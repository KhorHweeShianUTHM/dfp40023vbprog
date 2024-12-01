Public Class Form1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuNextPage_Click(sender As Object, e As EventArgs) Handles mnuNextPage.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class