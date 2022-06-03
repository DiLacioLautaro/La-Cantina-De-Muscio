Public Class Comanda
    Dim sql As String
 
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        btnImprimir.visible = False
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.Hide()
        If CrearComanda.parallevar = True Then
            Facturar.Show()
            Facturar.lblNumesa.Text = 0
            Facturar.lblParaLlevar.Visible = True
        Else
            Mesass.Show()
        End If


        btnImprimir.Visible = True
        lstDescr.Items.Clear()
        lslCantidades.Items.Clear()



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Comanda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Sql = "select idempleado from usuarios where usuario ='" & Modulo.user & "'"
        cargar(Sql)
        While rs.Read = True
            Sql = "select nombre,apellido from empleados where idempleado = '" & rs(0) & "'"
            cargar1(Sql)
            While rs1.Read = True
                lblBlank.Text = rs1(0) & " " & rs1(1)
            End While
        End While

    End Sub

    Private Sub Comanda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class