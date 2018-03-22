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
    End Sub
    'Check ageRestriction against group age
    Public Function ageRestrict(ByVal age As Integer)
        If ageID <= age Then
            available = True
        ElseIf ageID > age Then
            available = False
        End If
        Return available
    End Function
    'Check to see if sizeRestriction has been met
    Public Function sizeRestriction()
        If population < (maxSize - 6) Then
            available = True
        ElseIf population > (maxSize - 5) Then
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
    '*****STILL NO DISPLAY OR WRITE INFO FUNCTIONS******

End Class
