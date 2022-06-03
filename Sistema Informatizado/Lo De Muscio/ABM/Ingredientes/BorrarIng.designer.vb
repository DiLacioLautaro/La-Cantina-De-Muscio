<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarInG
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
        Me.btnVolverBIng = New System.Windows.Forms.Button()
        Me.dgvBorrarIng = New System.Windows.Forms.DataGridView()
        Me.lblBorrarIngred = New System.Windows.Forms.Label()
        Me.btnBorrarIng = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvBorrarIng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverBIng
        '
        Me.btnVolverBIng.Location = New System.Drawing.Point(416, 407)
        Me.btnVolverBIng.Name = "btnVolverBIng"
        Me.btnVolverBIng.Size = New System.Drawing.Size(71, 31)
        Me.btnVolverBIng.TabIndex = 33
        Me.btnVolverBIng.Text = "VOLVER"
        Me.btnVolverBIng.UseVisualStyleBackColor = True
        '
        'dgvBorrarIng
        '
        Me.dgvBorrarIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrarIng.Location = New System.Drawing.Point(27, 113)
        Me.dgvBorrarIng.Name = "dgvBorrarIng"
        Me.dgvBorrarIng.Size = New System.Drawing.Size(442, 237)
        Me.dgvBorrarIng.TabIndex = 34
        '
        'lblBorrarIngred
        '
        Me.lblBorrarIngred.AutoSize = True
        Me.lblBorrarIngred.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrarIngred.Location = New System.Drawing.Point(130, 21)
        Me.lblBorrarIngred.Name = "lblBorrarIngred"
        Me.lblBorrarIngred.Size = New System.Drawing.Size(258, 33)
        Me.lblBorrarIngred.TabIndex = 35
        Me.lblBorrarIngred.Text = "Borrar Ingrediente"
        '
        'btnBorrarIng
        '
        Me.btnBorrarIng.Location = New System.Drawing.Point(154, 373)
        Me.btnBorrarIng.Name = "btnBorrarIng"
        Me.btnBorrarIng.Size = New System.Drawing.Size(205, 45)
        Me.btnBorrarIng.TabIndex = 36
        Me.btnBorrarIng.Text = "BORRAR"
        Me.btnBorrarIng.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(201, 72)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 38
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(56, 71)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 37
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmBorrarInG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(499, 450)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnBorrarIng)
        Me.Controls.Add(Me.lblBorrarIngred)
        Me.Controls.Add(Me.dgvBorrarIng)
        Me.Controls.Add(Me.btnVolverBIng)
        Me.Name = "frmBorrarInG"
        Me.Text = "Borrar Ingrediente"
        CType(Me.dgvBorrarIng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolverBIng As System.Windows.Forms.Button
    Friend WithEvents dgvBorrarIng As System.Windows.Forms.DataGridView
    Friend WithEvents lblBorrarIngred As System.Windows.Forms.Label
    Friend WithEvents btnBorrarIng As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
