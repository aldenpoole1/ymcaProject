'Class for main form
'Author: Alden Poole
Public Class MainWindow
    Dim groupNum As Integer
    'Dim groupList() As campGroup
    Public groupList As New List(Of campGroup)
    Dim groupCount As Integer = 0

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
End Class