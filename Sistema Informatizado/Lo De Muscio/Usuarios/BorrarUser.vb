Imports System.Data.Odbc

Public Class frmBorrarUser

    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim id As Integer
    Dim x As Integer

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmUsuarios.Show()
    End Sub

    Private Sub frmBorrarUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()

        sql = "select idusuario, usuario, idempleado, permisos from usuarios where idusuario not in (select idusuario from usuarios where idusuario=" & Inicio_Sesion.rsid(0) & ")"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvUsers.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvUsers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Try
            id = dgvUsers.Rows(e.RowIndex).Cells("idusuario").Value
            MsgBox("Usuario seleccionado: " & dgvUsers.Rows(e.RowIndex).Cells("usuario").Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If id = 0 Then
            MsgBox("SELECCIONAR UN USUARIO", MsgBoxStyle.Critical)
        Else
            x = MsgBox("Desea eliminar el usuario?", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "delete from usuarios where idusuario=" & id
                cargar(sql)
                MsgBox("Usuario eliminado")
                txtBuscar.Text = ""

                ds.Tables.Clear()

                sql = "select idusuario, usuario, idempleado, permisos from usuarios where idusuario not in (select idusuario from usuarios where usuario='" & Inicio_Sesion.txtUsuario.Text & "')"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvUsers.DataSource = ds.Tables("XX")
                id = 0

            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            ds.Tables.Clear()

            sql = "select idusuario, usuario, idempleado, permisos from usuarios where idusuario not in (select idusuario from usuarios where usuario='" & Inicio_Sesion.txtUsuario.Text & "')"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvUsers.DataSource = ds.Tables("XX")
        Else
            ds.Tables.Clear()

            sql = "select idusuario, usuario, idempleado, permisos from usuarios where usuario like '%" & txtBuscar.Text & "%' and idusuario not in (select idusuario from usuarios where usuario='" & Inicio_Sesion.txtUsuario.Text & "')"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvUsers.DataSource = ds.Tables("XX")
        End If
    End Sub

End Class