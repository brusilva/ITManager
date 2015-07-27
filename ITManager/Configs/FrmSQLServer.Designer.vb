<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSqlServer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExecutarCmdSql = New System.Windows.Forms.Button()
        Me.btnTestarLigação = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.txbLogin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radAutenticaçãoSqlServer = New System.Windows.Forms.RadioButton()
        Me.radAutenticaçãoWindows = New System.Windows.Forms.RadioButton()
        Me.txbLog = New System.Windows.Forms.TextBox()
        Me.btnCriarBaseDados = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbServer = New System.Windows.Forms.ComboBox()
        Me.lstDatabases = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExecutarCmdSql)
        Me.GroupBox1.Controls.Add(Me.btnTestarLigação)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.radAutenticaçãoSqlServer)
        Me.GroupBox1.Controls.Add(Me.radAutenticaçãoWindows)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 152)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Autenticação"
        '
        'btnExecutarCmdSql
        '
        Me.btnExecutarCmdSql.Location = New System.Drawing.Point(183, 19)
        Me.btnExecutarCmdSql.Name = "btnExecutarCmdSql"
        Me.btnExecutarCmdSql.Size = New System.Drawing.Size(79, 43)
        Me.btnExecutarCmdSql.TabIndex = 12
        Me.btnExecutarCmdSql.Text = "Executar Cmd SQL"
        Me.btnExecutarCmdSql.UseVisualStyleBackColor = True
        '
        'btnTestarLigação
        '
        Me.btnTestarLigação.Location = New System.Drawing.Point(102, 19)
        Me.btnTestarLigação.Name = "btnTestarLigação"
        Me.btnTestarLigação.Size = New System.Drawing.Size(75, 43)
        Me.btnTestarLigação.TabIndex = 10
        Me.btnTestarLigação.Text = "&Testar Ligação"
        Me.btnTestarLigação.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txbPassword)
        Me.GroupBox2.Controls.Add(Me.txbLogin)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 72)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Utilizador"
        '
        'txbPassword
        '
        Me.txbPassword.Location = New System.Drawing.Point(68, 44)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPassword.Size = New System.Drawing.Size(182, 20)
        Me.txbPassword.TabIndex = 3
        '
        'txbLogin
        '
        Me.txbLogin.Location = New System.Drawing.Point(68, 18)
        Me.txbLogin.Name = "txbLogin"
        Me.txbLogin.Size = New System.Drawing.Size(182, 20)
        Me.txbLogin.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Login:"
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
        'txbLog
        '
        Me.txbLog.Location = New System.Drawing.Point(15, 353)
        Me.txbLog.Multiline = True
        Me.txbLog.Name = "txbLog"
        Me.txbLog.Size = New System.Drawing.Size(268, 56)
        Me.txbLog.TabIndex = 16
        '
        'btnCriarBaseDados
        '
        Me.btnCriarBaseDados.Location = New System.Drawing.Point(15, 324)
        Me.btnCriarBaseDados.Name = "btnCriarBaseDados"
        Me.btnCriarBaseDados.Size = New System.Drawing.Size(268, 23)
        Me.btnCriarBaseDados.TabIndex = 15
        Me.btnCriarBaseDados.Text = "&Criar Base de Dados"
        Me.btnCriarBaseDados.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(208, 23)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Bases de Dados do Servidor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Servidores SQL Existentes:"
        '
        'cmbServer
        '
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Location = New System.Drawing.Point(15, 25)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Size = New System.Drawing.Size(187, 21)
        Me.cmbServer.TabIndex = 10
        '
        'lstDatabases
        '
        Me.lstDatabases.Enabled = False
        Me.lstDatabases.FormattingEnabled = True
        Me.lstDatabases.Location = New System.Drawing.Point(15, 223)
        Me.lstDatabases.Name = "lstDatabases"
        Me.lstDatabases.Size = New System.Drawing.Size(268, 95)
        Me.lstDatabases.TabIndex = 12
        '
        'frmSqlServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txbLog)
        Me.Controls.Add(Me.btnCriarBaseDados)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbServer)
        Me.Controls.Add(Me.lstDatabases)
        Me.Name = "frmSqlServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Server"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExecutarCmdSql As System.Windows.Forms.Button
    Friend WithEvents btnTestarLigação As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txbPassword As System.Windows.Forms.TextBox
    Friend WithEvents txbLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radAutenticaçãoSqlServer As System.Windows.Forms.RadioButton
    Friend WithEvents radAutenticaçãoWindows As System.Windows.Forms.RadioButton
    Friend WithEvents txbLog As System.Windows.Forms.TextBox
    Friend WithEvents btnCriarBaseDados As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbServer As System.Windows.Forms.ComboBox
    Friend WithEvents lstDatabases As System.Windows.Forms.ListBox
End Class
