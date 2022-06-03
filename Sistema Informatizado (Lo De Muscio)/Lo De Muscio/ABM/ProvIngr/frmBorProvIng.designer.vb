<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorProvIng
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusProv = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.dgvProvBorPI = New System.Windows.Forms.DataGridView()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusIng = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvIngBorPI = New System.Windows.Forms.DataGridView()
        CType(Me.dgvProvBorPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIngBorPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(442, 33)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Borrar Ingrediente del Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 26)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Proveedores"
        '
        'txtBusProv
        '
        Me.txtBusProv.Location = New System.Drawing.Point(188, 88)
        Me.txtBusProv.Name = "txtBusProv"
        Me.txtBusProv.Size = New System.Drawing.Size(246, 20)
        Me.txtBusProv.TabIndex = 79
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(39, 87)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(143, 19)
        Me.lblModEmp.TabIndex = 78
        Me.lblModEmp.Text = "Buscar por Nombre:"
        '
        'dgvProvBorPI
        '
        Me.dgvProvBorPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProvBorPI.Location = New System.Drawing.Point(43, 118)
        Me.dgvProvBorPI.Name = "dgvProvBorPI"
        Me.dgvProvBorPI.Size = New System.Drawing.Size(471, 192)
        Me.dgvProvBorPI.TabIndex = 77
        '
        'btnCargar
        '
        Me.btnCargar.Enabled = False
        Me.btnCargar.Location = New System.Drawing.Point(384, 344)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(265, 46)
        Me.btnCargar.TabIndex = 88
        Me.btnCargar.Text = "BORRAR"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(826, 390)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 31)
        Me.btnVolver.TabIndex = 87
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(534, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 26)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Ingredientes"
        '
        'txtBusIng
        '
        Me.txtBusIng.Enabled = False
        Me.txtBusIng.Location = New System.Drawing.Point(684, 88)
        Me.txtBusIng.Name = "txtBusIng"
        Me.txtBusIng.Size = New System.Drawing.Size(246, 20)
        Me.txtBusIng.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(535, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Buscar por Nombre:"
        '
        'dgvIngBorPI
        '
        Me.dgvIngBorPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngBorPI.Enabled = False
        Me.dgvIngBorPI.Location = New System.Drawing.Point(539, 118)
        Me.dgvIngBorPI.Name = "dgvIngBorPI"
        Me.dgvIngBorPI.Size = New System.Drawing.Size(420, 192)
        Me.dgvIngBorPI.TabIndex = 83
        '
        'frmBorProvIng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 433)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBusIng)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvIngBorPI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBusProv)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.dgvProvBorPI)
        Me.Name = "frmBorProvIng"
        Me.Text = "Borrar Ingrediente-Proveedor"
        CType(Me.dgvProvBorPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIngBorPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBusProv As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents dgvProvBorPI As System.Windows.Forms.DataGridView
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBusIng As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvIngBorPI As System.Windows.Forms.DataGridView
End Class
