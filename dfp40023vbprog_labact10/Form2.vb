Public Class Form2
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim X As Integer
        Dim strMatrixNo As String
        For X = 1 To 16
            strMatrixNo = "18QIP09F10" & X.ToString("00")
            ListBox1.Items.Add(strMatrixNo)
        Next
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class