Public Class frmTicketFactura

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.visible = False
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.Hide()
        If Facturar.servcom = True Then
            Mesass.Show()
            Mesass.rdbMesa.Checked = False
            Mesass.rdbParaLlevar.Checked = False


        Else
            frmKiosco.Show()
        End If

        btnImprimir.Visible = True



        lstCantidad.Items.Clear()
        lstSubtotal.Items.Clear()
        lstProductos.Items.Clear()
        lstPrecio.Items.Clear()

    End Sub
End Class