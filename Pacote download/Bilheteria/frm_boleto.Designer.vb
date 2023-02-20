<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_boleto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_boleto))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_retornar = New System.Windows.Forms.Button()
        Me.btn_email = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_conta = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(51, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.LightPink
        Me.btn_imprimir.BackgroundImage = CType(resources.GetObject("btn_imprimir.BackgroundImage"), System.Drawing.Image)
        Me.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_imprimir.Location = New System.Drawing.Point(245, 35)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(145, 26)
        Me.btn_imprimir.TabIndex = 1
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_retornar
        '
        Me.btn_retornar.BackColor = System.Drawing.Color.LightPink
        Me.btn_retornar.BackgroundImage = CType(resources.GetObject("btn_retornar.BackgroundImage"), System.Drawing.Image)
        Me.btn_retornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_retornar.Location = New System.Drawing.Point(245, 208)
        Me.btn_retornar.Name = "btn_retornar"
        Me.btn_retornar.Size = New System.Drawing.Size(145, 26)
        Me.btn_retornar.TabIndex = 3
        Me.btn_retornar.Text = "Retornar"
        Me.btn_retornar.UseVisualStyleBackColor = False
        '
        'btn_email
        '
        Me.btn_email.BackColor = System.Drawing.Color.LightPink
        Me.btn_email.BackgroundImage = CType(resources.GetObject("btn_email.BackgroundImage"), System.Drawing.Image)
        Me.btn_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_email.Location = New System.Drawing.Point(245, 91)
        Me.btn_email.Name = "btn_email"
        Me.btn_email.Size = New System.Drawing.Size(145, 26)
        Me.btn_email.TabIndex = 4
        Me.btn_email.Text = "Enviar para e-mail"
        Me.btn_email.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.LightPink
        Me.btn_confirmar.BackgroundImage = CType(resources.GetObject("btn_confirmar.BackgroundImage"), System.Drawing.Image)
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_confirmar.Location = New System.Drawing.Point(245, 150)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(145, 26)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Location = New System.Drawing.Point(265, 274)
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
        Me.lbl_conta.Location = New System.Drawing.Point(319, 273)
        Me.lbl_conta.Name = "lbl_conta"
        Me.lbl_conta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_conta.TabIndex = 25
        Me.lbl_conta.Text = "conta"
        Me.lbl_conta.Visible = False
        '
        'frm_boleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(452, 328)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_conta)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_email)
        Me.Controls.Add(Me.btn_retornar)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_boleto"
        Me.Text = "BOLETO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents btn_retornar As Button
    Friend WithEvents btn_email As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_conta As Label
End Class
