Imports System.Data.Odbc
Public Class frmKiosco
    Dim sql As String
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim da1 As OdbcDataAdapter
    Dim ds2 As New DataSet
    Dim da2 As OdbcDataAdapter
    Dim ds2v As New DataSet
    Dim da2v As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim da As OdbcDataAdapter
    Dim idprod As Integer
    Dim nombreprod As String
    Dim cantkios As String
    Dim idprod1 As Integer
    Dim nombreprod1 As String
    Dim monto As Integer
    Dim change As Boolean
    Dim submonto As Integer
    Dim i As Integer = 0
    Dim idsocio As String
    Dim deuda As Boolean
    Dim montomenor As Integer
    Dim numauto As String
    Dim menor As Boolean
    Dim montopiola As Boolean
    Dim compraenab As Boolean
    Dim subttotal As Integer
    Dim maxticket As Integer
    Dim pu As Integer
    Dim hay As Boolean

    Private Sub frmKiosco_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
    End Sub




    Private Sub frmKiosco_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "select * from productos"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvProductos.DataSource = ds.Tables("XX")

        sql = "truncate kioscompra"
        cargar(sql)
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

    Private Sub dgvProductos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Try
            ds.Tables.Clear()
            Enabled = True
            idprod = dgvProductos.Rows(e.RowIndex).Cells("Idprod").Value
            nombreprod = dgvProductos.Rows(e.RowIndex).Cells("Nombreproducto").Value.ToString()
            sql = "select cantidad,nombreproducto from productos where idprod = " & idprod
            cargar(sql)
            While rs.Read = True
                If rs(0) = 0 Then
                    MsgBox("NO HAY STOCK DIPSPONIBLE DE " & rs(1))
                Else
                    sql = "select count(*) from kioscompra where idprod =" & idprod
                    cargar(sql)
                    While rs.Read = True
                        If rs(0) > 0 Then
                            sql = "select cantidad from kioscompra where idprod =" & idprod
                            cargar1(sql)
                            While rs1.Read = True
                                cantkios = rs1(0)

                            End While
                        Else
                            sql = "select cantidad from productos where idprod =" & idprod
                            cargar1(sql)
                            While rs1.Read = True
                                cantkios = rs1(0) - 1
                            End While
                        End If

                    End While
                    sql = "select cantidad from productos where idprod =" & idprod
                    cargar1(sql)
                    While rs1.Read = True
                        If (rs1(0) > cantkios) Then
                            sql = "select count(*) from kioscompra where idprod = " & idprod
                            cargar(sql)
                            While rs.Read = True
                                If rs(0) > 0 Then
                                    sql = "update kioscompra set cantidad = cantidad + 1 where idprod = " & idprod
                                    cargar1(sql)


                                Else
                                    sql = "insert into kioscompra values (" & idprod & ",'" & nombreprod & "'," & 1 & ")"
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
            monto = 0
            submonto = 0
            frmTicketFactura.lstSubtotal.Items.Clear()
            sql = "select * from kioscompra"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvPedido.DataSource = ds1.Tables("XX")

            sql = "select idprod,cantidad from kioscompra"
            cargar(sql)
            While rs.Read = True

                sql = "select Preciounitario from productos where idprod = " & rs(0)
                cargar1(sql)
                While rs1.Read = True
                    submonto = rs1(0) * rs(1)
                    frmTicketFactura.lstSubtotal.Items.Add(submonto.ToString)
                End While
                monto = monto + submonto
            End While
            lblMONTO.Text = monto

        Catch ex As Exception

        End Try


    End Sub






    Private Sub dgvPedido_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedido.CellClick
        Try
            ds2.Tables.Clear()
            dgvProductos.ClearSelection()

            idprod1 = dgvPedido.Rows(e.RowIndex).Cells("Idprod").Value
            nombreprod1 = dgvPedido.Rows(e.RowIndex).Cells("nombreprod").Value.ToString()

            sql = "update kioscompra set cantidad = cantidad - 1 where idprod = " & idprod1
            cargar1(sql)

            sql = "delete from kioscompra where cantidad = 0"
            cargar(sql)

            sql = "select * from kioscompra"
            cargar(sql)
            ds2.Tables.Add("XX")
            da2 = New OdbcDataAdapter(sql, cnn)
            da2.Fill(ds2.Tables("XX"))
            Me.dgvPedido.DataSource = ds2.Tables("XX")

            ds1.Tables.Clear()

            monto = 0
            submonto = 0

            frmTicketFactura.lstSubtotal.Items.Clear()

            sql = "select * from kioscompra"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvPedido.DataSource = ds1.Tables("XX")

            sql = "select idprod,cantidad from kioscompra"
            cargar(sql)
            While rs.Read = True
                frmTicketFactura.lstCantidad.Items.Add(rs(1).ToString)
                sql = "select Preciounitario from productos where idprod = " & rs(0)
                cargar1(sql)
                While rs1.Read = True
                    submonto = rs1(0) * rs(1)
                    frmTicketFactura.lstSubtotal.Items.Add((submonto).ToString)
                End While

                monto = monto + submonto
            End While
            lblMONTO.Text = monto
        Catch ex As Exception
        End Try

    End Sub

    Private Sub rdbCC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbCC.CheckedChanged
        If rdbCC.Checked = True Then
            btnMenorAutorizado.Enabled = True
            btnSocioCC.Enabled = True
            lstCliente.Enabled = True
            btnConfirmarCompra.Enabled = False
            lblEfectivo.Visible = False
            txtEfectivo.Visible = False
            lblVueltovich.Visible = False
            lblVuelto.Visible = False
            txtEfectivo.Text = ""
            compraenab = False
        Else
            btnMenorAutorizado.Enabled = False
            btnSocioCC.Enabled = False
            lstCliente.Enabled = False
            btnConfirmarCompra.Enabled = False
        End If


    End Sub




    Private Sub btnMenorAutorizado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenorAutorizado.Click
        Try
            numauto = InputBox("Ingrese el numero de Autorizacion")
            sql = "select count(*),idsocio,monto from autorizaciones where idA = " & numauto
            cargar(sql)
            While rs.Read = True
                If rs(0) = 0 Then
                    MsgBox("NUMERO DE AUTORIZACION ERRONEO!", MsgBoxStyle.Critical)
                    btnConfirmarCompra.Enabled = False
                    menor = False
                Else
                    lstCliente.Items.Clear()
                    MsgBox("Autorizacion Encontrada!")
                    idsocio = rs(1)
                    sql = "Select nombre,apellido,deuda from socios where idsocio =" & rs(1) & " and estado = 1"
                    cargar1(sql)
                    While rs1.Read = True
                        If rs1(2) = 1 Then
                            lstCliente.Items.Add(" " & rs1(0) & " " & rs1(1) & " (Con Deuda)")
                            deuda = True
                            btnConfirmarCompra.Enabled = False
                            menor = True
                            compraenab = False
                        Else
                            lstCliente.Items.Add(" " & rs1(0) & " " & rs1(1) & " (Sin Deuda) ")
                            deuda = False

                            btnConfirmarCompra.Enabled = True
                            montomenor = rs(2)
                            menor = True
                            compraenab = True
                        End If
                    End While
                End If
            End While

        Catch ex As Exception
            If numauto <> "" Then
                MsgBox("SOLO SE PUEDEN INGRESAR VALORES NUMERICOS", MsgBoxStyle.Critical)
            Else

            End If
        End Try
    End Sub

    Private Sub btnSocioCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSocioCC.Click
        Try
            idsocio = InputBox("Ingrese el numero de socio!")
            sql = "select count(*) from socios where idsocio = " & idsocio & " and estado = 1"
            cargar(sql)
            While rs.Read = True
                If rs(0) = 0 Then
                    MsgBox("SOCIO NO ENCONTRADO!", MsgBoxStyle.Critical)
                    btnConfirmarCompra.Enabled = False
                Else
                    lstCliente.Items.Clear()

                    MsgBox("Socio Encontrado!")
                    menor = False
                    sql = "Select nombre,apellido,deuda from socios where idsocio =" & idsocio
                    cargar1(sql)
                    While rs1.Read = True
                        If rs1(2) = 1 Then
                            lstCliente.Items.Add(" " & rs1(0) & " " & rs1(1) & " (Con Deuda)")
                            deuda = True
                            btnConfirmarCompra.Enabled = False
                            compraenab = False
                        Else
                            lstCliente.Items.Add(" " & rs1(0) & " " & rs1(1) & " (Sin Deuda) ")
                            deuda = False
                            btnConfirmarCompra.Enabled = True
                            compraenab = True

                        End If
                    End While
                End If


            End While
        Catch ex As Exception
            If idsocio <> "" Then
                MsgBox("SOLO SE PUEDEN INGRESAR VALORES NUMERICOS", MsgBoxStyle.Critical)
            Else

            End If

        End Try

        

    End Sub

    Private Sub rdbEfe_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbEfe.CheckedChanged
        If rdbEfe.Checked = True Then
            btnConfirmarCompra.Enabled = True
            lstCliente.Items.Clear()
            compraenab = True
            idsocio = 0
            lblEfectivo.Visible = True
            txtEfectivo.Visible = True
            lblVuelto.Visible = True
            lblVuelto.Text = ""
        End If
    End Sub


    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmCompras.Show()
        sql = "drop table kioscompra"
        cargar(sql)

    End Sub

    Private Sub btnConfirmarCompra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmarCompra.Click

        If menor = True Then
            sql = "select monto from autorizaciones where ida = " & numauto
            cargar(sql)
            While rs.Read = True
                If (rs(0) - Val(lblMONTO.Text)) < 0 Then
                    MsgBox("EL MONTO DE COMPRA SUPERA EL LIMITE QUE PUEDE GASTAR EL MENOR!", MsgBoxStyle.Critical)
                    compraenab = False
                Else
                    compraenab = True
                    sql = "update autorizaciones set monto = monto -" & Val(lblMONTO.Text) & " where ida = " & numauto
                    cargar1(sql)
                End If
            End While
        End If

        sql = "select count(*) from kioscompra"
        cargar(sql)
        While rs.Read = True
            If rs(0) = 0 Then
                hay = False
                MsgBox("Seleccione Algun Articulo!")
            Else
                hay = True
            End If
        End While
        If compraenab = True And hay = True Then

            If idsocio = 0 Then 'EFECTIVO'
                If txtEfectivo.Text <> "" Then
                    If Val(txtEfectivo.Text) >= Val(lblMONTO.Text) Then
                        sql = "select idprod,cantidad from kioscompra"
                        cargar(sql)
                        While rs.Read = True
                            sql = "update productos set cantidad = cantidad - " & rs(1) & " where idprod = " & rs(0)
                            cargar1(sql)
                        End While

                        sql = "insert into ingresos values (''," & Val(lblMONTO.Text) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','VENTA_KIOSCO')"
                        cargar(sql)

                        frmTicketFactura.lstCantidad.Items.Clear()

                        frmTicketFactura.lblFechaTicket.Text = Date.Today
                        frmTicketFactura.lblFormaPago.Text = "EFECTIVO"
                        frmTicketFactura.TextBox1.Text = lblMONTO.Text

                        sql = "select * from kioscompra"
                        cargar1(sql)
                        While rs1.Read = True
                            sql = "select preciounitario from productos where idprod =" & rs1(0)
                            cargar(sql)
                            While rs.Read = True
                                frmTicketFactura.lstPrecio.Items.Add((rs(0)).ToString)
                            End While

                            frmTicketFactura.lstProductos.Items.Add((rs1(1)).ToString)
                            frmTicketFactura.lstCantidad.Items.Add((rs1(2)).ToString)
                        End While
                        frmTicketFactura.lblHoraTicket.Text = TimeOfDay

                        frmTicketFactura.lblFechaTicket.Text = Date.Today
                        sql = "select max(idticketfactura) from ticketfactura"
                        cargar(sql)
                        While rs.Read = True
                            frmTicketFactura.lblNumTicket.Text = Val(rs(0)) + 1
                        End While
                        frmTicketFactura.lbla.Visible = True
                        frmTicketFactura.lblvuelto.Visible = True
                        frmTicketFactura.lblAbonado.Visible = True
                        frmTicketFactura.lblv.Visible = True
                        frmTicketFactura.lblAbonado.Text = txtEfectivo.Text
                        frmTicketFactura.lblvuelto.Text = lblVuelto.Text
                        frmTicketFactura.TextBox1.Text = lblMONTO.Text
                        frmTicketFactura.lblSocio.Visible = False
                        frmTicketFactura.Label6.Visible = False
                        sql = "insert into ticketfactura values (''," & lblMONTO.Text & ",'EFE','" & Format(Date.Today, "yyyy/MM/dd") & "')"
                        cargar(sql)
                        sql = "select max(idticketfactura) from ticketfactura"
                        cargar(sql)
                        While rs.Read = True
                            maxticket = rs(0)
                        End While
                        sql = "select * from kioscompra"
                        cargar(sql)
                        While rs.Read = True
                            sql = "select preciounitario from productos where idprod =" & rs(0)
                            cargar1(sql)
                            While rs1.Read = True
                                subttotal = rs1(0) * rs(2)
                                pu = rs1(0)
                            End While
                            sql = "insert into filaticketfactura values (''," & maxticket & ",'" & (rs(1)).ToString & "'," & rs(2) & "," & pu & "," & subttotal & ")"
                            cargar1(sql)


                        End While

                        Facturar.servcom = False

                        Me.Hide()
                        frmTicketFactura.Show()

                        lblMONTO.Text = ""
                        rdbCC.Checked = False
                        rdbEfe.Checked = False
                        lstCliente.Items.Clear()

                        ds2v.Tables.Clear()


                        sql = "truncate table kioscompra"
                        cargar(sql)
                        ds2v.Tables.Add("XX")
                        da2v = New OdbcDataAdapter(sql, cnn)
                        da2v.Fill(ds2v.Tables("XX"))
                        Me.dgvPedido.DataSource = ds2v.Tables("XX")


                        ds2v.Tables.Clear()


                        sql = "select * from productos"
                        cargar(sql)
                        ds2v.Tables.Add("XX")
                        da2v = New OdbcDataAdapter(sql, cnn)
                        da2v.Fill(ds2v.Tables("XX"))
                        Me.dgvProductos.DataSource = ds2v.Tables("XX")
                        btnConfirmarCompra.Enabled = False

                        lblEfectivo.Visible = False
                        txtEfectivo.Visible = False
                        txtEfectivo.Text = ""
                        lblVueltovich.Visible = False
                        lblVuelto.Text = ""
                        lblVuelto.Visible = False
                    Else
                        MsgBox("El efectivo debe ser mayor al monto a pagar!", MsgBoxStyle.Critical)


                    End If
                Else
                    MsgBox("Complete el espacio vacio!", MsgBoxStyle.Critical)

                End If


            Else 'CUENTA CORRIENTE'
                sql = "update cuentacorriente set monto = monto +" & Val(lblMONTO.Text) & " where idsocio = " & idsocio
                cargar(sql)

                frmTicketFactura.lstCantidad.Items.Clear()

                frmTicketFactura.lblFechaTicket.Text = Date.Today
                frmTicketFactura.lblFormaPago.Text = "CC"
                frmTicketFactura.TextBox1.Text = lblMONTO.Text

                sql = "select * from kioscompra"
                cargar1(sql)
                While rs1.Read = True
                    sql = "select preciounitario from productos where idprod =" & rs1(0)
                    cargar(sql)
                    While rs.Read = True
                        frmTicketFactura.lstPrecio.Items.Add((rs(0)).ToString)
                    End While

                    frmTicketFactura.lstProductos.Items.Add((rs1(1)).ToString)
                    frmTicketFactura.lstCantidad.Items.Add((rs1(2)).ToString)
                End While
                frmTicketFactura.lblHoraTicket.Text = TimeOfDay

                sql = "select max(idticketfactura) from ticketfactura"
                cargar(sql)
                While rs.Read = True
                    frmTicketFactura.lblNumTicket.Text = rs(0) + 1
                End While
                frmTicketFactura.lblFechaTicket.Text = Date.Today
                frmTicketFactura.lblFormaPago.Text = "CC"
                frmTicketFactura.TextBox1.Text = lblMONTO.Text
                frmTicketFactura.lblSocio.Text = idsocio
                frmTicketFactura.lbla.Visible = False
                frmTicketFactura.lblvuelto.Visible = False
                frmTicketFactura.lblAbonado.Visible = False
                frmTicketFactura.lblv.Visible = False
                frmTicketFactura.lblSocio.Visible = True
                frmTicketFactura.Label6.Visible = True

                sql = "insert into ticketfactura values (''," & lblMONTO.Text & ",'CC','" & Format(Date.Today, "yyyy/MM/dd") & "')"
                cargar(sql)
                sql = "select max(idticketfactura) from ticketfactura"
                cargar(sql)
                While rs.Read = True
                    maxticket = rs(0)
                End While
                sql = "select * from kioscompra"
                cargar(sql)
                While rs.Read = True
                    sql = "select preciounitario from productos where idprod =" & rs(0)
                    cargar1(sql)
                    While rs1.Read = True
                        subttotal = rs1(0) * rs(2)
                        pu = rs1(0)
                    End While
                    sql = "insert into filaticketfactura values (''," & maxticket & ",'" & (rs(1)).ToString & "'," & rs(2) & "," & pu & "," & subttotal & ")"
                    cargar1(sql)

                End While


                Facturar.servcom = False
                Me.Hide()
                frmTicketFactura.Show()

                lblMONTO.Text = ""
                rdbCC.Checked = False
                rdbEfe.Checked = False
                lstCliente.Items.Clear()

                ds2v.Tables.Clear()


                sql = "truncate table kioscompra"
                cargar(sql)
                ds2v.Tables.Add("XX")
                da2v = New OdbcDataAdapter(sql, cnn)
                da2v.Fill(ds2v.Tables("XX"))
                Me.dgvPedido.DataSource = ds2v.Tables("XX")


                ds2v.Tables.Clear()


                sql = "select * from productos"
                cargar(sql)
                ds2v.Tables.Add("XX")
                da2v = New OdbcDataAdapter(sql, cnn)
                da2v.Fill(ds2v.Tables("XX"))
                Me.dgvProductos.DataSource = ds2v.Tables("XX")
                btnConfirmarCompra.Enabled = False

                lblEfectivo.Visible = False
                txtEfectivo.Visible = False
                txtEfectivo.Text = ""
                lblVueltovich.Visible = False
                lblVuelto.Text = ""
                lblVuelto.Visible = False


            End If



        End If

    End Sub

    Private Sub txtEfectivo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEfectivo.TextChanged
        If lblMONTO.Text <> "" Then
            lblVuelto.Text = Val(txtEfectivo.Text) - Val(lblMONTO.Text)
            If rdbCC.Checked = False Then
                lblVueltovich.Visible = True
            End If


        Else
            lblVueltovich.Visible = False
        End If

    End Sub

    Private Sub btnBorrarPedido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrarPedido.Click

        lblMONTO.Text = ""
        rdbCC.Checked = False
        rdbEfe.Checked = False
        lstCliente.Items.Clear()

        ds2v.Tables.Clear()


        sql = "truncate table kioscompra"
        cargar(sql)
        ds2v.Tables.Add("XX")
        da2v = New OdbcDataAdapter(sql, cnn)
        da2v.Fill(ds2v.Tables("XX"))
        Me.dgvPedido.DataSource = ds2v.Tables("XX")


        ds2v.Tables.Clear()


        sql = "select * from productos"
        cargar(sql)
        ds2v.Tables.Add("XX")
        da2v = New OdbcDataAdapter(sql, cnn)
        da2v.Fill(ds2v.Tables("XX"))
        Me.dgvProductos.DataSource = ds2v.Tables("XX")
        btnConfirmarCompra.Enabled = False

        lblEfectivo.Visible = False
        txtEfectivo.Visible = False
        txtEfectivo.Text = ""
        lblVueltovich.Visible = False
        lblVuelto.Text = ""
        lblVuelto.Visible = False
    End Sub

    Private Sub dgvProductos_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub
End Class
