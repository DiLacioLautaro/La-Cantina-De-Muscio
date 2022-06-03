Imports System.Data.Odbc
Public Class frmABM
    Dim x As Integer
    Dim sql As String

    Private Sub btnVolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenuABM.Click
        frmMenuP.Show()
        Me.Hide()
    End Sub

 

    Private Sub btnCempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCEmp.Click
        Me.Hide()
        frmCargarEmpleado.Show()

    End Sub

    Private Sub btnCproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaProv.Click
        Me.Hide()
        frmCargarProveedor.Show()
    End Sub

    Private Sub btnCprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCprod.Click
        Me.Hide()
        frmCargarProd.Show()
    End Sub

    Private Sub btnMempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModEmp.Click
        Me.Hide()
        frmModEmpleado.Show()
    End Sub

    Private Sub btnBempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaEmp.Click
        Me.Hide()
        frmBorrarEmp.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModIngr.Click
        Me.Hide()
        frmModIngred.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarIngr.Click
        Me.Hide()
        frmBorrarInG.Show()
    End Sub

    Private Sub btnMprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMprod.Click
        Me.Hide()
        frmModProd.Show()
    End Sub

    Private Sub btnBprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBprod.Click
        Me.Hide()
        frmBorrarProd.Show()
    End Sub

    Private Sub btnCargarCom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargarCom.Click
        sql = "drop table if exists cargar_com"
        cargar(sql)

        sql = "create table cargar_com(idingr int,nombreingr char(30), cantidad float)"
        cargar(sql)
        Me.Hide()
        frmCargarCom.Show()
    End Sub

    Private Sub btnModCom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModCom.Click
        Me.Hide()
        frmModCom.Show()
    End Sub

    Private Sub btnBorrarCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom.Click
        Me.Hide()
        frmBorrarCom.Show()
    End Sub

    Private Sub btnMproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMproveedor.Click
        Me.Hide()
        frmModProv.Show()
    End Sub

    Private Sub btnBprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBprov.Click
        Me.Hide()
        frmBajaProv.Show()
    End Sub

    Private Sub btnModPReserv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModServ.Click
        Me.Hide()
        frmModServ.Show()
    End Sub

    Private Sub btnCarServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmCargarSer.Show()
    End Sub

    Private Sub btnBorrarServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmBorrarSer.Show()
    End Sub

    Private Sub btnCargarIngr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarIngr.Click
        Me.Hide()
        frmCargarIngr.Show()
    End Sub

    Private Sub btnReacProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReacProv.Click
        Me.Hide()
        frmReacProv.Show()

    End Sub

    Private Sub btnCargarMenuDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarMenuDiario.Click

        CargarMenu.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CargarMenu.ds.Tables.Add("XX")
        CargarMenu.da = New OdbcDataAdapter(sql, cnn)
        CargarMenu.da.Fill(CargarMenu.ds.Tables("XX"))
        CargarMenu.dgvComidas.DataSource = CargarMenu.ds.Tables("XX")

        CargarMenu.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CargarMenu.ds.Tables.Add("XX")
        CargarMenu.da = New OdbcDataAdapter(sql, cnn)
        CargarMenu.da.Fill(CargarMenu.ds.Tables("XX"))
        CargarMenu.dgvProductos.DataSource = CargarMenu.ds.Tables("XX")

        sql = "drop table if exists detallemenudiario1"
        cargar(sql)

        sql = "create table detallemenudiario1(iddetallemenu int auto_increment,idmenu int,concepto char(50),cantidad int,tipo char(10),dia char(40),idv int,primary key (iddetallemenu),foreign key (idmenu) references menudiario (idmenu)) "
        cargar(sql)

        Me.Hide()
        CargarMenu.Show()
    End Sub

    Private Sub btnBorProvP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarProvP.Click
        Me.Hide()
        frmCarProvP.Show()
    End Sub

    Private Sub btnBorProvP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorProvP.Click
        Me.Hide()
        frmBorProvP.Show()
    End Sub

    Private Sub btnCarProvI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarProvI.Click
        Me.Hide()
        frmCarProvI.Show()
    End Sub

    Private Sub btnBorProvI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorProvI.Click
        Me.Hide()
        frmBorProvIng.Show()
    End Sub

    Private Sub frmABM_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
    End Sub
End Class