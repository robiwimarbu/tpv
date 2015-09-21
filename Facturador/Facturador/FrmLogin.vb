Imports GestionSql
Public Class FrmLogin

    Private Sub TxtUser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUser.GotFocus
        If TxtUser.Text = "Usuario" Then
            TxtUser.Text = ""
        End If
    End Sub

    Private Sub TxtUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUser.LostFocus
        TxtUser.Text = RTrim(TxtUser.Text)
        If TxtUser.Text = "" Then
            TxtUser.Text = "Usuario"
        End If
    End Sub

    Private Sub TxtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPassword.GotFocus
        If TxtPassword.Text = "Clave" Then
            TxtPassword.Text = ""
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPassword.LostFocus
        If TxtPassword.Text = "" Then
            TxtPassword.Text = "Clave"
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim s As New ServiceLogin
        Dim t = s.ConsultaUsuario(TxtUser.Text, TxtPassword.Text)
        If t.Rows.Count > 0 Then
            FrmPrincipal.UserActualNombre = t(0)(1)
            FrmPrincipal.UserActualTipoUser = t(0)(4)
            FrmPrincipal.UserActualId = t(0)(0)
            FrmPrincipal.CargarDatos()
            Me.Close()
        Else
            MessageBox.Show("Error Usuario o Clave incorrecta")
        End If

    End Sub
End Class