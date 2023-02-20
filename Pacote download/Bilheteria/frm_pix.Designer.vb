<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pix))
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_conta = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.Location = New System.Drawing.Point(135, 9)
        Me.lbl_valor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(139, 18)
        Me.lbl_valor.TabIndex = 0
        Me.lbl_valor.Text = "Valor a pagar: 14,00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(138, 81)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chave: 3102004"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Location = New System.Drawing.Point(12, 203)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(22, 13)
        Me.lbl_cpf.TabIndex = 28
        Me.lbl_cpf.Text = "cpf"
        Me.lbl_cpf.Visible = False
        '
        'lbl_conta
        '
        Me.lbl_conta.AutoSize = True
        Me.lbl_conta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_conta.Location = New System.Drawing.Point(66, 202)
        Me.lbl_conta.Name = "lbl_conta"
        Me.lbl_conta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_conta.TabIndex = 27
        Me.lbl_conta.Text = "conta"
        '
        'btn_menu
        '
        Me.btn_menu.BackgroundImage = CType(resources.GetObject("btn_menu.BackgroundImage"), System.Drawing.Image)
        Me.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_menu.Location = New System.Drawing.Point(336, 202)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(75, 23)
        Me.btn_menu.TabIndex = 29
        Me.btn_menu.Text = "MENU"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'frm_pix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(423, 236)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_conta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_valor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_pix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIX"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_valor As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_conta As Label
    Friend WithEvents btn_menu As Button
End Class
