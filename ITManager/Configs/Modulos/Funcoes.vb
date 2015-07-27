Imports System.Data.SqlClient

Module Funcoes
    Public Function TrataGrelha(ByRef Grelha As Object, ByVal Sql As String, ByVal CodID As String)
        If CodID <> "" Then
            Try
                Dim sqlconnGrelha As New SqlConnection(Settings.strSQLConnection)
                sqlconnGrelha.Open()

                Dim dataAdapter = New SqlDataAdapter(Sql, sqlconnGrelha)
                Dim commandGrelha As New SqlCommandBuilder(dataAdapter)
                Dim table As New DataTable()
                dataAdapter.Fill(table)
                Grelha.DataSource = table

                ' Fecha a ligação e limpa as variáveis
                sqlconnGrelha.Close()
                sqlconnGrelha = Nothing
                commandGrelha = Nothing
                Sql = Nothing
            Catch ex As Exception
                Eventos.subErro(ex)
            End Try
            Return Grelha
        Else
            Return Grelha
        End If
    End Function

    Public Function PreencheLabel(ByRef LblAsset As Object, ByVal CodID As String)

        Try
            Dim StrAssetSql As String = "Select * From Asset Where ID='" & CodID & "'"
            Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
            Dim commandAsset As New SqlCommand(StrAssetSql, sqlConn)
            sqlConn.Open()

            ' Executa o comando colocando num SqlDataReader os resultados
            Dim readerAsset As SqlDataReader = commandAsset.ExecuteReader()
            ' Caso existam rows (linhas)

            If readerAsset.HasRows Then
                While readerAsset.Read()
                    LblAsset.Text = ""
                    LblAsset.Text += "Descrição do Item: " & Chr(10)
                    LblAsset.Text += "ID : " & readerAsset.Item("ID").ToString.Trim() & Chr(10)
                    LblAsset.Text += "Tipo : " & readerAsset.Item("Tipo").ToString.Trim() & Chr(10)
                    LblAsset.Text += "Contrato : " & readerAsset.Item("Contrato").ToString.Trim() & Chr(10)
                    LblAsset.Text += "Marca : " & readerAsset.Item("Marca").ToString.Trim() & Chr(10)
                    LblAsset.Text += "Comentário : " & readerAsset.Item("Comentário").ToString.Trim() & Chr(10)
                    LblAsset.Text += "Modelo : " & readerAsset.Item("Modelo").ToString.Trim() & Chr(10)
                    LblAsset.Text += "SN : " & readerAsset.Item("SN").ToString.Trim() & Chr(10)
                    LblAsset.Text += "Data Aquisição : " & readerAsset.Item("DataAquisicao").ToString.Trim() & Chr(10)
                    LblAsset.Text += "Valor : " & readerAsset.Item("Valor").ToString.Trim() & Chr(10)
                End While

            End If
            ' Fecha a ligação e limpa as variáveis
            sqlConn.Close()
            sqlConn = Nothing
            commandAsset = Nothing
            readerAsset.Close()
            readerAsset = Nothing
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
        Return LblAsset
    End Function

    Public Function GravaAsset(ByVal Codigo As String, ByVal Tipo As String, ByVal Contrato As Integer, ByVal marca As String, ByVal comentário As String, ByVal modelo As String, ByVal sn As String, ByVal DataAquisicao As Date, ByVal valor As String)
        Try
            Dim x As Integer

            ' Contamos o nº de assets
            Dim intCodAsset As Integer = 0

            If Codigo = "" Then
                Dim strIDAssetSQL As String = "SELECT MAX(ID) as ID FROM Asset"
                Dim sqlConnIDAsset As New SqlConnection(Settings.strSQLConnection)
                Dim commandAsset As New SqlCommand(strIDAssetSQL, sqlConnIDAsset)
                sqlConnIDAsset.Open()

                Dim reader As SqlDataReader = commandAsset.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        intCodAsset += reader.Item("ID").ToString
                    End While
                End If
                intCodAsset += 1
                Codigo = intCodAsset.ToString
                ' Fecha a ligação e limpa as variáveis
                sqlConnIDAsset.Close()
                strIDAssetSQL = Nothing
                sqlConnIDAsset = Nothing
                commandAsset = Nothing
                reader = Nothing
            Else
                intCodAsset = Int(Codigo)
            End If

            Dim strAssetSQL As String = "IF EXISTS "
            strAssetSQL += " (SELECT ID FROM Asset WHERE "
            strAssetSQL += " ID ='" & StrConv(Codigo, VbStrConv.ProperCase) & "' "
            strAssetSQL += ") "

            strAssetSQL += " UPDATE Asset SET "
            strAssetSQL += " TIPO = '" & RTrim(Tipo) & "', "
            strAssetSQL += " Contrato= '" & RTrim(Contrato) & "', "
            strAssetSQL += " Marca = '" & RTrim(marca) & "', "
            strAssetSQL += " Comentário = '" & RTrim(comentário) & "', "
            strAssetSQL += " Modelo = '" & RTrim(modelo) & "', "
            strAssetSQL += " SN = '" & RTrim(sn) & "', "
            strAssetSQL += " DataAquisicao = '" & DataAquisicao.ToString("yyyyMMdd") & "', "
            strAssetSQL += " Valor = '" & RTrim(valor) & "'  "
            strAssetSQL += " WHERE ID ='" & Codigo & "' "


            strAssetSQL += " ELSE "
            strAssetSQL += " INSERT INTO Asset VALUES ("
            strAssetSQL += "'" & intCodAsset & "', "

            strAssetSQL += "'" & Tipo & "', "
            strAssetSQL += "'" & Contrato & "', "
            strAssetSQL += "'" & marca & "', "
            strAssetSQL += "'" & comentário & "', "
            strAssetSQL += "'" & modelo & "', "
            strAssetSQL += "'" & sn & "', "
            strAssetSQL += "'" & DataAquisicao.ToString("yyyyMMdd") & "', "
            strAssetSQL += "'" & valor & "' "
            strAssetSQL += ")"

            Dim sqlConnAsset As New SqlConnection(Settings.strSQLConnection)
            Dim execAsset As New SqlCommand(strAssetSQL, sqlConnAsset)
            sqlConnAsset.Open()
            x = execAsset.ExecuteNonQuery
            sqlConnAsset.Close()
            sqlConnAsset = Nothing
            execAsset = Nothing
            strAssetSQL = Nothing

            MsgBox("Gravado", vbOKOnly & vbInformation, "IT Manager")

            Return True

        Catch ex As Exception
            Eventos.subErro(ex)
            Return False
        End Try


    End Function

    Public Sub LerDadosAsset(ByVal Codigo As String, ByRef TxtCodigo As Object, ByRef Tipo As Object, ByRef Contrato As Object, ByRef Marca As Object, ByRef Comentario As Object, ByRef Modelo As Object, ByRef SN As Object, ByRef DTPAquisicao As Object, ByRef Valor As Object)
        Try
            Dim strsql As String = "SELECT * FROM Asset WHERE ID='" & Codigo & "'"

            Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
            Dim commandAsset As New SqlCommand(strsql, sqlConn)
            sqlConn.Open()

            ' Executa o comando colocando num SqlDataReader os resultados
            Dim reader As SqlDataReader = commandAsset.ExecuteReader()
            If reader.HasRows Then
                ' Executa um ciclo nas linhas existentes mostrando o campo “username”
                While reader.Read()
                    TxtCodigo.text = reader.Item("ID").ToString.Trim()
                    Tipo.Text = reader.Item("Tipo").ToString.Trim()
                    Contrato.Text = reader.Item("Contrato").ToString.Trim()
                    Marca.Text = reader.Item("Marca").ToString.Trim()
                    Comentario.Text = reader.Item("Comentário").ToString.Trim()
                    Modelo.Text = reader.Item("Modelo").ToString.Trim()
                    SN.Text = reader.Item("SN").ToString.Trim()
                    DTPAquisicao.Value = reader.Item("DataAquisicao")
                    Valor.Text = reader.Item("Valor").ToString.Trim()


                End While
            Else
                ' subLimpaValores()
            End If

            


            ' Fecha a ligação e limpa as variáveis
            strsql = Nothing
            sqlConn.Close()
            sqlConn = Nothing
            commandAsset = Nothing
            reader.Close()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub
    Public Sub ListaAssets(ByRef Lista As Object, ByVal TipoOrd As String, ByVal Estado As Integer, ByVal Filtro As String)
        Try
            Lista.Nodes.Clear()

            Dim strsql_Tipos As String = "Select * From AssetType"
            Dim dset_Tipos As New DataSet
            Dim sql_Tipos As New SqlConnection(Settings.strSQLConnection)
            Dim da_Tipos As New SqlDataAdapter(strsql_Tipos, Settings.strSQLConnection)
            sql_Tipos.Open()
            da_Tipos.Fill(dset_Tipos, "Tipo")
            sql_Tipos.Close()
            For Each rowempresas As DataRow In dset_Tipos.Tables("Tipo").Rows

                Dim str_final
                str_final = "select * from asset "
                Select Case Estado
                    Case 1
                        str_final += " where asset.id <> 0 " & " AND Tipo = " & rowempresas("ID").ToString.Trim
                        str_final += Filtro
                    Case 2
                        str_final += " inner join Alocacoes on alocacoes.Asset = asset.ID  "
                        str_final += " Where  Tipo = " & rowempresas("ID").ToString.Trim
                        str_final += Filtro
                    Case 3
                        str_final += " where not exists (select * from alocacoes where alocacoes.asset=asset.id) "
                        str_final += " AND Tipo = " & rowempresas("ID").ToString.Trim
                        str_final += Filtro
                End Select
                'CONSTROI SQL'

                str_final += TipoOrd

                Dim dset As New DataSet
                Dim sql_connection As New SqlConnection(Settings.strSQLConnection)
                Dim daset As New SqlDataAdapter(str_final, Settings.strSQLConnection)

                sql_connection.Open()
                daset.Fill(dset, "Nome")

                sql_connection.Close()
                Dim noderoot As TreeNode
                noderoot = New TreeNode
                noderoot.Text = rowempresas("ID").ToString.Trim & " - " & rowempresas("Tipo").ToString.Trim
                noderoot.Tag = rowempresas("Tipo").ToString.Trim

                Lista.Nodes.Add(noderoot)
                For Each rowuser As DataRow In dset.Tables("Nome").Rows
                    Dim nodeuser As TreeNode
                    nodeuser = New TreeNode
                    nodeuser.Text = rowuser("ID").ToString.Trim & " - " & rowuser("Marca").ToString.Trim & " " & rowuser("Modelo").ToString.Trim
                    nodeuser.Tag = rowuser("ID").ToString.Trim
                    noderoot.Nodes.Add(nodeuser)
                Next
            Next
            Lista.EndUpdate()
        Catch ex As Exception
            Eventos.subErro(ex)
        Finally
            Lista.ExpandAll()
            Lista.CollapseAll()
        End Try
        ' str_final = ""
        Estado = Nothing
        TipoOrd = ""
    End Sub

    Public Sub EliminarRegisto(ByVal tabela As String, ByVal codigo As String)
        Dim Apaga As Boolean = False
        Try

            Select Case tabela
                Case "asset"
                    Dim strVerifica As String = "Select ID from alocacoes where asset= " & codigo
                    Dim ConnVerifica As New SqlConnection(strSQLConnection)
                    Dim CommandVerifica As New SqlCommand(strVerifica, ConnVerifica)
                    ConnVerifica.Open()
                    Dim ReaderVerifica As SqlDataReader = CommandVerifica.ExecuteReader
                    If ReaderVerifica.HasRows Then
                        MsgBox("Existem Alocacoes")
                        Apaga = False
                    Else
                        Apaga = True
                    End If
                    ' apagamos as variaveis
                    strVerifica = Nothing
                    ConnVerifica.Close()
                    ConnVerifica = Nothing
                    CommandVerifica = Nothing
                    ReaderVerifica.Close()
                    ReaderVerifica = Nothing
                Case "Utilizadores"
                    Dim strVerifica As String = "Select ID from alocacoes where [user]= " & codigo
                    Dim ConnVerifica As New SqlConnection(strSQLConnection)
                    Dim CommandVerifica As New SqlCommand(strVerifica, ConnVerifica)
                    ConnVerifica.Open()
                    Dim ReaderVerifica As SqlDataReader = CommandVerifica.ExecuteReader
                    If ReaderVerifica.HasRows Then
                        MsgBox("Existem Alocacoes")
                        Apaga = False
                    Else
                        Apaga = True
                    End If
                    ' apagamos as variaveis
                    strVerifica = Nothing
                    ConnVerifica.Close()
                    ConnVerifica = Nothing
                    CommandVerifica = Nothing
                    ReaderVerifica.Close()
                    ReaderVerifica = Nothing
                Case "Contratos"
                    Dim strVerifica As String = "Select asset.ID from asset inner join contratos on contratos.id = asset.contrato where asset.contrato= " & codigo
                    Dim ConnVerifica As New SqlConnection(strSQLConnection)
                    Dim CommandVerifica As New SqlCommand(strVerifica, ConnVerifica)
                    ConnVerifica.Open()
                    Dim ReaderVerifica As SqlDataReader = CommandVerifica.ExecuteReader
                    If ReaderVerifica.HasRows Then
                        MsgBox("Existem Assets associado a este contrato")
                        Apaga = False
                    Else
                        Apaga = True
                    End If
                    ' apagamos as variaveis
                    strVerifica = Nothing
                    ConnVerifica.Close()
                    ConnVerifica = Nothing
                    CommandVerifica = Nothing
                    ReaderVerifica.Close()
                    ReaderVerifica = Nothing
                Case "assettype"
                    Dim strVerifica As String = "Select asset.ID from asset inner join assettype on asset.tipo = assettype.id where asset.tipo= " & codigo
                    Dim ConnVerifica As New SqlConnection(strSQLConnection)
                    Dim CommandVerifica As New SqlCommand(strVerifica, ConnVerifica)
                    ConnVerifica.Open()
                    Dim ReaderVerifica As SqlDataReader = CommandVerifica.ExecuteReader
                    If ReaderVerifica.HasRows Then
                        MsgBox("Existem Assets associado a este Tipo")
                        Apaga = False
                    Else
                        Apaga = True
                    End If
                    ' apagamos as variaveis
                    strVerifica = Nothing
                    ConnVerifica.Close()
                    ConnVerifica = Nothing
                    CommandVerifica = Nothing
                    ReaderVerifica.Close()
                    ReaderVerifica = Nothing
                Case "Empresa"
                    Dim strVerifica As String = "Select Empresa.ID from Empresa inner join utilizadores on utilizadores.empresa = empresa.id where empresa.id= " & codigo
                    Dim ConnVerifica As New SqlConnection(strSQLConnection)
                    Dim CommandVerifica As New SqlCommand(strVerifica, ConnVerifica)
                    ConnVerifica.Open()
                    Dim ReaderVerifica As SqlDataReader = CommandVerifica.ExecuteReader
                    If ReaderVerifica.HasRows Then
                        MsgBox("Existem Utilizadores associados a esta Empresa")
                        Apaga = False
                    Else
                        Apaga = True
                    End If
                    ' apagamos as variaveis
                    strVerifica = Nothing
                    ConnVerifica.Close()
                    ConnVerifica = Nothing
                    CommandVerifica = Nothing
                    ReaderVerifica.Close()
                    ReaderVerifica = Nothing
                Case "Alocacoes"
                    Apaga = True
            End Select

            If Apaga = True Then
                Dim StrApaga As String = "Delete from " & tabela & " where ID= " & codigo
                Dim ConnApaga As New SqlConnection(Settings.strSQLConnection)
                Dim CommApaga As New SqlCommand(StrApaga, ConnApaga)
                ConnApaga.Open()
                Dim y As Integer
                y = CommApaga.ExecuteNonQuery()

                ConnApaga.Close()
                ConnApaga = Nothing
                CommApaga = Nothing
                StrApaga = Nothing
                y = Nothing
                MsgBox("Item Eliminado")
            End If

        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Public Function GetID(ByVal tabela As String, ByVal procura As String, ByVal campo As String)
        If procura <> "" Then


            Dim id As String
            Dim str As String = "select ID from " & tabela & " where " & campo & " like '%" & procura & "%'"
            Dim dset As New DataSet
            Dim sqlconn As New SqlConnection(Settings.strSQLConnection)
            Dim da As New SqlDataAdapter(str, Settings.strSQLConnection)
            sqlconn.Open()
            da.Fill(dset, "ID")
            sqlconn.Close()
            For Each row As DataRow In dset.Tables("ID").Rows
                id = row("ID").ToString.Trim()
            Next
            Return (id)
        End If


    End Function

    
    Public Sub TrataCombo(ByRef combo As Object, ByVal tabela As String, ByVal X As String, ByVal ID As String)
        'COMBO TIPO 
        Dim conn As New SqlConnection(Settings.strSQLConnection)
        Dim strsql As String = ""
        If ID = "" Or ID = "0" Then
            strsql = "SELECT * FROM " & tabela
        Else
            strsql = ("SELECT * FROM " & tabela & " Where ID=" & ID)
        End If


        Dim da As New SqlDataAdapter(strsql, conn)
        Dim ds As New DataSet
        da.Fill(ds, tabela)

        With combo
            .DataSource = ds.Tables(tabela)


            .DisplayMember = X
            .ValueMember = ("ID")

            .SelectedIndex = 0
        End With
        ds = Nothing
        conn.Close()
        conn = Nothing
        da = Nothing
        strsql = Nothing



    End Sub
End Module
