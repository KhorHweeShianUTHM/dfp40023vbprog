Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim srtMsg As String = "jtmk department"
        srtMsg = srtMsg.IndexOf("part")
        MsgBox(srtMsg)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class