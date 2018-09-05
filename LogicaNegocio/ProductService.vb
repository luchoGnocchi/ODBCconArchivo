Imports DAL
Imports Domino
Public Class ProductService
    Dim _productDataAccess As New ProductDataAccess()
    Public Sub insert(elProducto As Product)
        'agregar logica de negocio
        _productDataAccess.insert(elProducto)
    End Sub

    Public Function getAllTypeProduct() As DataTable
        Try
            Return _productDataAccess.getAllTypeProyect()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function getall() As DataTable
        Try
            Return _productDataAccess.getAll()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
