Imports System.Data.Odbc
Public Class Recepción_De_Meraderia
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
    Dim idprov As Integer
    Dim numcheque As String
    Dim rs2 As OdbcDataReader
    Dim maxidremito As Integer
    Dim maxidfactura As Integer
    Dim descrp As String
    Dim maxidreclamo As Integer
    Dim error1 As Boolean

    Private Sub Recepción_De_Meraderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbxIDOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxIDOC.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub cbxIDOC_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxIDOC.SelectedIndexChanged



        sql = "select idproveedor,total from ordencompra where idordencompra = " & cbxIDOC.Text
        cargar(sql)
        While rs.Read = True
            lblTotal.Text = rs(1)
            idprov = rs(0)
            sql = "select nombre from proveedor where idproveedor = " & rs(0)
            cargar1(sql)
            While rs1.Read = True
                lblProveedor.Text = rs1(0).ToString

            End While

        End While

        lblProveedor.Visible = True
        lblTotal.Visible = True

        lstCantidad.Items.Clear()
        lstInsumos.Items.Clear()

        sql = "select nombreproducto,cantidadfila,tipo from detalleordencompra where idordencompra = " & cbxIDOC.Text
        cargar(sql)
        While rs.Read = True
            lstInsumos.Items.Add(" " & rs(0).ToString & " ( " & rs(2).ToString & " )")
            If rs(2).ToString = "PROD" Then
                lstCantidad.Items.Add(rs(1) & " Unidades ")
            Else
                lstCantidad.Items.Add(rs(1) & " KG")
            End If
        End While

        btnPagar.Enabled = True
        btnReclamo.Enabled = True

    End Sub

    Private Sub btnPagar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        If dtpFechaFactura.Value.Date <= Date.Today And dtpFechaRemito.Value.Date <= Date.Today Then
            If txtNumFactura.Text <> "" And txtNumRemito.Text <> "" Then
                sql = "select * from detalleordencompra where idordencompra = " & cbxIDOC.Text
                cargar(sql)
                While rs.Read = True
                    sql = "delete from puntopedido where concepto = '" & rs(2).ToString & "' and tipo = '" & rs(5).ToString & "'"
                    cargar1(sql)

                    If rs(5) = "PROD" Then
                        sql = "update productos set cantidad = cantidad + " & rs(3) & " where nombreproducto = '" & rs(2) & "'"
                        cargar1(sql)
                    Else
                        sql = "update ingredientes set cantidad = cantidad + " & rs(3) & " where nombreingr = '" & rs(2) & "'"
                        cargar1(sql)
                    End If
                End While

                sql = "insert into facturaproveedor values ('','" & Format(dtpFechaFactura.Value.Date, "yyyy/MM/dd") & "'," & lblTotal.Text & "," & txtNumFactura.Text & "," & idprov & "," & cbxIDOC.Text & ",'ENPROCESO')"
                cargar(sql)

                sql = "select max(idfacturaproveedor) from facturaproveedor"
                cargar(sql)
                While rs.Read = True
                    maxidfactura = rs(0)
                End While


                sql = "insert into remito values (''," & txtNumRemito.Text & ",'" & Format(dtpFechaRemito.Value.Date, "yyyy/MM/dd") & "'," & cbxIDOC.Text & ",'ENPROCESO'," & maxidfactura & ")"
                cargar(sql)

                sql = "select max(idremito) from remito"
                cargar(sql)
                While rs.Read = True
                    maxidremito = rs(0)
                End While


                sql = "update ordencompra set estado = 'FINALIZADA' where idordencompra = " & cbxIDOC.Text
                cargar(sql)

                MsgBox("PRODUCTOS/INGREDIENTES Y DOCUMENTACION REGISTRADOS CORRECTAMENTE!")

                cbxIDOC.Text = ""
                txtNumFactura.Text = ""
                txtNumRemito.Text = ""
                lstCantidad.Items.Clear()
                lstInsumos.Items.Clear()
                lblProveedor.Visible = False
                lblTotal.Visible = False
                dtpFechaFactura.Value = Date.Today
                dtpFechaRemito.Value = Date.Today

                Me.Close()
                MenuStock.Show()

            Else
                If error1 = False Then
                    MsgBox("COMPLETE LOS ESPACIOS VACIOS!", MsgBoxStyle.Critical)
                End If

            End If
        Else
            MsgBox("LAS FECHAS DEL REMITO Y LA FACTURA DEL PROVEEDOR NO PUEDEN SER FUTURAS")

        End If

    End Sub

    Private Sub btnReclamo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReclamo.Click
        Try
            descrp = InputBox("Ingrese la descripcion del Reclamo a " & lblProveedor.Text & "")
        Catch ex As Exception
        End Try

        If dtpFechaFactura.Value.Date <= Date.Today And dtpFechaRemito.Value.Date <= Date.Today Then
            If txtNumFactura.Text <> "" And txtNumRemito.Text <> "" And descrp <> "" Then

                sql = "insert into facturaproveedor values ('','" & Format(dtpFechaFactura.Value.Date, "yyyy/MM/dd") & "'," & lblTotal.Text & "," & txtNumFactura.Text & "," & idprov & "," & cbxIDOC.Text & ",'CANCELADA')"
                cargar(sql)

                sql = "select max(idfacturaproveedor) from facturaproveedor"
                cargar(sql)
                While rs.Read = True
                    maxidfactura = rs(0)
                End While
                sql = "insert into remito values (''," & txtNumRemito.Text & ",'" & Format(dtpFechaRemito.Value.Date, "yyyy/MM/dd") & "'," & cbxIDOC.Text & ",'CANCELADO'," & maxidfactura & ")"
                cargar(sql)


                sql = "insert into reclamos values (''," & cbxIDOC.Text & ", " & idprov & ",'" & descrp & "'," & maxidfactura & ")"
                cargar(sql)

                sql = "select max(idreclamo) from reclamos"
                cargar(sql)
                While rs.Read = True
                    maxidreclamo = rs(0)
                End While

                Reclamo_Imprimir.lblNroRec.Text = maxidreclamo
                Reclamo_Imprimir.lblNumFactura.Text = txtNumFactura.Text
                Reclamo_Imprimir.lblNumOC.Text = cbxIDOC.Text
                Reclamo_Imprimir.lblNomProv.Text = lblProveedor.Text
                Reclamo_Imprimir.lblTotal.Text = lblTotal.Text
                Reclamo_Imprimir.txtDescrp.Text = descrp

                sql = "select nombreproducto,cantidadfila,tipo from detalleordencompra where idordencompra = " & cbxIDOC.Text
                cargar(sql)
                While rs.Read = True
                    Reclamo_Imprimir.lstConcepto.Items.Add(" " & rs(0).ToString & " ( " & rs(2).ToString & " )")
                    If rs(2).ToString = "PROD" Then
                        Reclamo_Imprimir.lstCantidad.Items.Add(rs(1) & " Unidades ")
                    Else
                        Reclamo_Imprimir.lstCantidad.Items.Add(rs(1) & " KG")
                    End If
                End While

                cbxIDOC.Text = ""
                txtNumFactura.Text = ""
                txtNumRemito.Text = ""
                lstCantidad.Items.Clear()
                lstInsumos.Items.Clear()
                lblProveedor.Visible = False
                lblTotal.Visible = False
                dtpFechaFactura.Value = Date.Today
                dtpFechaRemito.Value = Date.Today



                Me.Close()
                Reclamo_Imprimir.Show()



            Else
                MsgBox("COMPLETE LOS ESPACIOS VACIOS!", MsgBoxStyle.Critical)

            End If
        Else
            MsgBox("LAS FECHAS DEL REMITO Y LA FACTURA DEL PROVEEDOR NO PUEDEN SER FUTURAS")
        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        cbxIDOC.Text = ""
        txtNumFactura.Text = ""
        txtNumRemito.Text = ""
        lstCantidad.Items.Clear()
        lstInsumos.Items.Clear()
        lblProveedor.Visible = False
        lblTotal.Visible = False
        dtpFechaFactura.Value = Date.Today
        dtpFechaRemito.Value = Date.Today

        Me.Close()
        MenuStock.Show()


    End Sub

    Private Sub txtNumFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumFactura.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumFactura.TextChanged

    End Sub

    Private Sub txtNumRemito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumRemito.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumRemito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumRemito.TextChanged

    End Sub
End Class