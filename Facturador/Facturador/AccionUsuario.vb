Imports System.Data
Imports System.Data.OleDb
Imports GestionSql
Public Class AccionUsuario
    Public Sub AccionGuardarUsuario(ByRef DATOS As FrmUsuarios)
        Dim Er As Integer = 0 'variable usada para medir si existe un error
        Er = ValidaFormUsuario(DATOS)
        If Er = 0 Then
            Dim p As New ServiceUsuario
            p.SaveUsuario(DATOS.TxtNombre.Text, DATOS.TxtIdentificacion.Text, DATOS.TxtClave.Text, DATOS.CmbTipoUsuario.SelectedValue)

        End If
    End Sub
    Public Sub CargarDatagrid(ByRef DATOS As FrmUsuarios)
        Dim p As New ServiceUsuario
        Dim t As New DataTable
        t = p.Consulta()
        FrmUsuarios.DtgUsuarios.DataSource = t
        FrmUsuarios.DtgUsuarios.Columns(0).Visible = False
        FrmUsuarios.DtgUsuarios.Columns(0).Visible = False
        FrmUsuarios.DtgUsuarios.Columns("Nombres").Width = 150
        FrmUsuarios.DtgUsuarios.Columns("Identificacion").Width = 135
        FrmUsuarios.DtgUsuarios.Columns("Clave").Width = 95
        FrmUsuarios.DtgUsuarios.Columns("TipoUsuario").Width = 105
    End Sub
    Public Sub ElmininarUsuario(ByVal id As Integer)
        Dim p As New ServiceUsuario
        p.EliminarUsuario(id)
    End Sub
    Public Sub FiltrarUsuarios()
        Dim p As New ServiceUsuario
        Dim t As New DataTable
        t = p.Consulta(FrmUsuarios.TxtNombre.Text, FrmUsuarios.TxtIdentificacion.Text)
        FrmUsuarios.DtgUsuarios.DataSource = t
        FrmUsuarios.DtgUsuarios.Columns(0).Visible = False
    End Sub
    Public Sub CargaForm(ByVal id As Integer)
        FrmUsuarios.accion = "Actualizar"
        FrmUsuarios.BtnGuardar.Image = Facturador.My.Resources.Resources.modify
        FrmUsuarios.TxtNombre.Text = FrmUsuarios.DtgUsuarios.Rows(id).Cells(1).Value
        FrmUsuarios.TxtIdentificacion.Text = FrmUsuarios.DtgUsuarios.Rows(id).Cells(2).Value
        FrmUsuarios.TxtClave.Text = FrmUsuarios.DtgUsuarios.Rows(id).Cells(3).Value
        FrmUsuarios.CmbTipoUsuario.SelectedIndex = FrmUsuarios.DtgUsuarios.Rows(id).Cells(4).Value
        FrmUsuarios.Refresh()
    End Sub
    Public Sub LimpiarUsuario()
        FrmUsuarios.accion = "Guardar"
        FrmUsuarios.BtnGuardar.Image = Facturador.My.Resources.Resources.apply
        FrmUsuarios.TxtNombre.Text = "Nombre"
        FrmUsuarios.TxtIdentificacion.Text = "Identificacion"
        FrmUsuarios.TxtClave.Text = "Clave"
        FrmUsuarios.CmbTipoUsuario.SelectedIndex = 0
        CargarDatagrid(FrmUsuarios)
    End Sub
    Public Sub ActualizaUsuario()
        Dim er As Integer
        er = ValidaFormUsuario(FrmUsuarios)
        If er = 0 Then
            Dim p As New ServiceUsuario
            p.UpdateCliente(FrmUsuarios.TxtNombre.Text, FrmUsuarios.TxtIdentificacion.Text, FrmUsuarios.TxtClave.Text, FrmUsuarios.CmbTipoUsuario.SelectedIndex, FrmUsuarios.ActR)
        End If
    End Sub
    Public Sub CargaCombo()
        Dim p As New ServiceUsuario
        Dim t As New DataTable
        t = p.CargaComboBoxTipoUsuario()
        FrmUsuarios.CmbTipoUsuario.DataSource = t
        FrmUsuarios.CmbTipoUsuario.DisplayMember = "Tipo"
        FrmUsuarios.CmbTipoUsuario.ValueMember = "Id"
    End Sub
    Public Function ValidaFormUsuario(ByRef DATOS As FrmUsuarios) As Integer
        Dim Er As Integer = 0 'variable usada para medir si existe un error
        Dim msj As String = "Se detectaron los siguiente errores" & vbCr 'variable que guarda el mensaje de error segun este suceda
        If DATOS.TxtNombre.TextLength = 0 OrElse RTrim(DATOS.TxtNombre.Text) = "Nombre" Then
            msj &= "Nombre para el usuario" & vbCr
            Er += 1
        End If
        If DATOS.TxtIdentificacion.TextLength < 5 OrElse DATOS.TxtIdentificacion.Text = "Identificacion" Then
            msj &= "Identificacion Usuario incorrecta" & vbCr
            Er += 1
        End If
        If DATOS.TxtClave.TextLength < 5 OrElse DATOS.TxtClave.Text = "Clave" Then
            msj &= "Clave de Usuario " & vbCr
            Er += 1
        End If
        If DATOS.CmbTipoUsuario.SelectedValue = 0 Then
            msj &= "Seleccione Tipo de Usuario" & vbCr
            Er += 1
        End If
        If Er > 0 Then
            MessageBox.Show(msj, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return Er
    End Function

End Class
