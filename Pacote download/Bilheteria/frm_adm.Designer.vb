<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adm))
        Me.btn_gfilmes = New System.Windows.Forms.Button()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.btn_gclientes = New System.Windows.Forms.Button()
        Me.btn_gfuncionarios = New System.Windows.Forms.Button()
        Me.btn_vendas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_gfilmes
        '
        Me.btn_gfilmes.BackColor = System.Drawing.Color.LightPink
        Me.btn_gfilmes.BackgroundImage = CType(resources.GetObject("btn_gfilmes.BackgroundImage"), System.Drawing.Image)
        Me.btn_gfilmes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gfilmes.Location = New System.Drawing.Point(89, 26)
        Me.btn_gfilmes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gfilmes.Name = "btn_gfilmes"
        Me.btn_gfilmes.Size = New System.Drawing.Size(135, 36)
        Me.btn_gfilmes.TabIndex = 0
        Me.btn_gfilmes.Text = "GERENCIAR FILMES"
        Me.btn_gfilmes.UseVisualStyleBackColor = False
        '
        'btn_encerrar
        '
        Me.btn_encerrar.BackColor = System.Drawing.Color.LightPink
        Me.btn_encerrar.BackgroundImage = CType(resources.GetObject("btn_encerrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_encerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_encerrar.Location = New System.Drawing.Point(89, 230)
        Me.btn_encerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(135, 36)
        Me.btn_encerrar.TabIndex = 1
        Me.btn_encerrar.Text = "ENCERRAR"
        Me.btn_encerrar.UseVisualStyleBackColor = False
        '
        'btn_gclientes
        '
        Me.btn_gclientes.BackColor = System.Drawing.Color.LightPink
        Me.btn_gclientes.BackgroundImage = CType(resources.GetObject("btn_gclientes.BackgroundImage"), System.Drawing.Image)
        Me.btn_gclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gclientes.Location = New System.Drawing.Point(89, 127)
        Me.btn_gclientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gclientes.Name = "btn_gclientes"
        Me.btn_gclientes.Size = New System.Drawing.Size(135, 36)
        Me.btn_gclientes.TabIndex = 2
        Me.btn_gclientes.Text = "GERENCIAR CLIENTES"
        Me.btn_gclientes.UseVisualStyleBackColor = False
        '
        'btn_gfuncionarios
        '
        Me.btn_gfuncionarios.BackColor = System.Drawing.Color.LightPink
        Me.btn_gfuncionarios.BackgroundImage = CType(resources.GetObject("btn_gfuncionarios.BackgroundImage"), System.Drawing.Image)
        Me.btn_gfuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gfuncionarios.Location = New System.Drawing.Point(89, 76)
        Me.btn_gfuncionarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gfuncionarios.Name = "btn_gfuncionarios"
        Me.btn_gfuncionarios.Size = New System.Drawing.Size(135, 36)
        Me.btn_gfuncionarios.TabIndex = 3
        Me.btn_gfuncionarios.Text = "GERENCIAR FUNCIONARIOS"
        Me.btn_gfuncionarios.UseVisualStyleBackColor = False
        '
        'btn_vendas
        '
        Me.btn_vendas.BackColor = System.Drawing.Color.LightPink
        Me.btn_vendas.BackgroundImage = CType(resources.GetObject("btn_vendas.BackgroundImage"), System.Drawing.Image)
        Me.btn_vendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_vendas.Location = New System.Drawing.Point(89, 179)
        Me.btn_vendas.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_vendas.Name = "btn_vendas"
        Me.btn_vendas.Size = New System.Drawing.Size(135, 36)
        Me.btn_vendas.TabIndex = 4
        Me.btn_vendas.Text = "MONITORAR VENDAS"
        Me.btn_vendas.UseVisualStyleBackColor = False
        '
        'frm_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(322, 292)
        Me.Controls.Add(Me.btn_vendas)
        Me.Controls.Add(Me.btn_gfuncionarios)
        Me.Controls.Add(Me.btn_gclientes)
        Me.Controls.Add(Me.btn_encerrar)
        Me.Controls.Add(Me.btn_gfilmes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRADOR"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_gfilmes As Button
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents btn_gclientes As Button
    Friend WithEvents btn_gfuncionarios As Button
    Friend WithEvents btn_vendas As Button
End Class
