<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketFactura
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketFactura))
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstCantidad = New System.Windows.Forms.ListBox()
        Me.lstSubtotal = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblFechaTicket = New System.Windows.Forms.Label()
        Me.lblHoraTicket = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.lblNumTicket = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstPrecio = New System.Windows.Forms.ListBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblv = New System.Windows.Forms.Label()
        Me.lblAbonado = New System.Windows.Forms.Label()
        Me.lblvuelto = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstProductos
        '
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.Location = New System.Drawing.Point(92, 193)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(166, 225)
        Me.lstProductos.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "           Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    LO DE MUSCIO S.A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alvear 7522, Boedo C.A.B.A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NUMERO TICKET:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Imp. Total $"
        '
        'lstCantidad
        '
        Me.lstCantidad.FormattingEnabled = True
        Me.lstCantidad.Location = New System.Drawing.Point(24, 193)
        Me.lstCantidad.Name = "lstCantidad"
        Me.lstCantidad.Size = New System.Drawing.Size(61, 225)
        Me.lstCantidad.TabIndex = 12
        '
        'lstSubtotal
        '
        Me.lstSubtotal.FormattingEnabled = True
        Me.lstSubtotal.Location = New System.Drawing.Point(332, 193)
        Me.lstSubtotal.Name = "lstSubtotal"
        Me.lstSubtotal.Size = New System.Drawing.Size(65, 225)
        Me.lstSubtotal.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(332, 424)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(65, 21)
        Me.TextBox1.TabIndex = 7
        '
        'lblFechaTicket
        '
        Me.lblFechaTicket.AutoSize = True
        Me.lblFechaTicket.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaTicket.Location = New System.Drawing.Point(32, 21)
        Me.lblFechaTicket.Name = "lblFechaTicket"
        Me.lblFechaTicket.Size = New System.Drawing.Size(0, 15)
        Me.lblFechaTicket.TabIndex = 8
        '
        'lblHoraTicket
        '
        Me.lblHoraTicket.AutoSize = True
        Me.lblHoraTicket.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraTicket.Location = New System.Drawing.Point(288, 22)
        Me.lblHoraTicket.Name = "lblHoraTicket"
        Me.lblHoraTicket.Size = New System.Drawing.Size(0, 15)
        Me.lblHoraTicket.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Forma de Pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nro.Socio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(92, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(329, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Subtotal"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Location = New System.Drawing.Point(126, 108)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(45, 13)
        Me.lblFormaPago.TabIndex = 15
        Me.lblFormaPago.Text = "Label10"
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Location = New System.Drawing.Point(330, 110)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(14, 13)
        Me.lblSocio.TabIndex = 16
        Me.lblSocio.Text = "X"
        '
        'lblNumTicket
        '
        Me.lblNumTicket.AutoSize = True
        Me.lblNumTicket.Location = New System.Drawing.Point(142, 142)
        Me.lblNumTicket.Name = "lblNumTicket"
        Me.lblNumTicket.Size = New System.Drawing.Size(0, 13)
        Me.lblNumTicket.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(89, 489)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(252, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "XXXXXXXXX- COPIA CLIENTE -XXXXXXXXX"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(261, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Precio"
        '
        'lstPrecio
        '
        Me.lstPrecio.FormattingEnabled = True
        Me.lstPrecio.Location = New System.Drawing.Point(261, 193)
        Me.lstPrecio.Name = "lstPrecio"
        Me.lstPrecio.Size = New System.Drawing.Size(65, 225)
        Me.lstPrecio.TabIndex = 21
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(23, 431)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(62, 13)
        Me.lbla.TabIndex = 22
        Me.lbla.Text = "Abonado: $"
        Me.lbla.Visible = False
        '
        'lblv
        '
        Me.lblv.AutoSize = True
        Me.lblv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblv.Location = New System.Drawing.Point(23, 451)
        Me.lblv.Name = "lblv"
        Me.lblv.Size = New System.Drawing.Size(63, 15)
        Me.lblv.TabIndex = 23
        Me.lblv.Text = "Vuelto: $"
        Me.lblv.Visible = False
        '
        'lblAbonado
        '
        Me.lblAbonado.AutoSize = True
        Me.lblAbonado.Location = New System.Drawing.Point(92, 431)
        Me.lblAbonado.Name = "lblAbonado"
        Me.lblAbonado.Size = New System.Drawing.Size(62, 13)
        Me.lblAbonado.TabIndex = 24
        Me.lblAbonado.Text = "Abonado: $"
        Me.lblAbonado.Visible = False
        '
        'lblvuelto
        '
        Me.lblvuelto.AutoSize = True
        Me.lblvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvuelto.Location = New System.Drawing.Point(96, 453)
        Me.lblvuelto.Name = "lblvuelto"
        Me.lblvuelto.Size = New System.Drawing.Size(58, 13)
        Me.lblvuelto.TabIndex = 25
        Me.lblvuelto.Text = "Vuelto: $"
        Me.lblvuelto.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(23, 39)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(62, 40)
        Me.btnImprimir.TabIndex = 26
        Me.btnImprimir.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volver"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmTicketFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(421, 523)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblvuelto)
        Me.Controls.Add(Me.lblAbonado)
        Me.Controls.Add(Me.lblv)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.lstPrecio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblNumTicket)
        Me.Controls.Add(Me.lblSocio)
        Me.Controls.Add(Me.lblFormaPago)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblHoraTicket)
        Me.Controls.Add(Me.lblFechaTicket)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstSubtotal)
        Me.Controls.Add(Me.lstCantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstProductos)
        Me.Name = "frmTicketFactura"
        Me.Text = "frmTicketFactura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstProductos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstCantidad As System.Windows.Forms.ListBox
    Friend WithEvents lstSubtotal As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaTicket As System.Windows.Forms.Label
    Friend WithEvents lblHoraTicket As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
    Friend WithEvents lblSocio As System.Windows.Forms.Label
    Friend WithEvents lblNumTicket As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lstPrecio As System.Windows.Forms.ListBox
    Friend WithEvents lbla As System.Windows.Forms.Label
    Friend WithEvents lblv As System.Windows.Forms.Label
    Friend WithEvents lblAbonado As System.Windows.Forms.Label
    Friend WithEvents lblvuelto As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
