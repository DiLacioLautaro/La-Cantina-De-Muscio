<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comanda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comanda))
        Me.lblNumComanda = New System.Windows.Forms.Label()
        Me.lblBlank = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblNumMesa = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lstDescr = New System.Windows.Forms.ListBox()
        Me.lslCantidades = New System.Windows.Forms.ListBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumComanda
        '
        Me.lblNumComanda.AutoSize = True
        Me.lblNumComanda.Location = New System.Drawing.Point(124, 65)
        Me.lblNumComanda.Name = "lblNumComanda"
        Me.lblNumComanda.Size = New System.Drawing.Size(109, 13)
        Me.lblNumComanda.TabIndex = 0
        Me.lblNumComanda.Text = "NUMEROCOMANDA"
        '
        'lblBlank
        '
        Me.lblBlank.AutoSize = True
        Me.lblBlank.BackColor = System.Drawing.Color.Silver
        Me.lblBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlank.Location = New System.Drawing.Point(108, 107)
        Me.lblBlank.Name = "lblBlank"
        Me.lblBlank.Size = New System.Drawing.Size(206, 16)
        Me.lblBlank.TabIndex = 1
        Me.lblBlank.Text = "                                                                  "
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(206, 137)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(93, 137)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "Hora"
        '
        'lblNumMesa
        '
        Me.lblNumMesa.AutoSize = True
        Me.lblNumMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMesa.Location = New System.Drawing.Point(137, 592)
        Me.lblNumMesa.Name = "lblNumMesa"
        Me.lblNumMesa.Size = New System.Drawing.Size(24, 16)
        Me.lblNumMesa.TabIndex = 4
        Me.lblNumMesa.Text = "N°"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(304, 592)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "total"
        '
        'lstDescr
        '
        Me.lstDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDescr.FormattingEnabled = True
        Me.lstDescr.ItemHeight = 15
        Me.lstDescr.Location = New System.Drawing.Point(43, 176)
        Me.lstDescr.Name = "lstDescr"
        Me.lstDescr.Size = New System.Drawing.Size(299, 394)
        Me.lstDescr.TabIndex = 6
        '
        'lslCantidades
        '
        Me.lslCantidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lslCantidades.FormattingEnabled = True
        Me.lslCantidades.ItemHeight = 15
        Me.lslCantidades.Location = New System.Drawing.Point(341, 176)
        Me.lslCantidades.Name = "lslCantidades"
        Me.lslCantidades.Size = New System.Drawing.Size(35, 394)
        Me.lslCantidades.TabIndex = 7
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(43, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(90, 38)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "IMPRIMIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VOLVER"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(344, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cant."
        '
        'Comanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.comandafinishh
        Me.ClientSize = New System.Drawing.Size(426, 634)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lslCantidades)
        Me.Controls.Add(Me.lstDescr)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblNumMesa)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblBlank)
        Me.Controls.Add(Me.lblNumComanda)
        Me.Name = "Comanda"
        Me.Text = "Comanda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumComanda As System.Windows.Forms.Label
    Friend WithEvents lblBlank As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblNumMesa As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lstDescr As System.Windows.Forms.ListBox
    Friend WithEvents lslCantidades As System.Windows.Forms.ListBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
