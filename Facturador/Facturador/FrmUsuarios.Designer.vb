<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtIdentificacion = New System.Windows.Forms.TextBox()
        Me.DtgUsuarios = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.CmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        CType(Me.DtgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.Image = Global.Facturador.My.Resources.Resources.apply
        Me.BtnGuardar.Location = New System.Drawing.Point(417, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(109, 35)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtNombre.Location = New System.Drawing.Point(39, 12)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(328, 32)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.Text = "Nombre  "
        '
        'TxtIdentificacion
        '
        Me.TxtIdentificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentificacion.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentificacion.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtIdentificacion.Location = New System.Drawing.Point(39, 50)
        Me.TxtIdentificacion.Name = "TxtIdentificacion"
        Me.TxtIdentificacion.Size = New System.Drawing.Size(328, 32)
        Me.TxtIdentificacion.TabIndex = 2
        Me.TxtIdentificacion.Text = "Identificacion"
        '
        'DtgUsuarios
        '
        Me.DtgUsuarios.AllowUserToAddRows = False
        Me.DtgUsuarios.AllowUserToDeleteRows = False
        Me.DtgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgUsuarios.Location = New System.Drawing.Point(39, 171)
        Me.DtgUsuarios.Name = "DtgUsuarios"
        Me.DtgUsuarios.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgUsuarios.RowHeadersVisible = False
        Me.DtgUsuarios.Size = New System.Drawing.Size(487, 176)
        Me.DtgUsuarios.TabIndex = 9
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEliminar.Image = Global.Facturador.My.Resources.Resources._erase
        Me.BtnEliminar.Location = New System.Drawing.Point(417, 85)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(109, 35)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'CmbTipoUsuario
        '
        Me.CmbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmbTipoUsuario.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoUsuario.FormattingEnabled = True
        Me.CmbTipoUsuario.Location = New System.Drawing.Point(39, 129)
        Me.CmbTipoUsuario.Name = "CmbTipoUsuario"
        Me.CmbTipoUsuario.Size = New System.Drawing.Size(328, 36)
        Me.CmbTipoUsuario.TabIndex = 4
        '
        'TxtClave
        '
        Me.TxtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtClave.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtClave.Location = New System.Drawing.Point(39, 91)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(328, 32)
        Me.TxtClave.TabIndex = 3
        Me.TxtClave.Text = "Clave"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLimpiar.Image = Global.Facturador.My.Resources.Resources.invoice
        Me.BtnLimpiar.Location = New System.Drawing.Point(417, 123)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(109, 35)
        Me.BtnLimpiar.TabIndex = 8
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnBuscar.Image = Global.Facturador.My.Resources.Resources.find
        Me.BtnBuscar.Location = New System.Drawing.Point(417, 48)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(109, 35)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 349)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.CmbTipoUsuario)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DtgUsuarios)
        Me.Controls.Add(Me.TxtIdentificacion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion de usuarios"
        CType(Me.DtgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents CmbTipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents DtgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
End Class
