<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorProvP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusProd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProdBorPP = New System.Windows.Forms.DataGridView()
        Me.txtBusProv = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.lblCarProdProv = New System.Windows.Forms.Label()
        Me.dgvProvBorPP = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvProdBorPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProvBorPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 26)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Proveedores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(492, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 26)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Productos"
        '
        'txtBusProd
        '
        Me.txtBusProd.Enabled = False
        Me.txtBusProd.Location = New System.Drawing.Point(641, 107)
        Me.txtBusProd.Name = "txtBusProd"
        Me.txtBusProd.Size = New System.Drawing.Size(246, 20)
        Me.txtBusProd.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(492, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Buscar por Nombre:"
        '
        'dgvProdBorPP
        '
        Me.dgvProdBorPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdBorPP.Enabled = False
        Me.dgvProdBorPP.Location = New System.Drawing.Point(496, 143)
        Me.dgvProdBorPP.Name = "dgvProdBorPP"
        Me.dgvProdBorPP.Size = New System.Drawing.Size(420, 192)
        Me.dgvProdBorPP.TabIndex = 71
        '
        'txtBusProv
        '
        Me.txtBusProv.Location = New System.Drawing.Point(189, 108)
        Me.txtBusProv.Name = "txtBusProv"
        Me.txtBusProv.Size = New System.Drawing.Size(246, 20)
        Me.txtBusProv.TabIndex = 69
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(40, 107)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(143, 19)
        Me.lblModEmp.TabIndex = 68
        Me.lblModEmp.Text = "Buscar por Nombre:"
        '
        'lblCarProdProv
        '
        Me.lblCarProdProv.AutoSize = True
        Me.lblCarProdProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarProdProv.Location = New System.Drawing.Point(85, -36)
        Me.lblCarProdProv.Name = "lblCarProdProv"
        Me.lblCarProdProv.Size = New System.Drawing.Size(408, 33)
        Me.lblCarProdProv.TabIndex = 67
        Me.lblCarProdProv.Text = "Cargar Producto del Proveedor"
        '
        'dgvProvBorPP
        '
        Me.dgvProvBorPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProvBorPP.Location = New System.Drawing.Point(45, 143)
        Me.dgvProvBorPP.Name = "dgvProvBorPP"
        Me.dgvProvBorPP.Size = New System.Drawing.Size(420, 192)
        Me.dgvProvBorPP.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(407, 33)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Borrar Producto del Proveedor"
        '
        'btnBorrar
        '
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Location = New System.Drawing.Point(340, 371)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(266, 55)
        Me.btnBorrar.TabIndex = 78
        Me.btnBorrar.Text = "BORRAR"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(735, 431)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(97, 34)
        Me.btnVolver.TabIndex = 77
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmBorProvP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 486)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBusProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProdBorPP)
        Me.Controls.Add(Me.txtBusProv)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.lblCarProdProv)
        Me.Controls.Add(Me.dgvProvBorPP)
        Me.Name = "frmBorProvP"
        Me.Text = "Borrar Producto-Proveedor"
        CType(Me.dgvProdBorPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProvBorPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBusProd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvProdBorPP As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusProv As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents lblCarProdProv As System.Windows.Forms.Label
    Friend WithEvents dgvProvBorPP As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
