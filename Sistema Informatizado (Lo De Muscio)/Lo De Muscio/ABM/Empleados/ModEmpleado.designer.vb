<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModEmpleado
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
        Me.btnVolverMEmp = New System.Windows.Forms.Button()
        Me.dgvModEmp = New System.Windows.Forms.DataGridView()
        Me.lblModEmpleado = New System.Windows.Forms.Label()
        Me.txtTelModEmp = New System.Windows.Forms.TextBox()
        Me.txtApeModEmp = New System.Windows.Forms.TextBox()
        Me.txtDniModEmp = New System.Windows.Forms.TextBox()
        Me.txtNomModEmp = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoModEmp = New System.Windows.Forms.ComboBox()
        Me.btnModEmp = New System.Windows.Forms.Button()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblModEmp = New System.Windows.Forms.Label()
        CType(Me.dgvModEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverMEmp
        '
        Me.btnVolverMEmp.Location = New System.Drawing.Point(604, 497)
        Me.btnVolverMEmp.Name = "btnVolverMEmp"
        Me.btnVolverMEmp.Size = New System.Drawing.Size(75, 30)
        Me.btnVolverMEmp.TabIndex = 16
        Me.btnVolverMEmp.Text = "VOLVER"
        Me.btnVolverMEmp.UseVisualStyleBackColor = True
        '
        'dgvModEmp
        '
        Me.dgvModEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModEmp.Location = New System.Drawing.Point(38, 109)
        Me.dgvModEmp.Name = "dgvModEmp"
        Me.dgvModEmp.Size = New System.Drawing.Size(641, 192)
        Me.dgvModEmp.TabIndex = 17
        '
        'lblModEmpleado
        '
        Me.lblModEmpleado.AutoSize = True
        Me.lblModEmpleado.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmpleado.Location = New System.Drawing.Point(234, 19)
        Me.lblModEmpleado.Name = "lblModEmpleado"
        Me.lblModEmpleado.Size = New System.Drawing.Size(272, 33)
        Me.lblModEmpleado.TabIndex = 19
        Me.lblModEmpleado.Text = "Modificar Empleado"
        '
        'txtTelModEmp
        '
        Me.txtTelModEmp.Location = New System.Drawing.Point(501, 359)
        Me.txtTelModEmp.Name = "txtTelModEmp"
        Me.txtTelModEmp.Size = New System.Drawing.Size(178, 20)
        Me.txtTelModEmp.TabIndex = 20
        '
        'txtApeModEmp
        '
        Me.txtApeModEmp.Location = New System.Drawing.Point(92, 359)
        Me.txtApeModEmp.Name = "txtApeModEmp"
        Me.txtApeModEmp.Size = New System.Drawing.Size(178, 20)
        Me.txtApeModEmp.TabIndex = 21
        '
        'txtDniModEmp
        '
        Me.txtDniModEmp.Location = New System.Drawing.Point(501, 321)
        Me.txtDniModEmp.Name = "txtDniModEmp"
        Me.txtDniModEmp.Size = New System.Drawing.Size(178, 20)
        Me.txtDniModEmp.TabIndex = 21
        '
        'txtNomModEmp
        '
        Me.txtNomModEmp.Location = New System.Drawing.Point(92, 326)
        Me.txtNomModEmp.Name = "txtNomModEmp"
        Me.txtNomModEmp.Size = New System.Drawing.Size(178, 20)
        Me.txtNomModEmp.TabIndex = 22
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(39, 329)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreEmpleado.TabIndex = 24
        Me.lblNombreEmpleado.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(443, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(466, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tipo de empleado:"
        '
        'cmbTipoModEmp
        '
        Me.cmbTipoModEmp.FormattingEnabled = True
        Me.cmbTipoModEmp.Items.AddRange(New Object() {"Cajero", "Cocinero", "Mozo", "Sistemas"})
        Me.cmbTipoModEmp.Location = New System.Drawing.Point(342, 398)
        Me.cmbTipoModEmp.Name = "cmbTipoModEmp"
        Me.cmbTipoModEmp.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoModEmp.TabIndex = 29
        '
        'btnModEmp
        '
        Me.btnModEmp.Location = New System.Drawing.Point(240, 454)
        Me.btnModEmp.Name = "btnModEmp"
        Me.btnModEmp.Size = New System.Drawing.Size(248, 52)
        Me.btnModEmp.TabIndex = 30
        Me.btnModEmp.Text = "MODIFICAR"
        Me.btnModEmp.UseVisualStyleBackColor = True
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(179, 79)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(246, 20)
        Me.txtBuscarCom.TabIndex = 32
        '
        'lblModEmp
        '
        Me.lblModEmp.AutoSize = True
        Me.lblModEmp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModEmp.Location = New System.Drawing.Point(34, 78)
        Me.lblModEmp.Name = "lblModEmp"
        Me.lblModEmp.Size = New System.Drawing.Size(139, 19)
        Me.lblModEmp.TabIndex = 31
        Me.lblModEmp.Text = "Buscar por Nombre"
        '
        'frmModEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 541)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblModEmp)
        Me.Controls.Add(Me.btnModEmp)
        Me.Controls.Add(Me.cmbTipoModEmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.txtNomModEmp)
        Me.Controls.Add(Me.txtDniModEmp)
        Me.Controls.Add(Me.txtApeModEmp)
        Me.Controls.Add(Me.txtTelModEmp)
        Me.Controls.Add(Me.lblModEmpleado)
        Me.Controls.Add(Me.dgvModEmp)
        Me.Controls.Add(Me.btnVolverMEmp)
        Me.Name = "frmModEmpleado"
        CType(Me.dgvModEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolverMEmp As System.Windows.Forms.Button
    Friend WithEvents dgvModEmp As System.Windows.Forms.DataGridView
    Friend WithEvents lblModEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtTelModEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtApeModEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtDniModEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtNomModEmp As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoModEmp As System.Windows.Forms.ComboBox
    Friend WithEvents btnModEmp As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblModEmp As System.Windows.Forms.Label
End Class
