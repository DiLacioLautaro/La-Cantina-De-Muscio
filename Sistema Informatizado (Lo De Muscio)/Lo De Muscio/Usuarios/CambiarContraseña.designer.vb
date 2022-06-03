<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambCon
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
        Me.lblModCon = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblConV = New System.Windows.Forms.Label()
        Me.txtConV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConN2 = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnV1 = New System.Windows.Forms.Button()
        Me.btnV2 = New System.Windows.Forms.Button()
        Me.btnV3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModCon
        '
        Me.lblModCon.AutoSize = True
        Me.lblModCon.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModCon.Location = New System.Drawing.Point(138, 24)
        Me.lblModCon.Name = "lblModCon"
        Me.lblModCon.Size = New System.Drawing.Size(274, 33)
        Me.lblModCon.TabIndex = 14
        Me.lblModCon.Text = "Cambiar Contraseña"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(457, 298)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(88, 31)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblConV
        '
        Me.lblConV.AutoSize = True
        Me.lblConV.Location = New System.Drawing.Point(28, 27)
        Me.lblConV.Name = "lblConV"
        Me.lblConV.Size = New System.Drawing.Size(96, 13)
        Me.lblConV.TabIndex = 20
        Me.lblConV.Text = "Contraseña actual:"
        '
        'txtConV
        '
        Me.txtConV.Location = New System.Drawing.Point(130, 24)
        Me.txtConV.Name = "txtConV"
        Me.txtConV.Size = New System.Drawing.Size(256, 20)
        Me.txtConV.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nueva Contraseña:"
        '
        'txtConN
        '
        Me.txtConN.Location = New System.Drawing.Point(130, 71)
        Me.txtConN.Name = "txtConN"
        Me.txtConN.Size = New System.Drawing.Size(256, 20)
        Me.txtConN.TabIndex = 21
        Me.txtConN.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Confirmar Contraseña:"
        '
        'txtConN2
        '
        Me.txtConN2.Location = New System.Drawing.Point(130, 122)
        Me.txtConN2.Name = "txtConN2"
        Me.txtConN2.Size = New System.Drawing.Size(256, 20)
        Me.txtConN2.TabIndex = 23
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(204, 239)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(186, 49)
        Me.btnConfirmar.TabIndex = 28
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnV1
        '
        Me.btnV1.Location = New System.Drawing.Point(392, 20)
        Me.btnV1.Name = "btnV1"
        Me.btnV1.Size = New System.Drawing.Size(61, 26)
        Me.btnV1.TabIndex = 29
        Me.btnV1.Text = "Ver"
        Me.btnV1.UseVisualStyleBackColor = True
        '
        'btnV2
        '
        Me.btnV2.Location = New System.Drawing.Point(392, 67)
        Me.btnV2.Name = "btnV2"
        Me.btnV2.Size = New System.Drawing.Size(61, 26)
        Me.btnV2.TabIndex = 30
        Me.btnV2.Text = "Ver"
        Me.btnV2.UseVisualStyleBackColor = True
        '
        'btnV3
        '
        Me.btnV3.Location = New System.Drawing.Point(392, 116)
        Me.btnV3.Name = "btnV3"
        Me.btnV3.Size = New System.Drawing.Size(61, 26)
        Me.btnV3.TabIndex = 31
        Me.btnV3.Text = "Ver"
        Me.btnV3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnV3)
        Me.GroupBox1.Controls.Add(Me.btnV2)
        Me.GroupBox1.Controls.Add(Me.btnV1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtConN2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtConN)
        Me.GroupBox1.Controls.Add(Me.lblConV)
        Me.GroupBox1.Controls.Add(Me.txtConV)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 162)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'frmCambCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(557, 341)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblModCon)
        Me.Name = "frmCambCon"
        Me.Text = "Cambiar Contraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModCon As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblConV As System.Windows.Forms.Label
    Friend WithEvents txtConV As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConN2 As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnV1 As System.Windows.Forms.Button
    Friend WithEvents btnV2 As System.Windows.Forms.Button
    Friend WithEvents btnV3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
