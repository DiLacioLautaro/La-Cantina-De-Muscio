Imports System.Data.Odbc

Public Class frmModProd

    Dim x As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim nom As String
    Dim id As Integer
    Dim pp As Integer
    Dim pu As Integer

    Private Sub btnVolverMProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMProd.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmModProd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds.Tables.Clear()
        sql = "select * from productos"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvModProd.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvModProd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModProd.CellClick
        Try
            id = dgvModProd.Rows(e.RowIndex).Cells("IdProd").Value
            nom = dgvModProd.Rows(e.RowIndex).Cells("NombreProducto").Value
            pu = dgvModProd.Rows(e.RowIndex).Cells("PrecioUnitario").Value
            pp = dgvModProd.Rows(e.RowIndex).Cells("puntopedido").Value
            MsgBox("PRODUCTO SELECCIONADO: " & nom)

            txtNomProdMod.Text = nom
            txtPUprodMod.Text = pu
            txtPP.Text = pp
        Catch ex As Exception

        End Try
        
    End Sub



    Private Sub btnModProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModProd.Click
        If id = 0 Then
            MsgBox("SELECCIONAR UN PRODUCTO", MsgBoxStyle.Critical)
        Else
            If txtNomProdMod.Text <> "" And txtPUprodMod.Text <> "" And txtPP.Text <> "" Then
                x = MsgBox("Los datos son correctos?" & vbCrLf & "Nombre: " & txtNomProdMod.Text & vbCrLf & "Precio unitario: " & txtPUprodMod.Text & vbCrLf & "Punto De Pedido: " & txtPP.Text, MsgBoxStyle.YesNo)
                If x = 6 Then
                    sql = "update productos set nombreproducto='" & txtNomProdMod.Text & "', preciounitario=" & txtPUprodMod.Text & " where idprod=" & id
                    cargar(sql)
                    txtNomProdMod.Text = ""
                    txtPUprodMod.Text = ""
                    txtPP.Text = ""
                    MsgBox("Producto modificado correctamente")

                    ds.Tables.Clear()
                    sql = "select * from productos"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    dgvModProd.DataSource = ds.Tables("XX")
                End If
            Else
                MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
            End If
        End If
       
    End Sub


    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from productos where Nombreproducto like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvModProd.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from productos"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvModProd.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub txtPUprodMod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPUprodMod.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
