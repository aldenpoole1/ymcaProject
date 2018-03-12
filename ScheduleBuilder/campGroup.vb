Imports Microsoft.VisualBasic

Public Class campGroup
    Dim ageID As Integer
    Dim groupSize As Integer
    Dim groupName As String
    Dim counselorName As String

    Public Sub New(ByVal name As String, ByVal age As Integer, ByVal size As Integer, ByVal group As String)
        counselorName = name
        ageID = age
        groupSize = size
        groupName = group
    End Sub

    Public Sub setAgeId(ByVal x As Integer)
        ageID = x
    End Sub


    Public Sub getAgeId()
        Return ageID
    End Sub

    Public Sub setGroupName(ByVal x As String)
        groupName = x
    End Sub

    Public Sub getGroupName()
        Return groupName
    End Sub


    Public Sub setGroupSize(ByVal x As Integer)
        groupSize = x
    End Sub

    Public Sub getGroupSize()
        Return groupSize
    End Sub

    Public Sub setCounselorName(ByVal x As String)
        counselorName = x
    End Sub

    Public Sub getCounselorName()
        Return counselorName
    End Sub

End Class
