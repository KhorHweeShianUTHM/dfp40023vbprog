Imports System.Text.RegularExpressions
Public Class frmStudentValidationData
    Private Sub btnEmailFormat_Click(sender As Object, e As EventArgs) Handles btnEmailFormat.Click
        Dim a As String
        a = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA Z]{2,4}|[0-9]{1,3})(\]?)$"
        If Regex.IsMatch(txtEmail.Text, a) Then
            lblEmail.BackColor = Color.Green
            lblEmail.ForeColor = Color.White
            lblEmail.Text = "Valid email address"
        Else
            lblEmail.BackColor = Color.Red
            lblEmail.ForeColor = Color.White
            lblEmail.Text = "Invalid email address"
            btnSubmit.Enabled = False
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
        Dim msg As String = "Please insert data in the textbox!!"
        Dim title As String = "Warning System"
        Dim style As String = MsgBoxStyle.Information Or vbOKOnly

        If txtNoMatric.Text = "" Then
            MsgBox("Please enter Matric Number!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtName.Text = "" Then
            MsgBox("Please enter Name!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please enter Email!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtAge.Text = "" Then
            MsgBox("Please enter Age!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf Not String.IsNullOrEmpty(str) Then
            MsgBox(msg & vbNewLine & StrDup(52, "-") & vbCrLf & str, style, title)
        Else MsgBox("OK " & Environment.NewLine & "Well Done!!")
            txtNoMatric.Text = ""
            txtName.Text = ""
            txtEmail.Text = ""
            txtAge.Text = ""
            btnSubmit.Enabled = True
            lblEmail.BackColor = Color.Yellow
            lblEmail.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Text = ""
        txtEmail.Text = ""
        txtNoMatric.Text = ""
        txtAge.Text = ""
        btnSubmit.Enabled = True
        lblEmail.BackColor = Color.Yellow
        lblEmail.ForeColor = Color.Blue
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class