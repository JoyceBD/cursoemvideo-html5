Public Class frm_gclientes
    Private Sub btn_retornar_Click(sender As Object, e As EventArgs) Handles btn_retornar.Click
        If lbl_volta.Text = "adm" Then
            frm_adm.Show()
        Else
            frm_funcionario.Show()
        End If
        Me.Close()
    End Sub

    Private Sub frm_gclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_clientes()
        filtrar()
    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        With dgv_clientes
            Dim aux_cpf As String
            If .CurrentRow.Cells(5).Selected = True Then 'editar
                aux_cpf = .CurrentRow.Cells(0).Value
                sql = "select * from tb_clientes where cpf_cliente='" & aux_cpf & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    editar_clientes()
                End If
            ElseIf .CurrentRow.Cells(4).Selected Then 'ativar/bloquear
                aux_cpf = .CurrentRow.Cells(0).Value
                sql = "select status from tb_clientes where cpf_cliente='" & aux_cpf & "'"
                rs = db.Execute(sql)
                If rs.Fields(0).Value = "ATIVA" Then
                    resp = MsgBox("Essa ação bloqueará esta conta." + vbNewLine & "Tem certeza que deseja continuar?", MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        sql = "update tb_clientes set Status='" & "BLOQUEADA" & "' where cpf_cliente='" & aux_cpf & "'"
                        rs = db.Execute(UCase(sql))
                        carregar_clientes()
                    End If
                Else
                    resp = MsgBox("Essa ação ativará esta conta." + vbNewLine & "Tem certeza que deseja continuar?", MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        sql = "update tb_clientes set Status='" & "ATIVA" & "' where cpf_cliente='" & aux_cpf & "'"
                        rs = db.Execute(UCase(sql))
                        carregar_clientes()
                    End If
                End If
            ElseIf .CurrentRow.Cells(6).Selected = True Then 'excluir
                aux_cpf = .CurrentRow.Cells(0).Value
                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                            "O CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_clientes where cpf_cliente='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    carregar_clientes()
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        frm_cad_cliente.lbl_volta.Text = "adm1"
        frm_cad_cliente.Show()
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Try
            'Dim filtro As String
            Select Case cmb_filtro.SelectedIndex
                Case 0
                    filtro = "CPF_cliente"
                Case 1
                    filtro = "Nome_cliente"
            End Select
            sql = "select * from tb_clientes where " & filtro & " like '" & ToolStripTextBox1.Text & "%'"
            rs = db.Execute(sql)
            With dgv_clientes
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
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class