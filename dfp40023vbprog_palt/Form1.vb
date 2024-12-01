Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPresidentName.Text = "" Then
            MessageBox.Show("Please enter the President Name.", "Warning")
        ElseIf txtYear.Text = "" Then
            MessageBox.Show("Please enter the Year of Launch.", "Warning")
        ElseIf txtPresidentName.Text = "" And txtYear.Text = "" Then
            MessageBox.Show("Please enter the President Name and Year of Launch.", "Warning")
        Else
            MessageBox.Show(txtPresidentName.Text & " is DSC President since " & txtYear.Text, "Welcome")
        End If
    End Sub

    Private Sub txtPresidentName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresidentName.KeyPress
        Dim character As String = "abcdefghijklmnopqrstuvwxyz "
        If Not character.Contains(e.KeyChar.ToString.ToLower) Then
            MessageBox.Show("It only can enter character.", "Warning")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        Dim number As String = "1234567890"
        If Not number.Contains(e.KeyChar.ToString) Then
            MessageBox.Show("It only can enter a number.", "Warning")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmPage2.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form3.Show()
        Me.Hide()
    End Sub
End Class
