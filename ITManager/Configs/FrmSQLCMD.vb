Imports System.Data.SqlClient

Public Class frmCmdSql

    Private Sub btnExecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sqlConn As New SqlConnection(txbLigação.Text)
        Dim cmdBackupDB As SqlCommand
        Try
            sqlConn.Open()
            cmdBackupDB = New SqlCommand(txbCmdSql.Text, sqlConn)
            cmdBackupDB.ExecuteNonQuery() ' Cria Tabela Funcionários
            txbRespostaSql.Text += "Comando executado com sucesso" & vbNewLine
            sqlConn.Close()
        Catch ex As Exception
            txbRespostaSql.Text += ex.Message & vbNewLine
        End Try
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txbRespostaSql.Clear()
    End Sub

    Private Sub btnLigar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sqlConn As New SqlConnection(txbLigação.Text)
        Try
            sqlConn.Open()
            If sqlConn.State = ConnectionState.Open Then
                txbRespostaSql.Text += "Ligação com Sucesso" & vbNewLine
                sqlConn.Close()
            End If
        Catch ex As Exception
            txbRespostaSql.Text += ex.Message & vbNewLine
        End Try
    End Sub

    Private Sub btnLigar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLigar.Click

    End Sub
End Class