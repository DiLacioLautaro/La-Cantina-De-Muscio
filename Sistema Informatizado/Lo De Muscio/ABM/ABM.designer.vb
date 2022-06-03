<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABM
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
        Me.btnCEmp = New System.Windows.Forms.Button()
        Me.lblMenuABM = New System.Windows.Forms.Label()
        Me.grpEmpleados = New System.Windows.Forms.GroupBox()
        Me.btnBajaEmp = New System.Windows.Forms.Button()
        Me.btnModEmp = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnReacProv = New System.Windows.Forms.Button()
        Me.btnBprov = New System.Windows.Forms.Button()
        Me.btnMproveedor = New System.Windows.Forms.Button()
        Me.btnCargaProv = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBprod = New System.Windows.Forms.Button()
        Me.btnMprod = New System.Windows.Forms.Button()
        Me.btnCprod = New System.Windows.Forms.Button()
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.grpMenuABM = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnModServ = New System.Windows.Forms.Button()
        Me.grpComidas = New System.Windows.Forms.GroupBox()
        Me.btnBorrarCom = New System.Windows.Forms.Button()
        Me.btnModCom = New System.Windows.Forms.Button()
        Me.btnCargarCom = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnBorrarIngr = New System.Windows.Forms.Button()
        Me.btnModIngr = New System.Windows.Forms.Button()
        Me.btnCargarIngr = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCargarMenuDiario = New System.Windows.Forms.Button()
        Me.grpProvIng = New System.Windows.Forms.GroupBox()
        Me.btnBorProvI = New System.Windows.Forms.Button()
        Me.btnCarProvI = New System.Windows.Forms.Button()
        Me.grpProvProd = New System.Windows.Forms.GroupBox()
        Me.btnBorProvP = New System.Windows.Forms.Button()
        Me.btnCarProvP = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.grpEmpleados.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpMenuABM.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpComidas.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpProvIng.SuspendLayout()
        Me.grpProvProd.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCEmp
        '
        Me.btnCEmp.Location = New System.Drawing.Point(6, 19)
        Me.btnCEmp.Name = "btnCEmp"
        Me.btnCEmp.Size = New System.Drawing.Size(75, 44)
        Me.btnCEmp.TabIndex = 0
        Me.btnCEmp.Text = "Cargar"
        Me.btnCEmp.UseVisualStyleBackColor = True
        '
        'lblMenuABM
        '
        Me.lblMenuABM.AutoSize = True
        Me.lblMenuABM.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuABM.Location = New System.Drawing.Point(13, 16)
        Me.lblMenuABM.Name = "lblMenuABM"
        Me.lblMenuABM.Size = New System.Drawing.Size(350, 33)
        Me.lblMenuABM.TabIndex = 1
        Me.lblMenuABM.Text = "Altas, Bajas y Modificaciones"
        '
        'grpEmpleados
        '
        Me.grpEmpleados.Controls.Add(Me.btnBajaEmp)
        Me.grpEmpleados.Controls.Add(Me.btnModEmp)
        Me.grpEmpleados.Controls.Add(Me.btnCEmp)
        Me.grpEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEmpleados.Location = New System.Drawing.Point(21, 102)
        Me.grpEmpleados.Name = "grpEmpleados"
        Me.grpEmpleados.Size = New System.Drawing.Size(245, 69)
        Me.grpEmpleados.TabIndex = 2
        Me.grpEmpleados.TabStop = False
        Me.grpEmpleados.Text = "Empleados"
        '
        'btnBajaEmp
        '
        Me.btnBajaEmp.Location = New System.Drawing.Point(164, 19)
        Me.btnBajaEmp.Name = "btnBajaEmp"
        Me.btnBajaEmp.Size = New System.Drawing.Size(75, 44)
        Me.btnBajaEmp.TabIndex = 2
        Me.btnBajaEmp.Text = "Baja"
        Me.btnBajaEmp.UseVisualStyleBackColor = True
        '
        'btnModEmp
        '
        Me.btnModEmp.Location = New System.Drawing.Point(83, 19)
        Me.btnModEmp.Name = "btnModEmp"
        Me.btnModEmp.Size = New System.Drawing.Size(79, 44)
        Me.btnModEmp.TabIndex = 1
        Me.btnModEmp.Text = "Modificar"
        Me.btnModEmp.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnReacProv)
        Me.GroupBox3.Controls.Add(Me.btnBprov)
        Me.GroupBox3.Controls.Add(Me.btnMproveedor)
        Me.GroupBox3.Controls.Add(Me.btnCargaProv)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 75)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proveedores"
        '
        'btnReacProv
        '
        Me.btnReacProv.Location = New System.Drawing.Point(127, 46)
        Me.btnReacProv.Name = "btnReacProv"
        Me.btnReacProv.Size = New System.Drawing.Size(112, 23)
        Me.btnReacProv.TabIndex = 3
        Me.btnReacProv.Text = "Reactivar"
        Me.btnReacProv.UseVisualStyleBackColor = True
        '
        'btnBprov
        '
        Me.btnBprov.Location = New System.Drawing.Point(6, 46)
        Me.btnBprov.Name = "btnBprov"
        Me.btnBprov.Size = New System.Drawing.Size(115, 23)
        Me.btnBprov.TabIndex = 2
        Me.btnBprov.Text = "Baja"
        Me.btnBprov.UseVisualStyleBackColor = True
        '
        'btnMproveedor
        '
        Me.btnMproveedor.Location = New System.Drawing.Point(127, 19)
        Me.btnMproveedor.Name = "btnMproveedor"
        Me.btnMproveedor.Size = New System.Drawing.Size(112, 23)
        Me.btnMproveedor.TabIndex = 1
        Me.btnMproveedor.Text = "Modificar"
        Me.btnMproveedor.UseVisualStyleBackColor = True
        '
        'btnCargaProv
        '
        Me.btnCargaProv.Location = New System.Drawing.Point(6, 19)
        Me.btnCargaProv.Name = "btnCargaProv"
        Me.btnCargaProv.Size = New System.Drawing.Size(115, 23)
        Me.btnCargaProv.TabIndex = 0
        Me.btnCargaProv.Text = "Cargar"
        Me.btnCargaProv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBprod)
        Me.GroupBox2.Controls.Add(Me.btnMprod)
        Me.GroupBox2.Controls.Add(Me.btnCprod)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(592, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 75)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'btnBprod
        '
        Me.btnBprod.Location = New System.Drawing.Point(164, 19)
        Me.btnBprod.Name = "btnBprod"
        Me.btnBprod.Size = New System.Drawing.Size(75, 50)
        Me.btnBprod.TabIndex = 2
        Me.btnBprod.Text = "Borrar"
        Me.btnBprod.UseVisualStyleBackColor = True
        '
        'btnMprod
        '
        Me.btnMprod.Location = New System.Drawing.Point(83, 19)
        Me.btnMprod.Name = "btnMprod"
        Me.btnMprod.Size = New System.Drawing.Size(79, 50)
        Me.btnMprod.TabIndex = 1
        Me.btnMprod.Text = "Modificar"
        Me.btnMprod.UseVisualStyleBackColor = True
        '
        'btnCprod
        '
        Me.btnCprod.Location = New System.Drawing.Point(6, 19)
        Me.btnCprod.Name = "btnCprod"
        Me.btnCprod.Size = New System.Drawing.Size(75, 50)
        Me.btnCprod.TabIndex = 0
        Me.btnCprod.Text = "Cargar"
        Me.btnCprod.UseVisualStyleBackColor = True
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(323, 396)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(225, 51)
        Me.btnVolverMenuABM.TabIndex = 5
        Me.btnVolverMenuABM.Text = "VOLVER"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'grpMenuABM
        '
        Me.grpMenuABM.Controls.Add(Me.lblMenuABM)
        Me.grpMenuABM.Location = New System.Drawing.Point(244, 12)
        Me.grpMenuABM.Name = "grpMenuABM"
        Me.grpMenuABM.Size = New System.Drawing.Size(369, 59)
        Me.grpMenuABM.TabIndex = 9
        Me.grpMenuABM.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnModServ)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(592, 102)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(245, 69)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Precios Reserva del Salon"
        '
        'btnModServ
        '
        Me.btnModServ.Location = New System.Drawing.Point(6, 19)
        Me.btnModServ.Name = "btnModServ"
        Me.btnModServ.Size = New System.Drawing.Size(233, 44)
        Me.btnModServ.TabIndex = 0
        Me.btnModServ.Text = "Modificar"
        Me.btnModServ.UseVisualStyleBackColor = True
        '
        'grpComidas
        '
        Me.grpComidas.Controls.Add(Me.btnBorrarCom)
        Me.grpComidas.Controls.Add(Me.btnModCom)
        Me.grpComidas.Controls.Add(Me.btnCargarCom)
        Me.grpComidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpComidas.Location = New System.Drawing.Point(305, 191)
        Me.grpComidas.Name = "grpComidas"
        Me.grpComidas.Size = New System.Drawing.Size(255, 75)
        Me.grpComidas.TabIndex = 12
        Me.grpComidas.TabStop = False
        Me.grpComidas.Text = "Comidas"
        '
        'btnBorrarCom
        '
        Me.btnBorrarCom.Location = New System.Drawing.Point(168, 19)
        Me.btnBorrarCom.Name = "btnBorrarCom"
        Me.btnBorrarCom.Size = New System.Drawing.Size(75, 50)
        Me.btnBorrarCom.TabIndex = 3
        Me.btnBorrarCom.Text = "Borrar"
        Me.btnBorrarCom.UseVisualStyleBackColor = True
        '
        'btnModCom
        '
        Me.btnModCom.Location = New System.Drawing.Point(83, 19)
        Me.btnModCom.Name = "btnModCom"
        Me.btnModCom.Size = New System.Drawing.Size(83, 50)
        Me.btnModCom.TabIndex = 4
        Me.btnModCom.Text = "Modificar"
        Me.btnModCom.UseVisualStyleBackColor = True
        '
        'btnCargarCom
        '
        Me.btnCargarCom.Location = New System.Drawing.Point(6, 19)
        Me.btnCargarCom.Name = "btnCargarCom"
        Me.btnCargarCom.Size = New System.Drawing.Size(75, 50)
        Me.btnCargarCom.TabIndex = 3
        Me.btnCargarCom.Text = "Cargar"
        Me.btnCargarCom.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnBorrarIngr)
        Me.GroupBox7.Controls.Add(Me.btnModIngr)
        Me.GroupBox7.Controls.Add(Me.btnCargarIngr)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(305, 102)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(255, 69)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ingredientes"
        '
        'btnBorrarIngr
        '
        Me.btnBorrarIngr.Location = New System.Drawing.Point(168, 20)
        Me.btnBorrarIngr.Name = "btnBorrarIngr"
        Me.btnBorrarIngr.Size = New System.Drawing.Size(81, 43)
        Me.btnBorrarIngr.TabIndex = 2
        Me.btnBorrarIngr.Text = "Borrar"
        Me.btnBorrarIngr.UseVisualStyleBackColor = True
        '
        'btnModIngr
        '
        Me.btnModIngr.Location = New System.Drawing.Point(83, 20)
        Me.btnModIngr.Name = "btnModIngr"
        Me.btnModIngr.Size = New System.Drawing.Size(83, 43)
        Me.btnModIngr.TabIndex = 1
        Me.btnModIngr.Text = "Modificar"
        Me.btnModIngr.UseVisualStyleBackColor = True
        '
        'btnCargarIngr
        '
        Me.btnCargarIngr.Location = New System.Drawing.Point(6, 19)
        Me.btnCargarIngr.Name = "btnCargarIngr"
        Me.btnCargarIngr.Size = New System.Drawing.Size(75, 44)
        Me.btnCargarIngr.TabIndex = 0
        Me.btnCargarIngr.Text = "Cargar"
        Me.btnCargarIngr.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCargarMenuDiario)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 75)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menus Diarios"
        '
        'btnCargarMenuDiario
        '
        Me.btnCargarMenuDiario.Location = New System.Drawing.Point(6, 19)
        Me.btnCargarMenuDiario.Name = "btnCargarMenuDiario"
        Me.btnCargarMenuDiario.Size = New System.Drawing.Size(233, 50)
        Me.btnCargarMenuDiario.TabIndex = 3
        Me.btnCargarMenuDiario.Text = "Cargar/Modificar/Borrar"
        Me.btnCargarMenuDiario.UseVisualStyleBackColor = True
        '
        'grpProvIng
        '
        Me.grpProvIng.Controls.Add(Me.btnBorProvI)
        Me.grpProvIng.Controls.Add(Me.btnCarProvI)
        Me.grpProvIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProvIng.Location = New System.Drawing.Point(592, 291)
        Me.grpProvIng.Name = "grpProvIng"
        Me.grpProvIng.Size = New System.Drawing.Size(255, 75)
        Me.grpProvIng.TabIndex = 16
        Me.grpProvIng.TabStop = False
        Me.grpProvIng.Text = "Ingredientes-Proveedor"
        '
        'btnBorProvI
        '
        Me.btnBorProvI.Location = New System.Drawing.Point(134, 19)
        Me.btnBorProvI.Name = "btnBorProvI"
        Me.btnBorProvI.Size = New System.Drawing.Size(115, 50)
        Me.btnBorProvI.TabIndex = 5
        Me.btnBorProvI.Text = "Borrar"
        Me.btnBorProvI.UseVisualStyleBackColor = True
        '
        'btnCarProvI
        '
        Me.btnCarProvI.Location = New System.Drawing.Point(6, 19)
        Me.btnCarProvI.Name = "btnCarProvI"
        Me.btnCarProvI.Size = New System.Drawing.Size(115, 50)
        Me.btnCarProvI.TabIndex = 5
        Me.btnCarProvI.Text = "Cargar"
        Me.btnCarProvI.UseVisualStyleBackColor = True
        '
        'grpProvProd
        '
        Me.grpProvProd.Controls.Add(Me.btnBorProvP)
        Me.grpProvProd.Controls.Add(Me.btnCarProvP)
        Me.grpProvProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProvProd.Location = New System.Drawing.Point(311, 291)
        Me.grpProvProd.Name = "grpProvProd"
        Me.grpProvProd.Size = New System.Drawing.Size(255, 75)
        Me.grpProvProd.TabIndex = 15
        Me.grpProvProd.TabStop = False
        Me.grpProvProd.Text = "Productos-Proveedor"
        '
        'btnBorProvP
        '
        Me.btnBorProvP.Location = New System.Drawing.Point(137, 19)
        Me.btnBorProvP.Name = "btnBorProvP"
        Me.btnBorProvP.Size = New System.Drawing.Size(112, 50)
        Me.btnBorProvP.TabIndex = 4
        Me.btnBorProvP.Text = "Borrar"
        Me.btnBorProvP.UseVisualStyleBackColor = True
        '
        'btnCarProvP
        '
        Me.btnCarProvP.Location = New System.Drawing.Point(6, 19)
        Me.btnCarProvP.Name = "btnCarProvP"
        Me.btnCarProvP.Size = New System.Drawing.Size(115, 50)
        Me.btnCarProvP.TabIndex = 3
        Me.btnCarProvP.Text = "Cargar"
        Me.btnCarProvP.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.logopequeño__
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox6.Location = New System.Drawing.Point(728, 376)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(119, 81)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.logopequeño__
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox5.Location = New System.Drawing.Point(27, 376)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(119, 81)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = Global.Lo_De_Muscio.My.Resources.Resources.user_icon
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox8.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(63, 71)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(89, 41)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblTipoEmpleado.TabIndex = 31
        Me.lblTipoEmpleado.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(88, 23)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(57, 18)
        Me.lblUser.TabIndex = 30
        Me.lblUser.Text = "Label1"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.fecha)
        Me.GroupBox9.Location = New System.Drawing.Point(700, 22)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox9.TabIndex = 40
        Me.GroupBox9.TabStop = False
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(18, 16)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(46, 16)
        Me.fecha.TabIndex = 0
        Me.fecha.Text = "fecha"
        '
        'frmABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(874, 469)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.grpProvIng)
        Me.Controls.Add(Me.grpProvProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpComidas)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpEmpleados)
        Me.Controls.Add(Me.grpMenuABM)
        Me.Name = "frmABM"
        Me.Text = "Menu ABM"
        Me.grpEmpleados.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grpMenuABM.ResumeLayout(False)
        Me.grpMenuABM.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.grpComidas.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpProvIng.ResumeLayout(False)
        Me.grpProvProd.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCEmp As System.Windows.Forms.Button
    Friend WithEvents lblMenuABM As System.Windows.Forms.Label
    Friend WithEvents grpEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents btnBajaEmp As System.Windows.Forms.Button
    Friend WithEvents btnModEmp As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBprov As System.Windows.Forms.Button
    Friend WithEvents btnMproveedor As System.Windows.Forms.Button
    Friend WithEvents btnCargaProv As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBprod As System.Windows.Forms.Button
    Friend WithEvents btnMprod As System.Windows.Forms.Button
    Friend WithEvents btnCprod As System.Windows.Forms.Button
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents grpMenuABM As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModServ As System.Windows.Forms.Button
    Friend WithEvents grpComidas As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorrarCom As System.Windows.Forms.Button
    Friend WithEvents btnModCom As System.Windows.Forms.Button
    Friend WithEvents btnCargarCom As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorrarIngr As System.Windows.Forms.Button
    Friend WithEvents btnModIngr As System.Windows.Forms.Button
    Friend WithEvents btnCargarIngr As System.Windows.Forms.Button
    Friend WithEvents btnReacProv As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCargarMenuDiario As System.Windows.Forms.Button
    Friend WithEvents grpProvIng As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorProvI As System.Windows.Forms.Button
    Friend WithEvents btnCarProvI As System.Windows.Forms.Button
    Friend WithEvents grpProvProd As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorProvP As System.Windows.Forms.Button
    Friend WithEvents btnCarProvP As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.Label
End Class
