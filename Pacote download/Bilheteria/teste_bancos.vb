Public Class teste_bancos
    Private Sub teste_bancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cont, linha As Integer
        linha = 20
        cont = 0

        Do While (cont < 36)
            For i = 0 To 5
                Dim pic As New PictureBox
                pic.Size = New Size(26, 23)
                pic.Cursor = Cursors.Hand
                pic.SizeMode = PictureBoxSizeMode.StretchImage
                pic.Location = New Point(15 + 37 * i, linha)
                pic.Load(Application.StartupPath & "\icones\disponivel.png")
                bg_teste.Controls.Add(pic)
                'pic.BackColor = Color.Green
                AddHandler pic.DoubleClick, AddressOf pic_DoubleClick
                cont = cont + 1
                If (cont = 36) Then
                    Exit Sub
                End If
            Next
            linha = linha + 34
        Loop
    End Sub

    Private Sub pic_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        'Dim disponivel
        'Dim ocupado As Image = Application.StartupPath

        'disponivel = Application.StartupPath.icones.disponivel
        'ocupado = Application.StartupPath.icones.ocupado
        If sender.imagelocation = Application.StartupPath & "\icones\disponivel.png" Then
            sender.Load(Application.StartupPath & "\icones\ocupado.png")
        Else
            sender.load(Application.StartupPath & "\icones\disponivel.png")
        End If
    End Sub

    Private Sub bg_teste_Enter(sender As Object, e As EventArgs) Handles bg_teste.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class