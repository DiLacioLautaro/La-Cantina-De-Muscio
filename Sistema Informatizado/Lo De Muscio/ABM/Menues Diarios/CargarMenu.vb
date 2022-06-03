Imports System.Data.Odbc
Public Class CargarMenu
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
    Dim idprod As Integer
    Dim nombreprod As String
    Dim cantped As Integer
    Dim pu As Integer
    Dim idcom As Integer
    Dim sinstock As Boolean
    Dim nombrecom As String
    Dim nuevoengrilla As Boolean
    Dim noexisteningped As Boolean
    Dim id As Integer
    Dim nombre As String
    Dim maxidcomanda As Integer
    Dim submonto As Integer
    Dim monto As Integer
    Public parallevar As Boolean
    Dim idmenu As Integer
    Dim tipo As String
    Dim x As Integer
    Dim tabla As Integer



    Private Sub txtBuscarCom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from comidas where Nombrecomida like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvComidas.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from comidas"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvComidas.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub txtBuscarProd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarProd.TextChanged
        If txtBuscarProd.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from productos where Nombreproducto like '%" & txtBuscarProd.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvProductos.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from productos"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvProductos.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub cbxDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxDia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub cbxDia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxDia.TextChanged
        lblDia.Text = cbxDia.Text

        sql = "truncate detallemenudiario1"
        cargar(sql)

        sql = "select * from detallemenudiario "
        cargar(sql)
        While rs.Read = True
            sql = "insert into detallemenudiario1 values ('" & rs(0) & "'," & rs(1) & ",'" & rs(2) & "'," & rs(3) & ",'" & rs(4) & "','" & rs(5) & "'," & rs(6) & ") "
            cargar1(sql)
        End While

        ds1.Tables.Clear()
        sql = "select concepto,cantidad,tipo from detallemenudiario1 where dia = '" & cbxDia.Text & "'"
        cargar(sql)
        ds1.Tables.Add("XX")
        da1 = New OdbcDataAdapter(sql, cnn)
        da1.Fill(ds1.Tables("XX"))
        Me.dgvMenuDiario.DataSource = ds1.Tables("XX")

        sql = "select idmenu,nombremenu,precio from menudiario where dia = '" & cbxDia.Text & "'"
        cargar(sql)
        While rs.Read = True
            idmenu = rs(0)
            txtNombre.Text = rs(1).ToString
            If rs(2) = 0 Then
                txtPrecio.Text = ""
            Else
                txtPrecio.Text = rs(2)
            End If

        End While
        dgvComidas.Enabled = True
        dgvProductos.Enabled = True
    End Sub

    Private Sub dgvProductos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Try
            ds.Tables.Clear()
            idprod = dgvProductos.Rows(e.RowIndex).Cells("Idprod").Value
            nombreprod = dgvProductos.Rows(e.RowIndex).Cells("Nombreproducto").Value.ToString()
            sql = "select idprod,Nombreproducto from productos where idprod = " & idprod
            cargar(sql)
            While rs.Read = True
                sql = "select count(*) from detallemenudiario1 where concepto = '" & rs(1) & "' and tipo = 'PROD' and dia = '" & cbxDia.Text & "'"
                cargar1(sql)
                While rs1.Read = True
                    If rs1(0) = 0 Then
                        sql = "insert into detallemenudiario1 values (''," & idmenu & ",'" & rs(1).ToString & "',1,'PROD','" & cbxDia.Text & "'," & idprod & ")"
                        cargar(sql)
                    Else
                        sql = "update detallemenudiario1 set cantidad = cantidad + 1 where concepto = '" & rs(1) & "' and tipo = 'PROD' and dia = '" & cbxDia.Text & "'"
                        cargar(sql)
                    End If
                End While
            End While

            ds.Tables.Clear()
            sql = "select concepto,cantidad,tipo from detallemenudiario1 where dia = '" & cbxDia.Text & "'"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvMenuDiario.DataSource = ds.Tables("XX")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvComidas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComidas.CellClick
        Try
            ds.Tables.Clear()
            idcom = dgvComidas.Rows(e.RowIndex).Cells("idcom").Value
            nombrecom = dgvComidas.Rows(e.RowIndex).Cells("Nombrecomida").Value.ToString()
            sql = "select idcom,Nombrecomida from comidas where idcom = " & idcom
            cargar(sql)
            While rs.Read = True
                sql = "select count(*) from detallemenudiario1 where concepto = '" & rs(1) & "' and tipo = 'COM' and dia = '" & cbxDia.Text & "'"
                cargar1(sql)
                While rs1.Read = True
                    If rs1(0) = 0 Then
                        sql = "insert into detallemenudiario1 values (''," & idmenu & ",'" & rs(1).ToString & "',1,'COM','" & cbxDia.Text & "'," & idcom & ")"
                        cargar(sql)
                    Else
                        sql = "update detallemenudiario1 set cantidad = cantidad + 1 where concepto = '" & rs(1) & "' and tipo = 'COM' and dia = '" & cbxDia.Text & "'"
                        cargar(sql)
                    End If
                End While
            End While

            ds.Tables.Clear()
            sql = "select concepto,cantidad,tipo from detallemenudiario1 where dia = '" & cbxDia.Text & "'"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvMenuDiario.DataSource = ds.Tables("XX")
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dgvMenuDiario_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenuDiario.CellClick
        Try
            ds2.Tables.Clear()
            dgvMenuDiario.ClearSelection()

            tipo = dgvMenuDiario.Rows(e.RowIndex).Cells("tipo").Value.ToString()
            nombre = dgvMenuDiario.Rows(e.RowIndex).Cells("concepto").Value.ToString()


            sql = "update detallemenudiario1 set cantidad = cantidad - 1 where concepto = '" & nombre & "' and tipo = '" & tipo & "' and dia = '" & cbxDia.Text & "'"
            cargar1(sql)

            sql = "delete from detallemenudiario1 where cantidad = 0"
            cargar(sql)

            ds.Tables.Clear()
            sql = "select concepto,cantidad,tipo from detallemenudiario1 where dia = '" & cbxDia.Text & "'"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvMenuDiario.DataSource = ds.Tables("XX")
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub btnCargarMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargarMenu.Click
        

            If cbxDia.Text <> "" And txtNombre.Text <> "" And txtPrecio.Text <> "" Then
            If txtPrecio.Text > 0 Then
                sql = "select count(*) from detallemenudiario1 where dia = '" & cbxDia.Text & "'"
                cargar(sql)
                While rs.Read = True
                    tabla = rs(0)
                End While
                If tabla <> 0 Then
                    x = MsgBox("Esta seguro que quiere modificar el menu del dia " & cbxDia.Text & " ?", MsgBoxStyle.YesNo)
                    If x = 6 Then


                        sql = "truncate table detallemenudiario"
                        cargar(sql)

                        sql = "select * from detallemenudiario1 "
                        cargar(sql)
                        While rs.Read = True
                            sql = "insert into detallemenudiario values ('" & rs(0) & "'," & rs(1) & ",'" & rs(2) & "'," & rs(3) & ",'" & rs(4) & "','" & rs(5) & "'," & rs(6) & ") "
                            cargar1(sql)
                        End While

                        sql = "update menudiario set nombremenu = '" & txtNombre.Text & "'  where dia = '" & cbxDia.Text & "'"
                        cargar(sql)

                        sql = "update menudiario set precio = " & txtPrecio.Text & "  where dia = '" & cbxDia.Text & "'"
                        cargar(sql)

                        MsgBox("Menu del dia " & cbxDia.Text & " Cargado Correctamente!")

                        cbxDia.Text = ""

                        txtNombre.Text = ""
                        txtPrecio.Text = ""

                        dgvComidas.ClearSelection()
                        dgvProductos.ClearSelection()
                        dgvMenuDiario.ClearSelection()

                    End If
                Else
                    MsgBox("El menú debe tener al menos un ingrediente/producto!", MsgBoxStyle.Critical)

                End If
            Else
                MsgBox("El precio debe ser mayor a 0", MsgBoxStyle.Critical)


            End If
        Else
            MsgBox("Completar los espacios vacios!", MsgBoxStyle.Critical)
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmABM.Show()

        cbxDia.Text = ""

        txtNombre.Text = ""
        txtPrecio.Text = ""

        dgvComidas.ClearSelection()
        dgvProductos.ClearSelection()
        dgvMenuDiario.ClearSelection()

        sql = "drop table detallemenudiario1"
        cargar(sql)

    End Sub


    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
       If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class