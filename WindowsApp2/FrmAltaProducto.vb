Imports Domino
Imports LogicaNegocio

Public Class FrmAltaProducto
    Dim _productService As New ProductService()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim producto As New Product()
        producto.fechaAlta = DateTimePicker1.Value
        producto.nombre = TextBox1.Text
        producto.visible = CheckBox1.Checked
        producto.idTipo = ComboBox1.SelectedValue

        Try
            _productService.insert(producto)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmAltaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = _productService.getAllTypeProduct()
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "id"
    End Sub
End Class