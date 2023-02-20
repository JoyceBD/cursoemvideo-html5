Imports System.ComponentModel

Public Class frm_pix

    Private Sub frm_pix_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Try
        'frm_cliente.Show()
        'Catch ex As Exception
        'MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Try
            If lbl_conta.Text = "Cliente" Then
                frm_cliente.lbl_cliente.Text = lbl_cpf.Text
                frm_cliente.Show()
                Me.Close()
            Else
                frm_funcionario.lbl_cpf.Text = lbl_cpf.Text
                frm_funcionario.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class