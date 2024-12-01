Public Class Form1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        lstBox.Items.Add("johor")
        For num = 1 To 20 Step 3
            MsgBox(num)
            num = num + 2
        Next
    End Sub
End Class
