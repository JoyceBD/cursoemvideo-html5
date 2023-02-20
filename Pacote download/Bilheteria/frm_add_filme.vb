Public Class frm_add
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

    Private Sub frm_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        preencher_cmd(cmb_indicacao)
    End Sub

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        'Try
        If PictureBox1.Image Is Nothing Or
            String.IsNullOrEmpty(txt_nome_filme.Text) Or
            String.IsNullOrEmpty(txt_sinopse.Text) Or
            String.IsNullOrEmpty(txt_valor.Text) Or
            (chk_3d.Checked = False And chk_dub.Checked = False And chk_leg.Checked = False) Then
                MsgBox("Preencha todos os campos corretamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

        Dim id_filme = gerar_id()
        sql = "select * from tb_filmes where Nome_filme='" & txt_nome_filme.Text & "'"
            rs = db.Execute(sql)

        If rs.EOF = True Then 'se nao existir o filme na tabela
            sql = "insert into tb_filmes values (" & id_filme & ", " &
                        "'" & txt_nome_filme.Text & "', '" & txt_sinopse.Text & "', '" & diretorio & "','" & cmb_indicacao.Text & "', " &
                        "" & chk_dub.Checked & ", " & chk_leg.Checked & ", " & chk_3d.Checked & ", '" & txt_valor.Text & "')"
            rs = db.Execute(UCase(sql))
            db.Close()
            Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
            Dim id_sessao = gerar_sessao() - 1
            If (chk_leg.Checked = True And chk_dub.Checked = True) Then
                add_dub(txt_data1)
                add_leg(txt_data2)
                ' For i = 0 To 5 '6 horarios/sessoes
                'Dim dia = Convert.ToDateTime(txt_data1.Text)
                'Dim hora = Convert.ToDateTime(horas(i))
                'Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
                'id_sessao = id_sessao + 1
                'id_sessao = gerar_sessao() + i
                'Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
                'horas() = {}
                'Dim data = "txt_data" & i & ".Text"
                ' sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                ' "'" & "DUBLADO" & "', " & chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
                ' rs = db.Execute(UCase(sql))
                ' Next

                ' For i = 0 To 5 '6 horarios/sessoes
                'Dim dia = Convert.ToDateTime(txt_data2.Text)
                'Dim hora = Convert.ToDateTime(horas(i))
                'Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
                'id_sessao = id_sessao + 1
                'id_sessao = gerar_sessao() + i
                'Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
                'horas() = {}
                'Dim data = "txt_data" & i & ".Text"
                ' sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                '"'" & "LEGENDADO" & "', " & chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
                '    rs = db.Execute(UCase(sql))
                '    Next
            ElseIf chk_dub.Checked = True Then 'SE TIVER SÓ DUBLADO
                '  For i = 0 To 5
                add_dub(txt_data1)
                '       For i = 0 To 5 '6 horarios/sessoes
                '  Dim dia = Convert.ToDateTime(txt_data1.Text)
                '  Dim hora = Convert.ToDateTime(horas(i))
                '   Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
                '      id_sessao = id_sessao + 1
                'id_sessao = gerar_sessao() + i
                'Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
                'horas() = {}
                'Dim data = "txt_data" & i & ".Text"
                '    sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                '"'" & "DUBLADO" & "', " & chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
                '    rs = db.Execute(UCase(sql))
                ' Next
                ' For i = 0 To 5
                add_dub(txt_data2)
                'For i = 0 To 5 '6 horarios/sessoes
                '  Dim dia = Convert.ToDateTime(txt_data2.Text)
                '  Dim hora = Convert.ToDateTime(horas(i))
                '  Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
                ' id_sessao = id_sessao + 1
                'id_sessao = gerar_sessao() + i
                'Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
                'horas() = {}
                'Dim data = "txt_data" & i & ".Text"
                ' sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                '  "'" & "DUBLADO" & "', " & chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '  "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '  "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '  "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '  "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
                '      rs = db.Execute(UCase(sql))
                '  Next
                'add_dub(txt_data2)
            ElseIf chk_leg.Checked = True Then 'SE TIVER SÓ LEGENDADO
                ' For i = 0 To 5
                'add_dub(txt_data1)
                'For i = 0 To 5 '6 horarios/sessoes
                'Dim dia = Convert.ToDateTime(txt_data1.Text)
                'Dim hora = Convert.ToDateTime(horas(i))
                'Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
                'id_sessao = id_sessao + 1
                'id_sessao = gerar_sessao() + i
                'Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
                'horas() = {}
                'Dim data = "txt_data" & i & ".Text"
                'sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                '"'" & "LEGENDADO" & "', " & chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
                '   rs = db.Execute(UCase(sql))
                '  Next
                '  For i = 0 To 5
                'add_dub(txt_data1)For i = 0 To 5 '6 horarios/sessoes
                '  Dim dia = Convert.ToDateTime(txt_data2.Text)
                '     Dim hora = Convert.ToDateTime(horas(i))
                '     Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
                '     id_sessao = id_sessao + 1
                'id_sessao = gerar_sessao() + i
                'Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
                'horas() = {}
                'Dim data = "txt_data" & i & ".Text"
                '   sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                ' "'" & "LEGENDADO" & "', " & chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                '"'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                ' "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
                '   rs = db.Execute(UCase(sql))
                '    Next
                add_leg(txt_data1)
                add_leg(txt_data2)
            End If

            MsgBox("Filme adicionado com sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sistema")
            limpar_cadastro()
        Else
            MsgBox("O filme " & txt_nome_filme.Text & " já está cadastrado." + vbNewLine &
                    "Edite-o pelo catálogo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
        'Catch ex As Exception
        'MsgBox("Pane no sistema alguem me desconfigurou", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALOOOO")
        'End Try
    End Sub

    Private Sub btn_catalogo_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        frm_gerenciar_filmes.Show()
        Me.Close()
    End Sub
End Class