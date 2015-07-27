Imports System.Data.SqlClient
Public Class Form1

    Private Sub RenomeiaTabelas()
        Dim x, sql As String
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
        Sql = " EXECUTE sp_rename 'Utilizadores', 'Utilizadores2'; "
        Sql += " EXECUTE sp_rename 'Empresa', 'Empresa2';"
        Sql += " EXECUTE sp_rename 'Alocacoes', 'Alocacoes2';"
        Sql += " EXECUTE sp_rename 'Asset', 'Asset2';"
        Sql += " EXECUTE sp_rename 'Assettype', 'Assettype2';"
        Sql += " EXECUTE sp_rename 'Contratos', 'Contratos2';"


        Dim execUsers As New SqlCommand(Sql, sqlConnUsers)
        sqlConnUsers.Open()
        x = execUsers.ExecuteNonQuery
        sqlConnUsers.Close()
    End Sub
    Private Sub CriaNovasTabelas()
        frmSqlServer.subCriarTabelas2_0()
    End Sub
    Private Sub CopiaDados()
        '       CopiaUtilizadores()
        copiaEmpresas()
        CopiaTiposAsset()
        copiaContratos()
        copiaAssets()
        CopiaAlocacoes()
    End Sub
    Private Sub CopiaUtilizadores()
        Dim strSQL As String = "SELECT * FROM Utilizadores2"
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim command As New SqlCommand(strSQL, sqlConn)
        sqlConn.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                Dim x As String
                Dim sql As String


                sql = "Insert Into utilizadores VALUES ('"
                sql += reader.Item("ID").ToString & "', '" & RTrim(reader.Item("Nome").ToString) & "', '"
                sql += RTrim(reader.Item("Empresa").ToString) & "', '" & RTrim(reader.Item("Mail").ToString) & "', '"
                sql += RTrim(reader.Item("Contacto").ToString)
                sql += "' )"
                Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
                Dim execUsers As New SqlCommand(sql, sqlConnUsers)
                sqlConnUsers.Open()
                x = execUsers.ExecuteNonQuery
                sqlConnUsers.Close()
                sqlConnUsers = Nothing
                execUsers = Nothing
                sql = Nothing

            End While
        End If

        sqlConn.Close()
    End Sub
    Private Sub copiaEmpresas()
        Dim strSQL As String = "SELECT * FROM Empresa2"
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim command As New SqlCommand(strSQL, sqlConn)
        sqlConn.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Dim x As String
                Dim sql As String
                sql = "Insert Into Empresa  VALUES ('"
                sql += reader.Item("ID").ToString & "', '" & RTrim(reader.Item("Nome").ToString) & "'"
                sql += " )"
                Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
                Dim execUsers As New SqlCommand(sql, sqlConnUsers)
                sqlConnUsers.Open()
                x = execUsers.ExecuteNonQuery
                sqlConnUsers.Close()
                sqlConnUsers = Nothing
                execUsers = Nothing
                sql = Nothing

            End While
        End If

        sqlConn.Close()
    End Sub
    Private Sub CopiaTiposAsset()
        Dim strSQL As String = "SELECT * FROM Assettype2"
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim command As New SqlCommand(strSQL, sqlConn)
        sqlConn.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Dim x As String
                Dim sql As String
                sql = "Insert Into Assettype  VALUES ('"
                sql += reader.Item("ID").ToString & "', '" & RTrim(reader.Item("Tipo").ToString) & "'"
                sql += " )"
                Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
                Dim execUsers As New SqlCommand(sql, sqlConnUsers)
                sqlConnUsers.Open()
                x = execUsers.ExecuteNonQuery
                sqlConnUsers.Close()
                sqlConnUsers = Nothing
                execUsers = Nothing
                sql = Nothing

            End While
        End If

        sqlConn.Close()
    End Sub
    Private Sub copiaContratos()
        Dim strSQL As String = "SELECT * FROM Contratos2"
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim command As New SqlCommand(strSQL, sqlConn)
        sqlConn.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Dim x As String
                Dim sql As String
                sql = "Insert Into Contratos VALUES ('"
                sql += reader.Item("ID").ToString & "', '"
                sql += RTrim(reader.Item("NumeroContrato").ToString) & "', '"
                sql += RTrim(reader.Item("Descricao").ToString) & "', '"

                sql += RTrim(reader.Item("Entidade").ToString) & "', '"

                DateTimePicker1.Value = reader.Item("DataAssinatura")
                sql += DateTimePicker1.Value.ToString("yyyyMMdd") & "', '"

                DateTimePicker2.Value = reader.Item("DataFim")
                sql += DateTimePicker2.Value.ToString("yyyyMMdd") & "', '"
                sql += reader.Item("ValorMensal").ToString & "' "
                sql += " )"
                'MsgBox(sql)
                Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
                Dim execUsers As New SqlCommand(sql, sqlConnUsers)
                sqlConnUsers.Open()
                x = execUsers.ExecuteNonQuery
                sqlConnUsers.Close()
                sqlConnUsers = Nothing
                execUsers = Nothing
                sql = Nothing

            End While
        End If

        sqlConn.Close()
    End Sub
    Private Sub copiaAssets()
        Dim strSQL As String = "SELECT * FROM Asset2 "
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim command As New SqlCommand(strSQL, sqlConn)
        sqlConn.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Dim x As String
                Dim sql As String
                sql = "Insert Into Asset VALUES ('"
                sql += reader.Item("ID").ToString & "', '"
                sql += RTrim(reader.Item("Tipo").ToString) & "', '"

                sql += RTrim(reader.Item("Contrato").ToString) & "', '"
                sql += RTrim(reader.Item("Marca").ToString) & "', '"
                sql += RTrim(reader.Item("Comentário").ToString) & "', '"
                sql += RTrim(reader.Item("Modelo").ToString) & "', '"
                sql += RTrim(reader.Item("SN").ToString) & "', '"
                DateTimePicker1.Value = reader.Item("DataAquisicao")

                sql += DateTimePicker1.Value.ToString("yyyyMMdd") & "', '"
                sql += reader.Item("Valor").ToString & "'"


                sql += " )"

                Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
                Dim execUsers As New SqlCommand(sql, sqlConnUsers)
                sqlConnUsers.Open()
                x = execUsers.ExecuteNonQuery
                sqlConnUsers.Close()
                sqlConnUsers = Nothing
                execUsers = Nothing
                sql = Nothing

            End While
        End If

        sqlConn.Close()
    End Sub
    Private Sub CopiaAlocacoes()
        Dim strSQL As String = "SELECT * FROM Alocacoes2 "
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim command As New SqlCommand(strSQL, sqlConn)
        sqlConn.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Dim x As String
                Dim sql As String
                sql = "Insert Into Alocacoes VALUES ('"
                '  sql += reader.Item("ID").ToString & "', '"
                sql += reader.Item("Activo").ToString & "', '"
                sql += reader.Item("Asset").ToString & "', '"
                sql += reader.Item("User").ToString & "', '"
                If reader.Item("Data").ToString = vbNullString Then
                    DateTimePicker1.Value = "01-01-1900"
                Else
                    DateTimePicker1.Value = reader.Item("Data")
                End If

                sql += DateTimePicker1.Value.ToString("yyyyMMdd") & "', '"
                sql += RTrim(reader.Item("Motivo").ToString) & "' "
                sql += " )"

                Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
                Dim execUsers As New SqlCommand(sql, sqlConnUsers)
                sqlConnUsers.Open()
                x = execUsers.ExecuteNonQuery
                sqlConnUsers.Close()
                sqlConnUsers = Nothing
                execUsers = Nothing
                sql = Nothing

            End While
        End If
        sqlConn.Close()
    End Sub

    Private Sub EliminaTabelas()
        Dim x, sql As String
        Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
        Dim sqlConnUsers As New SqlConnection(Settings.strSQLConnection)
        sql = " Drop table Empresa2; "
        sql = " Drop table Alocacoes2; "
        sql = " Drop table Asset2; "
        sql = " Drop table Assettype2; "
        sql = " Drop table Contratos2; "
        sql = " Drop table Utilizadores2; "


        Dim execUsers As New SqlCommand(sql, sqlConnUsers)
        sqlConnUsers.Open()
        x = execUsers.ExecuteNonQuery
        sqlConnUsers.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RenomeiaTabelas()
        CriaNovasTabelas()
        CopiaDados()
        EliminaTabelas()
        MsgBox("Upgrade bem sucedido")
        MsgBox("vamos actualizar registos")
        '   ActualizaDados()

    End Sub

    'Private Sub ActualizaDados()
    '    'Dim strSQL As String = "SELECT * FROM Assettype2"
    '    'Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
    '    'Dim command As New SqlCommand(strSQL, sqlConn)
    '    'sqlConn.Open()

    '    'Dim reader As SqlDataReader = command.ExecuteReader()
    '    'If reader.HasRows Then
    '    '    While reader.Read()
    '    Dim x As String
    '    Dim sql As String
    '    sql = "Update asset set asset.NumeroContrato = 0 Where asset.NumeroContrao=''"

    '    sql += " )"
    '    Dim sqlConn As New SqlConnection(Settings.strSQLConnection)
    '    Dim exec As New SqlCommand(sql, sqlConn)
    '    sqlConn.Open()
    '    x = exec.ExecuteNonQuery
    '    sqlConn.Close()
    '    sqlConn = Nothing
    '    exec = Nothing
    '    sql = Nothing


    'End Sub
End Class