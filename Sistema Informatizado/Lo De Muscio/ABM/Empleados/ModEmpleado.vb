Imports System.Data.Odbc

Public Class frmModEmpleado

    Dim x As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim nom As String
    Dim ape As String
    Dim dni As Integer
    Dim tel As String
    Dim tipo As String
    Dim id As Integer
    Dim sql2 As String

    Private Sub btnVolverMEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMEmp.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub frmModEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from empleados"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvModEmp.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvModEmp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModEmp.CellClick
        Try
            id = dgvModEmp.Rows(e.RowIndex).Cells("IdEmpleado").Value
            nom = dgvModEmp.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            ape = dgvModEmp.Rows(e.RowIndex).Cells("Apellido").Value.ToString()
            dni = dgvModEmp.Rows(e.RowIndex).Cells("Dni").Value
            tel = dgvModEmp.Rows(e.RowIndex).Cells("Telefono").Value.ToString
            tipo = dgvModEmp.Rows(e.RowIndex).Cells("TipoEmpleado").Value.ToString
            MsgBox("Empleado seleccionado: " & nom & " " & ape)

            txtNomModEmp.Text = nom
            txtApeModEmp.Text = ape
            txtDniModEmp.Text = dni
            txtTelModEmp.Text = tel
            cmbTipoModEmp.Text = tipo
        Catch ex As Exception

        End Try



    End Sub




    Private Sub btnModEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModEmp.Click
        If txtNomModEmp.Text <> "" And txtApeModEmp.Text <> "" And txtDniModEmp.Text <> "" And txtTelModEmp.Text <> "" And cmbTipoModEmp.Text <> "" Then
            x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNomModEmp.Text & vbCrLf & "apellido: " & txtApeModEmp.Text & vbCrLf & "DNI: " & txtDniModEmp.Text & vbCrLf & "telefono: " & txtTelModEmp.Text & vbCrLf & "cargo: " & cmbTipoModEmp.Text, MsgBoxStyle.YesNo)
            If x = 6 Then
                sql2 = "update empleados set nombre='" & txtNomModEmp.Text & "', apellido='" & txtApeModEmp.Text & "',Dni=" & txtDniModEmp.Text & ", telefono='" & txtTelModEmp.Text & "', tipoempleado='" & cmbTipoModEmp.Text & "' where idempleado=" & id
                cargar(sql2)
                txtNomModEmp.Text = ""
                txtApeModEmp.Text = ""
                txtDniModEmp.Text = ""
                txtTelModEmp.Text = ""
                cmbTipoModEmp.Text = ""
                MsgBox("EMPLEADO MODIFICADO CORRECTAMENTE")

                ds.Tables.Clear()
                sql = "select * from empleados"
                cargar(sql)
                ds.Tables.Add("XX")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX"))
                Me.dgvModEmp.DataSource = ds.Tables("XX")
            End If
        Else
            MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from empleados where Nombre like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvModEmp.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from empleados"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvModEmp.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub txtDniModEmp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDniModEmp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class