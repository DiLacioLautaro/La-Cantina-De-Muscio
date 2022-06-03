Imports System.Data.Odbc

Public Class frmSocBorrar

    Dim da As OdbcDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim sql2 As String
    Dim x As Integer
    Dim id As Integer
    Dim rs2 As OdbcDataReader

    Private Sub btnVolverBSoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverBSoc.Click
        Me.Close()
        frmSocios.Show()

    End Sub

    Private Sub frmSocBorrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()

        sql = "select * from socios where estado=1"
        cargar(Sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(Sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvSocB.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvSocB_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSocB.CellClick
        Try
            id = dgvSocB.Rows(e.RowIndex).Cells("IdSocio").Value
            MsgBox("Socio seleccionado: " & dgvSocB.Rows(e.RowIndex).Cells("Nombre").Value.ToString & " " & dgvSocB.Rows(e.RowIndex).Cells("Apellido").Value.ToString)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBorrarSoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarSoc.Click
        If id > 0 Then
            x = MsgBox("DESEA ELIMINAR EL SOCIO? (SUS AUTORIZACIONES TAMBIEN SERAN ELIMINADAS)", MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "select count(*) from autorizaciones where idsocio=" & id
                cargar(sql)
                rs.Read()
                If rs(0) > 0 Then
                    While rs.Read = True
                        sql2 = "delete from autorizaciones where idsocio=" & id
                        cmd = New OdbcCommand(sql2, Modulo.cnn)
                        cmd.CommandType = CommandType.Text
                        rs2 = cmd.ExecuteReader()
                        cmd.Dispose()
                    End While
                End If
                sql = "update socios set estado=0 where idsocio=" & id
                cargar(sql)
                MsgBox("SOCIO ELIMINADO CORRECTAMENTE")

                ds.Tables.Clear()

                sql = "select * from socios where estado=1"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvSocB.DataSource = ds.Tables("XX")

            End If
        Else
            MsgBox("No se seleccionó ningun socio", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub txtBuscarNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNom.TextChanged
        If txtBuscarNom.Text <> "" Then
            ds.Tables.Clear()

            sql = "select * from socios where estado=1 and nombre like '%" & txtBuscarNom.Text & "%'"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvSocB.DataSource = ds.Tables("XX")
        Else
            ds.Tables.Clear()

            sql = "select * from socios where estado=1"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvSocB.DataSource = ds.Tables("XX")
        End If
    End Sub
End Class