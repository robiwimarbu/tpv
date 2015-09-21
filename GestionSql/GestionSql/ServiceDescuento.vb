Public Class ServiceDescuento
    Public sd As New GestionSql
    Public Function GetDescuento() As Double
        Dim descuento As Integer
        Dim t As New DataTable
        sd.ExecuteSql("ProcConsultaDescuento")
        Dim val As New OleDb.OleDbDataAdapter(sd.comando)
        val.Fill(t)
        descuento = t(0)("PorcDescuento") 
        Return descuento
    End Function

End Class
