Public Class Form1
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtResult.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        txtResult.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuiltiply.Click
        txtResult.Text = Val(txtNum1.Text) * Val(txtNum2.Text)
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        txtResult.Text = Val(txtNum1.Text) / Val(txtNum2.Text)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtNum1.Text = ""
        txtNum2.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class