<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_editar_especificacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editar_especificacoes))
        Me.gb_editar = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_hora1 = New System.Windows.Forms.ComboBox()
        Me.cmb_audio = New System.Windows.Forms.ComboBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_editar
        '
        Me.gb_editar.BackColor = System.Drawing.Color.Transparent
        Me.gb_editar.Location = New System.Drawing.Point(290, 44)
        Me.gb_editar.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_editar.Name = "gb_editar"
        Me.gb_editar.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_editar.Size = New System.Drawing.Size(241, 231)
        Me.gb_editar.TabIndex = 5
        Me.gb_editar.TabStop = False
        Me.gb_editar.Text = "Clique duplamente na poltrona para alterá-la"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmb_hora1)
        Me.GroupBox1.Controls.Add(Me.cmb_audio)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 44)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(252, 231)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horários disponíveis"
        '
        'cmb_hora1
        '
        Me.cmb_hora1.FormattingEnabled = True
        Me.cmb_hora1.Location = New System.Drawing.Point(21, 119)
        Me.cmb_hora1.Name = "cmb_hora1"
        Me.cmb_hora1.Size = New System.Drawing.Size(121, 21)
        Me.cmb_hora1.TabIndex = 82
        Me.cmb_hora1.Text = "Data e Hora"
        '
        'cmb_audio
        '
        Me.cmb_audio.FormattingEnabled = True
        Me.cmb_audio.Location = New System.Drawing.Point(21, 71)
        Me.cmb_audio.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_audio.Name = "cmb_audio"
        Me.cmb_audio.Size = New System.Drawing.Size(145, 21)
        Me.cmb_audio.TabIndex = 81
        Me.cmb_audio.Text = "Audio"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackgroundImage = CType(resources.GetObject("btn_confirmar.BackgroundImage"), System.Drawing.Image)
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_confirmar.Location = New System.Drawing.Point(417, 287)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(114, 32)
        Me.btn_confirmar.TabIndex = 24
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.Location = New System.Drawing.Point(290, 287)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(114, 32)
        Me.btn_cancelar.TabIndex = 23
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(232, 16)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(15, 13)
        Me.lbl_id.TabIndex = 25
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'frm_editar_especificacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(547, 328)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.gb_editar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_editar_especificacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Especificações"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_editar As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents cmb_hora1 As ComboBox
    Friend WithEvents cmb_audio As ComboBox
End Class
