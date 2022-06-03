Imports System.Data.Odbc

Public Class frmCargarSer

    Dim x As Integer
    Dim sql As String

    Private Sub btnCargarSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarSer.Click
        If txtNomSer.Text <> "" And txtPrecioSer.Text <> "" Then
            x = MsgBox("los datos son correctos?" & vbCrLf & "nombre: " & txtNomSer.Text & vbCrLf & "precio: " & txtPrecioSer.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "insert into precioservicios values ('','" & txtNomSer.Text & "', " & txtPrecioSer.Text & ")"
                cargar(sql)
                txtNomSer.Text = ""
                txtPrecioSer.Text = ""
                MsgBox("servicio cargado correctamente")
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnVolverCSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCSer.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub txtPrecioSer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioSer.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class