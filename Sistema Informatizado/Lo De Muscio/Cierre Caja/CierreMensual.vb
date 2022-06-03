Imports System.Data.Odbc
Public Class CierreMensual
    Dim sql As String
    Dim ingresos As Integer
    Dim gastos As Integer
    Dim neto As Integer
    Private Sub CierreMensual_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblFecha.Text = Date.Today
        lblMes.Text = Format(Date.Today, "MMMM")
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuCierreCaja.Show()
        dtpInicioMes.Value = Date.Today
        txtIngresos.Text = ""
        txtNeto.Text = ""
    End Sub

    Private Sub btnMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMensual.Click
        If dtpInicioMes.Value.Date = Date.Today Then
            MsgBox("LA FECHA DE INICIO DE MES ES LA FECHA DE HOY!")
        Else
            ingresos = 0
            gastos = 0
            sql = "select * from caja_diaria where fecha >= '" & Format(dtpInicioMes.Value.Date, "yyyy/MM/dd") & "' and fecha <= '" & Format(Date.Today, "yyyy/MM/dd") & "'"
            cargar(sql)
            While rs.Read = True
                ingresos = ingresos + rs(1)
                gastos = gastos + rs(2)
            End While
            neto = ingresos - gastos

            txtIngresos.Text = ingresos
            txtGastos.Text = gastos
            txtNeto.Text = neto

            btnCargarCierreMensual.Enabled = True

        End If
    End Sub


    Private Sub btnCargarCierreMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarCierreMensual.Click
        If Format(dtpInicioMes.Value.Date, "MMMM") = Format(Date.Today, "MMMM") Then
            sql = "insert into caja_mensual values(''," & Val(txtIngresos.Text) & "," & Val(txtGastos.Text) & "," & Val(txtNeto.Text) & ",'" & Format(dtpInicioMes.Value.Date, "yyyy/MM/dd") & "','" & Format(Date.Today, "yyyy/MM/dd") & "','" & lblMes.Text & "')"
            cargar(sql)
            MsgBox("Cierre Mensual Cargado Correctamente!")
            txtGastos.Text = ""
            txtIngresos.Text = ""
            txtNeto.Text = ""
            btnMensual.Enabled = False
            lblCierre.Visible = True
            btnCargarCierreMensual.Enabled = False
        Else
            MsgBox("Fecha de inicio de mes erronea!")
        End If
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        BuscarCajaMensual.ds.Tables.Clear()

        sql = "select * from caja_mensual"
        cargar(sql)
        BuscarCajaMensual.ds.Tables.Add("XX")
        BuscarCajaMensual.da = New OdbcDataAdapter(sql, cnn)
        BuscarCajaMensual.da.Fill(BuscarCajaMensual.ds.Tables("XX"))
        BuscarCajaMensual.dgvCajaMensual.DataSource = BuscarCajaMensual.ds.Tables("XX")


        Me.Hide()
        BuscarCajaMensual.Show()

    End Sub

    Private Sub CierreMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtInicioMes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class