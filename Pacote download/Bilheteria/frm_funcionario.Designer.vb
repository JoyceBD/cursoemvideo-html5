<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_funcionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_funcionario))
        Me.btn_gerenciar = New System.Windows.Forms.Button()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.btn_compra = New System.Windows.Forms.Button()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_gerenciar
        '
        Me.btn_gerenciar.BackColor = System.Drawing.Color.LightPink
        Me.btn_gerenciar.BackgroundImage = CType(resources.GetObject("btn_gerenciar.BackgroundImage"), System.Drawing.Image)
        Me.btn_gerenciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gerenciar.Location = New System.Drawing.Point(89, 128)
        Me.btn_gerenciar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gerenciar.Name = "btn_gerenciar"
        Me.btn_gerenciar.Size = New System.Drawing.Size(135, 36)
        Me.btn_gerenciar.TabIndex = 2
        Me.btn_gerenciar.Text = "GERENCIAR CLIENTES"
        Me.btn_gerenciar.UseVisualStyleBackColor = False
        '
        'btn_encerrar
        '
        Me.btn_encerrar.BackColor = System.Drawing.Color.LightPink
        Me.btn_encerrar.BackgroundImage = CType(resources.GetObject("btn_encerrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_encerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_encerrar.Location = New System.Drawing.Point(89, 198)
        Me.btn_encerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(135, 36)
        Me.btn_encerrar.TabIndex = 3
        Me.btn_encerrar.Text = "ENCERRAR"
        Me.btn_encerrar.UseVisualStyleBackColor = False
        '
        'btn_compra
        '
        Me.btn_compra.BackColor = System.Drawing.Color.LightPink
        Me.btn_compra.BackgroundImage = CType(resources.GetObject("btn_compra.BackgroundImage"), System.Drawing.Image)
        Me.btn_compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_compra.Location = New System.Drawing.Point(89, 59)
        Me.btn_compra.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_compra.Name = "btn_compra"
        Me.btn_compra.Size = New System.Drawing.Size(135, 36)
        Me.btn_compra.TabIndex = 1
        Me.btn_compra.Text = "COMPRA DE INGRESSO"
        Me.btn_compra.UseVisualStyleBackColor = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Location = New System.Drawing.Point(225, 251)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(46, 13)
        Me.lbl_cpf.TabIndex = 4
        Me.lbl_cpf.Text = "cpf func"
        Me.lbl_cpf.Visible = False
        '
        'frm_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(322, 292)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.btn_gerenciar)
        Me.Controls.Add(Me.btn_encerrar)
        Me.Controls.Add(Me.btn_compra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_funcionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FUNCIONÁRIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_gerenciar As Button
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents btn_compra As Button
    Friend WithEvents lbl_cpf As Label
End Class
