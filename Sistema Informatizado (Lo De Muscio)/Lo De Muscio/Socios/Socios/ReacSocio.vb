Imports System.Data.Odbc

Public Class frmReacSocio

    Dim x As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsb As New DataSet
    Dim dab As OdbcDataAdapter
    Dim nom As String
    Dim ape As String
    Dim dni As Integer
    Dim tel As String
    Dim mail As String
    Dim loc As String
    Dim id As Integer
    Dim id2 As Integer



    Private Sub btnVolverRProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverRProv.Click
        Me.Close()
        frmSocios.Show()
    End Sub

    Private Sub frmReacSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Clear()
        sql = "select * from socios where estado=0"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvReacSocio.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvReacSocio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReacSocio.CellClick
        Try
            id = dgvReacSocio.Rows(e.RowIndex).Cells("idsocio").Value
            nom = dgvReacSocio.Rows(e.RowIndex).Cells("nombre").Value
            ape = dgvReacSocio.Rows(e.RowIndex).Cells("apellido").Value
            loc = dgvReacSocio.Rows(e.RowIndex).Cells("localidad").Value
            tel = dgvReacSocio.Rows(e.RowIndex).Cells("telefono").Value
            mail = dgvReacSocio.Rows(e.RowIndex).Cells("email").Value
            dni = dgvReacSocio.Rows(e.RowIndex).Cells("dni").Value
            MsgBox("Socio seleccionado: " & nom & " " & ape)

            txtApeSocio.Text = ape
            txtDniSocio.Text = dni
            txtLocSocio.Text = loc
            txtMailSocio.Text = mail
            txtNomSocio.Text = nom
            txtTelSocio.Text = tel
            id2 = id
            btnReacSocio.Enabled = True
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnReacProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReacSocio.Click
        If txtApeSocio.Text <> "" And txtDniSocio.Text <> "" And txtLocSocio.Text <> "" And txtMailSocio.Text <> "" And txtNomSocio.Text <> "" And txtTelSocio.Text <> "" Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNomSocio.Text & vbCrLf & "apellido: " & txtApeSocio.Text & vbCrLf & "DNI: " & txtDniSocio.Text & vbCrLf & "telefono: " & txtTelSocio.Text & vbCrLf & "localidad: " & txtLocSocio.Text & vbCrLf & "E-Mail: " & txtMailSocio.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql = "update socios set nombre='" & txtNomSocio.Text & "', apellido='" & txtApeSocio.Text & "',Dni=" & txtDniSocio.Text & ", telefono='" & txtTelSocio.Text & "', Email='" & txtMailSocio.Text & "', localidad='" & txtLocSocio.Text & "', estado=1 where idSocio=" & id2
                cargar(sql)
                txtApeSocio.Text = ""
                txtDniSocio.Text = ""
                txtLocSocio.Text = ""
                txtMailSocio.Text = ""
                txtNomSocio.Text = ""
                txtTelSocio.Text = ""
                id2 = 0
                id = 0
                btnReacSocio.Enabled = False

                MsgBox("SOCIO REACTIVADO CORRECTAMENTE")

                ds.Tables.Clear()
                sql = "select * from socios where estado=0"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvReacSocio.DataSource = ds.Tables("XX")
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsb.Tables.Clear()

            sql = "select * from socios where estado=0 and Nombre like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsb.Tables.Add("XX")
            dab = New OdbcDataAdapter(sql, cnn)
            dab.Fill(dsb.Tables("XX"))
            Me.dgvReacSocio.DataSource = dsb.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from socios where estado=0"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvReacSocio.DataSource = ds.Tables("XX")
        End If
    End Sub
End Class