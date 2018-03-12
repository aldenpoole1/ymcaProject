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


    Public Sub int getAgeId()
        Return ageID
    End Sub

    Public setGroupName(String x)
        groupName = x;
        
Public String getGroupName()
        Return groupName;
        
Public int setGroupSize(int x)
        groupSize = x;
        
Public getGroupSize()
    Return groupSize;
        
Public setCounselorName(String x)
        counselorName = x;
        
Public String getCounselorName()
        Return counselorName;

End Class
