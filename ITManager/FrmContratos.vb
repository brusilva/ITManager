Imports System.Data.SqlClient
Public Class FrmContratos

    Private Sub FrmContratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TxtID.ReadOnly = True
            subRebuildArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub LstContratos_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles LstContratos.AfterSelect
        Try
            For Each node As TreeNode In LstContratos.Nodes(0).Nodes
                node.BackColor = Color.White
            Next
            If LstContratos.SelectedNode.Tag <> "Contratos" Then
                SubLerContratos()
                LstContratos.SelectedNode.BackColor = Color.Beige
            Else
                subLimpaValores()
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            subLimpaValores()
            subRebuildArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub SubLerContratos()
        LblAsset.Text = ""
        Try
            Dim strUserSQL As String = "SELECT * FROM Contratos WHERE ID = '" & LstContratos.SelectedNode.Tag & "'"

            Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
            Dim commandContrato As New SqlCommand(strUserSQL, sqlConn)
            sqlConn.Open()

            ' Executa o comando colocando num SqlDataReader os resultados
            Dim readerContrato As SqlDataReader = commandContrato.ExecuteReader()
            ' Caso existam rows (linhas)

            If readerContrato.HasRows Then
                ' Executa um ciclo nas linhas existentes mostrando o campo “username”
                While readerContrato.Read()
                    TxtID.Text = readerContrato.Item("ID").ToString.Trim
                    TxtNr.Text = readerContrato.Item("NumeroContrato").ToString.Trim
                    TxtDescricao.Text = readerContrato.Item("Descricao").ToString.Trim
                    TxtEntidade.Text = readerContrato.Item("Entidade").ToString.Trim
                    DtpInicio.Value = readerContrato.Item("DataAssinatura")
                    DtpFim.Value = readerContrato.Item("DataFim")
                    TxtValorMensal.Text = readerContrato.Item("ValorMensal").ToString.Trim

                End While
            Else
                subLimpaValores()
            End If

          
            Dim sql As String = "select asset.id as ID, assettype.Tipo as Tipo , "
            sql += "utilizadores.Nome as Atribuição, asset.Marca as Marca , "
            sql += "asset.Modelo as Modelo,  asset.Valor as Valor  "
            Sql += "From contratos inner join Asset on asset.Contrato = Contratos.ID "
            Sql += " inner join AssetType on asset.Tipo = AssetType.ID"
            Sql += " left outer join Alocacoes on Alocacoes.Asset = Asset.ID"
            Sql += " left outer join Utilizadores on Alocacoes.[User] = Utilizadores.ID "

            sql += " where asset.Contrato = " & TxtID.Text

            Funcoes.TrataGrelha(DBGridContratos, sql, TxtID.Text)


            ' Fecha a ligação e limpa as variáveis
            sqlConn.Close()
            sqlConn = Nothing
            commandContrato = Nothing
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub subLimpaValores()
        ' Rotina que limpa todos os dados das textboxs e passa as datas para hoje.
        TxtDescricao.Clear()
        TxtEntidade.Clear()
        TxtID.Clear()
        TxtNr.Clear()
        TxtValorMensal.Clear()
        DtpInicio.Value = Today
        DtpFim.Value = Today
        LblAsset.Text = ""
    End Sub

  

    Private Sub subRebuildArvore()
        Try
            LstContratos.Nodes.Clear()
            Dim strsql_Entidade As String = "Select distinct Cast(Entidade  as NVarchar(Max)) as Entidade from Contratos  ORDER BY Cast(Entidade as NVarchar(Max)) ASC"

            Dim dsetEntidades As New DataSet
            Dim sql_Entidades As New SqlConnection(Settings.strSQLConnection)
            Dim da_Entidades As New SqlDataAdapter(strsql_Entidade, Settings.strSQLConnection)

            sql_Entidades.Open()
            da_Entidades.Fill(dsetEntidades, "Entidade")
            sql_Entidades.Close()

            For Each rowempresas As DataRow In dsetEntidades.Tables("Entidade").Rows

                Dim strSQL As String = "Select * FROM Contratos WHERE Entidade like '" & rowempresas("Entidade").ToString.Trim & "'" '& "' order by NumeroContrato ASC"
                Dim dset As New DataSet
                Dim sql_connection As New SqlConnection(Settings.strSQLConnection)
                Dim daset As New SqlDataAdapter(strSQL, Settings.strSQLConnection)

                sql_connection.Open()
                daset.Fill(dset, "NumeroContrato")

                sql_connection.Close()
                Dim noderoot As TreeNode
                noderoot = New TreeNode
                noderoot.Text = rowempresas("Entidade").ToString.Trim
                noderoot.Tag = rowempresas("Entidade").ToString.Trim

                LstContratos.Nodes.Add(noderoot)
                For Each rowuser As DataRow In dset.Tables("NumeroContrato").Rows
                    Dim nodeuser As TreeNode
                    nodeuser = New TreeNode
                    nodeuser.Text = rowuser("NumeroContrato").ToString.Trim
                    nodeuser.Tag = rowuser("ID").ToString.Trim
                    noderoot.Nodes.Add(nodeuser)

                Next

            Next

            LstContratos.EndUpdate()
        Catch ex As Exception
            Eventos.subErro(ex)

        Finally
            LstContratos.ExpandAll()

        End Try
    End Sub

    Private Sub DBGridContratos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBGridContratos.Click
        If DBGridContratos.Rows.Count > 0 Then
            Funcoes.PreencheLabel(LblAsset, DBGridContratos.CurrentRow.Cells(0).Value.ToString)
        Else
            LblAsset.Text = ""
        End If
    End Sub

    Private Sub BtnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGravar.Click
        Try

            Dim x As Integer

            ' Contamos o nº de funcionários
            Dim IntCodContrato As Integer = 0

            If TxtID.Text = "" Then
                Dim strIDContratoSQL As String = "SELECT MAX(ID) AS ID FROM Contratos"
                Dim sqlConnIDContrato As New SqlConnection(Settings.strSQLConnection)
                Dim commandContrato As New SqlCommand(strIDContratoSQL, sqlConnIDContrato)
                sqlConnIDContrato.Open()

                Dim readerFuncionário As SqlDataReader = commandContrato.ExecuteReader()
                If readerFuncionário.HasRows Then
                    While readerFuncionário.Read()
                        IntCodContrato += readerFuncionário.Item("ID").ToString
                    End While
                End If
                IntCodContrato += 1
                TxtID.Text = IntCodContrato.ToString
                ' Fecha a ligação e limpa as variáveis
                sqlConnIDContrato.Close()
                sqlConnIDContrato = Nothing
                commandContrato = Nothing
            Else
                IntCodContrato = Int(TxtID.Text)
            End If


            Dim strContratosSQL As String = "IF EXISTS "
            strContratosSQL += " (SELECT ID FROM Contratos WHERE "
            strContratosSQL += " ID ='" & StrConv(TxtID.Text.Trim, VbStrConv.ProperCase) & "' "
            strContratosSQL += ") "
            strContratosSQL += " UPDATE Contratos SET "
            strContratosSQL += " NumeroContrato ='" & TxtNr.Text.Trim & "', "
            strContratosSQL += " Descricao ='" & TxtDescricao.Text.Trim & "', "
            strContratosSQL += " Entidade ='" & TxtEntidade.Text.Trim & "', "
            strContratosSQL += " DataAssinatura ='" & DtpInicio.Value.ToString("yyyyMMdd") & "', "

            strContratosSQL += " DataFim ='" & DtpFim.Value.ToString("yyyyMMdd") & "', "
            strContratosSQL += " ValorMensal ='" & TxtValorMensal.Text & "' "

            strContratosSQL += " WHERE ID ='" & TxtID.Text.Trim & "' "
            strContratosSQL += " ELSE "
            strContratosSQL += " INSERT INTO Contratos VALUES ("
            strContratosSQL += "'" & IntCodContrato & "', "
            strContratosSQL += "'" & TxtNr.Text.Trim & "', "
            strContratosSQL += "'" & TxtDescricao.Text.Trim & "', "
            strContratosSQL += "'" & TxtEntidade.Text.Trim & "', "
            strContratosSQL += "'" & DtpInicio.Value.ToString("yyyyMMdd") & "', "
            strContratosSQL += "'" & DtpFim.Value.ToString("yyyyMMdd") & "', "
            strContratosSQL += "'" & TxtValorMensal.Text & "' "
            strContratosSQL += ")"

            Dim sqlConnContrato As New SqlConnection(Settings.strSQLConnection)
            Dim execContrato As New SqlCommand(strContratosSQL, sqlConnContrato)
            sqlConnContrato.Open()
            x = execContrato.ExecuteNonQuery
            sqlConnContrato.Close()
            sqlConnContrato = Nothing
            execContrato = Nothing
            strContratosSQL = Nothing


            TxtNr.Text = IntCodContrato.ToString
            MsgBox("Gravado", vbOKOnly & vbInformation, "IT Manager")
            subRebuildArvore()

        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub


  
    Private Sub BtnApagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApagar.Click
        ApagarContratos()
    End Sub

    Private Sub ApagarContratos()

        Try

            Dim Apaga As Boolean = False
            If TxtID.Text <> "" Then ' se existe um codigo

                Dim strUsersSQL As String = "Select Contrato from Asset where Contrato= " & TxtID.Text
                Dim ConnIDUsers As New SqlConnection(Settings.strSQLConnection)
                Dim CommUsers As New SqlCommand(strUsersSQL, ConnIDUsers)

                ConnIDUsers.Open()
                Dim readerUsers As SqlDataReader = CommUsers.ExecuteReader()
                If readerUsers.HasRows Then
                    MsgBox("Existem alocacoes assets atribuidos a este contrato")
                Else
                    Apaga = True
                End If
                readerUsers.Close()
                readerUsers = Nothing
                ConnIDUsers.Close()


                strUsersSQL = Nothing
                ConnIDUsers = Nothing
                CommUsers = Nothing
            End If

            If Apaga = True Then
                Dim StrApaga As String = "Delete from Contratos where ID= " & TxtID.Text
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
                subRebuildArvore()
                subLimpaValores()
            End If



        Catch ex As Exception
            Eventos.subErro(ex)
        End Try

    End Sub

 
End Class