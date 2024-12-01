Imports System.IO
Public Class frm3
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

        txtBunName.Font = digFontDialog.Font
        txtBunFlavor.Font = digFontDialog.Font
        txtBunNum1.Font = digFontDialog.Font
        txtBunNum2.Font = digFontDialog.Font
        txtBunResult.Font = digFontDialog.Font
    End Sub

    Private Sub mnuSelectForeColor_Click(sender As Object, e As EventArgs) Handles mnuSelectForeColor.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult

        result = digColorDialog.ShowDialog
        txtBunName.ForeColor = digColorDialog.Color
        txtBunFlavor.ForeColor = digColorDialog.Color
        txtBunNum1.ForeColor = digColorDialog.Color
        txtBunNum2.ForeColor = digColorDialog.Color
        txtBunResult.ForeColor = digColorDialog.Color
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
        Me.Show()
    End Sub

    Private Sub mnuFourthPage_Click(sender As Object, e As EventArgs) Handles mnuFourthPage.Click
        frm4.Show()
        Me.Hide()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnBunDescription_Click(sender As Object, e As EventArgs) Handles btnBunDescription.Click
        InputBox("Please insert Description", "Description")
    End Sub

    Private Sub frm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Bun is Best", "Hello", MessageBoxButtons.OK)
    End Sub

    Private Sub btnBunAdd_Click(sender As Object, e As EventArgs) Handles btnBunAdd.Click
        txtBunResult.Text = Val(txtBunNum1.Text) + Val(txtBunNum2.Text)
    End Sub

    Private Sub btnBunSub_Click(sender As Object, e As EventArgs) Handles btnBunSub.Click
        txtBunResult.Text = Val(txtBunNum1.Text) - Val(txtBunNum2.Text)
    End Sub

    Private Sub btnBunMulti_Click(sender As Object, e As EventArgs) Handles btnBunMulti.Click
        txtBunResult.Text = Val(txtBunNum1.Text) * Val(txtBunNum2.Text)
    End Sub

    Private Sub btnBunDiv_Click(sender As Object, e As EventArgs) Handles btnBunDiv.Click
        txtBunResult.Text = Val(txtBunNum1.Text) / Val(txtBunNum2.Text)
    End Sub

    Private Sub btnBunReset_Click(sender As Object, e As EventArgs) Handles btnBunReset.Click
        txtBunNum1.Text = ""
        txtBunNum2.Text = ""
        txtBunResult.Text = ""
    End Sub

    Private Sub btnBunExit_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class