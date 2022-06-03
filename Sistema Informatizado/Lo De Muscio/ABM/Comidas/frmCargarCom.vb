Imports System.Data.Odbc
Imports System.Globalization
Public Class frmCargarCom
    Dim cambio As New Globalization.CultureInfo("es-ES")
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim dacl As New DataSet
    Dim dscl As OdbcDataAdapter
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim ds4 As New DataSet
    Dim ds5 As New DataSet
    Dim ds6 As New DataSet
    Dim ds7 As New DataSet
    Dim da As OdbcDataAdapter
    Dim da1 As OdbcDataAdapter
    Dim da2 As OdbcDataAdapter
    Dim da3 As OdbcDataAdapter
    Dim da4 As OdbcDataAdapter
    Dim da5 As OdbcDataAdapter
    Dim da6 As OdbcDataAdapter
    Dim da7 As OdbcDataAdapter
    Dim banderacount As Integer
    Dim sql As String
    Dim id As Integer
    Dim NombreIngre As String
    Dim cantidad As String
    Dim puntopedido As Integer
    Dim i As Integer
    Dim x As Integer
    Dim idcom As Integer
    Dim cantt As Integer
    Dim id1 As Integer
    Dim nombreingre1 As String


    Private Sub frmCargarCom_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ds.Tables.Clear()


        sql = "select * from ingredientes"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvIngr.DataSource = ds.Tables("XX")
    End Sub

    Private Sub frmCargarCom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds.Tables.Clear()
        sql = "select * from ingredientes"
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvIngr.DataSource = ds.Tables("XX")
        sql = "truncate cargar_com"
        cargar(sql)
        i = 0
    End Sub

    Private Sub dgvIngr_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngr.CellClick


        Try
            cambio.NumberFormat.NumberDecimalSeparator = (".")
            System.Threading.Thread.CurrentThread.CurrentCulture = cambio
            id = dgvIngr.Rows(e.RowIndex).Cells("Idingr").Value
            NombreIngre = dgvIngr.Rows(e.RowIndex).Cells("NombreIngr").Value.ToString()

            cantidad = InputBox("Ingrese la cantidad a utilizar del ingrediente (EN GRAMOS) ")
            If cantidad > 0 Then
                sql = "select count(*) from cargar_com where idingr = " & id
                cargar(sql)
                While rs.Read = True
                    If rs(0) > 0 Then
                        sql = "update cargar_com set cantidad = cantidad + '" & Val(cantidad) / 1000 & "' where idingr = " & id
                        cargar1(sql)
                    Else
                        sql = "insert into cargar_com values (" & id & ",'" & NombreIngre & "'," & Val(cantidad) / 1000 & ")"
                        cargar1(sql)
                    End If

                End While
            ElseIf 0 > cantidad Then
                MsgBox("LA CANTIDAD NO PUEDE SER NEGATIVA!", MsgBoxStyle.Critical)
            ElseIf cantidad = 0 Then
                MsgBox("LA CANTIDAD NO PUEDE SER NULA!", MsgBoxStyle.Critical)
            End If


            ds1.Tables.Clear()
            sql = "select * from cargar_com"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvIngrCom.DataSource = ds1.Tables("XX")
        Catch ex As Exception
            If cantidad <> "" Then
                MsgBox("SOLO SE PUEDEN INGRESAR VALORES NUMERICOS", MsgBoxStyle.Critical)
            Else

            End If
        End Try


    End Sub

    Private Sub btnCargarComida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargarComida.Click
        sql = "select count(*) from cargar_com"
        cargar(sql)
        While rs.Read = True
            banderacount = rs(0)
        End While
        If banderacount <> 0 Then
            If txtNomComida.Text <> "" And txtPreciocom.Text <> "" Then
                x = MsgBox("Los datos son correctos?" & vbCrLf & "Nombre Del Plato: " & txtNomComida.Text & vbCrLf & "Precio: " & txtPreciocom.Text, MsgBoxStyle.YesNo)
                If x = 6 Then

                    sql = "insert into comidas values ('','" & txtNomComida.Text & "'," & txtPreciocom.Text & ")"
                    cargar(sql)
                    sql = "select max(idcom) from comidas"
                    cargar(sql)
                    While rs.Read = True
                        idcom = rs(0)
                    End While
                    sql = "select idingr, cantidad from cargar_com"
                    cargar(sql)
                    While rs.Read = True
                        sql = "insert into ingredientes_comidas values (''," & idcom & "," & rs(0) & "," & rs(1) & ")"
                        cargar1(sql)

                    End While
                    txtNomComida.Text = ""
                    txtPreciocom.Text = ""

                    MsgBox("El plato se cargó exitosamente")


                    dgvIngrCom.DataSource = Nothing
                    sql = "truncate cargar_com"
                    cargar(sql)
                    i = 0

                    ds1.Tables.Clear()
                    ds2.Tables.Clear()
                    ds3.Tables.Clear()
                    ds4.Tables.Clear()
                    ds5.Tables.Clear()
                    ds6.Tables.Clear()
                    ds7.Tables.Clear()

                End If

            Else
                MsgBox("COMPLETAR LOS ESPACIOS VACIOS", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("LA COMIDA DEBE CONTENER POR LO MENOS 1 INGREDIENTE", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub txtNombreIngrBusc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreIngrBusc.TextChanged
        dsbu.Tables.Clear()

        If txtNombreIngrBusc.Text <> "" Then
            sql = "select * from ingredientes where nombreingr like '%" & txtNombreIngrBusc.Text & "%'"
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvIngr.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select * from ingredientes"
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvIngr.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        txtNombreIngrBusc.Text = ""
        txtNomComida.Text = ""
        txtPreciocom.Text = ""


        dgvIngrCom.DataSource = Nothing
        sql = "drop table cargar_com"
        cargar(sql)
        i = 0

        ds1.Tables.Clear()
        ds2.Tables.Clear()
        ds3.Tables.Clear()
        ds4.Tables.Clear()
        ds5.Tables.Clear()
        ds6.Tables.Clear()
        ds7.Tables.Clear()
        Me.Close()
        frmABM.Show()

        dgvIngr.Enabled = True
    End Sub

    Private Sub txtPreciocom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreciocom.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub dgvIngrCom_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngrCom.CellClick
        Try
            ds1.Tables.Clear()
            dgvIngr.ClearSelection()


            id1 = dgvIngrCom.Rows(e.RowIndex).Cells("Idingr").Value
            nombreingre1 = dgvIngrCom.Rows(e.RowIndex).Cells("NombreIngr").Value.ToString()

            sql = "update cargar_com set cantidad = cantidad - 0.100 where idingr = " & id1
            cargar1(sql)

            sql = "delete from cargar_com where cantidad <= 0.00001"
            cargar(sql)

            sql = "select * from cargar_com"
            cargar(sql)
            ds1.Tables.Add("XX")
            da1 = New OdbcDataAdapter(sql, cnn)
            da1.Fill(ds1.Tables("XX"))
            Me.dgvIngrCom.DataSource = ds1.Tables("XX")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvIngrCom_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngrCom.CellContentClick

    End Sub
End Class