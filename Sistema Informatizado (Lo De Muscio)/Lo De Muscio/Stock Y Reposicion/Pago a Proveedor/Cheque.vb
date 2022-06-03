Public Class Cheque

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirmadoPor.TextChanged

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        btnImprimir.Visible = True
        Me.Close()
        MenuStock.Show()

    End Sub
End Class