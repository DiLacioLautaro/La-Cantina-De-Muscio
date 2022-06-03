Imports System.Data.Odbc
Public Class CierreDiario
    Dim sql As String
    Dim ingresos As Integer
    Dim neto As Integer
    Dim gastos As Integer

    Private Sub CierreDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblFecha.Text = Date.Today
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        txtGastos.Text = ""
        txtIngresos.Text = ""
        txtNeto.Text = ""
        Me.Hide()
        MenuCierreCaja.Show()
    End Sub


    Private Sub btnDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiario.Click
        sql = "select * from ingresos where fecha = '" & Format(Date.Today, "yyyy/MM/dd") & "'"
        cargar(sql)
        ingresos = 0
        While rs.Read = True
            ingresos = ingresos + rs(1)
        End While
        sql = "select * from gastos where fecha = '" & Format(Date.Today, "yyyy/MM/dd") & "'"
        cargar(sql)
        gastos = 0
        While rs.Read = True
            gastos = gastos + rs(1)
        End While

        neto = ingresos - gastos

        txtIngresos.Text = ingresos
        txtGastos.Text = gastos
        txtNeto.Text = neto

        btnCargarCierreDiario.Enabled = True

    End Sub

    Private Sub btnCargarCierreDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarCierreDiario.Click
        sql = "insert into caja_diaria values(''," & Val(txtIngresos.Text) & "," & Val(txtGastos.Text) & "," & Val(txtNeto.Text) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "')"
        cargar(sql)
        MsgBox("Cierre Diario Cargado Correctamente!")
        txtGastos.Text = ""
        txtIngresos.Text = ""
        txtNeto.Text = ""
        btnDiario.Enabled = False
        lblCierre.Visible = True
        btnCargarCierreDiario.Enabled = False
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        BuscarCajaDiaria.ds.Tables.Clear()

        sql = "select * from caja_diaria"
        cargar(sql)
        BuscarCajaDiaria.ds.Tables.Add("XX")
        BuscarCajaDiaria.da = New OdbcDataAdapter(sql, cnn)
        BuscarCajaDiaria.da.Fill(BuscarCajaDiaria.ds.Tables("XX"))
        BuscarCajaDiaria.dgvCajaDiaria.DataSource = BuscarCajaDiaria.ds.Tables("XX")

        Me.Hide()
        BuscarCajaDiaria.Show()

    End Sub
End Class