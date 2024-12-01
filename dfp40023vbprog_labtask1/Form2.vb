Public Class Form2
    Private Sub lblDetail_Click(sender As Object, e As EventArgs) Handles lblDetail.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtResult.Text = Val(txtCake1.Text) + Val(txtCake2.Text)
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        txtResult.Text = Val(txtCake1.Text) - Val(txtCake2.Text)
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        txtResult.Text = Val(txtCake1.Text) * Val(txtCake2.Text)
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        txtResult.Text = Val(txtCake1.Text) / Val(txtCake2.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCake1.Text = ""
        txtCake2.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class