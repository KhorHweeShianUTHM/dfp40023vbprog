Public Class Form2
    Dim Height As Double
    Dim Base As Double
    Dim Area As Double
    Sub calculateTriangle()
        Height = Val(txtHeight.Text)
        Base = Val(txtBase.Text)

        Area = 1 / 2 * Height * Base

        lblAns.Text = Area.ToString("N2") & " cm2"
    End Sub
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        calculateTriangle()
        MsgBox("Congratulation", vbQuestion + vbYesNo, "myMessage")
    End Sub
End Class