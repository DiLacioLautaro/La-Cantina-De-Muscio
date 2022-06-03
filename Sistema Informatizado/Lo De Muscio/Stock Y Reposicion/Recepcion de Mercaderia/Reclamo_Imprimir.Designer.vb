<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reclamo_Imprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reclamo_Imprimir))
        Me.lblNroRec = New System.Windows.Forms.Label()
        Me.lblNomProv = New System.Windows.Forms.Label()
        Me.lblNumOC = New System.Windows.Forms.Label()
        Me.lblNumFactura = New System.Windows.Forms.Label()
        Me.txtDescrp = New System.Windows.Forms.TextBox()
        Me.lstConcepto = New System.Windows.Forms.ListBox()
        Me.lstCantidad = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblNroRec
        '
        Me.lblNroRec.AutoSize = True
        Me.lblNroRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroRec.Location = New System.Drawing.Point(199, 68)
        Me.lblNroRec.Name = "lblNroRec"
        Me.lblNroRec.Size = New System.Drawing.Size(51, 15)
        Me.lblNroRec.TabIndex = 1
        Me.lblNroRec.Text = "Label1"
        '
        'lblNomProv
        '
        Me.lblNomProv.AutoSize = True
        Me.lblNomProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProv.Location = New System.Drawing.Point(215, 220)
        Me.lblNomProv.Name = "lblNomProv"
        Me.lblNomProv.Size = New System.Drawing.Size(51, 15)
        Me.lblNomProv.TabIndex = 2
        Me.lblNomProv.Text = "Label1"
        '
        'lblNumOC
        '
        Me.lblNumOC.AutoSize = True
        Me.lblNumOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOC.Location = New System.Drawing.Point(252, 266)
        Me.lblNumOC.Name = "lblNumOC"
        Me.lblNumOC.Size = New System.Drawing.Size(51, 15)
        Me.lblNumOC.TabIndex = 3
        Me.lblNumOC.Text = "Label1"
        '
        'lblNumFactura
        '
        Me.lblNumFactura.AutoSize = True
        Me.lblNumFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFactura.Location = New System.Drawing.Point(199, 314)
        Me.lblNumFactura.Name = "lblNumFactura"
        Me.lblNumFactura.Size = New System.Drawing.Size(39, 15)
        Me.lblNumFactura.TabIndex = 4
        Me.lblNumFactura.Text = "lable"
        '
        'txtDescrp
        '
        Me.txtDescrp.Enabled = False
        Me.txtDescrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrp.Location = New System.Drawing.Point(140, 357)
        Me.txtDescrp.Multiline = True
        Me.txtDescrp.Name = "txtDescrp"
        Me.txtDescrp.ReadOnly = True
        Me.txtDescrp.Size = New System.Drawing.Size(375, 47)
        Me.txtDescrp.TabIndex = 5
        '
        'lstConcepto
        '
        Me.lstConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstConcepto.FormattingEnabled = True
        Me.lstConcepto.ItemHeight = 15
        Me.lstConcepto.Location = New System.Drawing.Point(56, 452)
        Me.lstConcepto.Name = "lstConcepto"
        Me.lstConcepto.Size = New System.Drawing.Size(305, 229)
        Me.lstConcepto.TabIndex = 6
        '
        'lstCantidad
        '
        Me.lstCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCantidad.FormattingEnabled = True
        Me.lstCantidad.ItemHeight = 15
        Me.lstCantidad.Location = New System.Drawing.Point(359, 452)
        Me.lstCantidad.Name = "lstCantidad"
        Me.lstCantidad.Size = New System.Drawing.Size(156, 229)
        Me.lstCantidad.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(455, 699)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 15)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "lable"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(218, 123)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(115, 67)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "IMPRIMIR/VOLVER"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Reclamo_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.RECLAMOPROVEEDOR
        Me.ClientSize = New System.Drawing.Size(570, 743)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstCantidad)
        Me.Controls.Add(Me.lstConcepto)
        Me.Controls.Add(Me.txtDescrp)
        Me.Controls.Add(Me.lblNumFactura)
        Me.Controls.Add(Me.lblNumOC)
        Me.Controls.Add(Me.lblNomProv)
        Me.Controls.Add(Me.lblNroRec)
        Me.Name = "Reclamo_Imprimir"
        Me.Text = "Reclamo_Imprimir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNroRec As System.Windows.Forms.Label
    Friend WithEvents lblNomProv As System.Windows.Forms.Label
    Friend WithEvents lblNumOC As System.Windows.Forms.Label
    Friend WithEvents lblNumFactura As System.Windows.Forms.Label
    Friend WithEvents txtDescrp As System.Windows.Forms.TextBox
    Friend WithEvents lstConcepto As System.Windows.Forms.ListBox
    Friend WithEvents lstCantidad As System.Windows.Forms.ListBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
