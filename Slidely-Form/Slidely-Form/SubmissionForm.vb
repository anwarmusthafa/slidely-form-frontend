Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class SubmissionForm
    Private submission As GetSubmission
    Private baseURL As String = "http://localhost:3000"

    Public Sub New()
        InitializeComponent()
        ' Initialize as new submission
        Me.Text = "Create Submission"
        btnSubmit.Text = "Create"
    End Sub

    Public Sub New(existingSubmission As GetSubmission)
        InitializeComponent()
        ' Initialize for editing existing submission
        Me.Text = "Edit Submission"
        btnSubmit.Text = "Update"
        submission = existingSubmission
        PopulateFormFields()
    End Sub

    Private Sub PopulateFormFields()
        If submission IsNot Nothing Then
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGithubLink.Text = submission.github_link
            txtStopWatch.Text = submission.stopwatch_time
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If submission Is Nothing Then
            Await CreateNewSubmissionAsync()
        Else
            Await UpdateSubmissionAsync()
        End If
    End Sub

    Private Async Function CreateNewSubmissionAsync() As Task
        Dim newSubmission As New GetSubmission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = txtStopWatch.Text
        }

        Using client As New HttpClient()
            Try
                Dim jsonContent As String = JsonConvert.SerializeObject(newSubmission)
                Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync($"{baseURL}/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission created successfully!")
                    Me.Close()
                Else
                    MessageBox.Show("Failed to create submission.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while creating submission: " & ex.Message)
            End Try
        End Using
    End Function

    Private Async Function UpdateSubmissionAsync() As Task
        If submission IsNot Nothing Then
            submission.name = txtName.Text
            submission.email = txtEmail.Text
            submission.phone = txtPhone.Text
            submission.github_link = txtGithubLink.Text
            submission.stopwatch_time = txtStopWatch.Text

            Using client As New HttpClient()
                Try
                    Dim jsonContent As String = JsonConvert.SerializeObject(submission)
                    Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")
                    Dim response As HttpResponseMessage = Await client.PutAsync($"{baseURL}/update/{submission.id}", content)

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission updated successfully!")
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to update submission.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while updating submission: " & ex.Message)
                End Try
            End Using
        End If
    End Function
End Class


Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
