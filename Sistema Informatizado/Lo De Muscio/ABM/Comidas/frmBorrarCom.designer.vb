<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarCom
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
        Me.txtNombreComBusc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.dgvComidas = New System.Windows.Forms.DataGridView()
        Me.btnBorrarComida = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreComBusc
        '
        Me.txtNombreComBusc.Location = New System.Drawing.Point(195, 65)
        Me.txtNombreComBusc.Name = "txtNombreComBusc"
        Me.txtNombreComBusc.Size = New System.Drawing.Size(200, 20)
        Me.txtNombreComBusc.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Buscar por Nombre:"
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(44, 19)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(203, 33)
        Me.lblMenu.TabIndex = 18
        Me.lblMenu.Text = "Borrar Comida"
        '
        'dgvComidas
        '
        Me.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComidas.Location = New System.Drawing.Point(50, 91)
        Me.dgvComidas.Name = "dgvComidas"
        Me.dgvComidas.Size = New System.Drawing.Size(412, 251)
        Me.dgvComidas.TabIndex = 17
        '
        'btnBorrarComida
        '
        Me.btnBorrarComida.Enabled = False
        Me.btnBorrarComida.Location = New System.Drawing.Point(151, 365)
        Me.btnBorrarComida.Name = "btnBorrarComida"
        Me.btnBorrarComida.Size = New System.Drawing.Size(198, 44)
        Me.btnBorrarComida.TabIndex = 21
        Me.btnBorrarComida.Text = "BORRAR COMIDA"
        Me.btnBorrarComida.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(398, 365)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 34)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmBorrarCom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(518, 432)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnBorrarComida)
        Me.Controls.Add(Me.txtNombreComBusc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.dgvComidas)
        Me.Name = "frmBorrarCom"
        Me.Text = "Borrar Comida"
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreComBusc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents dgvComidas As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrarComida As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
