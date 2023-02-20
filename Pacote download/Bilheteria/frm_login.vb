Public Class frm_login

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_cadastrar.Click
        Try
            frm_cad_cliente.lbl_volta.Text = "login"
            frm_cad_cliente.Show()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If (txt_user.Text = "admin" And txt_senha.Text = "admin") Then
                rbtn_adm.Visible = True
                rbtn_func.Visible = True
                txt_user.Clear()
                txt_senha.Clear()
                txt_user.Focus()
                Exit Sub
            End If

            If rbtn_func.Checked = True Then
                sql = "select cpf_funcionario, status from tb_funcionarios where (Email_funcionario='" & txt_user.Text & "' " &
                    "or Usuario_funcionario ='" & txt_user.Text & "') And senha='" & txt_senha.Text & "'"
                rs = db.Execute(UCase(sql))
                If rs.EOF = False Then 'se existir a conta
                    If rs.Fields(1).Value = "BLOQUEADA" Then
                        MsgBox("Sua conta está bloqueada." + vbNewLine & "Para mais informações, contate um administrador", MsgBoxStyle.OkOnly, "Aviso")
                        Exit Sub
                    Else
                        'frm_catalogo.lbl_conta.Text = "Funcionario"
                        frm_pagamento.lbl_conta.Text = "Funcionario"
                        frm_funcionario.lbl_cpf.Text = rs.Fields(0).Value
                        frm_pagamento.lbl_cpf.Text = rs.Fields(0).Value
                        frm_funcionario.Show()
                        Me.Close()
                        Exit Sub
                    End If
                Else
                    MsgBox("Funcionário '" & txt_user.Text & "' não encontrado." + vbNewLine & "Por favor, contate o administrador", MsgBoxStyle.OkOnly, "Sistema")
                    Exit Sub
                End If
            End If

            If rbtn_adm.Checked = True Then
                sql = "select * from tb_admin where Nome_admin='" & txt_user.Text & "' " &
                    "And senha_admin='" & txt_senha.Text & "'"
                rs = db.Execute(UCase(sql))
                If rs.EOF = False Then
                    frm_adm.Show()
                    'frm_catalogo.lbl_conta.Text = "Funcionario"
                    Me.Close()
                    Exit Sub
                Else
                    MsgBox("Admin '" & txt_user.Text & "' não encontrada." + vbNewLine & "Por favor, contate o suporte do sistema", MsgBoxStyle.OkOnly, "Sistema")
                    Exit Sub
                End If
            End If

            sql = "select CPF_cliente, status from tb_clientes where (Email_cliente='" & txt_user.Text & "' " &
                    "Or Usuario_cliente ='" & txt_user.Text & "') And senha_cliente='" & txt_senha.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then 'se existir a conta
                If rs.Fields(1).Value = "BLOQUEADA" Then
                    MsgBox("Sua conta está bloqueada." + vbNewLine & "Para mais informações, contate um funcionário", MsgBoxStyle.OkOnly, "Aviso")
                Else
                    'MsgBox("Login realizado!", MsgBoxStyle.OkOnly, "Sistema")
                    'frm_cliente.Show()
                    frm_cliente.lbl_cliente.Text = rs.Fields(0).Value
                    'frm_pagamento.lbl_cpf.Text = rs.Fields(0).Value
                    'frm_pagamento.lbl_conta.Text = "Cliente"
                    'frm_catalogo.lbl_conta.Text = "Cliente"
                    frm_cliente.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_sair_Click(sender As Object, e As EventArgs) Handles frm_sair.Click
        Try
            resp = MsgBox("Deseja encerrar o programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema")
            If resp = vbYes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class