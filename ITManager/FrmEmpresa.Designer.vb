<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresa
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
        Me.lstempresa = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.dbGrid = New System.Windows.Forms.DataGridView()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.LblAsset = New System.Windows.Forms.Label()
        Me.dbgrid2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbgrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstempresa
        '
        Me.lstempresa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstempresa.Location = New System.Drawing.Point(9, 12)
        Me.lstempresa.Name = "lstempresa"
        Me.lstempresa.Size = New System.Drawing.Size(226, 520)
        Me.lstempresa.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Location = New System.Drawing.Point(244, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 82)
        Me.GroupBox1.TabIndex = 10
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
        Me.dbGrid.Location = New System.Drawing.Point(244, 129)
        Me.dbGrid.MultiSelect = False
        Me.dbGrid.Name = "dbGrid"
        Me.dbGrid.ReadOnly = True
        Me.dbGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dbGrid.ShowCellErrors = False
        Me.dbGrid.ShowEditingIcon = False
        Me.dbGrid.ShowRowErrors = False
        Me.dbGrid.Size = New System.Drawing.Size(505, 266)
        Me.dbGrid.TabIndex = 11
        Me.dbGrid.VirtualMode = True
        '
        'btnGravar
        '
        Me.btnGravar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGravar.Location = New System.Drawing.Point(482, 100)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(66, 23)
        Me.btnGravar.TabIndex = 14
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Location = New System.Drawing.Point(396, 100)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(66, 23)
        Me.btnNovo.TabIndex = 13
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'LblAsset
        '
        Me.LblAsset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAsset.Location = New System.Drawing.Point(241, 398)
        Me.LblAsset.Name = "LblAsset"
        Me.LblAsset.Size = New System.Drawing.Size(508, 134)
        Me.LblAsset.TabIndex = 15
        '
        'dbgrid2
        '
        Me.dbgrid2.AllowUserToAddRows = False
        Me.dbgrid2.AllowUserToDeleteRows = False
        Me.dbgrid2.AllowUserToResizeColumns = False
        Me.dbgrid2.AllowUserToResizeRows = False
        Me.dbgrid2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbgrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dbgrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dbgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgrid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dbgrid2.Location = New System.Drawing.Point(244, 401)
        Me.dbgrid2.MultiSelect = False
        Me.dbgrid2.Name = "dbgrid2"
        Me.dbgrid2.ReadOnly = True
        Me.dbgrid2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dbgrid2.ShowCellErrors = False
        Me.dbgrid2.ShowEditingIcon = False
        Me.dbgrid2.ShowRowErrors = False
        Me.dbgrid2.Size = New System.Drawing.Size(505, 131)
        Me.dbgrid2.TabIndex = 16
        Me.dbgrid2.VirtualMode = True
        '
        'FrmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 544)
        Me.Controls.Add(Me.dbgrid2)
        Me.Controls.Add(Me.LblAsset)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dbGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstempresa)
        Me.Name = "FrmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbgrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstempresa As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents dbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents LblAsset As System.Windows.Forms.Label
    Friend WithEvents dbgrid2 As System.Windows.Forms.DataGridView
End Class
