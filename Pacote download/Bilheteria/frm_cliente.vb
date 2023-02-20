Public Class frm_cliente
    Private Sub frm_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_catalogo.Click
        Try
            'frm_catalogo.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            frm_catalogo.lbl_conta.Text = "Cliente"
            frm_catalogo.lbl_cpf.Text = lbl_cliente.Text
            frm_catalogo.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_historico.Click
        Try
            frm_historico.lbl_cliente.Text = lbl_cliente.Text
            frm_historico.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
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