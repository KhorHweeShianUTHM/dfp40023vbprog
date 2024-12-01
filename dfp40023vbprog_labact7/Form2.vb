Public Class Form2
    Dim invest As Double
    Dim interest As Double
    Dim year As Integer
    Dim future As Double

    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        If txtInvest.Text = "" Then
            MessageBox.Show("Please enter Investment amount", "Warning")
        End If
        If txtInterest.Text = "" Then
            MessageBox.Show("Please enter Interest rate", "Warning")
        End If
        If txtYear.Text = "" Then
            MessageBox.Show("Please enter Years", "Warning")
        End If
        txtFuture.Text = Val(txtInvest.Text) * ((1 + Val(txtInterest.Text)) ^ Val(txtYear.Text))
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtFuture.Text = ""
        txtInvest.Text = ""
        txtInterest.Text = ""
        txtYear.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class