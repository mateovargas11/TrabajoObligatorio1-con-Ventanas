Public Class frmMDI

    Private Sub listado(x As Integer, y As Integer, w As Integer, h As Integer)
        cerrarTodo()
        Dim frm As frmListados = New frmListados()
        frm.MdiParent = Me
        frm.Show()
        frm.SetBounds(x, y, w, h)
    End Sub

    Private Sub modificar(x As Integer, y As Integer, w As Integer, h As Integer)
        cerrarTodo()
        Dim frm As frmModificar = New frmModificar()
        frm.MdiParent = Me
        frm.Show()
        frm.SetBounds(x, y, w, h)
    End Sub

    Private Sub eliminar(x As Integer, y As Integer, w As Integer, h As Integer)
        cerrarTodo()
        Dim frm As frmEliminar = New frmEliminar()
        frm.MdiParent = Me
        frm.Show()
        frm.SetBounds(x, y, w, h)
    End Sub

    Private Sub agregar(x As Integer, y As Integer, w As Integer, h As Integer)
        cerrarTodo()
        Dim frm As frmAddEmp = New frmAddEmp()
        frm.MdiParent = Me
        frm.Show()
        frm.SetBounds(x, y, w, h)
    End Sub

    Private Sub TSBagregar_Click(sender As Object, e As EventArgs) Handles TSBagregar.Click
        agregar(238, 0, 870, 496)
    End Sub

    Private Sub TSBmodificar_Click(sender As Object, e As EventArgs) Handles TSBmodificar.Click
        modificar(238, 0, 870, 496)
    End Sub

    Private Sub TSBlistar_Click(sender As Object, e As EventArgs) Handles TSBlistar.Click
        listado(238, 0, 870, 496)
    End Sub

    Private Sub TSBeliminar_Click(sender As Object, e As EventArgs) Handles TSBeliminar.Click
        eliminar(238, 0, 870, 496)
    End Sub

    Private Sub AgregarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEmpleadoToolStripMenuItem.Click
        agregar(238, 0, 870, 496)
    End Sub

    Private Sub ModificarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarEmpleadoToolStripMenuItem.Click
        modificar(238, 0, 870, 496)
    End Sub

    Private Sub EliminarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarEmpleadoToolStripMenuItem.Click
        eliminar(238, 0, 870, 496)
    End Sub

    Private Sub ListarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarEmpleadosToolStripMenuItem.Click
        listado(238, 0, 870, 496)
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        agregar(238, 0, 870, 496)
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        modificar(238, 0, 870, 496)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listado(238, 0, 870, 496)
    End Sub

    Private Sub btnElim_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        eliminar(238, 0, 870, 496)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub cerrarTodo()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cerrarTodo()
    End Sub
End Class