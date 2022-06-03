Public Class frmCargarProd

    Dim x As Integer
    Dim sql As String

    Private Sub btnVolverCProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCProd.Click
        Me.Close()
        frmABM.Show()
    End Sub



    Private Sub btnCargarProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarProd.Click
        If txtNomProd.Text <> "" And txtCantProd.Text <> "" And txtPUProd.Text <> "" And txtPP.Text <> "" Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "Nombre: " & txtNomProd.Text & vbCrLf & "Cantidad: " & txtCantProd.Text & vbCrLf & "Precio Unitario: " & txtPUProd.Text & vbCrLf & "Punto de Pedido: " & txtPP.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "insert into productos values ('','" & txtNomProd.Text & "'," & txtCantProd.Text & "," & txtPUProd.Text & "," & txtPP.Text & ")"
                cargar(sql)
                txtNomProd.Text = ""
                txtCantProd.Text = ""
                txtPUProd.Text = ""
                txtPP.Text = ""
                MsgBox("El producto se cargó correctamente")
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtCantProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantProd.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtPUProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPUProd.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtPP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtPP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPP.TextChanged

    End Sub
End Class