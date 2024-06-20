Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class SubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private elapsedTime As TimeSpan
    Private stopwatchTimer As Timer

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        Me.Focus()
        stopwatchTimer = New Timer()
        AddHandler stopwatchTimer.Tick, AddressOf UpdateStopwatch
        stopwatchTimer.Interval = 1000
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Await SubmitFormAsync()
    End Sub

    Private Async Function SubmitFormAsync() As Task
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = txtStopWatch.Text
        }

        Using client As New HttpClient()
            Try
                Dim jsonContent As String = JsonConvert.SerializeObject(submission)
                Dim content As StringContent = New StringContent(jsonContent, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission Successful!")
                    ClearFormFields()
                Else
                    MessageBox.Show("Submission Failed!")
                End If
            Catch ex As Exception
                MessageBox.Show("Error submitting form: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub ClearFormFields()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithubLink.Text = ""
        txtStopWatch.Text = "00:00:00"
        ResetStopwatch()
    End Sub

    Private Sub ResetStopwatch()
        stopwatchRunning = False
        elapsedTime = TimeSpan.Zero
        stopwatchTimer.Stop()
        txtStopWatch.Text = "00:00:00"
    End Sub

    Private Sub SubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopWatchToggle.PerformClick()

        End If
    End Sub

    Private Sub btnStopWatchToggle_Click(sender As Object, e As EventArgs) Handles btnStopWatchToggle.Click
        If Not stopwatchRunning Then
            stopwatchRunning = True
            If elapsedTime = TimeSpan.Zero Then
                stopwatchStartTime = DateTime.Now
            Else
                stopwatchStartTime = DateTime.Now - elapsedTime
            End If
            stopwatchTimer.Start()
        Else
            stopwatchRunning = False
            elapsedTime = DateTime.Now - stopwatchStartTime
            stopwatchTimer.Stop()
        End If
    End Sub

    Private Sub UpdateStopwatch(sender As Object, e As EventArgs)
        If stopwatchRunning Then
            Dim currentTime As TimeSpan = DateTime.Now - stopwatchStartTime
            txtStopWatch.Text = String.Format("{0:00}:{1:00}:{2:00}", currentTime.Hours, currentTime.Minutes, currentTime.Seconds)
        End If
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
