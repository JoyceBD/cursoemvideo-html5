Public Class frm_catalogo
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            frm_filme.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Try
            frm_filme.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i = 0 To 10
        'Dim foto As New PictureBox
        'foto.Size = New Size(50, 50)
        'foto.Location = New Point(10 * i + 50 * i, 20)
        'Me.Controls.Add(pic)
        ''foto.Load()
        ' foto.BackColor = Color.Red
        'Next
    End Sub
End Class
