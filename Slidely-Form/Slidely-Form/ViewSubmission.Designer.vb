<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmission
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
        lblGithubLink = New Label()
        lblPhone = New Label()
        Label1 = New Label()
        lblName = New Label()
        txtGithubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        lblViewFormTitle = New Label()
        btnNext = New Button()
        btnPrev = New Button()
        txtStopWatch = New TextBox()
        lblStopWatch = New Label()
        SuspendLayout()
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(43, 248)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(87, 40)
        lblGithubLink.TabIndex = 21
        lblGithubLink.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(43, 191)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 40)
        lblPhone.TabIndex = 20
        lblPhone.Text = "Phone" & vbCrLf & "Num"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 19
        Label1.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(43, 84)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 18
        lblName.Text = "Name"
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.LightGray
        txtGithubLink.Location = New Point(143, 248)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(267, 27)
        txtGithubLink.TabIndex = 17
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.LightGray
        txtPhone.Location = New Point(143, 191)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(267, 27)
        txtPhone.TabIndex = 16
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.LightGray
        txtEmail.Location = New Point(143, 134)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(267, 27)
        txtEmail.TabIndex = 15
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.LightGray
        txtName.Location = New Point(143, 77)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(267, 27)
        txtName.TabIndex = 14
        ' 
        ' lblViewFormTitle
        ' 
        lblViewFormTitle.AutoSize = True
        lblViewFormTitle.Location = New Point(43, 28)
        lblViewFormTitle.Name = "lblViewFormTitle"
        lblViewFormTitle.Size = New Size(370, 20)
        lblViewFormTitle.TabIndex = 13
        lblViewFormTitle.Text = "Musthafa Anwar K P , Slidely Task 2 - View Submissions"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SkyBlue
        btnNext.Location = New Point(241, 389)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(178, 33)
        btnNext.TabIndex = 25
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = Color.Khaki
        btnPrev.Location = New Point(43, 389)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(192, 33)
        btnPrev.TabIndex = 24
        btnPrev.Text = "PREVIOUS (CTRL + P)"
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.BackColor = Color.LightGray
        txtStopWatch.Location = New Point(143, 320)
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.ReadOnly = True
        txtStopWatch.Size = New Size(267, 27)
        txtStopWatch.TabIndex = 23
        ' 
        ' lblStopWatch
        ' 
        lblStopWatch.AutoSize = True
        lblStopWatch.Location = New Point(43, 320)
        lblStopWatch.Name = "lblStopWatch"
        lblStopWatch.Size = New Size(85, 40)
        lblStopWatch.TabIndex = 22
        lblStopWatch.Text = "Stop Watch" & vbCrLf & "    Time"
        ' 
        ' ViewSubmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrev)
        Controls.Add(txtStopWatch)
        Controls.Add(lblStopWatch)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(Label1)
        Controls.Add(lblName)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblViewFormTitle)
        Name = "ViewSubmission"
        Text = "ViewSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblViewFormTitle As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents lblStopWatch As Label
End Class
