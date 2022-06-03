<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MorososCC
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvMorosos = New System.Windows.Forms.DataGridView()
        Me.cbxBuscarPor = New System.Windows.Forms.ComboBox()
        CType(Me.dgvMorosos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(630, 424)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(97, 35)
        Me.btnVolver.TabIndex = 31
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 26)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "MOROSOS EN CUENTA CORRIENTE - BUSCAR"
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(26, 56)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(117, 26)
        Me.lblMenu.TabIndex = 29
        Me.lblMenu.Text = "Buscar Por"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(345, 62)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(364, 20)
        Me.txtBuscar.TabIndex = 28
        '
        'dgvMorosos
        '
        Me.dgvMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMorosos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvMorosos.Location = New System.Drawing.Point(31, 88)
        Me.dgvMorosos.Name = "dgvMorosos"
        Me.dgvMorosos.Size = New System.Drawing.Size(678, 316)
        Me.dgvMorosos.TabIndex = 27
        '
        'cbxBuscarPor
        '
        Me.cbxBuscarPor.FormattingEnabled = True
        Me.cbxBuscarPor.Items.AddRange(New Object() {"nrosocio", "Nombre", "Apellido"})
        Me.cbxBuscarPor.Location = New System.Drawing.Point(146, 60)
        Me.cbxBuscarPor.Name = "cbxBuscarPor"
        Me.cbxBuscarPor.Size = New System.Drawing.Size(157, 21)
        Me.cbxBuscarPor.TabIndex = 32
        '
        'MorososCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(740, 471)
        Me.Controls.Add(Me.cbxBuscarPor)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvMorosos)
        Me.Name = "MorososCC"
        Me.Text = "Morosos En CC"
        CType(Me.dgvMorosos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvMorosos As System.Windows.Forms.DataGridView
    Friend WithEvents cbxBuscarPor As System.Windows.Forms.ComboBox
End Class
