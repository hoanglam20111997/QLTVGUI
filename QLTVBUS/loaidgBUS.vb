Imports QLTVDAl
Imports QLTVDTO
Imports Utility

Public Class loaidgBUS
    Private lhsDAL As loaidgDAL
    Public Sub New()
        lhsDAL = New loaidgDAL()
    End Sub
    Public Sub New(connectionString As String)
        lhsDAL = New loaidgDAL(connectionString)
    End Sub
    Public Function isValidName(lhs As loaidgDTO) As Boolean

        If (lhs.Tenloaidg.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(lhs As loaidgDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.insert(lhs)
    End Function
    Public Function selectAll(ByRef listLoaidg As List(Of loaidgDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.selectALL(listLoaidg)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lhsDAL.getNextID(nextID)
    End Function
End Class
