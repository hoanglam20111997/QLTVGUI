Public Class laptheDTO
    Private strmadg As String
    Private strhoten As String
    Private iloaidocgia As Integer
    Private datengaysinh As DateTime
    Private strdiachi As String
    Private stremail As String
    Private datelapthe As DateTime
    Private strnguoilap As String
    Public Sub New()
    End Sub
    Public Sub New(madg As String, hoten As String, loaidocgia As Integer, diachi As String, ngaysinh As DateTime, email As String, ngaylap As DateTime, nguoilap As String)
        Me.strmadg = madg
        Me.strhoten = hoten
        Me.iloaidocgia = loaidocgia
        Me.strdiachi = diachi
        Me.datengaysinh = ngaysinh
        Me.stremail = email
        Me.datelapthe = ngaylap
        Me.strnguoilap = nguoilap
    End Sub
    Property Madg() As String
        Get
            Return strmadg
        End Get
        Set(ByVal Value As String)
            strmadg = Value
        End Set
    End Property
    Property Hoten() As String
        Get
            Return strhoten
        End Get
        Set(ByVal Value As String)
            strhoten = Value
        End Set
    End Property

    Property Loaidocgia() As Integer
        Get
            Return iloaidocgia
        End Get
        Set(ByVal Value As Integer)
            iloaidocgia = Value
        End Set
    End Property

    Property NgaySinh() As DateTime
        Get
            Return datengaysinh
        End Get
        Set(ByVal Value As DateTime)
            datengaysinh = Value
        End Set
    End Property

    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property

    Property Email() As String
        Get
            Return stremail
        End Get
        Set(ByVal Value As String)
            stremail = Value
        End Set
    End Property
    Property Ngaylapthe() As DateTime
        Get
            Return datelapthe
        End Get
        Set(ByVal Value As DateTime)
            datelapthe = Value
        End Set
    End Property

    Property Nguoilap() As String
        Get
            Return strnguoilap
        End Get
        Set(ByVal Value As String)
            strnguoilap = Value
        End Set
    End Property
End Class
