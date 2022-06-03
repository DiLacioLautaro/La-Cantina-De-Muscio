Public Class Reservas
    Dim sql As String
    Dim deshab As Integer = 0
    Dim datee As Date
    Dim monto As Integer
    Dim montoreserva As Integer
    Public nombresocio As String
    Public nrocomp As Integer
    Public quincedias As Date
    Public resultado As Integer
    Public idreserva As Integer
    Dim precioinvitado As Integer
    Dim preciococina As Integer
    Dim preciohora As Integer
    Dim i As Integer

    Private Sub btnCargar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Try
            If txtNumSocio.Text <> "" Then
                lstCliente.Items.Clear()

                sql = "Select count(*) from Socios where idsocio = " & txtNumSocio.Text & " and estado = 1"
                Modulo.cargar(sql)
                While Modulo.rs.Read = True
                    If rs(0) > 0 Then
                        sql = "Select nombre, apellido , deuda from Socios where idsocio = " & txtNumSocio.Text & ""
                        Modulo.cargar1(sql)
                        While rs1.Read = True
                            If rs1(2) = 0 Then
                                lstCliente.Items.Add(rs1(0) & " " & rs1(1) & " (Sin deudas) ")
                                Calendario.Enabled = True
                                nombresocio = rs1(0) & " " & rs1(1)
                            Else
                                lstCliente.Items.Add(rs1(0) & " " & rs1(1) & " (Con deudas)")
                                Calendario.Enabled = False
                            End If

                        End While

                    Else
                        lstCliente.Items.Add("No existe el socio")
                        Calendario.Enabled = False
                    End If

                End While
            Else
                MsgBox("INGRESE UN NUMERO DE SOCIO!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("¡ INGRESE EL NUMERO DE SOCIO CORRECTAMENTE! ")
            txtNumSocio.Text = ""

        End Try


    End Sub


    Private Sub Calendario_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateSelected

        datee = Calendario.SelectionEnd.Date
        If datee > Date.Today Then
            sql = "Select count(*) from reserva where fecha = '" & Format(datee, "yyyy/MM/dd") & "'"


            Modulo.cargar(sql)



            While rs.Read = True
                quincedias = DateAdd(DateInterval.Day, 15, Date.Today)
                resultado = Date.Compare(datee, Format(quincedias, "yyyy/MM/dd"))
                If resultado > 0 Then
                    If rs(0) = 1 Then

                        MsgBox("FECHA YA RESERVADA, INGRESE OTRA")
                    Else

                        MsgBox("Fecha disponible")
                        txtCantHoras.Enabled = True
                    End If
                Else
                    MsgBox("La fecha se debe realizar con mas de 15 dias de anticipacion, Elegir otra fecha")

                End If
            End While
        Else
            MsgBox("NO SE ADMITEN FECHAS PASADAS ")
        End If

    End Sub

    Private Sub btnCalcularMonto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalcularMonto.Click
        Try
            If txtCantHoras.Text <> "" And txtCantInv.Text <> "" And txtNumSocio.Text <> "" Then
                If txtCantInv.Text > 80 Or Val(txtCantHoras.Text) > 12 Then
                    MsgBox("LA CANTIDAD DE PERSONAS NO PUEDE SUPERAR 80 y LA CANTIDAD DE HORAS A 12 !", MsgBoxStyle.Exclamation)
                Else
                    sql = "select * from precioservicios"
                    Modulo.cargar(sql)
                    While rs.Read = True
                        i = i + 1
                        If i = 1 Then
                            preciohora = rs(2)
                        ElseIf i = 2 Then
                            precioinvitado = rs(2)
                        ElseIf i = 3 Then
                            preciococina = rs(2)
                        End If
                    End While
                    monto = Val(txtCantHoras.Text) * preciohora + Val(txtCantInv.Text) * precioinvitado + preciococina
                    lblMonto.Text = monto
                    montoreserva = monto * 0.25
                    lblMontoReserva.Text = montoreserva

                    btnConfirmarReserva.Enabled = True
                End If
            Else
                MsgBox("COMPLETE ESPACIOS VACIOS!")
            End If

        Catch ex As Exception
            MsgBox("INGRESE VALORES CORRECTOS!")
        End Try

    End Sub

    Private Sub Reservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCantHoras_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantHoras.TextChanged
        txtCantInv.Enabled = True
    End Sub

    Private Sub txtCantInv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantInv.TextChanged
        btnCalcularMonto.Enabled = True
    End Sub

    Private Sub btnConfirmarReserva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmarReserva.Click

        sql = "insert into reserva values (''," & txtNumSocio.Text & ",'" & Format(datee, "yyyy/MM/dd") & "'," & txtCantHoras.Text & "," & lblMontoReserva.Text & "," & lblMonto.Text & "," & txtCantInv.Text & ",0)"

        cargar1(sql)

        MsgBox("Reserva Confirmada Correctamente")
        Me.Hide()
        Imprimir_ComprobanteReserva.Show()
        Imprimir_ComprobanteReserva.lblFechaevento.Text = Format(datee, "yyyy/MM/dd")
        Imprimir_ComprobanteReserva.lblFechareserva.Text = Format(Today, "yyyy/MM/dd")
        Imprimir_ComprobanteReserva.lblIdSocio.Text = txtNumSocio.Text
        Imprimir_ComprobanteReserva.lblMontoReserva.Text = lblMontoReserva.Text
        Imprimir_ComprobanteReserva.lblMontoTotal.Text = lblMonto.Text
        Imprimir_ComprobanteReserva.lblNombreSocio.Text = nombresocio

        sql = "select max(idcomprobantereserva) from comprobantereserva"
        cargar(sql)
        While rs.Read = True
            nrocomp = rs(0) + 1
            Imprimir_ComprobanteReserva.lblIDCOMPROBANTE.Text = nrocomp
        End While

        sql = "select max(idreserva) from reserva"
        cargar(sql)
        While rs.Read = True
            idreserva = rs(0)
        End While

        sql = "insert into ingresos values(''," & Val(lblMontoReserva.Text) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','RESERVA_SALON')"
        cargar(sql)

        sql = "insert into comprobantereserva values ('" & nrocomp & "'," & txtNumSocio.Text & ",'" & Format(Today, "yyyy/MM/dd") & "','" & Format(datee, "yyyy/MM/dd") & "'," & lblMontoReserva.Text & "," & lblMonto.Text & "," & idreserva & ")"
        cargar(sql)


    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        SalonMenu.Show()
        lstCliente.Items.Clear()
        txtNumSocio.Text = ""
        txtCantHoras.Text = ""
        txtCantInv.Text = ""
        lblMonto.Text = ""
        lblMontoReserva.Text = ""
        btnCalcularMonto.Enabled = False
        btnConfirmarReserva.Enabled = False
        Calendario.Enabled = False
        txtCantHoras.Enabled = False
        txtCantInv.Enabled = False

    End Sub

    Private Sub lstCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCliente.SelectedIndexChanged

    End Sub

    Private Sub lblMonto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMonto.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtNumSocio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumSocio.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblMontoReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMontoReserva.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class