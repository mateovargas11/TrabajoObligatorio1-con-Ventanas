<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEmp
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
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnListados = New System.Windows.Forms.Button()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtPape = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtPnom = New System.Windows.Forms.TextBox()
        Me.txtSape = New System.Windows.Forms.TextBox()
        Me.txtSnom = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.Location = New System.Drawing.Point(330, 237)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(276, 51)
        Me.btnAddEmp.TabIndex = 0
        Me.btnAddEmp.Text = "Agregar empleado"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btnListados
        '
        Me.btnListados.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListados.Location = New System.Drawing.Point(687, 304)
        Me.btnListados.Name = "btnListados"
        Me.btnListados.Size = New System.Drawing.Size(155, 51)
        Me.btnListados.TabIndex = 1
        Me.btnListados.Text = "Listados"
        Me.btnListados.UseVisualStyleBackColor = True
        '
        'cbCargo
        '
        Me.cbCargo.AutoCompleteCustomSource.AddRange(New String() {"Gerente", "Operario", "Administrativo"})
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Items.AddRange(New Object() {"Gerente", "Administrativo", "Operario"})
        Me.cbCargo.Location = New System.Drawing.Point(365, 186)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(169, 21)
        Me.cbCargo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cédula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "1er.Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(538, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "2do.Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "1er.Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "2do.Apellido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(551, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Direccion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cargo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Teléfono:"
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(111, 54)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(151, 20)
        Me.txtCi.TabIndex = 11
        '
        'txtPape
        '
        Me.txtPape.Location = New System.Drawing.Point(111, 119)
        Me.txtPape.Name = "txtPape"
        Me.txtPape.Size = New System.Drawing.Size(151, 20)
        Me.txtPape.TabIndex = 12
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(111, 182)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(151, 20)
        Me.txtTel.TabIndex = 13
        '
        'txtPnom
        '
        Me.txtPnom.Location = New System.Drawing.Point(365, 50)
        Me.txtPnom.Name = "txtPnom"
        Me.txtPnom.Size = New System.Drawing.Size(151, 20)
        Me.txtPnom.TabIndex = 14
        '
        'txtSape
        '
        Me.txtSape.Location = New System.Drawing.Point(365, 115)
        Me.txtSape.Name = "txtSape"
        Me.txtSape.Size = New System.Drawing.Size(151, 20)
        Me.txtSape.TabIndex = 15
        '
        'txtSnom
        '
        Me.txtSnom.Location = New System.Drawing.Point(625, 51)
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.Size = New System.Drawing.Size(151, 20)
        Me.txtSnom.TabIndex = 16
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(625, 119)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(256, 20)
        Me.txtDir.TabIndex = 17
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(625, 187)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(78, 20)
        Me.txtSalario.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Salario:"
        '
        'btnDelEmp
        '
        Me.btnDelEmp.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmp.Location = New System.Drawing.Point(43, 304)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(155, 51)
        Me.btnDelEmp.TabIndex = 20
        Me.btnDelEmp.Text = "Eliminar Empleado"
        Me.btnDelEmp.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(379, 304)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(155, 51)
        Me.btnModif.TabIndex = 21
        Me.btnModif.Text = "Modificar Empleado"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'AddEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 367)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.txtPnom)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtPape)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.btnListados)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Name = "AddEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empelados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddEmp As Button
    Friend WithEvents btnListados As Button
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCi As TextBox
    Friend WithEvents txtPape As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtPnom As TextBox
    Friend WithEvents txtSape As TextBox
    Friend WithEvents txtSnom As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnModif As Button
End Class
