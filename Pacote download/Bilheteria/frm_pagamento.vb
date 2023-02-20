Public Class frm_pagamento
    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        Try
            conectar_banco()
            'If (rbtn_boleto.Checked = False And rbtn_pix.Checked = False) Then
            If rbtn_pix.Checked = False Then
                MsgBox("Selecione um método de pagamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Sistema")
                Exit Sub
            End If
            'sql = "select  from tb_pedidos where cpf_funcionario='" & txt_cpf.Text & "'"
            sql = "Select ID_Filme from tb_filmes where Nome_Filme='" & lbl_filme.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then 'se existir o filme (o que existe, né)
                If lbl_conta.Text = "Cliente" Then 'se for conta cliente
                    sql = "insert into tb_pedidos (CPF_Cliente, ID_Filme, Preco, DataHoraSessao, Audio, Imagem) values (" &
                  "'" & lbl_cpf.Text & "', " & rs.Fields(0).Value & ", '" & lbl_total.Text & "', '" & lbl_data.Text & "', " &
                  "'" & lbl_audio.Text & "', " & lbl_3d.Visible & ")"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Pedido realizado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
                    frm_cliente.lbl_cliente.Text = lbl_cpf.Text
                Else 'se for conta funcionario
                    sql = "insert into tb_pedidos (CPF_Funcionario, ID_Filme, Preco, DataHoraSessao, Audio, Imagem) values (" &
                  "'" & lbl_cpf.Text & "', " & rs.Fields(0).Value & ", '" & lbl_total.Text & "', '" & lbl_data.Text & "', " &
                  "'" & lbl_audio.Text & "', " & lbl_3d.Visible & ")"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Pedido realizado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
                    frm_funcionario.lbl_cpf.Text = lbl_cpf.Text
                End If
            End If

            If rbtn_pix.Checked = True Then
                'If rbtn_pix.Text = "PIX" Then
                frm_pix.lbl_valor.Text = "VALOR A PAGAR: " & lbl_total.Text
                    frm_pix.lbl_conta.Text = lbl_conta.Text
                    frm_pix.lbl_cpf.Text = lbl_cpf.Text
                    frm_pix.Show()
                    Me.Close()
                'Else
                'frm_cartao.lbl_valor.Text = "VALOR A PAGAR: " & lbl_total.Text
                'frm_cartao.lbl_cpf.Text = lbl_cpf.Text
                'frm_cartao.Show()
                'Me.Close()
                'End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_catalogo_Click(sender As Object, e As EventArgs) Handles btn_voltar_compra.Click
        Try
            frm_compra_ingresso.lbl_conta.Text = lbl_conta.Text
            frm_compra_ingresso.lbl_cpf.Text = lbl_cpf.Text
            frm_compra_ingresso.lbl_id.Text = lbl_id.Text
            frm_compra_ingresso.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class