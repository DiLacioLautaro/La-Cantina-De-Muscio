<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCierreCaja
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
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnDiario = New System.Windows.Forms.Button()
        Me.btnMensual = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(214, 43)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(232, 39)
        Me.lblMenu.TabIndex = 8
        Me.lblMenu.Text = "Cierre De Caja"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(550, 217)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 32)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnDiario
        '
        Me.btnDiario.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnDiario.Location = New System.Drawing.Point(55, 126)
        Me.btnDiario.Name = "btnDiario"
        Me.btnDiario.Size = New System.Drawing.Size(225, 50)
        Me.btnDiario.TabIndex = 6
        Me.btnDiario.Text = "Cierre Diario"
        Me.btnDiario.UseVisualStyleBackColor = True
        '
        'btnMensual
        '
        Me.btnMensual.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnMensual.Location = New System.Drawing.Point(383, 126)
        Me.btnMensual.Name = "btnMensual"
        Me.btnMensual.Size = New System.Drawing.Size(225, 50)
        Me.btnMensual.TabIndex = 5
        Me.btnMensual.Text = "Cierre Mensual"
        Me.btnMensual.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox8.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox8.TabIndex = 35
        Me.GroupBox8.TabStop = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(93, 41)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 34
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(92, 23)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 33
        Me.lblUser.Text = "Label1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fecha)
        Me.GroupBox5.Location = New System.Drawing.Point(507, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 40
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
        'MenuCierreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 271)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnDiario)
        Me.Controls.Add(Me.btnMensual)
        Me.Name = "MenuCierreCaja"
        Me.Text = "Menu Cierre De Caja"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnDiario As System.Windows.Forms.Button
    Friend WithEvents btnMensual As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
End Class
