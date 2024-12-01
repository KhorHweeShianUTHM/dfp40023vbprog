Public Class Form1
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim dblFirst, dblSecond As Double
        If txtFirst.Text = "" Or txtSecond.Text = "" Then
            MessageBox.Show("Please enter any number in first and second boxes", "Alert",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            dblFirst = Val(txtFirst.Text)
            dblSecond = Val(txtSecond.Text)
            If dblSecond = 0 Then
                MessageBox.Show("Cannot divide by zero", "Sorry",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                txtResult.Text = dblFirst / dblSecond
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dblFirst, dblSecond As Double
        If txtFirst.Text = "" Or txtSecond.Text = "" Then
            MessageBox.Show("Please enter any number in first and second boxes", "Alert",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            txtResult.Text = dblFirst + dblSecond
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim dblFirst, dblSecond As Double
        If txtFirst.Text = "" Or txtSecond.Text = "" Then
            MessageBox.Show("Please enter any number in first and second boxes", "Alert",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            txtResult.Text = dblFirst - dblSecond
        End If
    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        Dim dblFirst, dblSecond As Double
        If txtFirst.Text = "" Or txtSecond.Text = "" Then
            MessageBox.Show("Please enter any number in first and second boxes", "Alert",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            txtResult.Text = dblFirst * dblSecond
        End If
    End Sub
    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
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
