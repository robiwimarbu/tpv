Public Class FrmProductos

    Public Actr, FilAct As Integer
    Public accion As String = "Guardar"
    Public ap As New AccionProducto
    
    Private Sub BtnIamagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIamagen.Click
        Dim filedia As New OpenFileDialog
        filedia.Filter = "Imagenes (*.jpg)|*.jpg| Imagenes (*.png)|*.png"
        If filedia.ShowDialog() = DialogResult.OK Then
            Dim s As String
            s = filedia.FileName
            PBimagen.ImageLocation = s
        End If
    End Sub

   

    Private Sub FrmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ap.CargaCombo()
        ap.CargarDatagrid(Me)
    End Sub

    Private Sub BtbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If accion = "Guardar" Then
            ap.AccionGuardarProducto(Me)
        Else
            ap.ActualizaProducto(Me)
        End If

    End Sub

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
    Private Sub TxtValor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtValor.GotFocus
        If TxtValor.Text = "Valor" Then
            TxtValor.Text = ""
        End If
    End Sub

    Private Sub TxtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtValor.LostFocus
        TxtValor.Text = RTrim(TxtValor.Text)
        If TxtValor.Text = "" Then
            TxtValor.Text = "Valor"
        End If
    End Sub

    Private Sub TxtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescripcion.GotFocus
        If TxtDescripcion.Text = "Descripcion" Then
            TxtDescripcion.Text = ""
        End If
    End Sub

    Private Sub TxtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescripcion.LostFocus
        TxtDescripcion.Text = RTrim(TxtDescripcion.Text)
        If TxtDescripcion.Text = "" Then
            TxtDescripcion.Text = "Descripcion"
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea Eliminar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim imagen As String = DtgProductos(5, FilAct).Value
            ap.ElmininarProducto(Actr, imagen)
        End If
    End Sub

    Private Sub DtgProductos_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtgProductos.CellMouseClick
        Try
            Actr = DtgProductos(0, e.RowIndex).Value
            FilAct = e.RowIndex
            ap.CargaForm(e.RowIndex)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        ap.LimpiarProducto()
    End Sub

    Private Sub CmbCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCategoria.SelectedIndexChanged
        'MessageBox.Show(CmbCategoria.Text)
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        ap.FiltrarProductos()
    End Sub
End Class