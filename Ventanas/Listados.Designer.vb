<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Listados
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
        Me.btnListar = New System.Windows.Forms.Button()
        Me.gvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoListado = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnTotalPagar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListar
        '
        Me.btnListar.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(559, 54)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(155, 51)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "Cargar grilla"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'gvEmpleados
        '
        Me.gvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvEmpleados.Location = New System.Drawing.Point(12, 191)
        Me.gvEmpleados.Name = "gvEmpleados"
        Me.gvEmpleados.Size = New System.Drawing.Size(948, 247)
        Me.gvEmpleados.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccionar criterio de listado:"
        '
        'cbTipoListado
        '
        Me.cbTipoListado.FormattingEnabled = True
        Me.cbTipoListado.Items.AddRange(New Object() {"Todos", "Operarios", "Gerentes", "Administrativos"})
        Me.cbTipoListado.Location = New System.Drawing.Point(313, 71)
        Me.cbTipoListado.Name = "cbTipoListado"
        Me.cbTipoListado.Size = New System.Drawing.Size(206, 21)
        Me.cbTipoListado.TabIndex = 5
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(16, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(135, 32)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(819, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 32)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnTotalPagar
        '
        Me.btnTotalPagar.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalPagar.Location = New System.Drawing.Point(559, 122)
        Me.btnTotalPagar.Name = "btnTotalPagar"
        Me.btnTotalPagar.Size = New System.Drawing.Size(155, 51)
        Me.btnTotalPagar.TabIndex = 21
        Me.btnTotalPagar.Text = "Ver total a pagar"
        Me.btnTotalPagar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Para ver lo que la empresa debe abonar:"
        '
        'Listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTotalPagar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.cbTipoListado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gvEmpleados)
        Me.Controls.Add(Me.btnListar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Listados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listados"
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListar As Button
    Friend WithEvents gvEmpleados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTipoListado As ComboBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnTotalPagar As Button
    Friend WithEvents Label2 As Label
End Class
