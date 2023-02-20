Public Class teste
    Private Sub teste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cont, linha, j As Integer
        linha = 20
        cont = 0
        j = 0
        Do While (cont < 11)
            For i = 1 To 8
                Dim pic As New PictureBox
                pic.Size = New Size(140, 200)
                pic.Location = New Point(10 * i + 150 * i, linha)
                Me.Controls.Add(pic)
                pic.BackColor = Color.Red
                cont = cont + 1
                If (cont = 11) Then
                    Exit Sub
                End If
            Next
            linha = linha + 220
        Loop
    End Sub
End Class