Imports System.Data.Odbc

Public Class frmBorProvIng

    Dim x As Integer
    Dim sql As String
    Dim sql2 As String
    Dim dsprov As New DataSet
    Dim daprov As OdbcDataAdapter
    Dim dsprod As New DataSet
    Dim daprod As OdbcDataAdapter
    Dim dsbupv As New DataSet
    Dim dabupv As OdbcDataAdapter
    Dim dsbupd As New DataSet
    Dim dapupd As OdbcDataAdapter
    Dim id As Integer
    Dim id2 As Integer
    Dim iding As Integer
    Dim prec As String

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmBorProvIng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsprov.Tables.Clear()
        sql = "select * from proveedor where estado=1"
        cargar(sql)
        dsprov.Tables.Add("XX")
        daprov = New OdbcDataAdapter(sql, cnn)
        daprov.Fill(dsprov.Tables("XX"))
        Me.dgvProvBorPI.DataSource = dsprov.Tables("XX")
    End Sub



    Private Sub dgvProvBorPI_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProvBorPI.CellClick
        Try
            id = dgvProvBorPI.Rows(e.RowIndex).Cells("idproveedor").Value
            MsgBox("Proveedor seleccionado: " & dgvProvBorPI.Rows(e.RowIndex).Cells("nombre").Value)

            id2 = id

            dsprod.Tables.Clear()
            sql = "select * from ingredientes where idingr in (select idingr from provingrediente where idproveedor=" & id2 & ")"
            cargar(sql)

            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvIngBorPI.DataSource = dsprod.Tables("XD")

            txtBusIng.Enabled = True
            dgvIngBorPI.Enabled = True
            btnCargar.Enabled = True
            iding = 0
        Catch ex As Exception

        End Try
        
    End Sub





    Private Sub dgvIngBorPI_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngBorPI.CellClick
        Try
            iding = dgvIngBorPI.Rows(e.RowIndex).Cells("idingr").Value
            MsgBox("Ingrediente seleccionado: " & dgvIngBorPI.Rows(e.RowIndex).Cells("nombreingr").Value)
        Catch ex As Exception

        End Try
       
    End Sub



    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        If iding <> 0 Then
            x = MsgBox("Desea borrar el ingrediente?", MsgBoxStyle.YesNo)
            If x = 6 Then

                sql = "delete from provingrediente where idproveedor=" & id2 & " and idingr=" & iding
                cmd = New OdbcCommand(sql, Modulo.cnn)
                cmd.CommandType = CommandType.Text
                rs = cmd.ExecuteReader()
                cmd.Dispose()
                MsgBox("Producto de proveedor borrado")

                dsprod.Tables.Clear()
                sql = "select * from ingredientes where idingr in (select idingr from provingrediente where idproveedor=" & id2 & ")"
                cargar(sql)
                dsprod.Tables.Add("XD")
                daprod = New OdbcDataAdapter(sql, cnn)
                daprod.Fill(dsprod.Tables("XD"))
                Me.dgvIngBorPI.DataSource = dsprod.Tables("XD")

                txtBusIng.Text = ""
                txtBusProv.Text = ""


            End If
        Else
            MsgBox("SELECCIONE UN INGREDIENTE", MsgBoxStyle.Critical)
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
            Me.dgvProvBorPI.DataSource = dsprov.Tables("XX")

        Else

            dsprov.Tables.Clear()
            sql = "select * from proveedor where estado=1"
            cargar(sql)
            dsprov.Tables.Add("XX")
            daprov = New OdbcDataAdapter(sql, cnn)
            daprov.Fill(dsprov.Tables("XX"))
            Me.dgvProvBorPI.DataSource = dsprov.Tables("XX")

        End If

    End Sub

    Private Sub txtBusIng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusIng.TextChanged
        If txtBusIng.Text <> "" Then
            dsprod.Tables.Clear()
            sql = "select * from ingredientes where nombreingr like '%" & txtBusIng.Text & "%' and idingr in (select idingr from provingrediente where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvIngBorPI.DataSource = dsprod.Tables("XD")
        Else
            dsprod.Tables.Clear()
            sql = "select * from ingredientes where idingr in (select idingr from provingrediente where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvIngBorPI.DataSource = dsprod.Tables("XD")
        End If

    End Sub
End Class