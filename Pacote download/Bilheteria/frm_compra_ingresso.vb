Public Class frm_compra_ingresso
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()
            qtde = 0
            sql = "select dublado, legendado from tb_filmes where id_filme=" & lbl_id.Text & ""
            rs = db.Execute(sql)

            If rs.Fields(0).Value = True Then
                With cmb_audio.Items
                    .Add("Dublado")
                    '.Add("Legendado")
                End With
            End If

            If rs.Fields(1).Value = True Then
                With cmb_audio.Items
                    '.Add("Dublado")
                    .Add("Legendado")
                End With
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        Try
            'conectar_banco()
            If qtde = 0 Then
                MsgBox("Selecione o áudio, data/hora e assentos corretamente", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Else
                conectar_banco()
                sql = "select nome_filme from tb_filmes where id_filme=" & lbl_id.Text & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    'frm_pagamento.lbl_qtde = qtde
                    frm_pagamento.lbl_conta.Text = lbl_conta.Text
                    frm_pagamento.lbl_id.Text = lbl_id.Text
                    frm_pagamento.lbl_cpf.Text = lbl_cpf.Text
                    frm_pagamento.lbl_data.Text = cmb_hora1.SelectedItem
                    frm_pagamento.lbl_audio.Text = cmb_audio.SelectedItem
                    frm_pagamento.lbl_filme.Text = rs.Fields(0).Value
                    If lbl_3d.Visible = True Then
                        frm_pagamento.lbl_3d.Visible = True
                    End If
                End If
                frm_pagamento.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_poltronas.Click
        Try
            If sender.imageLocation = Application.StartupPath & "\icones\ocupado.png" Then
                MsgBox("Esse assento já está ocupado." + vbNewLine &
                       "Por favor, escolha outro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf sender.imagelocation = Application.StartupPath & "\icones\disponivel.png" Then
                Dim data = cmb_hora1.Text
                Dim dia = Convert.ToDateTime(data)
                If dia.Day > 12 Then
                    Dim diames As New DateTime(dia.Year, dia.Month, dia.Day, dia.Hour, dia.Minute, 0)
                Else
                    Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
                End If
                'Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
                sql = "update tb_assentos2 set " + sender.name + " ='" & "OCUPADO" & "' where id_filme =" & lbl_id.Text & " and datahora=#" & diames & "#"
                rs = db.Execute(sql)
                qtde = qtde + 1
                frm_pagamento.lbl_qtde.Text = qtde
                sender.Load(Application.StartupPath & "\icones\selecionado.png")
            Else
                Dim data = cmb_hora1.Text
                Dim dia = Convert.ToDateTime(data)
                If dia.Day > 12 Then
                    Dim diames As New DateTime(dia.Year, dia.Month, dia.Day, dia.Hour, dia.Minute, 0)
                Else
                    Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
                End If
                'Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
                sql = "update tb_assentos2 set " + sender.name + " = '" & "DISPONÍVEL" & "' where id_filme =" & lbl_id.Text & " and datahora=#" & diames & "#"
                rs = db.Execute(sql)
                qtde = qtde - 1
                frm_pagamento.lbl_qtde.Text = qtde
                sender.load(Application.StartupPath & "\icones\disponivel.png")
            End If
        Catch ex As Exception
            MsgBox("Selecione uma opção de áudio e data!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_audio.SelectedIndexChanged
        Try
            cmb_hora1.Items.Clear()
            preencher_hora(cmb_hora1, cmb_audio.SelectedItem)
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_catalogo_Click(sender As Object, e As EventArgs) Handles btn_catalogo.Click
        Try
            frm_filme.lbl_conta.Text = lbl_conta.Text
            frm_filme.lbl_cpf.Text = lbl_cpf.Text
            frm_filme.lbl_id.Text = lbl_id.Text
            frm_filme.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_hora1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_hora1.SelectedIndexChanged
        Try
            gb_poltronas.Controls.Clear()
            Dim cont, linha, coluna, y As Integer
            linha = 1
            coluna = 1
            y = 20
            cont = 0

            Dim fields_assento = 5 'os assentos começam no rs.fields(5)
            Dim data = cmb_hora1.Text
            Dim dia = Convert.ToDateTime(data)
            If dia.Day > 12 Then 'se ele for converter
                'Dim novadata As New DateTime(dia.Year, dia.Month, dia.Day, dia.Hour, dia.Minute, 0)
                diames = data
                'novadata = dia
            Else
                'novadata
                Dim outradata As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
                diames = outradata
            End If

            'Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
            'Dim qtde As Integer = 0
            Do While (cont < 36)
                For i = 0 To 5
                    sql = "select * from tb_assentos2 where id_filme=" & lbl_id.Text & " and datahora=#" & diames & "#"
                    rs = db.Execute(sql)
                    Dim pic As New PictureBox
                    pic.Size = New Size(26, 23)
                    pic.Cursor = Cursors.Hand
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Location = New Point(15 + 37 * i, y)
                    pic.Name = linha & 0 & coluna
                    If rs.Fields(fields_assento).Value = "DISPONÍVEL" Then
                        pic.Load(Application.StartupPath & "\icones\disponivel.png")
                    Else 'If sql = "OCUPADO" Then
                        pic.Load(Application.StartupPath & "\icones\ocupado.png")
                    End If
                    gb_poltronas.Controls.Add(pic)
                    AddHandler pic.Click, AddressOf pic_Click
                    coluna = coluna + 1
                    cont = cont + 1
                    fields_assento = fields_assento + 1
                    If (cont = 36) Then
                        Exit Sub
                    End If
                Next
                y = y + 34
                coluna = 1
                linha = linha + 1
            Loop
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class