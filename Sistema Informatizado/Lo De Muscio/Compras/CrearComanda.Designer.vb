<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearComanda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.dgvComidas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPedidoMesa = New System.Windows.Forms.DataGridView()
        Me.lblNumMesa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscarProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnBorrarPedido = New System.Windows.Forms.Button()
        Me.btnConfirmarComanda = New System.Windows.Forms.Button()
        Me.lblParaLlevar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnmasmenu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPedidoMesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(221, 90)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(209, 20)
        Me.txtBuscarCom.TabIndex = 24
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(50, 84)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(100, 26)
        Me.lblMenu.TabIndex = 23
        Me.lblMenu.Text = "Comidas"
        '
        'dgvComidas
        '
        Me.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComidas.Location = New System.Drawing.Point(55, 116)
        Me.dgvComidas.Name = "dgvComidas"
        Me.dgvComidas.Size = New System.Drawing.Size(375, 201)
        Me.dgvComidas.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 33)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Pedido Mesa N°"
        '
        'dgvPedidoMesa
        '
        Me.dgvPedidoMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidoMesa.Location = New System.Drawing.Point(467, 116)
        Me.dgvPedidoMesa.Name = "dgvPedidoMesa"
        Me.dgvPedidoMesa.Size = New System.Drawing.Size(348, 363)
        Me.dgvPedidoMesa.TabIndex = 25
        '
        'lblNumMesa
        '
        Me.lblNumMesa.AutoSize = True
        Me.lblNumMesa.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMesa.Location = New System.Drawing.Point(676, 77)
        Me.lblNumMesa.Name = "lblNumMesa"
        Me.lblNumMesa.Size = New System.Drawing.Size(34, 33)
        Me.lblNumMesa.TabIndex = 27
        Me.lblNumMesa.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 33)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "GENERAR COMANDA - CAJA"
        '
        'txtBuscarProd
        '
        Me.txtBuscarProd.Location = New System.Drawing.Point(221, 336)
        Me.txtBuscarProd.Name = "txtBuscarProd"
        Me.txtBuscarProd.Size = New System.Drawing.Size(209, 20)
        Me.txtBuscarProd.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 26)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Productos"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(55, 362)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(375, 117)
        Me.dgvProductos.TabIndex = 29
        '
        'btnBorrarPedido
        '
        Me.btnBorrarPedido.Location = New System.Drawing.Point(537, 586)
        Me.btnBorrarPedido.Name = "btnBorrarPedido"
        Me.btnBorrarPedido.Size = New System.Drawing.Size(133, 42)
        Me.btnBorrarPedido.TabIndex = 40
        Me.btnBorrarPedido.Text = "BORRAR PEDIDO"
        Me.btnBorrarPedido.UseVisualStyleBackColor = True
        '
        'btnConfirmarComanda
        '
        Me.btnConfirmarComanda.Location = New System.Drawing.Point(55, 543)
        Me.btnConfirmarComanda.Name = "btnConfirmarComanda"
        Me.btnConfirmarComanda.Size = New System.Drawing.Size(401, 74)
        Me.btnConfirmarComanda.TabIndex = 41
        Me.btnConfirmarComanda.Text = "CONFIRMAR COMANDA"
        Me.btnConfirmarComanda.UseVisualStyleBackColor = True
        '
        'lblParaLlevar
        '
        Me.lblParaLlevar.AutoSize = True
        Me.lblParaLlevar.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParaLlevar.Location = New System.Drawing.Point(676, 77)
        Me.lblParaLlevar.Name = "lblParaLlevar"
        Me.lblParaLlevar.Size = New System.Drawing.Size(157, 33)
        Me.lblParaLlevar.TabIndex = 42
        Me.lblParaLlevar.Text = "Para Llevar"
        Me.lblParaLlevar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(462, 494)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 29)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Menu Diario"
        '
        'btnmasmenu
        '
        Me.btnmasmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmasmenu.Location = New System.Drawing.Point(625, 493)
        Me.btnmasmenu.Name = "btnmasmenu"
        Me.btnmasmenu.Size = New System.Drawing.Size(54, 35)
        Me.btnmasmenu.TabIndex = 44
        Me.btnmasmenu.Text = "+"
        Me.btnmasmenu.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "VOLVER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrearComanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(882, 660)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnmasmenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblParaLlevar)
        Me.Controls.Add(Me.btnConfirmarComanda)
        Me.Controls.Add(Me.btnBorrarPedido)
        Me.Controls.Add(Me.txtBuscarProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumMesa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPedidoMesa)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.dgvComidas)
        Me.Name = "CrearComanda"
        Me.Text = "Crear Comanda"
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPedidoMesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents dgvComidas As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPedidoMesa As System.Windows.Forms.DataGridView
    Friend WithEvents lblNumMesa As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarProd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrarPedido As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarComanda As System.Windows.Forms.Button
    Friend WithEvents lblParaLlevar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnmasmenu As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
