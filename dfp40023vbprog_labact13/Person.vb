Public Class Person
    Private Name1 As String
    Private name2 As String
    Private cho As String
    Public Property FirstName() As String
        Get
            Return Name1
        End Get
        Set(ByVal value As String)
            Name1 = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return name2
        End Get
        Set(ByVal value As String)
            name2 = value
        End Set
    End Property
    Public Property Choose() As String
        Get
            Return cho
        End Get
        Set(ByVal value As String)
            cho = value
        End Set
    End Property
    Public Function Age(ByVal Birthday As Date) As Integer
        Return Int(Now.Subtract(Birthday).Days / 365.25)
    End Function
End Class