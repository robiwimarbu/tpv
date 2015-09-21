<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GestionUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoTutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionUsuariosToolStripMenuItem, Me.GestionClientesToolStripMenuItem, Me.GestionProductosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 39)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 595)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(915, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'GestionUsuariosToolStripMenuItem
        '
        Me.GestionUsuariosToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.people
        Me.GestionUsuariosToolStripMenuItem.Name = "GestionUsuariosToolStripMenuItem"
        Me.GestionUsuariosToolStripMenuItem.Size = New System.Drawing.Size(123, 35)
        Me.GestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios"
        '
        'GestionClientesToolStripMenuItem
        '
        Me.GestionClientesToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.person
        Me.GestionClientesToolStripMenuItem.Name = "GestionClientesToolStripMenuItem"
        Me.GestionClientesToolStripMenuItem.Size = New System.Drawing.Size(120, 35)
        Me.GestionClientesToolStripMenuItem.Text = "Gestion Clientes"
        '
        'GestionProductosToolStripMenuItem
        '
        Me.GestionProductosToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.database
        Me.GestionProductosToolStripMenuItem.Name = "GestionProductosToolStripMenuItem"
        Me.GestionProductosToolStripMenuItem.Size = New System.Drawing.Size(132, 35)
        Me.GestionProductosToolStripMenuItem.Text = "Gestion Productos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.shopping_cart1
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(70, 35)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.pie_chart
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(87, 35)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VideoTutorialToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.ayuda
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(69, 35)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VideoTutorialToolStripMenuItem
        '
        Me.VideoTutorialToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.go
        Me.VideoTutorialToolStripMenuItem.Name = "VideoTutorialToolStripMenuItem"
        Me.VideoTutorialToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VideoTutorialToolStripMenuItem.Text = "VideoTutorial"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = Global.Facturador.My.Resources.Resources.about
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 617)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "TPV TACTIL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GestionUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoTutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
