Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim pattern As String = "-"
        Dim inputfile As String = "C:\Documents and Settings\administrator\Desktop\Students.txt"

        Dim finfo As FileInfo = New FileInfo(inputfile)
        If finfo.Exists = True Then
            Dim reader As StreamReader = New StreamReader(inputfile)
            Dim writer As StreamWriter = New StreamWriter(inputfile & "_XTEMP", True)
            Dim lineread As String = ""
            While reader.Peek <> -1
                lineread = reader.ReadLine
                If lineread.IndexOf(pattern) <> -1 Then
                    writer.WriteLine(lineread)
                End If
            End While
            writer.Flush()
            writer.Close()
            writer.Dispose()
            reader.Close()
            reader.Dispose()
        End If
        finfo = Nothing


        MsgBox("done")

    End Sub
End Class
