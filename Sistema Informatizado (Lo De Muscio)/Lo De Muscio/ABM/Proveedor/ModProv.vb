﻿Imports System.Data.Odbc

Public Class frmModProv

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
    Dim dir As String
    Dim pais As String
    Dim id As Integer

    Private Sub btnVolverMProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMProv.Click
        Me.Close()
        frmABM.Show()
    End Sub

    Private Sub ModProv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds.Tables.Clear()
        sql = "select * from proveedor where estado=1"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvModProv.DataSource = ds.Tables("XX")
    End Sub

    Private Sub dgvModProv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModProv.CellClick
        Try
            id = dgvModProv.Rows(e.RowIndex).Cells("idproveedor").Value
            nom = dgvModProv.Rows(e.RowIndex).Cells("nombre").Value
            dir = dgvModProv.Rows(e.RowIndex).Cells("direccion").Value
            tel = dgvModProv.Rows(e.RowIndex).Cells("telefono").Value
            pais = dgvModProv.Rows(e.RowIndex).Cells("pais").Value
            dni = dgvModProv.Rows(e.RowIndex).Cells("CUIT").Value
            MsgBox("proveedor seleccionado: " & nom)

            txtNomProv.Text = nom
            txtDirProv.Text = dir
            txtDniProv.Text = dni
            txtPaisProv.Text = pais
            txtTelProv.Text = tel
        Catch ex As Exception

        End Try

        
    End Sub



    Private Sub btnModProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModProv.Click
        If id = 0 Then
            MsgBox("SELECCIONAR UN PROVEEDOR", MsgBoxStyle.Critical)
        Else
            If txtNomProv.Text <> "" And txtDirProv.Text <> "" And txtDniProv.Text <> "" And txtPaisProv.Text <> "" And txtTelProv.Text <> "" Then
                x = MsgBox("Los datos son correctos?" & vbCrLf & "nombre: " & txtNomProv.Text & vbCrLf & "CUIT: " & txtDniProv.Text & vbCrLf & "telefono: " & txtTelProv.Text & vbCrLf & "Dirección: " & txtDirProv.Text & vbCrLf & "País: " & txtPaisProv.Text, MsgBoxStyle.YesNo)
                If x = 6 Then
                    sql = "update proveedor set nombre='" & txtNomProv.Text & "',CUIT=" & txtDniProv.Text & ", telefono='" & txtTelProv.Text & "', direccion='" & txtDirProv.Text & "', pais='" & txtPaisProv.Text & "' where idProveedor=" & id
                    cargar(sql)
                    txtNomProv.Text = ""
                    txtDirProv.Text = ""
                    txtDniProv.Text = ""
                    txtPaisProv.Text = ""
                    txtTelProv.Text = ""
                    MsgBox("EMPLEADO MODIFICADO CORRECTAMENTE")

                    ds.Tables.Clear()
                    sql = "select * from proveedor where estado=1"
                    cargar(sql)
                    ds.Tables.Add("XX")
                    da = New OdbcDataAdapter(sql, cnn)
                    da.Fill(ds.Tables("XX"))
                    Me.dgvModProv.DataSource = ds.Tables("XX")
                End If
            Else
                MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub txtBuscarCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCom.TextChanged
        If txtBuscarCom.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select * from proveedor where estado=1 and Nombre like '%" & txtBuscarCom.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvModProv.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from proveedor where estado=1"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvModProv.DataSource = ds.Tables("XX")
        End If

    End Sub

    Private Sub txtDniProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDniProv.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class