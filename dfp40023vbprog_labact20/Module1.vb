Module Module1
    Sub Main()
        Dim s1 As String
        s1 = “abcdefghijklmnopqrstu”
        Try
            Dim s2 As String = s1.Insert(16, “ There “)
            MsgBox(s2)
        Catch ex As Exception
            MsgBox(“Exception was caught : ”)
            MsgBox(ex.Message)
        Finally
            MsgBox(“Finally block is always executed”)
        End Try
    End Sub
End Module