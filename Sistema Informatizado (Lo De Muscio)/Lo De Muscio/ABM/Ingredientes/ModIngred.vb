Imports System.Data.Odbc

Public Class frmModIngred

    Dim x As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim nom As String
    Dim id As Integer
    Dim pp As Integer

    Private Sub btnVolverMIng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMProd.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmModIngred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from ingredientes"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvModIng.DataSource = ds.Tables("XX")
    End Sub


    Private Sub dgvModIng_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModIng.CellClick
        Try
            id = dgvModIng.Rows(e.RowIndex).Cells("IdIngr").Value
            nom = dgvModIng.Rows(e.RowIndex).Cells("NombreIngr").Value
            pp = dgvModIng.Rows(e.RowIndex).Cells("PuntoPedido").Value
            MsgBox("Ingrediente seleccionado: " & nom)

            txtNomIng.Text = nom
            txtPPing.Text = pp
        Catch ex As Exception

        End Try
        
    End Sub


    Private Sub btnModEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModIng.Click
        If txtNomIng.Text <> "" And txtPPing.Text <> "" And id <> 0 Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNomIng.Text & vbCrLf & "Punto de pedido: " & txtPPing.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "update ingredientes set nombreingr='" & txtNomIng.Text & "', puntopedido=" & txtPPing.Text & " where idingr=" & id
                cargar(sql)
                txtNomIng.Text = ""
                txtPPing.Text = ""
                MsgBox("INGREDIENTE MODIFICADO CORRECTAMENTE")
                ds.Tables.Clear()

                sql = "select * from ingredientes"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvModIng.DataSource = ds.Tables("XX")
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtPPing_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPing.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from ingredientes where Nombreingr like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvModIng.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from ingredientes"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvModIng.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub txtPPing_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPPing.TextChanged

    End Sub
End Class