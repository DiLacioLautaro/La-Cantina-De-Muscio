Imports System.Data.Odbc
Public Class Mesass
    Public mesa As String
    Public creacionpedido As String
    Public creaciofac As String
    Dim aa As String
    Dim sql As String
    Public yapidiendo As Boolean

    Private Sub Mesass_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fecha.Text = Date.Today
        lblUser.Text = Modulo.user
        lblTipoEmpleado.Text = Modulo.Tipoempleado
        rdbMesa.Visible = True
        rdbParaLlevar.Visible = True
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmCompras.Show()
        rdbMesa.Visible = True
        rdbParaLlevar.Visible = True

        sql = "drop table ingped"
        cargar(sql)
        sql = "drop table mesaped"
        cargar(sql)

    End Sub

    Private Sub btnComanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rdbMesa.Visible = True
        rdbParaLlevar.Visible = True

    End Sub

    Private Sub rdbMesa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMesa.CheckedChanged
 
            Try
                If rdbMesa.Checked = True Then
                    mesa = InputBox("Ingrese el numero de mesa que realiza el pedido")
                    If mesa > 0 And mesa <= 20 Then
                        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
                            yapidiendo = True
                        Else
                            yapidiendo = False
                        End If

                        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

                        CrearComanda.ds.Tables.Clear()
                        sql = "select * from comidas"
                        cargar(sql)
                        CrearComanda.ds.Tables.Add("XX")
                        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
                        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
                        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

                        CrearComanda.ds.Tables.Clear()

                        sql = "select * from productos"
                        cargar(sql)
                        CrearComanda.ds.Tables.Add("XX")
                        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
                        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
                        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

                        CrearComanda.lblNumMesa.Text = mesa

                        rdbMesa.Checked = False
                        rdbMesa.Visible = False
                        rdbParaLlevar.Visible = False

                        Me.Hide()
                        CrearComanda.Show()

                        If yapidiendo = False Then
                            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
                            cargar(creaciofac)
                        End If

                    Else
                    MsgBox("Numero de mesa erroneo!")
                    rdbMesa.Checked = False
                    End If
                End If
            Catch ex As Exception
            MsgBox("ERROR AL INGRESAR NUMERO DE MESA, INTENTE DENUEVO", MsgBoxStyle.Critical)
            rdbMesa.Checked = False
            End Try

    End Sub

    Private Sub rdbParaLlevar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbParaLlevar.CheckedChanged
        If rdbParaLlevar.Checked = True Then
            mesa = 0
     
            CrearComanda.ds.Tables.Clear()
            sql = "select * from comidas"
            cargar(sql)
            CrearComanda.ds.Tables.Add("XX")
            CrearComanda.da = New OdbcDataAdapter(sql, cnn)
            CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
            CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

            CrearComanda.ds.Tables.Clear()

            sql = "select * from productos"
            cargar(sql)
            CrearComanda.ds.Tables.Add("XX")
            CrearComanda.da = New OdbcDataAdapter(sql, cnn)
            CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
            CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

            CrearComanda.lblNumMesa.Text = mesa

            rdbMesa.Checked = False
            rdbMesa.Visible = False
            rdbParaLlevar.Visible = False

            CrearComanda.lblParaLlevar.Visible = True

            Me.Hide()
            CrearComanda.Show()

            sql = "drop table if exists mesacon0"
            cargar(sql)

            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)

        End If
    End Sub

    Private Function Control(ByVal p1 As String) As Object
        Throw New NotImplementedException
    End Function

    Private Sub btnFactura_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        Try
            mesa = InputBox("Ingrese el numero de mesa que se quiere facturar")
            If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Lime Then
                MsgBox("La mesa esta vacia!")
            Else
                Facturar.Show()
                Facturar.lblNumesa.Text = mesa

            End If
        Catch ex As Exception
            If mesa <> "" Then
                    MsgBox("INGRESE UN VALOR VALIDO", MsgBoxStyle.Critical)

                Else

                End If
        End Try
        

    End Sub

    Private Sub btnMesa1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa1.Click
        mesa = 1
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa2.Click
        mesa = 2
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa3.Click
        mesa = 3
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa4.Click
        mesa = 4
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa5.Click
        mesa = 5
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa6.Click
        mesa = 6
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa7.Click
        mesa = 7
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa8.Click
        mesa = 8
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa9.Click
        mesa = 9
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa10.Click
        mesa = 10
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa11.Click
        mesa = 11
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa12.Click
        mesa = 12
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa13.Click
        mesa = 13
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa14.Click
        mesa = 14
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa15.Click
        mesa = 15
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa16.Click
        mesa = 16
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa17.Click
        mesa = 17
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa18.Click
        mesa = 18
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa19.Click
        mesa = 19
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub btnMesa20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMesa20.Click
        mesa = 20
        If Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red Then
            yapidiendo = True
        Else
            yapidiendo = False
        End If

        Me.Controls("btnMesa" & mesa.ToString).BackColor() = Color.Red

        CrearComanda.ds.Tables.Clear()
        sql = "select * from comidas"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvComidas.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.ds.Tables.Clear()

        sql = "select * from productos"
        cargar(sql)
        CrearComanda.ds.Tables.Add("XX")
        CrearComanda.da = New OdbcDataAdapter(sql, cnn)
        CrearComanda.da.Fill(CrearComanda.ds.Tables("XX"))
        CrearComanda.dgvProductos.DataSource = CrearComanda.ds.Tables("XX")

        CrearComanda.lblNumMesa.Text = mesa

        rdbMesa.Checked = False
        rdbMesa.Visible = False
        rdbParaLlevar.Visible = False

        Me.Hide()
        CrearComanda.Show()

        If yapidiendo = False Then
            creaciofac = "create table mesacon" & mesa & "(id int,idv int,nombre char(30),cant int,tipo char(10),pu int)"
            cargar(creaciofac)
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class