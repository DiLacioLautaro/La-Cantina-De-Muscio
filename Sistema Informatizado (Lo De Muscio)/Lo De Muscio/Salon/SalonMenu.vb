Public Class SalonMenu

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        frmMenuP.Show()
        Me.Hide()

    End Sub

    Private Sub btnReserva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReserva.Click
        Reservas.Show()
        Me.Hide()
    End Sub


    Private Sub btnCancelacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelacion.Click
        Me.Hide()
        CancelacionDePago.Show()

    End Sub

    Private Sub SalonMenu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
    End Sub

    Private Sub SalonMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class