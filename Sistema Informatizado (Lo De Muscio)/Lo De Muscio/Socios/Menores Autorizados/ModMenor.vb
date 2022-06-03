Imports System.Data.Odbc


Public Class frmModMenor

    Dim x As Integer
    Dim nom As String
    Dim ape As String
    Dim mon As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim id2 As Integer

    Private Sub btnVolverModSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverModSocio.Click
        txtApeMenor.Text = ""
        txtBuscarMenor.Text = ""
        txtMonto.Text = ""
        txtNomMenor.Text = ""

        Me.Close()
        frmSocios.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from autorizaciones"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvModMenor.DataSource = ds.Tables("XX")
    End Sub


    Private Sub dgvModMenor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModMenor.CellClick
        Try
        id = dgvModMenor.Rows(e.RowIndex).Cells("ida").Value
        nom = dgvModMenor.Rows(e.RowIndex).Cells("nombremenor").Value
        ape = dgvModMenor.Rows(e.RowIndex).Cells("apellidomenor").Value
        mon = dgvModMenor.Rows(e.RowIndex).Cells("monto").Value
            MsgBox("Menor seleccionado: " & nom & " " & ape)
            id2 = id
            txtNomMenor.Text = nom
            txtApeMenor.Text = ape
            txtMonto.Text = mon
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnModSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModSocio.Click
        If id2 <> 0 Then
            If txtApeMenor.Text <> "" And txtMonto.Text <> "" And txtNomMenor.Text <> "" Then
                x = MsgBox("Los datos son correctos? " & vbCrLf & "Nombre: " & txtNomMenor.Text & vbCrLf & "Apellido: " & txtApeMenor.Text & vbCrLf & "Monto: " & txtMonto.Text, MsgBoxStyle.YesNo)
                If x = 6 Then
                    sql = "update autorizaciones set nombremenor='" & txtNomMenor.Text & "', apellidomenor='" & txtApeMenor.Text & "', montomensual= " & txtMonto.Text & "  where ida=" & id2
                    cargar(sql)

                    MsgBox("Autorización Modificada correctamente")

                    ds.Tables.Clear()
                    sql = "select * from autorizaciones"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvModMenor.DataSource = ds.Tables("XX")

                    AutorizacionMenor.lblAutorizacion.Text = id2
                    AutorizacionMenor.lblNombre.Text = " " & txtNomMenor.Text & "  " & txtApeMenor.Text & " "
                    sql = "select nombre, apellido from socios where idsocio = " & id2
                    cargar(sql)
                    While rs.Read = True
                        AutorizacionMenor.lblMayor.Text = " " & rs(0).ToString & "  " & rs(1).ToString & " "
                    End While

                    Me.Hide()
                    AutorizacionMenor.Show()

                    txtApeMenor.Text = ""
                    txtNomMenor.Text = ""
                    txtMonto.Text = ""
                    txtBuscarMenor.Text = ""

                Else
                    MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
                End If
            End If
        Else
            MsgBox("NO SE SELECCIONÓ NINGUN MENOR", MsgBoxStyle.Critical)
        End If

    End Sub



    Private Sub txtBuscarMenor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMenor.TextChanged
        If txtBuscarMenor.Text <> "" Then
            dsbu.Tables.Clear()
            sql = "select * from autorizaciones where Nombremenor like '%" & txtBuscarMenor.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvModMenor.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from autorizaciones"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvModMenor.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgvModMenor_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModMenor.CellContentClick

    End Sub
End Class