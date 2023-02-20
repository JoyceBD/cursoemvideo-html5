Public Class frm_filme

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_catalogo.Click
        Try
            frm_catalogo.lbl_cpf.Text = lbl_cpf.Text
            frm_catalogo.lbl_conta.Text = lbl_conta.Text
            frm_catalogo.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_filme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()
            'frm_catalogo.painel_filmes.Controls.
            'sql = "select * from tb_filmes where Cartaz_filme= '" & PictureBox1.ImageLocation & "'"
            sql = "select * from tb_filmes where ID_filme= " & lbl_id.Text & ""
            rs = db.Execute(sql)
            PictureBox1.Load(rs.Fields(3).Value)
            'lbl_id.Text = rs.Fields(0).Value
            lbl_nome.Text = rs.Fields(1).Value
            lbl_sinopse.Text = rs.Fields(2).Value
            lbl_valor.Text = "Preço: " & Format(rs.Fields(8).Value, "Currency")

            Dim position As Integer
            position = 4
            'position = position + 1

            For i = 4 To 7
                Dim pic As New PictureBox
                pic.Size = New Size(29, 29)
                pic.SizeMode = PictureBoxSizeMode.StretchImage
                pic.Location = New Point(188, 45)

                If i = 4 Then
                    pic.Load(Application.StartupPath & "\classificacao\" & rs.Fields(4).Value & ".png")
                    GroupBox1.Controls.Add(pic)
                    position = position + 1
                End If

                If i = 5 Then
                    If rs.Fields(5).Value = True Then 'se tiver dublado
                        pic.Location = New Point(48 + 35 * position, 45)
                        pic.Load(Application.StartupPath & "\classificacao\dub.png")
                        GroupBox1.Controls.Add(pic)
                        position = position + 1
                    End If
                End If

                If i = 6 Then
                    If rs.Fields(6).Value = True Then 'se tiver legendado
                        pic.Location = New Point(48 + 35 * position, 45)
                        pic.Load(Application.StartupPath & "\classificacao\leg.png")
                        GroupBox1.Controls.Add(pic)
                        position = position + 1
                    End If
                End If

                If i = 7 Then
                    If rs.Fields(7).Value = True Then 'se tiver 3D
                        pic.Location = New Point(48 + 35 * position, 45)
                        pic.Load(Application.StartupPath & "\classificacao\3d.png")
                        GroupBox1.Controls.Add(pic)
                        frm_compra_ingresso.lbl_3d.Visible = True
                        frm_pagamento.lbl_3d.Visible = True
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_comprar_Click_1(sender As Object, e As EventArgs) Handles btn_comprar.Click
        Try
            'sql = "select id_filme from tb_filmes where Cartaz_filme= '" & PictureBox1.ImageLocation & "'"
            frm_compra_ingresso.lbl_conta.Text = lbl_conta.Text
            frm_compra_ingresso.lbl_id.Text = lbl_id.Text
            frm_compra_ingresso.lbl_cpf.Text = lbl_cpf.Text
            frm_compra_ingresso.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class