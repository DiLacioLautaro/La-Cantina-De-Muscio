<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesass
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
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbParaLlevar = New System.Windows.Forms.RadioButton()
        Me.rdbMesa = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.btnMesa1 = New System.Windows.Forms.Button()
        Me.btnMesa2 = New System.Windows.Forms.Button()
        Me.btnMesa3 = New System.Windows.Forms.Button()
        Me.btnMesa4 = New System.Windows.Forms.Button()
        Me.btnMesa5 = New System.Windows.Forms.Button()
        Me.btnMesa6 = New System.Windows.Forms.Button()
        Me.btnMesa7 = New System.Windows.Forms.Button()
        Me.btnMesa8 = New System.Windows.Forms.Button()
        Me.btnMesa9 = New System.Windows.Forms.Button()
        Me.btnMesa10 = New System.Windows.Forms.Button()
        Me.btnMesa11 = New System.Windows.Forms.Button()
        Me.btnMesa12 = New System.Windows.Forms.Button()
        Me.btnMesa13 = New System.Windows.Forms.Button()
        Me.btnMesa14 = New System.Windows.Forms.Button()
        Me.btnMesa15 = New System.Windows.Forms.Button()
        Me.btnMesa16 = New System.Windows.Forms.Button()
        Me.btnMesa17 = New System.Windows.Forms.Button()
        Me.btnMesa18 = New System.Windows.Forms.Button()
        Me.btnMesa19 = New System.Windows.Forms.Button()
        Me.btnMesa20 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFactura
        '
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Location = New System.Drawing.Point(61, 556)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(263, 53)
        Me.btnFactura.TabIndex = 21
        Me.btnFactura.Text = "Facturar Mesa"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(641, 589)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(92, 36)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "SERVICIO COMIDAS - CAJA"
        '
        'rdbParaLlevar
        '
        Me.rdbParaLlevar.AutoSize = True
        Me.rdbParaLlevar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbParaLlevar.Location = New System.Drawing.Point(27, 21)
        Me.rdbParaLlevar.Name = "rdbParaLlevar"
        Me.rdbParaLlevar.Size = New System.Drawing.Size(102, 20)
        Me.rdbParaLlevar.TabIndex = 25
        Me.rdbParaLlevar.TabStop = True
        Me.rdbParaLlevar.Text = "Para llevar"
        Me.rdbParaLlevar.UseVisualStyleBackColor = True
        '
        'rdbMesa
        '
        Me.rdbMesa.AutoSize = True
        Me.rdbMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMesa.Location = New System.Drawing.Point(224, 21)
        Me.rdbMesa.Name = "rdbMesa"
        Me.rdbMesa.Size = New System.Drawing.Size(64, 20)
        Me.rdbMesa.TabIndex = 24
        Me.rdbMesa.TabStop = True
        Me.rdbMesa.Text = "Mesa"
        Me.rdbMesa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbParaLlevar)
        Me.GroupBox1.Controls.Add(Me.rdbMesa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(61, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 50)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Comanda"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox8.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox8.TabIndex = 38
        Me.GroupBox8.TabStop = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(90, 41)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 37
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(89, 23)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 36
        Me.lblUser.Text = "Label1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fecha)
        Me.GroupBox5.Location = New System.Drawing.Point(586, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 39
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
        'btnMesa1
        '
        Me.btnMesa1.BackColor = System.Drawing.Color.Lime
        Me.btnMesa1.ForeColor = System.Drawing.Color.Black
        Me.btnMesa1.Location = New System.Drawing.Point(88, 190)
        Me.btnMesa1.Name = "btnMesa1"
        Me.btnMesa1.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa1.TabIndex = 0
        Me.btnMesa1.Text = "MESA 1"
        Me.btnMesa1.UseVisualStyleBackColor = False
        '
        'btnMesa2
        '
        Me.btnMesa2.BackColor = System.Drawing.Color.Lime
        Me.btnMesa2.ForeColor = System.Drawing.Color.Black
        Me.btnMesa2.Location = New System.Drawing.Point(216, 190)
        Me.btnMesa2.Name = "btnMesa2"
        Me.btnMesa2.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa2.TabIndex = 1
        Me.btnMesa2.Text = "MESA 2"
        Me.btnMesa2.UseVisualStyleBackColor = False
        '
        'btnMesa3
        '
        Me.btnMesa3.BackColor = System.Drawing.Color.Lime
        Me.btnMesa3.ForeColor = System.Drawing.Color.Black
        Me.btnMesa3.Location = New System.Drawing.Point(339, 190)
        Me.btnMesa3.Name = "btnMesa3"
        Me.btnMesa3.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa3.TabIndex = 2
        Me.btnMesa3.Text = "MESA 3"
        Me.btnMesa3.UseVisualStyleBackColor = False
        '
        'btnMesa4
        '
        Me.btnMesa4.BackColor = System.Drawing.Color.Lime
        Me.btnMesa4.ForeColor = System.Drawing.Color.Black
        Me.btnMesa4.Location = New System.Drawing.Point(470, 190)
        Me.btnMesa4.Name = "btnMesa4"
        Me.btnMesa4.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa4.TabIndex = 3
        Me.btnMesa4.Text = "MESA 4"
        Me.btnMesa4.UseVisualStyleBackColor = False
        '
        'btnMesa5
        '
        Me.btnMesa5.BackColor = System.Drawing.Color.Lime
        Me.btnMesa5.ForeColor = System.Drawing.Color.Black
        Me.btnMesa5.Location = New System.Drawing.Point(594, 190)
        Me.btnMesa5.Name = "btnMesa5"
        Me.btnMesa5.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa5.TabIndex = 4
        Me.btnMesa5.Text = "MESA 5"
        Me.btnMesa5.UseVisualStyleBackColor = False
        '
        'btnMesa6
        '
        Me.btnMesa6.BackColor = System.Drawing.Color.Lime
        Me.btnMesa6.ForeColor = System.Drawing.Color.Black
        Me.btnMesa6.Location = New System.Drawing.Point(88, 283)
        Me.btnMesa6.Name = "btnMesa6"
        Me.btnMesa6.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa6.TabIndex = 5
        Me.btnMesa6.Text = "MESA 6"
        Me.btnMesa6.UseVisualStyleBackColor = False
        '
        'btnMesa7
        '
        Me.btnMesa7.BackColor = System.Drawing.Color.Lime
        Me.btnMesa7.ForeColor = System.Drawing.Color.Black
        Me.btnMesa7.Location = New System.Drawing.Point(216, 283)
        Me.btnMesa7.Name = "btnMesa7"
        Me.btnMesa7.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa7.TabIndex = 6
        Me.btnMesa7.Text = "MESA 7"
        Me.btnMesa7.UseVisualStyleBackColor = False
        '
        'btnMesa8
        '
        Me.btnMesa8.BackColor = System.Drawing.Color.Lime
        Me.btnMesa8.ForeColor = System.Drawing.Color.Black
        Me.btnMesa8.Location = New System.Drawing.Point(339, 283)
        Me.btnMesa8.Name = "btnMesa8"
        Me.btnMesa8.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa8.TabIndex = 7
        Me.btnMesa8.Text = "MESA 8"
        Me.btnMesa8.UseVisualStyleBackColor = False
        '
        'btnMesa9
        '
        Me.btnMesa9.BackColor = System.Drawing.Color.Lime
        Me.btnMesa9.ForeColor = System.Drawing.Color.Black
        Me.btnMesa9.Location = New System.Drawing.Point(470, 283)
        Me.btnMesa9.Name = "btnMesa9"
        Me.btnMesa9.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa9.TabIndex = 8
        Me.btnMesa9.Text = "MESA 9"
        Me.btnMesa9.UseVisualStyleBackColor = False
        '
        'btnMesa10
        '
        Me.btnMesa10.BackColor = System.Drawing.Color.Lime
        Me.btnMesa10.ForeColor = System.Drawing.Color.Black
        Me.btnMesa10.Location = New System.Drawing.Point(594, 283)
        Me.btnMesa10.Name = "btnMesa10"
        Me.btnMesa10.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa10.TabIndex = 9
        Me.btnMesa10.Text = "MESA 10"
        Me.btnMesa10.UseVisualStyleBackColor = False
        '
        'btnMesa11
        '
        Me.btnMesa11.BackColor = System.Drawing.Color.Lime
        Me.btnMesa11.ForeColor = System.Drawing.Color.Black
        Me.btnMesa11.Location = New System.Drawing.Point(88, 375)
        Me.btnMesa11.Name = "btnMesa11"
        Me.btnMesa11.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa11.TabIndex = 10
        Me.btnMesa11.Text = "MESA 11"
        Me.btnMesa11.UseVisualStyleBackColor = False
        '
        'btnMesa12
        '
        Me.btnMesa12.BackColor = System.Drawing.Color.Lime
        Me.btnMesa12.ForeColor = System.Drawing.Color.Black
        Me.btnMesa12.Location = New System.Drawing.Point(216, 375)
        Me.btnMesa12.Name = "btnMesa12"
        Me.btnMesa12.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa12.TabIndex = 11
        Me.btnMesa12.Text = "MESA 12"
        Me.btnMesa12.UseVisualStyleBackColor = False
        '
        'btnMesa13
        '
        Me.btnMesa13.BackColor = System.Drawing.Color.Lime
        Me.btnMesa13.ForeColor = System.Drawing.Color.Black
        Me.btnMesa13.Location = New System.Drawing.Point(339, 375)
        Me.btnMesa13.Name = "btnMesa13"
        Me.btnMesa13.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa13.TabIndex = 12
        Me.btnMesa13.Text = "MESA 13"
        Me.btnMesa13.UseVisualStyleBackColor = False
        '
        'btnMesa14
        '
        Me.btnMesa14.BackColor = System.Drawing.Color.Lime
        Me.btnMesa14.ForeColor = System.Drawing.Color.Black
        Me.btnMesa14.Location = New System.Drawing.Point(470, 375)
        Me.btnMesa14.Name = "btnMesa14"
        Me.btnMesa14.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa14.TabIndex = 13
        Me.btnMesa14.Text = "MESA 14"
        Me.btnMesa14.UseVisualStyleBackColor = False
        '
        'btnMesa15
        '
        Me.btnMesa15.BackColor = System.Drawing.Color.Lime
        Me.btnMesa15.ForeColor = System.Drawing.Color.Black
        Me.btnMesa15.Location = New System.Drawing.Point(594, 375)
        Me.btnMesa15.Name = "btnMesa15"
        Me.btnMesa15.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa15.TabIndex = 14
        Me.btnMesa15.Text = "MESA 15"
        Me.btnMesa15.UseVisualStyleBackColor = False
        '
        'btnMesa16
        '
        Me.btnMesa16.BackColor = System.Drawing.Color.Lime
        Me.btnMesa16.ForeColor = System.Drawing.Color.Black
        Me.btnMesa16.Location = New System.Drawing.Point(88, 468)
        Me.btnMesa16.Name = "btnMesa16"
        Me.btnMesa16.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa16.TabIndex = 15
        Me.btnMesa16.Text = "MESA 16"
        Me.btnMesa16.UseVisualStyleBackColor = False
        '
        'btnMesa17
        '
        Me.btnMesa17.BackColor = System.Drawing.Color.Lime
        Me.btnMesa17.ForeColor = System.Drawing.Color.Black
        Me.btnMesa17.Location = New System.Drawing.Point(216, 468)
        Me.btnMesa17.Name = "btnMesa17"
        Me.btnMesa17.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa17.TabIndex = 16
        Me.btnMesa17.Text = "MESA 17"
        Me.btnMesa17.UseVisualStyleBackColor = False
        '
        'btnMesa18
        '
        Me.btnMesa18.BackColor = System.Drawing.Color.Lime
        Me.btnMesa18.ForeColor = System.Drawing.Color.Black
        Me.btnMesa18.Location = New System.Drawing.Point(339, 468)
        Me.btnMesa18.Name = "btnMesa18"
        Me.btnMesa18.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa18.TabIndex = 17
        Me.btnMesa18.Text = "MESA 18"
        Me.btnMesa18.UseVisualStyleBackColor = False
        '
        'btnMesa19
        '
        Me.btnMesa19.BackColor = System.Drawing.Color.Lime
        Me.btnMesa19.ForeColor = System.Drawing.Color.Black
        Me.btnMesa19.Location = New System.Drawing.Point(470, 468)
        Me.btnMesa19.Name = "btnMesa19"
        Me.btnMesa19.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa19.TabIndex = 18
        Me.btnMesa19.Text = "MESA 19"
        Me.btnMesa19.UseVisualStyleBackColor = False
        '
        'btnMesa20
        '
        Me.btnMesa20.BackColor = System.Drawing.Color.Lime
        Me.btnMesa20.ForeColor = System.Drawing.Color.Black
        Me.btnMesa20.Location = New System.Drawing.Point(594, 468)
        Me.btnMesa20.Name = "btnMesa20"
        Me.btnMesa20.Size = New System.Drawing.Size(96, 64)
        Me.btnMesa20.TabIndex = 19
        Me.btnMesa20.Text = "MESA 20"
        Me.btnMesa20.UseVisualStyleBackColor = False
        '
        'Mesass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 649)
        Me.Controls.Add(Me.btnMesa20)
        Me.Controls.Add(Me.btnMesa19)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnMesa18)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.btnMesa17)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.btnMesa16)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnMesa15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMesa14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMesa13)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnMesa12)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnMesa11)
        Me.Controls.Add(Me.btnMesa2)
        Me.Controls.Add(Me.btnMesa10)
        Me.Controls.Add(Me.btnMesa1)
        Me.Controls.Add(Me.btnMesa9)
        Me.Controls.Add(Me.btnMesa3)
        Me.Controls.Add(Me.btnMesa8)
        Me.Controls.Add(Me.btnMesa4)
        Me.Controls.Add(Me.btnMesa7)
        Me.Controls.Add(Me.btnMesa5)
        Me.Controls.Add(Me.btnMesa6)
        Me.Name = "Mesass"
        Me.Text = "Mesas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFactura As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbParaLlevar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMesa As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents btnMesa1 As System.Windows.Forms.Button
    Friend WithEvents btnMesa2 As System.Windows.Forms.Button
    Friend WithEvents btnMesa3 As System.Windows.Forms.Button
    Friend WithEvents btnMesa4 As System.Windows.Forms.Button
    Friend WithEvents btnMesa5 As System.Windows.Forms.Button
    Friend WithEvents btnMesa6 As System.Windows.Forms.Button
    Friend WithEvents btnMesa7 As System.Windows.Forms.Button
    Friend WithEvents btnMesa8 As System.Windows.Forms.Button
    Friend WithEvents btnMesa9 As System.Windows.Forms.Button
    Friend WithEvents btnMesa10 As System.Windows.Forms.Button
    Friend WithEvents btnMesa11 As System.Windows.Forms.Button
    Friend WithEvents btnMesa12 As System.Windows.Forms.Button
    Friend WithEvents btnMesa13 As System.Windows.Forms.Button
    Friend WithEvents btnMesa14 As System.Windows.Forms.Button
    Friend WithEvents btnMesa15 As System.Windows.Forms.Button
    Friend WithEvents btnMesa16 As System.Windows.Forms.Button
    Friend WithEvents btnMesa17 As System.Windows.Forms.Button
    Friend WithEvents btnMesa18 As System.Windows.Forms.Button
    Friend WithEvents btnMesa19 As System.Windows.Forms.Button
    Friend WithEvents btnMesa20 As System.Windows.Forms.Button
End Class
