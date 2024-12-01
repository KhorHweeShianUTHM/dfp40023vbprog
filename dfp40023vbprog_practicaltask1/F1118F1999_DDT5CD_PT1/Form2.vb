Public Class Form2
    Private Sub SELECTFONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTFONTToolStripMenuItem.Click
        Dim digFontDialog As FontDialog = New FontDialog
        Dim result As DialogResult
        result = digFontDialog.ShowDialog
        TextBox1.Font = digFontDialog.Font
        TextBox2.Font = digFontDialog.Font
        TextBox3.Font = digFontDialog.Font
        TextBox4.Font = digFontDialog.Font
        ComboBox1.Font = digFontDialog.Font
    End Sub

    Private Sub SELECTFONTCOLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTFONTCOLORToolStripMenuItem.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult
        result = digColorDialog.ShowDialog
        TextBox1.ForeColor = digColorDialog.Color
        TextBox2.ForeColor = digColorDialog.Color
        TextBox3.ForeColor = digColorDialog.Color
        TextBox4.ForeColor = digColorDialog.Color
        ComboBox1.ForeColor = digColorDialog.Color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter NAME", "Hello")
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Please enter ADDRESS", "Hello")
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("Please enter PHONE NUMBER", "Hello")
        End If
        If TextBox4.Text = "" Then
            MessageBox.Show("Please enter PARENT NAME", "Hello")
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("Please enter CLASS", "Hello")
        End If
    End Sub

    Private Sub FRISTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FRISTPAGEToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class