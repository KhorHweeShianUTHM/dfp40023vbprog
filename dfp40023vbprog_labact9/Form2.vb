Public Class Form2
    Private Sub btnAnotherIf_Click(sender As Object, e As EventArgs) Handles btnAnotherIf.Click
        Dim intNumber As Integer = 27 'Declare and set a variable
        'Here’s where you make a decision, and tell the user what happened

        If TextBox1.Text = 1000 Then
            MessageBox.Show(“’intNumber’ is , indeed, 1000!”, “ Simple If “)
        ElseIf TextBox1.Text = intNumber Then
            MessageBox.Show(“’intNumber’ is 27!”, “ Simple If “)
        Else
            MessageBox.Show(“’intNumber’ is neither 1000 nor 27!”, “ Simple If “)
        End If
    End Sub

    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub THIRDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THIRDPAGEToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub FOURTHPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOURTHPAGEToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class