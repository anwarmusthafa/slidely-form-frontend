﻿Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class SubmissionForm
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        Me.Focus()
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
                    ' Clear form fields or perform other actions upon successful submission
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
        txtStopWatch.Text = ""
    End Sub

    ' 
    Private Sub SubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
            e.SuppressKeyPress = True
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
