Imports System.Data.Odbc

Public Class frmCambCon

    Dim sql As String
    Dim sql2 As String
    Dim rs2 As OdbcDataReader

    Private Sub btnVolverRUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        txtConN.Text = ""
        txtConN2.Text = ""
        txtConV.Text = ""
        Me.Close()
        frmUsuarios.Show()
    End Sub


    Private Sub btnV_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnV1.MouseLeave
        txtConV.UseSystemPasswordChar = True
    End Sub


    Private Sub btnV_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnV1.MouseMove
        txtConV.UseSystemPasswordChar = False
    End Sub


    Private Sub btnV2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnV2.MouseLeave
        txtConN.UseSystemPasswordChar = True
    End Sub


    Private Sub btnV2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnV2.MouseMove
        txtConN.UseSystemPasswordChar = False
    End Sub

    Private Sub btnV3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnV3.MouseLeave
        txtConN2.UseSystemPasswordChar = True
    End Sub


    Private Sub btnV3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnV3.MouseMove
        txtConN2.UseSystemPasswordChar = False
    End Sub

    Private Sub frmCambCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtConV.UseSystemPasswordChar = True
        txtConN.UseSystemPasswordChar = True
        txtConN2.UseSystemPasswordChar = True

        sql = "select password from usuarios where idusuario=" & Inicio_Sesion.rsid(0) & ""
        cargar(sql)

        rs.Read()

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If txtConN.Text <> "" And txtConN2.Text <> "" And txtConV.Text <> "" Then
            If txtConV.Text = rs(0) Then
                If txtConN.Text = txtConN2.Text Then
                    sql2 = "update usuarios set password='" & txtConN.Text & "' where idusuario=" & Inicio_Sesion.rsid(0)
                    cmd = New OdbcCommand(sql2, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rs2 = cmd.ExecuteReader()
                    cmd.Dispose()

                    MsgBox("Contraseña modificada correctamente")

                    txtConN.Text = ""
                    txtConN2.Text = ""
                    txtConV.Text = ""


                    sql = "select password from usuarios where idusuario=" & Inicio_Sesion.rsid(0) & ""
                    cargar(sql)

                    rs.Read()


                Else
                    MsgBox("LAS CONTRASEÑAS NO COINCIDEN", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("LA CONTRASEÑA ACTUAL ES INCORRECTA", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If

    End Sub
End Class