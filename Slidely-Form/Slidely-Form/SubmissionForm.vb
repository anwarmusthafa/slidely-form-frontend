Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class SubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private elapsedTime As TimeSpan
    Private stopwatchTimer As Timer
    Private isEditMode As Boolean = False
    Private submissionId As String

    Public Sub New(Optional submission As GetSubmission = Nothing)
        InitializeComponent()
        Me.KeyPreview = True
        Me.Focus()
        stopwatchTimer = New Timer()
        AddHandler stopwatchTimer.Tick, AddressOf UpdateStopwatch
        stopwatchTimer.Interval = 1000
        txtStopWatch.Text = "00:00:00"

        If submission IsNot Nothing Then
            isEditMode = True
            submissionId = submission.id
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGithubLink.Text = submission.github_link
            txtStopWatch.Text = submission.stopwatch_time
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If ValidateForm() Then
            If isEditMode Then
                Await EditSubmissionAsync()
            Else
                Await SubmitFormAsync()
            End If
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Check if name is empty
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            errorMessage &= "- Name is required." & vbCrLf
            isValid = False
        End If

        ' Check if email is empty or invalid format (basic format validation)
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            errorMessage &= "- Valid email address is required." & vbCrLf
            isValid = False
        End If

        ' Check if phone number is empty or not numeric (basic numeric validation)
        If String.IsNullOrWhiteSpace(txtPhone.Text) OrElse Not IsNumeric(txtPhone.Text) Then
            errorMessage &= "- Valid phone number is required." & vbCrLf
            isValid = False
        End If

        ' Display error message if validation fails
        If Not isValid Then
            MessageBox.Show("Validation Error:" & vbCrLf & errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

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

    Private Async Function EditSubmissionAsync() As Task
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
                Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/update/{submissionId}", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission Updated Successfully!")
                    Me.Close()
                Else
                    MessageBox.Show("Failed to Update Submission!")
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating submission: " & ex.Message)
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
