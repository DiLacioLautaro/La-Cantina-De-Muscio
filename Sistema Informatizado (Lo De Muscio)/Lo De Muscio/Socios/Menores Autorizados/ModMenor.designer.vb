<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModMenor
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
        Me.lblBuscSocio = New System.Windows.Forms.Label()
        Me.txtBuscarMenor = New System.Windows.Forms.TextBox()
        Me.btnModSocio = New System.Windows.Forms.Button()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblApeModSoc = New System.Windows.Forms.Label()
        Me.lblNomModSoc = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtApeMenor = New System.Windows.Forms.TextBox()
        Me.txtNomMenor = New System.Windows.Forms.TextBox()
        Me.dgvModMenor = New System.Windows.Forms.DataGridView()
        Me.btnVolverModSocio = New System.Windows.Forms.Button()
        Me.lblModSocio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvModMenor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBuscSocio
        '
        Me.lblBuscSocio.AutoSize = True
        Me.lblBuscSocio.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscSocio.Location = New System.Drawing.Point(50, 66)
        Me.lblBuscSocio.Name = "lblBuscSocio"
        Me.lblBuscSocio.Size = New System.Drawing.Size(143, 19)
        Me.lblBuscSocio.TabIndex = 56
        Me.lblBuscSocio.Text = "Buscar por Nombre:"
        '
        'txtBuscarMenor
        '
        Me.txtBuscarMenor.Location = New System.Drawing.Point(199, 67)
        Me.txtBuscarMenor.Name = "txtBuscarMenor"
        Me.txtBuscarMenor.Size = New System.Drawing.Size(205, 20)
        Me.txtBuscarMenor.TabIndex = 55
        '
        'btnModSocio
        '
        Me.btnModSocio.Location = New System.Drawing.Point(246, 403)
        Me.btnModSocio.Name = "btnModSocio"
        Me.btnModSocio.Size = New System.Drawing.Size(218, 50)
        Me.btnModSocio.TabIndex = 54
        Me.btnModSocio.Text = "MODIFICAR"
        Me.btnModSocio.UseVisualStyleBackColor = True
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(17, 54)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(40, 13)
        Me.lblMonto.TabIndex = 53
        Me.lblMonto.Text = "Monto:"
        '
        'lblApeModSoc
        '
        Me.lblApeModSoc.AutoSize = True
        Me.lblApeModSoc.Location = New System.Drawing.Point(344, 19)
        Me.lblApeModSoc.Name = "lblApeModSoc"
        Me.lblApeModSoc.Size = New System.Drawing.Size(47, 13)
        Me.lblApeModSoc.TabIndex = 49
        Me.lblApeModSoc.Text = "Apellido:"
        '
        'lblNomModSoc
        '
        Me.lblNomModSoc.AutoSize = True
        Me.lblNomModSoc.Location = New System.Drawing.Point(10, 19)
        Me.lblNomModSoc.Name = "lblNomModSoc"
        Me.lblNomModSoc.Size = New System.Drawing.Size(47, 13)
        Me.lblNomModSoc.TabIndex = 48
        Me.lblNomModSoc.Text = "Nombre:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(63, 51)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(178, 20)
        Me.txtMonto.TabIndex = 47
        '
        'txtApeMenor
        '
        Me.txtApeMenor.Location = New System.Drawing.Point(397, 16)
        Me.txtApeMenor.Name = "txtApeMenor"
        Me.txtApeMenor.Size = New System.Drawing.Size(178, 20)
        Me.txtApeMenor.TabIndex = 44
        '
        'txtNomMenor
        '
        Me.txtNomMenor.Location = New System.Drawing.Point(63, 16)
        Me.txtNomMenor.Name = "txtNomMenor"
        Me.txtNomMenor.Size = New System.Drawing.Size(178, 20)
        Me.txtNomMenor.TabIndex = 43
        '
        'dgvModMenor
        '
        Me.dgvModMenor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModMenor.Location = New System.Drawing.Point(54, 97)
        Me.dgvModMenor.Name = "dgvModMenor"
        Me.dgvModMenor.Size = New System.Drawing.Size(602, 192)
        Me.dgvModMenor.TabIndex = 40
        '
        'btnVolverModSocio
        '
        Me.btnVolverModSocio.Location = New System.Drawing.Point(582, 434)
        Me.btnVolverModSocio.Name = "btnVolverModSocio"
        Me.btnVolverModSocio.Size = New System.Drawing.Size(74, 33)
        Me.btnVolverModSocio.TabIndex = 39
        Me.btnVolverModSocio.Text = "VOLVER"
        Me.btnVolverModSocio.UseVisualStyleBackColor = True
        '
        'lblModSocio
        '
        Me.lblModSocio.AutoSize = True
        Me.lblModSocio.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModSocio.Location = New System.Drawing.Point(193, 21)
        Me.lblModSocio.Name = "lblModSocio"
        Me.lblModSocio.Size = New System.Drawing.Size(309, 33)
        Me.lblModSocio.TabIndex = 38
        Me.lblModSocio.Text = "Modificar Autorización"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.lblApeModSoc)
        Me.GroupBox1.Controls.Add(Me.lblNomModSoc)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtApeMenor)
        Me.GroupBox1.Controls.Add(Me.txtNomMenor)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 88)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'frmModMenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(701, 479)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblBuscSocio)
        Me.Controls.Add(Me.txtBuscarMenor)
        Me.Controls.Add(Me.btnModSocio)
        Me.Controls.Add(Me.dgvModMenor)
        Me.Controls.Add(Me.btnVolverModSocio)
        Me.Controls.Add(Me.lblModSocio)
        Me.Name = "frmModMenor"
        Me.Text = "Modificar Autorización"
        CType(Me.dgvModMenor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscSocio As System.Windows.Forms.Label
    Friend WithEvents txtBuscarMenor As System.Windows.Forms.TextBox
    Friend WithEvents btnModSocio As System.Windows.Forms.Button
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblApeModSoc As System.Windows.Forms.Label
    Friend WithEvents lblNomModSoc As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtApeMenor As System.Windows.Forms.TextBox
    Friend WithEvents txtNomMenor As System.Windows.Forms.TextBox
    Friend WithEvents dgvModMenor As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverModSocio As System.Windows.Forms.Button
    Friend WithEvents lblModSocio As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
