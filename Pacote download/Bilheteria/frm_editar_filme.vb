Public Class frm_editar_filme
    Private Sub frm_editar_filme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()
            preencher_cmd(cmb_indicacao)

            sql = "select * from tb_filmes where id_filme= " & lbl_id.Text & ""
            rs = db.Execute(sql)
            PictureBox1.Load(rs.Fields(3).Value)
            txt_nome_filme.Text = rs.Fields(1).Value
            txt_sinopse.Text = rs.Fields(2).Value
            txt_valor.Text = rs.Fields(8).Value
            cmb_indicacao.SelectedItem = rs.Fields(4).Value
            chk_dub.Checked = rs.Fields(5).Value
            chk_leg.Checked = rs.Fields(6).Value
            chk_3d.Checked = rs.Fields(7).Value
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        Try
            If PictureBox1.Image Is Nothing Or
            String.IsNullOrEmpty(txt_nome_filme.Text) Or
            String.IsNullOrEmpty(txt_sinopse.Text) Or
            String.IsNullOrEmpty(txt_valor.Text) Or
            (chk_3d.Checked = False And chk_dub.Checked = False And chk_leg.Checked = False) Then
                MsgBox("Preencha todos os campos corretamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            sql = "update tb_filmes set Nome_filme = '" & txt_nome_filme.Text & "', " &
            "Sinopse_filme = '" & txt_sinopse.Text & "', cartaz_filme = '" & PictureBox1.ImageLocation & "', " &
            "classificacao_filme = '" & cmb_indicacao.Text & "', Dublado = " & chk_dub.Checked & ", Legendado = " & chk_leg.Checked & ", " &
            "3D = " & chk_3d.Checked & ", Valor = " & txt_valor.Text & " where id_filme = " & lbl_id.Text & ""
            rs = db.Execute(UCase(sql))
            MsgBox("Dados do filme editados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
        Catch ex As Exception
            MsgBox("Este filme não existe", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_catalogo_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            frm_gerenciar_filmes.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_alterar_hora.Click
        Try
            frm_editar_especificacoes.lbl_id.Text = lbl_id.Text
            frm_editar_especificacoes.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            resp = MsgBox("Essa ação não poderá ser desfeita" + vbNewLine & "Deseja continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                sql = "delete * from tb_filmes where id_filme=" & lbl_id.Text & ""
                rs = db.Execute(sql)
                sql = "delete * from tb_assentos2 where id_filme=" & lbl_id.Text & ""
                rs = db.Execute(sql)
                sql = "delete * from tb_pedidos where id_filme=" & lbl_id.Text & ""
                rs = db.Execute(sql)
                frm_gerenciar_filmes.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1
                .InitialDirectory = Application.StartupPath & "\cartazes"
                .Title = "SELECIONE UMA FOTO"
                .ShowDialog()
                diretorio = .FileName
                PictureBox1.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class