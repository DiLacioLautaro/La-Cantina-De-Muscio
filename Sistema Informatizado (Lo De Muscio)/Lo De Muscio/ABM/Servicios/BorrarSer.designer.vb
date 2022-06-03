<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarSer
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
        Me.dgvBorrarSer = New System.Windows.Forms.DataGridView()
        Me.lblBorrarSer = New System.Windows.Forms.Label()
        Me.btnBorrarProv = New System.Windows.Forms.Button()
        Me.btnVolverBSer = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvBorrarSer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBorrarSer
        '
        Me.dgvBorrarSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrarSer.Location = New System.Drawing.Point(55, 124)
        Me.dgvBorrarSer.Name = "dgvBorrarSer"
        Me.dgvBorrarSer.Size = New System.Drawing.Size(344, 192)
        Me.dgvBorrarSer.TabIndex = 26
        '
        'lblBorrarSer
        '
        Me.lblBorrarSer.AutoSize = True
        Me.lblBorrarSer.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrarSer.Location = New System.Drawing.Point(134, 36)
        Me.lblBorrarSer.Name = "lblBorrarSer"
        Me.lblBorrarSer.Size = New System.Drawing.Size(207, 33)
        Me.lblBorrarSer.TabIndex = 27
        Me.lblBorrarSer.Text = "Borrar Servicio"
        '
        'btnBorrarProv
        '
        Me.btnBorrarProv.Location = New System.Drawing.Point(155, 337)
        Me.btnBorrarProv.Name = "btnBorrarProv"
        Me.btnBorrarProv.Size = New System.Drawing.Size(149, 37)
        Me.btnBorrarProv.TabIndex = 28
        Me.btnBorrarProv.Text = "BORRAR"
        Me.btnBorrarProv.UseVisualStyleBackColor = True
        '
        'btnVolverBSer
        '
        Me.btnVolverBSer.Location = New System.Drawing.Point(384, 386)
        Me.btnVolverBSer.Name = "btnVolverBSer"
        Me.btnVolverBSer.Size = New System.Drawing.Size(76, 26)
        Me.btnVolverBSer.TabIndex = 29
        Me.btnVolverBSer.Text = "VOLVER"
        Me.btnVolverBSer.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(176, 89)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 59
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(31, 88)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 58
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmBorrarSer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 422)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnVolverBSer)
        Me.Controls.Add(Me.btnBorrarProv)
        Me.Controls.Add(Me.lblBorrarSer)
        Me.Controls.Add(Me.dgvBorrarSer)
        Me.Name = "frmBorrarSer"
        Me.Text = "Borrar Servicio"
        CType(Me.dgvBorrarSer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBorrarSer As System.Windows.Forms.DataGridView
    Friend WithEvents lblBorrarSer As System.Windows.Forms.Label
    Friend WithEvents btnBorrarProv As System.Windows.Forms.Button
    Friend WithEvents btnVolverBSer As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
