<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisUser
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
        Me.lblRegisUser = New System.Windows.Forms.Label()
        Me.btnVolverRUser = New System.Windows.Forms.Button()
        Me.txtNomUser = New System.Windows.Forms.TextBox()
        Me.lblNomUser = New System.Windows.Forms.Label()
        Me.txtConUser = New System.Windows.Forms.TextBox()
        Me.txtConfCon = New System.Windows.Forms.TextBox()
        Me.txtDniEmpUser = New System.Windows.Forms.TextBox()
        Me.lblIdEmpUser = New System.Windows.Forms.Label()
        Me.lblConUser = New System.Windows.Forms.Label()
        Me.lblPermUser = New System.Windows.Forms.Label()
        Me.lblConfConUser = New System.Windows.Forms.Label()
        Me.cmbPermUser = New System.Windows.Forms.ComboBox()
        Me.btnRegisUser = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegisUser
        '
        Me.lblRegisUser.AutoSize = True
        Me.lblRegisUser.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisUser.Location = New System.Drawing.Point(138, 22)
        Me.lblRegisUser.Name = "lblRegisUser"
        Me.lblRegisUser.Size = New System.Drawing.Size(239, 33)
        Me.lblRegisUser.TabIndex = 13
        Me.lblRegisUser.Text = "Registrar Usuario"
        '
        'btnVolverRUser
        '
        Me.btnVolverRUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverRUser.Location = New System.Drawing.Point(403, 383)
        Me.btnVolverRUser.Name = "btnVolverRUser"
        Me.btnVolverRUser.Size = New System.Drawing.Size(84, 38)
        Me.btnVolverRUser.TabIndex = 16
        Me.btnVolverRUser.Text = "VOLVER"
        Me.btnVolverRUser.UseVisualStyleBackColor = True
        '
        'txtNomUser
        '
        Me.txtNomUser.Location = New System.Drawing.Point(131, 23)
        Me.txtNomUser.Name = "txtNomUser"
        Me.txtNomUser.Size = New System.Drawing.Size(256, 20)
        Me.txtNomUser.TabIndex = 17
        '
        'lblNomUser
        '
        Me.lblNomUser.AutoSize = True
        Me.lblNomUser.Location = New System.Drawing.Point(24, 26)
        Me.lblNomUser.Name = "lblNomUser"
        Me.lblNomUser.Size = New System.Drawing.Size(101, 13)
        Me.lblNomUser.TabIndex = 18
        Me.lblNomUser.Text = "Nombre de Usuario:"
        '
        'txtConUser
        '
        Me.txtConUser.Location = New System.Drawing.Point(131, 122)
        Me.txtConUser.Name = "txtConUser"
        Me.txtConUser.Size = New System.Drawing.Size(256, 20)
        Me.txtConUser.TabIndex = 19
        Me.txtConUser.UseSystemPasswordChar = True
        '
        'txtConfCon
        '
        Me.txtConfCon.Location = New System.Drawing.Point(131, 170)
        Me.txtConfCon.Name = "txtConfCon"
        Me.txtConfCon.Size = New System.Drawing.Size(256, 20)
        Me.txtConfCon.TabIndex = 20
        Me.txtConfCon.UseSystemPasswordChar = True
        '
        'txtDniEmpUser
        '
        Me.txtDniEmpUser.Location = New System.Drawing.Point(131, 75)
        Me.txtDniEmpUser.Name = "txtDniEmpUser"
        Me.txtDniEmpUser.Size = New System.Drawing.Size(256, 20)
        Me.txtDniEmpUser.TabIndex = 21
        '
        'lblIdEmpUser
        '
        Me.lblIdEmpUser.AutoSize = True
        Me.lblIdEmpUser.Location = New System.Drawing.Point(32, 78)
        Me.lblIdEmpUser.Name = "lblIdEmpUser"
        Me.lblIdEmpUser.Size = New System.Drawing.Size(93, 13)
        Me.lblIdEmpUser.TabIndex = 22
        Me.lblIdEmpUser.Text = "DNI de empleado:"
        '
        'lblConUser
        '
        Me.lblConUser.AutoSize = True
        Me.lblConUser.Location = New System.Drawing.Point(61, 125)
        Me.lblConUser.Name = "lblConUser"
        Me.lblConUser.Size = New System.Drawing.Size(64, 13)
        Me.lblConUser.TabIndex = 23
        Me.lblConUser.Text = "Contraseña:"
        '
        'lblPermUser
        '
        Me.lblPermUser.AutoSize = True
        Me.lblPermUser.Location = New System.Drawing.Point(130, 223)
        Me.lblPermUser.Name = "lblPermUser"
        Me.lblPermUser.Size = New System.Drawing.Size(52, 13)
        Me.lblPermUser.TabIndex = 24
        Me.lblPermUser.Text = "Permisos:"
        '
        'lblConfConUser
        '
        Me.lblConfConUser.AutoSize = True
        Me.lblConfConUser.Location = New System.Drawing.Point(14, 173)
        Me.lblConfConUser.Name = "lblConfConUser"
        Me.lblConfConUser.Size = New System.Drawing.Size(111, 13)
        Me.lblConfConUser.TabIndex = 25
        Me.lblConfConUser.Text = "Confirmar Contraseña:"
        '
        'cmbPermUser
        '
        Me.cmbPermUser.FormattingEnabled = True
        Me.cmbPermUser.Items.AddRange(New Object() {"Admin", "Compras", "Caja", "Mozo"})
        Me.cmbPermUser.Location = New System.Drawing.Point(188, 220)
        Me.cmbPermUser.Name = "cmbPermUser"
        Me.cmbPermUser.Size = New System.Drawing.Size(121, 21)
        Me.cmbPermUser.TabIndex = 26
        '
        'btnRegisUser
        '
        Me.btnRegisUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisUser.Location = New System.Drawing.Point(193, 342)
        Me.btnRegisUser.Name = "btnRegisUser"
        Me.btnRegisUser.Size = New System.Drawing.Size(134, 53)
        Me.btnRegisUser.TabIndex = 27
        Me.btnRegisUser.Text = "REGISTRAR"
        Me.btnRegisUser.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPermUser)
        Me.GroupBox1.Controls.Add(Me.lblConfConUser)
        Me.GroupBox1.Controls.Add(Me.lblPermUser)
        Me.GroupBox1.Controls.Add(Me.lblConUser)
        Me.GroupBox1.Controls.Add(Me.lblIdEmpUser)
        Me.GroupBox1.Controls.Add(Me.txtDniEmpUser)
        Me.GroupBox1.Controls.Add(Me.txtConfCon)
        Me.GroupBox1.Controls.Add(Me.txtConUser)
        Me.GroupBox1.Controls.Add(Me.lblNomUser)
        Me.GroupBox1.Controls.Add(Me.txtNomUser)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 263)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'frmRegisUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(509, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegisUser)
        Me.Controls.Add(Me.btnVolverRUser)
        Me.Controls.Add(Me.lblRegisUser)
        Me.Name = "frmRegisUser"
        Me.Text = "Registrar Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegisUser As System.Windows.Forms.Label
    Friend WithEvents btnVolverRUser As System.Windows.Forms.Button
    Friend WithEvents txtNomUser As System.Windows.Forms.TextBox
    Friend WithEvents lblNomUser As System.Windows.Forms.Label
    Friend WithEvents txtConUser As System.Windows.Forms.TextBox
    Friend WithEvents txtConfCon As System.Windows.Forms.TextBox
    Friend WithEvents txtDniEmpUser As System.Windows.Forms.TextBox
    Friend WithEvents lblIdEmpUser As System.Windows.Forms.Label
    Friend WithEvents lblConUser As System.Windows.Forms.Label
    Friend WithEvents lblPermUser As System.Windows.Forms.Label
    Friend WithEvents lblConfConUser As System.Windows.Forms.Label
    Friend WithEvents cmbPermUser As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegisUser As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
