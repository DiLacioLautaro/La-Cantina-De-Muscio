Imports System.Data.Odbc

Public Class MenuStock
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
    Dim rs2 As OdbcDataReader

    Public Sub cargar2(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs2 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP.Click
        Me.Hide()
        PuntoPedido.Show()

        sql = "select * from productos where cantidad <= puntopedido "
        cargar(sql)
        While rs.Read = True
            sql = "select count(*) from puntopedido where idv = " & rs(0) & " and tipo = 'PROD'"
            cargar1(sql)
            While rs1.Read = True
                If rs1(0) = 0 Then
                    sql = "insert into puntopedido values(''," & rs(0) & ",'" & rs(1).ToString & "','PROD','NOPEDIDO')"
                    cargar2(sql)
                End If
            End While

        End While

        sql = "select * from ingredientes where cantidad <= puntopedido "
        cargar(sql)
        While rs.Read = True
            sql = "select count(*) from puntopedido where idv = " & rs(0) & " and tipo = 'ING'"
            cargar1(sql)
            While rs1.Read = True
                If rs1(0) = 0 Then
                    sql = "insert into puntopedido values(''," & rs(0) & ",'" & rs(1).ToString & "','ING','NOPEDIDO')"
                    cargar2(sql)
                End If
            End While

        End While

        ds1.Tables.Clear()
        sql = "select idv,concepto,estado from puntopedido where tipo = 'PROD'"
        cargar(sql)
        ds1.Tables.Add("XX")
        da1 = New OdbcDataAdapter(sql, cnn)
        da1.Fill(ds1.Tables("XX"))
        PuntoPedido.dgvProdPP.DataSource = ds1.Tables("XX")

        ds2.Tables.Clear()
        sql = "select idv,concepto,estado from puntopedido where tipo = 'ING'"
        cargar(sql)
        ds2.Tables.Add("XX")
        da2 = New OdbcDataAdapter(sql, cnn)
        da2.Fill(ds2.Tables("XX"))
        PuntoPedido.dgvIngPP.DataSource = ds2.Tables("XX")
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenuP.Show()

    End Sub

    Private Sub btnORDENCOMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnORDENCOMP.Click

        sql = "select * from productos where cantidad <= puntopedido "
        cargar(sql)
        While rs.Read = True
            sql = "select count(*) from puntopedido where idv = " & rs(0) & " and tipo = 'PROD'"
            cargar1(sql)
            While rs1.Read = True
                If rs1(0) = 0 Then
                    sql = "insert into puntopedido values(''," & rs(0) & ",'" & rs(1).ToString & "','PROD','NOPEDIDO')"
                    cargar2(sql)
                End If
            End While

        End While

        sql = "select * from ingredientes where cantidad <= puntopedido "
        cargar(sql)
        While rs.Read = True
            sql = "select count(*) from puntopedido where idv = " & rs(0) & " and tipo = 'ING'"
            cargar1(sql)
            While rs1.Read = True
                If rs1(0) = 0 Then
                    sql = "insert into puntopedido values(''," & rs(0) & ",'" & rs(1).ToString & "','ING','NOPEDIDO')"
                    cargar2(sql)
                End If
            End While

        End While

        ds2.Tables.Clear()
        sql = "select * from puntopedido where estado = 'NOPEDIDO' "
        cargar(sql)
        ds2.Tables.Add("XX")
        da2 = New OdbcDataAdapter(sql, cnn)
        da2.Fill(ds2.Tables("XX"))
        OrdenCompra.dgvIngProd.DataSource = ds2.Tables("XX")




        ds2.Tables.Clear()
        sql = "select idproveedor,nombre,cuit,direccion from proveedor where estado = 1 and idproveedor in (select idproveedor from proveedorproductos pvpd, productos pd, puntopedido pp where pvpd.idprod=pd.idprod and pd.nombreproducto=pp.concepto and pp.estado ='NOPEDIDO') and estado = 1 or idproveedor in (select idproveedor from provingrediente pi, ingredientes i, puntopedido pp where pi.idingr=i.idingr and i.nombreingr=pp.concepto and pp.estado ='NOPEDIDO') and estado = 1"
        cargar(sql)
        ds2.Tables.Add("XX")
        da2 = New OdbcDataAdapter(sql, cnn)
        da2.Fill(ds2.Tables("XX"))
        OrdenCompra.dgvProveedor.DataSource = ds2.Tables("XX")

        Try
            sql = "drop table detalleordencompragrilla"
            cargar(sql)
        Catch ex As Exception

        End Try



        Me.Close()
        OrdenCompra.Show()


    End Sub

    Private Sub btnRecepcionMerc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecepcionMerc.Click
        sql = "select idordencompra from ordencompra where estado = 'PENDIENTE'"
        cargar(sql)
        While rs.Read = True
            Recepción_De_Meraderia.cbxIDOC.Items.Add(rs(0))
        End While

        Recepción_De_Meraderia.lblProveedor.Visible = False
        Recepción_De_Meraderia.lblTotal.Visible = False
        Me.Close()
        Recepción_De_Meraderia.Show()
    End Sub

    Private Sub MenuStock_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
    End Sub


    Private Sub btnPagoProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPagoProv.Click
        PagoProv.lblOrdenCompra.Visible = False
        PagoProv.lblTotal.Visible = False
        PagoProv.lblProveedor.Visible = False

        Me.Close()
        PagoProv.Show()

    End Sub

    Private Sub MenuStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class