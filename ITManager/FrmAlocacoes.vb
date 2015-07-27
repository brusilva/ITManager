Imports System.Data.SqlClient
Public Class FrmAlocacoes

    Private Sub BtnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovo.Click
        dbGrid.Enabled = True
        dbGrid.Visible = True
        LerAssets()
        TxtMotivo.Text = ""
        TxtMotivo.Visible = True
        DTPAlocacao.Visible = True
        btnadiciona.Visible = True
    End Sub

    
    Private Sub LerAssets()

        Dim strsql_Asset As String = "SELECT Asset.ID, AssetType.Tipo as Tipo, Asset.Modelo as Modelo, Asset.SN as SN, Asset.[Comentário]"
        strsql_Asset += " FROM AssetType INNER JOIN Asset ON AssetType.ID=Asset.Tipo"
        strsql_Asset += " WHERE not exists (select * from alocacoes where alocacoes.asset=asset.id) ORDER BY asset.id ASC"
        Funcoes.TrataGrelha(dbGrid, strsql_Asset, 0)

    End Sub



    Private Sub FrmAlocacoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LerUtilizadores()
    End Sub

    Private Sub LerUtilizadores()
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
                    nodeuser.Tag = rowuser("ID").ToString.Trim
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

    Private Sub tvwUsers_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwUsers.AfterSelect
        If tvwUsers.SelectedNode.Level <> 0 Then
            lerdados()
            dbGrid.Visible = False
            DTPAlocacao.Visible = False
            TxtMotivo.Visible = False
        End If

    End Sub
    Private Sub lerdados()
        Try
            Dim strsql_user As String = "select Alocacoes.ID as 'ID', Alocacoes.Data as 'Data Alocacao', Assettype.Tipo as Tipo, Alocacoes.Motivo as 'Motivo',"
            strsql_user += " Asset.Marca as Marca, asset.Modelo as Modelo,  asset.SN as SN, asset.DataAquisicao as 'Data Aquisição'"
            strsql_user += " from Alocacoes"
            strsql_user += "  inner join Asset on Alocacoes.Asset = Asset.ID"
            strsql_user += "  inner join Assettype on Asset.Tipo = Assettype.ID"
            strsql_user += " where Alocacoes.[User] = " & tvwUsers.SelectedNode.Tag
            TrataGrelha(dbgridalocacao, strsql_user, 0)
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
        dbGrid.Enabled = False

        dbGrid.DataSource = ""

    End Sub
  
    Private Sub btnremover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremover.Click
        '    MsgBox("deve remover a alocacao")
        If MsgBox("Tem a certeza que deseja remover esta alocação", vbYesNo, "IT Manager") = vbYes Then
            Try
                Dim sql_elimina As String = "DELETE FROM ALOCACOES WHERE ALOCACOES.ID = '" & dbgridalocacao.CurrentRow.Cells(0).Value.ToString & "'"
                Dim sqlconnAlocacao As New SqlConnection(Settings.strSQLConnection)
                Dim execalocacao As New SqlCommand(sql_elimina, sqlconnAlocacao)
                sqlconnAlocacao.Open()

                Dim x As Integer = execalocacao.ExecuteNonQuery
                sqlconnAlocacao.Close()
                sqlconnAlocacao = Nothing
                execalocacao = Nothing
                sql_elimina = Nothing

                LerUtilizadores()
                dbgridalocacao.DataSource = ""

            Catch ex As Exception
                Eventos.subErro(ex)
            End Try
        End If
    End Sub


    Private Sub btnadiciona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadiciona.Click

        GravaAlocacao()
        TxtMotivo.Visible = False
        DTPAlocacao.Visible = False
    End Sub

    Private Sub GravaAlocacao()

        Try

            Dim sql_Insere As String = "INSERT INTO Alocacoes VALUES ("

            sql_Insere += "1, " 'activo                                                           OK
            sql_Insere += "'" & dbGrid.CurrentRow.Cells(0).Value.ToString & "', " ' asset id       OK
            sql_Insere += "'" & tvwUsers.SelectedNode.Tag & "', " ' ID USer                       OK
            sql_Insere += "'" & DTPAlocacao.Value.ToString("yyyyMMdd") & "', " 'DATA DA ALOCACAO OK

            If TxtMotivo.Text = "" Then
                sql_Insere += "'-'" & TxtMotivo.Text  ' Motivo
            Else
                sql_Insere += "'" & TxtMotivo.Text & "'" ' Motivo
            End If

            sql_Insere += ")"



            Dim sqlconnAlocacao As New SqlConnection(Settings.strSQLConnection)
            Dim execalocacao As New SqlCommand(sql_Insere, sqlconnAlocacao)
            sqlconnAlocacao.Open()

            Dim x As Integer = execalocacao.ExecuteNonQuery
            sqlconnAlocacao.Close()
            sqlconnAlocacao = Nothing
            execalocacao = Nothing
            sql_Insere = Nothing


            MsgBox("Gravado", vbOKOnly & vbInformation, "IT Manager")
            LerUtilizadores()
            dbGrid.Visible = False


            dbgridalocacao.DataSource = ""


        Catch ex As Exception
            Eventos.subErro(ex)
        End Try




    End Sub


End Class