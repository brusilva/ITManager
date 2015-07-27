Module Eventos

    Public Sub subErro(ByVal Excepção As Exception)
        subGravaErro(Excepção)
        MsgBox(Excepção.Message, MsgBoxStyle.OkOnly, "ITManage - Erro!")
    End Sub
    Private Sub subGravaErro(ByVal Excepção As Exception)
        Try
            Dim Texto As String
            If My.Computer.FileSystem.DirectoryExists("C:\VB\") = False Then

                My.Computer.FileSystem.CreateDirectory("C:\VB\")
            End If
            If My.Computer.FileSystem.DirectoryExists("C:\VB\IT\") = False Then
                My.Computer.FileSystem.CreateDirectory("C:\VB\IT\")
            End If
            If My.Computer.FileSystem.DirectoryExists("C:\VB\IT\Erro\") = False Then
                My.Computer.FileSystem.CreateDirectory("C:\VB\IT\Erro\")
            End If
            If My.Computer.FileSystem.FileExists("C:\VB\IT\Erro\" & Now.Year & Format(Now.Month, "00") & Format(Now.Day, "00") & ".csv") = False Then
                Texto = "Hora;Erro" & vbNewLine
                My.Computer.FileSystem.WriteAllText("C:\VB\IT\Erro\" & Now.Year & Format(Now.Month, "00") & Format(Now.Day, "00") & ".csv", Texto & vbNewLine, True)
            End If
            Texto = Format(Now.Hour, "00") & ":" & Format(Now.Minute, "00") & ":" & Format(Now.Second, "00") & ";" & Excepção.ToString & vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\VB\IT\Erro\" & Now.Year & Format(Now.Month, "00") & Format(Now.Day, "00") & ".csv", Texto, True)
        Catch ex As Exception
            MsgBox("Erro a gravar erro -> modLog -> subGravaErro " & vbNewLine & ex.Message)
        End Try
    End Sub


End Module
