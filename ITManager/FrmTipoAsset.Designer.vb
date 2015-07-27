<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoAsset
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
        Me.LstTipos = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dbGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstTipos
        '
        Me.LstTipos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LstTipos.Location = New System.Drawing.Point(12, 12)
        Me.LstTipos.Name = "LstTipos"
        Me.LstTipos.Size = New System.Drawing.Size(189, 481)
        Me.LstTipos.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Location = New System.Drawing.Point(207, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 82)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(125, 29)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(347, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(65, 29)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(54, 20)
        Me.txtCod.TabIndex = 0
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGravar
        '
        Me.btnGravar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGravar.Location = New System.Drawing.Point(541, 100)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(66, 23)
        Me.btnGravar.TabIndex = 16
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Location = New System.Drawing.Point(395, 100)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(66, 23)
        Me.btnNovo.TabIndex = 15
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'dbGrid
        '
        Me.dbGrid.AllowUserToAddRows = False
        Me.dbGrid.AllowUserToDeleteRows = False
        Me.dbGrid.AllowUserToResizeColumns = False
        Me.dbGrid.AllowUserToResizeRows = False
        Me.dbGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dbGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dbGrid.Location = New System.Drawing.Point(207, 150)
        Me.dbGrid.MultiSelect = False
        Me.dbGrid.Name = "dbGrid"
        Me.dbGrid.ReadOnly = True
        Me.dbGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dbGrid.ShowCellErrors = False
        Me.dbGrid.ShowEditingIcon = False
        Me.dbGrid.ShowRowErrors = False
        Me.dbGrid.Size = New System.Drawing.Size(604, 343)
        Me.dbGrid.TabIndex = 17
        Me.dbGrid.VirtualMode = True
        '
        'FrmTipoAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 498)
        Me.Controls.Add(Me.dbGrid)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LstTipos)
        Me.Name = "FrmTipoAsset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstTipos As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents dbGrid As System.Windows.Forms.DataGridView
End Class
