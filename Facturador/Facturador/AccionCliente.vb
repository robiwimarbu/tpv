Imports System.Data
Imports System.Data.OleDb
Imports GestionSql
Public Class AccionCliente
    Public p As New ServiceCliente
    Public Sub AccionGuardarCliente()
        Dim Er As Integer = 0 'variable usada para medir si existe un error
        Er = ValidaFormCliente()
        If Er = 0 Then
            p.SaveCliente(FrmClientes.TxtNombre.Text, FrmClientes.TxtIdentificacion.Text)
        End If
    End Sub
    Public Sub CargaDatagrimClientes()
        Dim t As New DataTable
        t = p.ConsultaClientes()
        FrmClientes.DtgClientes.DataSource = t
        FrmClientes.DtgClientes.Columns(0).Visible = False
        FrmClientes.DtgClientes.Columns(1).Width = 240
        FrmClientes.DtgClientes.Columns(2).Width = 240
    End Sub

    Public Function ValidaFormCliente() As Integer
        Dim Er As Integer = 0 'variable usada para medir si existe un error
        Dim msj As String = "Se detectaron los siguiente errores" & vbCr 'variable que guarda el mensaje de error segun este suceda
        If FrmClientes.TxtNombre.TextLength = 0 OrElse RTrim(FrmClientes.TxtNombre.Text) = "Nombre" Then
            msj &= "Nombre para el usuario" & vbCr
            Er += 1
        End If
        If FrmClientes.TxtIdentificacion.TextLength < 5 OrElse FrmClientes.TxtIdentificacion.Text = "Identificacion" Then
            msj &= "Identificacion Usuario incorrecta" & vbCr
            Er += 1
        End If
        If Er > 0 Then
            MessageBox.Show(msj, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return Er
    End Function
    Public Sub CargaForm(ByVal id As Integer)
        FrmClientes.BtnGuardar.Image = Facturador.My.Resources.Resources.modify
        FrmClientes.accion = "Actualizar"
        FrmClientes.TxtNombre.Text = FrmClientes.DtgClientes.Rows(id).Cells(1).Value
        FrmClientes.TxtIdentificacion.Text = FrmClientes.DtgClientes.Rows(id).Cells(2).Value
        FrmClientes.Refresh()
    End Sub
    Public Sub ElmininarCliente(ByVal id As Integer)
        p.EliminarCliente(id)
        LimpiarCliente()
        p.ConsultaClientes()
    End Sub
    Public Sub LimpiarCliente()
        FrmClientes.BtnGuardar.Image = Facturador.My.Resources.Resources.apply
        FrmClientes.accion = "Guardar"
        FrmClientes.TxtNombre.Text = "Nombre"
        FrmClientes.TxtIdentificacion.Text = "Identificacion"
        FrmClientes.DtgClientes.DataSource = p.ConsultaClientes()
    End Sub
    Public Sub ActualizaCliente()
        Dim er As Integer
        er = ValidaFormCliente()
        If er = 0 Then
            p.UpdateCliente(FrmClientes.TxtNombre.Text, FrmClientes.TxtIdentificacion.Text, FrmClientes.ActR)
        End If
    End Sub
    Public Sub FiltrarClientes()
        Dim t As New DataTable
        t = p.ConsultaCliente(FrmClientes.TxtNombre.Text, FrmClientes.TxtIdentificacion.Text)
        FrmClientes.DtgClientes.DataSource = t
        FrmClientes.DtgClientes.Columns(0).Visible = False
    End Sub
End Class
