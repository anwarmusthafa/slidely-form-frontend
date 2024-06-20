<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblCreateFormTitle = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        lblName = New Label()
        Label1 = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtStopWatch = New TextBox()
        btnStopWatchToggle = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' lblCreateFormTitle
        ' 
        lblCreateFormTitle.AutoSize = True
        lblCreateFormTitle.Location = New Point(38, 23)
        lblCreateFormTitle.Name = "lblCreateFormTitle"
        lblCreateFormTitle.Size = New Size(381, 20)
        lblCreateFormTitle.TabIndex = 0
        lblCreateFormTitle.Text = "Musthafa Anwar K P , Slidely Task 2 - Create Submissions"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ButtonHighlight
        txtName.Location = New Point(131, 68)
        txtName.Name = "txtName"
        txtName.Size = New Size(267, 27)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ButtonHighlight
        txtEmail.Location = New Point(131, 125)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(267, 27)
        txtEmail.TabIndex = 2
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ButtonHighlight
        txtPhone.Location = New Point(131, 182)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(267, 27)
        txtPhone.TabIndex = 3
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.ButtonHighlight
        txtGithubLink.Location = New Point(131, 239)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(267, 27)
        txtGithubLink.TabIndex = 4
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(31, 75)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 5
        lblName.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 6
        Label1.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(31, 182)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 40)
        lblPhone.TabIndex = 7
        lblPhone.Text = "Phone" & vbCrLf & "Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(31, 239)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(87, 40)
        lblGithubLink.TabIndex = 9
        lblGithubLink.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.BackColor = Color.LightGray
        txtStopWatch.Location = New Point(255, 306)
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.ReadOnly = True
        txtStopWatch.Size = New Size(143, 27)
        txtStopWatch.TabIndex = 12
        ' 
        ' btnStopWatchToggle
        ' 
        btnStopWatchToggle.BackColor = Color.Khaki
        btnStopWatchToggle.Location = New Point(31, 306)
        btnStopWatchToggle.Name = "btnStopWatchToggle"
        btnStopWatchToggle.Size = New Size(218, 32)
        btnStopWatchToggle.TabIndex = 10
        btnStopWatchToggle.Text = "Toggle Stop Watch (CTRL + T)"
        btnStopWatchToggle.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SkyBlue
        btnSubmit.Location = New Point(38, 368)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(342, 47)
        btnSubmit.TabIndex = 13
        btnSubmit.Text = "SUBMIT (CRTL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' SubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 450)
        Controls.Add(btnSubmit)
        Controls.Add(txtStopWatch)
        Controls.Add(btnStopWatchToggle)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(Label1)
        Controls.Add(lblName)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblCreateFormTitle)
        Name = "SubmissionForm"
        Text = "SubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCreateFormTitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents btnStopWatchToggle As Button
    Friend WithEvents btnSubmit As Button
End Class
