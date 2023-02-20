Public Class frm_cad_cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            conectar_banco()
            If String.IsNullOrEmpty(txt_nome.Text) Or _ 'String.IsNullOrEmpty(txt_cpf.Text) Or
                String.IsNullOrEmpty(txt_usuario.Text) Or
                String.IsNullOrEmpty(txt_senha.Text) Or
                String.IsNullOrEmpty(txt_email.Text) Then 'String.IsNullOrEmpty(txt_fone.Text) Then
                MsgBox("Preencha todos os campos corretamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            sql = "select * from tb_clientes where cpf_cliente='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then 'se nao existir o cpf no banco
                sql = "insert into tb_clientes(cpf_cliente, Nome_cliente, Email_cliente, Senha_cliente, Status, Fone_Contato, Usuario_cliente) values (" &
            "'" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" & txt_email.Text & "', " &
                "'" & txt_senha.Text & "', '" & "ATIVA" & "', '" & txt_fone.Text & "', '" & txt_usuario.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastrado efetuado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
                limpar_cadastro_cliente()
                If lbl_volta.Text = "adm1" Then
                    carregar_clientes()
                    Exit Sub
                End If
                Exit Sub
            Else
                If lbl_volta.Text = "adm" Then
                    sql = "update tb_clientes set nome_cliente='" & txt_nome.Text & "', email_cliente= '" & txt_email.Text & "', " &
                "senha_cliente='" & txt_senha.Text & "', fone_contato= '" & txt_fone.Text & "', usuario_cliente= '" & txt_usuario.Text & "'" &
                "where cpf_cliente='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    carregar_clientes()
                    Me.Close()
                Else
                    MsgBox("O CPF '" & txt_cpf.Text & "' já está cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txt_senha.UseSystemPasswordChar = True Then
                txt_senha.UseSystemPasswordChar = False
            Else
                txt_senha.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class