<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarProvP
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtBusProv = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.lblCarProdProv = New System.Windows.Forms.Label()
        Me.dgvProvCarPP = New System.Windows.Forms.DataGridView()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtBusProd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProductosCarPP = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolver1 = New System.Windows.Forms.Button()
        CType(Me.dgvProvCarPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductosCarPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(562, 775)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 31)
        Me.btnVolver.TabIndex = 58
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtBusProv
        '
        Me.txtBusProv.Location = New System.Drawing.Point(185, 122)
        Me.txtBusProv.Name = "txtBusProv"
        Me.txtBusProv.Size = New System.Drawing.Size(246, 20)
        Me.txtBusProv.TabIndex = 56
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(40, 121)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 55
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'lblCarProdProv
        '
        Me.lblCarProdProv.AutoSize = True
        Me.lblCarProdProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarProdProv.Location = New System.Drawing.Point(38, 30)
        Me.lblCarProdProv.Name = "lblCarProdProv"
        Me.lblCarProdProv.Size = New System.Drawing.Size(408, 33)
        Me.lblCarProdProv.TabIndex = 54
        Me.lblCarProdProv.Text = "Cargar Producto del Proveedor"
        '
        'dgvProvCarPP
        '
        Me.dgvProvCarPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProvCarPP.Location = New System.Drawing.Point(45, 157)
        Me.dgvProvCarPP.Name = "dgvProvCarPP"
        Me.dgvProvCarPP.Size = New System.Drawing.Size(473, 192)
        Me.dgvProvCarPP.TabIndex = 53
        '
        'btnCargar
        '
        Me.btnCargar.Enabled = False
        Me.btnCargar.Location = New System.Drawing.Point(388, 381)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(321, 55)
        Me.btnCargar.TabIndex = 62
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtBusProd
        '
        Me.txtBusProd.Enabled = False
        Me.txtBusProd.Location = New System.Drawing.Point(708, 121)
        Me.txtBusProd.Name = "txtBusProd"
        Me.txtBusProd.Size = New System.Drawing.Size(246, 20)
        Me.txtBusProd.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Buscar por Nombre"
        '
        'dgvProductosCarPP
        '
        Me.dgvProductosCarPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosCarPP.Enabled = False
        Me.dgvProductosCarPP.Location = New System.Drawing.Point(567, 157)
        Me.dgvProductosCarPP.Name = "dgvProductosCarPP"
        Me.dgvProductosCarPP.Size = New System.Drawing.Size(420, 192)
        Me.dgvProductosCarPP.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(563, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 26)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Productos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 26)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Proveedores"
        '
        'btnVolver1
        '
        Me.btnVolver1.Location = New System.Drawing.Point(769, 433)
        Me.btnVolver1.Name = "btnVolver1"
        Me.btnVolver1.Size = New System.Drawing.Size(122, 40)
        Me.btnVolver1.TabIndex = 66
        Me.btnVolver1.Text = "VOLVER"
        Me.btnVolver1.UseVisualStyleBackColor = True
        '
        'frmCarProvP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 492)
        Me.Controls.Add(Me.btnVolver1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtBusProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductosCarPP)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtBusProv)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.lblCarProdProv)
        Me.Controls.Add(Me.dgvProvCarPP)
        Me.Name = "frmCarProvP"
        Me.Text = "Cargar Producto-Proveedor"
        CType(Me.dgvProvCarPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductosCarPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtBusProv As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents lblCarProdProv As System.Windows.Forms.Label
    Friend WithEvents dgvProvCarPP As System.Windows.Forms.DataGridView
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents txtBusProd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvProductosCarPP As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnVolver1 As System.Windows.Forms.Button
End Class
