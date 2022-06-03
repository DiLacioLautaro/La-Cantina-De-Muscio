Imports System.Data.Odbc

Public Class frmCargarProveedor

    Dim x As Integer
    Dim sql As String
    Public dniprov As Integer
    Dim sql2 As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim prec As String
    Dim idprov As Integer
    Dim rs3 As OdbcDataReader
    Dim rs2 As OdbcDataReader

    Private Sub btnVolverCProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCProveedor.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub btnCargarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarProv.Click
        If txtNomProv.Text <> "" And txtDNIProv.Text <> "" And txtDirProv.Text <> "" And txtTelProv.Text <> "" And txtPaisProv.Text <> "" Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNomProv.Text & vbCrLf & "Cuit: " & txtDNIProv.Text & vbCrLf & "telefono: " & txtTelProv.Text & vbCrLf & "Dirección: " & txtDirProv.Text & vbCrLf & "País: " & txtPaisProv.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "select count(*) from proveedor where cuit=" & txtDNIProv.Text
                cargar(sql)
                rs.Read()
                If rs(0) = 0 Then
                    sql = "insert into proveedor values ('','" & txtNomProv.Text & "'," & txtDNIProv.Text & ",'" & txtDirProv.Text & "','" & txtTelProv.Text & "','" & txtPaisProv.Text & "',1)"
                    cargar(sql)
                    dniprov = txtDNIProv.Text

                    MsgBox("El proveedor se cargó correctamente")


                    sql = "select idproveedor from proveedor where CUIT=" & dniprov
                    cmd = New OdbcCommand(sql, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rs3 = cmd.ExecuteReader()
                    cmd.Dispose()

                    rs3.Read()

                    ds.Tables.Clear()
                    sql = "select * from productos where idprod not in (select idprod from proveedorproductos where idproveedor=" & rs3(0) & ")"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvProd.DataSource = ds.Tables("XX")


                    sql = "select idproveedor from proveedor where CUIT=" & dniprov
                    cmd = New OdbcCommand(sql, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rs3 = cmd.ExecuteReader()
                    cmd.Dispose()

                    rs3.Read()


                    ds.Tables.Clear()
                    sql = "select * from ingredientes where idingr not in (select idingr from provingrediente where idproveedor=" & rs3(0) & ")"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvIng.DataSource = ds.Tables("XX")

                    txtBuscarIng.Enabled = True
                    txtBuscarProd.Enabled = True

                Else
                    MsgBox("EL CUIT INGRESADO YA EXISTE")
                End If
            End If



        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If



    End Sub

    Private Sub txtDNIProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNIProv.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscarIng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarIng.TextChanged
        If txtBuscarIng.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from ingredientes where idingr not in (select idingr from provingrediente where idproveedor=" & rs3(0) & ") and Nombreingr like '%" & txtBuscarIng.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvIng.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from ingredientes where idingr not in (select idingr from provingrediente where idproveedor=" & rs3(0) & ")"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvIng.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub txtBuscarProd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarProd.TextChanged
        If txtBuscarProd.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from productos where idprod not in (select idprod from proveedorproductos where idproveedor=" & rs3(0) & ") and Nombreproducto like '%" & txtBuscarProd.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvProd.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from productos where idprod not in (select idprod from proveedorproductos where idproveedor=" & rs3(0) & ")"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvProd.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub frmCargarProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtBuscarIng.Enabled = False
        txtBuscarProd.Enabled = False
    End Sub

    Private Sub dgvProd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProd.CellClick
        Try
            id = dgvProd.Rows(e.RowIndex).Cells("idprod").Value
            MsgBox("Producto seleccionado: " & dgvProd.Rows(e.RowIndex).Cells("Nombreproducto").Value)

            Try
                prec = InputBox("Ingrese el precio unitario del ingrediente")
                If prec > 0 Then
                    sql2 = "insert into proveedorproductos values(''," & rs3(0) & "," & id & "," & prec & ")"
                    cmd = New OdbcCommand(sql2, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rs2 = cmd.ExecuteReader()
                    cmd.Dispose()
                    MsgBox("Producto de proveedor cargado")
                    ds.Tables.Clear()
                    sql = "select * from productos where idprod not in (select idprod from proveedorproductos where idproveedor=" & rs3(0) & ")"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvProd.DataSource = ds.Tables("XX")
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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvIng_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIng.CellClick
        Try
            id = dgvIng.Rows(e.RowIndex).Cells("idingr").Value
            MsgBox("Ingrediente seleccionado: " & dgvIng.Rows(e.RowIndex).Cells("nombreingr").Value)

            Try
                prec = InputBox("Ingrese el precio POR KILO del ingrediente")
                If prec > 0 Then
                    sql2 = "insert into provingrediente values(''," & rs3(0) & "," & id & "," & prec & ")"
                    cmd = New OdbcCommand(sql2, Modulo.cnn)
                    cmd.CommandType = CommandType.Text
                    rs2 = cmd.ExecuteReader()
                    cmd.Dispose()
                    MsgBox("Ingrediente de proveedor cargado")
                    ds.Tables.Clear()
                    sql = "select * from ingredientes where idingr not in (select idingr from provingrediente where idproveedor=" & rs3(0) & ")"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvIng.DataSource = ds.Tables("XX")
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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDNIProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNIProv.TextChanged

    End Sub
End Class