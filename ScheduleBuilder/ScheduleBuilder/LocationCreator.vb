'Class for creating locations
'Author: Alden Poole
Public Class LocationCreator
<<<<<<< HEAD
    Dim locNum As Integer
    Dim ageID As Integer
    Dim maxSize As Integer
    Dim locName As String
    Public Sub New(ByVal num As Integer)
        InitializeComponent()
        locNum = num

    End Sub

    Private Sub btnCreateGroup_Click(sender As Object, e As EventArgs) Handles btnCreateLoc.Click
        'See below loop
        locNum = locNum - 1
        'Check age group, set ageID
        If (radChip.Checked) Then
            ageID = 1
        ElseIf (radFox.Checked) Then
            ageID = 2
        ElseIf (radBob.Checked) Then
            ageID = 3
        ElseIf (radBear.Checked) Then
            ageID = 4
        ElseIf (radTeen.Checked) Then
            ageID = 5
        Else
            ageID = 1

        End If
        'Set group size
        Try
            maxSize = CInt(txtSize.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a whole numeric value for max size.")
        End Try
        'Set group and counselor names
        locName = CStr(txtLocName.Text)
        'Create campGroup object with data given
        Dim location As New campLocation(locName, ageID, maxSize)
        'Add campGroup object to object list in main form
        MainWindow.addLocation(Location)
        'Debugging
        Dim locDisplay As String
        locDisplay = location.displayInfo()
        MessageBox.Show(locDisplay)
        'Save in a file to read later
        'My.Computer.FileSystem.WriteAllText("E:\Programming Projects\ScheduleBuilder\ScheduleBuilder\ScheduleBuilder\text\locationsList.txt",
        'location.writeInfo, True)
        'Loop for user determined amount of groups/ add group windows
        If locNum = 0 Then
            Me.Close()
        Else
            Dim box = New LocationCreator(locNum)
            box.Show()
        End If
        Me.Close()


    End Sub
    Private Sub btnLocExit_Click(sender As Object, e As EventArgs) Handles btnGroupExit.Click
        Me.Close()
    End Sub
=======

>>>>>>> 010ed414b239e8b19303593df9d41c2f4e1b8082
End Class