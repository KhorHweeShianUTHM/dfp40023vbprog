Public Class Display1
    Private Name As String
    Private Sex As String
    Private Age As String
    Private Race As String
    Public Property Nama() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property
    Public Property Pendaftaran() As String
        Get
            Return IC
        End Get
        Set(ByVal value As String)
            IC = value
        End Set
    End Property

    Public Property Jantina() As String
        Get
            Return Sex
        End Get
        Set(ByVal value As String)
            Sex = value
        End Set
    End Property
    Public Property Umur() As String
        Get
            Return Age
        End Get
        Set(ByVal value As String)
            Age = value
        End Set
    End Property
    Public Property Kaum() As String
        Get
            Return Race
        End Get
        Set(ByVal value As String)
            Race = value
        End Set
    End Property
End Class

Public Class Display2
    Inherits Display1
    Private Address As String
    Private Postcode As String
    Private City As String
    Private Area As String
    Private Telephone As String
    Public Property Alamat() As String
        Get
            Return Address
        End Get
        Set(ByVal value As String)
            Address = value
        End Set
    End Property
    Public Property Poskod() As String
        Get
            Return Postcode
        End Get
        Set(ByVal value As String)
            Postcode = value
        End Set
    End Property
    Public Property Bandar() As String
        Get
            Return City
        End Get
        Set(ByVal value As String)
            City = value
        End Set
    End Property
    Public Property Daerah() As String
        Get
            Return Area
        End Get
        Set(ByVal value As String)
            Area = value
        End Set
    End Property
    Public Property Telefon() As String
        Get
            Return Telephone
        End Get
        Set(ByVal value As String)
            Telephone = value
        End Set
    End Property
End Class