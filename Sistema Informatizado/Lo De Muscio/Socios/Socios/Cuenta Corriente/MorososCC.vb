Imports System.Data.Odbc
Public Class MorososCC
    Dim sql As String
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public da1 As OdbcDataAdapter
    Public ds2 As New DataSet
    Public da2 As OdbcDataAdapter
    Dim ds2v As New DataSet
    Dim da2v As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Public da As OdbcDataAdapter

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text <> "" And cbxBuscarPor.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from morosos where " & cbxBuscarPor.Text & " like '%" & txtBuscar.Text & "%' "
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvMorosos.DataSource = dsbu.Tables("XX")

        ElseIf cbxBuscarPor.Text = "" Or txtBuscar.Text = "" Then
            ds.Tables.Clear()

            sql = "select * from morosos"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvMorosos.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmSocios.Show()
        txtBuscar.Text = ""
        cbxBuscarPor.Text = ""
    End Sub

   
    Private Sub dgvMorosos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMorosos.CellContentClick

    End Sub

    Private Sub cbxBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxBuscarPor.SelectedIndexChanged

    End Sub
End Class