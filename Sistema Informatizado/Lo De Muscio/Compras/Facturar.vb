Imports System.Data.Odbc
Public Class Facturar
    Dim sql As String
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim da1 As OdbcDataAdapter
    Dim ds2 As New DataSet
    Dim da2 As OdbcDataAdapter
    Dim ds2v As New DataSet
    Dim da2v As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim da As OdbcDataAdapter
    Dim idprod As Integer
    Dim nombreprod As String
    Dim cantkios As String
    Dim idprod1 As Integer
    Dim nombreprod1 As String
    Dim monto As Integer
    Dim change As Boolean
    Dim submonto As Integer
    Dim i As Integer = 0
    Dim idsocio As String
    Dim deuda As Boolean
    Dim montomenor As Integer
    Dim numauto As Integer
    Dim menor As Boolean
    Dim montopiola As Boolean
    Dim compraenab As Boolean
    Dim subttotal As Integer
    Dim maxticket As Integer
    Dim pu As Integer
    Dim hay As Boolean
    Dim banderap As Boolean

    Public servcom As Boolean

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCierreMesa.Click

    End Sub



    Private Sub rdbCC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCC.CheckedChanged
        If rdbCC.Checked = True Then

            btnSocioCC.Enabled = True
            lstCliente.Enabled = True
            btnConfirmarCompra.Enabled = False
            compraenab = False
            lblEfectivo.Visible = False
            txtEfectivo.Visible = False
            lblVueltovich.Visible = False
            lblVuelto.Visible = False
            txtEfectivo.Text = ""
            lblTotalll.Visible = False
            lblTotall.Visible = False
        Else

            btnSocioCC.Enabled = False
            lstCliente.Enabled = False
            btnConfirmarCompra.Enabled = False
        End If
    End Sub

    Private Sub btnSocioCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocioCC.Click
        Try
            idsocio = InputBox("Ingrese el numero de socio!")
            sql = "select count(*) from socios where idsocio = " & idsocio & " and estado = 1"
            cargar(sql)
            While rs.Read = True
                If rs(0) = 0 Then
                    MsgBox("SOCIO NO ENCONTRADO!", MsgBoxStyle.Critical)
                    btnConfirmarCompra.Enabled = False
                Else
                    lstCliente.Items.Clear()

                    MsgBox("Socio Encontrado!")
                    menor = False
                    sql = "Select nombre,apellido,deuda from socios where idsocio =" & idsocio
                    cargar1(sql)
                    While rs1.Read = True
                        If rs1(2) = 1 Then
                            lstCliente.Items.Add(" " & rs1(0) & " " & rs1(1) & " (Con Deuda)")
                            deuda = True
                            btnConfirmarCompra.Enabled = False
                            compraenab = False
                        Else
                            lstCliente.Items.Add(" " & rs1(0) & " " & rs1(1) & " (Sin Deuda) ")
                            deuda = False
                            btnConfirmarCompra.Enabled = True
                            compraenab = True

                        End If
                    End While
                End If
            End While

        Catch ex As Exception
            If idsocio <> "" Then
                MsgBox("SOLO SE PUEDEN INGRESAR VALORES NUMERICOS", MsgBoxStyle.Critical)
            Else

            End If
        End Try


    End Sub

    Private Sub rdbEfe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbEfe.CheckedChanged
        If rdbEfe.Checked = True Then
            btnConfirmarCompra.Enabled = True
            lstCliente.Items.Clear()
            compraenab = True
            idsocio = 0
            lblEfectivo.Visible = True
            txtEfectivo.Visible = True
            lblTotall.Visible = True
            lblVuelto.Visible = True
            lblVuelto.Text = ""
            banderap = False

            monto = 0
            sql = "select * from mesacon" & lblNumesa.Text
            cargar(sql)
            While rs.Read = True
                monto = monto + rs(3) * rs(5)
            End While

            lblTotalll.Text = monto
            lblTotalll.Visible = True


        End If
    End Sub

    Private Sub btnConfirmarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarCompra.Click
        monto = 0
        sql = "select * from mesacon" & lblNumesa.Text
        cargar(sql)
        While rs.Read = True
            monto = monto + rs(3) * rs(5)
        End While


        If idsocio = 0 Then 'EFECTIVO'
            If txtEfectivo.Text <> "" And Val(txtEfectivo.Text) >= Val(monto) Then

                sql = "insert into ingresos values(''," & monto & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','VENTA_SERVICIOCOMIDAS')"
                cargar(sql)
                frmTicketFactura.lstCantidad.Items.Clear()

                frmTicketFactura.lblFechaTicket.Text = Date.Today
                frmTicketFactura.lblFormaPago.Text = "EFECTIVO"
                frmTicketFactura.TextBox1.Text = monto
                sql = "select * from mesacon" & lblNumesa.Text
                cargar1(sql)
                While rs1.Read = True
                    subttotal = rs1(3) * rs1(5)
                    frmTicketFactura.lstSubtotal.Items.Add((subttotal).ToString)
                    frmTicketFactura.lstPrecio.Items.Add((rs1(5)).ToString)


                    frmTicketFactura.lstProductos.Items.Add((rs1(2)).ToString)
                    frmTicketFactura.lstCantidad.Items.Add((rs1(3)).ToString)
                End While
                frmTicketFactura.lblHoraTicket.Text = TimeOfDay

                frmTicketFactura.lblFechaTicket.Text = Date.Today
                sql = "select max(idticketfactura) from ticketfactura"
                cargar(sql)
                While rs.Read = True
                    frmTicketFactura.lblNumTicket.Text = Val(rs(0)) + 1
                End While
                banderap = True
                frmTicketFactura.lbla.Visible = True
                frmTicketFactura.lblvuelto.Visible = True
                frmTicketFactura.lblAbonado.Visible = True
                frmTicketFactura.lblv.Visible = True
                frmTicketFactura.lblAbonado.Text = txtEfectivo.Text
                frmTicketFactura.lblvuelto.Text = lblVuelto.Text
                frmTicketFactura.TextBox1.Text = monto
                frmTicketFactura.lblSocio.Visible = False
                frmTicketFactura.Label6.Visible = False
                lblTotall.Visible = False
                lblTotalll.Visible = False
                lblVuelto.Visible = False
                lblVueltovich.Visible = False
                sql = "insert into ticketfactura values (''," & monto & ",'EFE','" & Format(Date.Today, "yyyy/MM/dd") & "')"
                cargar(sql)
                sql = "select max(idticketfactura) from ticketfactura"
                cargar(sql)
                While rs.Read = True
                    maxticket = rs(0)
                End While
                sql = "select * from mesacon" & lblNumesa.Text
                cargar(sql)
                While rs.Read = True

                    subttotal = rs(3) * rs(5)

                    sql = "insert into filaticketfactura values (''," & maxticket & ",'" & (rs(2)).ToString & "'," & rs(3) & "," & rs(5) & "," & subttotal & ")"
                    cargar1(sql)


                End While



                Me.Hide()
                frmTicketFactura.Show()
                servcom = True

                rdbCC.Checked = False
                rdbEfe.Checked = False
                lstCliente.Items.Clear()


                If lblNumesa.Text = 0 Then
                    CrearComanda.lblParaLlevar.Visible = False
                    lblParaLlevar.Visible = False
                Else
                    Mesass.Controls("btnMesa" & lblNumesa.Text).BackColor() = Color.Lime
                End If

                sql = "drop table mesacon" & lblNumesa.Text
                cargar(sql)

                lblEfectivo.Visible = False
                txtEfectivo.Visible = False
                lblVueltovich.Visible = False
                lblVuelto.Visible = False
                txtEfectivo.Text = ""
            Else
                MsgBox("Ingrese el efectivo de forma correcta!")
            End If
        Else 'CUENTA CORRIENTE'
            sql = "update cuentacorriente set monto = monto +" & monto & " where idsocio = " & idsocio
            cargar(sql)


            frmTicketFactura.lstCantidad.Items.Clear()
            frmTicketFactura.lblSocio.Text = idsocio
            frmTicketFactura.lblFechaTicket.Text = Date.Today
            frmTicketFactura.lblFormaPago.Text = "CC"
            frmTicketFactura.TextBox1.Text = monto

            sql = "select * from mesacon" & lblNumesa.Text
            cargar1(sql)
            While rs1.Read = True
                subttotal = rs1(3) * rs1(5)
                frmTicketFactura.lstSubtotal.Items.Add((subttotal).ToString)
                frmTicketFactura.lstPrecio.Items.Add((rs1(5)).ToString)


                frmTicketFactura.lstProductos.Items.Add((rs1(2)).ToString)
                frmTicketFactura.lstCantidad.Items.Add((rs1(3)).ToString)
            End While
            frmTicketFactura.lblHoraTicket.Text = TimeOfDay

            frmTicketFactura.lblFechaTicket.Text = Date.Today
            sql = "select max(idticketfactura) from ticketfactura"
            cargar(sql)
            While rs.Read = True
                frmTicketFactura.lblNumTicket.Text = Val(rs(0)) + 1
            End While
            frmTicketFactura.lbla.Visible = False
            frmTicketFactura.lblvuelto.Visible = False
            frmTicketFactura.lblAbonado.Visible = False
            frmTicketFactura.lblv.Visible = False
            banderap = False

            frmTicketFactura.TextBox1.Text = monto
            frmTicketFactura.lblSocio.Visible = True
            frmTicketFactura.Label6.Visible = True
            sql = "insert into ticketfactura values (''," & monto & ",'CC','" & Format(Date.Today, "yyyy/MM/dd") & "')"
            cargar(sql)
            sql = "select max(idticketfactura) from ticketfactura"
            cargar(sql)
            While rs.Read = True
                maxticket = rs(0)
            End While
            sql = "select * from mesacon" & lblNumesa.Text
            cargar(sql)
            While rs.Read = True

                subttotal = rs(3) * rs(5)

                sql = "insert into filaticketfactura values (''," & maxticket & ",'" & (rs(2)).ToString & "'," & rs(3) & "," & rs(5) & "," & subttotal & ")"
                cargar1(sql)


            End While

            servcom = True

            Me.Hide()
            frmTicketFactura.Show()

            rdbCC.Checked = False
            rdbEfe.Checked = False
            lstCliente.Items.Clear()

            If lblNumesa.Text = 0 Then
                CrearComanda.lblParaLlevar.Visible = False
                lblParaLlevar.Visible = False
            Else
                Mesass.Controls("btnMesa" & lblNumesa.Text).BackColor() = Color.Lime
            End If

            sql = "drop table mesacon" & lblNumesa.Text
            cargar(sql)

        End If
       

    End Sub

    Private Sub Facturar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
    End Sub

    Private Sub Facturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblTotall.Visible = False
        lblTotalll.Visible = False
        lblVuelto.Visible = False
        lblVueltovich.Visible = False

        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado

    End Sub

    Private Sub txtEfectivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEfectivo.TextChanged

        lblVuelto.Text = Val(txtEfectivo.Text) - Val(monto)
        If rdbCC.Checked = False And banderap = False Then
            lblVueltovich.Visible = True


        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class