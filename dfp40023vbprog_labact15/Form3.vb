Public Class frmPoly
    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub THIRDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THIRDPAGEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim two As New One()
        Me.Label1.Text = "Value for i : " & two.add(10)
        Me.Label2.Text = "Value for i+j : " & two.add(10, 20)
        Me.Label3.Text = "Value for i+j+k : " & two.add(10, 20, 30)
    End Sub
End Class
Public Class One
    Public i, j, k As Integer
    Public Function add(ByVal i As Integer) As Integer
        'function with one argument
        Return i
    End Function
    Public Function add(ByVal i As Integer, ByVal j As Integer) As Integer
        'function with two arguments
        Return i + j
    End Function
    Public Function add(ByVal i As Integer, ByVal j As Integer, ByVal k As Integer) As Integer
        'function with three arguments
        Return i + j + k
    End Function
End Class
