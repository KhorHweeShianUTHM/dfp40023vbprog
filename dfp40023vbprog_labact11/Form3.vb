Public Class Form3
    Private Sub btnClickArray_Click(sender As Object, e As EventArgs) Handles btnClickArray.Click
        Dim Numbers(5) As Integer
        Dim k As Integer

        Numbers(0) = 10
        Numbers(1) = 20
        Numbers(2) = 30
        Numbers(3) = 40
        Numbers(4) = 50

        For k = 0 To 4
            lstDisplay.Items.Add("The value of Number is " & Numbers(k))
        Next k
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Close()
    End Sub
End Class