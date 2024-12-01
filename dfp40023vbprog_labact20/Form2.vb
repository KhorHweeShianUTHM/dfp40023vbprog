Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim srtMsg As String = "happy holidays"
        srtMsg = srtMsg.Substring(0, 3)
        MsgBox(srtMsg)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class