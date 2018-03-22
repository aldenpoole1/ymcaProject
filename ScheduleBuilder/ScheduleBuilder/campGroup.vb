'Class for campGroup object
'Author: Alden Poole
Imports Microsoft.VisualBasic

Public Class campGroup
    Dim ageID As Integer
    Dim groupSize As Integer
    Dim groupName As String
    Dim counselorName As String
    Dim groupInfo As String
    Dim groupDisplayInfo As String
    'Construct new group
    Public Sub New(ByVal name As String, ByVal age As Integer, ByVal size As Integer, ByVal group As String)
        counselorName = name
        ageID = age
        groupSize = size
        groupName = group
    End Sub

    Public Sub setAgeId(ByVal x As Integer)
        ageID = x
    End Sub


    Public Function getAgeId()
        Return ageID
    End Function

    Public Sub setGroupName(ByVal x As String)
        groupName = x
    End Sub

    Public Function getGroupName()
        Return groupName
    End Function


    Public Sub setGroupSize(ByVal x As Integer)
        groupSize = x
    End Sub

    Public Function getGroupSize()
        Return groupSize
    End Function

    Public Sub setCounselorName(ByVal x As String)
        counselorName = x
    End Sub

    Public Function getCounselorName()
        Return counselorName
    End Function
    'Function for displaying info for debug
    Public Function displayInfo()
        groupDisplayInfo = "Counselor: " & counselorName & "  Group: " & groupName & "   Age ID: " & ageID & "   Group Size: " & groupSize
        Return groupDisplayInfo
    End Function
    'Function for writing information to file
    Public Function writeInfo()
        groupInfo = counselorName & "," & groupName & "," & ageID & "," & groupSize & Environment.NewLine
        Return groupInfo
    End Function

End Class
