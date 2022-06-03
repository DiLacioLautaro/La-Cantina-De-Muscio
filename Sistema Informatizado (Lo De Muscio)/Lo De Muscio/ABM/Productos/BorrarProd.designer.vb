<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarProd
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
        Me.lblModProd = New System.Windows.Forms.Label()
        Me.dgvBorrarProd = New System.Windows.Forms.DataGridView()
        Me.btnBorrarProd = New System.Windows.Forms.Button()
        Me.btnVolverBProd = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvBorrarProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblModProd
        '
        Me.lblModProd.AutoSize = True
        Me.lblModProd.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModProd.Location = New System.Drawing.Point(22, 33)
        Me.lblModProd.Name = "lblModProd"
        Me.lblModProd.Size = New System.Drawing.Size(223, 33)
        Me.lblModProd.TabIndex = 24
        Me.lblModProd.Text = "Borrar Producto"
        '
        'dgvBorrarProd
        '
        Me.dgvBorrarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrarProd.Location = New System.Drawing.Point(28, 129)
        Me.dgvBorrarProd.Name = "dgvBorrarProd"
        Me.dgvBorrarProd.Size = New System.Drawing.Size(531, 248)
        Me.dgvBorrarProd.TabIndex = 25
        '
        'btnBorrarProd
        '
        Me.btnBorrarProd.Location = New System.Drawing.Point(196, 396)
        Me.btnBorrarProd.Name = "btnBorrarProd"
        Me.btnBorrarProd.Size = New System.Drawing.Size(188, 37)
        Me.btnBorrarProd.TabIndex = 37
        Me.btnBorrarProd.Text = "BORRAR"
        Me.btnBorrarProd.UseVisualStyleBackColor = True
        '
        'btnVolverBProd
        '
        Me.btnVolverBProd.Location = New System.Drawing.Point(486, 437)
        Me.btnVolverBProd.Name = "btnVolverBProd"
        Me.btnVolverBProd.Size = New System.Drawing.Size(73, 27)
        Me.btnVolverBProd.TabIndex = 38
        Me.btnVolverBProd.Text = "VOLVER"
        Me.btnVolverBProd.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(169, 86)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(297, 20)
        Me.txtBuscar.TabIndex = 40
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(24, 85)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 39
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmBorrarProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(586, 476)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnVolverBProd)
        Me.Controls.Add(Me.btnBorrarProd)
        Me.Controls.Add(Me.dgvBorrarProd)
        Me.Controls.Add(Me.lblModProd)
        Me.Name = "frmBorrarProd"
        Me.Text = "Borrar Producto"
        CType(Me.dgvBorrarProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModProd As System.Windows.Forms.Label
    Friend WithEvents dgvBorrarProd As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrarProd As System.Windows.Forms.Button
    Friend WithEvents btnVolverBProd As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
