Imports System.Data.SqlClient
Public Class FrmTipoAsset

    Private Sub FrmTipoAsset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCod.ReadOnly = True
            subRebuildArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub LstTipos_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles LstTipos.AfterSelect
        Try
            For Each node As TreeNode In LstTipos.Nodes(0).Nodes
                node.BackColor = Color.White
            Next
            If LstTipos.SelectedNode.Tag <> "Empresa" Then
                lertipos()
                LstTipos.SelectedNode.BackColor = Color.Beige
            Else
                LimparValores()
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            LimparValores()
            subRebuildArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    Private Sub LimparValores()
        ' Rotina que limpa todos os dados das textboxs e passa as datas para hoje.
        txtCod.Clear()
        txtNome.Clear()
    End Sub

    Private Sub subRebuildArvore()
        Try
            LstTipos.Nodes.Clear()
            Dim strsql_tipos As String = "Select * From AssetType"
            Dim dsettipos As New DataSet
            Dim sql_tipos As New SqlConnection(Settings.strSQLConnection)
            Dim da_tipos As New SqlDataAdapter(strsql_tipos, Settings.strSQLConnection)

            sql_tipos.Open()
            da_tipos.Fill(dsettipos, "Tipo")
            sql_tipos.Close()

            For Each rowempresas As DataRow In dsettipos.Tables("Tipo").Rows

                Dim noderoot As TreeNode
                noderoot = New TreeNode
                noderoot.Text = rowempresas("Tipo").ToString.Trim
                noderoot.Tag = rowempresas("ID").ToString.Trim
                LstTipos.Nodes.Add(noderoot)
            Next

            LstTipos.EndUpdate()
        Catch ex As Exception
            Eventos.subErro(ex)

        Finally
            LstTipos.ExpandAll()

        End Try
    End Sub

    Private Function TestaValores()
        Return True
    End Function

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Try
            If TestaValores() Then
                Dim x As Integer

                ' Contamos o nº de Empresas
                Dim IntCodTipo As Integer = 0

                If txtCod.Text = "" Then
                    Dim strIDTipoSQL As String = "SELECT MAX(ID) FROM Assettype"
                    Dim sqlConnIDTipo As New SqlConnection(Settings.strSQLConnection)
                    Dim commandTipo As New SqlCommand(strIDTipoSQL, sqlConnIDTipo)
                    sqlConnIDTipo.Open()

                    Dim readerTipo As SqlDataReader = commandTipo.ExecuteReader()
                    If readerTipo.HasRows Then
                        While readerTipo.Read()
                            IntCodTipo += readerTipo.Item("ID").ToString
                        End While
                    End If
                    IntCodTipo += 1
                    txtCod.Text = IntCodTipo.ToString
                    ' Fecha a ligação e limpa as variáveis
                    sqlConnIDTipo.Close()
                    sqlConnIDTipo = Nothing
                    commandTipo = Nothing
                Else
                    IntCodTipo = Int(txtCod.Text)
                End If


                Dim strTipoSQL As String = "IF EXISTS "
                strTipoSQL += " (SELECT ID FROM Assettype WHERE "
                strTipoSQL += " ID ='" & txtCod.Text.Trim & "' "
                strTipoSQL += ") "
                strTipoSQL += " UPDATE Assettype SET "
                strTipoSQL += " Tipo ='" & txtNome.Text.Trim & "' "
                strTipoSQL += " WHERE ID ='" & txtCod.Text.Trim & "' "
                strTipoSQL += " ELSE "
                strTipoSQL += " INSERT INTO Assettype VALUES ("
                strTipoSQL += "'" & IntCodTipo & "', "
                strTipoSQL += "'" & txtNome.Text.Trim & "' "
                strTipoSQL += ")"

                Dim sqlConnTipo As New SqlConnection(Settings.strSQLConnection)
                Dim execTipo As New SqlCommand(strTipoSQL, sqlConnTipo)
                sqlConnTipo.Open()
                x = execTipo.ExecuteNonQuery
                sqlConnTipo.Close()
                sqlConnTipo = Nothing
                execTipo = Nothing
                strTipoSQL = Nothing


                txtCod.Text = IntCodTipo.ToString
                MsgBox("Gravado", vbOKOnly & vbInformation, "IT Manager")
                subRebuildArvore()
            End If
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub


    Private Sub lertipos()
        Try
            Dim strSQL As String = "SELECT * FROM Assettype WHERE ID='" & LstTipos.SelectedNode.Tag & "'"

            Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
            Dim commandtipo As New SqlCommand(strSQL, sqlConn)
            sqlConn.Open()
            Dim readerTipo As SqlDataReader = commandtipo.ExecuteReader()
            If readerTipo.HasRows Then

                While readerTipo.Read()

                    txtCod.Text = readerTipo.Item("ID").ToString.Trim
                    txtNome.Text = readerTipo.Item("Tipo").ToString.Trim
                End While
            Else
                LimparValores()
            End If

            Dim Sql As String = "Select ID, Nome as Nome, Contacto as Contacto From Utilizadores Where Empresa='" & txtCod.Text.Trim & "'"
            Funcoes.TrataGrelha(dbGrid, Sql, txtCod.Text)
            ' Fecha a ligação e limpa as variáveis
            sqlConn.Close()
            sqlConn = Nothing
            commandtipo = Nothing
            readerTipo.Close()
            strSQL = Nothing
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try



        Try
            Dim strsql As String = "select ID, Contrato, marca as Marca, Modelo as Modelo, SN, DataAquisicao as 'Data Aquisição', Valor from asset where tipo='" & LstTipos.SelectedNode.Tag & "'"

            Funcoes.TrataGrelha(dbGrid, strsql, 1)
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub



End Class