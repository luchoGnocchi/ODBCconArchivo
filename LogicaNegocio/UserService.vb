Imports DAL
Imports Domino

Public Class UserService
    Dim _userDataAccess As New UserDataAccess()
    Public Function login(usuario As User) As User
        Return _userDataAccess.login(usuario)

    End Function
    Public Function ingresar(usuario As User) As User
        'agregar logica de negocio
        Return _userDataAccess.insert(usuario)
    End Function
    Public Function getall() As DataTable
        Try
            Return _userDataAccess.getall()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
