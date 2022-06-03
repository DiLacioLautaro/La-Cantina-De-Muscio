<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservas
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
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumSocio = New System.Windows.Forms.TextBox()
        Me.lstCliente = New System.Windows.Forms.ListBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantHoras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantInv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMontoReserva = New System.Windows.Forms.Label()
        Me.btnCalcularMonto = New System.Windows.Forms.Button()
        Me.btnConfirmarReserva = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(35, 23)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(245, 33)
        Me.lblMenu.TabIndex = 5
        Me.lblMenu.Text = "Reservas De Salon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "1) Ingrese Numero de Socio"
        '
        'txtNumSocio
        '
        Me.txtNumSocio.Location = New System.Drawing.Point(219, 17)
        Me.txtNumSocio.Name = "txtNumSocio"
        Me.txtNumSocio.Size = New System.Drawing.Size(210, 20)
        Me.txtNumSocio.TabIndex = 7
        '
        'lstCliente
        '
        Me.lstCliente.FormattingEnabled = True
        Me.lstCliente.Location = New System.Drawing.Point(16, 43)
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(474, 17)
        Me.lstCliente.TabIndex = 8
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(435, 16)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(55, 22)
        Me.btnCargar.TabIndex = 9
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "2) Ingrese la fecha de reserva"
        '
        'Calendario
        '
        Me.Calendario.Enabled = False
        Me.Calendario.Location = New System.Drawing.Point(14, 30)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 36)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "3) Ingrese la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cantidad de horas"
        '
        'txtCantHoras
        '
        Me.txtCantHoras.Enabled = False
        Me.txtCantHoras.Location = New System.Drawing.Point(167, 12)
        Me.txtCantHoras.Name = "txtCantHoras"
        Me.txtCantHoras.Size = New System.Drawing.Size(49, 20)
        Me.txtCantHoras.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 36)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "4) Ingrese la cantidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de invitados"
        '
        'txtCantInv
        '
        Me.txtCantInv.Enabled = False
        Me.txtCantInv.Location = New System.Drawing.Point(167, 69)
        Me.txtCantInv.Name = "txtCantInv"
        Me.txtCantInv.Size = New System.Drawing.Size(49, 20)
        Me.txtCantInv.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Monto Total"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(142, 106)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(0, 20)
        Me.lblMonto.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Monto Reserva"
        '
        'lblMontoReserva
        '
        Me.lblMontoReserva.AutoSize = True
        Me.lblMontoReserva.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoReserva.Location = New System.Drawing.Point(142, 139)
        Me.lblMontoReserva.Name = "lblMontoReserva"
        Me.lblMontoReserva.Size = New System.Drawing.Size(0, 16)
        Me.lblMontoReserva.TabIndex = 20
        '
        'btnCalcularMonto
        '
        Me.btnCalcularMonto.Enabled = False
        Me.btnCalcularMonto.Location = New System.Drawing.Point(25, 168)
        Me.btnCalcularMonto.Name = "btnCalcularMonto"
        Me.btnCalcularMonto.Size = New System.Drawing.Size(104, 33)
        Me.btnCalcularMonto.TabIndex = 21
        Me.btnCalcularMonto.Text = "Calcular Monto"
        Me.btnCalcularMonto.UseVisualStyleBackColor = True
        '
        'btnConfirmarReserva
        '
        Me.btnConfirmarReserva.Enabled = False
        Me.btnConfirmarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarReserva.Location = New System.Drawing.Point(79, 382)
        Me.btnConfirmarReserva.Name = "btnConfirmarReserva"
        Me.btnConfirmarReserva.Size = New System.Drawing.Size(395, 56)
        Me.btnConfirmarReserva.TabIndex = 22
        Me.btnConfirmarReserva.Text = "CONFIRMAR RESERVA"
        Me.btnConfirmarReserva.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(469, 455)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(71, 46)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Cancelar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reserva"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCargar)
        Me.GroupBox1.Controls.Add(Me.lstCliente)
        Me.GroupBox1.Controls.Add(Me.txtNumSocio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 75)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Calendario)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 221)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCalcularMonto)
        Me.GroupBox3.Controls.Add(Me.lblMontoReserva)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblMonto)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCantInv)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtCantHoras)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(291, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 213)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'Reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 513)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnConfirmarReserva)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "Reservas"
        Me.Text = "Reservas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumSocio As System.Windows.Forms.TextBox
    Friend WithEvents lstCliente As System.Windows.Forms.ListBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCantHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCantInv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMontoReserva As System.Windows.Forms.Label
    Friend WithEvents btnCalcularMonto As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarReserva As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
