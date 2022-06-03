<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarSocio
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
        Me.lblCargarSocio = New System.Windows.Forms.Label()
        Me.btnVolverCSocios = New System.Windows.Forms.Button()
        Me.txtTelSocio = New System.Windows.Forms.TextBox()
        Me.txtNomSocio = New System.Windows.Forms.TextBox()
        Me.txtApeSocio = New System.Windows.Forms.TextBox()
        Me.txtDNISocio = New System.Windows.Forms.TextBox()
        Me.txtMailSocio = New System.Windows.Forms.TextBox()
        Me.txtLocSocio = New System.Windows.Forms.TextBox()
        Me.lblNomSocio = New System.Windows.Forms.Label()
        Me.lblApeSocio = New System.Windows.Forms.Label()
        Me.lblTelSocio = New System.Windows.Forms.Label()
        Me.lblMailSocio = New System.Windows.Forms.Label()
        Me.lblDniSocio = New System.Windows.Forms.Label()
        Me.lblLocSocio = New System.Windows.Forms.Label()
        Me.btnCargarSocio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdSocio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCargarSocio
        '
        Me.lblCargarSocio.AutoSize = True
        Me.lblCargarSocio.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarSocio.Location = New System.Drawing.Point(183, 30)
        Me.lblCargarSocio.Name = "lblCargarSocio"
        Me.lblCargarSocio.Size = New System.Drawing.Size(173, 33)
        Me.lblCargarSocio.TabIndex = 15
        Me.lblCargarSocio.Text = "Cargar Socio"
        '
        'btnVolverCSocios
        '
        Me.btnVolverCSocios.Location = New System.Drawing.Point(419, 331)
        Me.btnVolverCSocios.Name = "btnVolverCSocios"
        Me.btnVolverCSocios.Size = New System.Drawing.Size(78, 42)
        Me.btnVolverCSocios.TabIndex = 16
        Me.btnVolverCSocios.Text = "VOLVER"
        Me.btnVolverCSocios.UseVisualStyleBackColor = True
        '
        'txtTelSocio
        '
        Me.txtTelSocio.Location = New System.Drawing.Point(323, 59)
        Me.txtTelSocio.Name = "txtTelSocio"
        Me.txtTelSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtTelSocio.TabIndex = 18
        '
        'txtNomSocio
        '
        Me.txtNomSocio.Location = New System.Drawing.Point(71, 56)
        Me.txtNomSocio.Name = "txtNomSocio"
        Me.txtNomSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtNomSocio.TabIndex = 18
        '
        'txtApeSocio
        '
        Me.txtApeSocio.Location = New System.Drawing.Point(323, 19)
        Me.txtApeSocio.Name = "txtApeSocio"
        Me.txtApeSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtApeSocio.TabIndex = 19
        '
        'txtDNISocio
        '
        Me.txtDNISocio.Location = New System.Drawing.Point(323, 101)
        Me.txtDNISocio.Name = "txtDNISocio"
        Me.txtDNISocio.Size = New System.Drawing.Size(178, 20)
        Me.txtDNISocio.TabIndex = 19
        '
        'txtMailSocio
        '
        Me.txtMailSocio.Location = New System.Drawing.Point(71, 98)
        Me.txtMailSocio.Name = "txtMailSocio"
        Me.txtMailSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtMailSocio.TabIndex = 20
        '
        'txtLocSocio
        '
        Me.txtLocSocio.Location = New System.Drawing.Point(212, 139)
        Me.txtLocSocio.Name = "txtLocSocio"
        Me.txtLocSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtLocSocio.TabIndex = 21
        '
        'lblNomSocio
        '
        Me.lblNomSocio.AutoSize = True
        Me.lblNomSocio.Location = New System.Drawing.Point(8, 59)
        Me.lblNomSocio.Name = "lblNomSocio"
        Me.lblNomSocio.Size = New System.Drawing.Size(47, 13)
        Me.lblNomSocio.TabIndex = 22
        Me.lblNomSocio.Text = "Nombre:"
        '
        'lblApeSocio
        '
        Me.lblApeSocio.AutoSize = True
        Me.lblApeSocio.Location = New System.Drawing.Point(270, 22)
        Me.lblApeSocio.Name = "lblApeSocio"
        Me.lblApeSocio.Size = New System.Drawing.Size(47, 13)
        Me.lblApeSocio.TabIndex = 23
        Me.lblApeSocio.Text = "Apellido:"
        '
        'lblTelSocio
        '
        Me.lblTelSocio.AutoSize = True
        Me.lblTelSocio.Location = New System.Drawing.Point(265, 62)
        Me.lblTelSocio.Name = "lblTelSocio"
        Me.lblTelSocio.Size = New System.Drawing.Size(52, 13)
        Me.lblTelSocio.TabIndex = 24
        Me.lblTelSocio.Text = "Telefono:"
        '
        'lblMailSocio
        '
        Me.lblMailSocio.AutoSize = True
        Me.lblMailSocio.Location = New System.Drawing.Point(16, 101)
        Me.lblMailSocio.Name = "lblMailSocio"
        Me.lblMailSocio.Size = New System.Drawing.Size(39, 13)
        Me.lblMailSocio.TabIndex = 25
        Me.lblMailSocio.Text = "E-Mail:"
        '
        'lblDniSocio
        '
        Me.lblDniSocio.AutoSize = True
        Me.lblDniSocio.Location = New System.Drawing.Point(288, 108)
        Me.lblDniSocio.Name = "lblDniSocio"
        Me.lblDniSocio.Size = New System.Drawing.Size(29, 13)
        Me.lblDniSocio.TabIndex = 26
        Me.lblDniSocio.Text = "DNI:"
        '
        'lblLocSocio
        '
        Me.lblLocSocio.AutoSize = True
        Me.lblLocSocio.Location = New System.Drawing.Point(150, 142)
        Me.lblLocSocio.Name = "lblLocSocio"
        Me.lblLocSocio.Size = New System.Drawing.Size(56, 13)
        Me.lblLocSocio.TabIndex = 27
        Me.lblLocSocio.Text = "Localidad:"
        '
        'btnCargarSocio
        '
        Me.btnCargarSocio.Location = New System.Drawing.Point(189, 271)
        Me.btnCargarSocio.Name = "btnCargarSocio"
        Me.btnCargarSocio.Size = New System.Drawing.Size(201, 66)
        Me.btnCargarSocio.TabIndex = 28
        Me.btnCargarSocio.Text = "CARGAR"
        Me.btnCargarSocio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nro. Carnet " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  de Socio:"
        '
        'txtIdSocio
        '
        Me.txtIdSocio.Location = New System.Drawing.Point(71, 19)
        Me.txtIdSocio.Name = "txtIdSocio"
        Me.txtIdSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtIdSocio.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdSocio)
        Me.GroupBox1.Controls.Add(Me.lblLocSocio)
        Me.GroupBox1.Controls.Add(Me.lblDniSocio)
        Me.GroupBox1.Controls.Add(Me.lblMailSocio)
        Me.GroupBox1.Controls.Add(Me.lblTelSocio)
        Me.GroupBox1.Controls.Add(Me.lblApeSocio)
        Me.GroupBox1.Controls.Add(Me.lblNomSocio)
        Me.GroupBox1.Controls.Add(Me.txtLocSocio)
        Me.GroupBox1.Controls.Add(Me.txtMailSocio)
        Me.GroupBox1.Controls.Add(Me.txtDNISocio)
        Me.GroupBox1.Controls.Add(Me.txtApeSocio)
        Me.GroupBox1.Controls.Add(Me.txtNomSocio)
        Me.GroupBox1.Controls.Add(Me.txtTelSocio)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 171)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'frmCargarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(548, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCargarSocio)
        Me.Controls.Add(Me.btnVolverCSocios)
        Me.Controls.Add(Me.lblCargarSocio)
        Me.Name = "frmCargarSocio"
        Me.Text = "Cargar Socio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCargarSocio As System.Windows.Forms.Label
    Friend WithEvents btnVolverCSocios As System.Windows.Forms.Button
    Friend WithEvents txtTelSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNomSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtApeSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtDNISocio As System.Windows.Forms.TextBox
    Friend WithEvents txtMailSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtLocSocio As System.Windows.Forms.TextBox
    Friend WithEvents lblNomSocio As System.Windows.Forms.Label
    Friend WithEvents lblApeSocio As System.Windows.Forms.Label
    Friend WithEvents lblTelSocio As System.Windows.Forms.Label
    Friend WithEvents lblMailSocio As System.Windows.Forms.Label
    Friend WithEvents lblDniSocio As System.Windows.Forms.Label
    Friend WithEvents lblLocSocio As System.Windows.Forms.Label
    Friend WithEvents btnCargarSocio As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdSocio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
