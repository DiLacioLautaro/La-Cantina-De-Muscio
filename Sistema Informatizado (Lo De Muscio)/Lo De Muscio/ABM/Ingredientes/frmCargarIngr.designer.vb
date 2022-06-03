<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarIngr
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
        Me.txtNomIngr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPuntoPedido = New System.Windows.Forms.TextBox()
        Me.btnCargarIngr = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCargarProd
        '
        Me.lblCargarProd.AutoSize = True
        Me.lblCargarProd.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarProd.Location = New System.Drawing.Point(64, 38)
        Me.lblCargarProd.Name = "lblCargarProd"
        Me.lblCargarProd.Size = New System.Drawing.Size(259, 33)
        Me.lblCargarProd.TabIndex = 15
        Me.lblCargarProd.Text = "Cargar Ingrediente"
        '
        'txtNomIngr
        '
        Me.txtNomIngr.Location = New System.Drawing.Point(130, 94)
        Me.txtNomIngr.Name = "txtNomIngr"
        Me.txtNomIngr.Size = New System.Drawing.Size(160, 20)
        Me.txtNomIngr.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Stock Inicial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(EN KILOS)"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(132, 133)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(160, 20)
        Me.txtCant.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Punto De Pedido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(EN KILOS)"
        '
        'txtPuntoPedido
        '
        Me.txtPuntoPedido.Location = New System.Drawing.Point(130, 179)
        Me.txtPuntoPedido.Name = "txtPuntoPedido"
        Me.txtPuntoPedido.Size = New System.Drawing.Size(160, 20)
        Me.txtPuntoPedido.TabIndex = 20
        '
        'btnCargarIngr
        '
        Me.btnCargarIngr.Location = New System.Drawing.Point(86, 219)
        Me.btnCargarIngr.Name = "btnCargarIngr"
        Me.btnCargarIngr.Size = New System.Drawing.Size(219, 49)
        Me.btnCargarIngr.TabIndex = 29
        Me.btnCargarIngr.Text = "CARGAR"
        Me.btnCargarIngr.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(313, 302)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(69, 30)
        Me.btnVolver.TabIndex = 28
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmCargarIngr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 344)
        Me.Controls.Add(Me.btnCargarIngr)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPuntoPedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomIngr)
        Me.Controls.Add(Me.lblCargarProd)
        Me.Name = "frmCargarIngr"
        Me.Text = "Cargar Ingrediente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCargarProd As System.Windows.Forms.Label
    Friend WithEvents txtNomIngr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPuntoPedido As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarIngr As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
