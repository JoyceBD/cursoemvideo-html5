Public Class frm_historico
    Private Sub frm_historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_historico()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_cliente.lbl_cliente.Text = lbl_cliente.Text
        frm_cliente.Show()
        Me.Close()
    End Sub

    Private Sub dgv_historico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historico.CellContentClick
        With dgv_historico
            If .CurrentRow.Cells(7).Selected = True Then 'excluir
                Dim aux_pedido As String = .CurrentRow.Cells(0).Value
                'aux_cpf = .CurrentRow.Cells(0).Value
                resp = MsgBox("Deseja realmente excluir cancelar este pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_pedidos where id_pedido=" & aux_pedido & ""
                    rs = db.Execute(sql)
                    carregar_historico()
                End If
            End If
        End With

    End Sub
End Class