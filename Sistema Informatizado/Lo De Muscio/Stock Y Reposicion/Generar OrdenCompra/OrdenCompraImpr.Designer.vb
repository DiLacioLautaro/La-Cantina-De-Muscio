<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenCompraImpr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenCompraImpr))
        Me.lblNroOrd = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblFechaPed = New System.Windows.Forms.Label()
        Me.lblTermEntr = New System.Windows.Forms.Label()
        Me.lstConcepto = New System.Windows.Forms.ListBox()
        Me.lstCantidad = New System.Windows.Forms.ListBox()
        Me.lstPrecio = New System.Windows.Forms.ListBox()
        Me.lstPrecioTotal = New System.Windows.Forms.ListBox()
        Me.lblTOTAL = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblNroOrd
        '
        Me.lblNroOrd.AutoSize = True
        Me.lblNroOrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroOrd.Location = New System.Drawing.Point(131, 19)
        Me.lblNroOrd.Name = "lblNroOrd"
        Me.lblNroOrd.Size = New System.Drawing.Size(45, 13)
        Me.lblNroOrd.TabIndex = 0
        Me.lblNroOrd.Text = "Label1"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(90, 126)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(51, 15)
        Me.lblProveedor.TabIndex = 1
        Me.lblProveedor.Text = "Label1"
        '
        'lblFechaPed
        '
        Me.lblFechaPed.AutoSize = True
        Me.lblFechaPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPed.Location = New System.Drawing.Point(125, 152)
        Me.lblFechaPed.Name = "lblFechaPed"
        Me.lblFechaPed.Size = New System.Drawing.Size(51, 15)
        Me.lblFechaPed.TabIndex = 2
        Me.lblFechaPed.Text = "Label1"
        '
        'lblTermEntr
        '
        Me.lblTermEntr.AutoSize = True
        Me.lblTermEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTermEntr.Location = New System.Drawing.Point(140, 176)
        Me.lblTermEntr.Name = "lblTermEntr"
        Me.lblTermEntr.Size = New System.Drawing.Size(51, 15)
        Me.lblTermEntr.TabIndex = 3
        Me.lblTermEntr.Text = "Label1"
        '
        'lstConcepto
        '
        Me.lstConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstConcepto.FormattingEnabled = True
        Me.lstConcepto.ItemHeight = 15
        Me.lstConcepto.Location = New System.Drawing.Point(23, 217)
        Me.lstConcepto.Name = "lstConcepto"
        Me.lstConcepto.Size = New System.Drawing.Size(190, 274)
        Me.lstConcepto.TabIndex = 4
        '
        'lstCantidad
        '
        Me.lstCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCantidad.FormattingEnabled = True
        Me.lstCantidad.ItemHeight = 15
        Me.lstCantidad.Location = New System.Drawing.Point(210, 217)
        Me.lstCantidad.Name = "lstCantidad"
        Me.lstCantidad.Size = New System.Drawing.Size(80, 274)
        Me.lstCantidad.TabIndex = 5
        '
        'lstPrecio
        '
        Me.lstPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrecio.FormattingEnabled = True
        Me.lstPrecio.ItemHeight = 15
        Me.lstPrecio.Location = New System.Drawing.Point(287, 217)
        Me.lstPrecio.Name = "lstPrecio"
        Me.lstPrecio.Size = New System.Drawing.Size(108, 274)
        Me.lstPrecio.TabIndex = 6
        '
        'lstPrecioTotal
        '
        Me.lstPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrecioTotal.FormattingEnabled = True
        Me.lstPrecioTotal.ItemHeight = 15
        Me.lstPrecioTotal.Location = New System.Drawing.Point(390, 217)
        Me.lstPrecioTotal.Name = "lstPrecioTotal"
        Me.lstPrecioTotal.Size = New System.Drawing.Size(107, 274)
        Me.lstPrecioTotal.TabIndex = 7
        '
        'lblTOTAL
        '
        Me.lblTOTAL.AutoSize = True
        Me.lblTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOTAL.Location = New System.Drawing.Point(399, 507)
        Me.lblTOTAL.Name = "lblTOTAL"
        Me.lblTOTAL.Size = New System.Drawing.Size(51, 15)
        Me.lblTOTAL.TabIndex = 8
        Me.lblTOTAL.Text = "Label1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(250, 43)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 50)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "IMPRIMIR / VOLVER"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(253, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1----------"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'OrdenCompraImpr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.OrdenCompraChico
        Me.ClientSize = New System.Drawing.Size(525, 565)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTOTAL)
        Me.Controls.Add(Me.lstPrecioTotal)
        Me.Controls.Add(Me.lstPrecio)
        Me.Controls.Add(Me.lstCantidad)
        Me.Controls.Add(Me.lstConcepto)
        Me.Controls.Add(Me.lblTermEntr)
        Me.Controls.Add(Me.lblFechaPed)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.lblNroOrd)
        Me.Name = "OrdenCompraImpr"
        Me.Text = "OrdenCompraImpr"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNroOrd As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents lblFechaPed As System.Windows.Forms.Label
    Friend WithEvents lblTermEntr As System.Windows.Forms.Label
    Friend WithEvents lstConcepto As System.Windows.Forms.ListBox
    Friend WithEvents lstCantidad As System.Windows.Forms.ListBox
    Friend WithEvents lstPrecio As System.Windows.Forms.ListBox
    Friend WithEvents lstPrecioTotal As System.Windows.Forms.ListBox
    Friend WithEvents lblTOTAL As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
