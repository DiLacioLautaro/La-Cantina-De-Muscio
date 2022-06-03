
Imports System.Data.Odbc

Public Class frmBorProvP

    Dim x As Integer
    Dim sql As String
    Dim sql2 As String
    Dim dsprov As New DataSet
    Dim daprov As OdbcDataAdapter
    Dim dsprod As New DataSet
    Dim daprod As OdbcDataAdapter
    Dim id As Integer
    Dim id2 As Integer
    Dim idprod As Integer
    Dim prec As String


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmABM.Show()
    End Sub


    Private Sub frmBorProvP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsprov.Tables.Clear()
        sql = "select * from proveedor where estado=1"
        cargar(sql)
        dsprov.Tables.Add("XX")
        daprov = New OdbcDataAdapter(sql, cnn)
        daprov.Fill(dsprov.Tables("XX"))
        Me.dgvProvBorPP.DataSource = dsprov.Tables("XX")
    End Sub

    Private Sub dgvProvCarPP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProvBorPP.CellClick
        Try
            id = dgvProvBorPP.Rows(e.RowIndex).Cells("idproveedor").Value
            MsgBox("Proveedor seleccionado: " & dgvProvBorPP.Rows(e.RowIndex).Cells("nombre").Value)


            id2 = id

            dsprod.Tables.Clear()
            sql = "select * from productos where idprod in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvProdBorPP.DataSource = dsprod.Tables("XD")

            txtBusProd.Enabled = True
            dgvProdBorPP.Enabled = True
            btnBorrar.Enabled = True
        Catch ex As Exception

        End Try
       
    End Sub


    Private Sub dgvProdBorPP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProdBorPP.CellClick
        Try
            idprod = dgvProdBorPP.Rows(e.RowIndex).Cells("idprod").Value
            MsgBox("Producto seleccionado: " & dgvProdBorPP.Rows(e.RowIndex).Cells("nombreproducto").Value)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If idprod <> 0 Then
            x = MsgBox("Desea borrar el producto?", MsgBoxStyle.YesNo)
            If x = 6 Then

                sql = "delete from proveedorproductos where idproveedor=" & id2 & " and idprod=" & idprod
                cargar(sql)
                MsgBox("Producto de proveedor eliminado")

                dsprod.Tables.Clear()
                sql = "select * from productos where idprod in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
                cargar(sql)
                dsprod.Tables.Add("XD")
                daprod = New OdbcDataAdapter(sql, cnn)
                daprod.Fill(dsprod.Tables("XD"))
                Me.dgvProdBorPP.DataSource = dsprod.Tables("XD")

                txtBusProd.Text = ""
                txtBusProv.Text = ""


            End If
        Else
            MsgBox("SELECCIONE UN PRODUCTO", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtBusProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusProv.TextChanged
        If txtBusProv.Text <> "" Then

            dsprov.Tables.Clear()
            sql = "select * from proveedor where estado=1 and nombre like '%" & txtBusProv.Text & "%'"
            cargar(sql)
            dsprov.Tables.Add("XX")
            daprov = New OdbcDataAdapter(sql, cnn)
            daprov.Fill(dsprov.Tables("XX"))
            Me.dgvProvBorPP.DataSource = dsprov.Tables("XX")

        Else

            dsprov.Tables.Clear()
            sql = "select * from proveedor where estado=1"
            cargar(sql)
            dsprov.Tables.Add("XX")
            daprov = New OdbcDataAdapter(sql, cnn)
            daprov.Fill(dsprov.Tables("XX"))
            Me.dgvProvBorPP.DataSource = dsprov.Tables("XX")

        End If

    End Sub

    Private Sub txtBusProd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusProd.TextChanged
        If txtBusProd.Text <> "" Then

            dsprod.Tables.Clear()
            sql = "select * from productos where nombreproducto like '%" & txtBusProd.Text & "%' and idprod in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvProdBorPP.DataSource = dsprod.Tables("XD")

        Else

            dsprod.Tables.Clear()
            sql = "select * from productos where idprod in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvProdBorPP.DataSource = dsprod.Tables("XD")

        End If
    End Sub
End Class