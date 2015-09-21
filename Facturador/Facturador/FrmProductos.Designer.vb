<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DtgProductos = New System.Windows.Forms.DataGridView()
        Me.PBimagen = New System.Windows.Forms.PictureBox()
        Me.BtnIamagen = New System.Windows.Forms.Button()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLimpiar.Image = Global.Facturador.My.Resources.Resources.invoice
        Me.BtnLimpiar.Location = New System.Drawing.Point(374, 191)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(109, 32)
        Me.BtnLimpiar.TabIndex = 9
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtNombre.Location = New System.Drawing.Point(26, 23)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(328, 32)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.Text = "Nombre   "
        '
        'TxtValor
        '
        Me.TxtValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtValor.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtValor.Location = New System.Drawing.Point(26, 60)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(328, 32)
        Me.TxtValor.TabIndex = 2
        Me.TxtValor.Text = "Valor"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnBuscar.Image = Global.Facturador.My.Resources.Resources.find
        Me.BtnBuscar.Location = New System.Drawing.Point(259, 191)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(109, 32)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtDescripcion.Location = New System.Drawing.Point(26, 96)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(328, 32)
        Me.TxtDescripcion.TabIndex = 3
        Me.TxtDescripcion.Text = "Descripcion"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEliminar.Image = Global.Facturador.My.Resources.Resources._erase
        Me.BtnEliminar.Location = New System.Drawing.Point(144, 191)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(109, 32)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnGuardar.Image = Global.Facturador.My.Resources.Resources.apply
        Me.BtnGuardar.Location = New System.Drawing.Point(29, 191)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(109, 32)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'DtgProductos
        '
        Me.DtgProductos.AllowUserToAddRows = False
        Me.DtgProductos.AllowUserToDeleteRows = False
        Me.DtgProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgProductos.Location = New System.Drawing.Point(29, 233)
        Me.DtgProductos.Name = "DtgProductos"
        Me.DtgProductos.ReadOnly = True
        Me.DtgProductos.RowHeadersVisible = False
        Me.DtgProductos.Size = New System.Drawing.Size(487, 167)
        Me.DtgProductos.TabIndex = 10
        '
        'PBimagen
        '
        Me.PBimagen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PBimagen.Location = New System.Drawing.Point(394, 23)
        Me.PBimagen.Name = "PBimagen"
        Me.PBimagen.Size = New System.Drawing.Size(121, 102)
        Me.PBimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBimagen.TabIndex = 19
        Me.PBimagen.TabStop = False
        '
        'BtnIamagen
        '
        Me.BtnIamagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIamagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIamagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIamagen.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnIamagen.Location = New System.Drawing.Point(394, 131)
        Me.BtnIamagen.Name = "BtnIamagen"
        Me.BtnIamagen.Size = New System.Drawing.Size(121, 32)
        Me.BtnIamagen.TabIndex = 5
        Me.BtnIamagen.Text = "Imagen"
        Me.BtnIamagen.UseVisualStyleBackColor = False
        '
        'CmbCategoria
        '
        Me.CmbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmbCategoria.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(27, 131)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(328, 36)
        Me.CmbCategoria.TabIndex = 4
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(580, 412)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.BtnIamagen)
        Me.Controls.Add(Me.PBimagen)
        Me.Controls.Add(Me.DtgProductos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmProductos"
        Me.Text = "Productos"
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents DtgProductos As System.Windows.Forms.DataGridView
    Friend WithEvents PBimagen As System.Windows.Forms.PictureBox
    Friend WithEvents BtnIamagen As System.Windows.Forms.Button
    Friend WithEvents CmbCategoria As System.Windows.Forms.ComboBox
End Class
