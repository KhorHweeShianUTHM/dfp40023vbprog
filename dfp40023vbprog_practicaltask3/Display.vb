Public Class Display1
    Private n As String
    Private j As String
    Public Property Nama() As String
        Get
            Return n
        End Get
        Set(ByVal value As String)
            n = value
        End Set
    End Property
    Public Property Jantina() As String
        Get
            Return j
        End Get
        Set(ByVal value As String)
            j = value
        End Set
    End Property
End Class

Public Class Display2
    Inherits Display1
    Private a As String
    Private b As String
    Private d As String
    Public Property Alamat() As String
        Get
            Return a
        End Get
        Set(ByVal value As String)
            a = value
        End Set
    End Property
    Public Property Bandar() As String
        Get
            Return b
        End Get
        Set(ByVal value As String)
            b = value
        End Set
    End Property
    Public Property Daerah() As String
        Get
            Return d
        End Get
        Set(ByVal value As String)
            d = value
        End Set
    End Property
End Class