Public Class FrmConsultas

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim ac As New AccionConsulta
        ac.consulta()

    End Sub
End Class