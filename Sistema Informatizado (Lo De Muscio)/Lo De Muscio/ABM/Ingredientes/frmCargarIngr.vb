Public Class frmCargarIngr
    Dim x As Integer
    Dim sql As String
    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub btnCargarIngr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargarIngr.Click
        If txtNomIngr.Text <> "" And txtCant.Text <> "" And txtPuntoPedido.Text <> "" Then

            x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNomIngr.Text & vbCrLf & "cantidad: " & txtCant.Text & vbCrLf & "Punto De Pedido: " & txtPuntoPedido.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "select count(*) from ingredientes where nombreingr = '" & txtNomIngr.Text & "'"
                cargar1(sql)
                While rs1.Read = True
                    If rs1(0) >= 1 Then
                        MsgBox("INGREDIENTE YA EXISTENTE!", MsgBoxStyle.Critical)
                        txtNomIngr.Text = ""
                    Else
                        sql = "insert into ingredientes values ('','" & txtNomIngr.Text & "'," & txtCant.Text & "," & txtPuntoPedido.Text & ")"
                        cargar(sql)
                        txtNomIngr.Text = ""
                        txtPuntoPedido.Text = ""
                        txtCant.Text = ""
                        MsgBox("El Ingrediente se cargó correctamente")

                    End If

                End While

 
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPuntoPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPuntoPedido.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class