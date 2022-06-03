<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSocios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblSocios = New System.Windows.Forms.Label()
        Me.btnAgregarSociobtnAgregarSocio = New System.Windows.Forms.Button()
        Me.btnModSocio = New System.Windows.Forms.Button()
        Me.btnBorrarSocio = New System.Windows.Forms.Button()
        Me.btnCargarMenor = New System.Windows.Forms.Button()
        Me.btnBorrarMenor = New System.Windows.Forms.Button()
        Me.btnVolverSocios = New System.Windows.Forms.Button()
        Me.btnModMenor = New System.Windows.Forms.Button()
        Me.btnPagoCC = New System.Windows.Forms.Button()
        Me.btnMorosos = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblSocios)
        Me.GroupBox1.Controls.Add(Me.btnAgregarSociobtnAgregarSocio)
        Me.GroupBox1.Controls.Add(Me.btnModSocio)
        Me.GroupBox1.Controls.Add(Me.btnBorrarSocio)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(530, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 57)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "REACTIVAR SOCIO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblSocios
        '
        Me.lblSocios.AutoSize = True
        Me.lblSocios.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocios.Location = New System.Drawing.Point(30, 16)
        Me.lblSocios.Name = "lblSocios"
        Me.lblSocios.Size = New System.Drawing.Size(90, 33)
        Me.lblSocios.TabIndex = 1
        Me.lblSocios.Text = "Socios"
        '
        'btnAgregarSociobtnAgregarSocio
        '
        Me.btnAgregarSociobtnAgregarSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSociobtnAgregarSocio.Location = New System.Drawing.Point(21, 65)
        Me.btnAgregarSociobtnAgregarSocio.Name = "btnAgregarSociobtnAgregarSocio"
        Me.btnAgregarSociobtnAgregarSocio.Size = New System.Drawing.Size(145, 57)
        Me.btnAgregarSociobtnAgregarSocio.TabIndex = 4
        Me.btnAgregarSociobtnAgregarSocio.Text = "AGREGAR SOCIO"
        Me.btnAgregarSociobtnAgregarSocio.UseVisualStyleBackColor = True
        '
        'btnModSocio
        '
        Me.btnModSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModSocio.Location = New System.Drawing.Point(193, 65)
        Me.btnModSocio.Name = "btnModSocio"
        Me.btnModSocio.Size = New System.Drawing.Size(145, 57)
        Me.btnModSocio.TabIndex = 9
        Me.btnModSocio.Text = "MODIFICAR INFORMACIÓN DE SOCIO"
        Me.btnModSocio.UseVisualStyleBackColor = True
        '
        'btnBorrarSocio
        '
        Me.btnBorrarSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarSocio.Location = New System.Drawing.Point(358, 65)
        Me.btnBorrarSocio.Name = "btnBorrarSocio"
        Me.btnBorrarSocio.Size = New System.Drawing.Size(145, 57)
        Me.btnBorrarSocio.TabIndex = 5
        Me.btnBorrarSocio.Text = "BORRAR SOCIO"
        Me.btnBorrarSocio.UseVisualStyleBackColor = True
        '
        'btnCargarMenor
        '
        Me.btnCargarMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarMenor.Location = New System.Drawing.Point(23, 65)
        Me.btnCargarMenor.Name = "btnCargarMenor"
        Me.btnCargarMenor.Size = New System.Drawing.Size(145, 57)
        Me.btnCargarMenor.TabIndex = 7
        Me.btnCargarMenor.Text = "AGREGAR AUTORIZACIÓN A MENOR"
        Me.btnCargarMenor.UseVisualStyleBackColor = True
        '
        'btnBorrarMenor
        '
        Me.btnBorrarMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarMenor.Location = New System.Drawing.Point(193, 65)
        Me.btnBorrarMenor.Name = "btnBorrarMenor"
        Me.btnBorrarMenor.Size = New System.Drawing.Size(145, 57)
        Me.btnBorrarMenor.TabIndex = 8
        Me.btnBorrarMenor.Text = "ELIMINAR AUTORIZACIÓN A MENOR"
        Me.btnBorrarMenor.UseVisualStyleBackColor = True
        '
        'btnVolverSocios
        '
        Me.btnVolverSocios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverSocios.Location = New System.Drawing.Point(843, 412)
        Me.btnVolverSocios.Name = "btnVolverSocios"
        Me.btnVolverSocios.Size = New System.Drawing.Size(87, 43)
        Me.btnVolverSocios.TabIndex = 10
        Me.btnVolverSocios.Text = "VOLVER"
        Me.btnVolverSocios.UseVisualStyleBackColor = True
        '
        'btnModMenor
        '
        Me.btnModMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModMenor.Location = New System.Drawing.Point(358, 65)
        Me.btnModMenor.Name = "btnModMenor"
        Me.btnModMenor.Size = New System.Drawing.Size(145, 57)
        Me.btnModMenor.TabIndex = 11
        Me.btnModMenor.Text = "MODIFICAR AUTORIZACIÓN A MENOR"
        Me.btnModMenor.UseVisualStyleBackColor = True
        '
        'btnPagoCC
        '
        Me.btnPagoCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagoCC.Location = New System.Drawing.Point(26, 94)
        Me.btnPagoCC.Name = "btnPagoCC"
        Me.btnPagoCC.Size = New System.Drawing.Size(126, 76)
        Me.btnPagoCC.TabIndex = 12
        Me.btnPagoCC.Text = "PAGO CUENTA CORRIENTE"
        Me.btnPagoCC.UseVisualStyleBackColor = True
        '
        'btnMorosos
        '
        Me.btnMorosos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMorosos.Location = New System.Drawing.Point(26, 190)
        Me.btnMorosos.Name = "btnMorosos"
        Me.btnMorosos.Size = New System.Drawing.Size(126, 76)
        Me.btnMorosos.TabIndex = 13
        Me.btnMorosos.Text = "VER MOROSOS EN CUENTA CORRIENTE"
        Me.btnMorosos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnCargarMenor)
        Me.GroupBox2.Controls.Add(Me.btnModMenor)
        Me.GroupBox2.Controls.Add(Me.btnBorrarMenor)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 138)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Autorizaciones"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnPagoCC)
        Me.GroupBox3.Controls.Add(Me.btnMorosos)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 294)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 66)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuenta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Corriente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 33)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Menu Socios"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.logopequeño__
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox4.Location = New System.Drawing.Point(783, 96)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(148, 138)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox8.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox8.TabIndex = 35
        Me.GroupBox8.TabStop = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(98, 41)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 34
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(97, 23)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 33
        Me.lblUser.Text = "Label1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fecha)
        Me.GroupBox5.Location = New System.Drawing.Point(783, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(18, 16)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(46, 16)
        Me.fecha.TabIndex = 0
        Me.fecha.Text = "fecha"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(383, 30)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(199, 52)
        Me.GroupBox6.TabIndex = 37
        Me.GroupBox6.TabStop = False
        '
        'frmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(956, 476)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnVolverSocios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSocios"
        Me.Text = "Socios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSocios As System.Windows.Forms.Label
    Friend WithEvents btnAgregarSociobtnAgregarSocio As System.Windows.Forms.Button
    Friend WithEvents btnBorrarSocio As System.Windows.Forms.Button
    Friend WithEvents btnCargarMenor As System.Windows.Forms.Button
    Friend WithEvents btnBorrarMenor As System.Windows.Forms.Button
    Friend WithEvents btnModSocio As System.Windows.Forms.Button
    Friend WithEvents btnVolverSocios As System.Windows.Forms.Button
    Friend WithEvents btnModMenor As System.Windows.Forms.Button
    Friend WithEvents btnPagoCC As System.Windows.Forms.Button
    Friend WithEvents btnMorosos As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
End Class
