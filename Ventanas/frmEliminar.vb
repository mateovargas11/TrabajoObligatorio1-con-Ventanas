Imports BibliotecaClases

Public Class frmEliminar

    Dim emp As New Empleado()

    Private Sub btnVerEmp_Click(sender As Object, e As EventArgs) Handles btnVerEmp.Click
        Dim consulta As String
        If txtCi.Text = "" Then
            MsgBox("Ingrese una cedula valida!")
        Else
            consulta = "select * FROM EMPLEADOS WHERE ced=" & txtCi.Text & ""
            gvEmpleados.DataSource = emp.listado(consulta)
        End If
    End Sub

    'Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
    '    frmAddEmp.Show()
    '    Me.Close()
    'End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmAddEmp.Close()
    End Sub

    Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
        Dim consulta As String

        If txtCi.Text = "" Then
            MsgBox("Ingrese una cedula valida!")
        Else
            consulta = "DELETE FROM empleados WHERE ced= " & Val(txtCi.Text)
            If emp.Pedido(consulta) = True Then
                MsgBox("Empleado eliminado con exito!")

                consulta = "select * FROM EMPLEADOS WHERE ced=" & txtCi.Text & ""
                gvEmpleados.DataSource = emp.listado(consulta)

                txtCi.Clear()
            End If
        End If

    End Sub

End Class