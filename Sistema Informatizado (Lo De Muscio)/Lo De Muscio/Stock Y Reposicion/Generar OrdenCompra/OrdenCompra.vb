Imports System.Data.Odbc
Public Class OrdenCompra
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
    Dim nohaynada As Integer
    Dim id As Integer
    Dim nombre As String
    Dim proveedor As Boolean
    Dim idprov As Integer
    Dim idv As Integer
    Dim tipo As String
    Dim precio As String
    Dim cantpp As Integer
    Dim cantidadorden As Integer
    Dim nombreproveedor As String
    Dim maxidoc As Integer
    Dim cantidadd As Integer
    Dim monto As Integer
    Dim rs2 As OdbcDataReader

    Public Sub cargar2(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs2 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Private Sub dgvProveedor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedor.CellClick
        Try
            Try
                sql = "drop table provin"
                cargar(sql)
            Catch ex As Exception

            End Try

            sql = "truncate table detalleordencompragrilla"
            cargar(sql)

            ds1.Tables.Clear()
            sql = "select idv,nombreinsumo,cantidad,tipo from detalleordencompragrilla"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvDetalleOrden.DataSource = ds1.Tables("XX")



            id = dgvProveedor.Rows(e.RowIndex).Cells("IdProveedor").Value
            nombre = dgvProveedor.Rows(e.RowIndex).Cells("nombre").Value.ToString()

            lblProv.Text = "Proveedor: " & nombre & " "
            lblIngProd.Text = "Ing/Prod de " & nombre & " "
            lblOccc.Text = "Orden de compra a  " & nombre & " "
            nombreproveedor = nombre

            sql = "create table provin(idproveedor int,idv int,concepto char(50),tipo char(30),precio int,estado tinyint) "
            cargar(sql)

            sql = "select * from puntopedido where estado = 'NOPEDIDO'"
            cargar(sql)
            While rs.Read = True
                If rs(3).ToString = "ING" Then 'INGREDIENTE
                    sql = "select * from provingrediente where idproveedor = " & id & " and idingr = " & rs(1) & ""
                    cargar1(sql)
                    While rs1.Read = True
                        sql = "insert into provin values(" & id & "," & rs(1) & ",'" & rs(2) & "','ING'," & rs1(3) & ",1)"
                        cargar2(sql)
                    End While
                Else 'PRODUCTO
                    sql = "select * from proveedorproductos where idproveedor = " & id & " and idprod = " & rs(1) & ""
                    cargar1(sql)
                    While rs1.Read = True
                        sql = "insert into provin values(" & id & "," & rs(1) & ",'" & rs(2) & "','PROD'," & rs1(3) & ",1)"
                        cargar2(sql)
                    End While
                End If
            End While

            btnOrdenCompra.Enabled = True
            proveedor = True

            ds2.Tables.Clear()
            sql = "select * from provin where estado = 1"
            cargar(sql)
            ds2.Tables.Add("XX")
            da2 = New OdbcDataAdapter(sql, cnn)
            da2.Fill(ds2.Tables("XX"))
            Me.dgvIngProd.DataSource = ds2.Tables("XX")
        Catch ex As Exception

        End Try



    End Sub


    Private Sub dgvIngProd_CellContent(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngProd.CellClick
        Try
            If proveedor = True Then
                idprov = dgvIngProd.Rows(e.RowIndex).Cells("IdProveedor").Value
                idv = dgvIngProd.Rows(e.RowIndex).Cells("idv").Value
                nombre = dgvIngProd.Rows(e.RowIndex).Cells("concepto").Value.ToString()
                tipo = dgvIngProd.Rows(e.RowIndex).Cells("tipo").Value.ToString()
                precio = dgvIngProd.Rows(e.RowIndex).Cells("precio").Value



                If tipo = "ING" Then
                    sql = "select puntopedido from ingredientes where idingr = " & idv
                    cargar(sql)
                    While rs.Read = True
                        cantpp = rs(0)
                    End While
                    cantidadorden = InputBox("Ingrese la cantidad del ingrediente en KILOS (Debe ser mayor a " & cantpp & " !)")
                    If cantidadorden > cantpp Then
                        sql = "insert into detalleordencompragrilla values(" & idprov & "," & idv & ",'" & nombre & "'," & cantidadorden & "," & precio & ",'ING'," & cantidadorden * precio & ")"
                        cargar(sql)
                        sql = "update provin set estado = 0 where idv = " & idv & " and tipo = 'ING'"
                        cargar(sql)
                    Else
                        MsgBox("LA CANTIDAD A PEDIR DEBE SUPERAR AL PUNTO DE PEDIDO")
                    End If
                Else

                    sql = "select puntopedido from productos where idprod = " & idv
                    cargar(sql)
                    While rs.Read = True
                        cantpp = rs(0)
                    End While
                    cantidadorden = InputBox("Ingrese la cantidad del producto en UNIDADES (Debe ser mayor a " & cantpp & " !)")
                    If cantidadorden > cantpp Then
                        sql = "insert into detalleordencompragrilla values(" & idprov & "," & idv & ",'" & nombre & "'," & cantidadorden & "," & precio & ",'PROD'," & cantidadorden * precio & ")"
                        cargar(sql)
                        sql = "update provin set estado = 0 where idv = " & idv & " and tipo = 'PROD'"
                        cargar(sql)
                    Else
                        MsgBox("LA CANTIDAD A PEDIR DEBE SUPERAR AL PUNTO DE PEDIDO")

                    End If
                End If

                monto = 0
                sql = "select * from detalleordencompragrilla"
                cargar(sql)
                While rs.Read = True
                    monto = monto + rs(3) * rs(4)
                End While

                lblTotal.Text = monto

                ds1.Tables.Clear()
                sql = "select idv,nombreinsumo,cantidad,tipo from detalleordencompragrilla"
                cargar(sql)
                ds1.Tables.Add("XX")
                da1 = New OdbcDataAdapter(sql, cnn)
                da1.Fill(ds1.Tables("XX"))
                Me.dgvDetalleOrden.DataSource = ds1.Tables("XX")

                ds2.Tables.Clear()
                sql = "select * from provin where estado = 1"
                cargar(sql)
                ds2.Tables.Add("XX")
                da2 = New OdbcDataAdapter(sql, cnn)
                da2.Fill(ds2.Tables("XX"))
                Me.dgvIngProd.DataSource = ds2.Tables("XX")


            Else
                MsgBox("Seleccione un proveedor primero!!!")

            End If
        Catch ex As Exception
            MsgBox("ERROR AL CARGAR EL PRODUCTO INTENTE DENUEVO")
        End Try

    End Sub




    Private Sub dgvDetalleOrden_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrden.CellClick
        Try
            idv = dgvDetalleOrden.Rows(e.RowIndex).Cells("idv").Value
            nombre = dgvDetalleOrden.Rows(e.RowIndex).Cells("nombreinsumo").Value.ToString()
            tipo = dgvDetalleOrden.Rows(e.RowIndex).Cells("tipo").Value.ToString()
            cantidadd = dgvDetalleOrden.Rows(e.RowIndex).Cells("cantidad").Value

            If tipo = "PROD" Then
                sql = "update provin set estado = 1 where idv = " & idv & " and tipo = 'PROD'"
                cargar(sql)
            Else
                sql = "update provin set estado = 1 where idv = " & idv & " and tipo = 'ING'"
                cargar(sql)
            End If

            sql = "delete from detalleordencompragrilla where idv = " & idv & " and tipo = '" & tipo & "'"
            cargar(sql)

            monto = 0
            sql = "select * from detalleordencompragrilla"
            cargar(sql)
            While rs.Read = True
                monto = monto + rs(3) * rs(4)
            End While

            lblTotal.Text = monto
            ds1.Tables.Clear()
            sql = "select idv,nombreinsumo,cantidad,tipo from detalleordencompragrilla"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvDetalleOrden.DataSource = ds1.Tables("XX")

            ds2.Tables.Clear()
            sql = "select * from provin where estado = 1"
            cargar(sql)
            ds2.Tables.Add("XX")
            da2 = New OdbcDataAdapter(sql, cnn)
            da2.Fill(ds2.Tables("XX"))
            Me.dgvIngProd.DataSource = ds2.Tables("XX")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub OrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "drop table if exists detalleordencompragrilla"
        cargar(sql)
        sql = "create table detalleordencompragrilla(idproveedor int,idv int,nombreinsumo char(30),cantidad int,preciounitario int,tipo char(20),subtotal int)"
        cargar(sql)
    End Sub


    Private Sub btnOrdenCompra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOrdenCompra.Click
        sql = "select count(*) from detalleordencompragrilla"
        cargar(sql)
        While rs.Read = True
            nohaynada = rs(0)
        End While

        If txtTermino.Text <> "" And nohaynada <> 0 Then
            sql = "insert into ordencompra values (''," & idprov & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','" & txtTermino.Text & "','PENDIENTE'," & lblTotal.Text & ")"
            cargar(sql)
            sql = "select max(idordencompra) from ordencompra"
            cargar(sql)
            While rs.Read = True
                maxidoc = rs(0)
            End While


            Dim a As String = "create table detalleordencompragrilla(idproveedor int,idv int,nombreinsumo char(30),cantidad int,preciounitario int,tipo char(20))"

            sql = "select * from detalleordencompragrilla"
            cargar(sql)
            While rs.Read = True
                sql = "insert into detalleordencompra values (''," & maxidoc & ",'" & rs(2).ToString & "'," & rs(3) & "," & rs(4) & ",'" & rs(5).ToString & "'," & rs(6) & ")"
                cargar1(sql)
                sql = "update puntopedido set estado = 'PENDIENTE' where idv = " & rs(1) & " and tipo = '" & rs(5).ToString & "'"
                cargar1(sql)
                OrdenCompraImpr.lstConcepto.Items.Add(rs(2).ToString & " - " & rs(5).ToString)
                If rs(5).ToString = "PROD" Then
                    OrdenCompraImpr.lstCantidad.Items.Add(rs(3) & " .U")
                    OrdenCompraImpr.lstPrecio.Items.Add(rs(4) & " x Unidad")
                Else
                    OrdenCompraImpr.lstCantidad.Items.Add(rs(3) & " KG")
                    OrdenCompraImpr.lstPrecio.Items.Add("$" & rs(4) & " x KG")

                End If
                OrdenCompraImpr.lstPrecioTotal.Items.Add("$" & rs(6))
            End While

            OrdenCompraImpr.lblNroOrd.Text = maxidoc
            OrdenCompraImpr.lblProveedor.Text = nombreproveedor
            OrdenCompraImpr.lblTOTAL.Text = lblTotal.Text
            OrdenCompraImpr.lblFechaPed.Text = Date.Today
            OrdenCompraImpr.lblTermEntr.Text = txtTermino.Text

            txtTermino.Text = ""
            lblTotal.Text = ""


            Me.Close()
            OrdenCompraImpr.Show()


        Else
            MsgBox(" COMPLETE LOS ESPACIOS VACIOS!", MsgBoxStyle.Critical)
        End If


   
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtTermino.Text = ""
        lblTotal.Text = ""
        Me.Close()
        MenuStock.Show()

    End Sub

    Private Sub dgvProveedor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedor.CellContentClick

    End Sub

    Private Sub dgvDetalleOrden_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrden.CellContentClick

    End Sub
End Class