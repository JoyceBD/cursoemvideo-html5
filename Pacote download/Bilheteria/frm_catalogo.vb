Public Class frm_catalogo
    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    '    Try
    '       frm_filme.Show()
    '        Me.Close()
    '    Catch ex As Exception
    '        MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '    End Try
    ' End Sub

    ' Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
    '    Try
    '        frm_filme.ShowDialog()
    '        Me.Close()
    '   Catch ex As Exception
    '       MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '    End Try
    'End Sub

    Private Sub frm_catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()

            Dim cont, linha, id, qtde As Integer
            linha = 12
            cont = 0
            id = 0
            qtde = gerar_id() - 1

            Do While (cont < qtde)
                For i = 0 To 5

                    sql = "select * from tb_filmes where id_filme=" & id
                    rs = db.Execute(sql)
                    If rs.EOF = True Then

                        Do Until rs.EOF = False
                            id = id + 1
                            sql = "select * from tb_filmes where id_filme=" & id
                            rs = db.Execute(sql)
                            If id > qtde Then
                                Exit Sub
                            End If
                        Loop
                    End If

                    Dim pic As New PictureBox
                    pic.Size = New Size(140, 200)
                    pic.Cursor = Cursors.Hand
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Location = New Point(12 + 166 * i, linha)
                    pic.Name = rs.Fields(0).Value
                    pic.Load(rs.Fields(3).Value)
                    painel_filmes.Controls.Add(pic)
                    AddHandler pic.Click, AddressOf pic_Click
                    id = id + 1
                    cont = cont + 1
                    If (cont = qtde) Then
                        Exit Sub
                    End If
                Next
                linha = linha + 225
            Loop
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click
        Try
            frm_filme.lbl_cpf.Text = lbl_cpf.Text
            frm_filme.lbl_conta.Text = lbl_conta.Text
            frm_filme.lbl_id.Text = sender.name
            painel_filmes.Controls.Clear()
            frm_filme.Show()
            Me.Close()
        Catch ex As Exception
            'MsgBox("Selecione um filme válido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Try
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Try
            painel_filmes.Controls.Clear()
            If lbl_conta.Text = "Funcionario" Then
                frm_funcionario.lbl_cpf.Text = lbl_cpf.Text
                frm_funcionario.Show()
                Me.Close()
            Else
                frm_cliente.lbl_cliente.Text = lbl_cpf.Text
                frm_cliente.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class
