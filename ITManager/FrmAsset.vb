Imports System.Data.SqlClient

Public Class FrmAsset
    Dim TipoOrd As String
    Dim sql As String
    Dim filtro As String = ""
    Dim estado As Integer = 1

    'controlos
    Private Sub RBID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBID.CheckedChanged
        If RBID.Checked = True Then
            TipoOrd = " ORDER BY asset.ID ASC"
            ConstruirArvore()
        End If
    End Sub
    Private Sub RBMarca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMarca.CheckedChanged
        If RBMarca.Checked = True Then

            TipoOrd = "ORDER BY Cast(Marca as NVarchar(Max)) ASC"
            ConstruirArvore()
        End If

    End Sub
    Private Sub RbModelo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbModelo.CheckedChanged
        If RbModelo.Checked = True Then

            TipoOrd = "ORDER BY Cast(Modelo as NVarchar(Max)) ASC"
            ConstruirArvore()
        End If

    End Sub
    Private Sub RBContrato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBContrato.CheckedChanged
        If RBContrato.Checked = True Then
            TipoOrd = " ORDER BY Contrato ASC"
            ConstruirArvore()
        End If
    End Sub
    Private Sub RbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbTodos.CheckedChanged
        If RbTodos.Checked = True Then
            estado = 1
            ConstruirArvore()
        End If
    End Sub
    Private Sub RbAlocados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAlocados.CheckedChanged
        If RbAlocados.Checked = True Then
            ' estado = " inner join Alocacoes on alocacoes.Asset = asset.ID  "
            estado = 2
            ConstruirArvore()
        End If
    End Sub
    Private Sub RBNaoAlocados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNaoAlocados.CheckedChanged
        If RBNaoAlocados.Checked = True Then
            estado = 3
            ConstruirArvore()
        End If
    End Sub
    Private Sub cbtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtipo.SelectedIndexChanged
        TxtTipoAsset.Text = GetID("assettype", cbtipo.Text, "Tipo")
    End Sub
    Private Sub cbcontrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcontrato.SelectedIndexChanged
        TxtContratoAsset.Text = GetID("Contratos", cbcontrato.Text, "NumeroContrato")
    End Sub
    Private Sub TxtProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = 27 Then
            TxtProcura.Clear()
        End If
    End Sub
    Private Sub LstItems_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles LstItems.AfterSelect
        Try
            SubLerAsset()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub

    ' Subs 
    Private Sub TxtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProcura.TextChanged

        If TxtProcura.Text = vbNullString Then
            filtro = ""
        Else
            filtro = " AND (contrato like '%" & TxtProcura.Text & "%' OR "
            filtro += "Marca like '%" & TxtProcura.Text & "%' OR "
            filtro += "Comentário like '%" & TxtProcura.Text & "%' OR "
            filtro += "Modelo like '%" & TxtProcura.Text & "%' OR "
            filtro += "SN like '%" & TxtProcura.Text & "%') "
        End If
        ConstruirArvore()
    End Sub
    Private Sub ConstruirArvore()
        ListaAssets(LstItems, TipoOrd, estado, filtro)
    End Sub
    Private Sub subLimpaValores()
        ' Rotina que limpa todos os dados das textboxs e passa as datas para hoje.
        TxtCodAsset.Clear()
        TxtTipoAsset.Clear()
        TxtContratoAsset.Clear()
        TxtMarcaAsset.Clear()
        TxtComentarioAsset.Clear()
        TxtModeloAsset.Clear()
        TxtSNAsset.Clear()
        DTPAquisicao.Value = Today
        TxtValorAsset.Clear()
        dbGrid.DataSource = ""
        TrataCombo(cbtipo, "assettype", "Tipo", "")
        TrataCombo(cbcontrato, "Contratos", "NumeroContrato", "")
    End Sub
    Private Sub SubLerAsset()
        If LstItems.SelectedNode.Level.ToString = 0 Then
            subLimpaValores()
        End If
        If LstItems.SelectedNode.Tag <> "" Then
            LerDadosAsset(LstItems.SelectedNode.Tag, TxtCodAsset, TxtTipoAsset, TxtContratoAsset, TxtMarcaAsset, TxtComentarioAsset, TxtModeloAsset, TxtSNAsset, DTPAquisicao, TxtValorAsset)

            Dim sql As String = "select Empresa.Nome as Empresa, Utilizadores.Nome as Utilizador,"
            sql += "Alocacoes.Data, Alocacoes.Motivo as Comentário"
            sql += " from Alocacoes inner join Asset on Alocacoes.Asset = Asset.ID inner join Utilizadores on Alocacoes.[User] = Utilizadores.ID"
            sql += " inner join Empresa on Utilizadores.Empresa = Empresa.ID "
            sql += "where asset.id = " & TxtCodAsset.Text
            Funcoes.TrataGrelha(dbGrid, sql, TxtCodAsset.Text)
            sql = Nothing

            TrataCombo(cbtipo, "assettype", "Tipo", TxtTipoAsset.Text)
            TrataCombo(cbcontrato, "Contratos", "NumeroContrato", TxtContratoAsset.Text)

        Else
            subLimpaValores()
        End If

    End Sub
    'Botoes
    Private Sub BtnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGravar.Click
        GravaAsset(TxtCodAsset.Text, TxtTipoAsset.Text, TxtContratoAsset.Text, TxtMarcaAsset.Text, TxtComentarioAsset.Text, TxtModeloAsset.Text, TxtSNAsset.Text, DTPAquisicao.Value, TxtValorAsset.Text)
        ConstruirArvore()
        dbGrid.DataSource = ""
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If TxtCodAsset.Text <> "" Then
            EliminarRegisto("asset", TxtCodAsset.Text)
        End If
        ConstruirArvore()
        subLimpaValores()

    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            subLimpaValores()
            ConstruirArvore()
        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub
    Private Sub FrmAsset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            ConstruirArvore()

        Catch ex As Exception
            Eventos.subErro(ex)
        End Try
    End Sub


End Class

