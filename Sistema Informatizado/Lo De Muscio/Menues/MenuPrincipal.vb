Imports System.Data.Odbc
Public Class frmMenuP
    Dim menos6 As Date
    Dim sql As String
    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click
        frmCompras.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub frmMenuP_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblUser.Text = Inicio_Sesion.UsuarioActual
        lblTipoEmpleado.Text = Inicio_Sesion.permiso

        If Modulo.Tipoempleado = "Compras" Then
            btnABM.Enabled = False
            btnCompras.Enabled = False
            btnSalon.Enabled = False
            btnSocios.Enabled = False
            Button1.Enabled = False 'cierre caja'
            btnUsuarios.Enabled = True
            btnStockReposicion.Enabled = True
        End If

        If Modulo.Tipoempleado = "Caja" Then
            btnABM.Enabled = False
            btnCompras.Enabled = True
            btnSalon.Enabled = False
            btnSocios.Enabled = True
            Button1.Enabled = False 'cierre caja'
            btnUsuarios.Enabled = True
            btnStockReposicion.Enabled = False
        End If

        If Modulo.Tipoempleado = "Mozo" Then
            btnABM.Enabled = False
            btnCompras.Enabled = True
            btnSalon.Enabled = False
            btnSocios.Enabled = False
            Button1.Enabled = False 'cierre caja'
            btnUsuarios.Enabled = True
            btnStockReposicion.Enabled = False
        End If

        If Modulo.Tipoempleado = "Admin" Then
            btnABM.Enabled = True
            btnCompras.Enabled = True
            btnSalon.Enabled = True
            btnSocios.Enabled = True
            Button1.Enabled = True  'cierre caja'
            btnUsuarios.Enabled = True
            btnStockReposicion.Enabled = True
        End If


    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Inicio_Sesion.Show()
        Me.Close()
        Inicio_Sesion.txtUsuario.Text = ""
        Inicio_Sesion.txtContraseña.Text = ""
    End Sub

    Private Sub btnSalon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalon.Click
        SalonMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnABM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnABM.Click
        frmABM.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click
        Me.Hide()
        frmUsuarios.Show()

    End Sub

    Private Sub btnSocios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        Me.Hide()
        frmSocios.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuCierreCaja.Show()

    End Sub

    Private Sub frmMenuP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        menos6 = Date.Today.AddDays(-6)
        If Format(Date.Today, "dd") = 5 Then
            Dim mes As String = Format(menos6, "MMMM")
            sql = "select * from cuentacorriente where mes like '%" & mes & "%' and anio = " & Format(Date.Today, "yyyy") & ""
            cargar1(sql)
            While rs1.Read = True
                If rs1(1) = 0 Then
                    sql = "update cuentacorriente set mes = '" & Format(Date.Today, "MMMM") & "'where idsocio =" & rs1(0)
                    cargar(sql)
                    sql = "update cuentacorriente set anio = '" & Format(Date.Today, "yyyy") & "' where idsocio = " & rs1(0)
                    cargar(sql)
                Else
                    sql = "update socios set deuda = 1 where idsocio = " & rs1(0)
                    cargar(sql)
                End If
            End While
        ElseIf Format(Date.Today, "dd") > 5 And Format(Date.Today, "dd") < 25 Then
            Format(Date.Today, "MMMM")
            sql = "select * from cuentacorriente where mes <> '" & Format(Date.Today, "MMMM") & "' or anio <> '" & Format(Date.Today, "yyyy") & "'"
            cargar(sql)
            While rs.Read = True
                If rs(1) <> 0 Then
                    sql = "update socios set deuda = 1 where idsocio = " & rs(0)
                    cargar1(sql)
                Else
                    sql = "update cuentacorriente set mes = '" & Format(Date.Today, "MMMM") & "' where idsocio =" & rs(0)
                    cargar1(sql)
                    sql = "update cuentacorriente set anio = '" & Format(Date.Today, "yyyy") & "' where idsocio = " & rs(0)
                    cargar1(sql)
                End If
            End While

        ElseIf Format(Date.Today, "dd") >= 25 And Format(Date.Today, "dd") <= 31 Then
            Dim mas7 As Date = Date.Today.AddDays(7)

            sql = "select * from cuentacorriente where mes <> '" & Format(Date.Today, "MMMM") & "' and mes <> '" & Format(mas7, "MMMM") & "' or anio <> '" & Format(Date.Today, "yyyy") & "'"
            cargar(sql)
            While rs.Read = True
                If rs(1) <> 0 Then
                    sql = "update socios set deuda = 1 where idsocio = " & rs(0)
                    cargar1(sql)
                Else
                    sql = "update cuentacorriente set mes = '" & Format(Date.Today, "MMMM") & "' where idsocio =" & rs(0)
                    cargar1(sql)
                    sql = "update cuentacorriente set anio = '" & Format(Date.Today, "yyyy") & "' where idsocio = " & rs(0)
                    cargar1(sql)
                End If
            End While

        ElseIf Format(Date.Today, "dd") >= 1 And Format(Date.Today, "dd") < 5 Then

            Dim menoss6 As Date = Date.Today.AddDays(-6)

            sql = "select * from cuentacorriente where mes <> '" & Format(Date.Today, "MMMM") & "' and mes <> '" & Format(menoss6, "MMMM") & "' or anio <> '" & Format(Date.Today, "yyyy") & "'"
            cargar(sql)
            While rs.Read = True
                If rs(1) <> 0 Then
                    sql = "update socios set deuda = 1 where idsocio = " & rs(0)
                    cargar1(sql)
                Else
                    sql = "update cuentacorriente set mes = '" & Format(Date.Today, "MMMM") & "' where idsocio =" & rs(0)
                    cargar1(sql)
                    sql = "update cuentacorriente set anio = '" & Format(Date.Today, "yyyy") & "' where idsocio = " & rs(0)
                    cargar1(sql)
                End If
            End While

        End If
        If Format(Date.Today, "dd") = 1 Then
            sql = "update autorizaciones set monto = montomensual"
            cargar(sql)
        End If
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado

        lblUser.Text = Inicio_Sesion.UsuarioActual
        lblTipoEmpleado.Text = Inicio_Sesion.permiso


    End Sub

    Private Sub btnStockReposicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockReposicion.Click
        Me.Hide()
        MenuStock.Show()

    End Sub
End Class


