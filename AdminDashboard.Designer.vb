<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Panel1 = New Panel()
        lblNotifCount = New Label()
        btnNotification = New Button()
        lblWelcome = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnLogout = New Button()
        panelAdminContainer = New Panel()
        panelMainMenu = New Panel()
        panelDepartments = New Panel()
        btnIAT = New Button()
        btnPS = New Button()
        btnCED = New Button()
        btnCCJE = New Button()
        btnCBM = New Button()
        btnCCSICT = New Button()
        btnSAS = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelAdminContainer.SuspendLayout()
        panelMainMenu.SuspendLayout()
        panelDepartments.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(lblNotifCount)
        Panel1.Controls.Add(btnNotification)
        Panel1.Controls.Add(lblWelcome)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 110)
        Panel1.TabIndex = 1
        ' 
        ' lblNotifCount
        ' 
        lblNotifCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblNotifCount.BackColor = Color.Transparent
        lblNotifCount.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNotifCount.ForeColor = Color.Red
        lblNotifCount.ImageAlign = ContentAlignment.TopRight
        lblNotifCount.Location = New Point(779, 37)
        lblNotifCount.Name = "lblNotifCount"
        lblNotifCount.Size = New Size(22, 22)
        lblNotifCount.TabIndex = 8
        lblNotifCount.Text = "5"
        lblNotifCount.TextAlign = ContentAlignment.TopRight
        lblNotifCount.Visible = False
        ' 
        ' btnNotification
        ' 
        btnNotification.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNotification.BackColor = Color.White
        btnNotification.BackgroundImage = CType(resources.GetObject("btnNotification.BackgroundImage"), Image)
        btnNotification.BackgroundImageLayout = ImageLayout.Zoom
        btnNotification.Location = New Point(738, 48)
        btnNotification.Name = "btnNotification"
        btnNotification.Size = New Size(52, 37)
        btnNotification.TabIndex = 7
        btnNotification.UseVisualStyleBackColor = False
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
        lblWelcome.TabIndex = 5
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
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(904, 20)
        Panel2.TabIndex = 1
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
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' panelAdminContainer
        ' 
        panelAdminContainer.Controls.Add(panelMainMenu)
        panelAdminContainer.Dock = DockStyle.Fill
        panelAdminContainer.Location = New Point(0, 110)
        panelAdminContainer.Name = "panelAdminContainer"
        panelAdminContainer.Size = New Size(904, 494)
        panelAdminContainer.TabIndex = 7
        ' 
        ' panelMainMenu
        ' 
        panelMainMenu.Controls.Add(panelDepartments)
        panelMainMenu.Dock = DockStyle.Fill
        panelMainMenu.Location = New Point(0, 0)
        panelMainMenu.Name = "panelMainMenu"
        panelMainMenu.Size = New Size(904, 494)
        panelMainMenu.TabIndex = 0
        ' 
        ' panelDepartments
        ' 
        panelDepartments.Anchor = AnchorStyles.None
        panelDepartments.Controls.Add(btnIAT)
        panelDepartments.Controls.Add(btnPS)
        panelDepartments.Controls.Add(btnCED)
        panelDepartments.Controls.Add(btnCCJE)
        panelDepartments.Controls.Add(btnCBM)
        panelDepartments.Controls.Add(btnCCSICT)
        panelDepartments.Controls.Add(btnSAS)
        panelDepartments.Location = New Point(-93, 0)
        panelDepartments.Name = "panelDepartments"
        panelDepartments.Size = New Size(1170, 494)
        panelDepartments.TabIndex = 16
        ' 
        ' btnIAT
        ' 
        btnIAT.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnIAT.BackColor = Color.Green
        btnIAT.FlatStyle = FlatStyle.Flat
        btnIAT.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnIAT.ForeColor = Color.Black
        btnIAT.Location = New Point(806, 300)
        btnIAT.Name = "btnIAT"
        btnIAT.Size = New Size(220, 84)
        btnIAT.TabIndex = 16
        btnIAT.Text = "Institute of Agricultural Technology"
        btnIAT.UseVisualStyleBackColor = False
        ' 
        ' btnPS
        ' 
        btnPS.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPS.BackColor = Color.Gray
        btnPS.FlatStyle = FlatStyle.Flat
        btnPS.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnPS.ForeColor = Color.Black
        btnPS.Location = New Point(321, 110)
        btnPS.Name = "btnPS"
        btnPS.Size = New Size(179, 84)
        btnPS.TabIndex = 10
        btnPS.Text = "Polytechnic School" & vbCrLf
        btnPS.UseVisualStyleBackColor = False
        ' 
        ' btnCED
        ' 
        btnCED.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCED.BackColor = Color.CornflowerBlue
        btnCED.FlatStyle = FlatStyle.Flat
        btnCED.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnCED.ForeColor = Color.Black
        btnCED.Location = New Point(656, 110)
        btnCED.Name = "btnCED"
        btnCED.Size = New Size(183, 84)
        btnCED.TabIndex = 13
        btnCED.Text = "College of Education"
        btnCED.UseVisualStyleBackColor = False
        ' 
        ' btnCCJE
        ' 
        btnCCJE.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCCJE.BackColor = Color.Red
        btnCCJE.FlatStyle = FlatStyle.Flat
        btnCCJE.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnCCJE.ForeColor = Color.Black
        btnCCJE.Location = New Point(162, 301)
        btnCCJE.Name = "btnCCJE"
        btnCCJE.Size = New Size(182, 84)
        btnCCJE.TabIndex = 11
        btnCCJE.Text = "College of Criminal Justice Education" & vbCrLf
        btnCCJE.UseVisualStyleBackColor = False
        ' 
        ' btnCBM
        ' 
        btnCBM.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCBM.BackColor = Color.Yellow
        btnCBM.FlatStyle = FlatStyle.Flat
        btnCBM.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnCBM.ForeColor = Color.Black
        btnCBM.Location = New Point(3, 110)
        btnCBM.Name = "btnCBM"
        btnCBM.Size = New Size(203, 84)
        btnCBM.TabIndex = 9
        btnCBM.Text = "College of Business and Management"
        btnCBM.UseVisualStyleBackColor = False
        ' 
        ' btnCCSICT
        ' 
        btnCCSICT.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCCSICT.BackColor = Color.Violet
        btnCCSICT.FlatStyle = FlatStyle.Flat
        btnCCSICT.Font = New Font("Segoe UI Black", 10.25F, FontStyle.Bold)
        btnCCSICT.ForeColor = Color.Black
        btnCCSICT.Location = New Point(461, 301)
        btnCCSICT.Name = "btnCCSICT"
        btnCCSICT.Size = New Size(235, 84)
        btnCCSICT.TabIndex = 15
        btnCCSICT.Text = "College of Computing Studies, Information and Communication Technology"
        btnCCSICT.UseVisualStyleBackColor = False
        ' 
        ' btnSAS
        ' 
        btnSAS.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSAS.BackColor = Color.Purple
        btnSAS.FlatStyle = FlatStyle.Flat
        btnSAS.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnSAS.ForeColor = Color.Black
        btnSAS.Location = New Point(973, 110)
        btnSAS.Name = "btnSAS"
        btnSAS.Size = New Size(179, 84)
        btnSAS.TabIndex = 14
        btnSAS.Text = "School of Arts and Sciences"
        btnSAS.UseVisualStyleBackColor = False
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(904, 604)
        Controls.Add(panelAdminContainer)
        Controls.Add(btnLogout)
        Controls.Add(Panel1)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminDashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelAdminContainer.ResumeLayout(False)
        panelMainMenu.ResumeLayout(False)
        panelDepartments.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNotification As Button
    Friend WithEvents panelAdminContainer As Panel
    Friend WithEvents panelMainMenu As Panel
    Friend WithEvents btnCBM As Button
    Friend WithEvents lblNotifCount As Label
    Friend WithEvents btnCCJE As Button
    Friend WithEvents btnPS As Button
    Friend WithEvents btnCED As Button
    Friend WithEvents btnSAS As Button
    Friend WithEvents btnCCSICT As Button
    Friend WithEvents panelDepartments As Panel
    Friend WithEvents btnIAT As Button
End Class
