Public Class Form4
    Private Sub btnKlikSifir_Click(sender As Object, e As EventArgs) Handles btnKlikSifir.Click
        Dim multiplier As Integer
        Dim answer As Integer
        Dim i As Integer

        multiplier = 5

        Do While multiplier < 6
            For i = 1 To 10
                answer = i * multiplier
                lstSifirBox.Items.Add(i & " X " & multiplier & " = " & answer)
            Next i
            multiplier = multiplier + 1
        Loop
    End Sub

    Private Sub btnPrevious_Click_1(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class