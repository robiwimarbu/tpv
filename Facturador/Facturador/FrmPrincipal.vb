Public Class FrmPrincipal
    Public UserActualNombre As String
    Public UserActualTipoUser As Integer
    Public UserActualId As Integer
    Private Sub GestionUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        FrmUsuarios.MdiParent = Me
        FrmUsuarios.StartPosition = FormStartPosition.CenterScreen
        FrmUsuarios.Show()
        Me.ToolStripStatusLabel1.Text = "Formulario Usuarios"

    End Sub


    Private Sub GestionClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionClientesToolStripMenuItem.Click
        FrmClientes.MdiParent = Me
        FrmClientes.StartPosition = FormStartPosition.CenterScreen
        FrmClientes.Show()
        Me.ToolStripStatusLabel1.Text = "Formulario Clientes"
    End Sub

    Private Sub GestionProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionProductosToolStripMenuItem.Click
        FrmProductos.MdiParent = Me
        FrmProductos.StartPosition = FormStartPosition.CenterScreen
        FrmProductos.Show()
        Me.ToolStripStatusLabel1.Text = "Formulario Productos"
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        FrmVentas.MdiParent = Me
        FrmVentas.StartPosition = FormStartPosition.CenterScreen
        FrmVentas.Show()
        Me.ToolStripStatusLabel1.Text = "Ventas"
    End Sub

    Private Sub FrmPrincipal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        CargarDatos()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip1.Enabled = False
        FrmLogin.MdiParent = Me
        FrmLogin.StartPosition = FormStartPosition.CenterScreen
        FrmLogin.Show()
    End Sub
    Public Sub CargarDatos()
        MenuStrip1.Enabled = True
        If UserActualTipoUser <> 1 Then
            MenuStrip1.Items(0).Visible = False
            MenuStrip1.Items(1).Visible = False
            MenuStrip1.Items(2).Visible = False
            MenuStrip1.Items(3).Enabled = True
            MenuStrip1.Items(4).Visible = False
        End If
        Me.Refresh()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        FrmConsultas.MdiParent = Me
        FrmConsultas.StartPosition = FormStartPosition.CenterScreen
        FrmConsultas.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FrmAcercade.MdiParent = Me
        FrmAcercade.StartPosition = FormStartPosition.CenterScreen
        FrmAcercade.Show()
    End Sub

    Private Sub VideoTutorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoTutorialToolStripMenuItem.Click
        FrmVideotutorial.MdiParent = Me
        FrmVideotutorial.StartPosition = FormStartPosition.CenterScreen
        FrmVideotutorial.Show()
    End Sub
End Class
