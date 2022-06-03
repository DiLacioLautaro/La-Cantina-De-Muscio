Public Class frmUsuarios

    Private Sub btnVolverUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverUsuarios.Click
        Me.Hide()
        frmMenuP.Show()

    End Sub

    Private Sub btnRegUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegUsuario.Click
        Me.Hide()
        frmRegisUser.Show()

    End Sub

    Private Sub btnCambiarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarContraseña.Click
        Me.Hide()
        frmCambCon.Show()

    End Sub

    Private Sub btnEliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarUsuario.Click
        Me.Hide()
        frmBorrarUser.Show()

    End Sub

    Private Sub btnCambiarPerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPerm.Click
        Me.Hide()
        frmCamPerm.Show()

    End Sub

    Private Sub frmUsuarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado

        If Modulo.Tipoempleado = "Admin" Then
            btnCambiarContraseña.Enabled = True
            btnCambiarPerm.Enabled = True
            btnEliminarUsuario.Enabled = True
            btnRegUsuario.Enabled = True
        Else
            btnCambiarContraseña.Enabled = True
            btnCambiarPerm.Enabled = False
            btnEliminarUsuario.Enabled = False
            btnRegUsuario.Enabled = False

        End If
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class