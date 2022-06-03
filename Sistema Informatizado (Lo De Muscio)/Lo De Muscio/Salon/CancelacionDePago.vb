Public Class CancelacionDePago
    Dim sql As String
    Dim fechaevento As Date
    Dim resultado As Integer
    Dim menosdos As String
    Public idreserva As Integer
    Dim idsocio As Integer
    Dim maxrecibo As Integer
    Dim socio As String


    Private Sub btnVerificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerificar.Click

        Try
            sql = "select count(*) from comprobantereserva where idcomprobantereserva =" & txtNumComprob.Text
            Modulo.cargar(sql)
            While rs.Read = True
                If rs(0) = 0 Then
                    MsgBox("El comprobante NO EXISTE", MsgBoxStyle.Exclamation)
                    txtNumComprob.Text = ""
                Else
                    sql = "select fechaevento, montoreserva, montototal,idreserva,idsocio from comprobantereserva where idcomprobantereserva =" & txtNumComprob.Text
                    Modulo.cargar1(sql)
                    While rs1.Read = True
                        idreserva = rs1(3)
                        fechaevento = rs1(0)
                        Format(fechaevento, "yyyy/MM/dd")
                        menosdos = DateDiff("d", Date.Today, fechaevento)
                        If menosdos >= 2 Then
                            MsgBox("Comprobante confirmado correctamente! ")
                            idsocio = rs1(4)
                            lblMontoTotal.Text = rs1(2)
                            lblMontoReserva.Text = rs1(1)
                            lblRestanteAPagar.Text = rs1(2) - rs1(1)
                            btnConfirmarCancelacion.Enabled = True
                        Else
                            MsgBox("FECHA TARDIA A CANCELAR PAGO" & vbCrLf & " (Las reservas se cancelan como minimo 2 dias antes)", MsgBoxStyle.Exclamation)
                            txtNumComprob.Text = ""

                        End If


                    End While

                End If

            End While
        Catch ex As Exception
            MsgBox("INGRESE EL NUMERO DEL COMPROBANTE DE RESERVA CORRECTAMENTE!")
            txtNumComprob.Text = ""
        End Try
        

    End Sub


    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        txtNumComprob.Text = ""
        lblMontoReserva.Text = ""
        lblMontoTotal.Text = ""
        lblRestanteAPagar.Text = ""
        btnConfirmarCancelacion.Enabled = False
        Me.Hide()
        SalonMenu.Show()

    End Sub

    Private Sub btnConfirmarCancelacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmarCancelacion.Click
        sql = "update reserva set pagado = 1 where idreserva = " & idreserva
        Modulo.cargar(sql)

  
        sql = "insert into ingresos values(''," & Val(lblRestanteAPagar.Text) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','CANCELACION_SALON')"
        cargar(sql)

        sql = "insert into recibo values (''," & Val(lblRestanteAPagar.Text) & ",' Cancelacion De Alquiler Salon', '" & Format(Date.Today, "yyyy/MM/dd") & "'," & idsocio & ")"
        cargar(sql)

        sql = "select max(idrecibo) from recibo "
        cargar(sql)
        While rs.Read = True
            maxrecibo = rs(0) + 1
        End While

        sql = "select nombre, apellido from socios where idsocio = " & idsocio
        cargar(sql)
        While rs.Read = True
            socio = rs(0).ToString & " " & rs(1).ToString
        End While

        ReciboSalon.lblMonto.Text = lblRestanteAPagar.Text
        ReciboSalon.lblMonto1.Text = lblRestanteAPagar.Text
        ReciboSalon.lblSocio.Text = socio
        ReciboSalon.lblConcepto.Text = "Cancelacion de Alquiler Salon"
        ReciboSalon.lblIdRecibo.Text = maxrecibo
        ReciboSalon.lblFecha.Text = Date.Today

        Me.Hide()
        ReciboSalon.Show()

        txtNumComprob.Text = ""
        lblMontoReserva.Text = ""
        lblMontoTotal.Text = ""
        lblRestanteAPagar.Text = ""
        btnConfirmarCancelacion.Enabled = False

    End Sub
End Class