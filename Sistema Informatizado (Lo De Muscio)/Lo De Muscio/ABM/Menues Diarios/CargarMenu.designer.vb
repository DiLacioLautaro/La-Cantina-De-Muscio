<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarMenu
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
        Me.lblCargarProd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxDia = New System.Windows.Forms.ComboBox()
        Me.txtBuscarProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvMenuDiario = New System.Windows.Forms.DataGridView()
        Me.txtBuscarCom = New System.Windows.Forms.TextBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.dgvComidas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCargarMenu = New System.Windows.Forms.Button()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenuDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCargarProd
        '
        Me.lblCargarProd.AutoSize = True
        Me.lblCargarProd.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargarProd.Location = New System.Drawing.Point(12, 9)
        Me.lblCargarProd.Name = "lblCargarProd"
        Me.lblCargarProd.Size = New System.Drawing.Size(516, 33)
        Me.lblCargarProd.TabIndex = 15
        Me.lblCargarProd.Text = "Cargar , Modificar , Borrar  Menú Diario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Dia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbxDia
        '
        Me.cbxDia.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDia.FormattingEnabled = True
        Me.cbxDia.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.cbxDia.Location = New System.Drawing.Point(81, 59)
        Me.cbxDia.Name = "cbxDia"
        Me.cbxDia.Size = New System.Drawing.Size(191, 23)
        Me.cbxDia.TabIndex = 17
        '
        'txtBuscarProd
        '
        Me.txtBuscarProd.Location = New System.Drawing.Point(225, 343)
        Me.txtBuscarProd.Name = "txtBuscarProd"
        Me.txtBuscarProd.Size = New System.Drawing.Size(148, 21)
        Me.txtBuscarProd.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 26)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Productos"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Enabled = False
        Me.dgvProductos.Location = New System.Drawing.Point(29, 370)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(344, 175)
        Me.dgvProductos.TabIndex = 49
        '
        'dgvMenuDiario
        '
        Me.dgvMenuDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuDiario.Location = New System.Drawing.Point(444, 126)
        Me.dgvMenuDiario.Name = "dgvMenuDiario"
        Me.dgvMenuDiario.Size = New System.Drawing.Size(340, 419)
        Me.dgvMenuDiario.TabIndex = 46
        '
        'txtBuscarCom
        '
        Me.txtBuscarCom.Location = New System.Drawing.Point(194, 104)
        Me.txtBuscarCom.Name = "txtBuscarCom"
        Me.txtBuscarCom.Size = New System.Drawing.Size(179, 21)
        Me.txtBuscarCom.TabIndex = 45
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(24, 97)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(100, 26)
        Me.lblMenu.TabIndex = 44
        Me.lblMenu.Text = "Comidas"
        '
        'dgvComidas
        '
        Me.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComidas.Enabled = False
        Me.dgvComidas.Location = New System.Drawing.Point(29, 129)
        Me.dgvComidas.Name = "dgvComidas"
        Me.dgvComidas.Size = New System.Drawing.Size(344, 182)
        Me.dgvComidas.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(439, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Menu del Dia:"
        '
        'btnCargarMenu
        '
        Me.btnCargarMenu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarMenu.Location = New System.Drawing.Point(190, 569)
        Me.btnCargarMenu.Name = "btnCargarMenu"
        Me.btnCargarMenu.Size = New System.Drawing.Size(484, 52)
        Me.btnCargarMenu.TabIndex = 53
        Me.btnCargarMenu.Text = "CARGAR MENU"
        Me.btnCargarMenu.UseVisualStyleBackColor = True
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.Location = New System.Drawing.Point(595, 97)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(144, 26)
        Me.lblDia.TabIndex = 54
        Me.lblDia.Text = "Menu del Dia"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(691, 54)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(133, 21)
        Me.txtPrecio.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(606, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Precio $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Nombre "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(398, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(183, 21)
        Me.txtNombre.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(746, 602)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "VOLVER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CargarMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 649)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDia)
        Me.Controls.Add(Me.btnCargarMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscarProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.dgvMenuDiario)
        Me.Controls.Add(Me.txtBuscarCom)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.dgvComidas)
        Me.Controls.Add(Me.cbxDia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCargarProd)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.Name = "CargarMenu"
        Me.Text = "Cargar Menu Diario"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenuDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCargarProd As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxDia As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscarProd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMenuDiario As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscarCom As System.Windows.Forms.TextBox
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents dgvComidas As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCargarMenu As System.Windows.Forms.Button
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
