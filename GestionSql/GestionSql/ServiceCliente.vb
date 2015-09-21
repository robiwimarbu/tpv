Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class ServiceCliente
    Public Sub SaveCliente(ByVal Nombre As String, ByVal Identificacion As String)
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim Nom As New OleDb.OleDbParameter("@Nombre", Nombre)
        Dim id As New OleDb.OleDbParameter("@Identficacion", Identificacion)
        s.comando.Parameters.Add(Nom)
        s.comando.Parameters.Add(id)
        resultado = s.ExecuteSql("ProcGuardarCliente")
        If resultado = 0 Then
            MessageBox.Show("Error al guardar los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Datos guardados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function ConsultaClientes() As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        s.ExecuteSql("ProcConsultaClientes")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function
    Public Sub EliminarCliente(ByVal id)
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim idu As New OleDb.OleDbParameter("@IdUsuario", id)
        s.comando.Parameters.Add(idu)
        resultado = s.ExecuteSql("ProcBorrarCliente")
        If resultado = 0 Then
            MessageBox.Show("No fue posible la eliminacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Eliminacion exitosa ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ConsultaClientes()
        End If
    End Sub
    Public Function ConsultaCliente(ByVal NOMBRE As String, ByVal IDENTIFICACION As String) As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        Dim NOM, IDEN As OleDbParameter

        If NOMBRE = "Nombre" Then
            NOM = New OleDbParameter("@Nom", "")
        Else
            NOM = New OleDbParameter("@Nom", NOMBRE)
        End If
        If IDENTIFICACION = "Identificacion" Then
            IDEN = New OleDbParameter("@Iden", "")
        Else
            IDEN = New OleDbParameter("@Iden", IDENTIFICACION)
        End If

        s.comando.Parameters.Add(NOM)
        s.comando.Parameters.Add(IDEN)
        s.ExecuteSql("ProcFiltrarClientes")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function
    Public Function ConsultaCliente(ByVal IDENTIFICACION As String) As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        Dim IDEN As OleDbParameter
        If IDENTIFICACION = "Identificacion Cliente" Then
            IDEN = New OleDbParameter("@Identificacion", "")
        Else
            IDEN = New OleDbParameter("@Identificacion", IDENTIFICACION)
        End If
        s.comando.Parameters.Add(IDEN)
        s.ExecuteSql("ProcConsultaCliente")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function

    Public Sub UpdateCliente(ByVal Nombre As String, ByVal Identificacion As String, ByVal pk As Integer)
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim Nom As New OleDb.OleDbParameter("@Nombre", Nombre)
        Dim id As New OleDb.OleDbParameter("@Identficacion", Identificacion)
        Dim Ppk As New OleDb.OleDbParameter("@Id", pk)
        s.comando.Parameters.Add(Nom)
        s.comando.Parameters.Add(id)
        s.comando.Parameters.Add(Ppk)
        resultado = s.ExecuteSql("ProcActualizarCliente")
        If resultado = 0 Then
            MessageBox.Show("Error al guardar los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Datos guardados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    
End Class
