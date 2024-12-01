Public Class Form1
    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles btnArrayElement.Click
        'Declare an array
        Dim strFriends(5) As String
        Dim i As Integer

        'Populate the array
        strFriends(0) = “Ahmad”
        strFriends(1) = “Bryan”
        strFriends(2) = “Iffah”
        strFriends(3) = “Muthu”
        strFriends(4) = “Katie”

        'Show the output
        For i = 0 To 4
            MessageBox.Show(“My " & i & " friend is “ & strFriends(i))
        Next
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
