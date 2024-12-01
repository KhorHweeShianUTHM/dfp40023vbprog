Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("WELCOME EVERYBODY", "Welcome", MessageBoxButtons.OK)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InputBox("Please enter your name", "name")
    End Sub

    Private Sub FirstPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirstPageToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Page2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page2ToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class