Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Employee As New Person 'create new object of class Person named Employee
        Dim DOB As Date 'create new object of class Date named DOB

        Employee.FirstName = TextBox1.Text 'invoked property/data of class Person
        Employee.LastName = TextBox2.Text
        DOB = DateTimePicker1.Value.Date
        MsgBox(Employee.FirstName & " " & Employee.LastName & " is " & Employee.Age(DOB) & " years old. ")
    End Sub
End Class
