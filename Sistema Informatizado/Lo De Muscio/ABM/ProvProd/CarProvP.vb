Imports System.Data.Odbc


Public Class frmCarProvP


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
    Dim idprod As Integer
    Dim prec As String


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmCarProvP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dsprov.Tables.Clear()
        sql = "select * from proveedor where estado=1"
        cargar(sql)
        dsprov.Tables.Add("XX")
        daprov = New OdbcDataAdapter(sql, cnn)
        daprov.Fill(dsprov.Tables("XX"))
        Me.dgvProvCarPP.DataSource = dsprov.Tables("XX")

    End Sub

    Private Sub dgvProvCarPP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProvCarPP.CellClick
        Try
            id = dgvProvCarPP.Rows(e.RowIndex).Cells("idproveedor").Value
            MsgBox("Proveedor seleccionado: " & dgvProvCarPP.Rows(e.RowIndex).Cells("nombre").Value)

            id2 = id


            dsprod.Tables.Clear()
            sql = "select * from productos where idprod not in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvProductosCarPP.DataSource = dsprod.Tables("XD")

            txtBusProd.Enabled = True
            dgvProductosCarPP.Enabled = True
            btnCargar.Enabled = True
        Catch ex As Exception

        End Try
          End Sub



    Private Sub dgvProductosCarPP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductosCarPP.CellClick
        Try
            idprod = dgvProductosCarPP.Rows(e.RowIndex).Cells("idprod").Value
            MsgBox("Producto seleccionado: " & dgvProductosCarPP.Rows(e.RowIndex).Cells("nombreproducto").Value)
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        If id <> 0 Then
            Try
                prec = InputBox("Ingrese el precio unitario del ingrediente")
                If prec > 0 Then
                    sql = "insert into proveedorProductos values(''," & id2 & "," & idprod & "," & prec & ")"
                    cmd = New OdbcCommand(sql, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rs = cmd.ExecuteReader()
                    cmd.Dispose()
                    MsgBox("Producto de proveedor cargado")

                    dsprod.Tables.Clear()
                    sql = "select * from productos where idprod not in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
                    cargar(sql)
                    dsprod.Tables.Add("XD")
                    daprod = New OdbcDataAdapter(sql, cnn)
                    daprod.Fill(dsprod.Tables("XD"))
                    Me.dgvProductosCarPP.DataSource = dsprod.Tables("XD")

                    txtBusProd.Text = ""
                    txtBusProv.Text = ""
                ElseIf 0 > prec Then
                    MsgBox("EL PRODUCTO NO PUEDE TENER PRECIO NEGATIVO!", MsgBoxStyle.Critical)
                ElseIf prec = 0 Then
                    MsgBox("EL PRECIO NO PUEDE SER NULO", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                If prec <> "" Then
                    MsgBox("SOLO SE PUEDEN INGRESAR VALORES NUMERICOS", MsgBoxStyle.Critical)
                Else

                End If

            End Try
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
            Me.dgvProvCarPP.DataSource = dsprov.Tables("XX")

        Else

            dsprov.Tables.Clear()
            sql = "select * from proveedor where estado=1"
            cargar(sql)
            dsprov.Tables.Add("XX")
            daprov = New OdbcDataAdapter(sql, cnn)
            daprov.Fill(dsprov.Tables("XX"))
            Me.dgvProvCarPP.DataSource = dsprov.Tables("XX")

        End If

    End Sub

    Private Sub txtBusProd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusProd.TextChanged
        If txtBusProd.Text <> "" Then

            dsprod.Tables.Clear()
            sql = "select * from productos where nombreproducto like '%" & txtBusProd.Text & "%' and idprod not in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvProductosCarPP.DataSource = dsprod.Tables("XD")

        Else

            dsprod.Tables.Clear()
            sql = "select * from productos where idprod not in (select idprod from proveedorproductos where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvProductosCarPP.DataSource = dsprod.Tables("XD")

        End If

    End Sub

    Private Sub btnVolver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver1.Click
        Me.Close()
        frmABM.Show()

    End Sub
End Class