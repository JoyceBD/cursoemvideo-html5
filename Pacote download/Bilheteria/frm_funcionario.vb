Public Class frm_funcionario
    Private Sub btn_compra_Click(sender As Object, e As EventArgs) Handles btn_compra.Click
        Try
            frm_catalogo.lbl_cpf.Text = lbl_cpf.Text
            frm_catalogo.lbl_conta.Text = "Funcionario"
            frm_catalogo.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub btn_gerenciar_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        Try
            frm_gclientes.lbl_volta.Text = "funcionario"
            frm_gclientes.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

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