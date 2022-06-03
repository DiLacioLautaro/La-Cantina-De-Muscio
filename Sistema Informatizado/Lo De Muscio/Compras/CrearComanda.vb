Imports System.Data.Odbc
Imports System.Globalization
Public Class CrearComanda
    Dim cambio As New Globalization.CultureInfo("es-ES")
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
    Dim nosepuede As Boolean
    Dim dia As String
    Dim idmenudiario As Integer
    Dim nombremenu As String
    Dim preciomenu As Integer
    Dim mesa As Integer
    Dim x As Integer
    Public rs2 As OdbcDataReader
    Public rs3 As OdbcDataReader
    Public rs4 As OdbcDataReader
    Public rs5 As OdbcDataReader
    Public rs6 As OdbcDataReader
    Public rs7 As OdbcDataReader

    Public Sub cargar2(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs2 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Public Sub cargar3(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs3 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Public Sub cargar4(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs4 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Public Sub cargar5(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs5 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub
    Public Sub cargar6(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs6 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Public Sub cargar7(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs7 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub
    Private Sub CrearComanda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblNumMesa.Text = Mesass.mesa
        sql = "truncate mesaped"
        cargar(sql)
    End Sub 'LOAD'

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Hide()
        Mesass.Show()

    End Sub 'BTN VOLVER'

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
    End Sub 'TEXT CHANGED BUSCARPROD'

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
    End Sub 'TEXT CHANGED BUSCARCOM'

    Private Sub dgvProductos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Try
            ds.Tables.Clear()
            idprod = dgvProductos.Rows(e.RowIndex).Cells("Idprod").Value
            nombreprod = dgvProductos.Rows(e.RowIndex).Cells("Nombreproducto").Value.ToString()
            sql = "select cantidad,nombreproducto from productos where idprod = " & idprod
            cargar(sql)
            While rs.Read = True
                If rs(0) = 0 Then
                    MsgBox("NO HAY STOCK DIPSPONIBLE DE " & rs(1))
                Else
                    sql = "select count(*) from mesaped where idv =" & idprod & " and tipo = 'PROD'"
                    cargar(sql)
                    While rs.Read = True
                        If rs(0) > 0 Then
                            sql = "select cantidad from mesaped where idv =" & idprod & " and tipo = 'PROD'"
                            cargar1(sql)
                            While rs1.Read = True
                                cantped = rs1(0)

                            End While
                        Else
                            sql = "select cantidad from productos where idprod =" & idprod
                            cargar1(sql)
                            While rs1.Read = True
                                cantped = rs1(0) - 1
                            End While
                        End If

                    End While
                    sql = "select cantidad from productos where idprod =" & idprod
                    cargar1(sql)
                    While rs1.Read = True
                        If (rs1(0) > cantped) Then
                            sql = "select count(*) from mesaped where idv = " & idprod & " and tipo = 'PROD'"
                            cargar(sql)
                            While rs.Read = True
                                If rs(0) > 0 Then
                                    sql = "update mesaped set cantidad = cantidad + 1 where idv = " & idprod & " and tipo = 'PROD'"
                                    cargar1(sql)


                                Else
                                    sql = "select preciounitario from productos where idprod = " & idprod
                                    cargar(sql)
                                    While rs.Read = True
                                        pu = rs(0)
                                    End While
                                    sql = "insert into mesaped values (''," & idprod & ",'" & nombreprod & "'," & 1 & ",'PROD'," & pu & ")"
                                    cargar1(sql)
                                End If

                            End While
                        Else
                            MsgBox("Sin stock disponible!", MsgBoxStyle.Exclamation)

                        End If



                    End While

                End If
            End While

            ds1.Tables.Clear()



            sql = "select id,nombre,cantidad from mesaped"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvPedidoMesa.DataSource = ds1.Tables("XX")
        Catch ex As Exception
        End Try
    End Sub 'CellClick Tabla Productos (Con Stock!)'

    Private Sub dgvComidas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComidas.CellClick
        Try
            cambio.NumberFormat.NumberDecimalSeparator = (".")
            System.Threading.Thread.CurrentThread.CurrentCulture = cambio
            sinstock = False
            ds.Tables.Clear()
            idcom = dgvComidas.Rows(e.RowIndex).Cells("idcom").Value
            nombrecom = dgvComidas.Rows(e.RowIndex).Cells("Nombrecomida").Value.ToString()
            sql = "select i.idingr,i.cantidad ,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & idcom
            cargar(sql)
            While rs.Read = True 'Cantidad de ingredientes por comida y su uso'
                If rs(1) < rs(2) Then
                    sinstock = True
                End If
            End While

            sql = "select i.idingr,i.cantidad ,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & idcom
            cargar(sql)
            While rs.Read = True 'Cantidad de ingredientes por comida y su uso'
                sql = "select idi,cantidad,count(*) from ingped where idi = " & rs(0)
                cargar1(sql)
                While rs1.Read = True
                    If rs1(2) = 1 Then
                        If rs1(1) >= rs(1) Then
                            sinstock = True
                        End If
                    End If
                End While

            End While

            sql = "select i.idingr,i.cantidad ,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & idcom
            cargar(sql)
            While rs.Read = True 'Cantidad de ingredientes por comida y su uso'
                If rs(1) < rs(2) Then
                    sinstock = True
                End If
            End While

            If sinstock = True Then 'no hay'
                MsgBox("NO HAY STOCK DIPSPONIBLE!")
            Else 'dieron todas las banderas bien(los stocks son superiores a sus cantidades x comida)'
                sql = "select i.idingr,i.cantidad ,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & idcom
                cargar(sql)
                While rs.Read = True
                    sql = "select count(*) from ingped where idi =" & rs(0)
                    cargar1(sql)
                    While rs1.Read = True
                        If rs1(0) = 1 Then

                            sql = "update ingped set cantidad = cantidad + " & rs(2) & " where idi = " & rs(0)
                            cargar2(sql)
                        Else

                            sql = "insert into ingped values(" & rs(0) & "," & rs(2) & ")"
                            cargar2(sql)

                        End If

                    End While
                End While
                sql = "select count(*) from mesaped where idv =" & idcom & " and tipo = 'COM'"
                cargar(sql)
                While rs.Read = True
                    If rs(0) = 1 Then
                        sql = "update mesaped set cantidad = cantidad + 1 where idv = " & idcom & " and tipo = 'COM'"
                        cargar6(sql)
                    Else
                        sql = "select precio from comidas where idcom = " & idcom
                        cargar(sql)
                        While rs.Read = True
                            pu = rs(0)
                        End While
                        sql = "insert into mesaped values (''," & idcom & ",'" & nombrecom & "',1,'COM'," & pu & ")"
                        cargar6(sql)
                    End If

                End While

            End If

            ds1.Tables.Clear()



            sql = "select id,nombre,cantidad from mesaped"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvPedidoMesa.DataSource = ds1.Tables("XX")
        Catch ex As Exception
        End Try
    End Sub 'CellClick Tabla Comidas (Con Stock!)'

    Private Sub dgvPedidoMesa_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidoMesa.CellClick
        Try
            cambio.NumberFormat.NumberDecimalSeparator = (".")
            System.Threading.Thread.CurrentThread.CurrentCulture = cambio
            ds2.Tables.Clear()
            dgvPedidoMesa.ClearSelection()

            id = dgvPedidoMesa.Rows(e.RowIndex).Cells("Id").Value
            nombre = dgvPedidoMesa.Rows(e.RowIndex).Cells("nombre").Value.ToString()

            sql = "update mesaped set cantidad = cantidad - 1 where id = " & id
            cargar1(sql)

            sql = "select idv,tipo from mesaped where id =" & id
            cargar1(sql)
            While rs1.Read = True
                If rs1(1).ToString = "COM" Then
                    sql = "select i.idingr,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & rs1(0)
                    cargar(sql)
                    While rs.Read = True
                        sql = "update ingped set cantidad = cantidad - " & Val(rs(1)) & " where idi = " & rs(0)
                        cargar3(sql)
                        sql = "delete from ingped where cantidad <= 0.001"
                        cargar3(sql)

                    End While
                ElseIf rs1(1).ToString = "MEN" Then
                    dia = Format(Date.Today, "dddd")

                    sql = "select * from detallemenudiario where dia like '%" & dia & "%'"
                    cargar2(sql)
                    While rs2.Read = True
                        If rs2(4) = "COM" Then
                            sql = "select i.idingr,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & rs2(6)
                            cargar(sql)
                            While rs.Read = True
                                sql = "update ingped set cantidad = cantidad - " & rs(1) & " where idi = " & rs(0)
                                cargar3(sql)
                                sql = "delete from ingped where cantidad <=  0.001"
                                cargar4(sql)

                            End While
                        End If
                    End While
                End If
            End While


            sql = "delete from mesaped where cantidad = 0"
            cargar(sql)

            sql = "select id,nombre,cantidad from mesaped"
            cargar(sql)
            ds2.Tables.Add("XX")
            da2 = New OdbcDataAdapter(sql, cnn)
            da2.Fill(ds2.Tables("XX"))
            Me.dgvPedidoMesa.DataSource = ds2.Tables("XX")

            ds1.Tables.Clear()
        Catch ex As Exception
        End Try
    End Sub 'CellClick Tabla Pedido (Con Stock!)'

    Private Sub btnConfirmarComanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarComanda.Click
        cambio.NumberFormat.NumberDecimalSeparator = (".")
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
        If lblNumMesa.Text = 0 Then
            x = MsgBox("Desea confirmar el pedido PARA LLEVAR? ", MsgBoxStyle.YesNo)
        Else
            x = MsgBox("Desea confirmar la comanda de la mesa " & lblNumMesa.Text & " ?", MsgBoxStyle.YesNo)
        End If
        If x = 6 Then
            sql = "select count(*) from mesaped"
            cargar(sql)
            While rs.Read = True
                If rs(0) = 0 Then
                    MsgBox("PEDIDO VACIO!", MsgBoxStyle.Exclamation)
                Else
                    Comanda.lblFecha.Text = Date.Today
                    Comanda.lblHora.Text = TimeOfDay
                    cargar1("select max(idcomanda) from comanda")
                    While rs1.Read = True
                        Comanda.lblNumComanda.Text = rs1(0) + 1
                        maxidcomanda = rs1(0) + 1
                    End While
                    Comanda.lblNumMesa.Text = lblNumMesa.Text
                    sql = "select * from mesaped"
                    cargar3(sql)
                    While rs3.Read = True

                        If rs3(4) = "MEN" Then
                            Comanda.lstDescr.Items.Add(" " & rs3(2) & "  (MENU-DIARIO)")
                            Comanda.lslCantidades.Items.Add(" " & rs3(3))
                            dia = Format(Date.Today, "dddd")
                            sql = "select * from detallemenudiario where dia like '%" & dia & "%'"
                            cargar5(sql)
                            While rs5.Read = True
                                Comanda.lstDescr.Items.Add(" --- " & rs5(2))
                                Comanda.lslCantidades.Items.Add("-")
                            End While
                        Else
                            Comanda.lstDescr.Items.Add(" " & rs3(2))
                            Comanda.lslCantidades.Items.Add(" " & rs3(3))
                        End If

                    End While

                    monto = 0
                    submonto = 0
                    sql = "select idv,cantidad,tipo,pu from mesaped"
                    cargar(sql)
                    While rs.Read = True
                        submonto = rs(1) * rs(3)

                        monto = monto + submonto
                    End While
                    Comanda.lblTotal.Text = monto
                    sql = "insert into comanda values ('','" & Format(TimeOfDay, "hh:mm:ss") & "','" & Format(Date.Today, "yyyy/MM/dd") & "'," & lblNumMesa.Text & "," & monto & ")"
                    cargar1(sql)
                    sql = "select * from mesaped"
                    cargar1(sql)
                    While rs1.Read = True

                        sql = "select count(*) from mesacon" & lblNumMesa.Text & " where idv = " & rs1(1) & " and tipo = '" & rs1(4) & "'"
                        cargar5(sql)
                        While rs5.Read = True
                            If rs5(0) = 0 Then
                                sql = "insert into mesacon" & lblNumMesa.Text & " values (" & rs1(0) & "," & rs1(1) & ",'" & rs1(2).ToString & "'," & rs1(3) & ",'" & rs1(4).ToString & "'," & rs1(5) & ") "
                                cargar6(sql)
                            Else
                                sql = "update mesacon" & lblNumMesa.Text & " set cant = cant + " & rs1(3) & " where idv = " & rs1(1) & " and tipo = '" & rs1(4) & "'"
                                cargar6(sql)
                            End If
                        End While


                        sql = "insert into detallecomanda values (''," & maxidcomanda & ",'" & rs1(2).ToString & "'," & rs1(3) & ")"
                        cargar2(sql)
                        If rs1(4).ToString = "PROD" Then
                            sql = "update productos set cantidad = cantidad - " & rs1(3) & " where idprod = " & rs1(1)
                            cargar5(sql)
                        ElseIf rs1(4).ToString = "MEN" Then
                            dia = Format(Date.Today, "dddd")
                            sql = "select * from detallemenudiario where dia like '%" & dia & "%'"
                            cargar5(sql)
                            While rs5.Read = True
                                If rs5(4) = "PROD" Then
                                    sql = "update productos set cantidad = cantidad - " & rs5(3) & " where idprod = " & rs5(6)
                                    cargar6(sql)
                                End If
                            End While
                        End If
                    End While
                    sql = "select count(*) from ingped"
                    cargar1(sql)
                    While rs1.Read = True
                        If rs1(0) > 0 Then
                            sql = "select * from ingped"
                            cargar4(sql)
                            While rs4.Read = True
                                sql = "update ingredientes set cantidad = cantidad - " & rs4(1) & " where idingr = " & rs4(0)
                                cargar5(sql)
                                sql = "update ingredientes set cantidad = 0 where cantidad <= 0.00001"
                                cargar6(sql)
                            End While

                        End If
                    End While
                    sql = "truncate ingped"
                    cargar1(sql)
                    sql = "truncate mesaped"
                    cargar1(sql)

                    If lblNumMesa.Text = 0 Then

                        parallevar = True

                    Else
                        parallevar = False
                    End If



                    Me.Hide()
                    Comanda.Show()

                    ds1.Tables.Clear()
                    sql = "select id,nombre,cantidad from mesaped"
                    cargar(sql)
                    ds1.Tables.Add("XX")
                    da1 = New OdbcDataAdapter(sql, cnn)
                    da1.Fill(ds1.Tables("XX"))
                    Me.dgvPedidoMesa.DataSource = ds1.Tables("XX")

                End If

            End While

        End If
    End Sub

    Private Sub btnBorrarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarPedido.Click

        ds1.Tables.Clear()
        sql = "truncate mesaped"
        cargar(sql)
        ds1.Tables.Add("XX")
        da1 = New OdbcDataAdapter(sql, cnn)
        da1.Fill(ds1.Tables("XX"))
        Me.dgvPedidoMesa.DataSource = ds1.Tables("XX")

        sql = "truncate ingped"
        cargar(sql)
    End Sub

    Private Sub btnmasmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmasmenu.Click
        cambio.NumberFormat.NumberDecimalSeparator = (".")
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
        dia = Format(Date.Today, "dddd")
        nosepuede = False
        sql = "select * from menudiario where dia like '%" & dia & "%'"
        cargar(sql)
        While rs.Read = True
            idmenudiario = rs(0)
            nombremenu = rs(1).ToString
            preciomenu = rs(2)
        End While
        If nombremenu = "" Then
            MsgBox("MENU DEL DIA NO CARGADO!")
        Else
            sql = "select * from detallemenudiario where dia like '%" & dia & "%'"
            cargar(sql)
            While rs.Read = True
                If rs(4) = "PROD" Then 'ES PRODUCTO
                    sql = "select cantidad from productos where idprod = " & rs(6)
                    cargar1(sql)
                    While rs1.Read = True
                        If rs1(0) = 0 Then ' Check de Stock
                            nosepuede = True
                        End If


                    End While
                Else 'ES COMIDA 
                    sql = "select i.idingr,i.cantidad ,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & rs(6)
                    cargar(sql)
                    While rs.Read = True 'Cantidad de ingredientes por comida y su uso'
                        If rs(1) < rs(2) Then
                            nosepuede = True
                        End If
                    End While
                End If
            End While
            If nosepuede = True Then
                MsgBox("NO HAY STOCK SUFICIENTE!")
            Else
                sql = "select count(*) from mesaped where tipo = 'MEN' "
                cargar(sql)
                While rs.Read = True
                    If rs(0) = 1 Then 'existe en mesaped'
                        sql = "update mesaped set cantidad = cantidad + 1 where tipo = 'MEN'"
                        cargar1(sql)
                        sql = "select * from detallemenudiario where dia like '%" & dia & "%'"
                        cargar1(sql)
                        While rs1.Read = True
                            If rs1(4) = "COM" Then
                                sql = "select i.idingr,i.cantidad ,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & rs1(6)
                                cargar2(sql)
                                While rs2.Read = True
                                    sql = "select count(*) from ingped where idi =" & rs2(0)
                                    cargar3(sql)
                                    While rs3.Read = True
                                        If rs3(0) = 1 Then
                                            sql = "update ingped set cantidad = cantidad + " & rs2(2) & " where idi = " & rs2(0)
                                            cargar4(sql)
                                        Else
                                        End If

                                    End While
                                End While
                            End If
                        End While
                    Else
                        sql = "insert into mesaped values(''," & idmenudiario & ",'" & nombremenu & "',1,'MEN'," & preciomenu & ")"
                        cargar1(sql)
                        sql = "select * from detallemenudiario where dia like '%" & dia & "%'"
                        cargar1(sql)
                        While rs1.Read = True
                            If rs1(4) = "COM" Then
                                sql = "select i.idingr,i.cantidad ,ic.cantidad from ingredientes i,ingredientes_comidas ic, comidas c where i.idingr = ic.idingr and c.idcom=ic.idcom and c.idcom=" & rs1(6)
                                cargar2(sql)
                                While rs2.Read = True
                                    sql = "select count(*) from ingped where idi =" & rs2(0)
                                    cargar3(sql)
                                    While rs3.Read = True
                                        If rs3(0) = 1 Then
                                            sql = "update ingped set cantidad = cantidad + " & rs2(2) & " where idi = " & rs2(0)
                                            cargar4(sql)
                                        Else
                                            sql = "insert into ingped values(" & rs2(0) & "," & rs2(2) & ")"
                                            cargar4(sql)
                                        End If

                                    End While
                                End While
                            End If
                        End While

                    End If

                End While
            End If

            ds1.Tables.Clear()



            sql = "select id,nombre,cantidad from mesaped"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvPedidoMesa.DataSource = ds1.Tables("XX")
        End If


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Mesass.Show()
        If Mesass.yapidiendo = False Then
            sql = "drop table mesacon" & Mesass.mesa & ""
            cargar(sql)
            If Mesass.mesa <> 0 Then
                Mesass.Controls("btnMesa" & Mesass.mesa).BackColor() = Color.Lime
            End If
        End If
        sql = "truncate table mesaped"
        cargar(sql)
        sql = "truncate table ingped"
        cargar(sql)

        txtBuscarCom.Text = ""
        txtBuscarProd.Text = ""

        dgvComidas.ClearSelection()
        dgvProductos.ClearSelection()

        ds1.Tables.Clear()

        Mesass.rdbMesa.Checked = False
        Mesass.rdbParaLlevar.Checked = False


        sql = "select id,nombre,cantidad from mesaped"
        cargar(sql)
        ds1.Tables.Add("XX")
        da1 = New OdbcDataAdapter(sql, cnn)
        da1.Fill(ds1.Tables("XX"))
        Me.dgvPedidoMesa.DataSource = ds1.Tables("XX")
    End Sub

    Private Sub lblParaLlevar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblParaLlevar.Click

    End Sub

    Private Sub dgvPedidoMesa_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidoMesa.CellContentClick

    End Sub

    Private Sub dgvComidas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComidas.CellContentClick

    End Sub
End Class