<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.timePlayed = New System.Windows.Forms.Label()
        Me.processStatus = New System.Windows.Forms.Label()
        Me.saveTitle = New System.Windows.Forms.Label()
        Me.checkForProcess = New System.Windows.Forms.Timer(Me.components)
        Me.checkTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minutes = New System.Windows.Forms.Timer(Me.components)
        Me.thisSession = New System.Windows.Forms.Label()
        Me.thisSessionTime = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.overlayLabel = New System.Windows.Forms.Label()
        Me.timePlayedHRS = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'timePlayed
        '
        Me.timePlayed.AutoSize = True
        Me.timePlayed.BackColor = System.Drawing.Color.Transparent
        Me.timePlayed.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.timePlayed.ForeColor = System.Drawing.Color.Black
        Me.timePlayed.Location = New System.Drawing.Point(3, 4)
        Me.timePlayed.Name = "timePlayed"
        Me.timePlayed.Size = New System.Drawing.Size(57, 13)
        Me.timePlayed.TabIndex = 5
        Me.timePlayed.Text = "timePlayed"
        '
        'processStatus
        '
        Me.processStatus.AutoSize = True
        Me.processStatus.BackColor = System.Drawing.Color.Transparent
        Me.processStatus.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.processStatus.ForeColor = System.Drawing.Color.Black
        Me.processStatus.Location = New System.Drawing.Point(3, 55)
        Me.processStatus.Name = "processStatus"
        Me.processStatus.Size = New System.Drawing.Size(68, 13)
        Me.processStatus.TabIndex = 7
        Me.processStatus.Text = "processStatus"
        '
        'saveTitle
        '
        Me.saveTitle.AutoSize = True
        Me.saveTitle.BackColor = System.Drawing.Color.Transparent
        Me.saveTitle.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.saveTitle.ForeColor = System.Drawing.Color.Black
        Me.saveTitle.Location = New System.Drawing.Point(3, 72)
        Me.saveTitle.Name = "saveTitle"
        Me.saveTitle.Size = New System.Drawing.Size(46, 13)
        Me.saveTitle.TabIndex = 8
        Me.saveTitle.Text = "saveTitle"
        '
        'checkForProcess
        '
        Me.checkForProcess.Interval = 1
        '
        'checkTime
        '
        Me.checkTime.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(304, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "⨂"
        '
        'minutes
        '
        Me.minutes.Interval = 60000
        '
        'thisSession
        '
        Me.thisSession.AutoSize = True
        Me.thisSession.BackColor = System.Drawing.Color.Transparent
        Me.thisSession.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.thisSession.ForeColor = System.Drawing.Color.Black
        Me.thisSession.Location = New System.Drawing.Point(3, 38)
        Me.thisSession.Name = "thisSession"
        Me.thisSession.Size = New System.Drawing.Size(55, 13)
        Me.thisSession.TabIndex = 13
        Me.thisSession.Text = "thisSession"
        '
        'thisSessionTime
        '
        Me.thisSessionTime.Interval = 60000
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(-16, -1)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(36, 21)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "⎯"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'overlayLabel
        '
        Me.overlayLabel.AutoSize = True
        Me.overlayLabel.BackColor = System.Drawing.Color.Transparent
        Me.overlayLabel.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.overlayLabel.ForeColor = System.Drawing.Color.Black
        Me.overlayLabel.Location = New System.Drawing.Point(18, 3)
        Me.overlayLabel.Name = "overlayLabel"
        Me.overlayLabel.Size = New System.Drawing.Size(69, 13)
        Me.overlayLabel.TabIndex = 15
        Me.overlayLabel.Text = "Overlay Label"
        Me.overlayLabel.Visible = False
        '
        'timePlayedHRS
        '
        Me.timePlayedHRS.AutoSize = True
        Me.timePlayedHRS.BackColor = System.Drawing.Color.Transparent
        Me.timePlayedHRS.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.timePlayedHRS.ForeColor = System.Drawing.Color.Black
        Me.timePlayedHRS.Location = New System.Drawing.Point(3, 21)
        Me.timePlayedHRS.Name = "timePlayedHRS"
        Me.timePlayedHRS.Size = New System.Drawing.Size(75, 13)
        Me.timePlayedHRS.TabIndex = 16
        Me.timePlayedHRS.Text = "timePlayedHRS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-3, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 20)
        Me.Panel1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(113, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "6eamed.xyz/timely"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Timely_for_Roblox.My.Resources.Resources.CLOCK
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(439, 142)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.timePlayed)
        Me.Panel2.Controls.Add(Me.processStatus)
        Me.Panel2.Controls.Add(Me.saveTitle)
        Me.Panel2.Controls.Add(Me.timePlayedHRS)
        Me.Panel2.Controls.Add(Me.thisSession)
        Me.Panel2.Location = New System.Drawing.Point(42, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 107)
        Me.Panel2.TabIndex = 28
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(319, 157)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.overlayLabel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timely"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timePlayed As Label
    Friend WithEvents processStatus As Label
    Friend WithEvents saveTitle As Label
    Friend WithEvents checkForProcess As Timer
    Friend WithEvents checkTime As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents minutes As Timer
    Friend WithEvents thisSession As Label
    Friend WithEvents thisSessionTime As Timer
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents overlayLabel As Label
    Friend WithEvents timePlayedHRS As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
