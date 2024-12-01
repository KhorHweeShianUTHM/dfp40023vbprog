Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim value1 As Double = 50900.65
        Dim value2 As Double = 10500.5
        MsgBox(value1.ToString(“N3”))
        MsgBox(value2.ToString(“N”))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class