Module Module1
    Public qtde As Double = 0
    Public diames, novadata
    Public diretorio, sql, resp, filtro As String
    Public cod, cont As Integer
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirbanco = Application.StartupPath & "\banco\db_Bilheteria.mdb"

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub preencher_poltronas(ByVal box As GroupBox)
        Try
            Dim cont, linha As Integer
            linha = 20
            cont = 0

            Do While (cont < 36)
                For i = 0 To 5
                    Dim pic As New PictureBox
                    pic.Size = New Size(26, 23)
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Location = New Point(15 + 37 * i, linha)
                    pic.Load(Application.StartupPath & "\icones\disponivel.png")
                    box.Controls.Add(pic)
                    cont = cont + 1
                    If (cont = 36) Then
                        Exit Sub
                    End If
                Next
                linha = linha + 34
            Loop
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Function gerar_id() 'gera ID do filme
        Try
            conectar_banco()
            sql = "select * from tb_filmes order by id_filme desc"
            rs = db.Execute(sql)
            If rs.BOF = True Then 'se nao tiver nada na tabela
                cod = 1
            Else
                cod = rs.Fields(0).Value + 1
            End If
            Return cod
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Function

    Function gerar_sessao()
        Try
            conectar_banco()
            sql = "select * from tb_assentos2 order by id_sessao desc"
            rs = db.Execute(sql)
            If rs.BOF = True Then 'se nao tiver nada na tabela
                cod = 1
            Else
                cod = rs.Fields(0).Value + 1
            End If
            Return cod
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Function

    Sub limpar_cadastro()
        Try
            With frm_add
                .txt_nome_filme.Clear()
                .txt_sinopse.Clear()
                .txt_valor.Clear()
                .PictureBox1.Load(Application.StartupPath & "\cartazes\sample.jpg")
                .chk_3d.Checked = False
                .chk_dub.Checked = False
                .chk_leg.Checked = False
                .cmb_indicacao.Text = "Classificação"
                .txt_data1.Clear()
                .txt_data2.Clear()
                .txt_nome_filme.Focus()
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_cadastro_delete()
        Try
            With frm_editar_filme
                .lbl_id.Text = "-1"
                .txt_nome_filme.Clear()
                .txt_sinopse.Clear()
                .txt_valor.Clear()
                .PictureBox1.Load(Application.StartupPath & "\cartazes\sample.jpg")
                .chk_3d.Checked = False
                .chk_dub.Checked = False
                .chk_leg.Checked = False
                .cmb_indicacao.Text = "Classificação"
                .txt_nome_filme.Focus()
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub preencher_cmd(ByVal combo As ComboBox)
        Try
            With combo.Items
                .Add("L")
                .Add("10")
                .Add("12")
                .Add("14")
                .Add("16")
                .Add("18")
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub preencher_hora(ByVal combo As ComboBox, ByVal audio As String)
        Try
            Dim id = frm_compra_ingresso.lbl_id.Text
            sql = "select datahora from tb_assentos2 where id_filme=" & id & " and audio='" & audio & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                Do While rs.EOF = False
                    With combo.Items
                        .Add(rs.Fields(0).Value)
                    End With
                    rs.MoveNext()
                Loop
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub preencher_hora_edit(ByVal combo As ComboBox, ByVal audio As String)
        Try
            Dim id = frm_editar_especificacoes.lbl_id.Text
            sql = "select datahora from tb_assentos2 where id_filme=" & id & " and audio='" & audio & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                Do While rs.EOF = False
                    With combo.Items
                        .Add(rs.Fields(0).Value)
                    End With
                    rs.MoveNext()
                Loop
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub limpar_cadastro_funcionario()
        Try
            With frm_conta_funcionario
                .txt_cpf.Clear()
                .txt_usuario.Clear()
                .txt_email.Clear()
                .txt_fone.Clear()
                .txt_nome.Clear()
                .txt_senha.Clear()
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub limpar_cadastro_cliente()
        Try
            With frm_cad_cliente
                .txt_cpf.Clear()
                .txt_usuario.Clear()
                .txt_email.Clear()
                .txt_fone.Clear()
                .txt_nome.Clear()
                .txt_senha.Clear()
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub carregar_historico()
        Try
            Dim tipo As String

            sql = "Select tb_pedidos.Preco, tb_pedidos.DataHoraCompra, tb_pedidos.DataHoraSessao, " &
              "tb_pedidos.Audio, tb_pedidos.imagem, tb_filmes.Nome_filme, tb_pedidos.id_pedido FROM tb_pedidos INNER Join tb_filmes On " &
              "tb_pedidos.ID_Filme = tb_filmes.id_filme where tb_pedidos.CPF_Cliente = '" & frm_historico.lbl_cliente.Text & "' order by datahoracompra desc"
            rs = db.Execute(sql)
            With frm_historico.dgv_historico
                .Rows.Clear()
                Do While rs.EOF = False 'enquanto ter informações no banco
                    If rs.Fields(4).Value = True Then
                        tipo = "Sim"
                    Else
                        tipo = "Não"
                    End If
                    .Rows.Add(rs.Fields(6).Value, rs.Fields(5).Value, rs.Fields(3).Value, tipo, "R$ " & rs.Fields(0).Value, rs.Fields(2).Value,
                              rs.Fields(1).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub carregar_vendas()
        'Try
        Dim tipo As String
        sql = "Select tb_pedidos.Preco, tb_pedidos.DataHoraCompra, tb_pedidos.DataHoraSessao, " &
                  "tb_pedidos.Audio, tb_pedidos.imagem, tb_filmes.Nome_filme, tb_clientes.Nome_Cliente FROM (tb_pedidos INNER Join tb_filmes On " &
                  "tb_pedidos.ID_Filme = tb_filmes.id_filme) INNER JOIN tb_clientes on tb_pedidos.CPF_Cliente = tb_clientes.CPF_Cliente"
        rs = db.Execute(sql)
        With frm_controle.dgv_vendas
            .Rows.Clear()
            Do While rs.EOF = False 'enquanto ter informações no banco
                If rs.Fields(4).Value = True Then
                    tipo = "Sim"
                Else
                    tipo = "Não"
                End If
                .Rows.Add(rs.Fields(6).Value, rs.Fields(5).Value, rs.Fields(3).Value, tipo, "R$ " & rs.Fields(0).Value, rs.Fields(2).Value,
                                  rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
        ' Catch ex As Exception
        '   MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_vendas_func()
        'Try
        Dim tipo As String
        sql = "Select tb_pedidos.Preco, tb_pedidos.DataHoraCompra, tb_pedidos.DataHoraSessao, " &
                  "tb_pedidos.Audio, tb_pedidos.imagem, tb_filmes.Nome_filme, tb_funcionarios.Nome_funcionario FROM (tb_pedidos INNER Join tb_filmes On " &
                  "tb_pedidos.ID_Filme = tb_filmes.id_filme) INNER JOIN tb_funcionarios on tb_pedidos.CPF_funcionario = tb_funcionarios.CPF_funcionario"
        rs = db.Execute(sql)
        With frm_controle.dgv_vendas
            .Rows.Clear()
            Do While rs.EOF = False 'enquanto ter informações no banco
                If rs.Fields(4).Value = True Then
                    tipo = "Sim"
                Else
                    tipo = "Não"
                End If
                .Rows.Add(rs.Fields(6).Value, rs.Fields(5).Value, rs.Fields(3).Value, tipo, "R$ " & rs.Fields(0).Value, rs.Fields(2).Value,
                                  rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
        ' Catch ex As Exception
        '   MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_clientes()
        Try
            sql = "select * from tb_clientes order by nome_cliente asc"
            rs = db.Execute(sql)
            With frm_gclientes.dgv_clientes
                .Rows.Clear()
                Do While rs.EOF = False
                    Dim estado As Image
                    If rs.Fields(5).Value = "ATIVA" Then
                        estado = Image.FromFile(Application.StartupPath & "\icones\ativa.png")
                    Else
                        estado = Image.FromFile(Application.StartupPath & "\icones\bloqueada.png")
                    End If
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(6).Value, estado, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub editar_clientes()
        Try
            frm_cad_cliente.txt_cpf.Text = rs.Fields(0).Value
            frm_cad_cliente.txt_nome.Text = rs.Fields(1).Value
            frm_cad_cliente.txt_usuario.Text = rs.Fields(2).Value
            frm_cad_cliente.txt_senha.Text = rs.Fields(3).Value
            frm_cad_cliente.txt_email.Text = rs.Fields(4).Value
            frm_cad_cliente.txt_fone.Text = rs.Fields(6).Value
            frm_cad_cliente.lbl_volta.Text = "adm"
            frm_cad_cliente.Show()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_funcionarios()
        Try
            sql = "select * from tb_funcionarios order by nome_funcionario asc"
            rs = db.Execute(sql)
            With frm_gfuncionarios.dgv_funcionarios
                .Rows.Clear()
                Do While rs.EOF = False
                    Dim estado As Image
                    If rs.Fields(5).Value = "ATIVA" Then
                        estado = Image.FromFile(Application.StartupPath & "\icones\ativa.png")
                    Else
                        estado = Image.FromFile(Application.StartupPath & "\icones\bloqueada.png")
                    End If
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(6).Value, estado, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub editar_funcionarios()
        Try
            frm_conta_funcionario.txt_cpf.Text = rs.Fields(0).Value
            frm_conta_funcionario.txt_nome.Text = rs.Fields(1).Value
            frm_conta_funcionario.txt_usuario.Text = rs.Fields(2).Value
            frm_conta_funcionario.txt_senha.Text = rs.Fields(3).Value
            frm_conta_funcionario.txt_email.Text = rs.Fields(4).Value
            frm_conta_funcionario.txt_fone.Text = rs.Fields(6).Value
            'frm_conta_funcionario.lbl_volta.Text = "adm"
            'img_foto.Load(rs.Fields(2).Value)
            frm_conta_funcionario.Show()
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub add_leg(ByVal txt_data As MaskedTextBox)
        conectar_banco()
        'With frm_add
        Dim id_filme = gerar_id() - 1
        Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
        Dim id_sessao = gerar_sessao() + 1
        For i = 0 To 5
            Dim dia = Convert.ToDateTime(txt_data.Text)
            Dim hora = Convert.ToDateTime(horas(i))
            Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
            'id_sessao = id_sessao + 1
            sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                "'" & "LEGENDADO" & "', " & frm_add.chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
            rs = db.Execute(sql)
            id_sessao = id_sessao + 1
        Next
        db.Close()
        'End With
    End Sub

    Sub add_dub(ByVal txt_data As MaskedTextBox)
        conectar_banco()
        Dim id_filme = gerar_id() - 1
        Dim horas() = {"13:00", "14:30", "15:00", "16:00", "21:00", "23:00"}
        Dim id_sessao = gerar_sessao() + 1
        For i = 0 To 5
            Dim dia = Convert.ToDateTime(txt_data.Text)
            Dim hora = Convert.ToDateTime(horas(i))
            Dim DataCombinada As Date = dia.Date + hora.TimeOfDay
            'id_sessao = id_sessao + 1
            sql = "insert into tb_assentos2 values (" & id_sessao & ", " & id_filme & ", '" & DataCombinada & "', " &
                "'" & "DUBLADO" & "', " & frm_add.chk_3d.Checked & ", '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "', " &
                "'" & "DISPONÍVEL" & "', '" & "DISPONÍVEL" & "')" '36 disponivel
            rs = db.Execute(sql)
            id_sessao = id_sessao + 1
        Next
        db.Close()
    End Sub

    Sub filtrar()
        'Dim frm = form.Name
        With frm_gclientes.cmb_filtro.Items
            .Add("CPF")
            .Add("Nome")
        End With
    End Sub

    Sub filtrar_func()
        With frm_gfuncionarios.cmb_filtro.Items
            .Add("CPF")
            .Add("Nome")
        End With
    End Sub
End Module
