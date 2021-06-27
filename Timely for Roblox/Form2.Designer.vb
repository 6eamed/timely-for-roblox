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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minutes = New System.Windows.Forms.Timer(Me.components)
        Me.thisSession = New System.Windows.Forms.Label()
        Me.thisSessionTime = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.overlayLabel = New System.Windows.Forms.Label()
        Me.timePlayedHRS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timePlayed
        '
        Me.timePlayed.AutoSize = True
        Me.timePlayed.BackColor = System.Drawing.Color.Transparent
        Me.timePlayed.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timePlayed.ForeColor = System.Drawing.Color.White
        Me.timePlayed.Location = New System.Drawing.Point(12, 30)
        Me.timePlayed.Name = "timePlayed"
        Me.timePlayed.Size = New System.Drawing.Size(65, 11)
        Me.timePlayed.TabIndex = 5
        Me.timePlayed.Text = "timePlayed"
        '
        'processStatus
        '
        Me.processStatus.AutoSize = True
        Me.processStatus.BackColor = System.Drawing.Color.Transparent
        Me.processStatus.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.processStatus.ForeColor = System.Drawing.Color.White
        Me.processStatus.Location = New System.Drawing.Point(12, 63)
        Me.processStatus.Name = "processStatus"
        Me.processStatus.Size = New System.Drawing.Size(83, 11)
        Me.processStatus.TabIndex = 7
        Me.processStatus.Text = "processStatus"
        '
        'saveTitle
        '
        Me.saveTitle.AutoSize = True
        Me.saveTitle.BackColor = System.Drawing.Color.Transparent
        Me.saveTitle.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveTitle.ForeColor = System.Drawing.Color.White
        Me.saveTitle.Location = New System.Drawing.Point(12, 75)
        Me.saveTitle.Name = "saveTitle"
        Me.saveTitle.Size = New System.Drawing.Size(59, 11)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(103, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 11)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "6eamed.xyz/timely"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(306, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 11)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "x"
        '
        'minutes
        '
        Me.minutes.Interval = 60000
        '
        'thisSession
        '
        Me.thisSession.AutoSize = True
        Me.thisSession.BackColor = System.Drawing.Color.Transparent
        Me.thisSession.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thisSession.ForeColor = System.Drawing.Color.White
        Me.thisSession.Location = New System.Drawing.Point(12, 52)
        Me.thisSession.Name = "thisSession"
        Me.thisSession.Size = New System.Drawing.Size(71, 11)
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
        Me.CheckBox1.Font = New System.Drawing.Font("MS Gothic", 8.25!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(-15, -1)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 15)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Toggle Overlay"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'overlayLabel
        '
        Me.overlayLabel.AutoSize = True
        Me.overlayLabel.BackColor = System.Drawing.Color.Transparent
        Me.overlayLabel.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overlayLabel.ForeColor = System.Drawing.Color.White
        Me.overlayLabel.Location = New System.Drawing.Point(3, 20)
        Me.overlayLabel.Name = "overlayLabel"
        Me.overlayLabel.Size = New System.Drawing.Size(83, 11)
        Me.overlayLabel.TabIndex = 15
        Me.overlayLabel.Text = "Overlay Label"
        Me.overlayLabel.Visible = False
        '
        'timePlayedHRS
        '
        Me.timePlayedHRS.AutoSize = True
        Me.timePlayedHRS.BackColor = System.Drawing.Color.Transparent
        Me.timePlayedHRS.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timePlayedHRS.ForeColor = System.Drawing.Color.White
        Me.timePlayedHRS.Location = New System.Drawing.Point(12, 42)
        Me.timePlayedHRS.Name = "timePlayedHRS"
        Me.timePlayedHRS.Size = New System.Drawing.Size(83, 11)
        Me.timePlayedHRS.TabIndex = 16
        Me.timePlayedHRS.Text = "timePlayedHRS"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Timely_for_Roblox.My.Resources.Resources.RBX
        Me.ClientSize = New System.Drawing.Size(319, 157)
        Me.Controls.Add(Me.timePlayedHRS)
        Me.Controls.Add(Me.overlayLabel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.thisSession)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.saveTitle)
        Me.Controls.Add(Me.processStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.timePlayed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timely"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timePlayed As Label
    Friend WithEvents processStatus As Label
    Friend WithEvents saveTitle As Label
    Friend WithEvents checkForProcess As Timer
    Friend WithEvents checkTime As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents minutes As Timer
    Friend WithEvents thisSession As Label
    Friend WithEvents thisSessionTime As Timer
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents overlayLabel As Label
    Friend WithEvents timePlayedHRS As Label
End Class
