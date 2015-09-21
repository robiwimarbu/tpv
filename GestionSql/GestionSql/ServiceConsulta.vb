Public Class ServiceConsulta
    Public s As New GestionSql
    Public Function Consulta(ByVal IdCliente As Integer) As DataTable
        Dim dt As New DataTable
        Dim Id As New OleDb.OleDbParameter("@IdCliente", IdCliente)
        s.comando.Parameters.Add(Id)
        s.ExecuteSql("ProcConsultaVentasXCliente")
        Dim Da As New OleDb.OleDbDataAdapter(s.comando)
        Da.Fill(dt)
        Return (dt)
    End Function
    Public Function Consulta(ByVal Fecha As String) As DataTable
        Dim dt As New DataTable
        Dim fch As New OleDb.OleDbParameter("@Fecha", Fecha)
        s.comando.Parameters.Add(fch)
        s.ExecuteSql("ProcConsultaVentasXFecha")
        Dim Da As New OleDb.OleDbDataAdapter(s.comando)
        Da.Fill(dt)
        Return dt
    End Function
    Public Function Consulta(ByVal Fecha As String, ByVal IdCliente As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fch As New OleDb.OleDbParameter("@Fecha", Fecha)
            Dim id As New OleDb.OleDbParameter("@IdCliente", IdCliente)
            s.comando.Parameters.Add(fch)
            s.comando.Parameters.Add(id)
            s.ExecuteSql("ProcConsultaVentasXFechaXCliente")
            Dim Da As New OleDb.OleDbDataAdapter(s.comando)
            Da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return dt
    End Function
End Class
