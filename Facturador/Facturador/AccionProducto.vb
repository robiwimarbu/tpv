Imports System.Data
Imports System.Data.OleDb
Imports GestionSql
Imports System.IO
Public Class AccionProducto
    Public Sub AccionGuardarProducto(ByRef DATOS As FrmProductos)
        Dim Er As Integer = 0 'variable usada para medir si existe un error
        Er = ValidaFormProdudto(DATOS)
        If Er = 0 Then
            Dim img As String
            If DATOS.PBimagen.ImageLocation <> Nothing Then
                img = CopiarFoto(DATOS.PBimagen.ImageLocation)
            Else
                img = ""
            End If
            Dim p As New ServiceProducto
            p.SaveProducto(DATOS.TxtNombre.Text, DATOS.TxtDescripcion.Text, DATOS.CmbCategoria.SelectedValue, Double.Parse(DATOS.TxtValor.Text), img)
        End If
        CargarDatagrid(FrmProductos)
    End Sub
    Public Sub CargarDatagrid(ByRef DATOS As FrmProductos)
        Dim p As New ServiceProducto
        Dim t As New DataTable
        t = p.ConsultaProductos()
        FrmProductos.DtgProductos.DataSource = t
    End Sub
    Public Sub ElmininarProducto(ByVal id As Integer, ByVal imagen As String)
        Dim p As New ServiceProducto
        If p.EliminarProducto(id) > 0 Then
            EliminarFoto(imagen)
            CargarDatagrid(FrmProductos)
        End If
    End Sub
    Public Sub FiltrarProductos() 'filtro por nombre producto or categoria o ambas
        Dim p As New ServiceProducto
        Dim t As New DataTable
        t = p.ConsultaProductos(FrmProductos.TxtNombre.Text, FrmProductos.CmbCategoria.SelectedValue)
        FrmProductos.DtgProductos.DataSource = t
    End Sub
    Public Sub CargaForm(ByVal id As Integer) 'carga formulario con datos seleccionado en datagrid
        FrmProductos.BtnGuardar.Image = Facturador.My.Resources.Resources.modify
        FrmProductos.accion = "Actualizar"
        FrmProductos.TxtNombre.Text = FrmProductos.DtgProductos.Rows(id).Cells(1).Value
        FrmProductos.TxtDescripcion.Text = FrmProductos.DtgProductos.Rows(id).Cells(2).Value
        FrmProductos.CmbCategoria.SelectedIndex = FrmProductos.DtgProductos.Rows(id).Cells(3).Value
        FrmProductos.TxtValor.Text = FrmProductos.DtgProductos.Rows(id).Cells(4).Value.ToString
        FrmProductos.PBimagen.ImageLocation = FrmProductos.DtgProductos.Rows(id).Cells(5).Value.ToString
        FrmProductos.Refresh()
    End Sub
    Public Sub LimpiarProducto() 'prepara el formulario para nuevas acciones
        FrmProductos.BtnGuardar.Image = Facturador.My.Resources.Resources.apply
        FrmProductos.accion = "Guardar"
        FrmProductos.TxtNombre.Text = "Nombre"
        FrmProductos.TxtDescripcion.Text = "Descripcion"
        FrmProductos.TxtValor.Text = "Valor"
        FrmProductos.CmbCategoria.SelectedIndex = 0
        FrmProductos.PBimagen.ImageLocation = ""
        CargarDatagrid(FrmProductos)
    End Sub
    Public Sub ActualizaProducto(ByRef datos As FrmProductos)
        Dim er As Integer
        er = ValidaFormProdudto(FrmProductos)
        Dim img As String = datos.PBimagen.ImageLocation 'imagen actual en el pbimagen
        Dim imgant As String = FrmProductos.DtgProductos.Rows(datos.FilAct).Cells(5).Value.ToString 'imagen antigua en el datragrid
        If er = 0 Then
            Dim p As New ServiceProducto
            If img <> "" And img <> imgant Then
                img = CopiarFoto(img) 'copio la nueva imagen y guardoresultado en la var img para enviar a la db
            End If
            If p.UpdateProducto(datos.TxtNombre.Text, datos.TxtDescripcion.Text, datos.CmbCategoria.SelectedValue, Double.Parse(datos.TxtValor.Text), img, datos.Actr) > 0 Then
                If imgant <> "" And imgant <> img Then
                    EliminarFoto(imgant) 'si la actualizacion es OK borro la antigua imagen
                End If
                CargarDatagrid(datos)
            End If
        Else
            If img <> "" And img <> imgant Then
                EliminarFoto(img) 'si no pudo actualizar borro la imagen si era nueva
            End If
        End If
    End Sub
    Public Sub CargaCombo()
        Dim p As New ServiceProducto
        Dim t As New DataTable
        t = p.CargaComboBoxCategoria()
        FrmProductos.CmbCategoria.DataSource = t
        FrmProductos.CmbCategoria.DisplayMember = "Nombre"
        FrmProductos.CmbCategoria.ValueMember = "Id"
    End Sub
    Public Function ValidaFormProdudto(ByRef DATOS As FrmProductos) As Integer
        Dim Er As Integer = 0 'variable usada para medir si existe un error
        Dim msj As String = "Se detectaron los siguiente errores" & vbCr 'variable que guarda el mensaje de error segun este suceda
        If DATOS.TxtNombre.TextLength = 0 OrElse RTrim(DATOS.TxtNombre.Text) = "Nombre" Then
            msj &= "Nombre para el producto" & vbCr
            Er += 1
        End If
        If DATOS.TxtValor.TextLength < 0 OrElse Not IsNumeric(DATOS.TxtValor.Text) Then
            msj &= "Valor producto" & vbCr
            Er += 1
        End If

        If DATOS.CmbCategoria.SelectedValue = 0 Then
            msj &= "Seleccione categoria" & vbCr
            Er += 1
        End If
        If Er > 0 Then
            MessageBox.Show(msj, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return Er
    End Function
    Public Function CopiarFoto(ByVal ruta As String) As String
        Dim nombre As String
        Dim Random As New Random()
        Dim numero As Integer = Random.Next(1, 100)
        nombre = Path.GetFileName(ruta)
        Dim t As New DateTime
        Dim dirname As String = "ImgProductos\" & numero.ToString & nombre
        FileCopy(ruta, dirname)
        Return dirname
    End Function
    Public Sub EliminarFoto(ByVal ruta As String)
        Try
            My.Computer.FileSystem.DeleteFile(ruta)
        Catch ex As Exception
        End Try
    End Sub

End Class
