Imports QLTVDAl
Imports QLTVDTO
Imports Utility

Public Class laptheBUS
    Private dgDAL As laptheDAL
    Public Sub New()
        dgDAL = New laptheDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New laptheDAL(connectionString)
    End Sub
    Public Function isValidName(hs As laptheDTO) As Boolean

        If (hs.Hoten.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function isValidage(hs As laptheDTO) As Boolean

        If (Year(Now) - hs.NgaySinh.Year >= 18 And Year(Now) - hs.NgaySinh.Year <= 65) Then
            Return True
        End If

        Return False
    End Function
    Public Function insert(hs As laptheDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(hs)
    End Function

    Public Function buildMSHS(ByRef nextMshs As Integer) As Result
        Return dgDAL.buildMadg(nextMshs)
    End Function
End Class