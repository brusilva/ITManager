<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.btnSQL = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.txbLogin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.radAutenticaçãoSqlServer = New System.Windows.Forms.RadioButton()
        Me.radAutenticaçãoWindows = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbNomeServidorSQL = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGravar
        '
        Me.BtnGravar.Location = New System.Drawing.Point(85, 268)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(112, 24)
        Me.BtnGravar.TabIndex = 0
        Me.BtnGravar.Text = "Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = True
        '
        'btnSQL
        '
        Me.btnSQL.Location = New System.Drawing.Point(169, 203)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(89, 31)
        Me.btnSQL.TabIndex = 3
        Me.btnSQL.Text = "Configurar SQL"
        Me.btnSQL.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.btnSQL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txbNomeServidorSQL)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 250)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servidor SQL"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.radAutenticaçãoSqlServer)
        Me.GroupBox5.Controls.Add(Me.radAutenticaçãoWindows)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 45)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(249, 152)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Autenticação"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txbPassword)
        Me.GroupBox6.Controls.Add(Me.txbLogin)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 68)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(236, 72)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Utilizador"
        '
        'txbPassword
        '
        Me.txbPassword.Location = New System.Drawing.Point(68, 44)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPassword.Size = New System.Drawing.Size(162, 20)
        Me.txbPassword.TabIndex = 3
        '
        'txbLogin
        '
        Me.txbLogin.Location = New System.Drawing.Point(68, 18)
        Me.txbLogin.Name = "txbLogin"
        Me.txbLogin.Size = New System.Drawing.Size(162, 20)
        Me.txbLogin.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Password:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Login:"
        '
        'radAutenticaçãoSqlServer
        '
        Me.radAutenticaçãoSqlServer.AutoSize = True
        Me.radAutenticaçãoSqlServer.Location = New System.Drawing.Point(6, 45)
        Me.radAutenticaçãoSqlServer.Name = "radAutenticaçãoSqlServer"
        Me.radAutenticaçãoSqlServer.Size = New System.Drawing.Size(80, 17)
        Me.radAutenticaçãoSqlServer.TabIndex = 1
        Me.radAutenticaçãoSqlServer.TabStop = True
        Me.radAutenticaçãoSqlServer.Text = "SQL Server"
        Me.radAutenticaçãoSqlServer.UseVisualStyleBackColor = True
        '
        'radAutenticaçãoWindows
        '
        Me.radAutenticaçãoWindows.AutoSize = True
        Me.radAutenticaçãoWindows.Location = New System.Drawing.Point(6, 19)
        Me.radAutenticaçãoWindows.Name = "radAutenticaçãoWindows"
        Me.radAutenticaçãoWindows.Size = New System.Drawing.Size(69, 17)
        Me.radAutenticaçãoWindows.TabIndex = 0
        Me.radAutenticaçãoWindows.TabStop = True
        Me.radAutenticaçãoWindows.Text = "Windows"
        Me.radAutenticaçãoWindows.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome:"
        '
        'txbNomeServidorSQL
        '
        Me.txbNomeServidorSQL.Location = New System.Drawing.Point(50, 19)
        Me.txbNomeServidorSQL.Name = "txbNomeServidorSQL"
        Me.txbNomeServidorSQL.Size = New System.Drawing.Size(208, 20)
        Me.txbNomeServidorSQL.TabIndex = 0
        '
        'FrmSettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(294, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnGravar)
        Me.Name = "FrmSettings"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Definições SQL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnGravar As System.Windows.Forms.Button
    Friend WithEvents btnSQL As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txbPassword As System.Windows.Forms.TextBox
    Friend WithEvents txbLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents radAutenticaçãoSqlServer As System.Windows.Forms.RadioButton
    Friend WithEvents radAutenticaçãoWindows As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txbNomeServidorSQL As System.Windows.Forms.TextBox
End Class
