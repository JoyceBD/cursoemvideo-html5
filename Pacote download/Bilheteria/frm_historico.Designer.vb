<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_historico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_historico))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.dgv_historico = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Audio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_voltar)
        Me.GroupBox1.Controls.Add(Me.dgv_historico)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 484)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Histórico de Compras"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar.Location = New System.Drawing.Point(765, 443)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(91, 32)
        Me.btn_voltar.TabIndex = 1
        Me.btn_voltar.Text = "Menu"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'dgv_historico
        '
        Me.dgv_historico.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Audio, Me.Column6, Me.Column5, Me.Column3, Me.Column4, Me.Column2})
        Me.dgv_historico.Location = New System.Drawing.Point(6, 20)
        Me.dgv_historico.Name = "dgv_historico"
        Me.dgv_historico.Size = New System.Drawing.Size(850, 417)
        Me.dgv_historico.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pedido"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 60
        '
        'Column1
        '
        Me.Column1.HeaderText = "Filme"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Audio
        '
        Me.Audio.HeaderText = "Audio"
        Me.Audio.Name = "Audio"
        '
        'Column6
        '
        Me.Column6.HeaderText = "3D"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "Preço"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Data/Hora da Sessão"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Data/Hora da Compra"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cancelar"
        Me.Column2.Image = CType(resources.GetObject("Column2.Image"), System.Drawing.Image)
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(584, 9)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cliente.TabIndex = 1
        Me.lbl_cliente.Text = "Label1"
        Me.lbl_cliente.Visible = False
        '
        'frm_historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(886, 491)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_historico As DataGridView
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Audio As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
End Class
