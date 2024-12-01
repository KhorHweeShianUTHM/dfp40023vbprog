Public Class Form2
    Private Sub mnuTitle_Click(sender As Object, e As EventArgs) Handles mnuTitle.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click
        Dim digFontDialog As FontDialog = New FontDialog
        Dim result As DialogResult

        result = digFontDialog.ShowDialog

        lblIntro2.Font = digFontDialog.Font
        lblIntro4.Font = digFontDialog.Font
    End Sub

    Private Sub mnuBackcolor_Click(sender As Object, e As EventArgs) Handles mnuBackcolor.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult

        result = digColorDialog.ShowDialog

        lblIntro2.BackColor = digColorDialog.Color
        lblIntro4.BackColor = digColorDialog.Color
    End Sub

    Private Sub mnuForecolor_Click(sender As Object, e As EventArgs) Handles mnuForecolor.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult

        result = digColorDialog.ShowDialog

        lblIntro2.ForeColor = digColorDialog.Color
        lblIntro4.ForeColor = digColorDialog.Color
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class