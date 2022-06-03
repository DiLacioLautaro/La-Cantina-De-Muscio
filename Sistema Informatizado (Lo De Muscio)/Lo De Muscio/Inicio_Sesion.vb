Imports System.Data.Odbc
Public Class Inicio_Sesion
    Dim sql As String
    Public sqlid As String
    Public rsid As OdbcDataReader
    Public UsuarioActual As String
    Public permiso As String


    Private Sub btnIngresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        If txtUsuario.Text = "" Or txtContraseña.Text = "" Then
            MsgBox("No deje campos vacios", MsgBoxStyle.Exclamation, "error")
        Else
            sql = "select count(*) from usuarios where usuario='" & txtUsuario.Text & "' and password='" & txtContraseña.Text & "'"
            Call Modulo.cargar(sql)
            While Modulo.rs.Read = True
                If Modulo.rs(0) = 0 Then
                    MsgBox("Los datos son incorrectos.", MsgBoxStyle.Exclamation, "error")
                Else
                    UsuarioActual = txtUsuario.Text
                    sql = "Select permisos from usuarios where usuario='" & txtUsuario.Text & "' and password='" & txtContraseña.Text & "'"
                    cargar(sql)
                    While rs.Read = True
                        permiso = rs(0).ToString
                        If rs(0).ToString = "Admin" Then
                            Modulo.admin = True

                        End If
                    End While
                    sqlid = "select idusuario from usuarios where usuario='" & txtUsuario.Text & "' and password='" & txtContraseña.Text & "'"
                    cmd = New OdbcCommand(sqlid, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rsid = cmd.ExecuteReader()
                    cmd.Dispose()
                    rsid.Read()

                    Modulo.Tipoempleado = permiso
                    Modulo.user = txtUsuario.Text

                    Me.Hide()
                    frmMenuP.Show()

                End If

            End While

        End If
    End Sub

    Private Sub Inicio_Sesion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cnn = New OdbcConnection("DSN=cantinademuscio")
            cnn.Open()
            MsgBox("Conexion Satisfactoria")
        Catch ex As Exception
            MsgBox("Fallo la conexion")
        End Try
        txtContraseña.Text = "123"
        txtUsuario.Text = "test"

    End Sub

    Private Sub btnVer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVer.MouseLeave
        txtContraseña.UseSystemPasswordChar = True
    End Sub


  

    Private Sub btnVer_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnVer.MouseMove
        txtContraseña.UseSystemPasswordChar = False
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
