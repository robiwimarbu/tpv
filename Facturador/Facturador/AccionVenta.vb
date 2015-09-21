Imports System.Data
Imports System.Data.OleDb
Imports GestionSql
Imports System.IO
Public Class AccionVenta
    Public Sub venta(ByVal id)
        LimpiarFrmVentas()
        BotonesModEli(False)
        Dim descuento As Double = 0
        Dim t As New DataTable
        Dim p As New ServiceProducto
        Dim valor As Double
        t = p.ConsultaProductos(id)
        If FrmVentas.LblCliente.Text = "" Then 'si la etiqueta cliente no tiene un valor significa que no hay venta activa
            Dim frd As New FrmDato
            frd.ShowDialog()
            Dim sd As New ServiceDescuento
            descuento = sd.GetDescuento()
            descuento = descuento / 100
            FrmVentas.des = descuento
        End If
        If FrmVentas.ClienteActual <> 0 Then
            valor = t(0)("ValProducto") - (t(0)("ValProducto") * FrmVentas.des)
        Else
            valor = t(0)("ValProducto")
        End If
        FrmVentas.TxtNombre.Text = t(0)("NomProducto")
        FrmVentas.TxtValu.Text = valor.ToString
        FrmVentas.TxtCantidad.Focus()

    End Sub
    Public Sub LimpiarFrmVentas()
        FrmVentas.TxtNombre.Clear()
        FrmVentas.TxtValu.Clear()
        FrmVentas.TxtCantidad.Clear()
        FrmVentas.TxtSTotal.Clear()
    End Sub
    Public Sub EliminaVenta()
        Dim p As New ServiceVenta
        Dim id As Integer = Integer.Parse(FrmVentas.LblNumFact.Text)
        If p.EliminarDetallesdeVenta(id) > 0 Then
            p.EliminarFactura(id)
            LimpiarFrmVentas()
            CerrarVenta()
        Else
            MessageBox.Show("No fue posible la eliminacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub GuardarVenta()
        Try

        
        If FrmVentas.LblNumFact.Text = "" Then 'si la etiqueta factura no tiene un valor significa que no hay venta activa
            'guardar factura y venta
            AgregaFactura(FrmVentas.ClienteActual)
        Else 'si por el contrario la etiqueta tiene  valor significa que ya hay una cuenta activa y agrego productos a la venta
            Dim sv As New ServiceVenta
            Dim idF As Integer = Integer.Parse(FrmVentas.LblNumFact.Text)
            If sv.SaveDetalleFactura(idF, FrmVentas.IdProducto, FrmVentas.TxtValu.Text, FrmVentas.TxtCantidad.Text) > 0 Then
                CargarDatagrid()
                LimpiarFrmVentas()
                Totalizar()
            End If
        End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub Totalizar()
        If FrmVentas.LblNumFact.Text <> "" Then
            Dim sv As New ServiceVenta
            Dim idF As Integer = Integer.Parse(FrmVentas.LblNumFact.Text)
            FrmVentas.TxtTotal.Text = sv.ConsultaValorVenta(idF).ToString
        End If
    End Sub
    Public Sub CargarDatagrid()
        Dim sv As New ServiceVenta
        Dim t As New DataTable
        t = sv.ConsultaVenta(FrmVentas.LblNumFact.Text)
        FrmVentas.DtgVentas.DataSource = t
        FrmVentas.DtgVentas.Columns("Id").Visible = False
        FrmVentas.DtgVentas.Columns("Codigo").Visible = False
    End Sub
    Public Sub ElmininarDetalleVEnta(ByVal id As Integer)
        Dim sv As New ServiceVenta
        If sv.EliminarDetalleVenta(id) > 0 Then
            BotonesModEli(False)
            CargarDatagrid()
            Totalizar()
            LimpiarFrmVentas()
        End If
    End Sub
    Public Sub BotonesModEli(ByVal bool As Boolean)
        FrmVentas.BtnEliminar.Enabled = bool
        FrmVentas.BtnModificar.Enabled = bool
    End Sub

    Public Sub CargaForm(ByVal id As Integer)
        FrmVentas.TxtNombre.Text = FrmVentas.DtgVentas.Rows(id).Cells(2).Value
        FrmVentas.TxtValu.Text = FrmVentas.DtgVentas.Rows(id).Cells(3).Value
        FrmVentas.TxtCantidad.Text = FrmVentas.DtgVentas.Rows(id).Cells(4).Value
        FrmVentas.TxtSTotal.Text = FrmVentas.DtgVentas.Rows(id).Cells(3).Value
    End Sub

    Public Sub ActualizaDetalleVenta()
        Try
            Dim sv As New ServiceVenta
        If sv.UpdateDetalleVenta(FrmVentas.ActR, FrmVentas.IdProducto, FrmVentas.TxtValu.Text, FrmVentas.TxtCantidad.Text) > 0 Then
            LimpiarFrmVentas()
            CargarDatagrid()
            Totalizar()
            BotonesModEli(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Public Sub CerrarVenta()
        'limpiamos todos los elementos de la venta actual
        FrmVentas.LblCliente.Text = ""
        FrmVentas.LblNumFact.Text = ""
        FrmVentas.ActR = 0
        FrmVentas.TxtTotal.Clear()
        FrmVentas.DtgVentas.DataSource = Nothing
    End Sub
    Public Sub AgregaFactura(ByVal idcliente As Integer)
        Try
        'agrega valor a la factura
        Dim V As New ServiceVenta
        Dim id As Integer = V.SaveFactura(idcliente, FrmVentas.usuario)
        FrmVentas.LblNumFact.Text = id.ToString
        'y el detalle de la venta
        If V.SaveDetalleFactura(id, FrmVentas.IdProducto, FrmVentas.TxtValu.Text, FrmVentas.TxtCantidad.Text) > 0 Then
            Dim AV As New AccionVenta
            AV.CargarDatagrid()
            AV.LimpiarFrmVentas()
            AV.Totalizar()
        End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
End Class
