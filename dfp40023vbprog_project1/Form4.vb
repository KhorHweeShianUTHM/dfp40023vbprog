Imports System.IO
Public Class frm4
    Inherits System.Windows.Forms.Form
    Private FileName As String
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles mnuOpen.Click
        Dim openfiledialog1 As New OpenFileDialog
        Dim sr As StreamReader
        Try
            With openfiledialog1
                .Filter = "File Text (*.txt)|*.txt|" & "All File|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                    sr = New StreamReader(.OpenFile)
                    Me.Text = sr.ReadToEnd()
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sr Is Nothing) Then
                sr.Close()
            End If
        End Try
    End Sub

    Private Sub mnuSelectFont_Click(sender As Object, e As EventArgs) Handles mnuSelectFont.Click
        Dim digFontDialog As FontDialog = New FontDialog
        Dim result As DialogResult

        result = digFontDialog.ShowDialog

        txtCakeName.Font = digFontDialog.Font
        txtCakeFlavor.Font = digFontDialog.Font
        txtCakeNum1.Font = digFontDialog.Font
        txtCakeNum2.Font = digFontDialog.Font
        txtCakeResult.Font = digFontDialog.Font
    End Sub

    Private Sub mnuSelectForeColor_Click(sender As Object, e As EventArgs) Handles mnuSelectForeColor.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult

        result = digColorDialog.ShowDialog
        txtCakeName.ForeColor = digColorDialog.Color
        txtCakeFlavor.ForeColor = digColorDialog.Color
        txtCakeNum1.ForeColor = digColorDialog.Color
        txtCakeNum2.ForeColor = digColorDialog.Color
        txtCakeResult.ForeColor = digColorDialog.Color
    End Sub

    Private Sub mnuFirstPage_Click(sender As Object, e As EventArgs) Handles mnuFirstPage.Click
        frm1.Show()
        Me.Hide()
    End Sub

    Private Sub mnuSecondPage_Click(sender As Object, e As EventArgs) Handles mnuSecondPage.Click
        frm2.Show()
        Me.Hide()
    End Sub

    Private Sub mnuThirdPage_Click(sender As Object, e As EventArgs) Handles mnuThirdPage.Click
        frm3.Show()
        Me.Hide()
    End Sub

    Private Sub mnuFourthPage_Click(sender As Object, e As EventArgs) Handles mnuFourthPage.Click
        Me.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnCakeDescription_Click(sender As Object, e As EventArgs) Handles btnCakeDescription.Click
        InputBox("Please insert Description", "Description")
    End Sub

    Private Sub frm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Cake is Best", "Hello", MessageBoxButtons.OK)
    End Sub
    Private Sub btnCakeAdd_Click(sender As Object, e As EventArgs) Handles btnCakeAdd.Click
        txtCakeResult.Text = Val(txtCakeNum1.Text) + Val(txtCakeNum2.Text)
    End Sub

    Private Sub btnCakeSub_Click(sender As Object, e As EventArgs) Handles btnCakeSub.Click
        txtCakeResult.Text = Val(txtCakeNum1.Text) - Val(txtCakeNum2.Text)
    End Sub

    Private Sub btnCakeMulti_Click(sender As Object, e As EventArgs) Handles btnCakeMulti.Click
        txtCakeResult.Text = Val(txtCakeNum1.Text) * Val(txtCakeNum2.Text)
    End Sub

    Private Sub btnCakeDiv_Click(sender As Object, e As EventArgs) Handles btnCakeDiv.Click
        txtCakeResult.Text = Val(txtCakeNum1.Text) / Val(txtCakeNum2.Text)
    End Sub

    Private Sub btnCakeReset_Click(sender As Object, e As EventArgs) Handles btnCakeReset.Click
        txtCakeNum1.Text = ""
        txtCakeNum2.Text = ""
        txtCakeResult.Text = ""
    End Sub

    Private Sub btnCakeExit_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class