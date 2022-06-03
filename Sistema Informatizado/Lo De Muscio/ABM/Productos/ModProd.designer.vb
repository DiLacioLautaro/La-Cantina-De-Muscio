<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModProd
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
        Me.dgvModProd = New System.Windows.Forms.DataGridView()
        Me.lblModProd = New System.Windows.Forms.Label()
        Me.lblNomProdMod = New System.Windows.Forms.Label()
        Me.lblPrecioProd = New System.Windows.Forms.Label()
        Me.txtNomProdMod = New System.Windows.Forms.TextBox()
        Me.txtPUprodMod = New System.Windows.Forms.TextBox()
        Me.btnModProd = New System.Windows.Forms.Button()
        Me.btnVolverMProd = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvModProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvModProd
        '
        Me.dgvModProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModProd.Location = New System.Drawing.Point(63, 112)
        Me.dgvModProd.Name = "dgvModProd"
        Me.dgvModProd.Size = New System.Drawing.Size(504, 215)
        Me.dgvModProd.TabIndex = 22
        '
        'lblModProd
        '
        Me.lblModProd.AutoSize = True
        Me.lblModProd.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModProd.Location = New System.Drawing.Point(57, 29)
        Me.lblModProd.Name = "lblModProd"
        Me.lblModProd.Size = New System.Drawing.Size(262, 33)
        Me.lblModProd.TabIndex = 23
        Me.lblModProd.Text = "Modificar Producto"
        '
        'lblNomProdMod
        '
        Me.lblNomProdMod.AutoSize = True
        Me.lblNomProdMod.Location = New System.Drawing.Point(80, 359)
        Me.lblNomProdMod.Name = "lblNomProdMod"
        Me.lblNomProdMod.Size = New System.Drawing.Size(47, 13)
        Me.lblNomProdMod.TabIndex = 24
        Me.lblNomProdMod.Text = "Nombre:"
        '
        'lblPrecioProd
        '
        Me.lblPrecioProd.AutoSize = True
        Me.lblPrecioProd.Location = New System.Drawing.Point(317, 359)
        Me.lblPrecioProd.Name = "lblPrecioProd"
        Me.lblPrecioProd.Size = New System.Drawing.Size(77, 13)
        Me.lblPrecioProd.TabIndex = 26
        Me.lblPrecioProd.Text = "Precio unitario:"
        '
        'txtNomProdMod
        '
        Me.txtNomProdMod.Location = New System.Drawing.Point(133, 356)
        Me.txtNomProdMod.Name = "txtNomProdMod"
        Me.txtNomProdMod.Size = New System.Drawing.Size(178, 20)
        Me.txtNomProdMod.TabIndex = 27
        '
        'txtPUprodMod
        '
        Me.txtPUprodMod.Location = New System.Drawing.Point(400, 356)
        Me.txtPUprodMod.Name = "txtPUprodMod"
        Me.txtPUprodMod.Size = New System.Drawing.Size(133, 20)
        Me.txtPUprodMod.TabIndex = 28
        '
        'btnModProd
        '
        Me.btnModProd.Location = New System.Drawing.Point(197, 449)
        Me.btnModProd.Name = "btnModProd"
        Me.btnModProd.Size = New System.Drawing.Size(242, 53)
        Me.btnModProd.TabIndex = 32
        Me.btnModProd.Text = "MODIFICAR"
        Me.btnModProd.UseVisualStyleBackColor = True
        '
        'btnVolverMProd
        '
        Me.btnVolverMProd.Location = New System.Drawing.Point(545, 460)
        Me.btnVolverMProd.Name = "btnVolverMProd"
        Me.btnVolverMProd.Size = New System.Drawing.Size(74, 31)
        Me.btnVolverMProd.TabIndex = 33
        Me.btnVolverMProd.Text = "VOLVER"
        Me.btnVolverMProd.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(204, 82)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 42
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(59, 81)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 41
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'txtPP
        '
        Me.txtPP.Location = New System.Drawing.Point(289, 398)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(133, 20)
        Me.txtPP.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 26)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Punto de Pedido:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(UNIDADES)"
        '
        'frmModProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 524)
        Me.Controls.Add(Me.txtPP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnVolverMProd)
        Me.Controls.Add(Me.btnModProd)
        Me.Controls.Add(Me.txtPUprodMod)
        Me.Controls.Add(Me.txtNomProdMod)
        Me.Controls.Add(Me.lblPrecioProd)
        Me.Controls.Add(Me.lblNomProdMod)
        Me.Controls.Add(Me.lblModProd)
        Me.Controls.Add(Me.dgvModProd)
        Me.Name = "frmModProd"
        Me.Text = "Modificar Producto"
        CType(Me.dgvModProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvModProd As System.Windows.Forms.DataGridView
    Friend WithEvents lblModProd As System.Windows.Forms.Label
    Friend WithEvents lblNomProdMod As System.Windows.Forms.Label
    Friend WithEvents lblPrecioProd As System.Windows.Forms.Label
    Friend WithEvents txtNomProdMod As System.Windows.Forms.TextBox
    Friend WithEvents txtPUprodMod As System.Windows.Forms.TextBox
    Friend WithEvents btnModProd As System.Windows.Forms.Button
    Friend WithEvents btnVolverMProd As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
