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
End Class