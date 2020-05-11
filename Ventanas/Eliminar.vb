Imports BibliotecaClases

Public Class Eliminar

    Dim emp As New Empleado()

    Private Sub btnVerEmp_Click(sender As Object, e As EventArgs) Handles btnVerEmp.Click
        Dim consulta As String

        consulta = "SELECT * FROM EMPLEADOS WHERE ced=" & txtCi.Text & ""
        gvEmpleados.DataSource = emp.listado(consulta)

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        AddEmp.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        AddEmp.Close()
    End Sub

    Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
        Dim consulta As String

        If txtCi.Text = "" Then
            MsgBox("Ingrese una cedula valida!")
        Else
            consulta = "DELETE FROM empleados WHERE ced= " & Val(txtCi.Text)
            If emp.delEmp(consulta) = True Then
                MsgBox("Empleado eliminado con exito!")
                txtCi.Clear()
            End If
        End If

    End Sub
End Class