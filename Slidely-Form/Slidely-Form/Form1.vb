Public Class Form1
    Private Sub btnViewSubmission_Click(sender As Object, e As EventArgs) Handles btnViewSubmission.Click
        Dim viewSubmissionsForm As New ViewSubmission()
        viewSubmissionsForm.Show()

    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim SubmissionForm As New SubmissionForm()

        ' Show the new submission form
        SubmissionForm.Show()

    End Sub

End Class
