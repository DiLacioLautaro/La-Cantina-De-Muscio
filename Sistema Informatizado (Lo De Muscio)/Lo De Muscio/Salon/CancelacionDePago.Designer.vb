<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelacionDePago
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
        Me.txtNumComprob = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMontoTotal = New System.Windows.Forms.Label()
        Me.lblMontoReserva = New System.Windows.Forms.Label()
        Me.lblRestanteAPagar = New System.Windows.Forms.Label()
        Me.btnConfirmarCancelacion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(14, 19)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(367, 33)
        Me.lblMenu.TabIndex = 6
        Me.lblMenu.Text = "Cancelacion De Pago - Salon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "1) Ingrese el Nro de comprobante de reserva a pagar"
        '
        'txtNumComprob
        '
        Me.txtNumComprob.Location = New System.Drawing.Point(18, 34)
        Me.txtNumComprob.Name = "txtNumComprob"
        Me.txtNumComprob.Size = New System.Drawing.Size(240, 20)
        Me.txtNumComprob.TabIndex = 8
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(278, 34)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(85, 23)
        Me.btnVerificar.TabIndex = 9
        Me.btnVerificar.Text = " Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 22)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Restante A Pagar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(37, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Monto Ya Pagado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(125, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(14, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "---------------------------------------"
        '
        'lblMontoTotal
        '
        Me.lblMontoTotal.AutoSize = True
        Me.lblMontoTotal.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoTotal.Location = New System.Drawing.Point(189, 87)
        Me.lblMontoTotal.Name = "lblMontoTotal"
        Me.lblMontoTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblMontoTotal.TabIndex = 22
        '
        'lblMontoReserva
        '
        Me.lblMontoReserva.AutoSize = True
        Me.lblMontoReserva.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoReserva.Location = New System.Drawing.Point(189, 116)
        Me.lblMontoReserva.Name = "lblMontoReserva"
        Me.lblMontoReserva.Size = New System.Drawing.Size(0, 20)
        Me.lblMontoReserva.TabIndex = 23
        '
        'lblRestanteAPagar
        '
        Me.lblRestanteAPagar.AutoSize = True
        Me.lblRestanteAPagar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestanteAPagar.Location = New System.Drawing.Point(189, 156)
        Me.lblRestanteAPagar.Name = "lblRestanteAPagar"
        Me.lblRestanteAPagar.Size = New System.Drawing.Size(0, 20)
        Me.lblRestanteAPagar.TabIndex = 24
        '
        'btnConfirmarCancelacion
        '
        Me.btnConfirmarCancelacion.Enabled = False
        Me.btnConfirmarCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarCancelacion.Location = New System.Drawing.Point(45, 267)
        Me.btnConfirmarCancelacion.Name = "btnConfirmarCancelacion"
        Me.btnConfirmarCancelacion.Size = New System.Drawing.Size(345, 48)
        Me.btnConfirmarCancelacion.TabIndex = 25
        Me.btnConfirmarCancelacion.Text = "CONFIRMAR CANCELACION DE PAGO"
        Me.btnConfirmarCancelacion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(348, 334)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(83, 29)
        Me.btnVolver.TabIndex = 26
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRestanteAPagar)
        Me.GroupBox1.Controls.Add(Me.lblMontoReserva)
        Me.GroupBox1.Controls.Add(Me.lblMontoTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.txtNumComprob)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 187)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'CancelacionDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnConfirmarCancelacion)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "CancelacionDePago"
        Me.Text = "Cancelacion De Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumComprob As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMontoTotal As System.Windows.Forms.Label
    Friend WithEvents lblMontoReserva As System.Windows.Forms.Label
    Friend WithEvents lblRestanteAPagar As System.Windows.Forms.Label
    Friend WithEvents btnConfirmarCancelacion As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
