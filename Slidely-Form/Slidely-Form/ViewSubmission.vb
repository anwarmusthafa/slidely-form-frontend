Imports System.ComponentModel.DataAnnotations
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmission
    Private submissions As List(Of GetSubmission)
    Private baseURL As String = "http://localhost:3000"
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            submissions = Await FetchSubmissionsAsync()
            DisplaySubmission()
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching submissions: " & ex.Message)
        End Try
    End Sub

    Private Async Function FetchSubmissionsAsync() As Task(Of List(Of GetSubmission))
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"{baseURL}/read")
                response.EnsureSuccessStatusCode()
                Dim content As String = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of List(Of GetSubmission))(content)
            Catch ex As HttpRequestException
                MessageBox.Show("Request error: " & ex.Message)
                Return New List(Of GetSubmission)()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
                Return New List(Of GetSubmission)()
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As GetSubmission = submissions(currentIndex)
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGithubLink.Text = submission.github_link
            txtStopWatch.Text = submission.stopwatch_time
        Else
            MessageBox.Show("No submissions to display.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        Else
            MessageBox.Show("Already at the last submission.")
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        Else
            MessageBox.Show("Already at the first submission.")
        End If
    End Sub


End Class

Public Class GetSubmission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
