Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim srtMsg As String = " happy holidays"
        srtMsg = srtMsg.TrimStart
        MsgBox(srtMsg)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
