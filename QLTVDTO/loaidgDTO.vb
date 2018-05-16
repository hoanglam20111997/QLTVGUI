Public Class loaidgDTO

    Private imaloaidg As Integer
    Private strtenloaidg As String

    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String)
        imaloaidg = ml
        strtenloaidg = tl
    End Sub
    Property Maloaidg() As Integer
        Get
            Return imaloaidg
        End Get
        Set(ByVal Value As Integer)
            imaloaidg = Value
        End Set
    End Property
    Property Tenloaidg() As String
        Get
            Return strtenloaidg
        End Get
        Set(ByVal Value As String)
            strtenloaidg = Value
        End Set
    End Property
End Class
