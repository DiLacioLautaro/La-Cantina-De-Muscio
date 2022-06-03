Imports System.Data.Odbc

Public Class frmBorrarEmp

    Dim sql As String
    Dim sql2 As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim x As Integer

    Private Sub btnVolverBEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverBEmp.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmBorrarEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from empleados"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvBorrarEmp.DataSource = ds.Tables("XX")
    End Sub


    Private Sub dgvBorrarEmp_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrarEmp.CellClick
        Try
            id = dgvBorrarEmp.Rows(e.RowIndex).Cells("IdEmpleado").Value
            MsgBox("Empleado seleccionado: " & dgvBorrarEmp.Rows(e.RowIndex).Cells("Nombre").Value.ToString & " " & dgvBorrarEmp.Rows(e.RowIndex).Cells("Apellido").Value.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBorrarEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarEmp.Click
        If id > 0 Then
            x = MsgBox("DESEA ELIMINAR EL EMPLEADO? (SU CUENTA TAMBIEN SERÁ ELIMINADA)", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "delete from usuarios where idempleado=" & id
                cargar(sql)
                sql2 = "delete from empleados where idempleado=" & id
                cargar(sql2)
                MsgBox("Empleado eliminado correctamente")

                ds.Tables.Clear()
                sql = "select * from empleados"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvBorrarEmp.DataSource = ds.Tables("XX")
            End If
        Else
        MsgBox("No se seleccionó ningun empleado", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from empleados where Nombre like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvBorrarEmp.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from empleados"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvBorrarEmp.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub lblModEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblModEmp.Click

    End Sub
End Class