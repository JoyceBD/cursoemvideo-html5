Public Class frm_adm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_gfilmes.Click
        frm_gerenciar_filmes.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_gfuncionarios.Click
        frm_gfuncionarios.Show()
        Me.Close()
    End Sub

    Private Sub btn_gclientes_Click(sender As Object, e As EventArgs) Handles btn_gclientes.Click
        frm_gclientes.lbl_volta.Text = "adm"
        frm_gclientes.Show()
        Me.Close()
    End Sub

    Private Sub btn_vendas_Click(sender As Object, e As EventArgs) Handles btn_vendas.Click
        frm_controle.Show()
        Me.Close()
    End Sub

    Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
        Try
            resp = MsgBox("Gostaria realmente de encerrar a sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema")
            If resp = vbYes Then
                frm_login.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class