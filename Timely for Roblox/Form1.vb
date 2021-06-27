Imports System.IO
Imports System.Net

Public Class Form1
    Dim fileReader As String

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim address As String = "https://6eamed.xyz/timely/version.txt"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label8.Text = ("The latest version is: " & reader.ReadToEnd & " | You are running: 1.0.3.1")
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
End Class
