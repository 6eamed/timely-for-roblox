Public Class Form2
    Public Property FILE_NAME As String   'declare all the variables
    Dim p() As Process
    Dim fileReader As String
    Dim timeVar As Integer
    Dim thisSessionVAR As Integer
    Dim hoursplayed As Double
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkForProcess.Start() 'start timer

        Me.saveTitle.Text = ("Save file: " & FILE_NAME) 'change the textbox to show the save file that is selected

        checkTime.Start() 'start the checkTime timer lol

        thisSessionVAR = 0 'set the thisSessionVAR to 0

        thisSession.Text = ("You've played for " & thisSessionVAR & " minutes on this session.") 'change the label text at the start, because the timer will update it every 1 min
    End Sub

    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName(Form1.whatVersion) 'process name
        If p.Count > 0 Then 'if the process is running
            Me.processStatus.Text = "Process: Running, " & "Version: " & Form1.whatVersion 'change the label
            minutes.Start() 'start the counter
            thisSessionTime.Start() 'start the counter
        Else
            Me.processStatus.Text = "Process: Not running" 'change label 
            minutes.Stop() 'stop the counter
            thisSessionTime.Stop() 'stop the counter
        End If
    End Sub

    ' Adreanna says I love you.

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then    'Some random code I got from the Internet so the form moves idk how it works LOL
            m.Result = HTCAPTION
        End If
    End Sub

    Private Sub checkForProcess_Tick(sender As Object, e As EventArgs) Handles checkForProcess.Tick
        CheckIfRunning() 'run the function
        fileReader = My.Computer.FileSystem.ReadAllText(FILE_NAME) 'Will put this here, since making another timer is pointless. (make the fileReader var equal the value from the save file)
    End Sub

    Private Sub checkTime_Tick(sender As Object, e As EventArgs) Handles checkTime.Tick
        hoursplayed = fileReader / 60 'make the variable "hoursplayed" equal fileReader but divided by 60 so we can get hours instead of mins.
        timePlayed.Text = ("You've played for " & fileReader & " minutes.") 'change the label text.
        timePlayedHRS.Text = ("You've played for " & hoursplayed.ToString("0.0") & " hours.") 'change label text and shorten the decimal.
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End 'end the program lol
    End Sub

    Private Sub minutes_Tick(sender As Object, e As EventArgs) Handles minutes.Tick
        timeVar = fileReader.ToString() 'make the timeVar equal fileReader but convert it to String
        timeVar = timeVar + 1 ' add 1 to timevar with each tick 
        My.Computer.FileSystem.WriteAllText(FILE_NAME, "", False) 'clear the save, so we dont get multiple numbers like (100101102)
        My.Computer.FileSystem.WriteAllText(FILE_NAME, timeVar, True) 'update the save
    End Sub

    Private Sub thisSessionTime_Tick(sender As Object, e As EventArgs) Handles thisSessionTime.Tick
        thisSessionVAR = thisSessionVAR + 1 'add 1 to thisSessionVAR
        thisSession.Text = ("You've played for " & thisSessionVAR & " minutes on this session.") 'change the label
        overlayLabel.Text = (thisSessionVAR & " min.") 'change the label
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
            Me.Size = New Size(89, 32)
            overlayLabel.Text = (thisSessionVAR & " min.")

            overlayLabel.Visible = True
            'ALL OF THIS IS SELF EXPLANATORY.
            saveTitle.Visible = False
            processStatus.Visible = False
            thisSession.Visible = False
            timePlayed.Visible = False

        ElseIf CheckBox1.Checked = False Then

            Me.TopMost = False
            overlayLabel.Visible = False
            Me.Size = New Size(319, 157)

            saveTitle.Visible = True
            processStatus.Visible = True
            thisSession.Visible = True
            timePlayed.Visible = True

        End If
    End Sub

End Class