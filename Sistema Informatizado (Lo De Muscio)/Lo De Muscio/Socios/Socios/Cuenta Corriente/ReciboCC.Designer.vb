﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReciboCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReciboCC))
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblIdRecibo = New System.Windows.Forms.Label()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.lblMonto1 = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(335, 25)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(55, 16)
        Me.lblMonto.TabIndex = 0
        Me.lblMonto.Text = "Label1"
        '
        'lblIdRecibo
        '
        Me.lblIdRecibo.AutoSize = True
        Me.lblIdRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdRecibo.Location = New System.Drawing.Point(136, 25)
        Me.lblIdRecibo.Name = "lblIdRecibo"
        Me.lblIdRecibo.Size = New System.Drawing.Size(55, 16)
        Me.lblIdRecibo.TabIndex = 1
        Me.lblIdRecibo.Text = "Label1"
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocio.Location = New System.Drawing.Point(136, 72)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(55, 16)
        Me.lblSocio.TabIndex = 2
        Me.lblSocio.Text = "Label1"
        '
        'lblMonto1
        '
        Me.lblMonto1.AutoSize = True
        Me.lblMonto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto1.Location = New System.Drawing.Point(198, 124)
        Me.lblMonto1.Name = "lblMonto1"
        Me.lblMonto1.Size = New System.Drawing.Size(55, 16)
        Me.lblMonto1.TabIndex = 3
        Me.lblMonto1.Text = "Label1"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(213, 171)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(55, 16)
        Me.lblConcepto.TabIndex = 4
        Me.lblConcepto.Text = "Label1"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(504, 248)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(55, 16)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Label1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(484, 132)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(145, 26)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "imprimir volver"
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
        'ReciboCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.RECIBO
        Me.ClientSize = New System.Drawing.Size(680, 313)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.lblMonto1)
        Me.Controls.Add(Me.lblSocio)
        Me.Controls.Add(Me.lblIdRecibo)
        Me.Controls.Add(Me.lblMonto)
        Me.Name = "ReciboCC"
        Me.Text = "ReciboCC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblIdRecibo As System.Windows.Forms.Label
    Friend WithEvents lblSocio As System.Windows.Forms.Label
    Friend WithEvents lblMonto1 As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
