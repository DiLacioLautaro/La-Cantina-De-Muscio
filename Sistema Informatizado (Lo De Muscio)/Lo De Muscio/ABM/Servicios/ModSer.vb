Imports System.Data.Odbc

Public Class frmModServ

    Dim x As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim nom As String
    Dim pre As String
    Dim id As Integer
    Dim id2 As Integer


    Private Sub btnVolverMServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMServ.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmModServ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from precioservicios"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvModServ.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvModServ_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModServ.CellClick
        Try
            id = dgvModServ.Rows(e.RowIndex).Cells("idservpr").Value
            nom = dgvModServ.Rows(e.RowIndex).Cells("nombreservicio").Value
            pre = dgvModServ.Rows(e.RowIndex).Cells("precio").Value
            MsgBox("servicio seleccionado: " & nom)

            txtNomServ.Text = nom
            txtPrecioSer.Text = pre
        Catch ex As Exception

        End Try
        
    End Sub


    Private Sub btnModServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModServ.Click
        If id = 0 Then
            MsgBox("SELECCIONAR UN SERVICIO", MsgBoxStyle.Critical)
        Else
            If txtNomServ.Text <> "" And txtPrecioSer.Text <> "" Then
                x = MsgBox("los datos son correctos? " & vbCrLf & "nombre: " & txtNomServ.Text & vbCrLf & "precio: " & txtPrecioSer.Text, MsgBoxStyle.YesNo)
                If x = 6 Then
                    sql = "update precioservicios set nombreservicio='" & txtNomServ.Text & "',precio=" & txtPrecioSer.Text & " where idservpr=" & id
                    cargar(sql)
                    txtNomServ.Text = ""
                    txtPrecioSer.Text = ""
                    MsgBox("Servicio modificado")

                    ds.Tables.Clear()
                    sql = "select * from precioservicios"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvModServ.DataSource = ds.Tables("XX")

                End If
            Else
                MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
            End If
        End If
        
    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from precioservicios where Nombreservicio like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvModServ.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from precioservicios"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvModServ.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub txtPrecioSer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioSer.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class