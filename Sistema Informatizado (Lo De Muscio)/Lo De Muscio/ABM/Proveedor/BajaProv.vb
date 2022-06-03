Imports System.Data.Odbc

Public Class frmBajaProv

    Dim sql As String
    Dim sql2 As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim x As Integer

    Private Sub btnVolverBProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverBProv.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmBajaProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from proveedor where estado=1"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvBajaProv.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvBajaProv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBajaProv.CellClick
        Try
            id = dgvBajaProv.Rows(e.RowIndex).Cells("idproveedor").Value
            MsgBox("Proveedor seleccionado: " & dgvBajaProv.Rows(e.RowIndex).Cells("nombre").Value & " " & dgvBajaProv.Rows(e.RowIndex).Cells("apellido").Value)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnBajaProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaProv.Click
        If id > 0 Then
            x = MsgBox("DESEA DAR DE BAJA EL PROVEEDOR?", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "update proveedor set estado=0 where idproveedor=" & id
                cargar(sql)
                MsgBox("El proveedor se dió de baja correctamente")

                ds.Tables.Clear()
                sql = "select * from proveedor where estado=1"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                dgvBajaProv.DataSource = ds.Tables("XX")
            End If
        Else
            MsgBox("No se seleccionó ningun Proveedor", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from proveedor where estado=1 and Nombre like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvBajaProv.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from proveedor where estado=1"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvBajaProv.DataSource = ds.Tables("XX")
        End If
    End Sub
End Class