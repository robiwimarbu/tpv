Public Class FrmUsuarios
    Public ActR As Integer
    Public ac As New AccionUsuario
    Public accion As String = "Guardar"
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If accion = "Guardar" Then
            ac.AccionGuardarUsuario(Me)
        Else
            ac.ActualizaUsuario()
        End If
        ac.CargarDatagrid(Me)
    End Sub


    Private Sub TxtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.GotFocus
        If TxtNombre.Text = "Nombre" Then
            TxtNombre.Text = ""
        Else
            TxtNombre.SelectAll()
        End If
    End Sub

    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = RTrim(TxtNombre.Text)
        If TxtNombre.Text = "" Then
            TxtNombre.Text = "Nombre"
        End If
    End Sub


    Private Sub TxtIdentificacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIdentificacion.GotFocus
        TxtIdentificacion.Text = RTrim(TxtIdentificacion.Text)
        If TxtIdentificacion.Text = "Identificacion" Then
            TxtIdentificacion.Text = ""
        End If
    End Sub

    Private Sub TxtIdentificacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIdentificacion.LostFocus
        If TxtIdentificacion.Text = "" Then
            TxtIdentificacion.Text = "Identificacion"
        End If
    End Sub

    Private Sub TxtClave_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtClave.GotFocus
        If TxtClave.Text = "Clave" Then
            TxtClave.Text = ""
        End If
    End Sub

    Private Sub TxtClave_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtClave.LostFocus
        If TxtClave.Text = "" Then
            TxtClave.Text = "Clave"
        End If
    End Sub
    
    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim au As New AccionUsuario
        au.CargaCombo()
        au.CargarDatagrid(Me)
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim au As New AccionUsuario
        au.FiltrarUsuarios()
    End Sub

    Private Sub DtgUsuarios_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtgUsuarios.CellMouseClick
        Try
            Dim au As New AccionUsuario
            ActR = DtgUsuarios(0, e.RowIndex).Value
            au.CargaForm(e.RowIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim au As New AccionUsuario
        If MessageBox.Show("Esta seguro de querer eliminar el dato", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            au.ElmininarUsuario(ActR)
            au.CargarDatagrid(Me)
            au.LimpiarUsuario()
        End If
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        Dim au As New AccionUsuario
        au.LimpiarUsuario()
    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub
End Class