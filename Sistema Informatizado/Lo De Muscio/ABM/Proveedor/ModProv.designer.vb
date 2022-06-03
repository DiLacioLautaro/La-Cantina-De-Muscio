<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModProv
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
        Me.lblModProv = New System.Windows.Forms.Label()
        Me.dgvModProv = New System.Windows.Forms.DataGridView()
        Me.txtPaisProv = New System.Windows.Forms.TextBox()
        Me.txtNomProv = New System.Windows.Forms.TextBox()
        Me.txtDniProv = New System.Windows.Forms.TextBox()
        Me.txtDirProv = New System.Windows.Forms.TextBox()
        Me.txtTelProv = New System.Windows.Forms.TextBox()
        Me.lblNomProv = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModProv = New System.Windows.Forms.Button()
        Me.btnVolverMProv = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvModProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblModProv
        '
        Me.lblModProv.AutoSize = True
        Me.lblModProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModProv.Location = New System.Drawing.Point(276, 25)
        Me.lblModProv.Name = "lblModProv"
        Me.lblModProv.Size = New System.Drawing.Size(276, 33)
        Me.lblModProv.TabIndex = 20
        Me.lblModProv.Text = "Modificar Proveedor"
        '
        'dgvModProv
        '
        Me.dgvModProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModProv.Location = New System.Drawing.Point(78, 113)
        Me.dgvModProv.Name = "dgvModProv"
        Me.dgvModProv.Size = New System.Drawing.Size(704, 263)
        Me.dgvModProv.TabIndex = 21
        '
        'txtPaisProv
        '
        Me.txtPaisProv.Location = New System.Drawing.Point(604, 434)
        Me.txtPaisProv.Name = "txtPaisProv"
        Me.txtPaisProv.Size = New System.Drawing.Size(178, 20)
        Me.txtPaisProv.TabIndex = 23
        '
        'txtNomProv
        '
        Me.txtNomProv.Location = New System.Drawing.Point(120, 420)
        Me.txtNomProv.Name = "txtNomProv"
        Me.txtNomProv.Size = New System.Drawing.Size(178, 20)
        Me.txtNomProv.TabIndex = 24
        '
        'txtDniProv
        '
        Me.txtDniProv.Location = New System.Drawing.Point(362, 408)
        Me.txtDniProv.Name = "txtDniProv"
        Me.txtDniProv.Size = New System.Drawing.Size(178, 20)
        Me.txtDniProv.TabIndex = 26
        '
        'txtDirProv
        '
        Me.txtDirProv.Location = New System.Drawing.Point(362, 434)
        Me.txtDirProv.Name = "txtDirProv"
        Me.txtDirProv.Size = New System.Drawing.Size(178, 20)
        Me.txtDirProv.TabIndex = 27
        '
        'txtTelProv
        '
        Me.txtTelProv.Location = New System.Drawing.Point(604, 408)
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(178, 20)
        Me.txtTelProv.TabIndex = 28
        '
        'lblNomProv
        '
        Me.lblNomProv.AutoSize = True
        Me.lblNomProv.Location = New System.Drawing.Point(67, 423)
        Me.lblNomProv.Name = "lblNomProv"
        Me.lblNomProv.Size = New System.Drawing.Size(47, 13)
        Me.lblNomProv.TabIndex = 29
        Me.lblNomProv.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(566, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "País:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "CUIT:"
        '
        'btnModProv
        '
        Me.btnModProv.Location = New System.Drawing.Point(333, 478)
        Me.btnModProv.Name = "btnModProv"
        Me.btnModProv.Size = New System.Drawing.Size(248, 37)
        Me.btnModProv.TabIndex = 35
        Me.btnModProv.Text = "MODIFICAR"
        Me.btnModProv.UseVisualStyleBackColor = True
        '
        'btnVolverMProv
        '
        Me.btnVolverMProv.Location = New System.Drawing.Point(705, 513)
        Me.btnVolverMProv.Name = "btnVolverMProv"
        Me.btnVolverMProv.Size = New System.Drawing.Size(77, 33)
        Me.btnVolverMProv.TabIndex = 36
        Me.btnVolverMProv.Text = "VOLVER"
        Me.btnVolverMProv.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(219, 83)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 42
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(74, 82)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 41
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmModProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 558)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnVolverMProv)
        Me.Controls.Add(Me.btnModProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNomProv)
        Me.Controls.Add(Me.txtTelProv)
        Me.Controls.Add(Me.txtDirProv)
        Me.Controls.Add(Me.txtDniProv)
        Me.Controls.Add(Me.txtNomProv)
        Me.Controls.Add(Me.txtPaisProv)
        Me.Controls.Add(Me.dgvModProv)
        Me.Controls.Add(Me.lblModProv)
        Me.Name = "frmModProv"
        Me.Text = "Modificar Proveedor"
        CType(Me.dgvModProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModProv As System.Windows.Forms.Label
    Friend WithEvents dgvModProv As System.Windows.Forms.DataGridView
    Friend WithEvents txtPaisProv As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProv As System.Windows.Forms.TextBox
    Friend WithEvents txtDniProv As System.Windows.Forms.TextBox
    Friend WithEvents txtDirProv As System.Windows.Forms.TextBox
    Friend WithEvents txtTelProv As System.Windows.Forms.TextBox
    Friend WithEvents lblNomProv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnModProv As System.Windows.Forms.Button
    Friend WithEvents btnVolverMProv As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
