<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_catalogo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_catalogo))
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.lbl_conta = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.painel_filmes = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btn_voltar
        '
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar.Location = New System.Drawing.Point(924, 502)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(96, 27)
        Me.btn_voltar.TabIndex = 21
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'lbl_conta
        '
        Me.lbl_conta.AutoSize = True
        Me.lbl_conta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_conta.Location = New System.Drawing.Point(865, 509)
        Me.lbl_conta.Name = "lbl_conta"
        Me.lbl_conta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_conta.TabIndex = 22
        Me.lbl_conta.Text = "conta"
        Me.lbl_conta.Visible = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Location = New System.Drawing.Point(820, 509)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(22, 13)
        Me.lbl_cpf.TabIndex = 23
        Me.lbl_cpf.Text = "cpf"
        Me.lbl_cpf.Visible = False
        '
        'painel_filmes
        '
        Me.painel_filmes.AutoScroll = True
        Me.painel_filmes.BackColor = System.Drawing.Color.Transparent
        Me.painel_filmes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.painel_filmes.Location = New System.Drawing.Point(12, 5)
        Me.painel_filmes.Name = "painel_filmes"
        Me.painel_filmes.Size = New System.Drawing.Size(1001, 492)
        Me.painel_filmes.TabIndex = 24
        '
        'frm_catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1025, 538)
        Me.Controls.Add(Me.painel_filmes)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_conta)
        Me.Controls.Add(Me.btn_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_catalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Filmes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_voltar As Button
    Friend WithEvents lbl_conta As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents painel_filmes As Panel
End Class
