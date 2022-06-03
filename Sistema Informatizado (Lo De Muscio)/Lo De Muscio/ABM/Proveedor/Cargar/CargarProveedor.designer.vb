<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarProveedor
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
        Me.lblNomProv = New System.Windows.Forms.Label()
        Me.lblCargarProv = New System.Windows.Forms.Label()
        Me.btnVolverCProveedor = New System.Windows.Forms.Button()
        Me.txtNomProv = New System.Windows.Forms.TextBox()
        Me.lblDniProv = New System.Windows.Forms.Label()
        Me.txtDNIProv = New System.Windows.Forms.TextBox()
        Me.lblTelProv = New System.Windows.Forms.Label()
        Me.txtTelProv = New System.Windows.Forms.TextBox()
        Me.lblDirProv = New System.Windows.Forms.Label()
        Me.txtDirProv = New System.Windows.Forms.TextBox()
        Me.lblPaisProv = New System.Windows.Forms.Label()
        Me.txtPaisProv = New System.Windows.Forms.TextBox()
        Me.btnCargarProv = New System.Windows.Forms.Button()
        Me.dgvIng = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarIng = New System.Windows.Forms.TextBox()
        Me.txtBuscarProd = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.lblCarProdProv = New System.Windows.Forms.Label()
        Me.dgvProd = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvIng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNomProv
        '
        Me.lblNomProv.AutoSize = True
        Me.lblNomProv.Location = New System.Drawing.Point(23, 26)
        Me.lblNomProv.Name = "lblNomProv"
        Me.lblNomProv.Size = New System.Drawing.Size(47, 13)
        Me.lblNomProv.TabIndex = 7
        Me.lblNomProv.Text = "Nombre:"
        '
        'lblCargarProv
        '
        Me.lblCargarProv.AutoSize = True
        Me.lblCargarProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarProv.Location = New System.Drawing.Point(385, 9)
        Me.lblCargarProv.Name = "lblCargarProv"
        Me.lblCargarProv.Size = New System.Drawing.Size(238, 33)
        Me.lblCargarProv.TabIndex = 13
        Me.lblCargarProv.Text = "Cargar Proveedor"
        '
        'btnVolverCProveedor
        '
        Me.btnVolverCProveedor.Location = New System.Drawing.Point(356, 581)
        Me.btnVolverCProveedor.Name = "btnVolverCProveedor"
        Me.btnVolverCProveedor.Size = New System.Drawing.Size(369, 42)
        Me.btnVolverCProveedor.TabIndex = 14
        Me.btnVolverCProveedor.Text = "VOLVER / FINALIZAR"
        Me.btnVolverCProveedor.UseVisualStyleBackColor = True
        '
        'txtNomProv
        '
        Me.txtNomProv.Location = New System.Drawing.Point(76, 23)
        Me.txtNomProv.Name = "txtNomProv"
        Me.txtNomProv.Size = New System.Drawing.Size(178, 20)
        Me.txtNomProv.TabIndex = 15
        '
        'lblDniProv
        '
        Me.lblDniProv.AutoSize = True
        Me.lblDniProv.Location = New System.Drawing.Point(375, 22)
        Me.lblDniProv.Name = "lblDniProv"
        Me.lblDniProv.Size = New System.Drawing.Size(35, 13)
        Me.lblDniProv.TabIndex = 18
        Me.lblDniProv.Text = "CUIT:"
        '
        'txtDNIProv
        '
        Me.txtDNIProv.Location = New System.Drawing.Point(410, 19)
        Me.txtDNIProv.Name = "txtDNIProv"
        Me.txtDNIProv.Size = New System.Drawing.Size(178, 20)
        Me.txtDNIProv.TabIndex = 19
        '
        'lblTelProv
        '
        Me.lblTelProv.AutoSize = True
        Me.lblTelProv.Location = New System.Drawing.Point(18, 68)
        Me.lblTelProv.Name = "lblTelProv"
        Me.lblTelProv.Size = New System.Drawing.Size(52, 13)
        Me.lblTelProv.TabIndex = 20
        Me.lblTelProv.Text = "Telefono:"
        '
        'txtTelProv
        '
        Me.txtTelProv.Location = New System.Drawing.Point(76, 65)
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(178, 20)
        Me.txtTelProv.TabIndex = 21
        '
        'lblDirProv
        '
        Me.lblDirProv.AutoSize = True
        Me.lblDirProv.Location = New System.Drawing.Point(614, 40)
        Me.lblDirProv.Name = "lblDirProv"
        Me.lblDirProv.Size = New System.Drawing.Size(55, 13)
        Me.lblDirProv.TabIndex = 22
        Me.lblDirProv.Text = "Dirección:"
        '
        'txtDirProv
        '
        Me.txtDirProv.Location = New System.Drawing.Point(675, 37)
        Me.txtDirProv.Name = "txtDirProv"
        Me.txtDirProv.Size = New System.Drawing.Size(178, 20)
        Me.txtDirProv.TabIndex = 23
        '
        'lblPaisProv
        '
        Me.lblPaisProv.AutoSize = True
        Me.lblPaisProv.Location = New System.Drawing.Point(372, 64)
        Me.lblPaisProv.Name = "lblPaisProv"
        Me.lblPaisProv.Size = New System.Drawing.Size(32, 13)
        Me.lblPaisProv.TabIndex = 24
        Me.lblPaisProv.Text = "País:"
        '
        'txtPaisProv
        '
        Me.txtPaisProv.Location = New System.Drawing.Point(410, 61)
        Me.txtPaisProv.Name = "txtPaisProv"
        Me.txtPaisProv.Size = New System.Drawing.Size(178, 20)
        Me.txtPaisProv.TabIndex = 25
        '
        'btnCargarProv
        '
        Me.btnCargarProv.Location = New System.Drawing.Point(356, 173)
        Me.btnCargarProv.Name = "btnCargarProv"
        Me.btnCargarProv.Size = New System.Drawing.Size(315, 49)
        Me.btnCargarProv.TabIndex = 26
        Me.btnCargarProv.Text = "CARGAR PROVEEDOR"
        Me.btnCargarProv.UseVisualStyleBackColor = True
        '
        'dgvIng
        '
        Me.dgvIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIng.Location = New System.Drawing.Point(35, 96)
        Me.dgvIng.Name = "dgvIng"
        Me.dgvIng.Size = New System.Drawing.Size(420, 224)
        Me.dgvIng.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Cargar Ingrediente del Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Buscar por Nombre"
        '
        'txtBuscarIng
        '
        Me.txtBuscarIng.Enabled = False
        Me.txtBuscarIng.Location = New System.Drawing.Point(181, 67)
        Me.txtBuscarIng.Name = "txtBuscarIng"
        Me.txtBuscarIng.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarIng.TabIndex = 44
        '
        'txtBuscarProd
        '
        Me.txtBuscarProd.Enabled = False
        Me.txtBuscarProd.Location = New System.Drawing.Point(184, 68)
        Me.txtBuscarProd.Name = "txtBuscarProd"
        Me.txtBuscarProd.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarProd.TabIndex = 54
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(39, 67)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 53
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'lblCarProdProv
        '
        Me.lblCarProdProv.AutoSize = True
        Me.lblCarProdProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarProdProv.Location = New System.Drawing.Point(15, 16)
        Me.lblCarProdProv.Name = "lblCarProdProv"
        Me.lblCarProdProv.Size = New System.Drawing.Size(408, 33)
        Me.lblCarProdProv.TabIndex = 52
        Me.lblCarProdProv.Text = "Cargar Producto del Proveedor"
        '
        'dgvProd
        '
        Me.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProd.Location = New System.Drawing.Point(21, 94)
        Me.dgvProd.Name = "dgvProd"
        Me.dgvProd.Size = New System.Drawing.Size(420, 224)
        Me.dgvProd.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBuscarProd)
        Me.GroupBox1.Controls.Add(Me.lblModEmp)
        Me.GroupBox1.Controls.Add(Me.lblCarProdProv)
        Me.GroupBox1.Controls.Add(Me.dgvProd)
        Me.GroupBox1.Location = New System.Drawing.Point(525, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 338)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBuscarIng)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgvIng)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 337)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPaisProv)
        Me.GroupBox3.Controls.Add(Me.lblPaisProv)
        Me.GroupBox3.Controls.Add(Me.txtDirProv)
        Me.GroupBox3.Controls.Add(Me.lblDirProv)
        Me.GroupBox3.Controls.Add(Me.txtTelProv)
        Me.GroupBox3.Controls.Add(Me.lblTelProv)
        Me.GroupBox3.Controls.Add(Me.txtDNIProv)
        Me.GroupBox3.Controls.Add(Me.lblDniProv)
        Me.GroupBox3.Controls.Add(Me.txtNomProv)
        Me.GroupBox3.Controls.Add(Me.lblNomProv)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(901, 104)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        '
        'frmCargarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 635)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCargarProv)
        Me.Controls.Add(Me.btnVolverCProveedor)
        Me.Controls.Add(Me.lblCargarProv)
        Me.Name = "frmCargarProveedor"
        Me.Text = " CARGAR PROVEEDOR"
        CType(Me.dgvIng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNomProv As System.Windows.Forms.Label
    Friend WithEvents lblCargarProv As System.Windows.Forms.Label
    Friend WithEvents btnVolverCProveedor As System.Windows.Forms.Button
    Friend WithEvents txtNomProv As System.Windows.Forms.TextBox
    Friend WithEvents lblDniProv As System.Windows.Forms.Label
    Friend WithEvents txtDNIProv As System.Windows.Forms.TextBox
    Friend WithEvents lblTelProv As System.Windows.Forms.Label
    Friend WithEvents txtTelProv As System.Windows.Forms.TextBox
    Friend WithEvents lblDirProv As System.Windows.Forms.Label
    Friend WithEvents txtDirProv As System.Windows.Forms.TextBox
    Friend WithEvents lblPaisProv As System.Windows.Forms.Label
    Friend WithEvents txtPaisProv As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarProv As System.Windows.Forms.Button
    Friend WithEvents dgvIng As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarIng As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscarProd As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents lblCarProdProv As System.Windows.Forms.Label
    Friend WithEvents dgvProd As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
