Public Class Schedule
    Dim blocks As List(Of String)
    Dim subsets As New List(Of Label)
    Public Sub New(ByVal blockList As List(Of String))
        InitializeComponent()
        blocks = blockList
        subsets.Add(lbl0)
        subsets.Add(lbl1)
        subsets.Add(lbl2)
        subsets.Add(lbl3)
        subsets.Add(lbl4)
        subsets.Add(lbl5)
        subsets.Add(lbl6)
        subsets.Add(lbl7)
        subsets.Add(lbl8)
        subsets.Add(lbl9)
        subsets.Add(lbl10)
        subsets.Add(lbl11)
        subsets.Add(lbl12)
        subsets.Add(lbl13)
        subsets.Add(lbl14)
        subsets.Add(lbl15)
        subsets.Add(lbl16)
        subsets.Add(lbl17)
        subsets.Add(lbl18)
        subsets.Add(lbl19)
        subsets.Add(lbl20)
        subsets.Add(lbl21)
        subsets.Add(lbl22)
        subsets.Add(lbl23)
        subsets.Add(lbl24)
        'MessageBox.Show("scheduler working?")
        scheduleBlocks()
    End Sub
    Public Sub scheduleBlocks()
        Dim index As Integer = 0
        While index < blocks.Count
            subsets(index).Text = blocks(index)
            index = index + 1
        End While
        'MessageBox.Show("The end")
    End Sub
End Class