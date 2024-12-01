Public Class Form4
    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        'Declare variables
        Dim strName As String
        Dim strFavoriteColor As String
        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex)
        'Use a select case to get the favorite color of the selected name
        Select Case strName
            Case “Bryan”
                strFavoriteColor = “Madras Yellow”
            Case “Stephanie”
                strFavoriteColor = “Sea Blue”
            Case “Cathy”
                strFavoriteColor = “Morning Mist”
            Case “Betty”
                strFavoriteColor = “Passionate Purple”
            Case “Edward”
                strFavoriteColor = “Battleship Gray”
        End Select
        'Display the favorite color of the selected name
        MessageBox.Show(strName & “ ‘s favorite color is “ & strFavoriteColor, “Select Demo”)
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
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub FOURTHPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOURTHPAGEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class