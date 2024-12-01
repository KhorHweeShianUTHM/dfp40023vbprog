Public Class Form2
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strNama(4) As String

        strNama(0) = "Abdul Rahman"
        strNama(1) = "Norhazlan"
        strNama(2) = "Mohd. Irwan"
        strNama(3) = "Hamdan"

        If rbDan.Checked Then
            lblShow.Text = strNama(3)
        End If
        If rbLan.Checked Then
            lblShow.Text = strNama(1)
        End If
        If rbMan.Checked Then
            lblShow.Text = strNama(0)
        End If
        If rbWan.Checked Then
            lblShow.Text = strNama(2)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class