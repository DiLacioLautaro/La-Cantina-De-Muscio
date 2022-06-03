Imports System.Data.Odbc

Public Class frmBorrarProd


    Dim x As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer



    Private Sub frmBorrarProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from productos"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvBorrarProd.DataSource = ds.Tables("XX")
    End Sub



    Private Sub dgvBorrarProd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrarProd.CellClick
        Try
            id = dgvBorrarProd.Rows(e.RowIndex).Cells("IdProd").Value
            MsgBox("Producto seleccionado: " & dgvBorrarProd.Rows(e.RowIndex).Cells("nombreproducto").Value)
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub btnBorrarProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarProd.Click
        If id <> 0 Then
            x = MsgBox("DESEA ELIMINAR EL PRODUCTO?", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "delete from proveedorproductos where idprod=" & id
                cargar(sql)
                sql = "delete from productos where idprod=" & id
                cargar(sql)
                MsgBox("Producto Eliminado")

                txtBuscar.Text = ""
                id = 0

                ds.Tables.Clear()
                sql = "select * from productos"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvBorrarProd.DataSource = ds.Tables("XX")
            End If
        Else
            MsgBox("No se seleccionó ningun producto", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnVolverBProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverBProd.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from productos where Nombreproducto like '%" & txtBuscar.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvBorrarProd.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from productos"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvBorrarProd.DataSource = ds.Tables("XX")
        End If

    End Sub
End Class