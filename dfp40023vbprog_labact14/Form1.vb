Public Class Form1
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim Clerk As New Staff

        Clerk.Name = txtName.Text
        Clerk.Salary = Val(txtSalary.Text)

        lblView.Text = Clerk.Name & vbCrLf & "Total Payment:" & Clerk.Salary + Clerk.Bonus(50)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lblDisplay.Text = "Name: " & txtName.Text & vbCrLf &
                          "Position: " & txtPosition.Text & vbCrLf &
                          "Salary: " & txtSalary.Text
    End Sub
End Class
Public Class Staff
    Private StaffName As String
    Private Amount As Integer
    Public Property Name() As String
        Get
            Return StaffName
        End Get
        Set(ByVal value As String)
            StaffName = value
        End Set
    End Property
    Public Property Salary() As Integer
        Get
            Return Amount
        End Get
        Set(ByVal value As Integer)
            Amount = value
        End Set
    End Property
    Public Function Bonus(ByVal Percent As Integer) As Integer
        Return Amount * (Percent / 100)
    End Function
End Class