Imports Microsoft.SqlServer.Management
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Sdk
Imports System.Data.SqlClient


Public Class frmSqlServer

    Private Sub frmSqlServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Quando arrancar a form, carregamos a lista de servidores
        Try
            radAutenticaçãoSqlServer.Checked = Settings.bolAutenticaçãoSqlServer
            radAutenticaçãoWindows.Checked = Settings.bolAutenticaçãoSqlWindows
            txbLogin.Text = Settings.strSqlLogin
            txbPassword.Text = Settings.strSqlPassword
            txbLogin.Enabled = radAutenticaçãoSqlServer.Checked
            txbPassword.Enabled = radAutenticaçãoSqlServer.Checked
            subListaServers()
            cmbServer.SelectedIndex = cmbServer.FindString(Settings.strDataSouce)
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub cmbServer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Vamos mostrar todas as bases de dados registadas no servidor seleccionado
        Try
            subListaBasesDados()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub btnExecutarCmdSql_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCmdSql.Show()
        frmCmdSql.Focus()
    End Sub

    Private Sub radAutenticaçãoSqlServer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Sempre que o utilizador alterar o tipo de autenticação permitimos ou não alterar os dados de login
        txbLogin.Enabled = radAutenticaçãoSqlServer.Checked
        txbPassword.Enabled = radAutenticaçãoSqlServer.Checked
    End Sub

    Private Sub subListaServers() ' Preenchemos a ComboBox com todos os servidores SQL acessiveis
        Try
            Dim s() As clsSqlServer.ServerInstance
            s = clsSqlServer.EnumerateServers()
            cmbServer.Items.Clear()
            If s.Length > 0 Then
                For i = 0 To s.Length - 1
                    cmbServer.Items.Add(s(i).Name)
                Next
            Else
                MsgBox("Não foi possível encontrar nenhum servidor SQL!", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub subGravarConfiguração()
        Try
            Settings.strDataSouce = cmbServer.SelectedItem.ToString
            Settings.bolAutenticaçãoSqlServer = radAutenticaçãoSqlServer.Checked
            Settings.bolAutenticaçãoSqlWindows = radAutenticaçãoWindows.Checked
            Settings.strSqlLogin = txbLogin.Text
            Settings.strSqlPassword = txbPassword.Text
            FrmSettings.subGravarConfig()
            FrmSettings.subLerConfig()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub subListaBasesDados()
        Try
            lstDatabases.Items.Clear()
            If cmbServer.SelectedIndex <> -1 Then
                Dim serverName As String = cmbServer.SelectedItem.ToString
                Dim server As Server = New Server(serverName)
                Try
                    For Each database As Database In server.Databases
                        lstDatabases.Items.Add(database.Name)
                    Next
                Catch ex As Exception
                    Eventos.subErro(ex)
                End Try
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub btnExecutarCmdSql_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecutarCmdSql.Click
        frmCmdSql.Show()
        frmCmdSql.Focus()
    End Sub

    Private Sub btnActualizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            subListaServers()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub btnCriarBaseDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarBaseDados.Click
        Try
            subCriarBaseDados()

        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub btnTestarLigação_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestarLigação.Click
        Try
            If cmbServer.SelectedIndex <> -1 Then
                Dim strConnString As String = ""
                strConnString = "Data Source=" & cmbServer.SelectedItem.ToString & ";"
                If radAutenticaçãoWindows.Checked Then
                    strConnString += "Integrated Security=SSPI;"
                Else
                    strConnString += "User ID=" & txbLogin.Text & ";"
                    strConnString += "Password=" & txbPassword.Text & ";"
                End If
                Dim sqlConnDB As SqlConnection = New SqlConnection(strConnString)

                sqlConnDB.Open()
                If sqlConnDB.State <> ConnectionState.Open Then
                    MsgBox("Erro a abrir ligação!", MsgBoxStyle.Critical, "Salários - SQL Server")
                Else
                    sqlConnDB.Close()
                    MsgBox("Ligação correcta.", MsgBoxStyle.Information, "Salários - SQL Server")
                End If
            Else
                MsgBox("Nenhum servidor seleccionado!", MsgBoxStyle.Information, "Seleccione um servidor")
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub subCriarBaseDados()
        Dim bolDBCriada As Boolean = False
        Dim strConnString As String = ""
        strConnString = "Data Source=" & cmbServer.SelectedItem.ToString & ";"
        If radAutenticaçãoWindows.Checked Then
            strConnString += "Integrated Security=SSPI;"
        Else
            strConnString += "User ID=" & txbLogin.Text & ";"
            strConnString += "Password=" & txbPassword.Text & ";"
        End If
        Dim sqlConnDB As SqlConnection = New SqlConnection(strConnString)
        Dim strCreateDB As String = ""
        strCreateDB += "CREATE DATABASE ITManager "
        'strCreateDB += "ON " 'PRIMARY"
        'strCreateDB += "(NAME=ITManager, "
        'strCreateDB += "FILENAME='ITManager.mdf', "
        'strCreateDB += "SIZE=3, MAXSIZE=UNLIMITED, FILEGROWTH=10%) "
        'strCreateDB += "LOG ON "
        'strCreateDB += "(NAME=ITManager_log, "
        'strCreateDB += "FILENAME='ITManager.ldf', "
        'strCreateDB += "SIZE=1, MAXSIZE=UNLIMITED,FILEGROWTH=10%)"

        txbLog.Text = strCreateDB

        sqlConnDB.Open()
        If sqlConnDB.State <> ConnectionState.Open Then
            Throw New Exception("Erro a abrir ligação")
        Else
            sqlConnDB.Close()
        End If

        Dim sqlCmdCreateDB As SqlCommand = New SqlCommand(strCreateDB, sqlConnDB)
        Try
            sqlConnDB.Open()
            sqlCmdCreateDB.ExecuteNonQuery()
            bolDBCriada = True
            'MsgBox("Base de dados criada com sucesso!")
        Catch ex As Exception
            MsgBox("Não foi possível criar a base de dados!" & vbNewLine & "Erro: " & ex.Message)
        Finally
            If sqlConnDB.State = ConnectionState.Open Then
                sqlConnDB.Close()
            End If
        End Try
        If bolDBCriada Then
            txbLog.Text = "Base de dados registada com sucesso."
            subGravarConfiguração()
            subCriarTabelas2_0()
            subListaBasesDados()
        End If
    End Sub

    

    Private Sub radAutenticaçãoSqlServer_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAutenticaçãoSqlServer.CheckedChanged
        txbLogin.Enabled = radAutenticaçãoSqlServer.Checked
        txbPassword.Enabled = radAutenticaçãoSqlServer.Checked
    End Sub

    Private Sub radAutenticaçãoWindows_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAutenticaçãoWindows.CheckedChanged
        txbLogin.Enabled = radAutenticaçãoSqlServer.Checked
        txbPassword.Enabled = radAutenticaçãoSqlServer.Checked
    End Sub


    Public Sub subCriarTabelas2_0()
        Try
            ' Criação da tabela Utilizadores
            Dim strCriaUtilizadores As String = ""
            strCriaUtilizadores += "CREATE TABLE Utilizadores ( "
            strCriaUtilizadores += "ID int not null, "
            strCriaUtilizadores += "Nome ntext, "
            strCriaUtilizadores += "Empresa int not null, "
            strCriaUtilizadores += "Mail ntext, "
            strCriaUtilizadores += "Contacto ntext )"

            ' Criação da tabela Empresas
            Dim strCriaEmpresas As String = ""
            strCriaEmpresas += "CREATE TABLE Empresa ( "
            strCriaEmpresas += "ID int not null, "
            strCriaEmpresas += "Nome ntext not null)  "
            'Criação da tabela Contratos
            Dim strcriaContratos As String = ""
            strcriaContratos += "CREATE TABLE Contratos ("
            strcriaContratos += "ID int, "
            strcriaContratos += "NumeroContrato ntext, "
            strcriaContratos += "Descricao ntext, "
            strcriaContratos += "Entidade ntext, "
            strcriaContratos += "DataAssinatura Date, "
            strcriaContratos += "DataFim date, "
            strcriaContratos += "ValorMensal real )"

            'Criação da Tabela Asset
            Dim strCriaAsset As String = ""
            strCriaAsset += "CREATE TABLE Asset ("
            strCriaAsset += "ID int, "
            strCriaAsset += "Tipo int, "
            strCriaAsset += "Contrato int, "
            strCriaAsset += "Marca ntext, "
            strCriaAsset += "Comentário ntext, "
            strCriaAsset += "Modelo ntext, "
            strCriaAsset += "SN ntext, "
            strCriaAsset += "DataAquisicao date, "
            strCriaAsset += "Valor real ) "

            'Criação da Tabela AssetType
            Dim strCriaAssetType As String = ""
            strCriaAssetType += "CREATE TABLE AssetType ("
            strCriaAssetType += "ID int, "
            strCriaAssetType += "Tipo ntext )"

            'Criação da Tabela Alocacoes
            Dim strCriaAlocacoes As String = ""
            strCriaAlocacoes += "CREATE TABLE Alocacoes ("
            strCriaAlocacoes += "ID int identity, "
            strCriaAlocacoes += "Activo int, "
            strCriaAlocacoes += "Asset int, "
            strCriaAlocacoes += "[User] int, "
            strCriaAlocacoes += "Data date, "
            strCriaAlocacoes += "Motivo ntext )"


            ' Criação efectiva
            Dim sqlConnCriarTabelas As New SqlConnection(Settings.strSQLConnection)
            Dim cmdCriarTabela As SqlCommand
            sqlConnCriarTabelas.Open()
            cmdCriarTabela = New SqlCommand(strCriaUtilizadores, sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Cria Tabela Utilizadores
            cmdCriarTabela = New SqlCommand(strCriaAlocacoes, sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Cria Tabela Alocacoes
            cmdCriarTabela = New SqlCommand(strCriaAsset, sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Cria Tabela  ASset
            cmdCriarTabela = New SqlCommand(strCriaAssetType, sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Cria Tabela Assettype
            cmdCriarTabela = New SqlCommand(strcriaContratos, sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Cria Tabela Contratos
            cmdCriarTabela = New SqlCommand(strCriaEmpresas, sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Cria Tabela Empresas

            cmdCriarTabela = New SqlCommand("Insert Into Empresa VALUES (1,'Empresa 1')", sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Introduz Empresa Demo

            cmdCriarTabela = New SqlCommand("Insert Into assettype Values (1,'Tipo 1')", sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Introduz Tipo Demo

            cmdCriarTabela = New SqlCommand("Insert Into Contratos  (ID  , NumeroContrato) Values (0,'Sem Contrato')", sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Introduz Contratos

            cmdCriarTabela = New SqlCommand("Insert Into Utilizadores Values (1,'Utilizador 1',1,'mail@exemplo.com','91000000')", sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Introduz Utilizadores

            cmdCriarTabela = New SqlCommand("Insert Into asset  (ID, Tipo, Contrato) Values (1,1,1)", sqlConnCriarTabelas)
            cmdCriarTabela.ExecuteNonQuery() ' Introduz Utilizadores

            sqlConnCriarTabelas.Close()
            txbLog.Text += vbNewLine & "Base de dados criada com sucesso."
        Catch ex As Exception
            Eventos.subErro(ex)
            txbLog.Text += vbNewLine & "Erro ao criar a base de dados."
        End Try
    End Sub
End Class