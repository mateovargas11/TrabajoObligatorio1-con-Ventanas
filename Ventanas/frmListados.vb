Imports BibliotecaClases

Public Class frmListados
    Dim emp As New Empleado()

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim criterio, tipoConsulta As String
        criterio = cbTipoListado.Text
        Select Case criterio
            Case "Todos"
                tipoConsulta = "SELECT * FROM EMPLEADOS"
                gvEmpleados.DataSource = emp.listado(tipoConsulta)

            Case "Operarios"
                tipoConsulta = "SELECT * FROM EMPLEADOS WHERE Cargo='Operario'"
                gvEmpleados.DataSource = emp.listado(tipoConsulta)

            Case "Gerentes"
                tipoConsulta = "SELECT * FROM EMPLEADOS WHERE Cargo='Gerente'"
                gvEmpleados.DataSource = emp.listado(tipoConsulta)

            Case "Administrativos"
                tipoConsulta = "SELECT * FROM EMPLEADOS WHERE Cargo='Administrativo'"
                gvEmpleados.DataSource = emp.listado(tipoConsulta)

            Case Else
                MsgBox("Seleccione el criterio de busqueda!")
        End Select

    End Sub


    'Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
    '    frmAddEmp.Show()
    '    Me.Close()
    'End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmAddEmp.Close()
    End Sub

    Private Sub btnTotalPagar_Click(sender As Object, e As EventArgs) Handles btnTotalPagar.Click
        Dim tipoConsulta
        tipoConsulta = "Select SUM(sueldoPagar) As Total_A_Pagar from empleados"
        gvEmpleados.DataSource = emp.listado(tipoConsulta)
    End Sub
End Class