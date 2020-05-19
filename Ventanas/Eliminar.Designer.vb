<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar
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
        Me.gvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.btnVerEmp = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvEmpleados
        '
        Me.gvEmpleados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.gvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvEmpleados.Location = New System.Drawing.Point(12, 198)
        Me.gvEmpleados.Name = "gvEmpleados"
        Me.gvEmpleados.Size = New System.Drawing.Size(947, 94)
        Me.gvEmpleados.TabIndex = 4
        '
        'btnDelEmp
        '
        Me.btnDelEmp.BackColor = System.Drawing.Color.Transparent
        Me.btnDelEmp.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmp.Location = New System.Drawing.Point(596, 64)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(318, 51)
        Me.btnDelEmp.TabIndex = 5
        Me.btnDelEmp.Text = "Eliminar empleado "
        Me.btnDelEmp.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(23, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cédula del empleado a eliminar:"
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(185, 83)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(147, 20)
        Me.txtCi.TabIndex = 7
        '
        'btnVerEmp
        '
        Me.btnVerEmp.BackColor = System.Drawing.Color.Transparent
        Me.btnVerEmp.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerEmp.Location = New System.Drawing.Point(365, 74)
        Me.btnVerEmp.Name = "btnVerEmp"
        Me.btnVerEmp.Size = New System.Drawing.Size(118, 31)
        Me.btnVerEmp.TabIndex = 8
        Me.btnVerEmp.Text = "Ver Empleado"
        Me.btnVerEmp.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(135, 32)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(824, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 32)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(971, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnVerEmp)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.gvEmpleados)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Eliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar"
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvEmpleados As DataGridView
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCi As TextBox
    Friend WithEvents btnVerEmp As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSalir As Button
End Class
