Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class GestionSql
    Public Coneccion As OleDbConnection
    Public CadenadeConeccion = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=DbFacturador.mdb;"
    Public comando As New OleDbCommand()

    Public Sub OpenConnection()
        Coneccion = New OleDbConnection(CadenadeConeccion)
        Coneccion.Open()
    End Sub
    Public Sub CloseConnection()
        Coneccion.Close()
    End Sub
    Public Function ExecuteSql(ByVal nombreProcedimientoAlmacenado As String) As Integer
        Dim resultado As Integer = 0
        Try

            OpenConnection()
            comando.Connection = Coneccion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = nombreProcedimientoAlmacenado
            resultado = comando.ExecuteNonQuery()
            CloseConnection()
        Catch es As Exception
            MessageBox.Show(es.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = -1
        End Try
        Return resultado
    End Function
    Public Function ExecuteSql2(ByVal nombreProcedimientoAlmacenado As String) As Integer
        Dim resultado As Integer = 0
        Try
            OpenConnection()
            comando.Connection = Coneccion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = nombreProcedimientoAlmacenado
            resultado = comando.ExecuteNonQuery()
            Dim cmdAuto As New OleDbCommand("SELECT @@IDENTITY", Coneccion)
            resultado = cmdAuto.ExecuteScalar()
            CloseConnection()
        Catch es As Exception
            MessageBox.Show(es.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = -1
        End Try
        Return resultado
    End Function
End Class