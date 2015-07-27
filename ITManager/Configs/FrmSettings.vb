Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Public Class FrmSettings

    Public Sub subGravarConfig()
        If My.Computer.FileSystem.DirectoryExists("C:\VB\") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\VB\")
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\VB\IT\") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\VB\IT\")
        End If

        Dim xmlw As New XmlTextWriter("C:\VB\IT\Config.xml", System.Text.Encoding.UTF8)
        Try
            ' Cria um novo ficheiro XML com a codificação UTF8
            xmlw.Formatting = Formatting.Indented

            xmlw.WriteStartDocument()

            xmlw.WriteComment("ConfiguraçãoGeral") ' Adiciona um comentário geral

            xmlw.WriteStartElement("Config") ' Criar um elemento geral


            With xmlw ' Criar o elemento "Dados SQL" e alguns dados
                .WriteStartElement("DadosSQL")
                .WriteElementString("SQLServer", Settings.strDataSouce)
                .WriteElementString("AutenticaçãoSqlWindows", Settings.bolAutenticaçãoSqlWindows.ToString)
                .WriteElementString("AutenticaçãoSqlServer", Settings.bolAutenticaçãoSqlServer.ToString)
                .WriteElementString("SqlLogin", funEncrypt(Settings.strSqlLogin))
                .WriteElementString("SqlPassword", funEncrypt(Settings.strSqlPassword))
                .WriteElementString("FicheiroBackupDBSql", Settings.strFicheiroBackupDBSql)
                .WriteEndElement()
            End With

            xmlw.WriteEndElement() ' <- config
            xmlw.WriteEndDocument()

        Catch ex As Exception
            MsgBox("Settings: subGravarConfig -> " + ex.Message, MsgBoxStyle.Critical, "Erro a Gravar Configuração")
            Eventos.subErro(ex)
        Finally
            ' Fecha o documento XML
            xmlw.Flush()
            xmlw.Close()
        End Try
    End Sub

    ''' Esta rotina tenta ler a configuração, se não conseguir mete valores de defeito nas variáveis 
  
    Public Sub subLerConfig()
        Try
            Dim xmlFile = XDocument.Load("C:\VB\IT\Config.xml")

            ' Dados SQL
            Settings.strDataSouce = xmlFile...<SQLServer>.Value
            Settings.bolAutenticaçãoSqlWindows = (xmlFile...<AutenticaçãoSqlWindows>.Value.ToString.Trim = "True")
            Settings.bolAutenticaçãoSqlServer = (xmlFile...<AutenticaçãoSqlServer>.Value.ToString.Trim = "True")
            Settings.strSqlLogin = funDecrypt(xmlFile...<SqlLogin>.Value)
            Settings.strSqlPassword = funDecrypt(xmlFile...<SqlPassword>.Value)
            Settings.strFicheiroBackupDBSql = xmlFile...<FicheiroBackupDBSql>.Value

            

        Finally
            strSQLConnection = "Data Source=" & strDataSouce & ";"
            strSQLConnection += "Database=ITManager;"
            If bolAutenticaçãoSqlWindows Then
                strSQLConnection += "Integrated Security=SSPI;"
            Else
                strSQLConnection += "User ID=" & strSqlLogin & ";"
                strSQLConnection += "Password=" & strSqlPassword & ";"
            End If
        End Try
    End Sub
    ''' <summary>
    ''' Copia os valores para as caixas de texto e formata-as
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub subValores2Caixas()
        Try

            ' SQL
            txbNomeServidorSQL.Text = Settings.strDataSouce
            radAutenticaçãoSqlServer.Checked = Settings.bolAutenticaçãoSqlServer
            radAutenticaçãoWindows.Checked = Settings.bolAutenticaçãoSqlWindows
            txbLogin.Text = Settings.strSqlLogin
            txbPassword.Text = Settings.strSqlPassword
            '   txbFicheiroBackupDBSql.Text = Settings.strFicheiroBackupDBSql

            'txbNomeServidorSQL.Enabled = False
            'radAutenticaçãoSqlServer.Enabled = False
            'radAutenticaçãoWindows.Enabled = False
            'txbLogin.Enabled = False
            'txbPassword.Enabled = False   
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub FrmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'subLerConfig()
            subValores2Caixas()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub BtnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGravar.Click
        Try
            If funTestaValores() Then
                ' SQL
                Settings.strDataSouce = txbNomeServidorSQL.Text.Trim
                Settings.bolAutenticaçãoSqlServer = radAutenticaçãoSqlServer.Checked
                Settings.bolAutenticaçãoSqlWindows = radAutenticaçãoWindows.Checked
                Settings.strSqlLogin = txbLogin.Text
                Settings.strSqlPassword = txbPassword.Text
                '   Settings.strFicheiroBackupDBSql = txbFicheiroBackupDBSql.Text


                subGravarConfig()
                subValores2Caixas()
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    'Private Sub btnBackupBaseDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '  subBackupBaseDados()
    'End Sub
    Private Function funTestaValores()
        Try
            If txbNomeServidorSQL.Text.Trim = "" Then
                MsgBox("Nome do servidor SQL inválido")
                Return False
            End If

            

            Return True
        Catch ex As Exception
            Eventos.subErro(ex)
            Return False
        End Try
    End Function
    'Private Sub subBackupBaseDados()
    '    Settings.strFicheiroBackupDBSql = txbFicheiroBackupDBSql.Text
    '    Dim sqlConnBackupDB As New SqlConnection(Settings.strSQLConnection)
    '    Dim cmdBackupDB As SqlCommand
    '    Dim strBackupDB As String = "BACKUP DATABASE ITManager"
    '    If txbFicheiroBackupDBSql.Text <> "" Then strBackupDB += " TO DISK='" & txbFicheiroBackupDBSql.Text & "'"
    '    Try
    '        sqlConnBackupDB.Open()
    '        cmdBackupDB = New SqlCommand(strBackupDB, sqlConnBackupDB)
    '        cmdBackupDB.ExecuteNonQuery() ' Cria Tabela Funcionários
    '        MsgBox("Backup executado com sucesso!")
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Erro a executar backup!")
    '    End Try
    'End Sub

    'The function used to encrypt the text
    Private Function funEncrypt(ByVal strText As String) As String
        Dim byKey() As Byte = System.Text.Encoding.UTF8.GetBytes("&%#@?,:*")
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Try
            Dim des As New DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception
            Eventos.subErro(ex)
            Return ex.Message
        End Try
    End Function
    'The function used to decrypt the text
    Private Function funDecrypt(ByVal strText As String) As String
        Dim byKey() As Byte = System.Text.Encoding.UTF8.GetBytes("&%#@?,:*")
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte
        Try
            Dim des As New DESCryptoServiceProvider()
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
            Return encoding.GetString(ms.ToArray())
        Catch ex As Exception
            Eventos.subErro(ex)
            Return ex.Message
        End Try
    End Function

    Private Sub btnSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSQL.Click
        FrmSQLServer.Show()
        FrmSQLServer.Focus()
    End Sub
End Class