Public Class Form1
    Dim ageID As Integer
    Dim groupSize As Integer
    Dim groupName As String
    Dim counselorName As String
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If (radChip.Checked) Then
            ageID = 1
        ElseIf (radFox.Checked) Then
            ageID = 2
        ElseIf (radBob.Checked) Then
            ageID = 3
        ElseIf (radBear.Checked) Then
            ageID = 4
        ElseIf (radBob.Checked) Then
            ageID = 5
        End If

        Try
            groupSize = CInt(txtSize.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a whole numeric value for group size.")
        End Try
        groupName = CStr(txtGroupName.Text)
        counselorName = CStr(txtCounselorName.Text)

        Dim group As New campGroup(counselorName, ageID, groupSize, groupName)
    End Sub
End Class
