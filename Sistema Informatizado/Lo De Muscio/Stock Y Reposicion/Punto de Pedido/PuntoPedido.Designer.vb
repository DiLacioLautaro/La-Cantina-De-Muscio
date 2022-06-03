<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuntoPedido
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
        Me.dgvIngPP = New System.Windows.Forms.DataGridView()
        Me.dgvProdPP = New System.Windows.Forms.DataGridView()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstProv = New System.Windows.Forms.ListBox()
        Me.lstprecios = New System.Windows.Forms.ListBox()
        Me.lblCosa = New System.Windows.Forms.Label()
        CType(Me.dgvIngPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIngPP
        '
        Me.dgvIngPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngPP.Location = New System.Drawing.Point(12, 104)
        Me.dgvIngPP.Name = "dgvIngPP"
        Me.dgvIngPP.Size = New System.Drawing.Size(323, 286)
        Me.dgvIngPP.TabIndex = 0
        '
        'dgvProdPP
        '
        Me.dgvProdPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdPP.Location = New System.Drawing.Point(351, 104)
        Me.dgvProdPP.Name = "dgvProdPP"
        Me.dgvProdPP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvProdPP.Size = New System.Drawing.Size(314, 286)
        Me.dgvProdPP.TabIndex = 1
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(7, 72)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(289, 29)
        Me.lblMenu.TabIndex = 20
        Me.lblMenu.Text = "Ingredientes menor a PP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Productos menor a PP"
        '
        'lst
        '
        Me.lst.AutoSize = True
        Me.lst.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst.Location = New System.Drawing.Point(25, 18)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(240, 29)
        Me.lst.TabIndex = 22
        Me.lst.Text = "PUNTO DE PEDIDO"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(848, 409)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(106, 38)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(676, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Proveedores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(863, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Precios"
        '
        'lstProv
        '
        Me.lstProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProv.FormattingEnabled = True
        Me.lstProv.ItemHeight = 16
        Me.lstProv.Location = New System.Drawing.Point(680, 104)
        Me.lstProv.Name = "lstProv"
        Me.lstProv.Size = New System.Drawing.Size(181, 276)
        Me.lstProv.TabIndex = 26
        '
        'lstprecios
        '
        Me.lstprecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstprecios.FormattingEnabled = True
        Me.lstprecios.ItemHeight = 16
        Me.lstprecios.Location = New System.Drawing.Point(867, 104)
        Me.lstprecios.Name = "lstprecios"
        Me.lstprecios.Size = New System.Drawing.Size(87, 276)
        Me.lstprecios.TabIndex = 27
        '
        'lblCosa
        '
        Me.lblCosa.AutoSize = True
        Me.lblCosa.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosa.Location = New System.Drawing.Point(675, 29)
        Me.lblCosa.Name = "lblCosa"
        Me.lblCosa.Size = New System.Drawing.Size(240, 29)
        Me.lblCosa.TabIndex = 28
        Me.lblCosa.Text = "PUNTO DE PEDIDO"
        Me.lblCosa.Visible = False
        '
        'PuntoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(968, 463)
        Me.Controls.Add(Me.lblCosa)
        Me.Controls.Add(Me.lstprecios)
        Me.Controls.Add(Me.lstProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.dgvProdPP)
        Me.Controls.Add(Me.dgvIngPP)
        Me.Name = "PuntoPedido"
        Me.Text = "Punto Pedido"
        CType(Me.dgvIngPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvIngPP As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProdPP As System.Windows.Forms.DataGridView
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lst As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstProv As System.Windows.Forms.ListBox
    Friend WithEvents lstprecios As System.Windows.Forms.ListBox
    Friend WithEvents lblCosa As System.Windows.Forms.Label
End Class
