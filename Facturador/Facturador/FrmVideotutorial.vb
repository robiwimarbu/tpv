Public Class FrmVideotutorial
    Public WME As New AxWMPLib.AxWindowsMediaPlayer()
    Private Sub BtnIntroduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIntroduccion.Click
        Try
            WME.URL = "AyudaTpv\Introduccion TPV.mp4"
        Catch ex As Exception
        End Try

    End Sub

    Private Sub FrmVideotutorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WME.Size = New Size(1280 / 1.9, 720 / 1.9)
        WME.Top = 10
        WME.Left = 200
        Me.Controls.Add(WME)
    End Sub

    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUser.Click
        WME.URL = "AyudaTpv\GestionUsuarios.mp4"
    End Sub

    Private Sub BtnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClient.Click
        WME.URL = "AyudaTpv\GestionClientes.mp4"
    End Sub

    Private Sub BtnProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProd.Click
        WME.URL = "AyudaTpv\GestionProductos.mp4"
    End Sub

    Private Sub BtnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click
        WME.URL = "AyudaTpv\ventas.mp4"
    End Sub

    Private Sub BtnConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultas.Click
        WME.URL = "AyudaTpv\consultas.mp4"
    End Sub
End Class