<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBagregar = New System.Windows.Forms.ToolStripButton()
        Me.TSBmodificar = New System.Windows.Forms.ToolStripButton()
        Me.TSBlistar = New System.Windows.Forms.ToolStripButton()
        Me.TSBeliminar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1116, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEmpleadoToolStripMenuItem, Me.ModificarEmpleadoToolStripMenuItem, Me.EliminarEmpleadoToolStripMenuItem, Me.ListarEmpleadosToolStripMenuItem})
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'AgregarEmpleadoToolStripMenuItem
        '
        Me.AgregarEmpleadoToolStripMenuItem.Name = "AgregarEmpleadoToolStripMenuItem"
        Me.AgregarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AgregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado"
        '
        'ModificarEmpleadoToolStripMenuItem
        '
        Me.ModificarEmpleadoToolStripMenuItem.Name = "ModificarEmpleadoToolStripMenuItem"
        Me.ModificarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ModificarEmpleadoToolStripMenuItem.Text = "Modificar Empleado"
        '
        'EliminarEmpleadoToolStripMenuItem
        '
        Me.EliminarEmpleadoToolStripMenuItem.Name = "EliminarEmpleadoToolStripMenuItem"
        Me.EliminarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado"
        '
        'ListarEmpleadosToolStripMenuItem
        '
        Me.ListarEmpleadosToolStripMenuItem.Name = "ListarEmpleadosToolStripMenuItem"
        Me.ListarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListarEmpleadosToolStripMenuItem.Text = "Listar Empleados"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBagregar, Me.TSBmodificar, Me.TSBlistar, Me.TSBeliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1116, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBagregar
        '
        Me.TSBagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBagregar.Image = CType(resources.GetObject("TSBagregar.Image"), System.Drawing.Image)
        Me.TSBagregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBagregar.Name = "TSBagregar"
        Me.TSBagregar.Size = New System.Drawing.Size(23, 22)
        Me.TSBagregar.Text = "Ingresar Empleado"
        '
        'TSBmodificar
        '
        Me.TSBmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBmodificar.Image = CType(resources.GetObject("TSBmodificar.Image"), System.Drawing.Image)
        Me.TSBmodificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBmodificar.Name = "TSBmodificar"
        Me.TSBmodificar.Size = New System.Drawing.Size(23, 22)
        Me.TSBmodificar.ToolTipText = "Modificar Empleado"
        '
        'TSBlistar
        '
        Me.TSBlistar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBlistar.Image = CType(resources.GetObject("TSBlistar.Image"), System.Drawing.Image)
        Me.TSBlistar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBlistar.Name = "TSBlistar"
        Me.TSBlistar.Size = New System.Drawing.Size(23, 22)
        Me.TSBlistar.Text = "Listar Empleados"
        '
        'TSBeliminar
        '
        Me.TSBeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBeliminar.Image = CType(resources.GetObject("TSBeliminar.Image"), System.Drawing.Image)
        Me.TSBeliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBeliminar.Name = "TSBeliminar"
        Me.TSBeliminar.Size = New System.Drawing.Size(23, 22)
        Me.TSBeliminar.Text = "Eliminar Empleado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnElim)
        Me.Panel1.Controls.Add(Me.btnListar)
        Me.Panel1.Controls.Add(Me.btnModif)
        Me.Panel1.Controls.Add(Me.btnAddEmp)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 505)
        Me.Panel1.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(3, 449)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(57, 53)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnElim
        '
        Me.btnElim.FlatAppearance.BorderSize = 0
        Me.btnElim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElim.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElim.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnElim.Image = CType(resources.GetObject("btnElim.Image"), System.Drawing.Image)
        Me.btnElim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElim.Location = New System.Drawing.Point(12, 348)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(215, 40)
        Me.btnElim.TabIndex = 4
        Me.btnElim.Text = "Eliminar Empleado"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.FlatAppearance.BorderSize = 0
        Me.btnListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListar.Image = CType(resources.GetObject("btnListar.Image"), System.Drawing.Image)
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(12, 280)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(215, 40)
        Me.btnListar.TabIndex = 3
        Me.btnListar.Text = "Listar Empleados"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.FlatAppearance.BorderSize = 0
        Me.btnModif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnModif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModif.Image = CType(resources.GetObject("btnModif.Image"), System.Drawing.Image)
        Me.btnModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModif.Location = New System.Drawing.Point(12, 212)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(215, 40)
        Me.btnModif.TabIndex = 2
        Me.btnModif.Text = "Modificar Empleado"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.FlatAppearance.BorderSize = 0
        Me.btnAddEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddEmp.Image = CType(resources.GetObject("btnAddEmp.Image"), System.Drawing.Image)
        Me.btnAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmp.Location = New System.Drawing.Point(12, 148)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(215, 40)
        Me.btnAddEmp.TabIndex = 1
        Me.btnAddEmp.Text = "Agregar Empleado"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1116, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de gestion de empleados"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBagregar As ToolStripButton
    Friend WithEvents TSBmodificar As ToolStripButton
    Friend WithEvents TSBlistar As ToolStripButton
    Friend WithEvents TSBeliminar As ToolStripButton
    Friend WithEvents AgregarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents btnElim As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents btnSalir As Button
End Class
