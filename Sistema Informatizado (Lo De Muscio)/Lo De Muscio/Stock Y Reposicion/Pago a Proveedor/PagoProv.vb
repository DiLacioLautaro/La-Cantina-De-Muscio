Imports System.Data.Odbc
Public Class PagoProv
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
    Dim idremito As Integer
    Dim idprov As Integer
    Dim idfactura As Integer
    Dim numcheque As Integer


    Private Sub PagoProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select idremito from remito where estadoremito = 'ENPROCESO'"
        cargar(sql)
        While rs.Read = True
            idremito = rs(0)
            cbxIDR.Items.Add(rs(0))
        End While
    End Sub

    Private Sub cbxIDR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxIDR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbxIDR_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxIDR.SelectedIndexChanged
        sql = "select * from remito where idremito = " & cbxIDR.Text
        cargar(sql)
        While rs.Read = True
            idfactura = rs(5)
            sql = "select * from facturaproveedor where idfacturaproveedor = " & rs(5)
            cargar1(sql)
            While rs1.Read = True
                idprov = rs1(4)
                sql = "select nombre from proveedor where idproveedor =" & rs1(4)
                cargar(sql)
                While rs.Read = True
                    lblProveedor.Text = rs(0).ToString
                End While
                lblOrdenCompra.Text = rs1(5)
                lblTotal.Text = rs1(2)

            End While
        End While
        btnGenerarCheque.Enabled = True
        lblOrdenCompra.Visible = True
        lblTotal.Visible = True
        lblProveedor.Visible = True
        sql = "select max(numcheque) from cheques"
        cargar(sql)
        While rs.Read = True
            numcheque = rs(0) + 1
        End While
        txtNroCheque.Text = numcheque
    End Sub

    Private Sub btnGenerarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCheque.Click
        Try
            If txtNroCheque.Text <> "" Or Val(txtNroCheque.Text) < 0 Then
         
                sql = "insert into cheques values (''," & Val(txtNroCheque.Text) & "," & cbxIDR.Text & "," & idfactura & "," & idprov & "," & lblTotal.Text & ",'" & Format(Date.Today, "yyyy/MM/dd") & "' )"
                cargar(sql)

                sql = "update facturaproveedor set estado = 'PAGADA' where idfacturaproveedor = " & idfactura
                cargar(sql)

                sql = "update remito set estadoremito = 'FINALIZADO' where idfacturaproveedor = " & idfactura
                cargar(sql)

                sql = "insert into gastos values (''," & Val(lblTotal.Text) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','Pago a " & lblProveedor.Text & " ')"
                cargar(sql)



                Cheque.lblProveedor.Text = lblProveedor.Text
                Cheque.lblCantNum.Text = lblTotal.Text
                Cheque.lblCantTexto.Text = Num2Text(Val(lblTotal.Text))
                Cheque.txtFecha.Text = Date.Today
                Cheque.txtNroCheque.Text = txtNroCheque.Text
                sql = "select idempleado from usuarios where usuario ='" & Modulo.user & "'"
                cargar(sql)
                While rs.Read = True
                    sql = "select nombre,apellido from empleados where idempleado = '" & rs(0) & "'"
                    cargar1(sql)
                    While rs1.Read = True
                        Cheque.txtFirmadoPor.Text = rs1(0) & " " & rs1(1)
                    End While
                End While
                MsgBox("PAGO REGISTRADO CORRECTAMENTE!")
                Me.Close()
                Cheque.Show()

                txtNroCheque.Text = ""
                cbxIDR.Text = ""
                lblOrdenCompra.Visible = False
                lblProveedor.Visible = False
                lblTotal.Visible = False
                btnGenerarCheque.Enabled = False



            Else
                MsgBox("INGRESE EL NRO DEL CHEQUE CON EL QUE VA A PAGAR A " & lblProveedor.Text)
            End If
        Catch ex As Exception
            MsgBox("ERROR AL INGRESAR EL CHEQUE, INTENTE DENUEVO!")
        End Try

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        MenuStock.Show()
        txtNroCheque.Text = ""
        cbxIDR.Text = ""
        lblOrdenCompra.Visible = False
        lblProveedor.Visible = False
        lblTotal.Visible = False
        btnGenerarCheque.Enabled = False
    End Sub
End Class