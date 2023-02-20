Public Class frm_conta_funcionario
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If String.IsNullOrEmpty(txt_nome.Text) Or
                String.IsNullOrEmpty(txt_usuario.Text) Or
                String.IsNullOrEmpty(txt_senha.Text) Or
                String.IsNullOrEmpty(txt_email.Text) Then                'String.IsNullOrEmpty(txt_fone.Text) Then
                MsgBox("Preencha todos os campos corretamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            conectar_banco()
            sql = "select * from tb_funcionarios where cpf_funcionario='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then 'se nao existir o cpf no banco
                sql = "insert into tb_funcionarios(cpf_funcionario, Nome_funcionario, Email_funcionario, Senha, Status, Fone_Contato, Usuario_funcionario) values (" &
            "'" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" & txt_email.Text & "', " &
                "'" & txt_senha.Text & "', '" & "ATIVA" & "', '" & txt_fone.Text & "', '" & txt_usuario.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Funcionário cadastrado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
                limpar_cadastro_funcionario()
                carregar_funcionarios()
            Else
                If lbl_editar.Text = "sim" Then
                    sql = "update tb_funcionarios set nome_funcionario='" & txt_nome.Text & "', email_funcionario= '" & txt_email.Text & "', " &
                    "senha='" & txt_senha.Text & "', fone_contato= '" & txt_fone.Text & "', usuario_funcionario= '" & txt_usuario.Text & "'" &
                    "where cpf_funcionario='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
                    'limpar_cadastro_funcionario()
                    carregar_funcionarios()
                    Me.Close()
                Else
                    MsgBox("O CPF '" & txt_cpf.Text & "' já está cadastrado!" + vbNewLine &
                       "Para editá-lo, utilize a tabela de gerenciamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If

            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_senha.UseSystemPasswordChar = True Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub
End Class