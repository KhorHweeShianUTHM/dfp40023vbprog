Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(“Visual Studio 2015")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myitem
        myitem = InputBox(“Enter your Item”)
        ComboBox1.Items.Add(myitem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Remove(“Visual Studio 6”)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Items.Clear()
    End Sub

    Private Sub NextPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextPageToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub Page2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page2ToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class