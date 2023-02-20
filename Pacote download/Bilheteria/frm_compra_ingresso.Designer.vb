<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_compra_ingresso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_compra_ingresso))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_hora1 = New System.Windows.Forms.ComboBox()
        Me.cmb_audio = New System.Windows.Forms.ComboBox()
        Me.gb_poltronas = New System.Windows.Forms.GroupBox()
        Me.btn_catalogo = New System.Windows.Forms.Button()
        Me.btn_comprar = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_conta = New System.Windows.Forms.Label()
        Me.lbl_3d = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmb_hora1)
        Me.GroupBox1.Controls.Add(Me.cmb_audio)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(252, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horários disponíveis"
        '
        'cmb_hora1
        '
        Me.cmb_hora1.FormattingEnabled = True
        Me.cmb_hora1.Location = New System.Drawing.Point(15, 81)
        Me.cmb_hora1.Name = "cmb_hora1"
        Me.cmb_hora1.Size = New System.Drawing.Size(121, 21)
        Me.cmb_hora1.TabIndex = 80
        Me.cmb_hora1.Text = "Data e Hora"
        '
        'cmb_audio
        '
        Me.cmb_audio.FormattingEnabled = True
        Me.cmb_audio.Location = New System.Drawing.Point(15, 33)
        Me.cmb_audio.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_audio.Name = "cmb_audio"
        Me.cmb_audio.Size = New System.Drawing.Size(145, 21)
        Me.cmb_audio.TabIndex = 1
        Me.cmb_audio.Text = "Audio"
        '
        'gb_poltronas
        '
        Me.gb_poltronas.BackColor = System.Drawing.Color.Transparent
        Me.gb_poltronas.Location = New System.Drawing.Point(285, 28)
        Me.gb_poltronas.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_poltronas.Name = "gb_poltronas"
        Me.gb_poltronas.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_poltronas.Size = New System.Drawing.Size(241, 231)
        Me.gb_poltronas.TabIndex = 2
        Me.gb_poltronas.TabStop = False
        Me.gb_poltronas.Text = "Poltronas disponíveis"
        '
        'btn_catalogo
        '
        Me.btn_catalogo.BackgroundImage = CType(resources.GetObject("btn_catalogo.BackgroundImage"), System.Drawing.Image)
        Me.btn_catalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_catalogo.Location = New System.Drawing.Point(285, 284)
        Me.btn_catalogo.Name = "btn_catalogo"
        Me.btn_catalogo.Size = New System.Drawing.Size(114, 32)
        Me.btn_catalogo.TabIndex = 21
        Me.btn_catalogo.Text = "Cancelar"
        Me.btn_catalogo.UseVisualStyleBackColor = True
        '
        'btn_comprar
        '
        Me.btn_comprar.BackgroundImage = CType(resources.GetObject("btn_comprar.BackgroundImage"), System.Drawing.Image)
        Me.btn_comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_comprar.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btn_comprar.Location = New System.Drawing.Point(412, 284)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.Size = New System.Drawing.Size(114, 32)
        Me.btn_comprar.TabIndex = 22
        Me.btn_comprar.Text = "Confirmar"
        Me.btn_comprar.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(211, 297)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(15, 13)
        Me.lbl_id.TabIndex = 23
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'lbl_conta
        '
        Me.lbl_conta.AutoSize = True
        Me.lbl_conta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_conta.Location = New System.Drawing.Point(164, 296)
        Me.lbl_conta.Name = "lbl_conta"
        Me.lbl_conta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_conta.TabIndex = 24
        Me.lbl_conta.Text = "conta"
        Me.lbl_conta.Visible = False
        '
        'lbl_3d
        '
        Me.lbl_3d.AutoSize = True
        Me.lbl_3d.BackColor = System.Drawing.Color.Transparent
        Me.lbl_3d.Location = New System.Drawing.Point(20, 38)
        Me.lbl_3d.Name = "lbl_3d"
        Me.lbl_3d.Size = New System.Drawing.Size(142, 13)
        Me.lbl_3d.TabIndex = 25
        Me.lbl_3d.Text = "*Todas as sessões serão 3D"
        Me.lbl_3d.Visible = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Location = New System.Drawing.Point(110, 294)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(22, 13)
        Me.lbl_cpf.TabIndex = 26
        Me.lbl_cpf.Text = "cpf"
        Me.lbl_cpf.Visible = False
        '
        'frm_compra_ingresso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(547, 328)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_3d)
        Me.Controls.Add(Me.lbl_conta)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_comprar)
        Me.Controls.Add(Me.btn_catalogo)
        Me.Controls.Add(Me.gb_poltronas)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_compra_ingresso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de ingresso"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_audio As ComboBox
    Friend WithEvents gb_poltronas As GroupBox
    Friend WithEvents btn_catalogo As Button
    Friend WithEvents btn_comprar As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents cmb_hora1 As ComboBox
    Friend WithEvents lbl_conta As Label
    Friend WithEvents lbl_3d As Label
    Friend WithEvents lbl_cpf As Label
End Class
