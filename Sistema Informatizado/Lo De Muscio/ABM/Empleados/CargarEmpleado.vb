
Public Class frmCargarEmpleado

    Dim sql As String
    Dim x As Integer

    Private Sub btnVolverCargarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCargarEmpleado.Click
        Me.Close()
        frmABM.Show()
    End Sub





    Private Sub btnCargarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarEmpleado.Click
        If txtNombreEmpleado.Text <> "" And txtApellidoEmpleado.Text <> "" And txtDNIEmpleado.Text <> "" And txtTelefonoEmpleado.Text <> "" And cmbTipoEmpleado.Text <> "" Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNombreEmpleado.Text & vbCrLf & "apellido: " & txtApellidoEmpleado.Text & vbCrLf & "DNI: " & txtDNIEmpleado.Text & vbCrLf & "telefono: " & txtTelefonoEmpleado.Text & vbCrLf & "cargo: " & cmbTipoEmpleado.Text, MsgBoxStyle.YesNo)
            If x = 6 Then

                sql = "insert into empleados values ('','" & txtNombreEmpleado.Text & "','" & txtApellidoEmpleado.Text & "'," & txtDNIEmpleado.Text & ",'" & txtTelefonoEmpleado.Text & "','" & cmbTipoEmpleado.Text & "')"
                cargar(sql)
                txtNombreEmpleado.Text = ""
                txtApellidoEmpleado.Text = ""
                txtDNIEmpleado.Text = ""
                txtTelefonoEmpleado.Text = ""
                cmbTipoEmpleado.Text = ""
                MsgBox("El empleado se cargó exitosamente")
            End If

        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If


    End Sub


    Private Sub txtDNIEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNIEmpleado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDNIEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNIEmpleado.TextChanged

    End Sub
End Class