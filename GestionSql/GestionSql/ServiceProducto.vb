Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class ServiceProducto
    Public Sub SaveProducto(ByVal Nombre As String, ByVal descripcion As String, ByVal categoria As Integer, ByVal valor As Double, ByVal imagen As String)
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim Nom As New OleDb.OleDbParameter("@Nombre", Nombre)
        Dim desc As New OleDb.OleDbParameter("@Descripcion", descripcion)
        Dim cat As New OleDb.OleDbParameter("@Categoria", categoria)
        Dim val As New OleDb.OleDbParameter("@Valor", valor)
        Dim img As New OleDb.OleDbParameter("@Imagen", imagen)
        s.comando.Parameters.Add(Nom)
        s.comando.Parameters.Add(desc)
        s.comando.Parameters.Add(cat)
        s.comando.Parameters.Add(val)
        s.comando.Parameters.Add(img)
        resultado = s.ExecuteSql("ProcGuardarProducto")
        If resultado = 0 Then
            MessageBox.Show("Error al guardar los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Datos guardados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function ConsultaProductos() As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        s.ExecuteSql("ProcConsultaProductos")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function
    Public Function ConsultaProductos(ByVal Id As Integer) As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        Dim Idp As New OleDb.OleDbParameter("@IdProd", Id)
        s.comando.Parameters.Add(Idp)
        s.ExecuteSql("ProcConsultaProductoId")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function

    Public Function EliminarProducto(ByVal ide As Integer) As Integer
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim idu As New OleDb.OleDbParameter("@IdProducto", ide)
        s.comando.Parameters.Add(idu)
        resultado = s.ExecuteSql("ProcBorrarProducto")
        If resultado = 0 Then
            MessageBox.Show("No fue posible la eliminacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Eliminacion exitosa ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return resultado
    End Function
    Public Function ConsultaProductos(ByVal Nombre As String, ByVal Categoria As String) As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        Dim NOM, CAT As OleDbParameter

        If Nombre = "Nombre" Then
            NOM = New OleDbParameter("@Nom", "")
        Else
            NOM = New OleDbParameter("@Nom", Nombre)
        End If
        If Categoria = "Categoria" Then
            CAT = New OleDbParameter("@Cat", 0)
        Else
            CAT = New OleDbParameter("@Cat", Categoria)
        End If
        s.comando.Parameters.Add(NOM)
        s.comando.Parameters.Add(CAT)
        s.ExecuteSql("ProcFiltrarProductos")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function
    Public Function UpdateProducto(ByVal Nombre As String, ByVal descripcion As String, ByVal categoria As Integer, ByVal valor As Double, ByVal imagen As String, ByVal idpro As Integer) As Integer
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim Nom As New OleDb.OleDbParameter("@Nombre", Nombre)
        Dim desc As New OleDb.OleDbParameter("@Descripcion", descripcion)
        Dim cat As New OleDb.OleDbParameter("@Categoria", categoria)
        Dim val As New OleDb.OleDbParameter("@Valor", valor)
        Dim img As New OleDb.OleDbParameter("@Imagen", imagen)
        Dim Id As New OleDb.OleDbParameter("@Imagen", idpro)
        s.comando.Parameters.Add(Nom)
        s.comando.Parameters.Add(desc)
        s.comando.Parameters.Add(cat)
        s.comando.Parameters.Add(val)
        s.comando.Parameters.Add(img)
        s.comando.Parameters.Add(Id)
        resultado = s.ExecuteSql("ProcActualizarProducto")
        If resultado = 0 Then
            MessageBox.Show("Error al guardar los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Datos guardados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return resultado
    End Function
    Public Function CargaComboBoxCategoria() As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        s.ExecuteSql("ProcConsultaCategorias")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Dim fila As DataRow = DT.NewRow()
        fila.Item("Id") = 0
        fila.Item("Nombre") = "Categoria"
        DT.Rows.InsertAt(fila, 0)
        Return DT
    End Function
End Class
