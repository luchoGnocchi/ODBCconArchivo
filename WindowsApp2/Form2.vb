Imports LogicaNegocio

Public Class Form2
    Dim _userService As New UserService
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            DataGridView1.DataSource = _userService.getall()

        Catch ex As Exception
            MsgBox("Lo sentimos, ha ocurrido un error Detalle:" + ex.Message)
        End Try
    End Sub
End Class