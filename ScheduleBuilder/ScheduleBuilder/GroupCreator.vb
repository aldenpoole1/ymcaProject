'Class for group creation form
'Author: Alden Poole

Public Class GroupCreator
    Dim ageID As Integer
    Dim groupSize As Integer
    Dim groupName As String
    Dim counselorName As String
    Dim groupNum As Integer

    Public Sub New(ByVal num As Integer)
        InitializeComponent()
        groupNum = num

    End Sub

    Private Sub btnCreateGroup_Click(sender As Object, e As EventArgs) Handles btnCreateGroup.Click
        'See below loop
        groupNum = groupNum - 1
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
            groupSize = CInt(txtSize.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a whole numeric value for group size.")
        End Try
        'Set group and counselor names
        groupName = CStr(txtGroupName.Text)
        counselorName = CStr(txtCounselorName.Text)
        'Create campGroup object with data given
        Dim group As New campGroup(counselorName, ageID, groupSize, groupName)
        'Add campGroup object to object list in main form
        MainWindow.addGroup(group)
        'Debugging
        Dim groupDisplay As String
        groupDisplay = group.displayInfo()
        MessageBox.Show(groupDisplay)
        'Save in a file to read later

        'My.Computer.FileSystem.WriteAllText("E:\Programming Projects\ScheduleBuilder\ScheduleBuilder\ScheduleBuilder\text\groupsList.txt",
        'group.writeInfo, True)
        'Loop for user determined amount of groups/ add group windows
        If groupNum = 0 Then
            Me.Close()
        Else
            Dim box = New GroupCreator(groupNum)
            box.Show()
        End If
        Me.Close()


    End Sub

    Private Sub btnGroupExit_Click(sender As Object, e As EventArgs) Handles btnGroupExit.Click
        Me.Close()
    End Sub
End Class
