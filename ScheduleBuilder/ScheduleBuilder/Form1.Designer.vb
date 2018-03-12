<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.group1 = New System.Windows.Forms.GroupBox()
        Me.radChip = New System.Windows.Forms.RadioButton()
        Me.radFox = New System.Windows.Forms.RadioButton()
        Me.radBob = New System.Windows.Forms.RadioButton()
        Me.radBear = New System.Windows.Forms.RadioButton()
        Me.radTeen = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCounselorName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(192, 231)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(131, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Group"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Age Group:"
        '
        'group1
        '
        Me.group1.Controls.Add(Me.txtCounselorName)
        Me.group1.Controls.Add(Me.Label4)
        Me.group1.Controls.Add(Me.txtGroupName)
        Me.group1.Controls.Add(Me.Label3)
        Me.group1.Controls.Add(Me.txtSize)
        Me.group1.Controls.Add(Me.Label2)
        Me.group1.Controls.Add(Me.radTeen)
        Me.group1.Controls.Add(Me.radBear)
        Me.group1.Controls.Add(Me.radBob)
        Me.group1.Controls.Add(Me.radFox)
        Me.group1.Controls.Add(Me.radChip)
        Me.group1.Controls.Add(Me.Label1)
        Me.group1.Location = New System.Drawing.Point(12, 63)
        Me.group1.Name = "group1"
        Me.group1.Size = New System.Drawing.Size(483, 162)
        Me.group1.TabIndex = 2
        Me.group1.TabStop = False
        Me.group1.Text = "Group Information:"
        '
        'radChip
        '
        Me.radChip.AutoSize = True
        Me.radChip.Location = New System.Drawing.Point(73, 26)
        Me.radChip.Name = "radChip"
        Me.radChip.Size = New System.Drawing.Size(72, 17)
        Me.radChip.TabIndex = 2
        Me.radChip.TabStop = True
        Me.radChip.Text = "Chipmunk"
        Me.radChip.UseVisualStyleBackColor = True
        '
        'radFox
        '
        Me.radFox.AutoSize = True
        Me.radFox.Location = New System.Drawing.Point(151, 26)
        Me.radFox.Name = "radFox"
        Me.radFox.Size = New System.Drawing.Size(42, 17)
        Me.radFox.TabIndex = 3
        Me.radFox.TabStop = True
        Me.radFox.Text = "Fox"
        Me.radFox.UseVisualStyleBackColor = True
        '
        'radBob
        '
        Me.radBob.AutoSize = True
        Me.radBob.Location = New System.Drawing.Point(199, 26)
        Me.radBob.Name = "radBob"
        Me.radBob.Size = New System.Drawing.Size(59, 17)
        Me.radBob.TabIndex = 4
        Me.radBob.TabStop = True
        Me.radBob.Text = "Bobcat"
        Me.radBob.UseVisualStyleBackColor = True
        '
        'radBear
        '
        Me.radBear.AutoSize = True
        Me.radBear.Location = New System.Drawing.Point(264, 26)
        Me.radBear.Name = "radBear"
        Me.radBear.Size = New System.Drawing.Size(47, 17)
        Me.radBear.TabIndex = 5
        Me.radBear.TabStop = True
        Me.radBear.Text = "Bear"
        Me.radBear.UseVisualStyleBackColor = True
        '
        'radTeen
        '
        Me.radTeen.AutoSize = True
        Me.radTeen.Location = New System.Drawing.Point(317, 26)
        Me.radTeen.Name = "radTeen"
        Me.radTeen.Size = New System.Drawing.Size(50, 17)
        Me.radTeen.TabIndex = 6
        Me.radTeen.TabStop = True
        Me.radTeen.Text = "Teen"
        Me.radTeen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Group Size:"
        '
        'txtSize
        '
        Me.txtSize.BackColor = System.Drawing.SystemColors.Control
        Me.txtSize.Location = New System.Drawing.Point(103, 55)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(115, 20)
        Me.txtSize.TabIndex = 8
        '
        'txtGroupName
        '
        Me.txtGroupName.BackColor = System.Drawing.SystemColors.Control
        Me.txtGroupName.Location = New System.Drawing.Point(103, 90)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(115, 20)
        Me.txtGroupName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Group Name:"
        '
        'txtCounselorName
        '
        Me.txtCounselorName.BackColor = System.Drawing.SystemColors.Control
        Me.txtCounselorName.Location = New System.Drawing.Point(103, 126)
        Me.txtCounselorName.Name = "txtCounselorName"
        Me.txtCounselorName.Size = New System.Drawing.Size(115, 20)
        Me.txtCounselorName.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Counselor Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 269)
        Me.Controls.Add(Me.group1)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "Form1"
        Me.Text = "Camp Group Creator"
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents btnCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents group1 As GroupBox
    Friend WithEvents radTeen As RadioButton
    Friend WithEvents radBear As RadioButton
    Friend WithEvents radBob As RadioButton
    Friend WithEvents radFox As RadioButton
    Friend WithEvents radChip As RadioButton
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCounselorName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGroupName As TextBox
    Friend WithEvents Label3 As Label
End Class
