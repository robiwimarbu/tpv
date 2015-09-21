<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDato
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
        Me.TxtIdentificacion = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.RbtClienteRegistrado = New System.Windows.Forms.RadioButton()
        Me.RbtClienteNoRegistrado = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'TxtIdentificacion
        '
        Me.TxtIdentificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TxtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentificacion.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentificacion.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtIdentificacion.Location = New System.Drawing.Point(76, 59)
        Me.TxtIdentificacion.Name = "TxtIdentificacion"
        Me.TxtIdentificacion.Size = New System.Drawing.Size(352, 32)
        Me.TxtIdentificacion.TabIndex = 28
        Me.TxtIdentificacion.Text = "Identificacion Cliente"
        Me.TxtIdentificacion.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnGuardar.Image = Global.Facturador.My.Resources.Resources.apply
        Me.BtnGuardar.Location = New System.Drawing.Point(224, 113)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(57, 36)
        Me.BtnGuardar.TabIndex = 29
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'RbtClienteRegistrado
        '
        Me.RbtClienteRegistrado.AutoSize = True
        Me.RbtClienteRegistrado.Location = New System.Drawing.Point(145, 22)
        Me.RbtClienteRegistrado.Name = "RbtClienteRegistrado"
        Me.RbtClienteRegistrado.Size = New System.Drawing.Size(111, 17)
        Me.RbtClienteRegistrado.TabIndex = 30
        Me.RbtClienteRegistrado.TabStop = True
        Me.RbtClienteRegistrado.Text = "Cliente Registrado"
        Me.RbtClienteRegistrado.UseVisualStyleBackColor = True
        '
        'RbtClienteNoRegistrado
        '
        Me.RbtClienteNoRegistrado.AutoSize = True
        Me.RbtClienteNoRegistrado.Location = New System.Drawing.Point(272, 22)
        Me.RbtClienteNoRegistrado.Name = "RbtClienteNoRegistrado"
        Me.RbtClienteNoRegistrado.Size = New System.Drawing.Size(120, 17)
        Me.RbtClienteNoRegistrado.TabIndex = 31
        Me.RbtClienteNoRegistrado.TabStop = True
        Me.RbtClienteNoRegistrado.Text = "Cliente Sin Registrar"
        Me.RbtClienteNoRegistrado.UseVisualStyleBackColor = True
        '
        'FrmDato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 171)
        Me.Controls.Add(Me.RbtClienteNoRegistrado)
        Me.Controls.Add(Me.RbtClienteRegistrado)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtIdentificacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDato"
        Me.Text = "FrmDato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents RbtClienteRegistrado As System.Windows.Forms.RadioButton
    Friend WithEvents RbtClienteNoRegistrado As System.Windows.Forms.RadioButton
End Class
