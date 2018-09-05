Imports LogicaNegocio

Public Class Form2
    Dim _productService As New ProductService
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            DataGridView1.DataSource = _productService.getall()

        Catch ex As Exception
            MsgBox("Lo sentimos, ha ocurrido un error Detalle:" + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAltaProducto.Visible = True
    End Sub
End Class