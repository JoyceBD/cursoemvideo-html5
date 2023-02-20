Public Class frm_boleto
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_retornar.Click
        frm_cliente.Show()
        Me.Close()
    End Sub

    Private Sub frm_boleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)
    End Sub
End Class