Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim Name As String
        Dim NoMatric As String
        Dim kelas As String
        Dim Info As String

        Name = Val(txtName.Text)
        NoMatric = Val(txtMatricNum.Text)
        kelas = Val(txtClass.Text)

        Info = "Welcome, " & Name & " . " & vbNewLine &
            "Your Matric Number is " & NoMatric & " . " & vbNewLine &
            "Your Class is " & kelas & " . "

        lblAns.Text = Info
    End Sub
End Class
