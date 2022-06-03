Imports System.Data.Odbc
Public Class PuntoPedido
    Dim sql As String
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim da1 As OdbcDataAdapter
    Dim ds2 As New DataSet
    Dim da2 As OdbcDataAdapter
    Dim ds2v As New DataSet
    Dim da2v As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim idi As Integer
    Dim conceptoi As String
    Dim idp As Integer
    Dim conceptop As String
    Private Sub PuntoPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuStock.Show()
        lblCosa.Visible = False
        lstprecios.Items.Clear()
        lstProv.Items.Clear()

    End Sub

    Private Sub dgvProdPP_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProdPP.CellClick
        lblCosa.Visible = True
        lstprecios.Items.Clear()
        lstProv.Items.Clear()

        ds2.Tables.Clear()
        dgvProdPP.ClearSelection()

        idp = dgvProdPP.Rows(e.RowIndex).Cells("idv").Value
        conceptop = dgvProdPP.Rows(e.RowIndex).Cells("concepto").Value.ToString()

        lblCosa.Text = conceptop

        sql = "select idproveedor, precio from proveedorproductos where idprod = " & idp
        cargar(sql)
        While rs.Read = True
            sql = "select nombre from proveedor where idproveedor = " & rs(0)
            cargar1(sql)
            While rs1.Read = True
                lstProv.Items.Add(rs1(0).ToString)
                lstprecios.Items.Add("$" & rs(1) & " x U.")
            End While
        End While
    End Sub

    Private Sub dgvProdPP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProdPP.CellContentClick

    End Sub

    Private Sub lstprecios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstprecios.SelectedIndexChanged

    End Sub

    Private Sub dgvIngPP_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngPP.CellClick

        lblCosa.Visible = True
        lstprecios.Items.Clear()
        lstProv.Items.Clear()

        ds2.Tables.Clear()
        dgvIngPP.ClearSelection()

        idi = dgvIngPP.Rows(e.RowIndex).Cells("idv").Value
        conceptoi = dgvIngPP.Rows(e.RowIndex).Cells("concepto").Value.ToString()

        lblCosa.Text = conceptoi

        sql = "select idproveedor, precio from provingrediente where idingr = " & idi
        cargar(sql)
        While rs.Read = True
            sql = "select nombre from proveedor where idproveedor = " & rs(0)
            cargar1(sql)
            While rs1.Read = True
                lstProv.Items.Add(rs1(0).ToString)
                lstprecios.Items.Add("$" & rs(1) & " x KG")
            End While
        End While

    End Sub

    Private Sub lstProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProv.SelectedIndexChanged

    End Sub
End Class