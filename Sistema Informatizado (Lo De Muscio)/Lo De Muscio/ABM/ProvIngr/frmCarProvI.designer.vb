<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarProvI
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusProv = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.lblCarIngProv = New System.Windows.Forms.Label()
        Me.dgvProvCarPI = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtBusIng = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvIngCarPI = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtBusProd = New System.Windows.Forms.TextBox()
        CType(Me.dgvProvCarPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIngCarPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 26)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Proveedores"
        '
        'txtBusProv
        '
        Me.txtBusProv.Location = New System.Drawing.Point(176, 122)
        Me.txtBusProv.Name = "txtBusProv"
        Me.txtBusProv.Size = New System.Drawing.Size(246, 20)
        Me.txtBusProv.TabIndex = 69
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(31, 121)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 68
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'lblCarIngProv
        '
        Me.lblCarIngProv.AutoSize = True
        Me.lblCarIngProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarIngProv.Location = New System.Drawing.Point(30, 29)
        Me.lblCarIngProv.Name = "lblCarIngProv"
        Me.lblCarIngProv.Size = New System.Drawing.Size(443, 33)
        Me.lblCarIngProv.TabIndex = 67
        Me.lblCarIngProv.Text = "Cargar Ingrediente del Proveedor"
        '
        'dgvProvCarPI
        '
        Me.dgvProvCarPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProvCarPI.Location = New System.Drawing.Point(36, 157)
        Me.dgvProvCarPI.Name = "dgvProvCarPI"
        Me.dgvProvCarPI.Size = New System.Drawing.Size(420, 192)
        Me.dgvProvCarPI.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 26)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Ingredientes"
        '
        'btnCargar
        '
        Me.btnCargar.Enabled = False
        Me.btnCargar.Location = New System.Drawing.Point(340, 385)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(293, 55)
        Me.btnCargar.TabIndex = 76
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtBusIng
        '
        Me.txtBusIng.Enabled = False
        Me.txtBusIng.Location = New System.Drawing.Point(642, 121)
        Me.txtBusIng.Name = "txtBusIng"
        Me.txtBusIng.Size = New System.Drawing.Size(246, 20)
        Me.txtBusIng.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(497, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Buscar por Nombre"
        '
        'dgvIngCarPI
        '
        Me.dgvIngCarPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngCarPI.Enabled = False
        Me.dgvIngCarPI.Location = New System.Drawing.Point(501, 157)
        Me.dgvIngCarPI.Name = "dgvIngCarPI"
        Me.dgvIngCarPI.Size = New System.Drawing.Size(420, 192)
        Me.dgvIngCarPI.TabIndex = 73
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(783, 429)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 31)
        Me.btnVolver.TabIndex = 72
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtBusProd
        '
        Me.txtBusProd.Enabled = False
        Me.txtBusProd.Location = New System.Drawing.Point(292, 438)
        Me.txtBusProd.Name = "txtBusProd"
        Me.txtBusProd.Size = New System.Drawing.Size(246, 20)
        Me.txtBusProd.TabIndex = 75
        '
        'frmCarProvI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(966, 476)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtBusIng)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvIngCarPI)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBusProv)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.lblCarIngProv)
        Me.Controls.Add(Me.dgvProvCarPI)
        Me.Name = "frmCarProvI"
        Me.Text = "Cargar Ingrediente-Proveedor"
        CType(Me.dgvProvCarPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIngCarPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBusProv As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents lblCarIngProv As System.Windows.Forms.Label
    Friend WithEvents dgvProvCarPI As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents txtBusIng As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvIngCarPI As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtBusProd As System.Windows.Forms.TextBox
End Class
