Public Class Form2
    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim obj As New Second
        With obj
            .X = 100
            .Y = 50
            .Z = 100
            Me.lblSum.Text = .getSum()
        End With
    End Sub
    Private Sub THIRDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THIRDPAGEToolStripMenuItem.Click
        frmPoly.Show()
        Me.Hide()
    End Sub
End Class
Public Class Second
    Inherits First
    Private m_z As Integer
    Public Property Z() As Integer
        Get
            Return m_z
        End Get
        Set(ByVal value As Integer)
            m_z = value
        End Set
    End Property
    Public Function getSum() As Integer
        Dim s As Integer
        s = Me.X + Me.Y + Me.Z
        Return s
    End Function
End Class

