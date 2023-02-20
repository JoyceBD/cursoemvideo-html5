<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gclientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gclientes))
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_retornar = New System.Windows.Forms.Button()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lbl_volta = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_filtro = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.LightPink
        Me.btn_add.BackgroundImage = CType(resources.GetObject("btn_add.BackgroundImage"), System.Drawing.Image)
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Location = New System.Drawing.Point(750, 434)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(115, 34)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "ADICIONAR"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_retornar
        '
        Me.btn_retornar.BackColor = System.Drawing.Color.LightPink
        Me.btn_retornar.BackgroundImage = CType(resources.GetObject("btn_retornar.BackgroundImage"), System.Drawing.Image)
        Me.btn_retornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_retornar.Location = New System.Drawing.Point(631, 434)
        Me.btn_retornar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_retornar.Name = "btn_retornar"
        Me.btn_retornar.Size = New System.Drawing.Size(115, 34)
        Me.btn_retornar.TabIndex = 7
        Me.btn_retornar.Text = "RETORNAR"
        Me.btn_retornar.UseVisualStyleBackColor = False
        '
        'dgv_clientes
        '
        Me.dgv_clientes.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_clientes.Location = New System.Drawing.Point(0, 23)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.Size = New System.Drawing.Size(877, 401)
        Me.dgv_clientes.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF Cliente"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 104
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome Cliente"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "E-mail"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fone Contato"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column6
        '
        Me.Column6.HeaderText = "Editar"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column7
        '
        Me.Column7.HeaderText = "Excluir"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lbl_volta
        '
        Me.lbl_volta.AutoSize = True
        Me.lbl_volta.Location = New System.Drawing.Point(71, 454)
        Me.lbl_volta.Name = "lbl_volta"
        Me.lbl_volta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_volta.TabIndex = 10
        Me.lbl_volta.Text = "Label1"
        Me.lbl_volta.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightPink
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_filtro, Me.ToolStripLabel2, Me.ToolStripTextBox1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(877, 25)
        Me.ToolStrip1.TabIndex = 11
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripLabel2.Text = "PESQUISA"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'frm_gclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(877, 476)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbl_volta)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_retornar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_gclientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERENCIAR CLIENTES"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents btn_retornar As Button
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents lbl_volta As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_filtro As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class
