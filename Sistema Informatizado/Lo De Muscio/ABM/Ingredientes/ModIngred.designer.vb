<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModIngred
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
        Me.lblModIngred = New System.Windows.Forms.Label()
        Me.dgvModIng = New System.Windows.Forms.DataGridView()
        Me.txtPPing = New System.Windows.Forms.TextBox()
        Me.txtNomIng = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomIng = New System.Windows.Forms.Label()
        Me.btnModIng = New System.Windows.Forms.Button()
        Me.btnVolverMProd = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvModIng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblModIngred
        '
        Me.lblModIngred.AutoSize = True
        Me.lblModIngred.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModIngred.Location = New System.Drawing.Point(150, 21)
        Me.lblModIngred.Name = "lblModIngred"
        Me.lblModIngred.Size = New System.Drawing.Size(297, 33)
        Me.lblModIngred.TabIndex = 20
        Me.lblModIngred.Text = "Modificar Ingrediente"
        '
        'dgvModIng
        '
        Me.dgvModIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModIng.Location = New System.Drawing.Point(56, 102)
        Me.dgvModIng.Name = "dgvModIng"
        Me.dgvModIng.Size = New System.Drawing.Size(446, 192)
        Me.dgvModIng.TabIndex = 21
        '
        'txtPPing
        '
        Me.txtPPing.Location = New System.Drawing.Point(363, 314)
        Me.txtPPing.Name = "txtPPing"
        Me.txtPPing.Size = New System.Drawing.Size(148, 20)
        Me.txtPPing.TabIndex = 24
        '
        'txtNomIng
        '
        Me.txtNomIng.Location = New System.Drawing.Point(102, 314)
        Me.txtNomIng.Name = "txtNomIng"
        Me.txtNomIng.Size = New System.Drawing.Size(157, 20)
        Me.txtNomIng.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Punto de pedido:"
        '
        'lblNomIng
        '
        Me.lblNomIng.AutoSize = True
        Me.lblNomIng.Location = New System.Drawing.Point(49, 317)
        Me.lblNomIng.Name = "lblNomIng"
        Me.lblNomIng.Size = New System.Drawing.Size(47, 13)
        Me.lblNomIng.TabIndex = 28
        Me.lblNomIng.Text = "Nombre:"
        '
        'btnModIng
        '
        Me.btnModIng.Location = New System.Drawing.Point(173, 360)
        Me.btnModIng.Name = "btnModIng"
        Me.btnModIng.Size = New System.Drawing.Size(204, 48)
        Me.btnModIng.TabIndex = 31
        Me.btnModIng.Text = "MODIFICAR"
        Me.btnModIng.UseVisualStyleBackColor = True
        '
        'btnVolverMProd
        '
        Me.btnVolverMProd.Location = New System.Drawing.Point(467, 411)
        Me.btnVolverMProd.Name = "btnVolverMProd"
        Me.btnVolverMProd.Size = New System.Drawing.Size(77, 33)
        Me.btnVolverMProd.TabIndex = 32
        Me.btnVolverMProd.Text = "VOLVER"
        Me.btnVolverMProd.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(197, 70)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(301, 20)
        Me.txtBuscarCom.TabIndex = 36
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(52, 69)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 35
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmModIngred
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(556, 456)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnVolverMProd)
        Me.Controls.Add(Me.btnModIng)
        Me.Controls.Add(Me.lblNomIng)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomIng)
        Me.Controls.Add(Me.txtPPing)
        Me.Controls.Add(Me.dgvModIng)
        Me.Controls.Add(Me.lblModIngred)
        Me.Name = "frmModIngred"
        Me.Text = "Modificar Ingrediente"
        CType(Me.dgvModIng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModIngred As System.Windows.Forms.Label
    Friend WithEvents dgvModIng As System.Windows.Forms.DataGridView
    Friend WithEvents txtPPing As System.Windows.Forms.TextBox
    Friend WithEvents txtNomIng As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNomIng As System.Windows.Forms.Label
    Friend WithEvents btnModIng As System.Windows.Forms.Button
    Friend WithEvents btnVolverMProd As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
