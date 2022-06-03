Imports System.Data.Odbc
Public Class frmBorrarCom
    Dim sql As String
    Dim ds As New DataSet
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim da As OdbcDataAdapter
    Dim idcom As Integer
    Dim nombrecom As String
    Dim precio As Integer
    Dim x As Integer


    Private Sub frmBorrarCom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "select * from comidas"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvComidas.DataSource = ds.Tables("XX")
    End Sub

    Private Sub txtNombreComBusc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreComBusc.TextChanged
        If txtNombreComBusc.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from comidas where Nombrecomida like '%" & txtNombreComBusc.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvComidas.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from comidas"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvComidas.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub dgvComidas_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComidas.CellClick
        Try
            idcom = dgvComidas.Rows(e.RowIndex).Cells("Idcom").Value
            nombrecom = dgvComidas.Rows(e.RowIndex).Cells("Nombrecomida").Value.ToString()
            precio = dgvComidas.Rows(e.RowIndex).Cells("Precio").Value
        Catch ex As Exception

        End Try
        

        btnBorrarComida.Enabled = True
    End Sub

    Private Sub btnBorrarComida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrarComida.Click
        If idcom = 0 Then
            MsgBox("SELECCIONAR UNA COMIDA", MsgBoxStyle.Critical)
        Else
            x = MsgBox("Quiere borrar esta comida? " & vbCrLf & "Nombre: " & nombrecom & vbCrLf & "Precio: " & precio & vbCrLf, MsgBoxStyle.YesNo)
            If x = 6 Then

                sql = "delete from ingredientes_comidas where idcom = " & idcom
                cargar(sql)

                sql = "delete from comidas where idcom = " & idcom
                cargar(sql)


                MsgBox("Comida Borrada Correctamente!")
                dgvComidas.ClearSelection()
                txtNombreComBusc.Text = ""

                ds.Tables.Clear()

                sql = "select * from comidas"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvComidas.DataSource = ds.Tables("XX")

                btnBorrarComida.Enabled = False
            End If
        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmABM.Show()

    End Sub

    Private Sub dgvComidas_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComidas.CellContentClick

    End Sub
End Class