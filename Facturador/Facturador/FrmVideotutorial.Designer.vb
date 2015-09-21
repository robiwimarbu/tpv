<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVideotutorial
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
        Me.BtnIntroduccion = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnClient = New System.Windows.Forms.Button()
        Me.BtnProd = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnConsultas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnIntroduccion
        '
        Me.BtnIntroduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIntroduccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIntroduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIntroduccion.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnIntroduccion.Location = New System.Drawing.Point(4, 15)
        Me.BtnIntroduccion.Name = "BtnIntroduccion"
        Me.BtnIntroduccion.Size = New System.Drawing.Size(187, 43)
        Me.BtnIntroduccion.TabIndex = 24
        Me.BtnIntroduccion.Text = "Como Entrar?"
        Me.BtnIntroduccion.UseVisualStyleBackColor = False
        '
        'BtnUser
        '
        Me.BtnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUser.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnUser.Location = New System.Drawing.Point(4, 62)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(187, 43)
        Me.BtnUser.TabIndex = 25
        Me.BtnUser.Text = "Gestion usuarios"
        Me.BtnUser.UseVisualStyleBackColor = False
        '
        'BtnClient
        '
        Me.BtnClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClient.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnClient.Location = New System.Drawing.Point(4, 110)
        Me.BtnClient.Name = "BtnClient"
        Me.BtnClient.Size = New System.Drawing.Size(187, 43)
        Me.BtnClient.TabIndex = 26
        Me.BtnClient.Text = "Gestion Clientes"
        Me.BtnClient.UseVisualStyleBackColor = False
        '
        'BtnProd
        '
        Me.BtnProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProd.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnProd.Location = New System.Drawing.Point(4, 157)
        Me.BtnProd.Name = "BtnProd"
        Me.BtnProd.Size = New System.Drawing.Size(187, 43)
        Me.BtnProd.TabIndex = 27
        Me.BtnProd.Text = "Productos"
        Me.BtnProd.UseVisualStyleBackColor = False
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnVentas.Location = New System.Drawing.Point(4, 205)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(187, 43)
        Me.BtnVentas.TabIndex = 28
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'BtnConsultas
        '
        Me.BtnConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnConsultas.Location = New System.Drawing.Point(4, 252)
        Me.BtnConsultas.Name = "BtnConsultas"
        Me.BtnConsultas.Size = New System.Drawing.Size(187, 43)
        Me.BtnConsultas.TabIndex = 29
        Me.BtnConsultas.Text = "Consultas"
        Me.BtnConsultas.UseVisualStyleBackColor = False
        '
        'FrmVideotutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(884, 465)
        Me.Controls.Add(Me.BtnConsultas)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.BtnProd)
        Me.Controls.Add(Me.BtnClient)
        Me.Controls.Add(Me.BtnUser)
        Me.Controls.Add(Me.BtnIntroduccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmVideotutorial"
        Me.Text = "FrmVideotutorial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnIntroduccion As System.Windows.Forms.Button
    Friend WithEvents BtnUser As System.Windows.Forms.Button
    Friend WithEvents BtnClient As System.Windows.Forms.Button
    Friend WithEvents BtnProd As System.Windows.Forms.Button
    Friend WithEvents BtnVentas As System.Windows.Forms.Button
    Friend WithEvents BtnConsultas As System.Windows.Forms.Button
End Class
