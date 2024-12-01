Public Class frmPage2
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim i As Integer
        Dim name(4) As String

        name(0) = InputBox(“Please insert member's name.”)
        name(1) = InputBox(“Please insert member's name.”)
        name(2) = InputBox(“Please insert member's name.”)
        name(3) = InputBox(“Please insert member's name.”)

        For i = 0 To 3
            lstDisplayName.Items.Add(name(i))
        Next
    End Sub
End Class