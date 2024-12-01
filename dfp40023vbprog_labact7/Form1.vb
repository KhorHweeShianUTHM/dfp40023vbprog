Public Class Form1
    Dim f As Integer = 3
    Dim n As Integer = 5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = 8 + f ^ 5 - n
        TextBox2.Text = (8 + f) ^ 5 - n
        TextBox3.Text = 8 * (f ^ 5) - n
        TextBox4.Text = 8 * f ^ (5 - n)
        TextBox5.Text = (6 * f) ^ (5 - n)
        TextBox6.Text = 7 * f * f ^ 4 - (n + f)
        TextBox7.Text = 7 + f * 3 \ n - 1
        TextBox8.Text = f Mod 2 + 2 * n - 2 / 5
        TextBox9.Text = (3 * 9 - (f + (9 * 3 / (3 - n))))
    End Sub

    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class