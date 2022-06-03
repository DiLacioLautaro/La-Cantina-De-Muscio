Imports System.Data.Odbc


Public Class frmCarProvI


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


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmCarProvI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsprov.Tables.Clear()
        sql = "select * from proveedor where estado=1"
        cargar(sql)
        dsprov.Tables.Add("XX")
        daprov = New OdbcDataAdapter(sql, cnn)
        daprov.Fill(dsprov.Tables("XX"))
        Me.dgvProvCarPI.DataSource = dsprov.Tables("XX")

    End Sub

    Private Sub dgvProvCarPI_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProvCarPI.CellClick
        Try
            id = dgvProvCarPI.Rows(e.RowIndex).Cells("idproveedor").Value
            MsgBox("Proveedor seleccionado: " & dgvProvCarPI.Rows(e.RowIndex).Cells("nombre").Value)

            id2 = id


            dsprod.Tables.Clear()
            sql = "select * from ingredientes where idingr not in (select idingr from provingrediente where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvIngCarPI.DataSource = dsprod.Tables("XD")

            txtBusIng.Enabled = True
            dgvIngCarPI.Enabled = True
            btnCargar.Enabled = True
            iding = 0

        Catch ex As Exception

        End Try

  
    End Sub




    Private Sub dgvIngCarPI_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngCarPI.CellClick
        Try
            iding = dgvIngCarPI.Rows(e.RowIndex).Cells("idingr").Value
            MsgBox("Ingrediente seleccionado: " & dgvIngCarPI.Rows(e.RowIndex).Cells("nombreingr").Value)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnCargar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click

        If iding <> 0 Then
            Try
                prec = InputBox("Ingrese el precio POR KILO del ingrediente")
                If prec > 0 Then

                    sql = "insert into provingrediente values(''," & id2 & "," & iding & "," & prec & ")"
                    cmd = New OdbcCommand(sql, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rs = cmd.ExecuteReader()
                    cmd.Dispose()
                    MsgBox("Producto de proveedor cargado")

                    dsprod.Tables.Clear()
                    sql = "select * from ingredientes where idingr not in (select idingr from provingrediente where idproveedor=" & id2 & ")"
                    cargar(sql)
                    dsprod.Tables.Add("XD")
                    daprod = New OdbcDataAdapter(sql, cnn)
                    daprod.Fill(dsprod.Tables("XD"))
                    Me.dgvIngCarPI.DataSource = dsprod.Tables("XD")

                    txtBusIng.Text = ""
                    txtBusProv.Text = ""



                ElseIf 0 > prec Then
                    MsgBox("EL INGREDIENTE NO PUEDE TENER PRECIO NEGATIVO!", MsgBoxStyle.Critical)
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
            MsgBox("SELECCIONE UN INGREDIENTE", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub txtBusProv_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusProv.TextChanged

        If txtBusProv.Text <> "" Then

            dsprov.Tables.Clear()
            sql = "select * from proveedor where estado=1 and nombre like '%" & txtBusProv.Text & "%'"
            cargar(sql)
            dsprov.Tables.Add("XX")
            daprov = New OdbcDataAdapter(sql, cnn)
            daprov.Fill(dsprov.Tables("XX"))
            Me.dgvProvCarPI.DataSource = dsprov.Tables("XX")

        Else

            dsprov.Tables.Clear()
            sql = "select * from proveedor where estado=1"
            cargar(sql)
            dsprov.Tables.Add("XX")
            daprov = New OdbcDataAdapter(sql, cnn)
            daprov.Fill(dsprov.Tables("XX"))
            Me.dgvProvCarPI.DataSource = dsprov.Tables("XX")

        End If

    End Sub

    Private Sub txtBusProd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusIng.TextChanged
        If txtBusIng.Text <> "" Then

            dsprod.Tables.Clear()
            sql = "select * from ingredientes where nombreingr like '%" & txtBusIng.Text & "%' and idingr not in (select idingr from provingrediente where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvIngCarPI.DataSource = dsprod.Tables("XD")

        Else

            dsprod.Tables.Clear()
            sql = "select * from ingredientes where idingr not in (select idingr from provingrediente where idproveedor=" & id2 & ")"
            cargar(sql)
            dsprod.Tables.Add("XD")
            daprod = New OdbcDataAdapter(sql, cnn)
            daprod.Fill(dsprod.Tables("XD"))
            Me.dgvIngCarPI.DataSource = dsprod.Tables("XD")

        End If

    End Sub

    Private Sub btnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmABM.Show()
    End Sub

End Class