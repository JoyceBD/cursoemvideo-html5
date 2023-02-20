Public Class editar_especificacoes
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()

            Dim cont, linha, coluna, y As Integer
            coluna = 1
            linha = 1
            y = 20
            cont = 0

            Do While (cont < 36)
                For i = 0 To 5
                    sql = "select * from tb_assentos where Cod_Assento=" & linha & 0 & coluna
                    rs = db.Execute(sql)
                    Dim pic As New PictureBox
                    pic.Size = New Size(26, 23)
                    pic.Cursor = Cursors.Hand
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Location = New Point(15 + 37 * i, y)
                    If rs.Fields(1).Value = "DISPONÍVEL" Then
                        pic.Load(Application.StartupPath & "\icones\disponivel.png")
                    Else 'If sql = "OCUPADO" Then
                        pic.Load(Application.StartupPath & "\icones\ocupado.png")
                    End If
                    gb_editar.Controls.Add(pic)
                    'pic.BackColor = Color.Green
                    AddHandler pic.DoubleClick, AddressOf pic_DoubleClick
                    coluna = coluna + 1
                    cont = cont + 1
                    If (cont = 36) Then
                        Exit Sub
                    End If
                Next
                coluna = 1
                linha = linha + 1
                y = y + 34
            Loop
            'preencher_poltronas(gb_poltronas)
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub pic_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_editar.DoubleClick
        If sender.imagelocation = Application.StartupPath & "\icones\disponivel.png" Then
            sender.Load(Application.StartupPath & "\icones\ocupado.png")
        Else
            sender.load(Application.StartupPath & "\icones\disponivel.png")
        End If
    End Sub
End Class