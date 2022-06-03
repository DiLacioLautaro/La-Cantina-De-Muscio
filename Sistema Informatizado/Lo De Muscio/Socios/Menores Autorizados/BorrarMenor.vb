Imports System.Data.Odbc

Public Class frmBorrarMenor

    Dim da As OdbcDataAdapter
    Dim ds As New DataSet
    Dim dab As OdbcDataAdapter
    Dim dsb As New DataSet
    Dim sql As String
    Dim x As Integer
    Dim id As Integer

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        txtBuscar.Text = ""
        Me.Close()
        frmSocios.Show()
    End Sub

    Private Sub frmBorrarMenor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from autorizaciones"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvMenorBorrar.DataSource = ds.Tables("XX")
    End Sub



    Private Sub dgvMenorBorrar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenorBorrar.CellClick
        Try
            id = dgvMenorBorrar.Rows(e.RowIndex).Cells("ida").Value
            MsgBox("Menor seleccionado: " & dgvMenorBorrar.Rows(e.RowIndex).Cells("Nombremenor").Value & " " & dgvMenorBorrar.Rows(e.RowIndex).Cells("apellidomenor").Value)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnBorrarMenor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarMenor.Click
        If id > 0 Then
            x = MsgBox("DESEA ELIMINAR LA AUTORIZACIÓN?", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "delete from autorizaciones where idA=" & id
                cargar(sql)
                MsgBox("AUTORIZACIÓN ELIMINADO CORRECTAMENTE")

                ds.Tables.Clear()

                sql = "select * from autorizaciones"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvMenorBorrar.DataSource = ds.Tables("XX")
                id = 0

            End If
        Else
            MsgBox("NO SE SELECCIONÓ NINGUN MENOR", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text <> "" Then

            dsb.Tables.Clear()
            sql = "select * from autorizaciones where Nombremenor like '%" & txtBuscar.Text & "%'"
            cargar(sql)
            dsb.Tables.Add("XX")
            dab = New OdbcDataAdapter(sql, cnn)
            dab.Fill(dsb.Tables("XX"))
            Me.dgvMenorBorrar.DataSource = dsb.Tables("XX")

        Else

            ds.Tables.Clear()
            sql = "select * from autorizaciones"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvMenorBorrar.DataSource = ds.Tables("XX")

        End If
    End Sub

    Private Sub dgvMenorBorrar_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenorBorrar.CellContentClick

    End Sub
End Class