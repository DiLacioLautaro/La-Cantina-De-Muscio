<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajaProv
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
        Me.btnBajaProv = New System.Windows.Forms.Button()
        Me.dgvBajaProv = New System.Windows.Forms.DataGridView()
        Me.lblBajaProv = New System.Windows.Forms.Label()
        Me.btnVolverBProv = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvBajaProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBajaProv
        '
        Me.btnBajaProv.Location = New System.Drawing.Point(282, 362)
        Me.btnBajaProv.Name = "btnBajaProv"
        Me.btnBajaProv.Size = New System.Drawing.Size(189, 38)
        Me.btnBajaProv.TabIndex = 26
        Me.btnBajaProv.Text = "BORRAR"
        Me.btnBajaProv.UseVisualStyleBackColor = True
        '
        'dgvBajaProv
        '
        Me.dgvBajaProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBajaProv.Location = New System.Drawing.Point(50, 100)
        Me.dgvBajaProv.Name = "dgvBajaProv"
        Me.dgvBajaProv.Size = New System.Drawing.Size(638, 239)
        Me.dgvBajaProv.TabIndex = 25
        '
        'lblBajaProv
        '
        Me.lblBajaProv.AutoSize = True
        Me.lblBajaProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBajaProv.Location = New System.Drawing.Point(230, 20)
        Me.lblBajaProv.Name = "lblBajaProv"
        Me.lblBajaProv.Size = New System.Drawing.Size(207, 33)
        Me.lblBajaProv.TabIndex = 24
        Me.lblBajaProv.Text = "Baja Proveedor"
        '
        'btnVolverBProv
        '
        Me.btnVolverBProv.Location = New System.Drawing.Point(631, 390)
        Me.btnVolverBProv.Name = "btnVolverBProv"
        Me.btnVolverBProv.Size = New System.Drawing.Size(72, 29)
        Me.btnVolverBProv.TabIndex = 23
        Me.btnVolverBProv.Text = "VOLVER"
        Me.btnVolverBProv.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(191, 70)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 44
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(46, 69)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 43
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmBajaProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(729, 431)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnBajaProv)
        Me.Controls.Add(Me.dgvBajaProv)
        Me.Controls.Add(Me.lblBajaProv)
        Me.Controls.Add(Me.btnVolverBProv)
        Me.Name = "frmBajaProv"
        Me.Text = "Baja Proveedor"
        CType(Me.dgvBajaProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBajaProv As System.Windows.Forms.Button
    Friend WithEvents dgvBajaProv As System.Windows.Forms.DataGridView
    Friend WithEvents lblBajaProv As System.Windows.Forms.Label
    Friend WithEvents btnVolverBProv As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
