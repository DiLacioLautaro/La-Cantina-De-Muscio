<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarEmpleado
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
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.txtDNIEmpleado = New System.Windows.Forms.TextBox()
        Me.txtTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.cmbTipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.btnCargarEmpleado = New System.Windows.Forms.Button()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVolverCargarEmpleado = New System.Windows.Forms.Button()
        Me.lblCargarEmpleado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(85, 92)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(178, 20)
        Me.txtNombreEmpleado.TabIndex = 0
        '
        'txtApellidoEmpleado
        '
        Me.txtApellidoEmpleado.Location = New System.Drawing.Point(85, 137)
        Me.txtApellidoEmpleado.Name = "txtApellidoEmpleado"
        Me.txtApellidoEmpleado.Size = New System.Drawing.Size(178, 20)
        Me.txtApellidoEmpleado.TabIndex = 1
        '
        'txtDNIEmpleado
        '
        Me.txtDNIEmpleado.Location = New System.Drawing.Point(354, 91)
        Me.txtDNIEmpleado.Name = "txtDNIEmpleado"
        Me.txtDNIEmpleado.Size = New System.Drawing.Size(178, 20)
        Me.txtDNIEmpleado.TabIndex = 2
        '
        'txtTelefonoEmpleado
        '
        Me.txtTelefonoEmpleado.Location = New System.Drawing.Point(354, 140)
        Me.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado"
        Me.txtTelefonoEmpleado.Size = New System.Drawing.Size(178, 20)
        Me.txtTelefonoEmpleado.TabIndex = 3
        '
        'cmbTipoEmpleado
        '
        Me.cmbTipoEmpleado.FormattingEnabled = True
        Me.cmbTipoEmpleado.Items.AddRange(New Object() {"Sistemas", "Gerente", "Cajero", "Cocinero", "Mozo - Mediodia", "Mozo - Noche"})
        Me.cmbTipoEmpleado.Location = New System.Drawing.Point(228, 183)
        Me.cmbTipoEmpleado.Name = "cmbTipoEmpleado"
        Me.cmbTipoEmpleado.Size = New System.Drawing.Size(202, 21)
        Me.cmbTipoEmpleado.TabIndex = 4
        '
        'btnCargarEmpleado
        '
        Me.btnCargarEmpleado.Location = New System.Drawing.Point(196, 247)
        Me.btnCargarEmpleado.Name = "btnCargarEmpleado"
        Me.btnCargarEmpleado.Size = New System.Drawing.Size(161, 49)
        Me.btnCargarEmpleado.TabIndex = 5
        Me.btnCargarEmpleado.Text = "CARGAR"
        Me.btnCargarEmpleado.UseVisualStyleBackColor = True
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(12, 95)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreEmpleado.TabIndex = 6
        Me.lblNombreEmpleado.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipo de empleado:"
        '
        'btnVolverCargarEmpleado
        '
        Me.btnVolverCargarEmpleado.Location = New System.Drawing.Point(452, 282)
        Me.btnVolverCargarEmpleado.Name = "btnVolverCargarEmpleado"
        Me.btnVolverCargarEmpleado.Size = New System.Drawing.Size(71, 26)
        Me.btnVolverCargarEmpleado.TabIndex = 11
        Me.btnVolverCargarEmpleado.Text = "VOLVER"
        Me.btnVolverCargarEmpleado.UseVisualStyleBackColor = True
        '
        'lblCargarEmpleado
        '
        Me.lblCargarEmpleado.AutoSize = True
        Me.lblCargarEmpleado.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarEmpleado.Location = New System.Drawing.Point(159, 29)
        Me.lblCargarEmpleado.Name = "lblCargarEmpleado"
        Me.lblCargarEmpleado.Size = New System.Drawing.Size(234, 33)
        Me.lblCargarEmpleado.TabIndex = 12
        Me.lblCargarEmpleado.Text = "Cargar Empleado"
        '
        'frmCargarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(553, 325)
        Me.Controls.Add(Me.lblCargarEmpleado)
        Me.Controls.Add(Me.btnVolverCargarEmpleado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.btnCargarEmpleado)
        Me.Controls.Add(Me.cmbTipoEmpleado)
        Me.Controls.Add(Me.txtTelefonoEmpleado)
        Me.Controls.Add(Me.txtDNIEmpleado)
        Me.Controls.Add(Me.txtApellidoEmpleado)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Name = "frmCargarEmpleado"
        Me.Text = "Cargar Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtDNIEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents btnCargarEmpleado As System.Windows.Forms.Button
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnVolverCargarEmpleado As System.Windows.Forms.Button
    Friend WithEvents lblCargarEmpleado As System.Windows.Forms.Label
End Class
