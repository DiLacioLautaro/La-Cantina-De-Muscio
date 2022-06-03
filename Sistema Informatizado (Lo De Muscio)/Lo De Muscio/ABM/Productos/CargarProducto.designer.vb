<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarProd
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
        Me.lblCargarProd = New System.Windows.Forms.Label()
        Me.btnVolverCProd = New System.Windows.Forms.Button()
        Me.lblNomProd = New System.Windows.Forms.Label()
        Me.txtNomProd = New System.Windows.Forms.TextBox()
        Me.txtPUProd = New System.Windows.Forms.TextBox()
        Me.txtCantProd = New System.Windows.Forms.TextBox()
        Me.lblCantProd = New System.Windows.Forms.Label()
        Me.lblPrecioProd = New System.Windows.Forms.Label()
        Me.btnCargarProd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCargarProd
        '
        Me.lblCargarProd.AutoSize = True
        Me.lblCargarProd.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarProd.Location = New System.Drawing.Point(85, 37)
        Me.lblCargarProd.Name = "lblCargarProd"
        Me.lblCargarProd.Size = New System.Drawing.Size(224, 33)
        Me.lblCargarProd.TabIndex = 14
        Me.lblCargarProd.Text = "Cargar Producto"
        '
        'btnVolverCProd
        '
        Me.btnVolverCProd.Location = New System.Drawing.Point(315, 359)
        Me.btnVolverCProd.Name = "btnVolverCProd"
        Me.btnVolverCProd.Size = New System.Drawing.Size(71, 31)
        Me.btnVolverCProd.TabIndex = 15
        Me.btnVolverCProd.Text = "VOLVER"
        Me.btnVolverCProd.UseVisualStyleBackColor = True
        '
        'lblNomProd
        '
        Me.lblNomProd.AutoSize = True
        Me.lblNomProd.Location = New System.Drawing.Point(66, 111)
        Me.lblNomProd.Name = "lblNomProd"
        Me.lblNomProd.Size = New System.Drawing.Size(47, 13)
        Me.lblNomProd.TabIndex = 16
        Me.lblNomProd.Text = "Nombre:"
        '
        'txtNomProd
        '
        Me.txtNomProd.Location = New System.Drawing.Point(131, 108)
        Me.txtNomProd.Name = "txtNomProd"
        Me.txtNomProd.Size = New System.Drawing.Size(178, 20)
        Me.txtNomProd.TabIndex = 17
        '
        'txtPUProd
        '
        Me.txtPUProd.Location = New System.Drawing.Point(131, 207)
        Me.txtPUProd.Name = "txtPUProd"
        Me.txtPUProd.Size = New System.Drawing.Size(178, 20)
        Me.txtPUProd.TabIndex = 18
        '
        'txtCantProd
        '
        Me.txtCantProd.Location = New System.Drawing.Point(131, 156)
        Me.txtCantProd.Name = "txtCantProd"
        Me.txtCantProd.Size = New System.Drawing.Size(178, 20)
        Me.txtCantProd.TabIndex = 18
        '
        'lblCantProd
        '
        Me.lblCantProd.AutoSize = True
        Me.lblCantProd.Location = New System.Drawing.Point(61, 159)
        Me.lblCantProd.Name = "lblCantProd"
        Me.lblCantProd.Size = New System.Drawing.Size(52, 13)
        Me.lblCantProd.TabIndex = 19
        Me.lblCantProd.Text = "Cantidad:"
        '
        'lblPrecioProd
        '
        Me.lblPrecioProd.AutoSize = True
        Me.lblPrecioProd.Location = New System.Drawing.Point(36, 210)
        Me.lblPrecioProd.Name = "lblPrecioProd"
        Me.lblPrecioProd.Size = New System.Drawing.Size(77, 13)
        Me.lblPrecioProd.TabIndex = 20
        Me.lblPrecioProd.Text = "Precio unitario:"
        '
        'btnCargarProd
        '
        Me.btnCargarProd.Location = New System.Drawing.Point(142, 299)
        Me.btnCargarProd.Name = "btnCargarProd"
        Me.btnCargarProd.Size = New System.Drawing.Size(151, 49)
        Me.btnCargarProd.TabIndex = 27
        Me.btnCargarProd.Text = "CARGAR"
        Me.btnCargarProd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 26)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Punto De Pedido:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(UNIDADES)"
        '
        'txtPP
        '
        Me.txtPP.Location = New System.Drawing.Point(131, 255)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(178, 20)
        Me.txtPP.TabIndex = 28
        '
        'frmCargarProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 402)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPP)
        Me.Controls.Add(Me.btnCargarProd)
        Me.Controls.Add(Me.lblPrecioProd)
        Me.Controls.Add(Me.lblCantProd)
        Me.Controls.Add(Me.txtCantProd)
        Me.Controls.Add(Me.txtPUProd)
        Me.Controls.Add(Me.txtNomProd)
        Me.Controls.Add(Me.lblNomProd)
        Me.Controls.Add(Me.btnVolverCProd)
        Me.Controls.Add(Me.lblCargarProd)
        Me.Name = "frmCargarProd"
        Me.Text = "Cargar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCargarProd As System.Windows.Forms.Label
    Friend WithEvents btnVolverCProd As System.Windows.Forms.Button
    Friend WithEvents lblNomProd As System.Windows.Forms.Label
    Friend WithEvents txtNomProd As System.Windows.Forms.TextBox
    Friend WithEvents txtPUProd As System.Windows.Forms.TextBox
    Friend WithEvents txtCantProd As System.Windows.Forms.TextBox
    Friend WithEvents lblCantProd As System.Windows.Forms.Label
    Friend WithEvents lblPrecioProd As System.Windows.Forms.Label
    Friend WithEvents btnCargarProd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
End Class
