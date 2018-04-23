'Class for main form
'Author: Alden Poole
Public Class MainWindow
    Dim groupNum As Integer
<<<<<<< HEAD
    Dim locNum As Integer
    Public groupList As New List(Of campGroup)
    Public locationList As New List(Of campLocation)
    Dim groupCount As Integer = 0
    Dim locCount As Integer = 0
    Dim scheduleBlocks As Integer = 6
    Dim scheduled As Boolean
    Dim printStuff As String = ""
    Dim debugFinally As String = ""
=======
    'Dim groupList() As campGroup
    Public groupList As New List(Of campGroup)
    Dim groupCount As Integer = 0
>>>>>>> 010ed414b239e8b19303593df9d41c2f4e1b8082

    Private Sub btnGroup_Click(sender As Object, e As EventArgs) Handles btnGroup.Click
        groupNum = CInt(txtGroupNum.Text)
        Dim box = New GroupCreator(groupNum)
        box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub addGroup(ByVal group As campGroup)
        groupList.Add(group)
<<<<<<< HEAD
        groupCount = groupCount + 1
        ComboBox1.Items.Add(group.getGroupName)
    End Sub

    Public Sub addLocation(ByVal location As campLocation)
        locationList.Add(location)
        locCount = locCount + 1
    End Sub

    Private Sub btnCreateSched_Click(sender As Object, e As EventArgs) Handles btnCreateSched.Click
        schedulerLoop()
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        locNum = CInt(txtLocNum.Text)
        Dim box = New LocationCreator(locNum)
        box.Show()
    End Sub
    Public Sub schedulerLoop()
        Dim blockIndex As Integer = 0
        Dim locIndex As Integer = 0
        Dim index As Integer = 0
        Dim groupNum As Integer
        While index < groupList.Count()
            If ComboBox1.Text = groupList(index).getGroupName Then
                groupNum = index
            End If
            index = index + 1
            'MessageBox.Show("Loop 0")
        End While
        While blockIndex < 5
            groupList(groupNum).addBlock("Pool")
            blockIndex = blockIndex + 1
        End While
        'MessageBox.Show("Loop 1")
        While blockIndex < 25
            locIndex = CInt(Math.Ceiling(Rnd() * locationList.Count())) - 1
            groupList(groupNum).addBlock(locationList(locIndex).getName)
            blockIndex = blockIndex + 1


        End While
        'MessageBox.Show("Loop 2")

        Dim box = New Schedule(groupList(groupNum).getBlockList)
        box.Show()




        '   blockIndex = blockIndex + 1
        'End While
        'Dim debugIndex As Integer = 0
        'While debugIndex < groupList.Count()
        '  debugFinally = debugFinally & groupList(debugIndex).getLocString & vbCrLf
        '   debugIndex += 1
        'End While
        'MessageBox.Show(debugFinally)
        'MessageBox.Show(printStuff)
        'MessageBox.Show(groupList(groupIndex).displayInfo)


    End Sub
    ' Public Sub scheduleCreate(ByVal group As campGroup, ByVal location As campLocation)

    ' If (location.ageRestrict(group.getAgeId)) = True Then
    'If (location.sizeRestriction(group.getGroupSize)) = True Then
    ' group.addBlock(location.getName)
    'location.addGroup(group.getGroupSize, group.getAgeId)
    'scheduled = True
    'printStuff = printStuff & group.getGroupName & ": "
    'printStuff = printStuff & location.getName

    '    Else
    'scheduled = False
    'printStuff = printStuff & " -doh!- "
    '    End If
    'Else

    'End If


    'End Sub

    Public Sub createSheet(ByVal group As campGroup)

    End Sub




=======
        'groupList(groupCount) = group
        groupCount = groupCount + 1
    End Sub
    'Debugging array:

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim index As Integer = groupCount
    'Dim groupIndex As Integer = groupCount - 1
    'While index > 0
    '       MessageBox.Show(CStr(groupList(groupIndex).displayInfo))
    '      index = index - 1
    '     groupIndex = groupIndex - 1
    'End While
    'End Sub
>>>>>>> 010ed414b239e8b19303593df9d41c2f4e1b8082
End Class