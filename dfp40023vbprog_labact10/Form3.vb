Public Class Form3
    Private Sub btnForNextLoop_Click(sender As Object, e As EventArgs) Handles btnForNextLoop.Click
        Dim intCount As Integer 'Declare variable
        'Perform a loop
        For intCount = 1 To 8
            'Add the item to the list
            lstData.Items.Add(" I’m item " & intCount & " in the list! ")
        Next
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class