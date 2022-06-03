<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarSer
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
        Me.lblCargarSer = New System.Windows.Forms.Label()
        Me.lblNomSer = New System.Windows.Forms.Label()
        Me.lblPrecioSer = New System.Windows.Forms.Label()
        Me.txtPrecioSer = New System.Windows.Forms.TextBox()
        Me.txtNomSer = New System.Windows.Forms.TextBox()
        Me.btnCargarSer = New System.Windows.Forms.Button()
        Me.btnVolverCSer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCargarSer
        '
        Me.lblCargarSer.AutoSize = True
        Me.lblCargarSer.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarSer.Location = New System.Drawing.Point(74, 22)
        Me.lblCargarSer.Name = "lblCargarSer"
        Me.lblCargarSer.Size = New System.Drawing.Size(208, 33)
        Me.lblCargarSer.TabIndex = 14
        Me.lblCargarSer.Text = "Cargar Servicio"
        '
        'lblNomSer
        '
        Me.lblNomSer.AutoSize = True
        Me.lblNomSer.Location = New System.Drawing.Point(40, 83)
        Me.lblNomSer.Name = "lblNomSer"
        Me.lblNomSer.Size = New System.Drawing.Size(47, 13)
        Me.lblNomSer.TabIndex = 15
        Me.lblNomSer.Text = "Nombre:"
        '
        'lblPrecioSer
        '
        Me.lblPrecioSer.AutoSize = True
        Me.lblPrecioSer.Location = New System.Drawing.Point(47, 127)
        Me.lblPrecioSer.Name = "lblPrecioSer"
        Me.lblPrecioSer.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecioSer.TabIndex = 16
        Me.lblPrecioSer.Text = "Precio:"
        '
        'txtPrecioSer
        '
        Me.txtPrecioSer.Location = New System.Drawing.Point(93, 124)
        Me.txtPrecioSer.Name = "txtPrecioSer"
        Me.txtPrecioSer.Size = New System.Drawing.Size(178, 20)
        Me.txtPrecioSer.TabIndex = 17
        '
        'txtNomSer
        '
        Me.txtNomSer.Location = New System.Drawing.Point(93, 80)
        Me.txtNomSer.Name = "txtNomSer"
        Me.txtNomSer.Size = New System.Drawing.Size(178, 20)
        Me.txtNomSer.TabIndex = 18
        '
        'btnCargarSer
        '
        Me.btnCargarSer.Location = New System.Drawing.Point(114, 176)
        Me.btnCargarSer.Name = "btnCargarSer"
        Me.btnCargarSer.Size = New System.Drawing.Size(121, 49)
        Me.btnCargarSer.TabIndex = 27
        Me.btnCargarSer.Text = "CARGAR"
        Me.btnCargarSer.UseVisualStyleBackColor = True
        '
        'btnVolverCSer
        '
        Me.btnVolverCSer.Location = New System.Drawing.Point(264, 238)
        Me.btnVolverCSer.Name = "btnVolverCSer"
        Me.btnVolverCSer.Size = New System.Drawing.Size(75, 28)
        Me.btnVolverCSer.TabIndex = 28
        Me.btnVolverCSer.Text = "VOLVER"
        Me.btnVolverCSer.UseVisualStyleBackColor = True
        '
        'frmCargarSer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(358, 278)
        Me.Controls.Add(Me.btnVolverCSer)
        Me.Controls.Add(Me.btnCargarSer)
        Me.Controls.Add(Me.txtNomSer)
        Me.Controls.Add(Me.txtPrecioSer)
        Me.Controls.Add(Me.lblPrecioSer)
        Me.Controls.Add(Me.lblNomSer)
        Me.Controls.Add(Me.lblCargarSer)
        Me.Name = "frmCargarSer"
        Me.Text = "Cargar Servicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCargarSer As System.Windows.Forms.Label
    Friend WithEvents lblNomSer As System.Windows.Forms.Label
    Friend WithEvents lblPrecioSer As System.Windows.Forms.Label
    Friend WithEvents txtPrecioSer As System.Windows.Forms.TextBox
    Friend WithEvents txtNomSer As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarSer As System.Windows.Forms.Button
    Friend WithEvents btnVolverCSer As System.Windows.Forms.Button
End Class
