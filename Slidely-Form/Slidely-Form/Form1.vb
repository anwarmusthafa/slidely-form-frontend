Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        Me.Focus()
    End Sub
    Private Sub btnViewSubmission_Click(sender As Object, e As EventArgs) Handles btnViewSubmission.Click
        Dim viewSubmissionsForm As New ViewSubmission()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim submissionForm As New SubmissionForm()
        submissionForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmission.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

End Class
