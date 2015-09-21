Public Class FrmClientes
    Public ActR As Integer
    Public accion As String = "Guardar"
    Public ac As New AccionCliente
    
    Private Sub TxtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.GotFocus
        If TxtNombre.Text = "Nombre" Then
            TxtNombre.Text = ""
        End If
    End Sub
    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = RTrim(TxtNombre.Text)
        If TxtNombre.Text = "" Then
            TxtNombre.Text = "Nombre"
        End If
    End Sub

    Private Sub TxtIdentificacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIdentificacion.GotFocus
        If TxtIdentificacion.Text = "Identificacion" Then
            TxtIdentificacion.Text = ""
        End If
    End Sub

    Private Sub TxtIdentificacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIdentificacion.LostFocus
        If TxtIdentificacion.Text = "" Then
            TxtIdentificacion.Text = "Identificacion"
        End If
    End Sub
    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ac.CargaDatagrimClientes()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If accion = "Guardar" Then
            ac.AccionGuardarCliente()
        Else
            ac.ActualizaCliente()
        End If
        ac.CargaDatagrimClientes()
    End Sub

    Private Sub DtgClientes_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtgClientes.CellMouseClick
        Try
            ActR = DtgClientes(0, e.RowIndex).Value
            ac.CargaForm(e.RowIndex)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea Eliminar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            ac.ElmininarCliente(ActR)
        End If
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        ac.LimpiarCliente()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        ac.FiltrarClientes()
    End Sub
End Class