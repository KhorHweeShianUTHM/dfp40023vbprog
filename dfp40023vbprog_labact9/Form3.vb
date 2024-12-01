Public Class Form3
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim value As Integer = Integer.Parse(InputBox("Enter the 1-5 number"))
        Select Case value
            Case 1
                MsgBox("You typed one")
            Case 2
                MsgBox("You typed two")
            Case 3
                MsgBox("You typed three")
            Case 4
                MsgBox("You typed four")
            Case 5
                MsgBox("You typed five")
            Case Else
                MsgBox("Please typed again")
        End Select
    End Sub

    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub THIRDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THIRDPAGEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub FOURTHPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOURTHPAGEToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class