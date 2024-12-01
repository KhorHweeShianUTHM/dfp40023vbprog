Public Class Form5
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer, i As Integer = 1
        Dim num As Integer, total As Integer
        n = Val(TextBox1.Text)

        While (i <= n)
            num = InputBox("Please enter value" & i & ".")
            total = total + num
            i = i + 1

            MessageBox.Show("The sum is " & total / n, "Result")
        End While
    End Sub
End Class