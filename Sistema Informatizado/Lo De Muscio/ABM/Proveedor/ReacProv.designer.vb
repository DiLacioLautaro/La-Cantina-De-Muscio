<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReacProv
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
        Me.btnVolverRProv = New System.Windows.Forms.Button()
        Me.btnReacProv = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomProv = New System.Windows.Forms.Label()
        Me.txtTelProv = New System.Windows.Forms.TextBox()
        Me.txtDirProv = New System.Windows.Forms.TextBox()
        Me.txtDniProv = New System.Windows.Forms.TextBox()
        Me.txtNomProv = New System.Windows.Forms.TextBox()
        Me.txtPaisProv = New System.Windows.Forms.TextBox()
        Me.dgvReacProv = New System.Windows.Forms.DataGridView()
        Me.lblReacProv = New System.Windows.Forms.Label()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvReacProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverRProv
        '
        Me.btnVolverRProv.Location = New System.Drawing.Point(645, 488)
        Me.btnVolverRProv.Name = "btnVolverRProv"
        Me.btnVolverRProv.Size = New System.Drawing.Size(95, 37)
        Me.btnVolverRProv.TabIndex = 53
        Me.btnVolverRProv.Text = "VOLVER"
        Me.btnVolverRProv.UseVisualStyleBackColor = True
        '
        'btnReacProv
        '
        Me.btnReacProv.Location = New System.Drawing.Point(291, 443)
        Me.btnReacProv.Name = "btnReacProv"
        Me.btnReacProv.Size = New System.Drawing.Size(260, 54)
        Me.btnReacProv.TabIndex = 52
        Me.btnReacProv.Text = "REACTIVAR"
        Me.btnReacProv.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "CUIT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(530, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(550, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "País:"
        '
        'lblNomProv
        '
        Me.lblNomProv.AutoSize = True
        Me.lblNomProv.Location = New System.Drawing.Point(51, 389)
        Me.lblNomProv.Name = "lblNomProv"
        Me.lblNomProv.Size = New System.Drawing.Size(47, 13)
        Me.lblNomProv.TabIndex = 46
        Me.lblNomProv.Text = "Nombre:"
        '
        'txtTelProv
        '
        Me.txtTelProv.Location = New System.Drawing.Point(588, 374)
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(178, 20)
        Me.txtTelProv.TabIndex = 45
        '
        'txtDirProv
        '
        Me.txtDirProv.Location = New System.Drawing.Point(346, 400)
        Me.txtDirProv.Name = "txtDirProv"
        Me.txtDirProv.Size = New System.Drawing.Size(178, 20)
        Me.txtDirProv.TabIndex = 44
        '
        'txtDniProv
        '
        Me.txtDniProv.Location = New System.Drawing.Point(346, 374)
        Me.txtDniProv.Name = "txtDniProv"
        Me.txtDniProv.Size = New System.Drawing.Size(178, 20)
        Me.txtDniProv.TabIndex = 43
        '
        'txtNomProv
        '
        Me.txtNomProv.Location = New System.Drawing.Point(104, 386)
        Me.txtNomProv.Name = "txtNomProv"
        Me.txtNomProv.Size = New System.Drawing.Size(178, 20)
        Me.txtNomProv.TabIndex = 41
        '
        'txtPaisProv
        '
        Me.txtPaisProv.Location = New System.Drawing.Point(588, 400)
        Me.txtPaisProv.Name = "txtPaisProv"
        Me.txtPaisProv.Size = New System.Drawing.Size(178, 20)
        Me.txtPaisProv.TabIndex = 40
        '
        'dgvReacProv
        '
        Me.dgvReacProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReacProv.Location = New System.Drawing.Point(58, 94)
        Me.dgvReacProv.Name = "dgvReacProv"
        Me.dgvReacProv.Size = New System.Drawing.Size(708, 244)
        Me.dgvReacProv.TabIndex = 38
        '
        'lblReacProv
        '
        Me.lblReacProv.AutoSize = True
        Me.lblReacProv.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReacProv.Location = New System.Drawing.Point(248, 14)
        Me.lblReacProv.Name = "lblReacProv"
        Me.lblReacProv.Size = New System.Drawing.Size(274, 33)
        Me.lblReacProv.TabIndex = 37
        Me.lblReacProv.Text = "Reactivar Proveedor"
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(199, 63)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 55
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(54, 62)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 54
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmReacProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 545)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnVolverRProv)
        Me.Controls.Add(Me.btnReacProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNomProv)
        Me.Controls.Add(Me.txtTelProv)
        Me.Controls.Add(Me.txtDirProv)
        Me.Controls.Add(Me.txtDniProv)
        Me.Controls.Add(Me.txtNomProv)
        Me.Controls.Add(Me.txtPaisProv)
        Me.Controls.Add(Me.dgvReacProv)
        Me.Controls.Add(Me.lblReacProv)
        Me.Name = "frmReacProv"
        Me.Text = "Reactivar Proveedor"
        CType(Me.dgvReacProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolverRProv As System.Windows.Forms.Button
    Friend WithEvents btnReacProv As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNomProv As System.Windows.Forms.Label
    Friend WithEvents txtTelProv As System.Windows.Forms.TextBox
    Friend WithEvents txtDirProv As System.Windows.Forms.TextBox
    Friend WithEvents txtDniProv As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProv As System.Windows.Forms.TextBox
    Friend WithEvents txtPaisProv As System.Windows.Forms.TextBox
    Friend WithEvents dgvReacProv As System.Windows.Forms.DataGridView
    Friend WithEvents lblReacProv As System.Windows.Forms.Label
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
