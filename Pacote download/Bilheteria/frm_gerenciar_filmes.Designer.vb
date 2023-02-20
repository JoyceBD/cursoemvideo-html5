<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerenciar_filmes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciar_filmes))
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.painel_filmes = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = CType(resources.GetObject("btn_add.BackgroundImage"), System.Drawing.Image)
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Location = New System.Drawing.Point(924, 502)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(96, 27)
        Me.btn_add.TabIndex = 19
        Me.btn_add.Text = "Adicionar Filme"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar.Location = New System.Drawing.Point(824, 502)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(96, 27)
        Me.btn_voltar.TabIndex = 24
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'painel_filmes
        '
        Me.painel_filmes.AutoScroll = True
        Me.painel_filmes.BackColor = System.Drawing.Color.Transparent
        Me.painel_filmes.Location = New System.Drawing.Point(12, 5)
        Me.painel_filmes.Name = "painel_filmes"
        Me.painel_filmes.Size = New System.Drawing.Size(1001, 492)
        Me.painel_filmes.TabIndex = 25
        '
        'frm_gerenciar_filmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1025, 538)
        Me.Controls.Add(Me.painel_filmes)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_gerenciar_filmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERENCIAR FILMES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents painel_filmes As Panel
End Class
