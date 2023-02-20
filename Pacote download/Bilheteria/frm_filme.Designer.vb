<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_filme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_filme))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_sinopse = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.btn_comprar = New System.Windows.Forms.Button()
        Me.btn_catalogo = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_conta = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 236)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(183, 17)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(159, 25)
        Me.lbl_nome.TabIndex = 5
        Me.lbl_nome.Text = "NOME_FILME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sinopse"
        '
        'lbl_sinopse
        '
        Me.lbl_sinopse.AutoSize = True
        Me.lbl_sinopse.Location = New System.Drawing.Point(3, 3)
        Me.lbl_sinopse.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lbl_sinopse.Name = "lbl_sinopse"
        Me.lbl_sinopse.Size = New System.Drawing.Size(75, 13)
        Me.lbl_sinopse.TabIndex = 7
        Me.lbl_sinopse.Text = "Texto Sinopse"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.lbl_valor)
        Me.GroupBox1.Controls.Add(Me.lbl_nome)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 278)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhes do Filme"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_sinopse)
        Me.Panel1.Location = New System.Drawing.Point(180, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 150)
        Me.Panel1.TabIndex = 12
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Location = New System.Drawing.Point(434, 256)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(35, 13)
        Me.lbl_valor.TabIndex = 11
        Me.lbl_valor.Text = "Preço"
        '
        'btn_comprar
        '
        Me.btn_comprar.BackgroundImage = CType(resources.GetObject("btn_comprar.BackgroundImage"), System.Drawing.Image)
        Me.btn_comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_comprar.Location = New System.Drawing.Point(423, 300)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.Size = New System.Drawing.Size(114, 32)
        Me.btn_comprar.TabIndex = 9
        Me.btn_comprar.Text = "Comprar Ingresso"
        Me.btn_comprar.UseVisualStyleBackColor = True
        '
        'btn_catalogo
        '
        Me.btn_catalogo.BackgroundImage = CType(resources.GetObject("btn_catalogo.BackgroundImage"), System.Drawing.Image)
        Me.btn_catalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_catalogo.Location = New System.Drawing.Point(303, 300)
        Me.btn_catalogo.Name = "btn_catalogo"
        Me.btn_catalogo.Size = New System.Drawing.Size(114, 32)
        Me.btn_catalogo.TabIndex = 10
        Me.btn_catalogo.Text = "Catálogo"
        Me.btn_catalogo.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(216, 318)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "id filme"
        Me.lbl_id.Visible = False
        '
        'lbl_conta
        '
        Me.lbl_conta.AutoSize = True
        Me.lbl_conta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_conta.Location = New System.Drawing.Point(134, 317)
        Me.lbl_conta.Name = "lbl_conta"
        Me.lbl_conta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_conta.TabIndex = 12
        Me.lbl_conta.Text = "conta"
        Me.lbl_conta.Visible = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Location = New System.Drawing.Point(80, 318)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(22, 13)
        Me.lbl_cpf.TabIndex = 24
        Me.lbl_cpf.Text = "cpf"
        Me.lbl_cpf.Visible = False
        '
        'frm_filme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(563, 359)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_conta)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_catalogo)
        Me.Controls.Add(Me.btn_comprar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_filme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FILME"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_sinopse As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_comprar As Button
    Friend WithEvents btn_catalogo As Button
    Friend WithEvents lbl_valor As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_conta As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents Panel1 As Panel
End Class
