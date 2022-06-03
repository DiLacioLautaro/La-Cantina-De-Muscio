<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamPerm
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
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.lblModCon = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPermUser = New System.Windows.Forms.ComboBox()
        Me.lblPermUser = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(524, 366)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 32)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(30, 108)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(573, 198)
        Me.dgvUsers.TabIndex = 9
        '
        'lblModCon
        '
        Me.lblModCon.AutoSize = True
        Me.lblModCon.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModCon.Location = New System.Drawing.Point(160, 19)
        Me.lblModCon.Name = "lblModCon"
        Me.lblModCon.Size = New System.Drawing.Size(260, 33)
        Me.lblModCon.TabIndex = 15
        Me.lblModCon.Text = "Modificar Permisos"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(255, 82)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscar.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar por Nombre de Usuario:"
        '
        'cmbPermUser
        '
        Me.cmbPermUser.FormattingEnabled = True
        Me.cmbPermUser.Items.AddRange(New Object() {"Admin", "Compras", "Caja", "Mozo" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cmbPermUser.Location = New System.Drawing.Point(110, 325)
        Me.cmbPermUser.Name = "cmbPermUser"
        Me.cmbPermUser.Size = New System.Drawing.Size(178, 21)
        Me.cmbPermUser.TabIndex = 28
        '
        'lblPermUser
        '
        Me.lblPermUser.AutoSize = True
        Me.lblPermUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermUser.Location = New System.Drawing.Point(27, 326)
        Me.lblPermUser.Name = "lblPermUser"
        Me.lblPermUser.Size = New System.Drawing.Size(77, 16)
        Me.lblPermUser.TabIndex = 27
        Me.lblPermUser.Text = "Permisos:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(294, 325)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(207, 48)
        Me.btnConfirmar.TabIndex = 29
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmCamPerm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 410)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.cmbPermUser)
        Me.Controls.Add(Me.lblPermUser)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblModCon)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "frmCamPerm"
        Me.Text = "Modificar Permisos"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents lblModCon As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPermUser As System.Windows.Forms.ComboBox
    Friend WithEvents lblPermUser As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
End Class
