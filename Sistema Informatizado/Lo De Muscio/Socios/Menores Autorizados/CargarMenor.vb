Public Class frmCargarMenor

    Dim sql As String
    Dim x As Integer
    Dim maxid As Integer
    Private Sub btnVolverCMenor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCMenor.Click
        txtApeMenor.Text = ""
        txtIdSocioMenor.Text = ""
        txtMontoMenor.Text = ""
        txtNomMenor.Text = ""
        Me.Hide()
        frmSocios.Show()

    End Sub

    Private Sub btnCargarMenor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarMenor.Click

        If txtNomMenor.Text <> "" And txtApeMenor.Text <> "" And txtIdSocioMenor.Text <> "" And txtMontoMenor.Text <> "" Then
            sql = "select count(*) from socios where idsocio = " & txtIdSocioMenor.Text & " and estado = 1"
            cargar1(sql)
            While rs1.Read = True
                If rs1(0) <> 0 Then
                    x = MsgBox("Los datos son correctos?" & vbCrLf & "Nombre: " & txtNomMenor.Text & vbCrLf & "Apellido: " & txtApeMenor.Text & vbCrLf & "ID socio: " & txtIdSocioMenor.Text & vbCrLf & "Monto: " & txtMontoMenor.Text, MsgBoxStyle.YesNo)
                    If x = 6 Then
                        sql = "insert into autorizaciones values ('','" & txtNomMenor.Text & "','" & txtApeMenor.Text & "'," & txtIdSocioMenor.Text & "," & txtMontoMenor.Text & "," & txtMontoMenor.Text & ")"
                        cargar(sql)
                        MsgBox("Menor Autorizado correctamente")

                        sql = "select max(idA) from autorizaciones "
                        cargar(sql)
                        While rs.Read = True
                            maxid = rs(0)
                        End While
                        AutorizacionMenor.lblAutorizacion.Text = maxid
                        AutorizacionMenor.lblNombre.Text = " " & txtNomMenor.Text & "  " & txtApeMenor.Text & " "
                        sql = "select nombre, apellido from socios where idsocio = " & txtIdSocioMenor.Text
                        cargar(sql)
                        While rs.Read = True
                            AutorizacionMenor.lblMayor.Text = " " & rs(0).ToString & "  " & rs(1).ToString & " "
                        End While

                        Me.Hide()
                        AutorizacionMenor.Show()

                        txtApeMenor.Text = ""
                        txtIdSocioMenor.Text = ""
                        txtMontoMenor.Text = ""
                        txtNomMenor.Text = ""
                    End If
                Else
                    MsgBox("Socio no encontrado!")
                End If
            End While
 
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txtIdSocioMenor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdSocioMenor.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtMontoMenor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoMenor.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Class