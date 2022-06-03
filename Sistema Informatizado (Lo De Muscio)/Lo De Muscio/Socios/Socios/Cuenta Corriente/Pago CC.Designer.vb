<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago_CC
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
        Me.lblModSocio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstIdSocio = New System.Windows.Forms.ListBox()
        Me.txtIdSocio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPagarCC = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstNombre = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstDeuda = New System.Windows.Forms.ListBox()
        Me.lblCierre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModSocio
        '
        Me.lblModSocio.AutoSize = True
        Me.lblModSocio.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModSocio.Location = New System.Drawing.Point(26, 18)
        Me.lblModSocio.Name = "lblModSocio"
        Me.lblModSocio.Size = New System.Drawing.Size(367, 33)
        Me.lblModSocio.TabIndex = 21
        Me.lblModSocio.Text = "Pago de Cuentas Corrientes "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Socio"
        '
        'lstIdSocio
        '
        Me.lstIdSocio.FormattingEnabled = True
        Me.lstIdSocio.Location = New System.Drawing.Point(73, 70)
        Me.lstIdSocio.Name = "lstIdSocio"
        Me.lstIdSocio.Size = New System.Drawing.Size(73, 17)
        Me.lstIdSocio.TabIndex = 41
        '
        'txtIdSocio
        '
        Me.txtIdSocio.Location = New System.Drawing.Point(147, 19)
        Me.txtIdSocio.Name = "txtIdSocio"
        Me.txtIdSocio.Size = New System.Drawing.Size(264, 20)
        Me.txtIdSocio.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Num. Socio:"
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(417, 12)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(67, 27)
        Me.btnVerificar.TabIndex = 45
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Total A Pagar: $"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(166, 150)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(49, 23)
        Me.lblTotal.TabIndex = 49
        Me.lblTotal.Text = "total"
        '
        'btnPagarCC
        '
        Me.btnPagarCC.Enabled = False
        Me.btnPagarCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagarCC.Location = New System.Drawing.Point(27, 188)
        Me.btnPagarCC.Name = "btnPagarCC"
        Me.btnPagarCC.Size = New System.Drawing.Size(272, 59)
        Me.btnPagarCC.TabIndex = 50
        Me.btnPagarCC.Text = "PAGAR CUENTA CORRIENTE"
        Me.btnPagarCC.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(500, 345)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(74, 33)
        Me.btnVolver.TabIndex = 51
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(166, 112)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(44, 23)
        Me.lblMes.TabIndex = 53
        Me.lblMes.Text = "Mes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 23)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Mes a Pagar:"
        '
        'lstNombre
        '
        Me.lstNombre.FormattingEnabled = True
        Me.lstNombre.Location = New System.Drawing.Point(152, 70)
        Me.lstNombre.Name = "lstNombre"
        Me.lstNombre.Size = New System.Drawing.Size(187, 17)
        Me.lstNombre.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Num Socio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(153, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(346, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Deuda"
        '
        'lstDeuda
        '
        Me.lstDeuda.FormattingEnabled = True
        Me.lstDeuda.Location = New System.Drawing.Point(345, 70)
        Me.lstDeuda.Name = "lstDeuda"
        Me.lstDeuda.Size = New System.Drawing.Size(139, 17)
        Me.lstDeuda.TabIndex = 57
        '
        'lblCierre
        '
        Me.lblCierre.AutoSize = True
        Me.lblCierre.Font = New System.Drawing.Font("Constantia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCierre.ForeColor = System.Drawing.Color.Red
        Me.lblCierre.Location = New System.Drawing.Point(48, 381)
        Me.lblCierre.Name = "lblCierre"
        Me.lblCierre.Size = New System.Drawing.Size(511, 19)
        Me.lblCierre.TabIndex = 59
        Me.lblCierre.Text = "Los pagos de CC se realizan entre el 25 hasta el 5 del mes siguiente"
        Me.lblCierre.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lstDeuda)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lstNombre)
        Me.GroupBox1.Controls.Add(Me.lblMes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnPagarCC)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdSocio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lstIdSocio)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 263)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'Pago_CC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCierre)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblModSocio)
        Me.Name = "Pago_CC"
        Me.Text = "Pago Cuenta Corriente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModSocio As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstIdSocio As System.Windows.Forms.ListBox
    Friend WithEvents txtIdSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnPagarCC As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstNombre As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lstDeuda As System.Windows.Forms.ListBox
    Friend WithEvents lblCierre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
