Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class ServiceLogin
    
    Public Function ConsultaUsuario(ByVal Usuario As String, ByVal Clave As String) As DataTable
        Dim s As New GestionSql()
        Dim dt As New DataTable
        Dim Us As New OleDb.OleDbParameter("@Usuario", Usuario)
        Dim Cl As New OleDb.OleDbParameter("@Clave", Clave)
        s.comando.Parameters.Add(Us)
        s.comando.Parameters.Add(Cl)
        s.ExecuteSql("ProcConsultaUsuario")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(dt)
        Return dt
    End Function
    
End Class
