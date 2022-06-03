Imports System.Data.Odbc

Public Class frmCamPerm

    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim x As Integer

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        txtBuscar.Text = ""
        Me.Close()
        frmUsuarios.Show()
    End Sub

    Private Sub frmCamPerm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()

        sql = "select idusuario, usuario, idempleado, permisos from usuarios"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvUsers.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvUsers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Try
            id = dgvUsers.Rows(e.RowIndex).Cells("idusuario").Value
            cmbPermUser.Text = dgvUsers.Rows(e.RowIndex).Cells("permisos").Value
            MsgBox("Usuario seleccionado: " & dgvUsers.Rows(e.RowIndex).Cells("usuario").Value)

        Catch ex As Exception

        End Try
        
    End Sub



    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If id = 0 Or cmbPermUser.Text = "" Then
            MsgBox("SELECCIONAR UN USUARIO", MsgBoxStyle.Critical)
        Else
            x = MsgBox("Desea modificar los permisos del Usuario?", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "update usuarios set permisos='" & cmbPermUser.Text & "' where idusuario=" & id
                cargar(sql)
                MsgBox("Permisos modificados correctamente")
                txtBuscar.Text = ""
                id = 0
                cmbPermUser.Text = ""


                ds.Tables.Clear()

                sql = "select idusuario, usuario, idempleado, permisos from usuarios"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvUsers.DataSource = ds.Tables("XX")
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            ds.Tables.Clear()

            sql = "select idusuario, usuario, idempleado, permisos from usuarios"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvUsers.DataSource = ds.Tables("XX")
        Else
            ds.Tables.Clear()

            sql = "select idusuario, usuario, idempleado, permisos from usuarios where usuario like '%" & txtBuscar.Text & "%'"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvUsers.DataSource = ds.Tables("XX")
        End If

    End Sub

    Private Sub cmbPermUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPermUser.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbPermUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPermUser.SelectedIndexChanged

    End Sub
End Class