<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_controle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_controle))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_filtro = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_vendas = New System.Windows.Forms.DataGridView()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Audio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightPink
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_filtro})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(886, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel1.Text = "FILTRO"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(121, 25)
        '
        'dgv_vendas
        '
        Me.dgv_vendas.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.Column1, Me.Audio, Me.Column6, Me.Column5, Me.Column3, Me.Column4})
        Me.dgv_vendas.Location = New System.Drawing.Point(0, 23)
        Me.dgv_vendas.Name = "dgv_vendas"
        Me.dgv_vendas.Size = New System.Drawing.Size(877, 401)
        Me.dgv_vendas.TabIndex = 0
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Nome"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 150
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
        'btn_voltar
        '
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(786, 430)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(91, 32)
        Me.btn_voltar.TabIndex = 13
        Me.btn_voltar.Text = "Menu"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'frm_controle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(886, 465)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_vendas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_controle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Vendas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_filtro As ToolStripComboBox
    Friend WithEvents dgv_vendas As DataGridView
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Audio As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
