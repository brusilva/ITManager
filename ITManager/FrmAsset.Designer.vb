<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsset
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LstItems = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbcontrato = New System.Windows.Forms.ComboBox()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtComentarioAsset = New System.Windows.Forms.TextBox()
        Me.DTPAquisicao = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtValorAsset = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSNAsset = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtModeloAsset = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMarcaAsset = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtContratoAsset = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTipoAsset = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodAsset = New System.Windows.Forms.TextBox()
        Me.dbGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBContrato = New System.Windows.Forms.RadioButton()
        Me.RbModelo = New System.Windows.Forms.RadioButton()
        Me.RBMarca = New System.Windows.Forms.RadioButton()
        Me.RBID = New System.Windows.Forms.RadioButton()
        Me.TxtProcura = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.RBNaoAlocados = New System.Windows.Forms.RadioButton()
        Me.RbAlocados = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstItems
        '
        Me.LstItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstItems.Location = New System.Drawing.Point(13, 34)
        Me.LstItems.Name = "LstItems"
        Me.LstItems.Size = New System.Drawing.Size(283, 415)
        Me.LstItems.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbcontrato)
        Me.GroupBox1.Controls.Add(Me.cbtipo)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnGravar)
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtComentarioAsset)
        Me.GroupBox1.Controls.Add(Me.DTPAquisicao)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtValorAsset)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtSNAsset)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtModeloAsset)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtMarcaAsset)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtContratoAsset)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtTipoAsset)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCodAsset)
        Me.GroupBox1.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 283)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Asset"
        '
        'cbcontrato
        '
        Me.cbcontrato.FormattingEnabled = True
        Me.cbcontrato.Location = New System.Drawing.Point(313, 44)
        Me.cbcontrato.Name = "cbcontrato"
        Me.cbcontrato.Size = New System.Drawing.Size(109, 21)
        Me.cbcontrato.TabIndex = 48
        '
        'cbtipo
        '
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Location = New System.Drawing.Point(105, 45)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(121, 21)
        Me.cbtipo.TabIndex = 47
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.Location = New System.Drawing.Point(299, 247)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 45
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGravar
        '
        Me.BtnGravar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGravar.Location = New System.Drawing.Point(218, 247)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGravar.TabIndex = 44
        Me.BtnGravar.Text = "Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Location = New System.Drawing.Point(137, 247)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 43
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Comentario"
        '
        'TxtComentarioAsset
        '
        Me.TxtComentarioAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtComentarioAsset.Location = New System.Drawing.Point(74, 149)
        Me.TxtComentarioAsset.Multiline = True
        Me.TxtComentarioAsset.Name = "TxtComentarioAsset"
        Me.TxtComentarioAsset.Size = New System.Drawing.Size(348, 92)
        Me.TxtComentarioAsset.TabIndex = 41
        '
        'DTPAquisicao
        '
        Me.DTPAquisicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPAquisicao.Location = New System.Drawing.Point(74, 123)
        Me.DTPAquisicao.Name = "DTPAquisicao"
        Me.DTPAquisicao.Size = New System.Drawing.Size(230, 20)
        Me.DTPAquisicao.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Valor"
        '
        'TxtValorAsset
        '
        Me.TxtValorAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtValorAsset.Location = New System.Drawing.Point(347, 123)
        Me.TxtValorAsset.Name = "TxtValorAsset"
        Me.TxtValorAsset.Size = New System.Drawing.Size(75, 20)
        Me.TxtValorAsset.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Aquisição"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Serial"
        '
        'TxtSNAsset
        '
        Me.TxtSNAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSNAsset.Location = New System.Drawing.Point(74, 97)
        Me.TxtSNAsset.Name = "TxtSNAsset"
        Me.TxtSNAsset.Size = New System.Drawing.Size(348, 20)
        Me.TxtSNAsset.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Modelo"
        '
        'TxtModeloAsset
        '
        Me.TxtModeloAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtModeloAsset.Location = New System.Drawing.Point(256, 71)
        Me.TxtModeloAsset.Name = "TxtModeloAsset"
        Me.TxtModeloAsset.Size = New System.Drawing.Size(166, 20)
        Me.TxtModeloAsset.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Marca"
        '
        'TxtMarcaAsset
        '
        Me.TxtMarcaAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMarcaAsset.Location = New System.Drawing.Point(74, 71)
        Me.TxtMarcaAsset.Name = "TxtMarcaAsset"
        Me.TxtMarcaAsset.Size = New System.Drawing.Size(128, 20)
        Me.TxtMarcaAsset.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Contrato"
        '
        'TxtContratoAsset
        '
        Me.TxtContratoAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtContratoAsset.Location = New System.Drawing.Point(285, 44)
        Me.TxtContratoAsset.Name = "TxtContratoAsset"
        Me.TxtContratoAsset.ReadOnly = True
        Me.TxtContratoAsset.Size = New System.Drawing.Size(23, 20)
        Me.TxtContratoAsset.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tipo"
        '
        'TxtTipoAsset
        '
        Me.TxtTipoAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTipoAsset.Location = New System.Drawing.Point(74, 45)
        Me.TxtTipoAsset.Name = "TxtTipoAsset"
        Me.TxtTipoAsset.ReadOnly = True
        Me.TxtTipoAsset.Size = New System.Drawing.Size(25, 20)
        Me.TxtTipoAsset.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Codigo"
        '
        'TxtCodAsset
        '
        Me.TxtCodAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCodAsset.Location = New System.Drawing.Point(74, 19)
        Me.TxtCodAsset.Name = "TxtCodAsset"
        Me.TxtCodAsset.ReadOnly = True
        Me.TxtCodAsset.Size = New System.Drawing.Size(65, 20)
        Me.TxtCodAsset.TabIndex = 13
        '
        'dbGrid
        '
        Me.dbGrid.AllowUserToAddRows = False
        Me.dbGrid.AllowUserToDeleteRows = False
        Me.dbGrid.AllowUserToResizeColumns = False
        Me.dbGrid.AllowUserToResizeRows = False
        Me.dbGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dbGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dbGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.dbGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dbGrid.Location = New System.Drawing.Point(302, 301)
        Me.dbGrid.MultiSelect = False
        Me.dbGrid.Name = "dbGrid"
        Me.dbGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dbGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dbGrid.ShowCellErrors = False
        Me.dbGrid.ShowEditingIcon = False
        Me.dbGrid.ShowRowErrors = False
        Me.dbGrid.Size = New System.Drawing.Size(618, 148)
        Me.dbGrid.TabIndex = 45
        Me.dbGrid.VirtualMode = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RBContrato)
        Me.GroupBox2.Controls.Add(Me.RbModelo)
        Me.GroupBox2.Controls.Add(Me.RBMarca)
        Me.GroupBox2.Controls.Add(Me.RBID)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 154)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenação"
        '
        'RBContrato
        '
        Me.RBContrato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBContrato.AutoSize = True
        Me.RBContrato.Location = New System.Drawing.Point(6, 92)
        Me.RBContrato.Name = "RBContrato"
        Me.RBContrato.Size = New System.Drawing.Size(65, 17)
        Me.RBContrato.TabIndex = 3
        Me.RBContrato.Text = "Contrato"
        Me.RBContrato.UseVisualStyleBackColor = True
        '
        'RbModelo
        '
        Me.RbModelo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbModelo.AutoSize = True
        Me.RbModelo.Location = New System.Drawing.Point(6, 69)
        Me.RbModelo.Name = "RbModelo"
        Me.RbModelo.Size = New System.Drawing.Size(60, 17)
        Me.RbModelo.TabIndex = 2
        Me.RbModelo.Text = "Modelo"
        Me.RbModelo.UseVisualStyleBackColor = True
        '
        'RBMarca
        '
        Me.RBMarca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBMarca.AutoSize = True
        Me.RBMarca.Location = New System.Drawing.Point(6, 46)
        Me.RBMarca.Name = "RBMarca"
        Me.RBMarca.Size = New System.Drawing.Size(55, 17)
        Me.RBMarca.TabIndex = 1
        Me.RBMarca.Text = "Marca"
        Me.RBMarca.UseVisualStyleBackColor = True
        '
        'RBID
        '
        Me.RBID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBID.AutoSize = True
        Me.RBID.Checked = True
        Me.RBID.Location = New System.Drawing.Point(6, 22)
        Me.RBID.Name = "RBID"
        Me.RBID.Size = New System.Drawing.Size(36, 17)
        Me.RBID.TabIndex = 0
        Me.RBID.TabStop = True
        Me.RBID.Text = "ID"
        Me.RBID.UseVisualStyleBackColor = True
        '
        'TxtProcura
        '
        Me.TxtProcura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProcura.Location = New System.Drawing.Point(13, 8)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(283, 20)
        Me.TxtProcura.TabIndex = 48
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.RbTodos)
        Me.GroupBox3.Controls.Add(Me.RBNaoAlocados)
        Me.GroupBox3.Controls.Add(Me.RbAlocados)
        Me.GroupBox3.Location = New System.Drawing.Point(302, 197)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(110, 98)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado"
        '
        'RbTodos
        '
        Me.RbTodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Checked = True
        Me.RbTodos.Location = New System.Drawing.Point(6, 19)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(55, 17)
        Me.RbTodos.TabIndex = 2
        Me.RbTodos.TabStop = True
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'RBNaoAlocados
        '
        Me.RBNaoAlocados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBNaoAlocados.AutoSize = True
        Me.RBNaoAlocados.Location = New System.Drawing.Point(6, 42)
        Me.RBNaoAlocados.Name = "RBNaoAlocados"
        Me.RBNaoAlocados.Size = New System.Drawing.Size(92, 17)
        Me.RBNaoAlocados.TabIndex = 1
        Me.RBNaoAlocados.Text = "Não Alocados"
        Me.RBNaoAlocados.UseVisualStyleBackColor = True
        '
        'RbAlocados
        '
        Me.RbAlocados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbAlocados.AutoSize = True
        Me.RbAlocados.Location = New System.Drawing.Point(6, 65)
        Me.RbAlocados.Name = "RbAlocados"
        Me.RbAlocados.Size = New System.Drawing.Size(69, 17)
        Me.RbAlocados.TabIndex = 0
        Me.RbAlocados.Text = "Alocados"
        Me.RbAlocados.UseVisualStyleBackColor = True
        '
        'FrmAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(931, 461)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TxtProcura)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dbGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LstItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsset"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manutenção de Assets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstItems As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtValorAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSNAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtModeloAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMarcaAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtContratoAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTipoAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodAsset As System.Windows.Forms.TextBox
    Friend WithEvents DTPAquisicao As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnGravar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtComentarioAsset As System.Windows.Forms.TextBox
    Friend WithEvents dbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBContrato As System.Windows.Forms.RadioButton
    Friend WithEvents RbModelo As System.Windows.Forms.RadioButton
    Friend WithEvents RBMarca As System.Windows.Forms.RadioButton
    Friend WithEvents RBID As System.Windows.Forms.RadioButton
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RBNaoAlocados As System.Windows.Forms.RadioButton
    Friend WithEvents RbAlocados As System.Windows.Forms.RadioButton
    Friend WithEvents cbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbcontrato As System.Windows.Forms.ComboBox
End Class
