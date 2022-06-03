Imports System.Data.Odbc

Public Class frmRegisUser
    Dim x As Integer
    Dim sql As String
    Dim sql2 As String
    Dim rs2 As odbcdatareader

    Private Sub btnVolverCUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverRUser.Click
        txtConfCon.Text = ""
        txtConUser.Text = ""
        txtDniEmpUser.Text = ""
        txtNomUser.Text = ""
        cmbPermUser.Text = ""
        Me.Hide()
        frmUsuarios.Show()
    End Sub


    Private Sub btnRegisUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisUser.Click

        If txtNomUser.Text <> "" And txtConUser.Text <> "" And txtDniEmpUser.Text <> "" And txtConfCon.Text <> "" And cmbPermUser.Text <> "" Then
            sql = "select count(*), idempleado from empleados where dni=" & txtDniEmpUser.Text
            cargar(sql)
            rs.Read()
            If rs(0) > 0 Then

                sql2 = "select count(*) from usuarios where usuario='" & txtNomUser.Text & "'"
                cmd = New OdbcCommand(sql2, Modulo.cnn)
                cmd.CommandType = CommandType.Text
                rs2 = cmd.ExecuteReader()
                cmd.Dispose()

                rs2.Read()

                If rs2(0) < 1 Then
                    If txtConfCon.Text = txtConUser.Text Then
                        x = MsgBox("Desea Registrar El Usuario?", MsgBoxStyle.YesNo)
                        If x = 6 Then

                            sql = "insert into usuarios values ('','" & txtNomUser.Text & "'," & rs(1) & ",'" & txtConUser.Text & "','" & cmbPermUser.Text & "')"
                            cargar(sql)
                            txtNomUser.Text = ""
                            txtConUser.Text = ""
                            txtDniEmpUser.Text = ""
                            txtConfCon.Text = ""
                            cmbPermUser.Text = ""
                            MsgBox("Usuario Registrado Exitosamente!")
                        End If
                    Else
                        MsgBox("Las contraseñas NO COINCIDEN", MsgBoxStyle.Exclamation)
                        txtConUser.Text = ""
                        txtConfCon.Text = ""
                    End If
                Else
                    MsgBox("EL NOMBRE DE USUARIO YA ESTÁ EN USO, ELIJA OTRO", MsgBoxStyle.Critical)

                End If
            Else
                MsgBox("NO EXISTE NINGUN EMPLEADO CON ESE DNI", MsgBoxStyle.Critical)

            End If

        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If

    End Sub

End Class