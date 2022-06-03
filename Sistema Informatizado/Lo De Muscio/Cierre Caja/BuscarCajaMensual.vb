Imports System.Data.Odbc
Public Class BuscarCajaMensual
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
    Private Sub BuscarCajaMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        CierreMensual.Show()
        txtBuscar.Text = ""
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from caja_mensual where mes like '%" & txtBuscar.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvCajaMensual.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from caja_diaria"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvCajaMensual.DataSource = ds.Tables("XX")
        End If
    End Sub
End Class