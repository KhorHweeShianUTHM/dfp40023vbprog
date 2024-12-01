Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valResult1, valResult2, valResult3 As Double
        valResult1 = Val("2457")
        valResult2 = Val(" 2 45 7")
        valResult3 = Val("24 and 57")
        MsgBox(valResult1)
        MsgBox(valResult2)
        MsgBox(valResult3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
