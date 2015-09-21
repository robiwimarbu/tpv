Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class ServiceVenta
    Public Function SaveFactura(ByVal IdCliente As Integer, ByVal IdUsuario As Integer) As Integer
        Dim Clave As Integer
        Dim s As New GestionSql()
        Dim IdC As New OleDb.OleDbParameter("@IdCliente", IdCliente)
        Dim IdU As New OleDb.OleDbParameter("@IdUsuario", IdUsuario)
        s.comando.Parameters.Add(IdC)
        s.comando.Parameters.Add(IdU)
        Clave = s.ExecuteSql2("ProcGuardarFactura")
        Return Clave
    End Function
    Public Function SaveDetalleFactura(ByVal IdFactura As Integer, ByVal IdProducto As Integer, ByVal ValorUnitario As Double, ByVal Cantidad As Double) As Integer
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim IdF As New OleDb.OleDbParameter("@IdFactura", IdFactura)
        Dim IdP As New OleDb.OleDbParameter("@IdProducto", IdProducto)
        Dim VaU As New OleDb.OleDbParameter("@ValorUnitario", ValorUnitario)
        Dim Can As New OleDb.OleDbParameter("@Cantidad", Cantidad)
        s.comando.Parameters.Add(IdF)
        s.comando.Parameters.Add(IdP)
        s.comando.Parameters.Add(VaU)
        s.comando.Parameters.Add(Can)
        resultado = s.ExecuteSql2("ProcGuardarDetalleFactura")
        Return resultado
    End Function
    Public Function ConsultaVenta(ByVal NumFactura As Integer) As DataTable
        Dim DT As New DataTable
        Dim s As New GestionSql()
        Dim IdF As New OleDb.OleDbParameter("@IdFactura", NumFactura)
        s.comando.Parameters.Add(IdF)
        s.ExecuteSql("ProcConsultaVenta")
        Dim da As New OleDbDataAdapter(s.comando)
        da.Fill(DT)
        Return DT
    End Function
    Public Function ConsultaValorVenta(ByVal NumFactura As Integer) As Double
        Dim ValorTotal As Double = 0
        Dim dt As New DataTable
        Dim s As New GestionSql()
        Try
            Dim IdF As New OleDb.OleDbParameter("@IdFactura", NumFactura)
            s.comando.Parameters.Add(IdF)
            s.ExecuteSql("ProcConsultaValorVenta")
            Dim da As New OleDbDataAdapter(s.comando)
            da.Fill(dt)
            ValorTotal = dt(0)("TOTAL")
        Catch ex As Exception
        End Try
        Return ValorTotal
    End Function
   
    Public Function EliminarDetalleVenta(ByVal id As Integer) As Integer
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim idv As New OleDb.OleDbParameter("@IdDetalleventa", id)
        s.comando.Parameters.Add(idv)
        resultado = s.ExecuteSql("ProcBorrarDetalleVenta")
        If resultado = 0 Then
            MessageBox.Show("No fue posible la eliminacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Eliminacion exitosa ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return resultado
    End Function
    Public Function EliminarDetallesdeVenta(ByVal id As Integer) As Integer
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim idv As New OleDb.OleDbParameter("@IdFactura", id)
        s.comando.Parameters.Add(idv)
        resultado = s.ExecuteSql("ProcBorrarDetallesdeVenta")
        Return resultado
    End Function
    Public Function EliminarFactura(ByVal id As Integer) As Integer
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim idv As New OleDb.OleDbParameter("@IdFactura", id)
        s.comando.Parameters.Add(idv)
        resultado = s.ExecuteSql("ProcBorrarFactura")
        If resultado = 0 Then
            MessageBox.Show("No fue posible la eliminacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Eliminacion exitosa ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return resultado
    End Function

    Public Function UpdateDetalleVenta(ByVal IdDetalleFactura As Integer, ByVal IdProducto As Integer, ByVal ValorUnitario As Double, ByVal Cantidad As Double) As Integer
        Dim resultado As Integer
        Dim s As New GestionSql()
        Dim idf As New OleDb.OleDbParameter("@IdDetalleFactura", IdDetalleFactura)
        Dim idp As New OleDb.OleDbParameter("@IdProducto", IdProducto)
        Dim val As New OleDb.OleDbParameter("@ValorUnitario", ValorUnitario)
        Dim cant As New OleDb.OleDbParameter("@Cantidad", Cantidad)
        s.comando.Parameters.Add(idf)
        s.comando.Parameters.Add(idp)
        s.comando.Parameters.Add(val)
        s.comando.Parameters.Add(cant)
        resultado = s.ExecuteSql("ProcActualizarDetalleFactura")
        If resultado = 0 Then
            MessageBox.Show("Error al guardar los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resultado > 0 Then
            MessageBox.Show("Datos guardados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return resultado
    End Function
    
End Class
