<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_cadastrar = New System.Windows.Forms.Label()
        Me.rbtn_func = New System.Windows.Forms.RadioButton()
        Me.rbtn_adm = New System.Windows.Forms.RadioButton()
        Me.frm_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(25, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(25, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(69, 45)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(276, 20)
        Me.txt_user.TabIndex = 2
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(69, 100)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(276, 20)
        Me.txt_senha.TabIndex = 3
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.Location = New System.Drawing.Point(206, 167)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Entrar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'lbl_cadastrar
        '
        Me.lbl_cadastrar.AutoSize = True
        Me.lbl_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cadastrar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_cadastrar.Location = New System.Drawing.Point(248, 134)
        Me.lbl_cadastrar.Name = "lbl_cadastrar"
        Me.lbl_cadastrar.Size = New System.Drawing.Size(97, 13)
        Me.lbl_cadastrar.TabIndex = 6
        Me.lbl_cadastrar.Text = "Cadastrar conta"
        '
        'rbtn_func
        '
        Me.rbtn_func.AutoSize = True
        Me.rbtn_func.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_func.Location = New System.Drawing.Point(147, 134)
        Me.rbtn_func.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtn_func.Name = "rbtn_func"
        Me.rbtn_func.Size = New System.Drawing.Size(80, 17)
        Me.rbtn_func.TabIndex = 7
        Me.rbtn_func.TabStop = True
        Me.rbtn_func.Text = "Funcionário"
        Me.rbtn_func.UseVisualStyleBackColor = False
        Me.rbtn_func.Visible = False
        '
        'rbtn_adm
        '
        Me.rbtn_adm.AutoSize = True
        Me.rbtn_adm.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_adm.Location = New System.Drawing.Point(69, 134)
        Me.rbtn_adm.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtn_adm.Name = "rbtn_adm"
        Me.rbtn_adm.Size = New System.Drawing.Size(46, 17)
        Me.rbtn_adm.TabIndex = 8
        Me.rbtn_adm.TabStop = True
        Me.rbtn_adm.Text = "Adm"
        Me.rbtn_adm.UseVisualStyleBackColor = False
        Me.rbtn_adm.Visible = False
        '
        'frm_sair
        '
        Me.frm_sair.BackgroundImage = CType(resources.GetObject("frm_sair.BackgroundImage"), System.Drawing.Image)
        Me.frm_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.frm_sair.Location = New System.Drawing.Point(103, 167)
        Me.frm_sair.Name = "frm_sair"
        Me.frm_sair.Size = New System.Drawing.Size(75, 23)
        Me.frm_sair.TabIndex = 9
        Me.frm_sair.Text = "Sair"
        Me.frm_sair.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(383, 218)
        Me.Controls.Add(Me.frm_sair)
        Me.Controls.Add(Me.rbtn_adm)
        Me.Controls.Add(Me.rbtn_func)
        Me.Controls.Add(Me.lbl_cadastrar)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_cadastrar As Label
    Friend WithEvents rbtn_func As RadioButton
    Friend WithEvents rbtn_adm As RadioButton
    Friend WithEvents frm_sair As Button
End Class
