Imports System.Data.Odbc
Public Class frmCompras
    Dim sql As String

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverCompras.Click
        Me.Hide()
        frmMenuP.Show()

    End Sub

    Private Sub btnKiosco_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKiosco.Click
        sql = "drop table if exists kioscompra"
        cargar(sql)

        sql = "create table kioscompra (idprod int,nombreprod char(30),cantidad int)"
        cargar(sql)

        Me.Hide()
        frmKiosco.Show()
    End Sub

    Private Sub btnServicioCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicioCom.Click
        Me.Hide()
        Mesass.Show()

        sql = "drop table if exists mesaped"
        cargar(sql)

        sql = "drop table if exists ingped"
        cargar(sql)

        sql = "create table mesaped(id int auto_increment,idv int,nombre char(30),cantidad int,tipo char(10),pu int,primary key (id))"
        cargar(sql)
        sql = "create table ingped(idi int,cantidad float(4),primary key(idi))"
        cargar(sql)



    End Sub

    Private Sub frmCompras_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado

    End Sub

    Private Sub frmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class