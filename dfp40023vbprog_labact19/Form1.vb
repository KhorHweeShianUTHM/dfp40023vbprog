Imports System.Data.SqlClient
Public Class Form1
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a character!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter a number!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            Dim allowednos As String = "1234567890"
            Dim allowedsymbols As String = "@."
            If Not allowedchars.Contains(e.KeyChar.ToString) And Not allowednos.Contains(e.KeyChar.ToString) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter a valid email!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter the details")
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("Please enter the details")
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please enter the details")
        ElseIf txtPass.Text = "" Then
            MessageBox.Show("Please enter the details")
        ElseIf Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid email address!")
        ElseIf Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Please enter a valid email address!")
                    Else
            MsgBox("User Registered Successfully.")
        End If
    End Sub
End Class