Imports System.Data.SqlClient
Public Class FrmEmpresa

    Private Sub FrmEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCod.ReadOnly = True
            subRebuildArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub
    Private Sub tvwUsers_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles lstempresa.AfterSelect
        Try
            For Each node As TreeNode In lstempresa.Nodes(0).Nodes
                node.BackColor = Color.White
            Next
            If lstempresa.SelectedNode.Tag <> "Empresa" Then
                SubLerEmpresa()
                lstempresa.SelectedNode.BackColor = Color.Beige
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

    Private Sub dbGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbGrid.Click
        If dbGrid.Rows.Count > 0 Then
            ' Funcoes.PreencheLabel(LblAsset, dbGrid.CurrentRow.Cells(0).Value.ToString)
            Dim sql As String = "select [Alocacoes].[User] as Utilizador , [AssetType].Tipo as Tipo , [Asset].Marca as Marca , asset.modelo as Modelo, asset.SN as SN "
            sql += " from Alocacoes inner join Utilizadores on [Alocacoes].[User] = Utilizadores.ID "
            sql += "inner join Asset on [Alocacoes].[Asset] = [Asset].[ID]"
            sql += "inner join AssetType on asset.Tipo = assettype.ID "
            sql += "inner join Empresa on Utilizadores.Empresa = Empresa.ID "
            sql += "where Utilizadores.ID = '" & dbGrid.CurrentRow.Cells(0).Value.ToString & "'"
            Funcoes.TrataGrelha(dbgrid2, sql, txtCod.Text)
            sql = Nothing
        Else
            If dbgrid2.Rows.Count <> 0 Then
                dbgrid2.DataSource = ""
            End If


        End If
    End Sub

    Private Sub subLimpaValores()
        ' Rotina que limpa todos os dados das textboxs e passa as datas para hoje.
        txtCod.Clear()
        txtNome.Clear()
        LblAsset.Text = ""
    End Sub
    Private Function funtestavalores()
        Return True
    End Function

    Private Sub subRebuildArvore()
        Try
            lstempresa.Nodes.Clear()
            Dim strsql_empresas As String = "Select * From Empresa"
            Dim dsetempresas As New DataSet
            Dim sql_empresas As New SqlConnection(Settings.strSQLConnection)
            Dim da_empresas As New SqlDataAdapter(strsql_empresas, Settings.strSQLConnection)

            sql_empresas.Open()
            da_empresas.Fill(dsetempresas, "Nome")
            sql_empresas.Close()

            For Each rowempresas As DataRow In dsetempresas.Tables("Nome").Rows

                Dim noderoot As TreeNode
                noderoot = New TreeNode
                noderoot.Text = rowempresas("Nome").ToString.Trim
                noderoot.Tag = rowempresas("ID").ToString.Trim
                lstempresa.Nodes.Add(noderoot)
            Next

            lstempresa.EndUpdate()
        Catch ex As Exception
            Eventos.subErro(ex)

        Finally
            lstempresa.ExpandAll()

        End Try
    End Sub

    ''' <summary>
    ''' AKI AINDA NAO TA
    ''' </summary>
    ''' <remarks></remarks>



    Private Sub SubLerEmpresa()
        LblAsset.Text = ""
        Try
            Dim strUserSQL As String = "SELECT * FROM Empresa WHERE ID='" & lstempresa.SelectedNode.Tag & "'"

            Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
            Dim commandEmpresa As New SqlCommand(strUserSQL, sqlConn)
            sqlConn.Open()

            ' Executa o comando colocando num SqlDataReader os resultados
            Dim readerEmpresa As SqlDataReader = commandEmpresa.ExecuteReader()
            ' Caso existam rows (linhas)

            If readerEmpresa.HasRows Then
                ' Executa um ciclo nas linhas existentes mostrando o campo “Nome”
                While readerEmpresa.Read()
    
                    txtCod.Text = readerEmpresa.Item("ID").ToString.Trim
                    txtNome.Text = readerEmpresa.Item("Nome").ToString.Trim
                End While
            Else
                subLimpaValores()
            End If

            Dim Sql As String = "Select ID, Nome as Nome, Contacto as Contacto From Utilizadores Where Empresa='" & txtCod.Text.Trim & "'"
            'Dim sql As String = "select  Rtrim(asset.id) as ID, RTrim(assettype.Tipo) as Tipo, RTrim(asset.Marca) as Marca ,  RTrim(asset.Modelo) as Modelo, alocacoes.Data , alocacoes.Motivo from  Alocacoes inner join Asset on Asset.ID = Alocacoes.Asset inner join AssetType on asset.Tipo = assettype.ID where [Alocacoes].[User] = " & txtCodUser.Text '& "'"
            Funcoes.TrataGrelha(dbGrid, Sql, txtCod.Text)
            dbGrid_Click(Nothing, Nothing)

            ' Fecha a ligação e limpa as variáveis
            sqlConn.Close()
            sqlConn = Nothing
            commandEmpresa = Nothing
            readerEmpresa.Close()

        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub ' necessario fazer a grelha
    
    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Try
            If funTestaValores() Then
                Dim x As Integer

                ' Contamos o nº de Empresas
                Dim IntCodEmpresa As Integer = 0

                If txtCod.Text = "" Then
                    Dim strIDEmpresaSQL As String = "SELECT ID FROM Empresa"
                    Dim sqlConnIDEmpresa As New SqlConnection(Settings.strSQLConnection)
                    Dim commandEmpresa As New SqlCommand(strIDEmpresaSQL, sqlConnIDEmpresa)
                    sqlConnIDEmpresa.Open()

                    Dim readerEmpresa As SqlDataReader = commandEmpresa.ExecuteReader()
                    If readerEmpresa.HasRows Then
                        While readerEmpresa.Read()
                            IntCodEmpresa += 1
                        End While
                    End If
                    IntCodEmpresa += 1
                    txtCod.Text = IntCodEmpresa.ToString
                    ' Fecha a ligação e limpa as variáveis
                    sqlConnIDEmpresa.Close()
                    sqlConnIDEmpresa = Nothing
                    commandEmpresa = Nothing
                Else
                    IntCodEmpresa = Int(txtCod.Text)
                End If


                Dim strEmpresaSQL As String = "IF EXISTS "
                strEmpresaSQL += " (SELECT ID FROM Empresa WHERE "
                strEmpresaSQL += " ID ='" & txtCod.Text.Trim & "' "
                strEmpresaSQL += ") "
                strEmpresaSQL += " UPDATE Empresa SET "
                strEmpresaSQL += " Nome ='" & txtNome.Text.Trim & "' "
                strEmpresaSQL += " WHERE ID ='" & txtCod.Text.Trim & "' "
                strEmpresaSQL += " ELSE "
                strEmpresaSQL += " INSERT INTO Empresa VALUES ("
                strEmpresaSQL += "'" & IntCodEmpresa & "', "
                strEmpresaSQL += "'" & txtNome.Text.Trim & "' "
                strEmpresaSQL += ")"

                Dim sqlConnEmpresa As New SqlConnection(Settings.strSQLConnection)
                Dim execEmpresa As New SqlCommand(strEmpresaSQL, sqlConnEmpresa)
                sqlConnEmpresa.Open()
                x = execEmpresa.ExecuteNonQuery
                sqlConnEmpresa.Close()
                sqlConnEmpresa = Nothing
                execEmpresa = Nothing
                strEmpresaSQL = Nothing


                txtCod.Text = IntCodEmpresa.ToString
                MsgBox("Gravado", vbOKOnly & vbInformation, "IT Manager")
                subRebuildArvore()
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub


End Class