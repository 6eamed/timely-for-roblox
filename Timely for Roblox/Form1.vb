Imports System.IO
Imports System.Net

Public Class Form1
    Dim fileReader As String
    Public whatVersion As String

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim address As String = "https://6eamed.xyz/timely/version.txt" 'Get version from server
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address)) 'Copy the string from /timely/version.txt and put in the the reader var
        Label8.Text = ("The latest version is: " & reader.ReadToEnd & " | You are running: 1.0.4.0")

        Dim filePaths = Directory.GetFiles(CurDir, "*.6eamed")
        Dim fileNames = Array.ConvertAll(filePaths, Function(s) Path.GetFileName(s)) 'Get only the filename, without the path.

        ListBox1.Items.AddRange(fileNames)

        whatVersion = "RobloxPlayerBeta" 'Set the default process to RobloxPlayerBeta.

    End Sub


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then
            m.Result = HTCAPTION
        End If
    End Sub
    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim FILE_NAME As String 'FILE NAME will be a string
        FILE_NAME = (nameBox.Text & ".6eamed") ' we will give the value to the variable from the textbox


        If nameBox.Text = "Enter name" Then
            MsgBox("Invalid name")
        Else

            If System.IO.File.Exists(FILE_NAME) Then 'next we will check if the file exists
                MsgBox("This file already exists") 'if the file exists, let the user know
            Else
                File.Create(nameBox.Text & ".6eamed").Dispose() 'if not, create the file
                My.Computer.FileSystem.WriteAllText(FILE_NAME, "0", True)
                fileReader = My.Computer.FileSystem.ReadAllText(FILE_NAME) '?
                MsgBox("Save has been created.")
            End If

        End If


    End Sub



    Public Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim FILE_NAME As String 'FILE NAME will be a string
        FILE_NAME = (nameBox.Text & ".6eamed") ' we will give the value to the variable from the textbox
        Form2.FILE_NAME = FILE_NAME
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        End
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim FILE_NAME As String 'FILE NAME will be a string
        FILE_NAME = (nameBox.Text & ".6eamed") ' we will give the value to the variable from the textbox
        Form2.FILE_NAME = FILE_NAME
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim FILE_NAME As String 'FILE NAME will be a string
        FILE_NAME = (nameBox.Text & ".6eamed") ' we will give the value to the variable from the textbox


        If nameBox.Text = "Enter name" Then
            MsgBox("Invalid name")
        Else

            If System.IO.File.Exists(FILE_NAME) Then 'next we will check if the file exists
                MsgBox("This file already exists") 'if the file exists, let the user know
            Else
                File.Create(nameBox.Text & ".6eamed").Dispose() 'if not, create the file
                My.Computer.FileSystem.WriteAllText(FILE_NAME, "0", True)
                fileReader = My.Computer.FileSystem.ReadAllText(FILE_NAME) '?
                MsgBox("Save has been created.")
            End If

        End If


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        nameBox.Clear()

        For Each Item As Object In ListBox1.SelectedItems
            Dim filewithextension As String = (Item.ToString + Environment.NewLine) 'get the file name and put it into filewithoutextension
            Dim filewithoutextension As String = filewithextension.Replace(".6eamed", vbNullString) 'get filewithoutextension and remove .6eamed, there has to be an easier way to do this but fuck off
            nameBox.Text = filewithoutextension.Trim '.Trim removes the invisible character
        Next

    End Sub


    Private Sub versionCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles versionCheckBox.CheckedChanged
        If versionCheckBox.Checked Then
            whatVersion = "Windows10Universal"
        Else
            whatVersion = "RobloxPlayerBeta"
        End If
    End Sub

    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles InfoButton.Click
        MsgBox("Use this ONLY IF you're using the Microsoft Store version of ROBLOX.")
    End Sub
End Class
