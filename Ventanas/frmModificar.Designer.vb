﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificar))
        Me.txtPnom = New System.Windows.Forms.TextBox()
        Me.txtSnom = New System.Windows.Forms.TextBox()
        Me.txtPape = New System.Windows.Forms.TextBox()
        Me.txtSape = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblSape = New System.Windows.Forms.Label()
        Me.lblPape = New System.Windows.Forms.Label()
        Me.lblSnom = New System.Windows.Forms.Label()
        Me.lblPnom = New System.Windows.Forms.Label()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnVerEmp = New System.Windows.Forms.Button()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.dgEmp = New System.Windows.Forms.DataGridView()
        Me.lblSelec = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPnom
        '
        Me.txtPnom.Location = New System.Drawing.Point(122, 275)
        Me.txtPnom.Name = "txtPnom"
        Me.txtPnom.Size = New System.Drawing.Size(147, 20)
        Me.txtPnom.TabIndex = 16
        '
        'txtSnom
        '
        Me.txtSnom.Location = New System.Drawing.Point(122, 335)
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.Size = New System.Drawing.Size(147, 20)
        Me.txtSnom.TabIndex = 17
        '
        'txtPape
        '
        Me.txtPape.Location = New System.Drawing.Point(302, 275)
        Me.txtPape.Name = "txtPape"
        Me.txtPape.Size = New System.Drawing.Size(147, 20)
        Me.txtPape.TabIndex = 18
        '
        'txtSape
        '
        Me.txtSape.Location = New System.Drawing.Point(302, 335)
        Me.txtSape.Name = "txtSape"
        Me.txtSape.Size = New System.Drawing.Size(147, 20)
        Me.txtSape.TabIndex = 19
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(484, 275)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(147, 20)
        Me.txtTel.TabIndex = 20
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(484, 335)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(147, 20)
        Me.txtDir.TabIndex = 21
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(481, 384)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(42, 13)
        Me.lblSalario.TabIndex = 30
        Me.lblSalario.Text = "Salario:"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(481, 259)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(52, 13)
        Me.lblTel.TabIndex = 29
        Me.lblTel.Text = "Teléfono:"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(289, 384)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(38, 13)
        Me.lblCargo.TabIndex = 28
        Me.lblCargo.Text = "Cargo:"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Location = New System.Drawing.Point(481, 319)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(55, 13)
        Me.lblDir.TabIndex = 27
        Me.lblDir.Text = "Direccion:"
        '
        'lblSape
        '
        Me.lblSape.AutoSize = True
        Me.lblSape.Location = New System.Drawing.Point(299, 319)
        Me.lblSape.Name = "lblSape"
        Me.lblSape.Size = New System.Drawing.Size(68, 13)
        Me.lblSape.TabIndex = 26
        Me.lblSape.Text = "2do.Apellido:"
        '
        'lblPape
        '
        Me.lblPape.AutoSize = True
        Me.lblPape.Location = New System.Drawing.Point(302, 259)
        Me.lblPape.Name = "lblPape"
        Me.lblPape.Size = New System.Drawing.Size(65, 13)
        Me.lblPape.TabIndex = 25
        Me.lblPape.Text = "1er.Apellido:"
        '
        'lblSnom
        '
        Me.lblSnom.AutoSize = True
        Me.lblSnom.Location = New System.Drawing.Point(119, 319)
        Me.lblSnom.Name = "lblSnom"
        Me.lblSnom.Size = New System.Drawing.Size(68, 13)
        Me.lblSnom.TabIndex = 24
        Me.lblSnom.Text = "2do.Nombre:"
        '
        'lblPnom
        '
        Me.lblPnom.AutoSize = True
        Me.lblPnom.Location = New System.Drawing.Point(119, 259)
        Me.lblPnom.Name = "lblPnom"
        Me.lblPnom.Size = New System.Drawing.Size(65, 13)
        Me.lblPnom.TabIndex = 23
        Me.lblPnom.Text = "1er.Nombre:"
        '
        'cbCargo
        '
        Me.cbCargo.AutoCompleteCustomSource.AddRange(New String() {"Gerente", "Operario", "Administrativo"})
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Items.AddRange(New Object() {"Gerente", "Administrativo", "Operario"})
        Me.cbCargo.Location = New System.Drawing.Point(292, 404)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(169, 21)
        Me.cbCargo.TabIndex = 22
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(484, 405)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(147, 20)
        Me.txtSalario.TabIndex = 31
        '
        'btnModif
        '
        Me.btnModif.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(7, 387)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(262, 51)
        Me.btnModif.TabIndex = 32
        Me.btnModif.Text = "Modificar empleado"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnVerEmp
        '
        Me.btnVerEmp.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerEmp.Location = New System.Drawing.Point(392, 88)
        Me.btnVerEmp.Name = "btnVerEmp"
        Me.btnVerEmp.Size = New System.Drawing.Size(147, 38)
        Me.btnVerEmp.TabIndex = 13
        Me.btnVerEmp.Text = "Ver Empleado"
        Me.btnVerEmp.UseVisualStyleBackColor = True
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(212, 99)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(147, 20)
        Me.txtCi.TabIndex = 12
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Location = New System.Drawing.Point(36, 102)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(163, 13)
        Me.lblCi.TabIndex = 11
        Me.lblCi.Text = "Cédula del empleado a modificar:"
        '
        'dgEmp
        '
        Me.dgEmp.AllowUserToAddRows = False
        Me.dgEmp.AllowUserToDeleteRows = False
        Me.dgEmp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmp.Location = New System.Drawing.Point(5, 156)
        Me.dgEmp.Name = "dgEmp"
        Me.dgEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgEmp.Size = New System.Drawing.Size(774, 69)
        Me.dgEmp.TabIndex = 33
        '
        'lblSelec
        '
        Me.lblSelec.AutoSize = True
        Me.lblSelec.Enabled = False
        Me.lblSelec.Location = New System.Drawing.Point(2, 140)
        Me.lblSelec.Name = "lblSelec"
        Me.lblSelec.Size = New System.Drawing.Size(279, 13)
        Me.lblSelec.TabIndex = 34
        Me.lblSelec.Text = "Seleccione al empleado para poder acceder a sus datos :"
        Me.lblSelec.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(39, 28)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(135, 32)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        Me.btnVolver.Visible = False
        '
        'frmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(791, 462)
        Me.Controls.Add(Me.lblSelec)
        Me.Controls.Add(Me.dgEmp)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.lblSalario)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblSape)
        Me.Controls.Add(Me.lblPape)
        Me.Controls.Add(Me.lblSnom)
        Me.Controls.Add(Me.lblPnom)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.txtPape)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtPnom)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnVerEmp)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lblCi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Modificar"
        CType(Me.dgEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPnom As Windows.Forms.TextBox
    Friend WithEvents txtSnom As Windows.Forms.TextBox
    Friend WithEvents txtPape As Windows.Forms.TextBox
    Friend WithEvents txtSape As Windows.Forms.TextBox
    Friend WithEvents txtTel As Windows.Forms.TextBox
    Friend WithEvents txtDir As Windows.Forms.TextBox
    Friend WithEvents lblSalario As Windows.Forms.Label
    Friend WithEvents lblTel As Windows.Forms.Label
    Friend WithEvents lblCargo As Windows.Forms.Label
    Friend WithEvents lblDir As Windows.Forms.Label
    Friend WithEvents lblSape As Windows.Forms.Label
    Friend WithEvents lblPape As Windows.Forms.Label
    Friend WithEvents lblSnom As Windows.Forms.Label
    Friend WithEvents lblPnom As Windows.Forms.Label
    Friend WithEvents cbCargo As Windows.Forms.ComboBox
    Friend WithEvents txtSalario As Windows.Forms.TextBox
    Friend WithEvents btnModif As Windows.Forms.Button
    Friend WithEvents btnVerEmp As Button
    Friend WithEvents txtCi As TextBox
    Friend WithEvents lblCi As Label
    Friend WithEvents dgEmp As DataGridView
    Friend WithEvents lblSelec As Label
    Friend WithEvents btnVolver As Button
End Class
