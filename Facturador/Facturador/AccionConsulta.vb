Imports GestionSql
Public Class AccionConsulta
    Public sc As New ServiceConsulta
    Public Sub consulta()
        Dim fc As New DateTime
        fc = FrmConsultas.DTPFecha.Text
        fc.ToString("#dd/MM/yyyy hh:mm:ss tt.#")
        Dim IdCliente As Integer = 0
        Dim dt As New DataTable
        Try
            If FrmConsultas.TxtCodigo.TextLength > 0 And FrmConsultas.TxtCodigo.Text <> "Codigo Cliente" Then
                Dim Cli As New ServiceCliente
                dt = Cli.ConsultaCliente(FrmConsultas.TxtCodigo.Text)
                If dt.Rows.Count > 0 Then
                    IdCliente = dt(0)("Id")
                Else
                    MessageBox.Show("CLiente No Existe")
                    Exit Sub
                End If
            End If
            If IdCliente <> 0 And FrmConsultas.DTPFecha.Text <> "" Then
                If FrmConsultas.ChkFecha.Checked = True Then
                    FrmConsultas.DtgConsulta.DataSource = sc.Consulta(fc, IdCliente)
                Else
                    FrmConsultas.DtgConsulta.DataSource = sc.Consulta(IdCliente)
                End If
            ElseIf IdCliente = 0 Then
                If FrmConsultas.ChkFecha.Checked = True Then
                    FrmConsultas.DtgConsulta.DataSource = sc.Consulta(fc)
                End If

            End If
            dt = FrmConsultas.DtgConsulta.DataSource
            Totalizar(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
    Public Sub Totalizar(ByRef dt As DataTable)
        Dim total As Double = 0
        For Each sum As DataRow In dt.Rows
            total = total + sum.Item(5)
        Next
        FrmConsultas.TxtTotal.Text = total.ToString
    End Sub
End Class
