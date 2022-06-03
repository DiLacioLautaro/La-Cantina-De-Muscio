<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarCom
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
        Me.dgvIngr = New System.Windows.Forms.DataGridView()
        Me.dgvIngrCom = New System.Windows.Forms.DataGridView()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNombreIngrBusc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCargarComida = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomComida = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPreciocom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvIngr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIngrCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIngr
        '
        Me.dgvIngr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngr.Location = New System.Drawing.Point(72, 81)
        Me.dgvIngr.Name = "dgvIngr"
        Me.dgvIngr.Size = New System.Drawing.Size(444, 192)
        Me.dgvIngr.TabIndex = 0
        '
        'dgvIngrCom
        '
        Me.dgvIngrCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngrCom.Location = New System.Drawing.Point(72, 320)
        Me.dgvIngrCom.Name = "dgvIngrCom"
        Me.dgvIngrCom.Size = New System.Drawing.Size(341, 167)
        Me.dgvIngrCom.TabIndex = 1
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(66, 21)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(204, 33)
        Me.lblMenu.TabIndex = 6
        Me.lblMenu.Text = "Cargar Comida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "1) Seleccione los ingredientes"
        '
        'txtNombreIngrBusc
        '
        Me.txtNombreIngrBusc.Location = New System.Drawing.Point(311, 55)
        Me.txtNombreIngrBusc.Name = "txtNombreIngrBusc"
        Me.txtNombreIngrBusc.Size = New System.Drawing.Size(205, 20)
        Me.txtNombreIngrBusc.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txtNombreIngrBusc, "Ingrese el Nombre del Ingrediente a Buscar!!!")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Los Ingredientes del nuevo plato van a figurar abajo"
        '
        'btnCargarComida
        '
        Me.btnCargarComida.Location = New System.Drawing.Point(536, 543)
        Me.btnCargarComida.Name = "btnCargarComida"
        Me.btnCargarComida.Size = New System.Drawing.Size(88, 33)
        Me.btnCargarComida.TabIndex = 10
        Me.btnCargarComida.Text = "Cargar Plato"
        Me.btnCargarComida.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "2) Ingrese el nombre del plato"
        '
        'txtNomComida
        '
        Me.txtNomComida.Location = New System.Drawing.Point(317, 519)
        Me.txtNomComida.Name = "txtNomComida"
        Me.txtNomComida.Size = New System.Drawing.Size(156, 20)
        Me.txtNomComida.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 568)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "3) Ingrese el precio del plato"
        '
        'txtPreciocom
        '
        Me.txtPreciocom.Location = New System.Drawing.Point(317, 569)
        Me.txtPreciocom.Name = "txtPreciocom"
        Me.txtPreciocom.Size = New System.Drawing.Size(156, 20)
        Me.txtPreciocom.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(295, 569)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "$"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(542, 587)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(82, 30)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmCargarCom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(636, 629)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtNombreIngrBusc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPreciocom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNomComida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCargarComida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.dgvIngrCom)
        Me.Controls.Add(Me.dgvIngr)
        Me.Name = "frmCargarCom"
        Me.Text = "Cargar Comida"
        CType(Me.dgvIngr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIngrCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvIngr As System.Windows.Forms.DataGridView
    Friend WithEvents dgvIngrCom As System.Windows.Forms.DataGridView
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCargarComida As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomComida As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPreciocom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombreIngrBusc As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
