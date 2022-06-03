<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSocBorrar
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
        Me.dgvSocB = New System.Windows.Forms.DataGridView()
        Me.lblBorrarSoc = New System.Windows.Forms.Label()
        Me.btnVolverBSoc = New System.Windows.Forms.Button()
        Me.btnBorrarSoc = New System.Windows.Forms.Button()
        Me.lblBuscSocio = New System.Windows.Forms.Label()
        Me.txtBuscarNom = New System.Windows.Forms.TextBox()
        CType(Me.dgvSocB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSocB
        '
        Me.dgvSocB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSocB.Location = New System.Drawing.Point(24, 102)
        Me.dgvSocB.Name = "dgvSocB"
        Me.dgvSocB.Size = New System.Drawing.Size(629, 273)
        Me.dgvSocB.TabIndex = 0
        '
        'lblBorrarSoc
        '
        Me.lblBorrarSoc.AutoSize = True
        Me.lblBorrarSoc.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrarSoc.Location = New System.Drawing.Point(251, 27)
        Me.lblBorrarSoc.Name = "lblBorrarSoc"
        Me.lblBorrarSoc.Size = New System.Drawing.Size(172, 33)
        Me.lblBorrarSoc.TabIndex = 21
        Me.lblBorrarSoc.Text = "Borrar Socio"
        '
        'btnVolverBSoc
        '
        Me.btnVolverBSoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverBSoc.Location = New System.Drawing.Point(558, 410)
        Me.btnVolverBSoc.Name = "btnVolverBSoc"
        Me.btnVolverBSoc.Size = New System.Drawing.Size(95, 34)
        Me.btnVolverBSoc.TabIndex = 22
        Me.btnVolverBSoc.Text = "VOLVER"
        Me.btnVolverBSoc.UseVisualStyleBackColor = True
        '
        'btnBorrarSoc
        '
        Me.btnBorrarSoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarSoc.Location = New System.Drawing.Point(257, 392)
        Me.btnBorrarSoc.Name = "btnBorrarSoc"
        Me.btnBorrarSoc.Size = New System.Drawing.Size(154, 42)
        Me.btnBorrarSoc.TabIndex = 23
        Me.btnBorrarSoc.Text = "BORRAR"
        Me.btnBorrarSoc.UseVisualStyleBackColor = True
        '
        'lblBuscSocio
        '
        Me.lblBuscSocio.AutoSize = True
        Me.lblBuscSocio.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscSocio.Location = New System.Drawing.Point(22, 77)
        Me.lblBuscSocio.Name = "lblBuscSocio"
        Me.lblBuscSocio.Size = New System.Drawing.Size(113, 19)
        Me.lblBuscSocio.TabIndex = 39
        Me.lblBuscSocio.Text = "Buscar Nombre"
        '
        'txtBuscarNom
        '
        Me.txtBuscarNom.Location = New System.Drawing.Point(141, 76)
        Me.txtBuscarNom.Name = "txtBuscarNom"
        Me.txtBuscarNom.Size = New System.Drawing.Size(229, 20)
        Me.txtBuscarNom.TabIndex = 38
        '
        'frmSocBorrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(678, 456)
        Me.Controls.Add(Me.lblBuscSocio)
        Me.Controls.Add(Me.txtBuscarNom)
        Me.Controls.Add(Me.btnBorrarSoc)
        Me.Controls.Add(Me.btnVolverBSoc)
        Me.Controls.Add(Me.lblBorrarSoc)
        Me.Controls.Add(Me.dgvSocB)
        Me.Name = "frmSocBorrar"
        Me.Text = "Borrar Socios"
        CType(Me.dgvSocB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSocB As System.Windows.Forms.DataGridView
    Friend WithEvents lblBorrarSoc As System.Windows.Forms.Label
    Friend WithEvents btnVolverBSoc As System.Windows.Forms.Button
    Friend WithEvents btnBorrarSoc As System.Windows.Forms.Button
    Friend WithEvents lblBuscSocio As System.Windows.Forms.Label
    Friend WithEvents txtBuscarNom As System.Windows.Forms.TextBox
End Class
