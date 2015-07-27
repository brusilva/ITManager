Imports System.Data.SqlClient

Public Class FrmUtilizadores

    Private Sub FrmUtilizadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCodUser.ReadOnly = True
            subRebuildArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub tvwUsers_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwUsers.AfterSelect
        If tvwUsers.SelectedNode.Level <> 0 Then
            Try
                For Each node As TreeNode In tvwUsers.Nodes(0).Nodes
                    node.BackColor = Color.White
                Next
                If tvwUsers.SelectedNode.Tag <> "Utilizadores" Then
                    SubLerUser()
                    tvwUsers.SelectedNode.BackColor = Color.Beige
                Else
                    subLimpaValores()
                End If
            Catch ex As Exception
                Eventos.subErro(ex)
            End Try


        End If

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            subLimpaValores()
            subRebuildArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Try
            If funTestaValores() Then
                Dim x As Integer

                ' Contamos o nº de funcionários
                Dim intCodFunc As Integer = 0

                If txtCodUser.Text = "" Then
                    Dim strIDUserSQL As String = "SELECT MAX(ID) AS ID FROM Utilizadores"
                    Dim sqlConnIDUser As New SqlConnection(Settings.strSQLConnection)
                    Dim commandUser As New SqlCommand(strIDUserSQL, sqlConnIDUser)
                    sqlConnIDUser.Open()

                    Dim readerFuncionário As SqlDataReader = commandUser.ExecuteReader()
                    If readerFuncionário.HasRows Then
                        While readerFuncionário.Read()
                            intCodFunc += readerFuncionário.Item("ID").ToString
                        End While
                    End If
                    intCodFunc += 1
                    txtCodUser.Text = intCodFunc.ToString
                    ' Fecha a ligação e limpa as variáveis
                    sqlConnIDUser.Close()
                    sqlConnIDUser = Nothing
                    commandUser = Nothing
                Else
                    intCodFunc = Int(txtCodUser.Text)
                End If


                ' Inserimos ou actualizamos os dados dos funcionários na tabela Funcionários
 
                Dim strUsersSQL As String = "IF EXISTS "
                strUsersSQL += " (SELECT ID FROM Utilizadores WHERE "
                strUsersSQL += " ID ='" & StrConv(txtCodUser.Text.Trim, VbStrConv.ProperCase) & "' "
                strUsersSQL += ") "
                strUsersSQL += " UPDATE Utilizadores SET "
                strUsersSQL += " Nome ='" & StrConv(txtNomeUser.Text.Trim, VbStrConv.ProperCase) & "', "
                strUsersSQL += " Empresa ='" & StrConv(TxtEmpresa.Text.Trim, VbStrConv.Lowercase) & "', "
                strUsersSQL += " Mail ='" & txtEmail.Text.Trim.Replace(" ", "") & "', "
                strUsersSQL += " Contacto ='" & TxtContacto.Text.Trim.Replace(" ", "") & "' "

                strUsersSQL += " WHERE ID ='" & txtCodUser.Text.Trim & "' "
                strUsersSQL += " ELSE "
                strUsersSQL += " INSERT INTO Utilizadores VALUES ("
                strUsersSQL += "'" & intCodFunc & "', "

                strUsersSQL += "'" & StrConv(txtNomeUser.Text.Trim, VbStrConv.ProperCase) & "', "
                strUsersSQL += "'" & StrConv(TxtEmpresa.Text.Trim, VbStrConv.ProperCase) & "', "
                strUsersSQL += "'" & txtEmail.Text.Trim.Replace(" ", "") & "', "
                strUsersSQL += "'" & TxtContacto.Text.Trim.Replace(" ", "") & "' "
                strUsersSQL += ")"

                Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
                Dim execUsers As New SqlCommand(strUsersSQL, sqlConnUsers)
                sqlConnUsers.Open()
                x = execUsers.ExecuteNonQuery
                sqlConnUsers.Close()
                sqlConnUsers = Nothing
                execUsers = Nothing
                strUsersSQL = Nothing

                txtCodUser.Text = intCodFunc.ToString
                MsgBox("Gravado", vbOKOnly & vbInformation, "IT Manager")
                subRebuildArvore()
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub subRebuildArvore()
        Try
            tvwUsers.Nodes.Clear()
            Dim strsql_empresas As String = "Select * From Empresa"
            Dim dsetempresas As New DataSet
            Dim sql_empresas As New SqlConnection(Settings.strSQLConnection)
            Dim da_empresas As New SqlDataAdapter(strsql_empresas, Settings.strSQLConnection)

            sql_empresas.Open()
            da_empresas.Fill(dsetempresas, "Nome")
            sql_empresas.Close()

            For Each rowempresas As DataRow In dsetempresas.Tables("Nome").Rows

                Dim strSQL As String = "Select * FROM Utilizadores WHERE EMPRESA = " & rowempresas("ID").ToString.Trim
                Dim dset As New DataSet
                Dim sql_connection As New SqlConnection(Settings.strSQLConnection)
                Dim daset As New SqlDataAdapter(strSQL, Settings.strSQLConnection)

                sql_connection.Open()
                daset.Fill(dset, "Nome")

                sql_connection.Close()
                Dim noderoot As TreeNode
                noderoot = New TreeNode
                noderoot.Text = rowempresas("Nome").ToString.Trim
                noderoot.Tag = rowempresas("Nome").ToString.Trim

                tvwUsers.Nodes.Add(noderoot)
                For Each rowuser As DataRow In dset.Tables("Nome").Rows
                    Dim nodeuser As TreeNode
                    nodeuser = New TreeNode
                    nodeuser.Text = rowuser("Nome").ToString.Trim
                    nodeuser.Tag = rowuser("Nome").ToString.Trim
                    noderoot.Nodes.Add(nodeuser)

                Next

            Next
        
            tvwUsers.EndUpdate()

        Catch ex As Exception
            Eventos.subErro(ex)

        Finally
            tvwUsers.ExpandAll()
            tvwUsers.CollapseAll()

        End Try
    End Sub

    Private Sub SubLerUser()
        LblAsset.Text = ""
        Try
            Dim strUserSQL As String = "SELECT * FROM Utilizadores WHERE Nome like '" & tvwUsers.SelectedNode.Tag & "'"

            Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
            Dim commandUser As New SqlCommand(strUserSQL, sqlConn)
            sqlConn.Open()

            ' Executa o comando colocando num SqlDataReader os resultados
            Dim readerUser As SqlDataReader = commandUser.ExecuteReader()
            ' Caso existam rows (linhas)

            If readerUser.HasRows Then
                ' Executa um ciclo nas linhas existentes mostrando o campo “username”
                While readerUser.Read()
                    Dim strIDUser As String = readerUser.Item("ID").ToString.Trim
                    Dim strNome As String = readerUser.Item("Nome").ToString.Trim
                    Dim strMail As String = readerUser.Item("Mail").ToString.Trim
                    Dim strContacto As String = readerUser.Item("Contacto").ToString.Trim
                    Dim strempresa As String = readerUser.Item("Empresa").ToString.Trim


                    txtCodUser.Text = strIDUser
                    txtNomeUser.Text = strNome
                    txtEmail.Text = strMail
                    TxtContacto.Text = strContacto
                    TxtEmpresa.Text = strempresa

                End While
            Else
                subLimpaValores()
            End If

            Dim sql As String = "select  asset.id as ID, assettype.Tipo as Tipo, asset.Marca as Marca ,  asset.Modelo as Modelo, alocacoes.Data , alocacoes.Motivo from  Alocacoes inner join Asset on Asset.ID = Alocacoes.Asset inner join AssetType on asset.Tipo = assettype.ID where [Alocacoes].[User] = " & txtCodUser.Text '& "'"
            Funcoes.TrataGrelha(dbGrid, sql, txtCodUser.Text)

            ' Fecha a ligação e limpa as variáveis
            sqlConn.Close()
            sqlConn = Nothing
            commandUser = Nothing
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    ' Private Sub TrataGrelha()
    'Try
    '    Dim strGrelhaSQL As String = "Select * from Alocacoes Where user ='" & txtCodUser.Text & "'"
    '    Dim sqlconnGrelha As New SqlConnection(Settings.strSQLConnection)
    '    sqlconnGrelha.Open()

    '    'Dim readerGrelha As SqlDataReader = commandGrelha.ExecuteReader
    '    Dim sqlgrelha As String = "select  Rtrim(asset.id) as ID, RTrim(assettype.Tipo) as Tipo, RTrim(asset.Marca) as Marca ,  RTrim(asset.Modelo) as Modelo, alocacoes.Data , alocacoes.Motivo from  Alocacoes inner join Asset on Asset.ID = Alocacoes.Asset inner join AssetType on asset.Tipo = assettype.ID where [Alocacoes].[User] = '"
    '    Dim dataAdapter = New SqlDataAdapter(sqlgrelha & txtCodUser.Text & "'", sqlconnGrelha)
    '    Dim commandGrelha As New SqlCommandBuilder(dataAdapter)
    '    Dim table As New DataTable()
    '    dataAdapter.Fill(table)
    '    dbGrid.DataSource = table

    '    ' Fecha a ligação e limpa as variáveis
    '    sqlconnGrelha.Close()
    '    sqlconnGrelha = Nothing
    '    commandGrelha = Nothing
    '    sqlgrelha = Nothing
    'Catch ex As Exception
    '    Eventos.subErro(ex)
    'End Try


    '  End Sub

    Private Sub subLimpaValores()
        ' Rotina que limpa todos os dados das textboxs e passa as datas para hoje.
        txtCodUser.Clear()
        txtNomeUser.Clear()
        TxtContacto.Clear()
        txtEmail.Clear()
        TxtEmpresa.Clear()
        LblAsset.Text = ""
    End Sub

    Private Function funTestaValores() As Boolean
        'Valida os valores introduzidos para não dar erro no envio para o SQL  
        'Retorna True se todos os dados estiverem correctos</returns>
        Try
            'If txtNomeUser.Text.Trim = "" Then
            '    MsgBox("Nome do funcionário não preenchido!")
            '    Return False
            'End If
            'If txtNomeUser.Text.Trim.Length > 100 Then
            '    MsgBox("Nome do funcionário muito comprido!")
            '    Return False
            'End If
            'If txbFunçãoFuncionário.Text.Trim = "" Then
            '    MsgBox("Função do funcionário não preenchido!")
            '    Return False
            'End If
            'If txbFunçãoFuncionário.Text.Trim.Length > 50 Then
            '    MsgBox("Descrição da Função do funcionário muito comprida!")
            '    Return False
            'End If

            '' TODO -> Validar Nº da Segurança Social
            ''strUpdateSQL += " NúmeroSegSocial ='" & StrConv(txbNúmeroSegSocial.Text.Trim, VbStrConv.ProperCase) & "',"
            'If mtbNúmeroSegSocial.Text.Trim.Length > 50 Then
            '    MsgBox("Número de Segurança Social muito comprido!")
            '    Return False
            'End If
            'If mtbNúmeroSegSocial.Text.Trim = "" Then
            '    Dim resposta As Integer = MsgBox("O Número de Segurança Social não está preenchido, não será possível imprimir recibos sem este dado!", MsgBoxStyle.YesNo, "Quer continuar?")
            '    If resposta = vbNo Then Return False
            'End If

            'If mtbNIF.Text.Trim = "" Then
            '    Dim resposta As Integer = MsgBox("O Número de Contribuinte não está preenchido, não será possível imprimir recibos sem este dado!", MsgBoxStyle.YesNo, "Quer continuar?")
            '    If resposta = vbNo Then Return False
            'End If
            'If mtbNIF.Text.Trim <> "" AndAlso Not modCálculos.funValidarNIF(mtbNIF.Text.Trim.Replace(" ", "")) Then
            '    MsgBox("Número de Contribuinte errado ou inválido!")
            '    Return False
            'End If

            'If mtbNIB.Text.Trim = "" Then
            '    Dim resposta As Integer = MsgBox("O NIB não está preenchido, não será possível imprimir recibos sem este dado!", MsgBoxStyle.YesNo, "Quer continuar?")
            '    If resposta = vbNo Then Return False
            'End If
            'If mtbNIB.Text.Trim <> "" AndAlso Not modCálculos.funValidarNIB(mtbNIB.Text.Trim.Replace(" ", "")) Then
            '    MsgBox("NIB errado ou inválido!")
            '    Return False
            'End If
            'If dtpAdmitidoEm.Value > dtpRescindiuEm.Value Then
            '    MsgBox("Data de Admissão posterior à Data de Rescisão!")
            '    Return False
            'End If
            Return True
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Function

    Private Sub dbGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbGrid.Click
        If dbGrid.Rows.Count > 0 Then
            Funcoes.PreencheLabel(LblAsset, dbGrid.CurrentRow.Cells(0).Value.ToString)
        Else
            LblAsset.Text = ""
        End If
    End Sub

 
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        ApagarUtilizador()
    End Sub

    Private Sub apagarUtilizador()
        Try

            Dim Apaga As Boolean = False
            If txtCodUser.Text <> "" Then ' se existe um codigo

                Dim strAlocacoesSQL As String = "Select  ID from alocacoes where [User]= " & txtCodUser.Text
                Dim ConnIDAlocacao As New SqlConnection(Settings.strSQLConnection)
                Dim CommAlocacao As New SqlCommand(strAlocacoesSQL, ConnIDAlocacao)

                ConnIDAlocacao.Open()
                Dim readerAlocacao As SqlDataReader = CommAlocacao.ExecuteReader()
                If readerAlocacao.HasRows Then
                    MsgBox("Existem alocacoes")
                Else
                    Apaga = True
                End If
                readerAlocacao.Close()
                readerAlocacao = Nothing
                ConnIDAlocacao.Close()


                strAlocacoesSQL = Nothing
                ConnIDAlocacao = Nothing
                CommAlocacao = Nothing
            End If

            If Apaga = True Then
                Dim StrApagaUser As String = "Delete from Utilizadores where ID= " & txtCodUser.Text
                Dim ConnApagaUser As New SqlConnection(Settings.strSQLConnection)
                Dim CommApagaUser As New SqlCommand(StrApagaUser, ConnApagaUser)
                ConnApagaUser.Open()
                Dim y As Integer
                y = CommApagaUser.ExecuteNonQuery()

                ConnApagaUser.Close()
                ConnApagaUser = Nothing
                CommApagaUser = Nothing
                StrApagaUser = Nothing
                y = Nothing
                MsgBox("Item Eliminado")
                subRebuildArvore()
                subLimpaValores()
            End If



        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub
End Class