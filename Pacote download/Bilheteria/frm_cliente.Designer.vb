<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cliente))
        Me.btn_historico = New System.Windows.Forms.Button()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.btn_catalogo = New System.Windows.Forms.Button()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_historico
        '
        Me.btn_historico.BackColor = System.Drawing.Color.LightPink
        Me.btn_historico.BackgroundImage = CType(resources.GetObject("btn_historico.BackgroundImage"), System.Drawing.Image)
        Me.btn_historico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_historico.Location = New System.Drawing.Point(89, 121)
        Me.btn_historico.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_historico.Name = "btn_historico"
        Me.btn_historico.Size = New System.Drawing.Size(135, 36)
        Me.btn_historico.TabIndex = 2
        Me.btn_historico.Text = "HISTÓRICO DE COMPRAS"
        Me.btn_historico.UseVisualStyleBackColor = False
        '
        'btn_encerrar
        '
        Me.btn_encerrar.BackColor = System.Drawing.Color.LightPink
        Me.btn_encerrar.BackgroundImage = CType(resources.GetObject("btn_encerrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_encerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_encerrar.Location = New System.Drawing.Point(89, 180)
        Me.btn_encerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(135, 36)
        Me.btn_encerrar.TabIndex = 3
        Me.btn_encerrar.Text = "ENCERRAR"
        Me.btn_encerrar.UseVisualStyleBackColor = False
        '
        'btn_catalogo
        '
        Me.btn_catalogo.BackColor = System.Drawing.Color.LightPink
        Me.btn_catalogo.BackgroundImage = CType(resources.GetObject("btn_catalogo.BackgroundImage"), System.Drawing.Image)
        Me.btn_catalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_catalogo.Location = New System.Drawing.Point(89, 63)
        Me.btn_catalogo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_catalogo.Name = "btn_catalogo"
        Me.btn_catalogo.Size = New System.Drawing.Size(135, 36)
        Me.btn_catalogo.TabIndex = 1
        Me.btn_catalogo.Text = "CATÁLOGO"
        Me.btn_catalogo.UseVisualStyleBackColor = False
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cliente.Location = New System.Drawing.Point(188, 241)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cliente.TabIndex = 4
        Me.lbl_cliente.Text = "Label1"
        Me.lbl_cliente.Visible = False
        '
        'frm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(322, 292)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.btn_historico)
        Me.Controls.Add(Me.btn_encerrar)
        Me.Controls.Add(Me.btn_catalogo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTE"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_historico As Button
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents btn_catalogo As Button
    Friend WithEvents lbl_cliente As Label
End Class
