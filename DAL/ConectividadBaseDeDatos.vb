Imports System.Data.Odbc

Public Class ConectividadBaseDeDatos
    Public cn As New OdbcConnection
    Public comando As New OdbcCommand
    Public reader As OdbcDataReader

    Protected Shared Function CrearConexion() As OdbcConnection

        Dim usuarioBD As String = My.Settings.Usuario
        Dim passwordBD As String = My.Settings.Password
        Dim puerto As String = My.Settings.Puerto
        Dim servidor As String = My.Settings.Instancia
        Dim ip As String = My.Settings.Ip
        Dim nombreBD As String = My.Settings.NombreBD
        Return New OdbcConnection("FileDsn=" & AppDomain.CurrentDomain.BaseDirectory & "ODBC.dsn;UID =" & usuarioBD & ";PWD=" & passwordBD)
    End Function

    Public Function getDataInDataTable(ByVal query As String) As DataTable
        Dim retorno As New DataTable
        Try
            cn = CrearConexion()
            Dim adapter As New OdbcDataAdapter(query, cn)
            cn.Open()
            adapter.Fill(retorno)
            cn.Close()
        Catch ex As Exception
            Throw New Exception(AppDomain.CurrentDomain.BaseDirectory)
        End Try
        Return retorno
    End Function
End Class