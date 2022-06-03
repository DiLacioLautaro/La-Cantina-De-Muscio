<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenCompra
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
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.dgvIngProd = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.lblIngProd = New System.Windows.Forms.Label()
        Me.dgvDetalleOrden = New System.Windows.Forms.DataGridView()
        Me.lblOccc = New System.Windows.Forms.Label()
        Me.btnOrdenCompra = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTermino = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIngProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedor.Location = New System.Drawing.Point(12, 42)
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.Size = New System.Drawing.Size(428, 187)
        Me.dgvProveedor.TabIndex = 0
        '
        'dgvIngProd
        '
        Me.dgvIngProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvIngProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvIngProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngProd.Location = New System.Drawing.Point(13, 275)
        Me.dgvIngProd.Name = "dgvIngProd"
        Me.dgvIngProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvIngProd.Size = New System.Drawing.Size(428, 248)
        Me.dgvIngProd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "GENERAR ORDEN DE COMPRA"
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProv.Location = New System.Drawing.Point(6, 10)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(254, 29)
        Me.lblProv.TabIndex = 24
        Me.lblProv.Text = "Seleccione Proveedor"
        '
        'lblIngProd
        '
        Me.lblIngProd.AutoSize = True
        Me.lblIngProd.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngProd.Location = New System.Drawing.Point(7, 243)
        Me.lblIngProd.Name = "lblIngProd"
        Me.lblIngProd.Size = New System.Drawing.Size(363, 29)
        Me.lblIngProd.TabIndex = 25
        Me.lblIngProd.Text = "Ingredientes / Productos en PP"
        '
        'dgvDetalleOrden
        '
        Me.dgvDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDetalleOrden.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrden.Location = New System.Drawing.Point(13, 43)
        Me.dgvDetalleOrden.Name = "dgvDetalleOrden"
        Me.dgvDetalleOrden.Size = New System.Drawing.Size(382, 338)
        Me.dgvDetalleOrden.TabIndex = 26
        '
        'lblOccc
        '
        Me.lblOccc.AutoSize = True
        Me.lblOccc.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccc.Location = New System.Drawing.Point(3, 11)
        Me.lblOccc.Name = "lblOccc"
        Me.lblOccc.Size = New System.Drawing.Size(214, 29)
        Me.lblOccc.TabIndex = 27
        Me.lblOccc.Text = "Orden de Compra"
        '
        'btnOrdenCompra
        '
        Me.btnOrdenCompra.Enabled = False
        Me.btnOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenCompra.Location = New System.Drawing.Point(23, 46)
        Me.btnOrdenCompra.Name = "btnOrdenCompra"
        Me.btnOrdenCompra.Size = New System.Drawing.Size(372, 48)
        Me.btnOrdenCompra.TabIndex = 28
        Me.btnOrdenCompra.Text = "GENERAR ORDEN DE COMPRA"
        Me.btnOrdenCompra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Termino:"
        '
        'txtTermino
        '
        Me.txtTermino.Location = New System.Drawing.Point(121, 19)
        Me.txtTermino.Name = "txtTermino"
        Me.txtTermino.Size = New System.Drawing.Size(274, 20)
        Me.txtTermino.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 29)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "TOTAL: $"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(111, 392)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 29)
        Me.lblTotal.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(748, 611)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 33)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "CANCELAR / VOLVER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTermino)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnOrdenCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(476, 496)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 109)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblOccc)
        Me.GroupBox2.Controls.Add(Me.dgvDetalleOrden)
        Me.GroupBox2.Location = New System.Drawing.Point(476, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(414, 427)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblIngProd)
        Me.GroupBox3.Controls.Add(Me.lblProv)
        Me.GroupBox3.Controls.Add(Me.dgvIngProd)
        Me.GroupBox3.Controls.Add(Me.dgvProveedor)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(448, 538)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'OrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 659)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "OrdenCompra"
        Me.Text = "OrdenCompra"
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIngProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents dgvIngProd As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProv As System.Windows.Forms.Label
    Friend WithEvents lblIngProd As System.Windows.Forms.Label
    Friend WithEvents dgvDetalleOrden As System.Windows.Forms.DataGridView
    Friend WithEvents lblOccc As System.Windows.Forms.Label
    Friend WithEvents btnOrdenCompra As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTermino As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
