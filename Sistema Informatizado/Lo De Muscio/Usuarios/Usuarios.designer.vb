<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.btnCambiarPerm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.btnRegUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnVolverUsuarios = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCambiarPerm
        '
        Me.btnCambiarPerm.Enabled = False
        Me.btnCambiarPerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPerm.Location = New System.Drawing.Point(66, 142)
        Me.btnCambiarPerm.Name = "btnCambiarPerm"
        Me.btnCambiarPerm.Size = New System.Drawing.Size(251, 57)
        Me.btnCambiarPerm.TabIndex = 0
        Me.btnCambiarPerm.Text = "CAMBIAR PERMISOS"
        Me.btnCambiarPerm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 63)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.Location = New System.Drawing.Point(24, 16)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(117, 33)
        Me.lblUsuarios.TabIndex = 4
        Me.lblUsuarios.Text = "Usuarios"
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Enabled = False
        Me.btnCambiarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(366, 142)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(245, 57)
        Me.btnCambiarContraseña.TabIndex = 4
        Me.btnCambiarContraseña.Text = "CAMBIAR CONTRASEÑA"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'btnRegUsuario
        '
        Me.btnRegUsuario.Enabled = False
        Me.btnRegUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegUsuario.Location = New System.Drawing.Point(66, 226)
        Me.btnRegUsuario.Name = "btnRegUsuario"
        Me.btnRegUsuario.Size = New System.Drawing.Size(251, 57)
        Me.btnRegUsuario.TabIndex = 5
        Me.btnRegUsuario.Text = "REGISTRAR USUARIO"
        Me.btnRegUsuario.UseVisualStyleBackColor = True
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Enabled = False
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(366, 226)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(245, 57)
        Me.btnEliminarUsuario.TabIndex = 6
        Me.btnEliminarUsuario.Text = "ELIMINAR USUARIO"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'btnVolverUsuarios
        '
        Me.btnVolverUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverUsuarios.Location = New System.Drawing.Point(566, 325)
        Me.btnVolverUsuarios.Name = "btnVolverUsuarios"
        Me.btnVolverUsuarios.Size = New System.Drawing.Size(80, 31)
        Me.btnVolverUsuarios.TabIndex = 7
        Me.btnVolverUsuarios.Text = "VOLVER"
        Me.btnVolverUsuarios.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fecha)
        Me.GroupBox5.Location = New System.Drawing.Point(499, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 40
        Me.GroupBox5.TabStop = False
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(15, 16)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(46, 16)
        Me.fecha.TabIndex = 0
        Me.fecha.Text = "fecha"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox8.Location = New System.Drawing.Point(23, 24)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox8.TabIndex = 43
        Me.GroupBox8.TabStop = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(91, 53)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 42
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(90, 35)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 41
        Me.lblUser.Text = "Label1"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 368)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnVolverUsuarios)
        Me.Controls.Add(Me.btnEliminarUsuario)
        Me.Controls.Add(Me.btnRegUsuario)
        Me.Controls.Add(Me.btnCambiarContraseña)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCambiarPerm)
        Me.Name = "frmUsuarios"
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCambiarPerm As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUsuarios As System.Windows.Forms.Label
    Friend WithEvents btnCambiarContraseña As System.Windows.Forms.Button
    Friend WithEvents btnRegUsuario As System.Windows.Forms.Button
    Friend WithEvents btnEliminarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnVolverUsuarios As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
