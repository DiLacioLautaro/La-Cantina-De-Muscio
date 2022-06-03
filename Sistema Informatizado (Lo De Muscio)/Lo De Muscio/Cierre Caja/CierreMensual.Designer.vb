<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CierreMensual
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCargarCierreMensual = New System.Windows.Forms.Button()
        Me.txtNeto = New System.Windows.Forms.TextBox()
        Me.txtGastos = New System.Windows.Forms.TextBox()
        Me.txtIngresos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMensual = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblCierre = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpInicioMes = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(596, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Buscar"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(551, 369)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(102, 38)
        Me.btnVolver.TabIndex = 35
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnCargarCierreMensual
        '
        Me.btnCargarCierreMensual.Enabled = False
        Me.btnCargarCierreMensual.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarCierreMensual.Location = New System.Drawing.Point(232, 205)
        Me.btnCargarCierreMensual.Name = "btnCargarCierreMensual"
        Me.btnCargarCierreMensual.Size = New System.Drawing.Size(281, 59)
        Me.btnCargarCierreMensual.TabIndex = 34
        Me.btnCargarCierreMensual.Text = "CARGAR CIERRE MENSUAL"
        Me.btnCargarCierreMensual.UseVisualStyleBackColor = True
        '
        'txtNeto
        '
        Me.txtNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeto.Location = New System.Drawing.Point(363, 169)
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Size = New System.Drawing.Size(176, 24)
        Me.txtNeto.TabIndex = 33
        '
        'txtGastos
        '
        Me.txtGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastos.ForeColor = System.Drawing.Color.Red
        Me.txtGastos.Location = New System.Drawing.Point(363, 133)
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Size = New System.Drawing.Size(176, 22)
        Me.txtGastos.TabIndex = 32
        '
        'txtIngresos
        '
        Me.txtIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresos.ForeColor = System.Drawing.Color.Green
        Me.txtIngresos.Location = New System.Drawing.Point(363, 101)
        Me.txtIngresos.Name = "txtIngresos"
        Me.txtIngresos.Size = New System.Drawing.Size(176, 22)
        Me.txtIngresos.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(276, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "NETO: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Total Gastos: $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Total Ingresos: $"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(358, 67)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(58, 23)
        Me.lblFecha.TabIndex = 27
        Me.lblFecha.Text = "fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Fin de Mes: "
        '
        'btnMensual
        '
        Me.btnMensual.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensual.Location = New System.Drawing.Point(24, 38)
        Me.btnMensual.Name = "btnMensual"
        Me.btnMensual.Size = New System.Drawing.Size(179, 83)
        Me.btnMensual.TabIndex = 25
        Me.btnMensual.Text = "GENERAR CIERRE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MENSUAL"
        Me.btnMensual.UseVisualStyleBackColor = True
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(18, 33)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(385, 39)
        Me.lblMenu.TabIndex = 24
        Me.lblMenu.Text = "Cierre De Caja Mensual: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(212, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Inicio de Mes: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Ejemplo: 2019-11-01"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblMes.Location = New System.Drawing.Point(400, 33)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(83, 39)
        Me.lblMes.TabIndex = 41
        Me.lblMes.Text = "MES"
        '
        'lblCierre
        '
        Me.lblCierre.AutoSize = True
        Me.lblCierre.Font = New System.Drawing.Font("Constantia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCierre.ForeColor = System.Drawing.Color.Red
        Me.lblCierre.Location = New System.Drawing.Point(6, 170)
        Me.lblCierre.Name = "lblCierre"
        Me.lblCierre.Size = New System.Drawing.Size(222, 23)
        Me.lblCierre.TabIndex = 42
        Me.lblCierre.Text = "CIERRE YA REALIZADO"
        Me.lblCierre.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.Image = Global.Lo_De_Muscio.My.Resources.Resources.lupafinished
        Me.btnbuscar.Location = New System.Drawing.Point(607, 38)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(46, 40)
        Me.btnbuscar.TabIndex = 36
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpInicioMes)
        Me.GroupBox1.Controls.Add(Me.lblCierre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCargarCierreMensual)
        Me.GroupBox1.Controls.Add(Me.txtNeto)
        Me.GroupBox1.Controls.Add(Me.txtGastos)
        Me.GroupBox1.Controls.Add(Me.txtIngresos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnMensual)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 275)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'dtpInicioMes
        '
        Me.dtpInicioMes.Location = New System.Drawing.Point(361, 40)
        Me.dtpInicioMes.Name = "dtpInicioMes"
        Me.dtpInicioMes.Size = New System.Drawing.Size(178, 20)
        Me.dtpInicioMes.TabIndex = 44
        '
        'CierreMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(678, 419)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "CierreMensual"
        Me.Text = "Cierre De Caja Mensual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnCargarCierreMensual As System.Windows.Forms.Button
    Friend WithEvents txtNeto As System.Windows.Forms.TextBox
    Friend WithEvents txtGastos As System.Windows.Forms.TextBox
    Friend WithEvents txtIngresos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMensual As System.Windows.Forms.Button
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents lblCierre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpInicioMes As System.Windows.Forms.DateTimePicker
End Class
