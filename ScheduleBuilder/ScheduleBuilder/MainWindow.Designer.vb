<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.txtLocNum = New System.Windows.Forms.TextBox()
        Me.txtGroupNum = New System.Windows.Forms.TextBox()
        Me.lblLocNum = New System.Windows.Forms.Label()
        Me.lblGroupNum = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.btnGroup = New System.Windows.Forms.Button()
        Me.btnCreateSched = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLocNum
        '
        Me.txtLocNum.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtLocNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocNum.Location = New System.Drawing.Point(123, 32)
        Me.txtLocNum.Name = "txtLocNum"
        Me.txtLocNum.Size = New System.Drawing.Size(132, 26)
        Me.txtLocNum.TabIndex = 2
        '
        'txtGroupNum
        '
        Me.txtGroupNum.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGroupNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGroupNum.Location = New System.Drawing.Point(124, 66)
        Me.txtGroupNum.Name = "txtGroupNum"
        Me.txtGroupNum.Size = New System.Drawing.Size(132, 26)
        Me.txtGroupNum.TabIndex = 3
        '
        'lblLocNum
        '
        Me.lblLocNum.AutoSize = True
        Me.lblLocNum.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocNum.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLocNum.Location = New System.Drawing.Point(6, 34)
        Me.lblLocNum.Name = "lblLocNum"
        Me.lblLocNum.Size = New System.Drawing.Size(112, 14)
        Me.lblLocNum.TabIndex = 8
        Me.lblLocNum.Text = "Number of Locations:"
        '
        'lblGroupNum
        '
        Me.lblGroupNum.AutoSize = True
        Me.lblGroupNum.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupNum.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblGroupNum.Location = New System.Drawing.Point(17, 68)
        Me.lblGroupNum.Name = "lblGroupNum"
        Me.lblGroupNum.Size = New System.Drawing.Size(101, 14)
        Me.lblGroupNum.TabIndex = 9
        Me.lblGroupNum.Text = "Number of Groups:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLoc)
        Me.GroupBox1.Controls.Add(Me.btnGroup)
        Me.GroupBox1.Controls.Add(Me.txtLocNum)
        Me.GroupBox1.Controls.Add(Me.lblGroupNum)
        Me.GroupBox1.Controls.Add(Me.txtGroupNum)
        Me.GroupBox1.Controls.Add(Me.lblLocNum)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 112)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Populate Schedule Items:"
        '
        'btnLoc
        '
        Me.btnLoc.Location = New System.Drawing.Point(261, 34)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(138, 23)
        Me.btnLoc.TabIndex = 11
        Me.btnLoc.Text = "Create Locations"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'btnGroup
        '
        Me.btnGroup.Location = New System.Drawing.Point(261, 68)
        Me.btnGroup.Name = "btnGroup"
        Me.btnGroup.Size = New System.Drawing.Size(138, 23)
        Me.btnGroup.TabIndex = 10
        Me.btnGroup.Text = "Create Groups"
        Me.btnGroup.UseVisualStyleBackColor = True
        '
        'btnCreateSched
        '
        Me.btnCreateSched.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSched.ForeColor = System.Drawing.Color.Indigo
        Me.btnCreateSched.Location = New System.Drawing.Point(12, 225)
        Me.btnCreateSched.Name = "btnCreateSched"
        Me.btnCreateSched.Size = New System.Drawing.Size(296, 35)
        Me.btnCreateSched.TabIndex = 11
        Me.btnCreateSched.Text = "Create Schedule"
        Me.btnCreateSched.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Indigo
        Me.btnExit.Location = New System.Drawing.Point(314, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 35)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ScheduleBuilder.My.Resources.Resources.ylogo
        Me.PictureBox1.Location = New System.Drawing.Point(314, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 185)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(296, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Select Group to Schedule:"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(429, 328)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreateSched)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "MainWindow"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLocNum As TextBox
    Friend WithEvents txtGroupNum As TextBox
    Friend WithEvents lblLocNum As Label
    Friend WithEvents lblGroupNum As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnGroup As Button
    Friend WithEvents btnCreateSched As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
