Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class ServiceUsuario
    Public Sub SaveUsuario(ByVal Nombre As String, ByVal Identificacion As String, ByVal Clave As String, ByVal TipoUsuario As Integer)
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim Nom As New OleDb.OleDbParameter("@Nombre", Nombre)
        Dim id As New OleDb.OleDbParameter("@Identficacion", Identificacion)
        Dim pass As New OleDb.OleDbParameter("@Clave", Clave)
        Dim TpU As New OleDb.OleDbParameter("@TipoUsuario", TipoUsuario)
        s.comando.Parameters.Add(Nom)
        s.comando.Parameters.Add(id)
        s.comando.Parameters.Add(pass)
        s.comando.Parameters.Add(TpU)
        resultado = s.ExecuteSql("ProcGuardarUsuario")
        If resultado = 0 Then
            MessageBox.Show("Error al guardar los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Datos guardados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function Consulta() As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        s.ExecuteSql("ProcConsultaUsuarios")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function
    Public Sub EliminarUsuario(ByVal id)
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim idu As New OleDb.OleDbParameter("@IdUsuario", id)
        s.comando.Parameters.Add(idu)
        resultado = s.ExecuteSql("ProcBorrarUsuario")
        If resultado = 0 Then
            MessageBox.Show("No fue posible la eliminacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Eliminacion exitosa ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Consulta()
        End If
    End Sub
    Public Function Consulta(ByVal NOMBRE As String, ByVal IDENTIFICACION As String) As DataTable
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
        s.ExecuteSql("ProcFiltrarUsuarios")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function
    Public Sub UpdateCliente(ByVal Nombre As String, ByVal Identificacion As String, ByVal Clave As String, ByVal TipoUsuario As Integer, ByVal pk As Integer)
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim Nom As New OleDb.OleDbParameter("@Nombre", Nombre)
        Dim id As New OleDb.OleDbParameter("@Identficacion", Identificacion)
        Dim pass As New OleDb.OleDbParameter("@Clave", Clave)
        Dim TpU As New OleDb.OleDbParameter("@TipoUsuario", TipoUsuario)
        Dim Ppk As New OleDb.OleDbParameter("@Id", pk)
        s.comando.Parameters.Add(Nom)
        s.comando.Parameters.Add(id)
        s.comando.Parameters.Add(pass)
        s.comando.Parameters.Add(TpU)
        s.comando.Parameters.Add(Ppk)
        resultado = s.ExecuteSql("ProcActualizarUsuario")
        If resultado = 0 Then
            MessageBox.Show("Error al guardar los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Datos guardados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function CargaComboBoxTipoUsuario() As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        s.ExecuteSql("ProcConsultaTipoUsuarios")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Dim fila As DataRow = DT.NewRow()
        fila.Item("Id") = 0
        fila.Item("Tipo") = "Tipo Usuario"
        DT.Rows.InsertAt(fila, 0)
        Return DT
    End Function
End Class
