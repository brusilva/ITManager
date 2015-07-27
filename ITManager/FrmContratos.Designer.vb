<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContratos
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
        Me.LstContratos = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.TxtValorMensal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEntidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.DBGridContratos = New System.Windows.Forms.DataGridView()
        Me.LblAsset = New System.Windows.Forms.Label()
        Me.BtnApagar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBGridContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstContratos
        '
        Me.LstContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstContratos.Location = New System.Drawing.Point(12, 12)
        Me.LstContratos.Name = "LstContratos"
        Me.LstContratos.Size = New System.Drawing.Size(228, 508)
        Me.LstContratos.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DtpFim)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DtpInicio)
        Me.GroupBox1.Controls.Add(Me.TxtValorMensal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtEntidade)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 161)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fim"
        '
        'DtpFim
        '
        Me.DtpFim.Location = New System.Drawing.Point(322, 107)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(215, 20)
        Me.DtpFim.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Inicio"
        '
        'DtpInicio
        '
        Me.DtpInicio.Location = New System.Drawing.Point(67, 107)
        Me.DtpInicio.Name = "DtpInicio"
        Me.DtpInicio.Size = New System.Drawing.Size(211, 20)
        Me.DtpInicio.TabIndex = 10
        '
        'TxtValorMensal
        '
        Me.TxtValorMensal.Location = New System.Drawing.Point(322, 76)
        Me.TxtValorMensal.Name = "TxtValorMensal"
        Me.TxtValorMensal.Size = New System.Drawing.Size(114, 20)
        Me.TxtValorMensal.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Valor Mensal"
        '
        'TxtEntidade
        '
        Me.TxtEntidade.Location = New System.Drawing.Point(67, 76)
        Me.TxtEntidade.Name = "TxtEntidade"
        Me.TxtEntidade.Size = New System.Drawing.Size(175, 20)
        Me.TxtEntidade.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Entidade"
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(67, 45)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(369, 20)
        Me.TxtDescricao.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descricao"
        '
        'TxtNr
        '
        Me.TxtNr.Location = New System.Drawing.Point(225, 16)
        Me.TxtNr.Name = "TxtNr"
        Me.TxtNr.Size = New System.Drawing.Size(211, 20)
        Me.TxtNr.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nr Contrato"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(67, 13)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(81, 20)
        Me.TxtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'BtnGravar
        '
        Me.BtnGravar.Location = New System.Drawing.Point(336, 188)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGravar.TabIndex = 4
        Me.BtnGravar.Text = "Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(255, 188)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 5
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'DBGridContratos
        '
        Me.DBGridContratos.AllowUserToAddRows = False
        Me.DBGridContratos.AllowUserToDeleteRows = False
        Me.DBGridContratos.AllowUserToResizeColumns = False
        Me.DBGridContratos.AllowUserToResizeRows = False
        Me.DBGridContratos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBGridContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DBGridContratos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DBGridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBGridContratos.Location = New System.Drawing.Point(248, 217)
        Me.DBGridContratos.MultiSelect = False
        Me.DBGridContratos.Name = "DBGridContratos"
        Me.DBGridContratos.ReadOnly = True
        Me.DBGridContratos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DBGridContratos.ShowCellErrors = False
        Me.DBGridContratos.ShowEditingIcon = False
        Me.DBGridContratos.ShowRowErrors = False
        Me.DBGridContratos.Size = New System.Drawing.Size(548, 120)
        Me.DBGridContratos.TabIndex = 6
        Me.DBGridContratos.VirtualMode = True
        '
        'LblAsset
        '
        Me.LblAsset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAsset.Location = New System.Drawing.Point(246, 340)
        Me.LblAsset.Name = "LblAsset"
        Me.LblAsset.Size = New System.Drawing.Size(550, 180)
        Me.LblAsset.TabIndex = 12
        '
        'BtnApagar
        '
        Me.BtnApagar.Location = New System.Drawing.Point(417, 188)
        Me.BtnApagar.Name = "BtnApagar"
        Me.BtnApagar.Size = New System.Drawing.Size(75, 23)
        Me.BtnApagar.TabIndex = 13
        Me.BtnApagar.Text = "Eliminar"
        Me.BtnApagar.UseVisualStyleBackColor = True
        '
        'FrmContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 532)
        Me.Controls.Add(Me.BtnApagar)
        Me.Controls.Add(Me.LblAsset)
        Me.Controls.Add(Me.DBGridContratos)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.BtnGravar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LstContratos)
        Me.Name = "FrmContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contratos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DBGridContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstContratos As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtValorMensal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtEntidade As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGravar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents DBGridContratos As System.Windows.Forms.DataGridView
    Friend WithEvents LblAsset As System.Windows.Forms.Label
    Friend WithEvents BtnApagar As System.Windows.Forms.Button
End Class
