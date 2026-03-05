<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorDashboard
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructorDashboard))
        Panel1 = New Panel()
        btnLogout = New Button()
        lblWelcome = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        panelHistory = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        dgvHistory = New DataGridView()
        grpStatus = New GroupBox()
        btnSubmitStatus = New Button()
        rbTravel = New RadioButton()
        dtTo = New DateTimePicker()
        rbLeave = New RadioButton()
        Label2 = New Label()
        rbOut = New RadioButton()
        Label1 = New Label()
        rbIn = New RadioButton()
        dtFrom = New DateTimePicker()
        panelStatusBorder = New Panel()
        Panel4 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelHistory.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        grpStatus.SuspendLayout()
        panelStatusBorder.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(lblWelcome)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 110)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.ForestGreen
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(807, 50)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(76, 33)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(129, 53)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(131, 32)
        lblWelcome.TabIndex = 4
        lblWelcome.Text = "Welcome!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(85, 81)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(904, 20)
        Panel2.TabIndex = 1
        ' 
        ' panelHistory
        ' 
        panelHistory.Anchor = AnchorStyles.None
        panelHistory.BackColor = Color.WhiteSmoke
        panelHistory.Controls.Add(Panel3)
        panelHistory.Controls.Add(dgvHistory)
        panelHistory.Location = New Point(10, 11)
        panelHistory.Name = "panelHistory"
        panelHistory.Size = New Size(568, 357)
        panelHistory.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(566, 46)
        Panel3.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(210, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 25)
        Label3.TabIndex = 8
        Label3.Text = "STATUS HISTORY"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvHistory
        ' 
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.AllowUserToDeleteRows = False
        dgvHistory.BackgroundColor = Color.WhiteSmoke
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Location = New Point(0, 46)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.ReadOnly = True
        dgvHistory.Size = New Size(568, 311)
        dgvHistory.TabIndex = 8
        ' 
        ' grpStatus
        ' 
        grpStatus.Anchor = AnchorStyles.None
        grpStatus.BackColor = Color.WhiteSmoke
        grpStatus.Controls.Add(Label4)
        grpStatus.Controls.Add(btnSubmitStatus)
        grpStatus.Controls.Add(rbTravel)
        grpStatus.Controls.Add(dtTo)
        grpStatus.Controls.Add(rbLeave)
        grpStatus.Controls.Add(Label2)
        grpStatus.Controls.Add(rbOut)
        grpStatus.Controls.Add(Label1)
        grpStatus.Controls.Add(rbIn)
        grpStatus.Controls.Add(dtFrom)
        grpStatus.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpStatus.Location = New Point(9, 11)
        grpStatus.Name = "grpStatus"
        grpStatus.Size = New Size(303, 357)
        grpStatus.TabIndex = 1
        grpStatus.TabStop = False
        ' 
        ' btnSubmitStatus
        ' 
        btnSubmitStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSubmitStatus.BackColor = Color.ForestGreen
        btnSubmitStatus.FlatStyle = FlatStyle.Flat
        btnSubmitStatus.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold)
        btnSubmitStatus.ForeColor = Color.White
        btnSubmitStatus.Location = New Point(206, 304)
        btnSubmitStatus.Name = "btnSubmitStatus"
        btnSubmitStatus.Size = New Size(76, 33)
        btnSubmitStatus.TabIndex = 6
        btnSubmitStatus.Text = "Submit"
        btnSubmitStatus.UseVisualStyleBackColor = False
        ' 
        ' rbTravel
        ' 
        rbTravel.AutoSize = True
        rbTravel.Location = New Point(64, 177)
        rbTravel.Name = "rbTravel"
        rbTravel.Size = New Size(105, 24)
        rbTravel.TabIndex = 3
        rbTravel.TabStop = True
        rbTravel.Text = "ON TRAVEL"
        rbTravel.UseVisualStyleBackColor = True
        ' 
        ' dtTo
        ' 
        dtTo.Format = DateTimePickerFormat.Custom
        dtTo.Location = New Point(81, 258)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(200, 27)
        dtTo.TabIndex = 5
        ' 
        ' rbLeave
        ' 
        rbLeave.AutoSize = True
        rbLeave.Location = New Point(64, 141)
        rbLeave.Name = "rbLeave"
        rbLeave.Size = New Size(96, 24)
        rbLeave.TabIndex = 2
        rbLeave.TabStop = True
        rbLeave.Text = "ON LEAVE"
        rbLeave.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 263)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 20)
        Label2.TabIndex = 4
        Label2.Text = "To:"
        ' 
        ' rbOut
        ' 
        rbOut.AutoSize = True
        rbOut.Location = New Point(64, 104)
        rbOut.Name = "rbOut"
        rbOut.Size = New Size(57, 24)
        rbOut.TabIndex = 1
        rbOut.TabStop = True
        rbOut.Text = "OUT"
        rbOut.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 234)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "From:"
        ' 
        ' rbIn
        ' 
        rbIn.AutoSize = True
        rbIn.ForeColor = Color.Black
        rbIn.Location = New Point(64, 67)
        rbIn.Name = "rbIn"
        rbIn.Size = New Size(43, 24)
        rbIn.TabIndex = 0
        rbIn.TabStop = True
        rbIn.Text = "IN"
        rbIn.UseVisualStyleBackColor = True
        ' 
        ' dtFrom
        ' 
        dtFrom.Format = DateTimePickerFormat.Custom
        dtFrom.Location = New Point(81, 229)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(200, 27)
        dtFrom.TabIndex = 3
        ' 
        ' panelStatusBorder
        ' 
        panelStatusBorder.Anchor = AnchorStyles.None
        panelStatusBorder.BackColor = Color.ForestGreen
        panelStatusBorder.Controls.Add(grpStatus)
        panelStatusBorder.Location = New Point(-86, 160)
        panelStatusBorder.Name = "panelStatusBorder"
        panelStatusBorder.Size = New Size(321, 379)
        panelStatusBorder.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.None
        Panel4.BackColor = Color.ForestGreen
        Panel4.Controls.Add(panelHistory)
        Panel4.Location = New Point(376, 160)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(589, 379)
        Panel4.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold)
        Label4.ForeColor = Color.ForestGreen
        Label4.Location = New Point(8, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 25)
        Label4.TabIndex = 9
        Label4.Text = "STATUS:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' InstructorDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(904, 604)
        Controls.Add(panelStatusBorder)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "InstructorDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InstructorDashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelHistory.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        grpStatus.ResumeLayout(False)
        grpStatus.PerformLayout()
        panelStatusBorder.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents panelHistory As Panel
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents btnSubmitStatus As Button
    Friend WithEvents rbTravel As RadioButton
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents rbLeave As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rbOut As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rbIn As RadioButton
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents panelStatusBorder As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
End Class
