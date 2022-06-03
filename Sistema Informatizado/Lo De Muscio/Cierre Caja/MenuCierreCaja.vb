Imports System.Data.Odbc
Public Class MenuCierreCaja
    Dim sql As String

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenuP.Show()

    End Sub

    Private Sub btnDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiario.Click
        sql = "select count(*) from caja_diaria where fecha = '" & Format(Date.Today, "yyyy/MM/dd") & "'"
        cargar(sql)
        While rs.Read = True
            If rs(0) = 1 Then
                CierreDiario.lblCierre.Visible = True
                CierreDiario.btnDiario.Enabled = False
            Else
                CierreDiario.lblCierre.Visible = False
                CierreDiario.btnDiario.Enabled = True
            End If
        End While
        Me.Hide()
        CierreDiario.Show()

    End Sub

    Private Sub btnMensual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMensual.Click
        sql = "select count(*) from caja_mensual where mes = '" & Format(Date.Today, "MMMM") & "'"
        cargar(sql)
        While rs.Read = True
            If rs(0) = 1 Then
                CierreMensual.lblCierre.Visible = True
                CierreMensual.btnMensual.Enabled = False
                CierreMensual.btnCargarCierreMensual.Enabled = False
            Else
                CierreMensual.lblCierre.Visible = False
                CierreMensual.btnMensual.Enabled = True

            End If
        End While

        Me.Hide()
        CierreMensual.Show()

    End Sub

    Private Sub MenuCierreCaja_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
    End Sub

    Private Sub MenuCierreCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class