<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReacSocio
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
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.btnVolverRProv = New System.Windows.Forms.Button()
        Me.btnReacSocio = New System.Windows.Forms.Button()
        Me.lblApeProv = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomProv = New System.Windows.Forms.Label()
        Me.txtTelSocio = New System.Windows.Forms.TextBox()
        Me.txtMailSocio = New System.Windows.Forms.TextBox()
        Me.txtDniSocio = New System.Windows.Forms.TextBox()
        Me.txtApeSocio = New System.Windows.Forms.TextBox()
        Me.txtNomSocio = New System.Windows.Forms.TextBox()
        Me.txtLocSocio = New System.Windows.Forms.TextBox()
        Me.dgvReacSocio = New System.Windows.Forms.DataGridView()
        Me.lblReacSocio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvReacSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(166, 72)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 74
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(21, 71)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 73
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'btnVolverRProv
        '
        Me.btnVolverRProv.Location = New System.Drawing.Point(666, 495)
        Me.btnVolverRProv.Name = "btnVolverRProv"
        Me.btnVolverRProv.Size = New System.Drawing.Size(92, 37)
        Me.btnVolverRProv.TabIndex = 72
        Me.btnVolverRProv.Text = "VOLVER"
        Me.btnVolverRProv.UseVisualStyleBackColor = True
        '
        'btnReacSocio
        '
        Me.btnReacSocio.Enabled = False
        Me.btnReacSocio.Location = New System.Drawing.Point(270, 450)
        Me.btnReacSocio.Name = "btnReacSocio"
        Me.btnReacSocio.Size = New System.Drawing.Size(261, 48)
        Me.btnReacSocio.TabIndex = 71
        Me.btnReacSocio.Text = "REACTIVAR"
        Me.btnReacSocio.UseVisualStyleBackColor = True
        '
        'lblApeProv
        '
        Me.lblApeProv.AutoSize = True
        Me.lblApeProv.Location = New System.Drawing.Point(11, 40)
        Me.lblApeProv.Name = "lblApeProv"
        Me.lblApeProv.Size = New System.Drawing.Size(47, 13)
        Me.lblApeProv.TabIndex = 70
        Me.lblApeProv.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(519, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Localidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(535, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "E-Mail:"
        '
        'lblNomProv
        '
        Me.lblNomProv.AutoSize = True
        Me.lblNomProv.Location = New System.Drawing.Point(11, 14)
        Me.lblNomProv.Name = "lblNomProv"
        Me.lblNomProv.Size = New System.Drawing.Size(47, 13)
        Me.lblNomProv.TabIndex = 65
        Me.lblNomProv.Text = "Nombre:"
        '
        'txtTelSocio
        '
        Me.txtTelSocio.Location = New System.Drawing.Point(318, 14)
        Me.txtTelSocio.Name = "txtTelSocio"
        Me.txtTelSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtTelSocio.TabIndex = 64
        '
        'txtMailSocio
        '
        Me.txtMailSocio.Location = New System.Drawing.Point(580, 14)
        Me.txtMailSocio.Name = "txtMailSocio"
        Me.txtMailSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtMailSocio.TabIndex = 63
        '
        'txtDniSocio
        '
        Me.txtDniSocio.Location = New System.Drawing.Point(318, 40)
        Me.txtDniSocio.Name = "txtDniSocio"
        Me.txtDniSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtDniSocio.TabIndex = 62
        '
        'txtApeSocio
        '
        Me.txtApeSocio.Location = New System.Drawing.Point(64, 37)
        Me.txtApeSocio.Name = "txtApeSocio"
        Me.txtApeSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtApeSocio.TabIndex = 61
        '
        'txtNomSocio
        '
        Me.txtNomSocio.Location = New System.Drawing.Point(64, 11)
        Me.txtNomSocio.Name = "txtNomSocio"
        Me.txtNomSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtNomSocio.TabIndex = 60
        '
        'txtLocSocio
        '
        Me.txtLocSocio.Location = New System.Drawing.Point(580, 40)
        Me.txtLocSocio.Name = "txtLocSocio"
        Me.txtLocSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtLocSocio.TabIndex = 59
        '
        'dgvReacSocio
        '
        Me.dgvReacSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReacSocio.Location = New System.Drawing.Point(25, 102)
        Me.dgvReacSocio.Name = "dgvReacSocio"
        Me.dgvReacSocio.Size = New System.Drawing.Size(752, 249)
        Me.dgvReacSocio.TabIndex = 57
        '
        'lblReacSocio
        '
        Me.lblReacSocio.AutoSize = True
        Me.lblReacSocio.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReacSocio.Location = New System.Drawing.Point(290, 25)
        Me.lblReacSocio.Name = "lblReacSocio"
        Me.lblReacSocio.Size = New System.Drawing.Size(209, 33)
        Me.lblReacSocio.TabIndex = 56
        Me.lblReacSocio.Text = "Reactivar Socio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblApeProv)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblNomProv)
        Me.GroupBox1.Controls.Add(Me.txtTelSocio)
        Me.GroupBox1.Controls.Add(Me.txtMailSocio)
        Me.GroupBox1.Controls.Add(Me.txtDniSocio)
        Me.GroupBox1.Controls.Add(Me.txtApeSocio)
        Me.GroupBox1.Controls.Add(Me.txtNomSocio)
        Me.GroupBox1.Controls.Add(Me.txtLocSocio)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 361)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 77)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'frmReacSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnVolverRProv)
        Me.Controls.Add(Me.btnReacSocio)
        Me.Controls.Add(Me.dgvReacSocio)
        Me.Controls.Add(Me.lblReacSocio)
        Me.Name = "frmReacSocio"
        Me.Text = "Reactivar Socio"
        CType(Me.dgvReacSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents btnVolverRProv As System.Windows.Forms.Button
    Friend WithEvents btnReacSocio As System.Windows.Forms.Button
    Friend WithEvents lblApeProv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNomProv As System.Windows.Forms.Label
    Friend WithEvents txtTelSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtMailSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtDniSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtApeSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNomSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtLocSocio As System.Windows.Forms.TextBox
    Friend WithEvents dgvReacSocio As System.Windows.Forms.DataGridView
    Friend WithEvents lblReacSocio As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
