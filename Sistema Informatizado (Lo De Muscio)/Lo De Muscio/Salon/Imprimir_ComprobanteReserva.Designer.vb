<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir_ComprobanteReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimir_ComprobanteReserva))
        Me.lblIdSocio = New System.Windows.Forms.Label()
        Me.lblNombreSocio = New System.Windows.Forms.Label()
        Me.lblFechareserva = New System.Windows.Forms.Label()
        Me.lblMontoReserva = New System.Windows.Forms.Label()
        Me.lblFechaevento = New System.Windows.Forms.Label()
        Me.lblMontoTotal = New System.Windows.Forms.Label()
        Me.lblIDCOMPROBANTE = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimirYVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIdSocio
        '
        Me.lblIdSocio.AutoSize = True
        Me.lblIdSocio.Location = New System.Drawing.Point(126, 134)
        Me.lblIdSocio.Name = "lblIdSocio"
        Me.lblIdSocio.Size = New System.Drawing.Size(0, 13)
        Me.lblIdSocio.TabIndex = 0
        '
        'lblNombreSocio
        '
        Me.lblNombreSocio.AutoSize = True
        Me.lblNombreSocio.Location = New System.Drawing.Point(244, 178)
        Me.lblNombreSocio.Name = "lblNombreSocio"
        Me.lblNombreSocio.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreSocio.TabIndex = 1
        '
        'lblFechareserva
        '
        Me.lblFechareserva.AutoSize = True
        Me.lblFechareserva.Location = New System.Drawing.Point(154, 224)
        Me.lblFechareserva.Name = "lblFechareserva"
        Me.lblFechareserva.Size = New System.Drawing.Size(0, 13)
        Me.lblFechareserva.TabIndex = 2
        '
        'lblMontoReserva
        '
        Me.lblMontoReserva.AutoSize = True
        Me.lblMontoReserva.Location = New System.Drawing.Point(154, 259)
        Me.lblMontoReserva.Name = "lblMontoReserva"
        Me.lblMontoReserva.Size = New System.Drawing.Size(0, 13)
        Me.lblMontoReserva.TabIndex = 3
        '
        'lblFechaevento
        '
        Me.lblFechaevento.AutoSize = True
        Me.lblFechaevento.Location = New System.Drawing.Point(344, 224)
        Me.lblFechaevento.Name = "lblFechaevento"
        Me.lblFechaevento.Size = New System.Drawing.Size(0, 13)
        Me.lblFechaevento.TabIndex = 4
        '
        'lblMontoTotal
        '
        Me.lblMontoTotal.AutoSize = True
        Me.lblMontoTotal.Location = New System.Drawing.Point(344, 259)
        Me.lblMontoTotal.Name = "lblMontoTotal"
        Me.lblMontoTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblMontoTotal.TabIndex = 5
        '
        'lblIDCOMPROBANTE
        '
        Me.lblIDCOMPROBANTE.AutoSize = True
        Me.lblIDCOMPROBANTE.Location = New System.Drawing.Point(205, 25)
        Me.lblIDCOMPROBANTE.Name = "lblIDCOMPROBANTE"
        Me.lblIDCOMPROBANTE.Size = New System.Drawing.Size(0, 13)
        Me.lblIDCOMPROBANTE.TabIndex = 6
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimirYVolver
        '
        Me.btnImprimirYVolver.Location = New System.Drawing.Point(332, 52)
        Me.btnImprimirYVolver.Name = "btnImprimirYVolver"
        Me.btnImprimirYVolver.Size = New System.Drawing.Size(109, 43)
        Me.btnImprimirYVolver.TabIndex = 7
        Me.btnImprimirYVolver.Text = "Imprimir y Volver"
        Me.btnImprimirYVolver.UseVisualStyleBackColor = True
        '
        'Imprimir_ComprobanteReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(475, 663)
        Me.Controls.Add(Me.btnImprimirYVolver)
        Me.Controls.Add(Me.lblIDCOMPROBANTE)
        Me.Controls.Add(Me.lblMontoTotal)
        Me.Controls.Add(Me.lblFechaevento)
        Me.Controls.Add(Me.lblMontoReserva)
        Me.Controls.Add(Me.lblFechareserva)
        Me.Controls.Add(Me.lblNombreSocio)
        Me.Controls.Add(Me.lblIdSocio)
        Me.Name = "Imprimir_ComprobanteReserva"
        Me.Text = "Imprimir_ComprobanteReserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdSocio As System.Windows.Forms.Label
    Friend WithEvents lblNombreSocio As System.Windows.Forms.Label
    Friend WithEvents lblFechareserva As System.Windows.Forms.Label
    Friend WithEvents lblMontoReserva As System.Windows.Forms.Label
    Friend WithEvents lblFechaevento As System.Windows.Forms.Label
    Friend WithEvents lblMontoTotal As System.Windows.Forms.Label
    Friend WithEvents lblIDCOMPROBANTE As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimirYVolver As System.Windows.Forms.Button
End Class
