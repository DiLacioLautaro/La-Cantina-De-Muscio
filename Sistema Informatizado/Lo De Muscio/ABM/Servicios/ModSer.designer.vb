<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModServ
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
        Me.dgvModServ = New System.Windows.Forms.DataGridView()
        Me.lblModServ = New System.Windows.Forms.Label()
        Me.txtPrecioSer = New System.Windows.Forms.TextBox()
        Me.lblPrecioServ = New System.Windows.Forms.Label()
        Me.btnVolverMServ = New System.Windows.Forms.Button()
        Me.btnModServ = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.txtNomServ = New System.Windows.Forms.TextBox()
        Me.lblNomServ = New System.Windows.Forms.Label()
        CType(Me.dgvModServ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvModServ
        '
        Me.dgvModServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModServ.Location = New System.Drawing.Point(112, 144)
        Me.dgvModServ.Name = "dgvModServ"
        Me.dgvModServ.Size = New System.Drawing.Size(344, 192)
        Me.dgvModServ.TabIndex = 23
        '
        'lblModServ
        '
        Me.lblModServ.AutoSize = True
        Me.lblModServ.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModServ.Location = New System.Drawing.Point(151, 40)
        Me.lblModServ.Name = "lblModServ"
        Me.lblModServ.Size = New System.Drawing.Size(246, 33)
        Me.lblModServ.TabIndex = 24
        Me.lblModServ.Text = "Modificar Servicio"
        '
        'txtPrecioSer
        '
        Me.txtPrecioSer.Location = New System.Drawing.Point(349, 367)
        Me.txtPrecioSer.Name = "txtPrecioSer"
        Me.txtPrecioSer.Size = New System.Drawing.Size(146, 20)
        Me.txtPrecioSer.TabIndex = 32
        '
        'lblPrecioServ
        '
        Me.lblPrecioServ.AutoSize = True
        Me.lblPrecioServ.Location = New System.Drawing.Point(303, 370)
        Me.lblPrecioServ.Name = "lblPrecioServ"
        Me.lblPrecioServ.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecioServ.TabIndex = 34
        Me.lblPrecioServ.Text = "Precio:"
        '
        'btnVolverMServ
        '
        Me.btnVolverMServ.Location = New System.Drawing.Point(476, 474)
        Me.btnVolverMServ.Name = "btnVolverMServ"
        Me.btnVolverMServ.Size = New System.Drawing.Size(79, 36)
        Me.btnVolverMServ.TabIndex = 35
        Me.btnVolverMServ.Text = "VOLVER"
        Me.btnVolverMServ.UseVisualStyleBackColor = True
        '
        'btnModServ
        '
        Me.btnModServ.Location = New System.Drawing.Point(195, 419)
        Me.btnModServ.Name = "btnModServ"
        Me.btnModServ.Size = New System.Drawing.Size(193, 51)
        Me.btnModServ.TabIndex = 36
        Me.btnModServ.Text = "MODIFICAR"
        Me.btnModServ.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(231, 103)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 57
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(86, 102)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 56
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'txtNomServ
        '
        Me.txtNomServ.Enabled = False
        Me.txtNomServ.Location = New System.Drawing.Point(112, 367)
        Me.txtNomServ.Name = "txtNomServ"
        Me.txtNomServ.Size = New System.Drawing.Size(178, 20)
        Me.txtNomServ.TabIndex = 31
        '
        'lblNomServ
        '
        Me.lblNomServ.AutoSize = True
        Me.lblNomServ.Location = New System.Drawing.Point(59, 370)
        Me.lblNomServ.Name = "lblNomServ"
        Me.lblNomServ.Size = New System.Drawing.Size(47, 13)
        Me.lblNomServ.TabIndex = 33
        Me.lblNomServ.Text = "Nombre:"
        '
        'frmModServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 528)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnModServ)
        Me.Controls.Add(Me.btnVolverMServ)
        Me.Controls.Add(Me.lblPrecioServ)
        Me.Controls.Add(Me.lblNomServ)
        Me.Controls.Add(Me.txtPrecioSer)
        Me.Controls.Add(Me.txtNomServ)
        Me.Controls.Add(Me.lblModServ)
        Me.Controls.Add(Me.dgvModServ)
        Me.Name = "frmModServ"
        Me.Text = "Modificar servicio"
        CType(Me.dgvModServ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvModServ As System.Windows.Forms.DataGridView
    Friend WithEvents lblModServ As System.Windows.Forms.Label
    Friend WithEvents txtPrecioSer As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioServ As System.Windows.Forms.Label
    Friend WithEvents btnVolverMServ As System.Windows.Forms.Button
    Friend WithEvents btnModServ As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents txtNomServ As System.Windows.Forms.TextBox
    Friend WithEvents lblNomServ As System.Windows.Forms.Label
End Class
