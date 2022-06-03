<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKiosco
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarProd = New System.Windows.Forms.TextBox()
        Me.rdbCC = New System.Windows.Forms.RadioButton()
        Me.rdbEfe = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMONTO = New System.Windows.Forms.Label()
        Me.btnMenorAutorizado = New System.Windows.Forms.Button()
        Me.btnSocioCC = New System.Windows.Forms.Button()
        Me.lstCliente = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnConfirmarCompra = New System.Windows.Forms.Button()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.lblVueltovich = New System.Windows.Forms.Label()
        Me.lblVuelto = New System.Windows.Forms.Label()
        Me.btnBorrarPedido = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(40, 121)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(431, 201)
        Me.dgvProductos.TabIndex = 0
        '
        'dgvPedido
        '
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Location = New System.Drawing.Point(492, 121)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.Size = New System.Drawing.Size(339, 321)
        Me.dgvPedido.TabIndex = 1
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(54, 85)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(134, 29)
        Me.lblMenu.TabIndex = 19
        Me.lblMenu.Text = "Productos "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 33)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Pedido actual"
        '
        'txtBuscarProd
        '
        Me.txtBuscarProd.Location = New System.Drawing.Point(255, 95)
        Me.txtBuscarProd.Name = "txtBuscarProd"
        Me.txtBuscarProd.Size = New System.Drawing.Size(205, 20)
        Me.txtBuscarProd.TabIndex = 21
        '
        'rdbCC
        '
        Me.rdbCC.AutoSize = True
        Me.rdbCC.Font = New System.Drawing.Font("Constantia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCC.Location = New System.Drawing.Point(18, 36)
        Me.rdbCC.Name = "rdbCC"
        Me.rdbCC.Size = New System.Drawing.Size(149, 22)
        Me.rdbCC.TabIndex = 22
        Me.rdbCC.TabStop = True
        Me.rdbCC.Text = "Cuenta Corriente"
        Me.rdbCC.UseVisualStyleBackColor = True
        '
        'rdbEfe
        '
        Me.rdbEfe.AutoSize = True
        Me.rdbEfe.Font = New System.Drawing.Font("Constantia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbEfe.Location = New System.Drawing.Point(18, 132)
        Me.rdbEfe.Name = "rdbEfe"
        Me.rdbEfe.Size = New System.Drawing.Size(83, 22)
        Me.rdbEfe.TabIndex = 23
        Me.rdbEfe.TabStop = True
        Me.rdbEfe.Text = "Efectivo"
        Me.rdbEfe.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 26)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Forma de Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 26)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "MONTO TOTAL: $"
        '
        'lblMONTO
        '
        Me.lblMONTO.AutoSize = True
        Me.lblMONTO.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTO.Location = New System.Drawing.Point(215, 19)
        Me.lblMONTO.Name = "lblMONTO"
        Me.lblMONTO.Size = New System.Drawing.Size(0, 26)
        Me.lblMONTO.TabIndex = 26
        '
        'btnMenorAutorizado
        '
        Me.btnMenorAutorizado.Enabled = False
        Me.btnMenorAutorizado.Location = New System.Drawing.Point(28, 59)
        Me.btnMenorAutorizado.Name = "btnMenorAutorizado"
        Me.btnMenorAutorizado.Size = New System.Drawing.Size(104, 23)
        Me.btnMenorAutorizado.TabIndex = 27
        Me.btnMenorAutorizado.Text = "Menor Autorizado"
        Me.btnMenorAutorizado.UseVisualStyleBackColor = True
        '
        'btnSocioCC
        '
        Me.btnSocioCC.Enabled = False
        Me.btnSocioCC.Location = New System.Drawing.Point(28, 88)
        Me.btnSocioCC.Name = "btnSocioCC"
        Me.btnSocioCC.Size = New System.Drawing.Size(104, 23)
        Me.btnSocioCC.TabIndex = 28
        Me.btnSocioCC.Text = "Socio"
        Me.btnSocioCC.UseVisualStyleBackColor = True
        '
        'lstCliente
        '
        Me.lstCliente.FormattingEnabled = True
        Me.lstCliente.Location = New System.Drawing.Point(147, 88)
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(272, 17)
        Me.lstCliente.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 33)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "KIOSCO - CAJA "
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(762, 584)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(85, 29)
        Me.btnVolver.TabIndex = 32
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnConfirmarCompra
        '
        Me.btnConfirmarCompra.Enabled = False
        Me.btnConfirmarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarCompra.Location = New System.Drawing.Point(81, 514)
        Me.btnConfirmarCompra.Name = "btnConfirmarCompra"
        Me.btnConfirmarCompra.Size = New System.Drawing.Size(336, 69)
        Me.btnConfirmarCompra.TabIndex = 33
        Me.btnConfirmarCompra.Text = "CONFIRMAR COMPRA"
        Me.btnConfirmarCompra.UseVisualStyleBackColor = True
        '
        'lblEfectivo
        '
        Me.lblEfectivo.AutoSize = True
        Me.lblEfectivo.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfectivo.Location = New System.Drawing.Point(65, 52)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(126, 23)
        Me.lblEfectivo.TabIndex = 34
        Me.lblEfectivo.Text = "EFECTIVO:  $"
        Me.lblEfectivo.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(197, 52)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(123, 20)
        Me.txtEfectivo.TabIndex = 35
        Me.txtEfectivo.Visible = False
        '
        'lblVueltovich
        '
        Me.lblVueltovich.AutoSize = True
        Me.lblVueltovich.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVueltovich.Location = New System.Drawing.Point(81, 88)
        Me.lblVueltovich.Name = "lblVueltovich"
        Me.lblVueltovich.Size = New System.Drawing.Size(110, 23)
        Me.lblVueltovich.TabIndex = 36
        Me.lblVueltovich.Text = "VUELTO:  $"
        Me.lblVueltovich.Visible = False
        '
        'lblVuelto
        '
        Me.lblVuelto.AutoSize = True
        Me.lblVuelto.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelto.Location = New System.Drawing.Point(197, 85)
        Me.lblVuelto.Name = "lblVuelto"
        Me.lblVuelto.Size = New System.Drawing.Size(0, 26)
        Me.lblVuelto.TabIndex = 37
        '
        'btnBorrarPedido
        '
        Me.btnBorrarPedido.Location = New System.Drawing.Point(652, 579)
        Me.btnBorrarPedido.Name = "btnBorrarPedido"
        Me.btnBorrarPedido.Size = New System.Drawing.Size(85, 39)
        Me.btnBorrarPedido.TabIndex = 38
        Me.btnBorrarPedido.Text = "BORRAR PEDIDO"
        Me.btnBorrarPedido.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lstCliente)
        Me.GroupBox1.Controls.Add(Me.btnSocioCC)
        Me.GroupBox1.Controls.Add(Me.btnMenorAutorizado)
        Me.GroupBox1.Controls.Add(Me.rdbEfe)
        Me.GroupBox1.Controls.Add(Me.rdbCC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 165)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblVuelto)
        Me.GroupBox2.Controls.Add(Me.lblVueltovich)
        Me.GroupBox2.Controls.Add(Me.txtEfectivo)
        Me.GroupBox2.Controls.Add(Me.lblEfectivo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblMONTO)
        Me.GroupBox2.Location = New System.Drawing.Point(492, 448)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 120)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fecha)
        Me.GroupBox5.Location = New System.Drawing.Point(700, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(18, 16)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(46, 16)
        Me.fecha.TabIndex = 0
        Me.fecha.Text = "fecha"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox8.Location = New System.Drawing.Point(23, 11)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox8.TabIndex = 44
        Me.GroupBox8.TabStop = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(91, 40)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 43
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(90, 22)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 42
        Me.lblUser.Text = "Label1"
        '
        'frmKiosco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 634)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBorrarPedido)
        Me.Controls.Add(Me.btnConfirmarCompra)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBuscarProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "frmKiosco"
        Me.Text = " "
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPedido As System.Windows.Forms.DataGridView
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarProd As System.Windows.Forms.TextBox
    Friend WithEvents rdbCC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEfe As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMONTO As System.Windows.Forms.Label
    Friend WithEvents btnMenorAutorizado As System.Windows.Forms.Button
    Friend WithEvents btnSocioCC As System.Windows.Forms.Button
    Friend WithEvents lstCliente As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarCompra As System.Windows.Forms.Button
    Friend WithEvents lblEfectivo As System.Windows.Forms.Label
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents lblVueltovich As System.Windows.Forms.Label
    Friend WithEvents lblVuelto As System.Windows.Forms.Label
    Friend WithEvents btnBorrarPedido As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
