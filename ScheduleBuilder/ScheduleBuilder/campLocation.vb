'Class for campLocation object
'Author: Alden Poole 3/21/18
Public Class campLocation
    Dim ageID As Integer
    Dim maxSize As Integer
    Dim locationName As String
    Dim population As Integer
    Dim locationDisplayInfo As String
    Dim available As Boolean
    Public ageList As New List(Of Integer)
    'construct new object
    Public Sub New(ByVal name As String, ByVal age As Integer, ByVal size As Integer)
        ageID = age
        maxSize = size
        locationName = name
        population = 0
    End Sub
    'Check ageRestriction against group age
    Public Function ageRestrict(ByVal age As Integer)
        If age >= ageID Then
            available = True
        ElseIf age < ageID Then
            available = False
        End If
        Return available
    End Function
    'Check to see if sizeRestriction has been met
    Public Function sizeRestriction(ByVal groupNum As Integer)
        Dim pop = population + groupNum
        If pop < maxSize Then
            available = True
        ElseIf pop > maxSize Then
            available = False
        End If
        Return available
    End Function
    'Check for age compatibility 
    Public Function ageTest(ByVal groupAge As Integer)
        Dim index As Integer = 0
        Dim falseCount As Integer = 0
        While index < ageList.Count()
            If groupAge < (ageList(index) - 1) Then
                falseCount = falseCount + 1
            ElseIf groupAge > (ageList(index) + 1) Then
                falseCount = falseCount + 1
            End If
        End While
        If falseCount > 0 Then
            available = False
        Else
            available = True
        End If
        Return available
    End Function
    'Add group and information to location if above standards are met
    Public Sub addGroup(ByVal pop As Integer, ByVal age As Integer)
        population = population + pop
        ageList.Add(age)
    End Sub
    Public Function getName()
        Return locationName
    End Function
    Public Function displayInfo()
        Dim locDisplayInfo As String
        locDisplayInfo = "Location: " & locationName & "   Age ID: " & ageID & "   Max Size: " & maxSize
        Return locDisplayInfo
    End Function
    'Function for writing information to file
    Public Function writeInfo()
        Dim locInfo As String
        locInfo = locationName & "," & ageID & "," & maxSize & Environment.NewLine
        Return locInfo
    End Function

    Public Sub resetValues()
        population = 0
        ageList.Clear()
    End Sub

End Class
