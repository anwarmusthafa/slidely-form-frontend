<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmission = New Button()
        btnCreateNewSubmission = New Button()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmission
        ' 
        btnViewSubmission.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnViewSubmission.Location = New Point(12, 94)
        btnViewSubmission.Name = "btnViewSubmission"
        btnViewSubmission.Size = New Size(392, 43)
        btnViewSubmission.TabIndex = 0
        btnViewSubmission.Text = "VIEW SUBMISSIONS (CRTL + V)"
        btnViewSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = SystemColors.InactiveCaption
        btnCreateNewSubmission.Location = New Point(12, 152)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(392, 43)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CRTL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(24, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(371, 20)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Musthafa Anwar K P . Slidely Task 2 -Slidely Form App  "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 228)
        Controls.Add(lblTitle)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmission)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmission As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents lblTitle As Label

End Class
