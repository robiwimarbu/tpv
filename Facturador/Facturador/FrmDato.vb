Imports GestionSql
Public Class FrmDato

    Private Sub RbtClienteRegistrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtClienteRegistrado.CheckedChanged
        If RbtClienteRegistrado.Checked Then
            TxtIdentificacion.Visible = True
        End If
    End Sub

    Private Sub RbtClienteNoRegistrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtClienteNoRegistrado.CheckedChanged
        If RbtClienteNoRegistrado.Checked Then
            TxtIdentificacion.Visible = False
        End If
    End Sub

    Private Sub TxtIdentificacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIdentificacion.GotFocus
        If TxtIdentificacion.Text = "Identificacion Cliente" Then
            TxtIdentificacion.Clear()
        End If
    End Sub

    Private Sub TxtIdentificacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIdentificacion.LostFocus
        If TxtIdentificacion.Text = "" Then
            TxtIdentificacion.Text = "Identificacion Cliente"
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If RbtClienteNoRegistrado.Checked Then
            FrmVentas.LblCliente.Text = "Cliente sin registrar"
            'AgregaFactura(0)
            FrmVentas.ClienteActual = 0
            Me.Close()
        ElseIf RbtClienteRegistrado.Checked Then
            Dim C As New ServiceCliente
            Dim t As New DataTable
            t = C.ConsultaCliente(TxtIdentificacion.Text)
            Dim nombre As String = ""
            If t.Rows.Count > 0 Then
                nombre = "Nombre del cliente: "
                nombre &= t(0)("Nombres")
                FrmVentas.LblCliente.Text = t(0)("Nombres")
                FrmVentas.ClienteActual = t(0)("Id")
                Me.Close()
            Else
                nombre = "No se encuentra cliente"
                MessageBox.Show(nombre)
            End If

            End If

    End Sub
    
    Private Sub FrmDato_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If RbtClienteRegistrado.Checked = False Then
            FrmVentas.ClienteActual = 0
        End If
    End Sub
End Class