<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationCreator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocationCreator))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.group1 = New System.Windows.Forms.GroupBox()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBear = New System.Windows.Forms.RadioButton()
        Me.radTeen = New System.Windows.Forms.RadioButton()
        Me.radFox = New System.Windows.Forms.RadioButton()
        Me.radBob = New System.Windows.Forms.RadioButton()
        Me.radChip = New System.Windows.Forms.RadioButton()
        Me.btnCreateGroup = New System.Windows.Forms.Button()
        Me.btnGroupExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Indigo
        Me.Label6.Location = New System.Drawing.Point(43, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Group Creator"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Indigo
        Me.Label5.Location = New System.Drawing.Point(13, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cherokee Outdoor Y"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(206, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'group1
        '
        Me.group1.Controls.Add(Me.txtGroupName)
        Me.group1.Controls.Add(Me.Label3)
        Me.group1.Controls.Add(Me.txtSize)
        Me.group1.Controls.Add(Me.Label2)
        Me.group1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group1.ForeColor = System.Drawing.Color.Indigo
        Me.group1.Location = New System.Drawing.Point(18, 121)
        Me.group1.Name = "group1"
        Me.group1.Size = New System.Drawing.Size(236, 120)
        Me.group1.TabIndex = 9
        Me.group1.TabStop = False
        Me.group1.Text = "Location Information:"
        '
        'txtGroupName
        '
        Me.txtGroupName.BackColor = System.Drawing.SystemColors.Control
        Me.txtGroupName.Location = New System.Drawing.Point(112, 72)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(115, 26)
        Me.txtGroupName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Location Name:"
        '
        'txtSize
        '
        Me.txtSize.BackColor = System.Drawing.SystemColors.Control
        Me.txtSize.Location = New System.Drawing.Point(112, 24)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(115, 26)
        Me.txtSize.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Max Size:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBear)
        Me.GroupBox1.Controls.Add(Me.radTeen)
        Me.GroupBox1.Controls.Add(Me.radFox)
        Me.GroupBox1.Controls.Add(Me.radBob)
        Me.GroupBox1.Controls.Add(Me.radChip)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox1.Location = New System.Drawing.Point(266, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 149)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Age Group (Select Lowest):"
        '
        'radBear
        '
        Me.radBear.AutoSize = True
        Me.radBear.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBear.ForeColor = System.Drawing.Color.RoyalBlue
        Me.radBear.Location = New System.Drawing.Point(16, 96)
        Me.radBear.Name = "radBear"
        Me.radBear.Size = New System.Drawing.Size(48, 18)
        Me.radBear.TabIndex = 5
        Me.radBear.TabStop = True
        Me.radBear.Text = "Bear"
        Me.radBear.UseVisualStyleBackColor = True
        '
        'radTeen
        '
        Me.radTeen.AutoSize = True
        Me.radTeen.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTeen.ForeColor = System.Drawing.Color.RoyalBlue
        Me.radTeen.Location = New System.Drawing.Point(16, 120)
        Me.radTeen.Name = "radTeen"
        Me.radTeen.Size = New System.Drawing.Size(48, 18)
        Me.radTeen.TabIndex = 6
        Me.radTeen.TabStop = True
        Me.radTeen.Text = "Teen"
        Me.radTeen.UseVisualStyleBackColor = True
        '
        'radFox
        '
        Me.radFox.AutoSize = True
        Me.radFox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.radFox.Location = New System.Drawing.Point(16, 48)
        Me.radFox.Name = "radFox"
        Me.radFox.Size = New System.Drawing.Size(43, 18)
        Me.radFox.TabIndex = 3
        Me.radFox.TabStop = True
        Me.radFox.Text = "Fox"
        Me.radFox.UseVisualStyleBackColor = True
        '
        'radBob
        '
        Me.radBob.AutoSize = True
        Me.radBob.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBob.ForeColor = System.Drawing.Color.RoyalBlue
        Me.radBob.Location = New System.Drawing.Point(16, 72)
        Me.radBob.Name = "radBob"
        Me.radBob.Size = New System.Drawing.Size(59, 18)
        Me.radBob.TabIndex = 4
        Me.radBob.TabStop = True
        Me.radBob.Text = "Bobcat"
        Me.radBob.UseVisualStyleBackColor = True
        '
        'radChip
        '
        Me.radChip.AutoSize = True
        Me.radChip.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChip.ForeColor = System.Drawing.Color.RoyalBlue
        Me.radChip.Location = New System.Drawing.Point(16, 24)
        Me.radChip.Name = "radChip"
        Me.radChip.Size = New System.Drawing.Size(122, 18)
        Me.radChip.TabIndex = 2
        Me.radChip.TabStop = True
        Me.radChip.Text = "Chipmunk (Default)"
        Me.radChip.UseVisualStyleBackColor = True
        '
        'btnCreateGroup
        '
        Me.btnCreateGroup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateGroup.ForeColor = System.Drawing.Color.Indigo
        Me.btnCreateGroup.Location = New System.Drawing.Point(18, 247)
        Me.btnCreateGroup.Name = "btnCreateGroup"
        Me.btnCreateGroup.Size = New System.Drawing.Size(124, 23)
        Me.btnCreateGroup.TabIndex = 11
        Me.btnCreateGroup.Text = "Create Group"
        Me.btnCreateGroup.UseVisualStyleBackColor = True
        '
        'btnGroupExit
        '
        Me.btnGroupExit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGroupExit.ForeColor = System.Drawing.Color.Indigo
        Me.btnGroupExit.Location = New System.Drawing.Point(148, 247)
        Me.btnGroupExit.Name = "btnGroupExit"
        Me.btnGroupExit.Size = New System.Drawing.Size(106, 23)
        Me.btnGroupExit.TabIndex = 12
        Me.btnGroupExit.Text = "Exit"
        Me.btnGroupExit.UseVisualStyleBackColor = True
        '
        'LocationCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 282)
        Me.Controls.Add(Me.btnGroupExit)
        Me.Controls.Add(Me.btnCreateGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.group1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LocationCreator"
        Me.Text = "LocationCreator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents group1 As GroupBox
    Friend WithEvents txtGroupName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBear As RadioButton
    Friend WithEvents radTeen As RadioButton
    Friend WithEvents radFox As RadioButton
    Friend WithEvents radBob As RadioButton
    Friend WithEvents radChip As RadioButton
    Public WithEvents btnCreateGroup As Button
    Public WithEvents btnGroupExit As Button
End Class
