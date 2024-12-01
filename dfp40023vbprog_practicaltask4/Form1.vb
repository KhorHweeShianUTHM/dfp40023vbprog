Public Class Form1
    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim srtMsg As String = "Hello World!"
        srtMsg = srtMsg.Remove(6)
        MsgBox(srtMsg)

        Dim srtMsg2 As String = "Welcome to SMK AMAN JAYA"
        srtMsg2 = srtMsg2.TrimStart
        MsgBox(srtMsg2)
    End Sub
End Class