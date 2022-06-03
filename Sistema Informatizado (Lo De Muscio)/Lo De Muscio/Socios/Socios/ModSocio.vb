Imports System.Data.Odbc

Public Class frmModSocio

    Dim x As Integer
    Dim nom As String
    Dim ape As String
    Dim dni As Integer
    Dim tel As String
    Dim mail As String
    Dim loc As String
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim id As Integer
    Dim id2 As Integer

    Private Sub btnVolverModSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverModSocio.Click
        Me.Close()
        frmSocios.Show()

    End Sub

    Private Sub frmModSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from socios where estado=1"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvModSocio.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvModSocio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModSocio.CellClick
        Try
        id = dgvModSocio.Rows(e.RowIndex).Cells("IdSocio").Value
        nom = dgvModSocio.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
        ape = dgvModSocio.Rows(e.RowIndex).Cells("Apellido").Value.ToString()
        dni = dgvModSocio.Rows(e.RowIndex).Cells("Dni").Value
        tel = dgvModSocio.Rows(e.RowIndex).Cells("Telefono").Value.ToString
        mail = dgvModSocio.Rows(e.RowIndex).Cells("Email").Value.ToString
        loc = dgvModSocio.Rows(e.RowIndex).Cells("Localidad").Value.ToString
            MsgBox("Socio seleccionado: " & dgvModSocio.Rows(e.RowIndex).Cells("Nombre").Value & " " & dgvModSocio.Rows(e.RowIndex).Cells("Apellido").Value)

            id2 = id
            txtNomModSocio.Text = nom
            txtApeModSocio.Text = ape
            txtTelModSocio.Text = tel
            txtEmailModSocio.Text = mail
            txtDniModSocio.Text = dni
            txtLocModSocio.Text = loc

        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnModSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModSocio.Click
        If txtApeModSocio.Text <> "" And txtDniModSocio.Text <> "" And txtEmailModSocio.Text <> "" And txtLocModSocio.Text <> "" And txtNomModSocio.Text <> "" And txtTelModSocio.Text <> "" Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "Nombre: " & txtNomModSocio.Text & vbCrLf & "Apellido: " & txtApeModSocio.Text & vbCrLf & "Telefono: " & txtTelModSocio.Text & vbCrLf & "DNI: " & txtDniModSocio.Text & vbCrLf & "E-Mail: " & txtEmailModSocio.Text & vbCrLf & "Localidad: " & txtLocModSocio.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "update socios set nombre='" & txtNomModSocio.Text & "', apellido='" & txtApeModSocio.Text & "', telefono='" & txtTelModSocio.Text & "',dni=" & txtDniModSocio.Text & ", email='" & txtEmailModSocio.Text & "',Localidad='" & txtLocModSocio.Text & "' where idsocio=" & id2
                cargar(sql)
                txtApeModSocio.Text = ""
                txtDniModSocio.Text = ""
                txtBuscarNom.Text = ""
                txtNomModSocio.Text = ""
                txtTelModSocio.Text = ""
                txtLocModSocio.Text = ""
                txtEmailModSocio.Text = ""
                MsgBox("Socio modificado correctamente")
                ds.Tables.Clear()

                sql = "select * from socios"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvModSocio.DataSource = ds.Tables("XX")
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtNombreIngrBusc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNom.TextChanged
        If txtBuscarNom.Text <> "" Then
            dsbu.Tables.Clear()
            sql = "select * from socios where estado=1 and Nombre like '%" & txtBuscarNom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvModSocio.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from socios where estado=1"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvModSocio.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub dgvModSocio_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModSocio.CellContentClick

    End Sub
End Class