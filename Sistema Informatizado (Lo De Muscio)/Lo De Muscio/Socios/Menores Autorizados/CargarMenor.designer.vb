<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarMenor
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
        Me.btnCargarMenor = New System.Windows.Forms.Button()
        Me.btnVolverCMenor = New System.Windows.Forms.Button()
        Me.lblCargarMenor = New System.Windows.Forms.Label()
        Me.txtNomMenor = New System.Windows.Forms.TextBox()
        Me.txtMontoMenor = New System.Windows.Forms.TextBox()
        Me.txtApeMenor = New System.Windows.Forms.TextBox()
        Me.txtIdSocioMenor = New System.Windows.Forms.TextBox()
        Me.lblNomMenor = New System.Windows.Forms.Label()
        Me.lblApeMenor = New System.Windows.Forms.Label()
        Me.lblSocioMenor = New System.Windows.Forms.Label()
        Me.lblMontoMenor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCargarMenor
        '
        Me.btnCargarMenor.Location = New System.Drawing.Point(127, 237)
        Me.btnCargarMenor.Name = "btnCargarMenor"
        Me.btnCargarMenor.Size = New System.Drawing.Size(229, 49)
        Me.btnCargarMenor.TabIndex = 6
        Me.btnCargarMenor.Text = "GENERAR AUTORIZACION"
        Me.btnCargarMenor.UseVisualStyleBackColor = True
        '
        'btnVolverCMenor
        '
        Me.btnVolverCMenor.Location = New System.Drawing.Point(383, 270)
        Me.btnVolverCMenor.Name = "btnVolverCMenor"
        Me.btnVolverCMenor.Size = New System.Drawing.Size(73, 26)
        Me.btnVolverCMenor.TabIndex = 12
        Me.btnVolverCMenor.Text = "VOLVER"
        Me.btnVolverCMenor.UseVisualStyleBackColor = True
        '
        'lblCargarMenor
        '
        Me.lblCargarMenor.AutoSize = True
        Me.lblCargarMenor.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarMenor.Location = New System.Drawing.Point(21, 25)
        Me.lblCargarMenor.Name = "lblCargarMenor"
        Me.lblCargarMenor.Size = New System.Drawing.Size(417, 33)
        Me.lblCargarMenor.TabIndex = 13
        Me.lblCargarMenor.Text = "Generar Autorizacion de Menor"
        '
        'txtNomMenor
        '
        Me.txtNomMenor.Location = New System.Drawing.Point(208, 22)
        Me.txtNomMenor.Name = "txtNomMenor"
        Me.txtNomMenor.Size = New System.Drawing.Size(178, 20)
        Me.txtNomMenor.TabIndex = 14
        '
        'txtMontoMenor
        '
        Me.txtMontoMenor.Location = New System.Drawing.Point(208, 137)
        Me.txtMontoMenor.Name = "txtMontoMenor"
        Me.txtMontoMenor.Size = New System.Drawing.Size(178, 20)
        Me.txtMontoMenor.TabIndex = 15
        '
        'txtApeMenor
        '
        Me.txtApeMenor.Location = New System.Drawing.Point(208, 59)
        Me.txtApeMenor.Name = "txtApeMenor"
        Me.txtApeMenor.Size = New System.Drawing.Size(178, 20)
        Me.txtApeMenor.TabIndex = 15
        '
        'txtIdSocioMenor
        '
        Me.txtIdSocioMenor.Location = New System.Drawing.Point(208, 95)
        Me.txtIdSocioMenor.Name = "txtIdSocioMenor"
        Me.txtIdSocioMenor.Size = New System.Drawing.Size(178, 20)
        Me.txtIdSocioMenor.TabIndex = 16
        '
        'lblNomMenor
        '
        Me.lblNomMenor.AutoSize = True
        Me.lblNomMenor.Location = New System.Drawing.Point(41, 29)
        Me.lblNomMenor.Name = "lblNomMenor"
        Me.lblNomMenor.Size = New System.Drawing.Size(148, 13)
        Me.lblNomMenor.TabIndex = 17
        Me.lblNomMenor.Text = "Nombre del menor autorizado:"
        '
        'lblApeMenor
        '
        Me.lblApeMenor.AutoSize = True
        Me.lblApeMenor.Location = New System.Drawing.Point(46, 62)
        Me.lblApeMenor.Name = "lblApeMenor"
        Me.lblApeMenor.Size = New System.Drawing.Size(150, 13)
        Me.lblApeMenor.TabIndex = 18
        Me.lblApeMenor.Text = "Apellido del Menor Autorizado:"
        '
        'lblSocioMenor
        '
        Me.lblSocioMenor.AutoSize = True
        Me.lblSocioMenor.Location = New System.Drawing.Point(13, 102)
        Me.lblSocioMenor.Name = "lblSocioMenor"
        Me.lblSocioMenor.Size = New System.Drawing.Size(183, 13)
        Me.lblSocioMenor.TabIndex = 19
        Me.lblSocioMenor.Text = "Num. Socio del Titular De La Cuenta:"
        '
        'lblMontoMenor
        '
        Me.lblMontoMenor.AutoSize = True
        Me.lblMontoMenor.Location = New System.Drawing.Point(76, 140)
        Me.lblMontoMenor.Name = "lblMontoMenor"
        Me.lblMontoMenor.Size = New System.Drawing.Size(113, 13)
        Me.lblMontoMenor.TabIndex = 20
        Me.lblMontoMenor.Text = "Monto Limite Mensual:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMontoMenor)
        Me.GroupBox1.Controls.Add(Me.lblSocioMenor)
        Me.GroupBox1.Controls.Add(Me.lblApeMenor)
        Me.GroupBox1.Controls.Add(Me.lblNomMenor)
        Me.GroupBox1.Controls.Add(Me.txtIdSocioMenor)
        Me.GroupBox1.Controls.Add(Me.txtApeMenor)
        Me.GroupBox1.Controls.Add(Me.txtMontoMenor)
        Me.GroupBox1.Controls.Add(Me.txtNomMenor)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 170)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'frmCargarMenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(477, 308)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCargarMenor)
        Me.Controls.Add(Me.btnVolverCMenor)
        Me.Controls.Add(Me.btnCargarMenor)
        Me.Name = "frmCargarMenor"
        Me.Text = "Cargar Autorizacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargarMenor As System.Windows.Forms.Button
    Friend WithEvents btnVolverCMenor As System.Windows.Forms.Button
    Friend WithEvents lblCargarMenor As System.Windows.Forms.Label
    Friend WithEvents txtNomMenor As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoMenor As System.Windows.Forms.TextBox
    Friend WithEvents txtApeMenor As System.Windows.Forms.TextBox
    Friend WithEvents txtIdSocioMenor As System.Windows.Forms.TextBox
    Friend WithEvents lblNomMenor As System.Windows.Forms.Label
    Friend WithEvents lblApeMenor As System.Windows.Forms.Label
    Friend WithEvents lblSocioMenor As System.Windows.Forms.Label
    Friend WithEvents lblMontoMenor As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
