<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarMenor
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
        Me.btnBorrarMenor = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblBorrarMenor = New System.Windows.Forms.Label()
        Me.dgvMenorBorrar = New System.Windows.Forms.DataGridView()
        Me.lblBuscSocio = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dgvMenorBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrarMenor
        '
        Me.btnBorrarMenor.Location = New System.Drawing.Point(219, 408)
        Me.btnBorrarMenor.Name = "btnBorrarMenor"
        Me.btnBorrarMenor.Size = New System.Drawing.Size(146, 48)
        Me.btnBorrarMenor.TabIndex = 27
        Me.btnBorrarMenor.Text = "BORRAR"
        Me.btnBorrarMenor.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(500, 435)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 37)
        Me.btnVolver.TabIndex = 26
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblBorrarMenor
        '
        Me.lblBorrarMenor.AutoSize = True
        Me.lblBorrarMenor.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrarMenor.Location = New System.Drawing.Point(172, 18)
        Me.lblBorrarMenor.Name = "lblBorrarMenor"
        Me.lblBorrarMenor.Size = New System.Drawing.Size(270, 33)
        Me.lblBorrarMenor.TabIndex = 25
        Me.lblBorrarMenor.Text = "Borrar Autorización"
        '
        'dgvMenorBorrar
        '
        Me.dgvMenorBorrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenorBorrar.Location = New System.Drawing.Point(37, 114)
        Me.dgvMenorBorrar.Name = "dgvMenorBorrar"
        Me.dgvMenorBorrar.Size = New System.Drawing.Size(542, 273)
        Me.dgvMenorBorrar.TabIndex = 24
        '
        'lblBuscSocio
        '
        Me.lblBuscSocio.AutoSize = True
        Me.lblBuscSocio.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscSocio.Location = New System.Drawing.Point(129, 69)
        Me.lblBuscSocio.Name = "lblBuscSocio"
        Me.lblBuscSocio.Size = New System.Drawing.Size(143, 19)
        Me.lblBuscSocio.TabIndex = 60
        Me.lblBuscSocio.Text = "Buscar por Nombre:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(274, 70)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(205, 20)
        Me.txtBuscar.TabIndex = 59
        '
        'frmBorrarMenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 484)
        Me.Controls.Add(Me.lblBuscSocio)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBorrarMenor)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblBorrarMenor)
        Me.Controls.Add(Me.dgvMenorBorrar)
        Me.Name = "frmBorrarMenor"
        Me.Text = "Borrar Autorización"
        CType(Me.dgvMenorBorrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrarMenor As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblBorrarMenor As System.Windows.Forms.Label
    Friend WithEvents dgvMenorBorrar As System.Windows.Forms.DataGridView
    Friend WithEvents lblBuscSocio As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
End Class
