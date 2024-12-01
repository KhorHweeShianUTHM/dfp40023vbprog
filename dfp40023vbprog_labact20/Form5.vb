Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim texts() As String = {"DO", "RE", "MI", "LA"}
        For Each t As String In texts
            MsgBox(t.PadLeft(2))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class