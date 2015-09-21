Imports GestionSql
Imports System.Drawing.Printing
Public Class FrmVentas
    Public av As New AccionVenta
    Public usuario As Integer = FrmPrincipal.UserActualId
    Public IdProducto As Integer
    Public ActR As Integer
    Public des As Double
    Public ClienteActual As Integer
    Private Sub FrmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblVendedor.Text = FrmPrincipal.UserActualNombre
        LblFecha.Text = Now.ToShortDateString
        ParrillaImagenes()
    End Sub
    Public Sub ParrillaImagenes()
        Const Tamano As Integer = 100 'tamaño ancho alto de la imagen
        Const Columnas As Integer = 2 'cantida de columnas teniendo en cuenta inicia en 0
        Const distancia As Integer = 10 'distancia entre imagnes
        Dim panelImagenes As New Panel 'objeto de tipo panel para cargar en el imangenes
        panelImagenes.BackColor = Color.LightYellow
        panelImagenes.Top = 250
        panelImagenes.Left = 450
        panelImagenes.Width = 350
        panelImagenes.Height = 240
        panelImagenes.AutoScroll = True
        Me.Controls.Add(panelImagenes) 'agrego el panel a el formulario
        Dim t As New DataTable 'creo un datatable para cargar los datos de producto 
        Dim ap As New ServiceProducto 'objeto de tipo serviceproducto para realizar consulta de la DB
        t = ap.ConsultaProductos 'llamo a el metodo consulta productos y el resultado lo cargo en t
        Dim c As Integer = 0 'contador para columnas de la parrilla de imagenes
        Dim f As Integer = 0 'contador para fila de imagenes
        For Each row As DataRow In t.Rows 'inicio el recorrido de las filas de t cargo los datos en row
            Dim PB As New PictureBox 'objeto picturebox para cargar imagenes de producto
            Dim lbl As New Label 'objeto label para cargar nombre de productos
            PB.Height = Tamano - 10
            PB.Width = Tamano - 10
            PB.Name = row.Item(0).ToString() 'establesco el id del producto como name de la imagen
            lbl.Text = row.Item(1).ToString() 'texto con nombre producto
            AddHandler PB.Click, AddressOf Comprar 'añado el evento click de el picture box y envio a la funcion comprar
            'utilizo a C y a F para distanciar las imagenes y los textos
            If c = 0 Then
                PB.Left = distancia
                lbl.Left = distancia
            Else
                PB.Left = c * Tamano + (distancia * (c + 1))
                lbl.Left = c * Tamano + (distancia * (c + 1))
            End If
            If f = 0 Then
                PB.Top = distancia
                lbl.Top = Tamano - 10
            Else
                PB.Top = f * Tamano + (distancia * (f + 1))
                lbl.Top = f * Tamano + (distancia * (f + 10))
            End If
            'el picturebox establezco la propiedad strech
            PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            If row.Item(5).ToString() <> "" Then
                'creo un bitmap para convertir la cadena en una imagen
                Dim IMAGEN As New Bitmap(row.Item(5).ToString())
                PB.Image = IMAGEN 'cargo el objeto bitmap en el picture box
                panelImagenes.Controls.Add(lbl) 'agrego la etiqueta al panel
                panelImagenes.Controls.Add(PB) 'agrego el picture box al panel
            End If
            c += 1
            If c > Columnas Then
                f += 1
                c = 0
            End If
        Next
    End Sub
    Public Sub Comprar(ByVal sender As System.Object, ByVal e As EventArgs)
        'convierto el objeto en un picturebox para poder tomar todos los datos de la imagen
        'que origino el evento
        Dim f = TryCast(sender, PictureBox)
        Dim id As Integer = Integer.Parse(f.Name.ToString)
        IdProducto = id
        av.venta(id)
    End Sub

    Private Sub TxtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.TextChanged
        Try

            If TxtNombre.Text <> "" And TxtValu.Text <> "" Then
                Dim st As Double = Double.Parse(TxtValu.Text * TxtCantidad.Text)
                TxtSTotal.Text = st.ToString
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        av.LimpiarFrmVentas()
        av.BotonesModEli(False)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TxtCantidad.Text <> "" And TxtNombre.Text <> "" And TxtValu.Text <> "" And TxtSTotal.Text <> "" Then
            av.GuardarVenta()
        Else
            MessageBox.Show("Debe seleccionar producto y elegir cantidad", "Informacion", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        TxtCantidad.Text &= "1"
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        TxtCantidad.Text &= "2"
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        TxtCantidad.Text &= "3"
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        TxtCantidad.Text &= "4"
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        TxtCantidad.Text &= "5"
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        TxtCantidad.Text &= "6"
    End Sub

    Private Sub Btn7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn7.Click
        TxtCantidad.Text &= "7"
    End Sub

    Private Sub Btn8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn8.Click
        TxtCantidad.Text &= "8"
    End Sub

    Private Sub Btn9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn9.Click
        TxtCantidad.Text &= "9"
    End Sub

    Private Sub Btn0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn0.Click
        TxtCantidad.Text &= "0"
    End Sub

    Private Sub BtnPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPunto.Click
        TxtCantidad.Text &= "."
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim s As String = TxtCantidad.Text
        If TxtCantidad.TextLength > 0 Then
            TxtCantidad.Text = s.Remove(TxtCantidad.TextLength - 1)
        End If

    End Sub

    Private Sub DtgVentas_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtgVentas.CellMouseClick
        Try
            av.BotonesModEli(True)
            av.CargaForm(e.RowIndex)
            ActR = DtgVentas.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        av.ElmininarDetalleVEnta(ActR)
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        av.ActualizaDetalleVenta()
    End Sub

    Private Sub BtnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCobrar.Click
        If LblNumFact.Text <> "" Then
            If MessageBox.Show("Al imprimir la factura se cierra la venta actual", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Dim printDoc As New PrintDocument
                Dim ancho, alto As Short
                ancho = Short.Parse("300")
                Dim prFont As New Font("Courier New", 8, FontStyle.Bold)
                alto = (prFont.GetHeight() * DtgVentas.RowCount) + (prFont.GetHeight() * 10)  'alto dinamico segun cantidad de productos + las lineas para informacion
                Dim TamañoPersonal As Printing.PaperSize
                TamañoPersonal = New Printing.PaperSize("POS", ancho, alto)
                printDoc.DefaultPageSettings.PaperSize = TamañoPersonal

                ' asignamos el método de evento para cada página a imprimir
                AddHandler printDoc.PrintPage, AddressOf PrintDocument1_PrintPage
                ' indicamos que queremos imprimir
                printDoc.Print()
                av.CerrarVenta()
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim sv As New ServiceVenta
        Dim t As New DataTable
        t = sv.ConsultaVenta(LblNumFact.Text)
        Dim xPos As Single = e.PageBounds.Left + 10

        ' La fuente a usar
        Dim prFont As New Font("Courier New", 8, FontStyle.Bold)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        Dim linea As String = "Fecha: " & LblFecha.Text & vbNewLine
        linea &= "Vendedor: " & LblVendedor.Text & vbNewLine
        linea &= "Cliente: " & LblCliente.Text & vbNewLine
        linea &= "Factura: " & LblNumFact.Text & vbNewLine
        Dim suma As Double = 0
        For Each row As DataRow In t.Rows
            Dim producto As String = Mid(row(2).ToString, 1, 7) 'tamaño de nombre producto
            If producto.Length < 9 Then
                Dim dif = 8 - producto.Length
                Dim i As Integer
                For i = 0 To dif - 1 Step 1
                    producto &= " "
                Next
            End If

            Dim svalor As String = row(3).ToString
            Dim x As Integer
            Dim columnav As String = ""
            For x = 0 To 10 - svalor.Length Step 1 'columna valor
                columnav &= " "
            Next
            columnav &= row(3).ToString

            Dim sCantidad As String = row(4).ToString
            Dim columnac As String = ""
            For x = 0 To 6 - sCantidad.Length Step 1 'columna cantidad
                columnac &= " "
            Next
            columnac &= row(4).ToString

            Dim total As Double = row(3) * row(4) 'calcula totales por producto
            Dim sTotal As String = total.ToString
            Dim columnat As String = ""
            For x = 0 To 10 - sTotal.Length Step 1 'columna cantidad
                columnat &= " "
            Next
            columnat &= total

            suma = suma + total

            linea &= UCase(producto) & " " & columnav & " " & columnac & " " & columnat & vbNewLine
        Next
        Dim columnavt As String = ""
        Dim x1 As Integer
        Dim st As String = suma.ToString
        For x1 = 0 To 31 - st.Length Step 1 'columna cantidad
            columnavt &= "_"
        Next
        columnavt &= st
        linea &= "Total   " & columnavt
        ' imprimimos la cadena

        e.Graphics.DrawString(linea, prFont, Brushes.Black, xPos, yPos)
        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False
    End Sub

    Private Sub BtnEliminarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarFactura.Click
        If LblNumFact.Text <> "" Then
            If MessageBox.Show("Desea Eliminar Factura", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                av.EliminaVenta()
            End If
        End If

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        If DtgVentas.RowCount > 0 Then 'si la factura ya tiene datos
            If MessageBox.Show("Aun no ha imprimido  la factura, si tiene datos esto no seran eliminados", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                ActR = 0
                des = 0
                ClienteActual = 0
                LblCliente.Text = ""
                av.LimpiarFrmVentas()
                av.CerrarVenta()
            End If
        Else 'si la factura no tiene datos solo borra para permitir un nuevo inicio
            ActR = 0
            des = 0
            ClienteActual = 0
            LblCliente.Text = ""
            av.LimpiarFrmVentas()
            av.CerrarVenta()
        End If
    End Sub
End Class