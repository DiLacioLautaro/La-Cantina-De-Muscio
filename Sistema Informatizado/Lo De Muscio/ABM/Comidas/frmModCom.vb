Imports System.Data.Odbc
Public Class frmModCom
    Dim sql As String
    Dim ds As New DataSet
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim da As OdbcDataAdapter
    Dim idcom As Integer
    Dim id2 As Integer
    Dim nombrecom As String
    Dim precio As Integer
    Dim x As Integer




    Private Sub frmModCom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "select * from comidas"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvComidas.DataSource = ds.Tables("XX")
    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from comidas where Nombrecomida like '%" & txtBuscarCom.Text & "%'"
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




    Private Sub dgvComidas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComidas.CellClick
        Try
            idcom = dgvComidas.Rows(e.RowIndex).Cells("Idcom").Value
            nombrecom = dgvComidas.Rows(e.RowIndex).Cells("Nombrecomida").Value.ToString()
            precio = dgvComidas.Rows(e.RowIndex).Cells("Precio").Value

            id2 = idcom

            txtNomComida.Text = nombrecom
            txtPrecioCom.Text = precio

            btnModificarCom.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificarCom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificarCom.Click
        If id2 = 0 Then
            MsgBox("SELECCIONAR UNA COMIDA", MsgBoxStyle.Critical)
        Else
            If txtNomComida.Text <> "" And txtPrecioCom.Text <> "" Then
                x = MsgBox("Los datos son correctos?" & vbCrLf & "Nombre: " & txtNomComida.Text & vbCrLf & "Precio: " & txtPrecioCom.Text & vbCrLf, MsgBoxStyle.YesNo)
                If x = 6 Then

                    sql = "update comidas set nombrecomida='" & txtNomComida.Text & "', precio =" & txtPrecioCom.Text & " where idcom = " & id2
                    cargar(sql)

                    MsgBox("Comida Modificada Correctamente!")
                    dgvComidas.ClearSelection()
                    txtBuscarCom.Text = ""
                    txtNomComida.Text = ""
                    txtPrecioCom.Text = ""

                    ds.Tables.Clear()
                    sql = "select * from comidas"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvComidas.DataSource = ds.Tables("XX")


                End If

            Else
                MsgBox("NO DEJE ESPACIOS VACIOS!", MsgBoxStyle.Critical)

            End If
        End If
        
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub txtPrecioCom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCom.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class