Imports System.Data.Odbc
Public Class Pago_CC
    Dim sql As String
    Dim total As Integer
    Dim menos5 As Date
    Dim ultimopago As Date
    Dim mas10 As Date
    Dim deuda As Boolean
    Dim ultimo As Date
    Dim maxrecibo As Integer
    Dim nombre As String
    Dim socio As String

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click

        Try

        If txtIdSocio.Text = "" Then
            MsgBox("Ingrese un numero de socio primero!")
        Else
            lstDeuda.Items.Clear()
            lstIdSocio.Items.Clear()
            lstNombre.Items.Clear()

            sql = "select * , count(*) from socios where idsocio = " & txtIdSocio.Text & " and estado "
            cargar(sql)
            While rs.Read = True
                If rs(9) = 1 And rs(8) = 1 Then
                    MsgBox("Socio Encontrado!")
                    lstIdSocio.Items.Add(" " & rs(0))
                    lstNombre.Items.Add(" " & rs(1).ToString & " " & rs(2).ToString)
                    nombre = rs(1).ToString
                    If rs(4) = 0 Then 'SIN DEUDA
                        lstDeuda.Items.Add("SIN DEUDA")
                        deuda = False
                        sql = "select * from cuentacorriente where idsocio = " & txtIdSocio.Text
                        cargar1(sql)
                        While rs1.Read = True
                            total = rs1(1)
                            lblMes.Text = rs1(2).ToString
                        End While


                        lblTotal.Text = total
                        btnPagarCC.Enabled = True

                    Else 'CON DEUDA
                        deuda = True
                        lstDeuda.Items.Add("CON DEUDA")

                        sql = "select * from cuentacorriente where idsocio = " & txtIdSocio.Text
                        cargar1(sql)
                        While rs1.Read = True
                            total = rs1(1)
                            lblMes.Text = rs1(2).ToString
                        End While


                        lblTotal.Text = total
                        btnPagarCC.Enabled = True
                    End If
                Else
                    MsgBox("Socio No Encontrado!", MsgBoxStyle.Critical)

                End If


            End While
        End If
               Catch ex As Exception
            MsgBox("ERROR AL INGRESAR NUMERO DE SOCIO, INTENTE DENUEVO!")
            txtIdSocio.Text = ""
        End Try
    End Sub


    Private Sub btnPagarCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPagarCC.Click
        If deuda = True Then



            sql = "update socios set deuda = 0 where idsocio = " & txtIdSocio.Text
            cargar(sql)
            If Format(Date.Today, "dd") < 25 Then
                sql = "update cuentacorriente set mes = '" & Format(Date.Today, "MMMM") & "' where idsocio = " & txtIdSocio.Text
                cargar(sql)
            ElseIf Format(Date.Today, "dd") >= 25 Then
                Dim mas7 As Date = Date.Today.AddDays(7)
                sql = "update cuentacorriente set mes = '" & Format(mas7, "MMMM") & "' where idsocio = " & txtIdSocio.Text
                cargar(sql)
            End If
            sql = "update cuentacorriente set monto = 0 where idsocio = " & txtIdSocio.Text
            cargar(sql)

            sql = "update cuentacorriente set anio = " & Format(Date.Today, "yyyy") & " where idsocio = " & txtIdSocio.Text
            cargar1(sql)

            sql = "update autorizaciones set monto = 0 where idsocio = " & txtIdSocio.Text
            cargar(sql)



            MsgBox("Pago del mes " & lblMes.Text & " realizado correctamente!")
        Else
            mas10 = Date.Today.AddDays(10)
            sql = "update cuentacorriente set mes = '" & Format(mas10, "MMMM") & "' where idsocio = " & txtIdSocio.Text
            cargar(sql)
            sql = "update cuentacorriente set monto = 0 where idsocio = " & txtIdSocio.Text
            cargar(sql)
            sql = "update autorizaciones set monto = 0 where idsocio = " & txtIdSocio.Text
            cargar(sql)

            sql = "update cuentacorriente set anio = " & Format(Date.Today, "yyyy") & " where idsocio = " & txtIdSocio.Text
            cargar1(sql)

            MsgBox("Pago del mes " & lblMes.Text & " realizado correctamente!")
        End If

        sql = "insert into ingresos values (''," & lblTotal.Text & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','PagoCC Socio: " & nombre & "')"
        cargar(sql)
        sql = "insert into recibo values (''," & Val(lblTotal.Text) & ",' Pago CC del Mes " & lblMes.Text & " ', '" & Format(Date.Today, "yyyy/MM/dd") & "'," & txtIdSocio.Text & ")"
        cargar(sql)

        sql = "select max(idrecibo) from recibo "
        cargar(sql)
        While rs.Read = True
            maxrecibo = rs(0) + 1
        End While

        sql = "select nombre, apellido from socios where idsocio = " & txtIdSocio.Text
        cargar(sql)
        While rs.Read = True
            socio = rs(0).ToString & " " & rs(1).ToString
        End While

        ReciboCC.lblMonto.Text = lblTotal.Text
        ReciboCC.lblMonto1.Text = lblTotal.Text
        ReciboCC.lblSocio.Text = socio
        ReciboCC.lblConcepto.Text = "Pago CC del Mes " & lblMes.Text
        ReciboCC.lblIdRecibo.Text = maxrecibo
        ReciboCC.lblFecha.Text = Date.Today

        txtIdSocio.Text = ""
        lstIdSocio.Items.Clear()
        lstNombre.Items.Clear()
        lstDeuda.Items.Clear()
        lblMes.Text = ""
        lblTotal.Text = ""
        btnPagarCC.Enabled = False
        Me.Hide()
        ReciboCC.Show()

    End Sub

    Private Sub Pago_CC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmSocios.Show()
        txtIdSocio.Text = ""
        lstIdSocio.Items.Clear()
        lstNombre.Items.Clear()
        lstDeuda.Items.Clear()
        lblMes.Text = ""
        lblTotal.Text = ""
        btnPagarCC.Enabled = False
    End Sub
End Class