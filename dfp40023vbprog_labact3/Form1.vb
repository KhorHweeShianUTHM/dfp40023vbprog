﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(“Visual Studio 2018”)
        ListBox1.Items.Remove(“Visual Basic 6”)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myitem
        myitem = InputBox(“Enter your Item”)
        ListBox1.Items.Add(myitem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myitem
        myitem = InputBox(“Enter your Item for Deletion”)
        ListBox1.Items.Remove(myitem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
