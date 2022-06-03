Public Class Imprimir_ComprobanteReserva

    Private Sub btnImprimirYVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimirYVolver.Click
        btnImprimirYVolver.Visible = False

        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        SalonMenu.Show()
        Me.Hide()
        Reservas.lstCliente.Items.Clear()
        Reservas.txtNumSocio.Text = ""
        Reservas.txtCantHoras.Text = ""
        Reservas.txtCantInv.Text = ""
        Reservas.lblMonto.Text = ""
        Reservas.lblMontoReserva.Text = ""
        Reservas.btnCalcularMonto.Enabled = False
        Reservas.btnConfirmarReserva.Enabled = False
        Reservas.Calendario.Enabled = False
        Reservas.txtCantHoras.Enabled = False
        Reservas.txtCantInv.Enabled = False
        btnImprimirYVolver.Visible = True

    End Sub

End Class