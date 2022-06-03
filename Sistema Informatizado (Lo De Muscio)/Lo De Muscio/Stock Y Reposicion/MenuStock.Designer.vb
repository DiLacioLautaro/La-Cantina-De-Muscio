<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuStock
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
        Me.btnPP = New System.Windows.Forms.Button()
        Me.btnORDENCOMP = New System.Windows.Forms.Button()
        Me.btnRecepcionMerc = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.btnPagoProv = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPP
        '
        Me.btnPP.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPP.Location = New System.Drawing.Point(119, 118)
        Me.btnPP.Name = "btnPP"
        Me.btnPP.Size = New System.Drawing.Size(197, 51)
        Me.btnPP.TabIndex = 2
        Me.btnPP.Text = "Ver punto de pedido "
        Me.btnPP.UseVisualStyleBackColor = True
        '
        'btnORDENCOMP
        '
        Me.btnORDENCOMP.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnORDENCOMP.Location = New System.Drawing.Point(340, 118)
        Me.btnORDENCOMP.Name = "btnORDENCOMP"
        Me.btnORDENCOMP.Size = New System.Drawing.Size(197, 51)
        Me.btnORDENCOMP.TabIndex = 3
        Me.btnORDENCOMP.Text = "Generar Orden De Compra"
        Me.btnORDENCOMP.UseVisualStyleBackColor = True
        '
        'btnRecepcionMerc
        '
        Me.btnRecepcionMerc.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecepcionMerc.Location = New System.Drawing.Point(570, 118)
        Me.btnRecepcionMerc.Name = "btnRecepcionMerc"
        Me.btnRecepcionMerc.Size = New System.Drawing.Size(197, 51)
        Me.btnRecepcionMerc.TabIndex = 4
        Me.btnRecepcionMerc.Text = "Recepcion de Mercaderia"
        Me.btnRecepcionMerc.UseVisualStyleBackColor = True
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(218, 51)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(396, 39)
        Me.lblMenu.TabIndex = 5
        Me.lblMenu.Text = "Menú Stock y Reposicion"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnVolver.Location = New System.Drawing.Point(723, 232)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 30)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(80, 36)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 13
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(79, 18)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 12
        Me.lblUser.Text = "Label1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fecha)
        Me.GroupBox5.Location = New System.Drawing.Point(683, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 38
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
        'btnPagoProv
        '
        Me.btnPagoProv.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagoProv.Location = New System.Drawing.Point(340, 192)
        Me.btnPagoProv.Name = "btnPagoProv"
        Me.btnPagoProv.Size = New System.Drawing.Size(197, 51)
        Me.btnPagoProv.TabIndex = 39
        Me.btnPagoProv.Text = "Pago a Proveedor"
        Me.btnPagoProv.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'MenuStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(851, 281)
        Me.Controls.Add(Me.btnPagoProv)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.btnRecepcionMerc)
        Me.Controls.Add(Me.btnORDENCOMP)
        Me.Controls.Add(Me.btnPP)
        Me.Name = "MenuStock"
        Me.Text = "Stock Y Reposicion "
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPP As System.Windows.Forms.Button
    Friend WithEvents btnORDENCOMP As System.Windows.Forms.Button
    Friend WithEvents btnRecepcionMerc As System.Windows.Forms.Button
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents btnPagoProv As System.Windows.Forms.Button
End Class
