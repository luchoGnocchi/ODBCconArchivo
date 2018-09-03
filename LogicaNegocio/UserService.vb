Imports DAL
Imports Domino

Public Class UserService
    Dim _userDataAccess As New UserDataAccess()
    Public Function login(usuario As Usuario) As Usuario
        Return _userDataAccess.login(usuario)

    End Function
    Public Function ingresar(usuario As Usuario) As Usuario
        'agregar logica de negocio
        Return _userDataAccess.ingresar(usuario)
    End Function
    Public Function getall() As DataTable
        Try
            Return _userDataAccess.getall()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
