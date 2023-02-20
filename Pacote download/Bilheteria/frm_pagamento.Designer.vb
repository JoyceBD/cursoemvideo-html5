<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pagamento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_assentos = New System.Windows.Forms.Label()
        Me.lbl_3d = New System.Windows.Forms.Label()
        Me.lbl_audio = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_filme = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_comprar = New System.Windows.Forms.Button()
        Me.btn_voltar_compra = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtn_pix = New System.Windows.Forms.RadioButton()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_conta = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_qtde = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_assentos)
        Me.GroupBox1.Controls.Add(Me.lbl_3d)
        Me.GroupBox1.Controls.Add(Me.lbl_audio)
        Me.GroupBox1.Controls.Add(Me.lbl_data)
        Me.GroupBox1.Controls.Add(Me.lbl_filme)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(253, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhes da compra"
        '
        'lbl_assentos
        '
        Me.lbl_assentos.AutoSize = True
        Me.lbl_assentos.Location = New System.Drawing.Point(18, 90)
        Me.lbl_assentos.Name = "lbl_assentos"
        Me.lbl_assentos.Size = New System.Drawing.Size(49, 13)
        Me.lbl_assentos.TabIndex = 8
        Me.lbl_assentos.Text = "assentos"
        '
        'lbl_3d
        '
        Me.lbl_3d.AutoSize = True
        Me.lbl_3d.Location = New System.Drawing.Point(227, 15)
        Me.lbl_3d.Name = "lbl_3d"
        Me.lbl_3d.Size = New System.Drawing.Size(21, 13)
        Me.lbl_3d.TabIndex = 7
        Me.lbl_3d.Text = "3D"
        Me.lbl_3d.Visible = False
        '
        'lbl_audio
        '
        Me.lbl_audio.AutoSize = True
        Me.lbl_audio.Location = New System.Drawing.Point(19, 59)
        Me.lbl_audio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_audio.Name = "lbl_audio"
        Me.lbl_audio.Size = New System.Drawing.Size(47, 13)
        Me.lbl_audio.TabIndex = 6
        Me.lbl_audio.Text = "Dublado"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(132, 57)
        Me.lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(30, 13)
        Me.lbl_data.TabIndex = 3
        Me.lbl_data.Text = "Data"
        '
        'lbl_filme
        '
        Me.lbl_filme.AutoSize = True
        Me.lbl_filme.Location = New System.Drawing.Point(18, 32)
        Me.lbl_filme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_filme.Name = "lbl_filme"
        Me.lbl_filme.Size = New System.Drawing.Size(96, 13)
        Me.lbl_filme.TabIndex = 1
        Me.lbl_filme.Text = "Meninas Malvadas"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(132, 90)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(48, 13)
        Me.lbl_total.TabIndex = 2
        Me.lbl_total.Text = "R$14,00"
        '
        'btn_comprar
        '
        Me.btn_comprar.BackgroundImage = CType(resources.GetObject("btn_comprar.BackgroundImage"), System.Drawing.Image)
        Me.btn_comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_comprar.Location = New System.Drawing.Point(295, 197)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.Size = New System.Drawing.Size(114, 32)
        Me.btn_comprar.TabIndex = 24
        Me.btn_comprar.Text = "Confirmar"
        Me.btn_comprar.UseVisualStyleBackColor = True
        '
        'btn_voltar_compra
        '
        Me.btn_voltar_compra.BackgroundImage = CType(resources.GetObject("btn_voltar_compra.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar_compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar_compra.Location = New System.Drawing.Point(168, 197)
        Me.btn_voltar_compra.Name = "btn_voltar_compra"
        Me.btn_voltar_compra.Size = New System.Drawing.Size(114, 32)
        Me.btn_voltar_compra.TabIndex = 23
        Me.btn_voltar_compra.Text = "Cancelar"
        Me.btn_voltar_compra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbtn_pix)
        Me.GroupBox2.Location = New System.Drawing.Point(282, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(125, 127)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opções de Pagamento"
        '
        'rbtn_pix
        '
        Me.rbtn_pix.AutoSize = True
        Me.rbtn_pix.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_pix.Location = New System.Drawing.Point(24, 57)
        Me.rbtn_pix.Name = "rbtn_pix"
        Me.rbtn_pix.Size = New System.Drawing.Size(42, 17)
        Me.rbtn_pix.TabIndex = 26
        Me.rbtn_pix.TabStop = True
        Me.rbtn_pix.Text = "PIX"
        Me.rbtn_pix.UseVisualStyleBackColor = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Location = New System.Drawing.Point(282, 158)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(22, 13)
        Me.lbl_cpf.TabIndex = 26
        Me.lbl_cpf.Text = "cpf"
        Me.lbl_cpf.Visible = False
        '
        'lbl_conta
        '
        Me.lbl_conta.AutoSize = True
        Me.lbl_conta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_conta.Location = New System.Drawing.Point(358, 158)
        Me.lbl_conta.Name = "lbl_conta"
        Me.lbl_conta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_conta.TabIndex = 27
        Me.lbl_conta.Text = "conta"
        Me.lbl_conta.Visible = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(231, 158)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(15, 13)
        Me.lbl_id.TabIndex = 28
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'lbl_qtde
        '
        Me.lbl_qtde.AutoSize = True
        Me.lbl_qtde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qtde.Location = New System.Drawing.Point(128, 158)
        Me.lbl_qtde.Name = "lbl_qtde"
        Me.lbl_qtde.Size = New System.Drawing.Size(28, 13)
        Me.lbl_qtde.TabIndex = 29
        Me.lbl_qtde.Text = "qtde"
        Me.lbl_qtde.Visible = False
        '
        'frm_pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(437, 268)
        Me.Controls.Add(Me.lbl_qtde)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_conta)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_comprar)
        Me.Controls.Add(Me.btn_voltar_compra)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_pagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_filme As Label
    Friend WithEvents lbl_audio As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_comprar As Button
    Friend WithEvents btn_voltar_compra As Button
    Friend WithEvents GroupBox2 As GroupBox

    Private Sub frm_pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If lbl_conta.Text = "funcionario" Then
                rbtn_pix.Text = "Cartão"
            End If
            sql = "select valor from tb_filmes where nome_filme='" & lbl_filme.Text & "'"
            rs = db.Execute(sql)
            lbl_assentos.Text = lbl_qtde.Text & " lugares"
            lbl_total.Text = "R$ " & rs.Fields(0).Value * lbl_qtde.Text
        Catch ex As Exception
            MsgBox("Falha no sistema!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Friend WithEvents rbtn_pix As RadioButton
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_conta As Label
    Friend WithEvents lbl_3d As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_qtde As Label
    Friend WithEvents lbl_assentos As Label
End Class
