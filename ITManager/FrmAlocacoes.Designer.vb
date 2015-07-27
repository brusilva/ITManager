<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlocacoes
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
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.dbgridalocacao = New System.Windows.Forms.DataGridView()
        Me.dbGrid = New System.Windows.Forms.DataGridView()
        Me.DTPAlocacao = New System.Windows.Forms.DateTimePicker()
        Me.TxtMotivo = New System.Windows.Forms.TextBox()
        Me.tvwUsers = New System.Windows.Forms.TreeView()
        Me.btnadiciona = New System.Windows.Forms.Button()
        Me.btnremover = New System.Windows.Forms.Button()
        CType(Me.dbgridalocacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNovo
        '
        Me.BtnNovo.Location = New System.Drawing.Point(844, 501)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(92, 23)
        Me.BtnNovo.TabIndex = 2
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'dbgridalocacao
        '
        Me.dbgridalocacao.AllowUserToAddRows = False
        Me.dbgridalocacao.AllowUserToDeleteRows = False
        Me.dbgridalocacao.AllowUserToResizeColumns = False
        Me.dbgridalocacao.AllowUserToResizeRows = False
        Me.dbgridalocacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbgridalocacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dbgridalocacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgridalocacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dbgridalocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgridalocacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dbgridalocacao.Location = New System.Drawing.Point(251, 12)
        Me.dbgridalocacao.MultiSelect = False
        Me.dbgridalocacao.Name = "dbgridalocacao"
        Me.dbgridalocacao.ReadOnly = True
        Me.dbgridalocacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dbgridalocacao.ShowCellErrors = False
        Me.dbgridalocacao.ShowEditingIcon = False
        Me.dbgridalocacao.ShowRowErrors = False
        Me.dbgridalocacao.Size = New System.Drawing.Size(685, 258)
        Me.dbgridalocacao.TabIndex = 15
        Me.dbgridalocacao.VirtualMode = True
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
        Me.dbGrid.Enabled = False
        Me.dbGrid.Location = New System.Drawing.Point(251, 276)
        Me.dbGrid.MultiSelect = False
        Me.dbGrid.Name = "dbGrid"
        Me.dbGrid.ReadOnly = True
        Me.dbGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dbGrid.ShowCellErrors = False
        Me.dbGrid.ShowEditingIcon = False
        Me.dbGrid.ShowRowErrors = False
        Me.dbGrid.Size = New System.Drawing.Size(685, 222)
        Me.dbGrid.TabIndex = 16
        Me.dbGrid.VirtualMode = True
        Me.dbGrid.Visible = False
        '
        'DTPAlocacao
        '
        Me.DTPAlocacao.Location = New System.Drawing.Point(66, 504)
        Me.DTPAlocacao.Name = "DTPAlocacao"
        Me.DTPAlocacao.Size = New System.Drawing.Size(243, 20)
        Me.DTPAlocacao.TabIndex = 17
        Me.DTPAlocacao.Visible = False
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Location = New System.Drawing.Point(394, 504)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(439, 20)
        Me.TxtMotivo.TabIndex = 18
        Me.TxtMotivo.Visible = False
        '
        'tvwUsers
        '
        Me.tvwUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvwUsers.Location = New System.Drawing.Point(3, 12)
        Me.tvwUsers.Name = "tvwUsers"
        Me.tvwUsers.Size = New System.Drawing.Size(242, 486)
        Me.tvwUsers.TabIndex = 20
        '
        'btnadiciona
        '
        Me.btnadiciona.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnadiciona.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadiciona.Image = Global.ITManage.My.Resources.Resources.Check_icon
        Me.btnadiciona.Location = New System.Drawing.Point(942, 357)
        Me.btnadiciona.Name = "btnadiciona"
        Me.btnadiciona.Size = New System.Drawing.Size(30, 30)
        Me.btnadiciona.TabIndex = 22
        Me.btnadiciona.UseVisualStyleBackColor = True
        Me.btnadiciona.Visible = False
        '
        'btnremover
        '
        Me.btnremover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnremover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnremover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnremover.Image = Global.ITManage.My.Resources.Resources.Delete_icon1
        Me.btnremover.Location = New System.Drawing.Point(940, 109)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(31, 31)
        Me.btnremover.TabIndex = 21
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'FrmAlocacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 549)
        Me.Controls.Add(Me.btnadiciona)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.tvwUsers)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.DTPAlocacao)
        Me.Controls.Add(Me.dbGrid)
        Me.Controls.Add(Me.dbgridalocacao)
        Me.Controls.Add(Me.BtnNovo)
        Me.Name = "FrmAlocacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alocacoes"
        CType(Me.dbgridalocacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNovo As System.Windows.Forms.Button
    Friend WithEvents dbgridalocacao As System.Windows.Forms.DataGridView
    Friend WithEvents dbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DTPAlocacao As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents tvwUsers As System.Windows.Forms.TreeView
    Friend WithEvents btnadiciona As System.Windows.Forms.Button
    Friend WithEvents btnremover As System.Windows.Forms.Button
End Class
