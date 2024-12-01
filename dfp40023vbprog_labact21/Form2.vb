Imports System.Text.RegularExpressions
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA Z]{2,4}|[0-9]{1,3})(\]?)$"
        If Regex.IsMatch(txtEmail.Text, a) Then
            lblEmail.BackColor = Color.Yellow
            lblEmail.Text = "valid email address"
        Else
            lblEmail.BackColor = Color.Red
            lblEmail.Text = "invalid email address"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim tbx As TextBox
        Dim ctrl As Control
        Dim tbxList As New List(Of Control)
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                tbx = CType(ctrl, TextBox)
                If String.IsNullOrEmpty(tbx.Text) Then
                    tbxList.Add(tbx)
                    tbx.BackColor = Color.MistyRose
                Else tbx.BackColor = Color.White
                End If
            End If
        Next
        Dim str As String = ""
        For i As Integer = 0 To tbxList.Count - 1
            str &= tbxList(i).Tag.ToString() & Environment.NewLine
        Next i
        Dim msg As String = "please insert data in the textbox"
        Dim title As String = "warning system"
        Dim style As String = MsgBoxStyle.Information Or vbOKOnly
        If Not String.IsNullOrEmpty(str) Then
            MsgBox(msg & vbNewLine & StrDup(52, "-") & vbCrLf & str, style, title)
        Else MsgBox("ok" & Environment.NewLine & "well done")
            txtNoMatric.Text = ""
            txtName.Text = ""
            txtEmail.Text = ""
            txtAge.Text = ""
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Text = ""
        txtEmail.Text = ""
        txtNoMatric.Text = ""
        txtAge.Text = ""
    End Sub

    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Form1.Show()
    End Sub
End Class