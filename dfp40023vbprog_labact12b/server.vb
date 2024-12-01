Module server
    Public Sub addemp(ByRef a As Integer, ByVal b As Integer)
        Dim sum As Integer
        sum = a + b
        Console.WriteLine("ACTIVITY 12.4: INVOKED A SUB-PROCEDURE")
        Console.WriteLine("The Total =" & sum)
        Console.ReadKey()
    End Sub
End Module