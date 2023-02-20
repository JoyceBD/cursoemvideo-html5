Public Class frm_controle
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frm_controle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        'carregar_vendas()
        With cmb_filtro.Items
            .Add("Cliente")
            .Add("Funcionario")
        End With
        cmb_filtro.SelectedIndex = 0
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        frm_adm.Show()
        Me.Close()
    End Sub

    Private Sub btn_voltar_Click_1(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Try
            frm_adm.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtro.SelectedIndexChanged
        'Try
        Dim tipo As String
            Select Case cmb_filtro.SelectedIndex
                Case 0
                    carregar_vendas()
                    'filtro = "tb_clientes.nome_cliente"
                Case 1
                    carregar_vendas_func()
                    'filtro = "tb_funcionarios.Nome_funcionario"
            End Select
        'sql = "Select tb_pedidos.Preco, tb_pedidos.DataHoraCompra, tb_pedidos.DataHoraSessao, " &
        '  "tb_pedidos.Audio, tb_pedidos.imagem, tb_filmes.Nome_filme, tb_clientes.Nome_Cliente FROM (tb_pedidos INNER Join tb_filmes On " &
        '  "tb_pedidos.ID_Filme = tb_filmes.id_filme) INNER JOIN tb_clientes on tb_pedidos.CPF_Cliente = tb_clientes.CPF_Cliente where " & filtro & " Like '" & ToolStripTextBox1.Text & "%'"
        'rs = db.Execute(sql)
        'With dgv_vendas
        '.Rows.Clear()
        'Do While rs.EOF = False 'enquanto ter informações no banco
        'If rs.Fields(4).Value = True Then
        ' = "Sim"
        'Else
        'tipo = "Não"
        'End If
        '.Rows.Add(rs.Fields(6).Value, rs.Fields(5).Value, rs.Fields(3).Value, tipo, "R$ " & rs.Fields(0).Value, rs.Fields(2).Value,
        'rs.Fields(1).Value)
        'rs.MoveNext()
        'Loop
        'End With
        'Catch ex As Exception
        'MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ' End Try
    End Sub
End Class