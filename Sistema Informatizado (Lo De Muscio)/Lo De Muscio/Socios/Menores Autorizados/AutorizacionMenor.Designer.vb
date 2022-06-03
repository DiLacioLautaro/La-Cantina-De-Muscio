<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutorizacionMenor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutorizacionMenor))
        Me.lblAutorizacion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblMayor = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblAutorizacion
        '
        Me.lblAutorizacion.AutoSize = True
        Me.lblAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutorizacion.Location = New System.Drawing.Point(181, 64)
        Me.lblAutorizacion.Name = "lblAutorizacion"
        Me.lblAutorizacion.Size = New System.Drawing.Size(55, 16)
        Me.lblAutorizacion.TabIndex = 0
        Me.lblAutorizacion.Text = "Label1"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(129, 117)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(55, 16)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Label1"
        '
        'lblMayor
        '
        Me.lblMayor.AutoSize = True
        Me.lblMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMayor.Location = New System.Drawing.Point(181, 175)
        Me.lblMayor.Name = "lblMayor"
        Me.lblMayor.Size = New System.Drawing.Size(55, 16)
        Me.lblMayor.TabIndex = 2
        Me.lblMayor.Text = "Label1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(420, 214)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(81, 38)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Volver"
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
        'AutorizacionMenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.AUTORIZACIONMENOREDAD
        Me.ClientSize = New System.Drawing.Size(522, 300)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblMayor)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblAutorizacion)
        Me.Name = "AutorizacionMenor"
        Me.Text = "AutorizacionMenor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAutorizacion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblMayor As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
