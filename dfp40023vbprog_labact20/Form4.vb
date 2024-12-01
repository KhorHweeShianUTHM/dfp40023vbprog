Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim srtMsg As String = "happy holidays"
        srtMsg = srtMsg.Remove(6)
        MsgBox(srtMsg)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class