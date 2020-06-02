Imports BibliotecaClases

Public Class frmAddEmp
    Dim emp As New Empleado()
    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim pagar As Double
        Try
            pagar = emp.calcMonto(cbCargo.Text, Double.Parse(txtSalario.Text)) + (Double.Parse(txtSalario.Text))
            If emp.AgrgarRegistro(Integer.Parse(txtCi.Text), txtPnom.Text,
            txtSnom.Text, txtPape.Text, txtSape.Text, txtDir.Text, txtTel.Text, cbCargo.Text, pagar) = True Then

                MsgBox("Empleado Agregado Satisfactoriamente !")
                limpiarFormulario()

            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information, "Advertencia")
        End Try


    End Sub

    Private Sub limpiarFormulario()
        txtCi.Clear()
        txtSalario.Clear()
        txtPnom.Clear()
        txtSnom.Clear()
        txtPape.Clear()
        txtSape.Clear()
        txtDir.Clear()
        txtTel.Clear()
        txtSalario.Clear()
        cbCargo.SelectedIndex = -1
    End Sub

    'Private Sub btnListados_Click(sender As Object, e As EventArgs) Handles btnListados.Click
    '    frmListados.Show()
    '    Me.Hide()
    'End Sub

    'Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
    '    frmEliminar.Show()
    '    Me.Hide()
    'End Sub

    'Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
    '    frmModificar.Show()
    '    Me.Hide()
    'End Sub
End Class
