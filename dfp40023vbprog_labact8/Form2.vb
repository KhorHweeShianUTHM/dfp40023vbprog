Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim theDate As Date = #12/25/2005#
        TextBox1.Text = theDate.ToString("MMMM d, yyyy")

        Dim MyCulture As New System.Globalization.CultureInfo("es-ES")
        CultureDateEcho.Text = theDate.ToString("MMMM d, yyyy", MyCulture)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class