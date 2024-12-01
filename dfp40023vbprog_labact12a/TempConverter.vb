Module TempConverter
    Dim farenheit As Integer
    Dim celsius As Integer
    Sub main3()
        inputFarenheit()
        calculate()
        display()
    End Sub
    Private Sub inputFarenheit()
        farenheit = Convert.ToDouble(InputBox("Enter the Farenheit Temperature: "))
    End Sub
    Private Sub calculate()
        celsius = 5 / 9 * (farenheit - 32)
    End Sub
    Private Sub display()
        celsius = Math.Round(celsius, 1)
        MsgBox(farenheit & " F = " & celsius & " C")
    End Sub
End Module
