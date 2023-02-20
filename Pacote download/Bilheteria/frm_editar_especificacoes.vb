Public Class frm_editar_especificacoes
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'With cmb_audio.Items
            '.Add("Dublado")
            '.Add("Legendado")
            'End With
            conectar_banco()
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

    Private Sub pic_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_editar.DoubleClick
        Try
            Dim data As String = cmb_hora1.Text
            Dim dia = Convert.ToDateTime(data)
            If dia.Day > 12 Then
                Dim diames As New DateTime(dia.Year, dia.Month, dia.Day, dia.Hour, dia.Minute, 0)
            Else
                Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
            End If
            'Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
            If sender.imagelocation = Application.StartupPath & "\icones\disponivel.png" Then
                sql = "update tb_assentos2 set " + sender.name + " ='" & "OCUPADO" & "' where id_filme =" & lbl_id.Text & " and datahora=#" & diames & "#"
                rs = db.Execute(sql)
                sender.Load(Application.StartupPath & "\icones\ocupado.png")
            Else
                sql = "update tb_assentos2 set " + sender.name + " ='" & "DISPONÍVEL" & "' where id_filme =" & lbl_id.Text & " and datahora=#" & diames & "#"
                rs = db.Execute(sql)
                sender.load(Application.StartupPath & "\icones\disponivel.png")
            End If
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub btn_catalogo_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            frm_editar_filme.lbl_id.Text = lbl_id.Text
            frm_editar_filme.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_hora1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_hora1.SelectedIndexChanged
        'Try
        gb_editar.Controls.Clear()
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
        'If dia.Day > 12 Then
        '    Dim diames As New DateTime(dia.Year, dia.Month, dia.Day, dia.Hour, dia.Minute, 0)
        'Else
        '    Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)
        'End If
        'Dim diames As New DateTime(dia.Year, dia.Day, dia.Month, dia.Hour, dia.Minute, 0)

        '(1974, 7, 10, 7, 10, 24)
        '7:10:24
        'diames = dia.Month / dia.Day / dia.Year
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
                gb_editar.Controls.Add(pic)
                AddHandler pic.Click, AddressOf pic_DoubleClick
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
        'Catch ex As Exception
        'MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub cmb_audio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_audio.SelectedIndexChanged
        Try
            cmb_hora1.Items.Clear()
            preencher_hora_edit(cmb_hora1, cmb_audio.SelectedItem)
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            MsgBox("Alterações feitas com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class