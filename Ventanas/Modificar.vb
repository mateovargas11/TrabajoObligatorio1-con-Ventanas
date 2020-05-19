Imports System.Configuration
Imports BibliotecaClases

Public Class Modificar
    Dim emp As New Empleado()
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarTodo()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        AddEmp.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        AddEmp.Close()
        Me.Close()
    End Sub

    Private Sub btnVerEmp_Click(sender As Object, e As EventArgs) Handles btnVerEmp.Click
        If txtCi.Text = "" Then
            MsgBox("Ingrese una cedula valida!")
        Else
            MostrarTodo()
            Dim consulta As String
            txtCi.Enabled = False
            consulta = "SELECT * FROM EMPLEADOS WHERE ced=" & txtCi.Text & ""
            dgEmp.DataSource = emp.listado(consulta)
        End If
    End Sub

    Private Sub OcultarTodo()
        txtPnom.Visible = False
        txtSnom.Visible = False
        txtPape.Visible = False
        txtSape.Visible = False
        txtSalario.Visible = False
        txtDir.Visible = False
        txtTel.Visible = False
        cbCargo.Visible = False

        btnModif.Visible = False

        lblCargo.Visible = False
        lblDir.Visible = False
        lblPape.Visible = False
        lblPnom.Visible = False
        lblSalario.Visible = False
        lblSape.Visible = False
        lblSnom.Visible = False
        lblTel.Visible = False
    End Sub

    Private Sub MostrarTodo()
        txtPnom.Visible = True
        txtSnom.Visible = True
        txtPape.Visible = True
        txtSape.Visible = True
        txtSalario.Visible = True
        txtDir.Visible = True
        txtTel.Visible = True
        cbCargo.Visible = True

        btnModif.Visible = True

        lblCargo.Visible = True
        lblDir.Visible = True
        lblPape.Visible = True
        lblPnom.Visible = True
        lblSalario.Visible = True
        lblSape.Visible = True
        lblSnom.Visible = True
        lblTel.Visible = True
        lblSelec.Visible = True
    End Sub

    Private Sub limpiarTodo()
        txtCi.Clear()
        txtDir.Clear()
        txtPape.Clear()
        txtPnom.Clear()
        txtSalario.Clear()
        txtSape.Clear()
        txtSnom.Clear()
        txtTel.Clear()
        cbCargo.SelectedIndex = -1
    End Sub

    Private Sub dgEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmp.CellClick

        Try
            Dim i As Integer
            i = dgEmp.CurrentRow.Index
            txtCi.Text = dgEmp.Item(0, i).Value()
            txtPnom.Text = dgEmp.Item(1, i).Value()
            txtSnom.Text = dgEmp.Item(2, i).Value()
            txtPape.Text = dgEmp.Item(3, i).Value()
            txtSape.Text = dgEmp.Item(4, i).Value()
            cbCargo.Text = dgEmp.Item(5, i).Value()
            txtDir.Text = dgEmp.Item(6, i).Value()
            txtTel.Text = dgEmp.Item(7, i).Value()
            txtSalario.Text = dgEmp.Item(8, i).Value()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Dim consulta As String
        consulta = "update empleados set "
        consulta = consulta & "Pnom= '" & txtPnom.Text & "',"
        consulta = consulta & "Snom= '" & txtSnom.Text & "',"
        consulta = consulta & "Pape= '" & txtPape.Text & "',"
        consulta = consulta & "Sape= '" & txtSape.Text & "',"
        consulta = consulta & "direccion= '" & txtDir.Text & "',"
        consulta = consulta & "tel= '" & txtTel.Text.ToString & "',"
        consulta = consulta & "Cargo= '" & cbCargo.Text & "',"
        consulta = consulta & "sueldoPagar= " & txtSalario.Text.ToString & " where ced= " & txtCi.Text
        If (emp.Pedido(consulta)) = True Then
            MsgBox("Empleado modificado con exito!")
            dgEmp.DataSource = emp.listado("SELECT * FROM EMPLEADOS WHERE Ced= " & txtCi.Text)
            OcultarTodo()
            limpiarTodo()
            txtCi.Enabled = True
        End If

    End Sub
End Class