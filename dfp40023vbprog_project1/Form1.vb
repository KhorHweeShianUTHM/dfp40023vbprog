﻿Imports System.IO
Public Class frm1
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

    Private Sub mnuFirstPage_Click(sender As Object, e As EventArgs) Handles mnuFirstPage.Click
        Me.Show()
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
        frm4.Show()
        Me.Hide()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frm2.Show()
        Me.Hide()
    End Sub
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome To TEDBOY Bakery Shop", "Hello", MessageBoxButtons.OK)
    End Sub
End Class
