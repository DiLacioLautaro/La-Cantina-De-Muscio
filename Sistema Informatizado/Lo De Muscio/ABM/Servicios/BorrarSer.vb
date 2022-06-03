
Imports System.Data.Odbc

Public Class frmBorrarSer

    Dim sql As String
    Dim sql2 As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim x As Integer

    Private Sub btnVolverBSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverBSer.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmBorrarSer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from precioservicios where idservpr>3"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvBorrarSer.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvBorrarSer_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrarSer.CellClick
        Try
            id = dgvBorrarSer.Rows(e.RowIndex).Cells("idservpr").Value
            MsgBox("Servicio seleccionado: " & dgvBorrarSer.Rows(e.RowIndex).Cells("nombreservicio").Value)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnBorrarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarProv.Click
        If id > 0 Then
            x = MsgBox("DESEA BORRAR EL SERVICIO?", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "delete from precioservicios where idservpr=" & id
                cargar(sql)
                MsgBox("El servicio se borró correctamente")

                ds.Tables.Clear()
                sql = "select * from precioservicios where idservpr>3"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvBorrarSer.DataSource = ds.Tables("XX")
        End If
        Else
        MsgBox("No se seleccionó ningun servicio", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from precioservicios where Nombreservicio like '%" & txtBuscarCom.Text & "%' and idservpr>3"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvBorrarSer.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()
            sql = "select * from precioservicios where idservpr>3"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvBorrarSer.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub dgvBorrarSer_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrarSer.CellContentClick

    End Sub
End Class