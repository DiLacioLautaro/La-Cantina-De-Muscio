Public Class AutorizacionMenor

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False

             PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.Hide()
        frmSocios.Show()

        btnImprimir.Visible = True

    End Sub
End Class