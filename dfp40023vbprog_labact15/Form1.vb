Public Class Form1
    Private Sub FIRSTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIRSTPAGEToolStripMenuItem.Click
        Me.Show()
    End Sub
    Private Sub SECONDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONDPAGEToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim obj As New First
        With obj
            .X = 100
            .Y = 50
            Me.lblSum.Text = .X + .Y
        End With
    End Sub
    Private Sub THIRDPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THIRDPAGEToolStripMenuItem.Click
        frmPoly.Show()
        Me.Hide()
    End Sub
End Class
Public Class First
    Private m_x As Integer
    Private m_y As Integer
    Public Property X() As Integer
        Get
            Return m_x
        End Get
        Set(ByVal value As Integer)
            m_x = value
        End Set
    End Property
    Public Property Y() As Integer
        Get
            Return m_y
        End Get
        Set(ByVal value As Integer)
            m_y = value
        End Set
    End Property
End Class