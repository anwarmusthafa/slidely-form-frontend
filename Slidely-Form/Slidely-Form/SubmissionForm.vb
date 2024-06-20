Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text
Imports System.Windows.Forms

Public Class SubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private elapsedTime As TimeSpan
    Private stopwatchTimer As Timer

    Private baseURL As String = "http://localhost:3000"
    Private submission As Submission

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        Me.Focus()
        InitializeStopwatch()
        InitializeForm()
    End Sub

    Public Sub New(existingSubmission As Submission)
        InitializeComponent()
        Me.KeyPreview = True
        Me.Focus()
        InitializeStopwatch()
        InitializeForm(existingSubmission)
    End Sub

    Private Sub InitializeForm(Optional existingSubmission As Submission = Nothing)
        submission = If(existingSubmission, New Submission())
        PopulateFormFields()
    End Sub

    Private Sub PopulateFormFields()
        txtName.Text = submission.name
        txtEmail.Text = submission.email
        txtPhone.Text = submission.phone
        txtGithubLink.Text = submission.github_link
        txtStopWatch.Text = submission.stopwatch_time
    End Sub

    Private Sub InitializeStopwatch()
        stopwatchTimer = New Timer()
        AddHandler stopwatchTimer.Tick, AddressOf UpdateStopwatch
        stopwatchTimer.Interval = 1000
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Await SubmitForm()
    End Sub

    Private Async Function SubmitForm() As Task
        Try
            submission.name = txtName.Text
            submission.email = txtEmail.Text
            submission.phone = txtPhone.Text
            submission.github_link = txtGithubLink.Text
            submission.stopwatch_time = txtStopWatch.Text

            Using client As New HttpClient()
                Dim jsonContent As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage
                If String.IsNullOrEmpty(submission.id) Then
                    response = Await client.PostAsync($"{baseURL}/submit", content)
                Else
                    response = Await client.PutAsync($"{baseURL}/update/{submission.id}", content)
                End If

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission Successful!")
                    ClearFormFields()
                Else
                    MessageBox.Show("Submission Failed!")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while submitting the form: " & ex.Message)
        End Try
    End Function

    Private Sub ClearFormFields()
        submission = New Submission()
        PopulateFormFields()
    End Sub

    Private Sub ResetStopwatch()
        stopwatchRunning = False
        elapsedTime = TimeSpan.Zero
        stopwatchTimer.Stop()
        txtStopWatch.Text = "00:00:00"
    End Sub

    Private Sub SubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            e.SuppressKeyPress = True
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopWatchToggle.PerformClick()
        End If
    End Sub

    Private Sub btnStopWatchToggle_Click(sender As Object, e As EventArgs) Handles btnStopWatchToggle.Click
        If Not stopwatchRunning Then
            StartStopwatch()
        Else
            StopStopwatch()
        End If
    End Sub

    Private Sub StartStopwatch()
        stopwatchRunning = True
        stopwatchStartTime = DateTime.Now - elapsedTime
        stopwatchTimer.Start()
    End Sub

    Private Sub StopStopwatch()
        stopwatchRunning = False
        elapsedTime = DateTime.Now - stopwatchStartTime
        stopwatchTimer.Stop()
    End Sub

    Private Sub UpdateStopwatch(sender As Object, e As EventArgs)
        If stopwatchRunning Then
            Dim currentTime As TimeSpan = DateTime.Now - stopwatchStartTime
            txtStopWatch.Text = String.Format("{0:00}:{1:00}:{2:00}", currentTime.Hours, currentTime.Minutes, currentTime.Seconds)
        End If
    End Sub
End Class

Public Class Submission
    Public Property id As String
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
