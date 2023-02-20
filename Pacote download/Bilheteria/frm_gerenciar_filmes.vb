Public Class frm_gerenciar_filmes
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Try
            painel_filmes.Controls.Clear()
            frm_adm.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub gerenciar_filmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()

            Dim cont, linha, id, qtde As Integer
            linha = 12
            cont = 0
            id = 1
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

                    sql = "select * from tb_filmes where id_filme=" & id
                    rs = db.Execute(sql)
                    Dim pic As New PictureBox
                    pic.Size = New Size(140, 200)
                    pic.Cursor = Cursors.Hand
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Location = New Point(12 + 166 * i, linha)
                    pic.Name = id
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
            'MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Try
        End Try
    End Sub
    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click
        Try
            frm_editar_filme.lbl_id.Text = sender.name
            painel_filmes.Controls.Clear()
            frm_editar_filme.Show()
            Me.Close()
        Catch ex As Exception
            Exit Try
        End Try
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            frm_add.Show()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class