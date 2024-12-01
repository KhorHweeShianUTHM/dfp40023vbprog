Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Pls enter your comment and email address", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
        ElseIf TextBox1.Text = "" Then
            MsgBox("Pls enter your comment", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
        ElseIf TextBox2.Text = "" Then
            MsgBox("Pls enter your email address", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class