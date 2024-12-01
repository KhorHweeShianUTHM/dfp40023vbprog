Imports System.IO
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private FileName As String

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
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

    Private Sub SveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SveToolStripMenuItem.Click
        Dim savefiledialog1 As New SaveFileDialog
        Dim sw As StreamWriter
        Try
            With savefiledialog1
                .Filter = "File Text(*.txt)|*.txt|" & "File Doc(*.docx)|*.docx|" & "All File|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                    sw = New StreamWriter(FileName)
                    sw.Write(txtName.Text)
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()
            End If
        End Try
    End Sub

    Private Sub SelectFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFontToolStripMenuItem.Click
        Dim digFontDialog As FontDialog = New FontDialog
        Dim result As DialogResult

        result = digFontDialog.ShowDialog

        txtName.Font = digFontDialog.Font
    End Sub

    Private Sub SelectForeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectForeColorToolStripMenuItem.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult

        result = digColorDialog.ShowDialog

        Label1.ForeColor = digColorDialog.Color
    End Sub

    Private Sub SelectBackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectBackColorToolStripMenuItem.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult

        result = digColorDialog.ShowDialog

        Me.BackColor = digColorDialog.Color
    End Sub
End Class