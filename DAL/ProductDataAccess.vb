Imports System.Data.Odbc
Imports Domino

Public Class ProductDataAccess
    Inherits ConectividadBaseDeDatos
    Public Function getAll() As DataTable
        Return getDataInDataTable("SELECT 	* FROM producto;")
    End Function
    Public Function getAllTypeProyect() As DataTable
        Return getDataInDataTable("SELECT * FROM tipoProducto;")
    End Function
    Public Sub insert(ByVal elProducto As Product)
        cn = CrearConexion()
        comando = New OdbcCommand("INSERT INTO producto 	(id, nombre, idtipo, fechaalta, visible)
VALUES 	(?, ?,? ,? , ?);", cn)
        comando.CommandType = CommandType.Text
        ''  INSERT INTO testlucho:producto ( id, nombre, idtipo, fechaalta, visible) VALUES (0, 'pepe', 1, 2,'T');
        comando.Parameters.Add(New OdbcParameter("", 0))
        comando.Parameters.Add(New OdbcParameter("", elProducto.nombre))
        comando.Parameters.Add(New OdbcParameter("", elProducto.idTipo))
        comando.Parameters.Add(New OdbcParameter("", elProducto.fechaAlta))
        comando.Parameters.Add(New OdbcParameter("", True))
        cn.Open()
        reader = comando.ExecuteReader()
        cn.Close()

    End Sub
End Class
