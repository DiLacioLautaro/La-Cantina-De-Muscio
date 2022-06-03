Imports System.Data.Odbc
Public Class frmSocios
    Dim rs2 As OdbcDataReader
    Public Sub cargar2(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs2 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Dim sql As String
    Private Sub btnVolverSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverSocios.Click
        Me.Hide()
        frmMenuP.Show()

    End Sub

    Private Sub btnAgregarSociobtnAgregarSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarSociobtnAgregarSocio.Click
        Me.Hide()
        frmCargarSocio.Show()
    End Sub

    Private Sub btnCargarMenor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarMenor.Click
        Me.Hide()
        frmCargarMenor.Show()

    End Sub

    Private Sub btnBorrarSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarSocio.Click
        Me.Hide()
        frmSocBorrar.Show()

    End Sub

    Private Sub btnModSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModSocio.Click
        Me.Hide()
        frmModSocio.Show()
    End Sub

    Private Sub btnPagoCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagoCC.Click
        Pago_CC.lblMes.Text = ""
        Pago_CC.lblTotal.Text = ""
        Me.Hide()
        Pago_CC.Show()

    End Sub

    Private Sub btnMorosos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMorosos.Click
        Me.Hide()
        MorososCC.Show()

        MorososCC.ds.Tables.Clear()
        sql = "drop table if exists morosos"
        cargar(sql)
        sql = "create table morosos(nrosocio int,nombre varchar(20),apellido varchar(20),telefono varchar(20),email varchar(20),deuda int)"
        cargar(sql)
        sql = "select idsocio,nombre,apellido,telefono,email from socios where estado = 1 and deuda = 1"
        cargar(sql)
        While rs.Read = True
            sql = "select monto from cuentacorriente where idsocio = " & rs(0)
            cargar1(sql)
            While rs1.Read = True
                sql = "insert into morosos values (" & rs(0) & ",'" & rs(1) & "','" & rs(2) & "','" & rs(3) & "','" & rs(4) & "'," & rs1(0) & ")"
                cargar2(sql)
            End While
        End While
        sql = "select * from morosos"
        cargar(sql)
        MorososCC.ds.Tables.Add("XX")
        MorososCC.da = New OdbcDataAdapter(sql, cnn)
        MorososCC.da.Fill(MorososCC.ds.Tables("XX"))
        MorososCC.dgvMorosos.DataSource = MorososCC.ds.Tables("XX")
    End Sub

    Private Sub btnBorrarMenor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarMenor.Click
        Me.Close()
        frmBorrarMenor.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmReacSocio.Show()

    End Sub

    Private Sub btnModMenor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModMenor.Click
        Me.Close()
        frmModMenor.Show()
    End Sub

    Private Sub fecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.Click

    End Sub

    Private Sub frmSocios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
    End Sub

    Private Sub frmSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class