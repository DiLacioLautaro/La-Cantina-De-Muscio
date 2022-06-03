<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturar))
        Me.btnConfirmarCompra = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstCliente = New System.Windows.Forms.ListBox()
        Me.btnSocioCC = New System.Windows.Forms.Button()
        Me.rdbEfe = New System.Windows.Forms.RadioButton()
        Me.rdbCC = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCierreMesa = New System.Windows.Forms.Label()
        Me.lblNumesa = New System.Windows.Forms.Label()
        Me.lblParaLlevar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalll = New System.Windows.Forms.Label()
        Me.lblTotall = New System.Windows.Forms.Label()
        Me.lblVuelto = New System.Windows.Forms.Label()
        Me.lblVueltovich = New System.Windows.Forms.Label()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirmarCompra
        '
        Me.btnConfirmarCompra.Enabled = False
        Me.btnConfirmarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarCompra.Location = New System.Drawing.Point(152, 381)
        Me.btnConfirmarCompra.Name = "btnConfirmarCompra"
        Me.btnConfirmarCompra.Size = New System.Drawing.Size(317, 69)
        Me.btnConfirmarCompra.TabIndex = 41
        Me.btnConfirmarCompra.Text = "CONFIRMAR COMPRA"
        Me.btnConfirmarCompra.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Cliente"
        '
        'lstCliente
        '
        Me.lstCliente.FormattingEnabled = True
        Me.lstCliente.Location = New System.Drawing.Point(139, 73)
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(272, 17)
        Me.lstCliente.TabIndex = 39
        '
        'btnSocioCC
        '
        Me.btnSocioCC.Enabled = False
        Me.btnSocioCC.Location = New System.Drawing.Point(20, 67)
        Me.btnSocioCC.Name = "btnSocioCC"
        Me.btnSocioCC.Size = New System.Drawing.Size(104, 23)
        Me.btnSocioCC.TabIndex = 38
        Me.btnSocioCC.Text = "Socio"
        Me.btnSocioCC.UseVisualStyleBackColor = True
        '
        'rdbEfe
        '
        Me.rdbEfe.AutoSize = True
        Me.rdbEfe.Font = New System.Drawing.Font("Constantia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbEfe.Location = New System.Drawing.Point(19, 111)
        Me.rdbEfe.Name = "rdbEfe"
        Me.rdbEfe.Size = New System.Drawing.Size(83, 22)
        Me.rdbEfe.TabIndex = 35
        Me.rdbEfe.TabStop = True
        Me.rdbEfe.Text = "Efectivo"
        Me.rdbEfe.UseVisualStyleBackColor = True
        '
        'rdbCC
        '
        Me.rdbCC.AutoSize = True
        Me.rdbCC.Font = New System.Drawing.Font("Constantia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCC.Location = New System.Drawing.Point(19, 31)
        Me.rdbCC.Name = "rdbCC"
        Me.rdbCC.Size = New System.Drawing.Size(149, 22)
        Me.rdbCC.TabIndex = 34
        Me.rdbCC.TabStop = True
        Me.rdbCC.Text = "Cuenta Corriente"
        Me.rdbCC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 26)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Forma de Pago"
        '
        'lblCierreMesa
        '
        Me.lblCierreMesa.AutoSize = True
        Me.lblCierreMesa.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCierreMesa.Location = New System.Drawing.Point(96, 99)
        Me.lblCierreMesa.Name = "lblCierreMesa"
        Me.lblCierreMesa.Size = New System.Drawing.Size(242, 33)
        Me.lblCierreMesa.TabIndex = 42
        Me.lblCierreMesa.Text = "CIERRE DE MESA "
        '
        'lblNumesa
        '
        Me.lblNumesa.AutoSize = True
        Me.lblNumesa.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumesa.Location = New System.Drawing.Point(344, 99)
        Me.lblNumesa.Name = "lblNumesa"
        Me.lblNumesa.Size = New System.Drawing.Size(34, 33)
        Me.lblNumesa.TabIndex = 43
        Me.lblNumesa.Text = "X"
        '
        'lblParaLlevar
        '
        Me.lblParaLlevar.AutoSize = True
        Me.lblParaLlevar.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParaLlevar.Location = New System.Drawing.Point(336, 99)
        Me.lblParaLlevar.Name = "lblParaLlevar"
        Me.lblParaLlevar.Size = New System.Drawing.Size(157, 33)
        Me.lblParaLlevar.TabIndex = 44
        Me.lblParaLlevar.Text = "Para Llevar"
        Me.lblParaLlevar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalll)
        Me.GroupBox1.Controls.Add(Me.lblTotall)
        Me.GroupBox1.Controls.Add(Me.lblVuelto)
        Me.GroupBox1.Controls.Add(Me.lblVueltovich)
        Me.GroupBox1.Controls.Add(Me.txtEfectivo)
        Me.GroupBox1.Controls.Add(Me.lblEfectivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lstCliente)
        Me.GroupBox1.Controls.Add(Me.btnSocioCC)
        Me.GroupBox1.Controls.Add(Me.rdbEfe)
        Me.GroupBox1.Controls.Add(Me.rdbCC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 222)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'lblTotalll
        '
        Me.lblTotalll.AutoSize = True
        Me.lblTotalll.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalll.Location = New System.Drawing.Point(267, 111)
        Me.lblTotalll.Name = "lblTotalll"
        Me.lblTotalll.Size = New System.Drawing.Size(96, 23)
        Me.lblTotalll.TabIndex = 46
        Me.lblTotalll.Text = "TOTAL:  $"
        Me.lblTotalll.Visible = False
        '
        'lblTotall
        '
        Me.lblTotall.AutoSize = True
        Me.lblTotall.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotall.Location = New System.Drawing.Point(165, 111)
        Me.lblTotall.Name = "lblTotall"
        Me.lblTotall.Size = New System.Drawing.Size(96, 23)
        Me.lblTotall.TabIndex = 45
        Me.lblTotall.Text = "TOTAL:  $"
        Me.lblTotall.Visible = False
        '
        'lblVuelto
        '
        Me.lblVuelto.AutoSize = True
        Me.lblVuelto.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelto.Location = New System.Drawing.Point(267, 180)
        Me.lblVuelto.Name = "lblVuelto"
        Me.lblVuelto.Size = New System.Drawing.Size(0, 26)
        Me.lblVuelto.TabIndex = 44
        '
        'lblVueltovich
        '
        Me.lblVueltovich.AutoSize = True
        Me.lblVueltovich.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVueltovich.Location = New System.Drawing.Point(135, 183)
        Me.lblVueltovich.Name = "lblVueltovich"
        Me.lblVueltovich.Size = New System.Drawing.Size(110, 23)
        Me.lblVueltovich.TabIndex = 43
        Me.lblVueltovich.Text = "VUELTO:  $"
        Me.lblVueltovich.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(267, 147)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(123, 20)
        Me.txtEfectivo.TabIndex = 42
        Me.txtEfectivo.Visible = False
        '
        'lblEfectivo
        '
        Me.lblEfectivo.AutoSize = True
        Me.lblEfectivo.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfectivo.Location = New System.Drawing.Point(135, 147)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(126, 23)
        Me.lblEfectivo.TabIndex = 41
        Me.lblEfectivo.Text = "EFECTIVO:  $"
        Me.lblEfectivo.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fecha)
        Me.GroupBox5.Location = New System.Drawing.Point(429, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 46
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
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(80, 41)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 48
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(79, 23)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 47
        Me.lblUser.Text = "Label1"
        '
        'Facturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(588, 482)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblParaLlevar)
        Me.Controls.Add(Me.lblNumesa)
        Me.Controls.Add(Me.lblCierreMesa)
        Me.Controls.Add(Me.btnConfirmarCompra)
        Me.Name = "Facturar"
        Me.Text = resources.GetString("$this.Text")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConfirmarCompra As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstCliente As System.Windows.Forms.ListBox
    Friend WithEvents btnSocioCC As System.Windows.Forms.Button
    Friend WithEvents rdbEfe As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCC As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCierreMesa As System.Windows.Forms.Label
    Friend WithEvents lblNumesa As System.Windows.Forms.Label
    Friend WithEvents lblParaLlevar As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblVuelto As System.Windows.Forms.Label
    Friend WithEvents lblVueltovich As System.Windows.Forms.Label
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents lblEfectivo As System.Windows.Forms.Label
    Friend WithEvents lblTotalll As System.Windows.Forms.Label
    Friend WithEvents lblTotall As System.Windows.Forms.Label
End Class
