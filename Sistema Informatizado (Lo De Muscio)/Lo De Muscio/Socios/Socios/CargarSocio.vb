Public Class frmCargarSocio

    Dim sql As String
    Dim x As Integer

    Private Sub btnVolverCSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCSocios.Click
        Me.Close()
        frmSocios.Show()
    End Sub

    Private Sub btnCargarSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarSocio.Click


        If txtIdSocio.Text <> "" And txtNomSocio.Text <> "" And txtApeSocio.Text <> "" And txtDNISocio.Text <> "" And txtLocSocio.Text <> "" And txtMailSocio.Text <> "" And txtTelSocio.Text <> "" Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNomSocio.Text & vbCrLf & "apellido: " & txtApeSocio.Text & vbCrLf & "DNI: " & txtDNISocio.Text & vbCrLf & "E-Mail: " & txtMailSocio.Text & vbCrLf & "telefono: " & txtTelSocio.Text & vbCrLf & "localidad: " & txtLocSocio.Text, MsgBoxStyle.YesNo)
            If x = 6 Then

                sql = "select count(*) from socios where idsocio=" & txtIdSocio.Text
                cargar(sql)
                rs.Read()

                If rs(0) < 1 Then
                    sql = "insert into socios values (" & txtIdSocio.Text & ",'" & txtNomSocio.Text & "','" & txtApeSocio.Text & "','" & txtTelSocio.Text & "',0," & txtDNISocio.Text & ",'" & txtMailSocio.Text & "','" & txtLocSocio.Text & "',1)"
                    cargar(sql)
                    sql = "insert into cuentacorriente values (" & txtIdSocio.Text & ",0,'" & Format(Date.Today, "MMMM") & "'," & Format(Date.Today, "yyyy") & ")"
                    cargar(sql)
                    txtApeSocio.Text = ""
                    txtDNISocio.Text = ""
                    txtLocSocio.Text = ""
                    txtMailSocio.Text = ""
                    txtNomSocio.Text = ""
                    txtTelSocio.Text = ""
                    txtIdSocio.Text = ""
                    MsgBox("El socio se cargó correctamente")
                Else
                    MsgBox("YA EXISTE UN SOCIO CON ESE ID", MsgBoxStyle.Critical)
                End If
                
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txtDNISocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNISocio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtTelSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelSocio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtIdSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdSocio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class