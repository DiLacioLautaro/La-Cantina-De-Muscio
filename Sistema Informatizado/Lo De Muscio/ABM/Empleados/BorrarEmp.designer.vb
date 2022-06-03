<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarEmp
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
        Me.btnVolverBEmp = New System.Windows.Forms.Button()
        Me.lblBorrarEmp = New System.Windows.Forms.Label()
        Me.dgvBorrarEmp = New System.Windows.Forms.DataGridView()
        Me.btnBorrarEmp = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvBorrarEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverBEmp
        '
        Me.btnVolverBEmp.Location = New System.Drawing.Point(565, 387)
        Me.btnVolverBEmp.Name = "btnVolverBEmp"
        Me.btnVolverBEmp.Size = New System.Drawing.Size(71, 29)
        Me.btnVolverBEmp.TabIndex = 17
        Me.btnVolverBEmp.Text = "VOLVER"
        Me.btnVolverBEmp.UseVisualStyleBackColor = True
        '
        'lblBorrarEmp
        '
        Me.lblBorrarEmp.AutoSize = True
        Me.lblBorrarEmp.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrarEmp.Location = New System.Drawing.Point(226, 19)
        Me.lblBorrarEmp.Name = "lblBorrarEmp"
        Me.lblBorrarEmp.Size = New System.Drawing.Size(203, 33)
        Me.lblBorrarEmp.TabIndex = 20
        Me.lblBorrarEmp.Text = "Baja Empleado"
        '
        'dgvBorrarEmp
        '
        Me.dgvBorrarEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrarEmp.Location = New System.Drawing.Point(23, 103)
        Me.dgvBorrarEmp.Name = "dgvBorrarEmp"
        Me.dgvBorrarEmp.Size = New System.Drawing.Size(613, 228)
        Me.dgvBorrarEmp.TabIndex = 21
        '
        'btnBorrarEmp
        '
        Me.btnBorrarEmp.Location = New System.Drawing.Point(184, 347)
        Me.btnBorrarEmp.Name = "btnBorrarEmp"
        Me.btnBorrarEmp.Size = New System.Drawing.Size(303, 52)
        Me.btnBorrarEmp.TabIndex = 22
        Me.btnBorrarEmp.Text = "BORRAR"
        Me.btnBorrarEmp.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(164, 69)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 34
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(19, 68)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 33
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmBorrarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(661, 428)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnBorrarEmp)
        Me.Controls.Add(Me.dgvBorrarEmp)
        Me.Controls.Add(Me.lblBorrarEmp)
        Me.Controls.Add(Me.btnVolverBEmp)
        Me.Name = "frmBorrarEmp"
        Me.Text = "Borrar Empleado"
        CType(Me.dgvBorrarEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolverBEmp As System.Windows.Forms.Button
    Friend WithEvents lblBorrarEmp As System.Windows.Forms.Label
    Friend WithEvents dgvBorrarEmp As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrarEmp As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
