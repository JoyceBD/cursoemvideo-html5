<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_editar_filme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editar_filme))
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_comprar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.cmb_indicacao = New System.Windows.Forms.ComboBox()
        Me.chk_dub = New System.Windows.Forms.CheckBox()
        Me.chk_leg = New System.Windows.Forms.CheckBox()
        Me.chk_3d = New System.Windows.Forms.CheckBox()
        Me.txt_sinopse = New System.Windows.Forms.TextBox()
        Me.txt_nome_filme = New System.Windows.Forms.TextBox()
        Me.btn_alterar_hora = New System.Windows.Forms.Button()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.Location = New System.Drawing.Point(48, 298)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(114, 32)
        Me.btn_cancelar.TabIndex = 25
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_comprar
        '
        Me.btn_comprar.BackgroundImage = CType(resources.GetObject("btn_comprar.BackgroundImage"), System.Drawing.Image)
        Me.btn_comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_comprar.Location = New System.Drawing.Point(424, 297)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.Size = New System.Drawing.Size(114, 32)
        Me.btn_comprar.TabIndex = 24
        Me.btn_comprar.Text = "Confirmar"
        Me.btn_comprar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Sinopse"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 236)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.txt_valor)
        Me.GroupBox1.Controls.Add(Me.lbl_valor)
        Me.GroupBox1.Controls.Add(Me.cmb_indicacao)
        Me.GroupBox1.Controls.Add(Me.chk_dub)
        Me.GroupBox1.Controls.Add(Me.chk_leg)
        Me.GroupBox1.Controls.Add(Me.chk_3d)
        Me.GroupBox1.Controls.Add(Me.txt_sinopse)
        Me.GroupBox1.Controls.Add(Me.txt_nome_filme)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 278)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhes do Filme"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(114, 259)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_id.TabIndex = 15
        Me.lbl_id.Text = "Label1"
        Me.lbl_id.Visible = False
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(436, 250)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(73, 20)
        Me.txt_valor.TabIndex = 14
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Location = New System.Drawing.Point(395, 253)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(35, 13)
        Me.lbl_valor.TabIndex = 12
        Me.lbl_valor.Text = "Preço"
        '
        'cmb_indicacao
        '
        Me.cmb_indicacao.FormattingEnabled = True
        Me.cmb_indicacao.Location = New System.Drawing.Point(182, 52)
        Me.cmb_indicacao.Name = "cmb_indicacao"
        Me.cmb_indicacao.Size = New System.Drawing.Size(121, 21)
        Me.cmb_indicacao.TabIndex = 5
        Me.cmb_indicacao.Text = "Classificação"
        '
        'chk_dub
        '
        Me.chk_dub.AutoSize = True
        Me.chk_dub.Location = New System.Drawing.Point(309, 54)
        Me.chk_dub.Name = "chk_dub"
        Me.chk_dub.Size = New System.Drawing.Size(66, 17)
        Me.chk_dub.TabIndex = 4
        Me.chk_dub.Text = "Dublado"
        Me.chk_dub.UseVisualStyleBackColor = True
        '
        'chk_leg
        '
        Me.chk_leg.AutoSize = True
        Me.chk_leg.Location = New System.Drawing.Point(381, 54)
        Me.chk_leg.Name = "chk_leg"
        Me.chk_leg.Size = New System.Drawing.Size(80, 17)
        Me.chk_leg.TabIndex = 3
        Me.chk_leg.Text = "Legendado"
        Me.chk_leg.UseVisualStyleBackColor = True
        '
        'chk_3d
        '
        Me.chk_3d.AutoSize = True
        Me.chk_3d.Location = New System.Drawing.Point(467, 54)
        Me.chk_3d.Name = "chk_3d"
        Me.chk_3d.Size = New System.Drawing.Size(40, 17)
        Me.chk_3d.TabIndex = 2
        Me.chk_3d.Text = "3D"
        Me.chk_3d.UseVisualStyleBackColor = True
        '
        'txt_sinopse
        '
        Me.txt_sinopse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sinopse.Location = New System.Drawing.Point(183, 97)
        Me.txt_sinopse.Multiline = True
        Me.txt_sinopse.Name = "txt_sinopse"
        Me.txt_sinopse.Size = New System.Drawing.Size(326, 150)
        Me.txt_sinopse.TabIndex = 1
        Me.txt_sinopse.Text = "SINOPSE"
        '
        'txt_nome_filme
        '
        Me.txt_nome_filme.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_filme.Location = New System.Drawing.Point(182, 17)
        Me.txt_nome_filme.Name = "txt_nome_filme"
        Me.txt_nome_filme.Size = New System.Drawing.Size(315, 31)
        Me.txt_nome_filme.TabIndex = 0
        Me.txt_nome_filme.Text = "NOME DO FILME"
        '
        'btn_alterar_hora
        '
        Me.btn_alterar_hora.BackgroundImage = CType(resources.GetObject("btn_alterar_hora.BackgroundImage"), System.Drawing.Image)
        Me.btn_alterar_hora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alterar_hora.Location = New System.Drawing.Point(295, 298)
        Me.btn_alterar_hora.Name = "btn_alterar_hora"
        Me.btn_alterar_hora.Size = New System.Drawing.Size(114, 32)
        Me.btn_alterar_hora.TabIndex = 26
        Me.btn_alterar_hora.Text = "Alterar Horário"
        Me.btn_alterar_hora.UseVisualStyleBackColor = True
        '
        'btn_excluir
        '
        Me.btn_excluir.BackgroundImage = CType(resources.GetObject("btn_excluir.BackgroundImage"), System.Drawing.Image)
        Me.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_excluir.Location = New System.Drawing.Point(168, 298)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(114, 32)
        Me.btn_excluir.TabIndex = 27
        Me.btn_excluir.Text = "Deletar Filme"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_editar_filme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 359)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.btn_alterar_hora)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_comprar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_editar_filme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR FILME"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_comprar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_indicacao As ComboBox
    Friend WithEvents chk_dub As CheckBox
    Friend WithEvents chk_leg As CheckBox
    Friend WithEvents chk_3d As CheckBox
    Friend WithEvents txt_sinopse As TextBox
    Friend WithEvents txt_nome_filme As TextBox
    Friend WithEvents btn_alterar_hora As Button
    Friend WithEvents lbl_valor As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_excluir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
