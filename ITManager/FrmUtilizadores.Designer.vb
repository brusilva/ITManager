<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtilizadores
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
        Me.tvwUsers = New System.Windows.Forms.TreeView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtContacto = New System.Windows.Forms.TextBox()
        Me.TxtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodUser = New System.Windows.Forms.TextBox()
        Me.dbGrid = New System.Windows.Forms.DataGridView()
        Me.LblAsset = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvwUsers
        '
        Me.tvwUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvwUsers.Location = New System.Drawing.Point(12, 12)
        Me.tvwUsers.Name = "tvwUsers"
        Me.tvwUsers.Size = New System.Drawing.Size(242, 545)
        Me.tvwUsers.TabIndex = 1
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Location = New System.Drawing.Point(268, 203)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(66, 23)
        Me.btnNovo.TabIndex = 4
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGravar.Location = New System.Drawing.Point(340, 203)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(66, 23)
        Me.btnGravar.TabIndex = 5
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtContacto)
        Me.GroupBox1.Controls.Add(Me.TxtEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNomeUser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodUser)
        Me.GroupBox1.Location = New System.Drawing.Point(268, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 181)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Pessoais"
        '
        'TxtContacto
        '
        Me.TxtContacto.Location = New System.Drawing.Point(65, 137)
        Me.TxtContacto.Name = "TxtContacto"
        Me.TxtContacto.Size = New System.Drawing.Size(407, 20)
        Me.TxtContacto.TabIndex = 7
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.Location = New System.Drawing.Point(65, 109)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Size = New System.Drawing.Size(99, 20)
        Me.TxtEmpresa.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(65, 83)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(407, 20)
        Me.txtEmail.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contacto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-mail"
        '
        'txtNomeUser
        '
        Me.txtNomeUser.Location = New System.Drawing.Point(65, 55)
        Me.txtNomeUser.Name = "txtNomeUser"
        Me.txtNomeUser.Size = New System.Drawing.Size(407, 20)
        Me.txtNomeUser.TabIndex = 1
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'txtCodUser
        '
        Me.txtCodUser.Location = New System.Drawing.Point(65, 29)
        Me.txtCodUser.Name = "txtCodUser"
        Me.txtCodUser.Size = New System.Drawing.Size(123, 20)
        Me.txtCodUser.TabIndex = 0
        Me.txtCodUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dbGrid
        '
        Me.dbGrid.AllowUserToAddRows = False
        Me.dbGrid.AllowUserToDeleteRows = False
        Me.dbGrid.AllowUserToResizeColumns = False
        Me.dbGrid.AllowUserToResizeRows = False
        Me.dbGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dbGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dbGrid.Location = New System.Drawing.Point(268, 232)
        Me.dbGrid.MultiSelect = False
        Me.dbGrid.Name = "dbGrid"
        Me.dbGrid.ReadOnly = True
        Me.dbGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dbGrid.ShowCellErrors = False
        Me.dbGrid.ShowEditingIcon = False
        Me.dbGrid.ShowRowErrors = False
        Me.dbGrid.Size = New System.Drawing.Size(489, 188)
        Me.dbGrid.TabIndex = 10
        Me.dbGrid.VirtualMode = True
        '
        'LblAsset
        '
        Me.LblAsset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAsset.Location = New System.Drawing.Point(265, 423)
        Me.LblAsset.Name = "LblAsset"
        Me.LblAsset.Size = New System.Drawing.Size(492, 134)
        Me.LblAsset.TabIndex = 11
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(413, 202)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "Elimina"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmUtilizadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 569)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.LblAsset)
        Me.Controls.Add(Me.dbGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.tvwUsers)
        Me.Name = "FrmUtilizadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilizadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvwUsers As System.Windows.Forms.TreeView
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtContacto As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomeUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodUser As System.Windows.Forms.TextBox
    Friend WithEvents dbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents LblAsset As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
End Class
