<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModSocio
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
        Me.lblModSocio = New System.Windows.Forms.Label()
        Me.btnVolverModSocio = New System.Windows.Forms.Button()
        Me.dgvModSocio = New System.Windows.Forms.DataGridView()
        Me.txtDniModSocio = New System.Windows.Forms.TextBox()
        Me.txtNomModSocio = New System.Windows.Forms.TextBox()
        Me.txtApeModSocio = New System.Windows.Forms.TextBox()
        Me.txtTelModSocio = New System.Windows.Forms.TextBox()
        Me.txtLocModSocio = New System.Windows.Forms.TextBox()
        Me.txtEmailModSocio = New System.Windows.Forms.TextBox()
        Me.lblNomModSoc = New System.Windows.Forms.Label()
        Me.lblApeModSoc = New System.Windows.Forms.Label()
        Me.lblTelModSoc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDniModSoc = New System.Windows.Forms.Label()
        Me.lblLocModSoc = New System.Windows.Forms.Label()
        Me.btnModSocio = New System.Windows.Forms.Button()
        Me.txtBuscarNom = New System.Windows.Forms.TextBox()
        Me.lblBuscSocio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvModSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModSocio
        '
        Me.lblModSocio.AutoSize = True
        Me.lblModSocio.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModSocio.Location = New System.Drawing.Point(285, 20)
        Me.lblModSocio.Name = "lblModSocio"
        Me.lblModSocio.Size = New System.Drawing.Size(211, 33)
        Me.lblModSocio.TabIndex = 20
        Me.lblModSocio.Text = "Modificar Socio"
        '
        'btnVolverModSocio
        '
        Me.btnVolverModSocio.Location = New System.Drawing.Point(613, 471)
        Me.btnVolverModSocio.Name = "btnVolverModSocio"
        Me.btnVolverModSocio.Size = New System.Drawing.Size(88, 37)
        Me.btnVolverModSocio.TabIndex = 21
        Me.btnVolverModSocio.Text = "VOLVER"
        Me.btnVolverModSocio.UseVisualStyleBackColor = True
        '
        'dgvModSocio
        '
        Me.dgvModSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModSocio.Location = New System.Drawing.Point(29, 97)
        Me.dgvModSocio.Name = "dgvModSocio"
        Me.dgvModSocio.Size = New System.Drawing.Size(709, 241)
        Me.dgvModSocio.TabIndex = 22
        '
        'txtDniModSocio
        '
        Me.txtDniModSocio.Location = New System.Drawing.Point(543, 15)
        Me.txtDniModSocio.Name = "txtDniModSocio"
        Me.txtDniModSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtDniModSocio.TabIndex = 24
        '
        'txtNomModSocio
        '
        Me.txtNomModSocio.Location = New System.Drawing.Point(54, 19)
        Me.txtNomModSocio.Name = "txtNomModSocio"
        Me.txtNomModSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtNomModSocio.TabIndex = 24
        '
        'txtApeModSocio
        '
        Me.txtApeModSocio.Location = New System.Drawing.Point(54, 45)
        Me.txtApeModSocio.Name = "txtApeModSocio"
        Me.txtApeModSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtApeModSocio.TabIndex = 25
        '
        'txtTelModSocio
        '
        Me.txtTelModSocio.Location = New System.Drawing.Point(301, 19)
        Me.txtTelModSocio.Name = "txtTelModSocio"
        Me.txtTelModSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtTelModSocio.TabIndex = 26
        '
        'txtLocModSocio
        '
        Me.txtLocModSocio.Location = New System.Drawing.Point(543, 41)
        Me.txtLocModSocio.Name = "txtLocModSocio"
        Me.txtLocModSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtLocModSocio.TabIndex = 27
        '
        'txtEmailModSocio
        '
        Me.txtEmailModSocio.Location = New System.Drawing.Point(301, 45)
        Me.txtEmailModSocio.Name = "txtEmailModSocio"
        Me.txtEmailModSocio.Size = New System.Drawing.Size(178, 20)
        Me.txtEmailModSocio.TabIndex = 28
        '
        'lblNomModSoc
        '
        Me.lblNomModSoc.AutoSize = True
        Me.lblNomModSoc.Location = New System.Drawing.Point(1, 22)
        Me.lblNomModSoc.Name = "lblNomModSoc"
        Me.lblNomModSoc.Size = New System.Drawing.Size(47, 13)
        Me.lblNomModSoc.TabIndex = 29
        Me.lblNomModSoc.Text = "Nombre:"
        '
        'lblApeModSoc
        '
        Me.lblApeModSoc.AutoSize = True
        Me.lblApeModSoc.Location = New System.Drawing.Point(1, 48)
        Me.lblApeModSoc.Name = "lblApeModSoc"
        Me.lblApeModSoc.Size = New System.Drawing.Size(47, 13)
        Me.lblApeModSoc.TabIndex = 30
        Me.lblApeModSoc.Text = "Apellido:"
        '
        'lblTelModSoc
        '
        Me.lblTelModSoc.AutoSize = True
        Me.lblTelModSoc.Location = New System.Drawing.Point(243, 22)
        Me.lblTelModSoc.Name = "lblTelModSoc"
        Me.lblTelModSoc.Size = New System.Drawing.Size(52, 13)
        Me.lblTelModSoc.TabIndex = 31
        Me.lblTelModSoc.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "E-Mail:"
        '
        'lblDniModSoc
        '
        Me.lblDniModSoc.AutoSize = True
        Me.lblDniModSoc.Location = New System.Drawing.Point(512, 19)
        Me.lblDniModSoc.Name = "lblDniModSoc"
        Me.lblDniModSoc.Size = New System.Drawing.Size(29, 13)
        Me.lblDniModSoc.TabIndex = 33
        Me.lblDniModSoc.Text = "DNI:"
        '
        'lblLocModSoc
        '
        Me.lblLocModSoc.AutoSize = True
        Me.lblLocModSoc.Location = New System.Drawing.Point(485, 45)
        Me.lblLocModSoc.Name = "lblLocModSoc"
        Me.lblLocModSoc.Size = New System.Drawing.Size(56, 13)
        Me.lblLocModSoc.TabIndex = 34
        Me.lblLocModSoc.Text = "Localidad:"
        '
        'btnModSocio
        '
        Me.btnModSocio.Location = New System.Drawing.Point(276, 451)
        Me.btnModSocio.Name = "btnModSocio"
        Me.btnModSocio.Size = New System.Drawing.Size(203, 43)
        Me.btnModSocio.TabIndex = 35
        Me.btnModSocio.Text = "MODIFICAR"
        Me.btnModSocio.UseVisualStyleBackColor = True
        '
        'txtBuscarNom
        '
        Me.txtBuscarNom.Location = New System.Drawing.Point(183, 71)
        Me.txtBuscarNom.Name = "txtBuscarNom"
        Me.txtBuscarNom.Size = New System.Drawing.Size(296, 20)
        Me.txtBuscarNom.TabIndex = 36
        '
        'lblBuscSocio
        '
        Me.lblBuscSocio.AutoSize = True
        Me.lblBuscSocio.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscSocio.Location = New System.Drawing.Point(34, 70)
        Me.lblBuscSocio.Name = "lblBuscSocio"
        Me.lblBuscSocio.Size = New System.Drawing.Size(143, 19)
        Me.lblBuscSocio.TabIndex = 37
        Me.lblBuscSocio.Text = "Buscar por Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLocModSoc)
        Me.GroupBox1.Controls.Add(Me.lblDniModSoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTelModSoc)
        Me.GroupBox1.Controls.Add(Me.lblApeModSoc)
        Me.GroupBox1.Controls.Add(Me.lblNomModSoc)
        Me.GroupBox1.Controls.Add(Me.txtEmailModSocio)
        Me.GroupBox1.Controls.Add(Me.txtLocModSocio)
        Me.GroupBox1.Controls.Add(Me.txtTelModSocio)
        Me.GroupBox1.Controls.Add(Me.txtApeModSocio)
        Me.GroupBox1.Controls.Add(Me.txtNomModSocio)
        Me.GroupBox1.Controls.Add(Me.txtDniModSocio)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 88)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'frmModSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 534)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblBuscSocio)
        Me.Controls.Add(Me.txtBuscarNom)
        Me.Controls.Add(Me.btnModSocio)
        Me.Controls.Add(Me.dgvModSocio)
        Me.Controls.Add(Me.btnVolverModSocio)
        Me.Controls.Add(Me.lblModSocio)
        Me.Name = "frmModSocio"
        Me.Text = "Modificar Socio"
        CType(Me.dgvModSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModSocio As System.Windows.Forms.Label
    Friend WithEvents btnVolverModSocio As System.Windows.Forms.Button
    Friend WithEvents dgvModSocio As System.Windows.Forms.DataGridView
    Friend WithEvents txtDniModSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNomModSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtApeModSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtTelModSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtLocModSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailModSocio As System.Windows.Forms.TextBox
    Friend WithEvents lblNomModSoc As System.Windows.Forms.Label
    Friend WithEvents lblApeModSoc As System.Windows.Forms.Label
    Friend WithEvents lblTelModSoc As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDniModSoc As System.Windows.Forms.Label
    Friend WithEvents lblLocModSoc As System.Windows.Forms.Label
    Friend WithEvents btnModSocio As System.Windows.Forms.Button
    Friend WithEvents txtBuscarNom As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscSocio As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
