Imports System.Data.Odbc


Public Class frmBorrarInG

    Dim sql As String
    Dim sql2 As String
    Dim sql3 As String
    Dim rs1 As OdbcDataReader
    Dim rs2 As OdbcDataReader
    Dim rs3 As OdbcDataReader
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim x As Integer

    Private Sub btnVolverBIng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverBIng.Click
        Me.Close()
        frmABM.Show()
    End Sub


    Private Sub frmBorrarInG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from ingredientes"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvBorrarIng.DataSource = ds.Tables("XX")
    End Sub


    Private Sub dgvBorrarIng_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrarIng.CellClick
        Try
            id = dgvBorrarIng.Rows(e.RowIndex).Cells("Idingr").Value
            MsgBox("Ingrediente seleccionado: " & dgvBorrarIng.Rows(e.RowIndex).Cells("Nombreingr").Value)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnBorrarIng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarIng.Click
        If id > 0 Then
            x = MsgBox("DESEA ELIMINAR EL INGREDIENTE? (LAS COMIDAS RELACIONADAS A ESTE SERÁN ELIMINADAS)", MsgBoxStyle.YesNo)
            If x = 6 Then

                sql = "select count(*) from provingrediente where idingr=" & id
                cmd = New OdbcCommand(sql, Modulo.cnn)
                cmd.CommandType = CommandType.Text
                rs1 = cmd.ExecuteReader()
                cmd.Dispose()

                While rs1.Read = True
                    If rs1(0) > 0 Then
                        sql2 = "delete from provingrediente where idingr=" & id
                        cmd = New OdbcCommand(sql2, Modulo.cnn)
                        cmd.CommandType = CommandType.Text
                        rs2 = cmd.ExecuteReader()
                        cmd.Dispose()
                    End If
                End While

                sql = "select idcom, count(*) from ingredientes_comidas where idingr=" & id
                cmd = New OdbcCommand(sql, Modulo.cnn)
                cmd.CommandType = CommandType.Text
                rs1 = cmd.ExecuteReader()
                cmd.Dispose()

                While rs1.Read = True

                    If rs1(1) > 0 Then

                        sql3 = "delete from ingredientes_comidas where idingr=" & id
                        cmd = New OdbcCommand(sql3, Modulo.cnn)
                        cmd.CommandType = CommandType.Text
                        rs3 = cmd.ExecuteReader()
                        cmd.Dispose()

                        While rs1.Read = True
                            sql2 = "delete from comidas where idcom=" & rs1(0)
                            cmd = New OdbcCommand(sql2, Modulo.cnn)
                            cmd.CommandType = CommandType.Text
                            rs2 = cmd.ExecuteReader()
                            cmd.Dispose()
                        End While

                    End If

                End While


                sql = "delete from ingredientes where idingr=" & id
                cargar(sql)
                MsgBox("Ingrediente eliminado correctamente")
                txtBuscarCom.Text = ""
                id = 0


                ds.Tables.Clear()
                sql = "select * from ingredientes"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                dgvBorrarIng.DataSource = ds.Tables("XX")
            End If
        Else
            MsgBox("No se seleccionó ningun ingrediente", MsgBoxStyle.Critical)
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
            Me.dgvBorrarIng.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from ingredientes"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvBorrarIng.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub lblModEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblModEmp.Click

    End Sub
End Class