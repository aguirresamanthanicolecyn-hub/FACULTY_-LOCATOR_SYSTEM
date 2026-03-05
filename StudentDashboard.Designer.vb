<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentDashboard))
        panelHeader = New Panel()
        btnLogout = New Button()
        lblWelcome = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnIAT = New Button()
        btnPS = New Button()
        btnCOE = New Button()
        btnCCJE = New Button()
        btnCBM = New Button()
        btnCCS = New Button()
        btnSAS = New Button()
        panelHeader.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackgroundImage = CType(resources.GetObject("panelHeader.BackgroundImage"), Image)
        panelHeader.BackgroundImageLayout = ImageLayout.Stretch
        panelHeader.Controls.Add(btnLogout)
        panelHeader.Controls.Add(lblWelcome)
        panelHeader.Controls.Add(PictureBox1)
        panelHeader.Controls.Add(Panel2)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(904, 110)
        panelHeader.TabIndex = 1
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
        ' btnIAT
        ' 
        btnIAT.Anchor = AnchorStyles.None
        btnIAT.BackColor = Color.Green
        btnIAT.FlatStyle = FlatStyle.Flat
        btnIAT.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnIAT.ForeColor = Color.Black
        btnIAT.Location = New Point(692, 424)
        btnIAT.Name = "btnIAT"
        btnIAT.Size = New Size(220, 84)
        btnIAT.TabIndex = 22
        btnIAT.Text = "Institute of Agricultural Technology"
        btnIAT.UseVisualStyleBackColor = False
        ' 
        ' btnPS
        ' 
        btnPS.Anchor = AnchorStyles.None
        btnPS.BackColor = Color.Gray
        btnPS.FlatStyle = FlatStyle.Flat
        btnPS.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnPS.ForeColor = Color.Black
        btnPS.Location = New Point(207, 234)
        btnPS.Name = "btnPS"
        btnPS.Size = New Size(179, 84)
        btnPS.TabIndex = 18
        btnPS.Text = "Polytechnic School" & vbCrLf
        btnPS.UseVisualStyleBackColor = False
        ' 
        ' btnCOE
        ' 
        btnCOE.Anchor = AnchorStyles.None
        btnCOE.BackColor = Color.CornflowerBlue
        btnCOE.FlatStyle = FlatStyle.Flat
        btnCOE.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnCOE.ForeColor = Color.Black
        btnCOE.Location = New Point(542, 234)
        btnCOE.Name = "btnCOE"
        btnCOE.Size = New Size(183, 84)
        btnCOE.TabIndex = 20
        btnCOE.Text = "College of Education"
        btnCOE.UseVisualStyleBackColor = False
        ' 
        ' btnCCJE
        ' 
        btnCCJE.Anchor = AnchorStyles.None
        btnCCJE.BackColor = Color.Red
        btnCCJE.FlatStyle = FlatStyle.Flat
        btnCCJE.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnCCJE.ForeColor = Color.Black
        btnCCJE.Location = New Point(48, 425)
        btnCCJE.Name = "btnCCJE"
        btnCCJE.Size = New Size(182, 84)
        btnCCJE.TabIndex = 19
        btnCCJE.Text = "College of Criminal Justice Education" & vbCrLf
        btnCCJE.UseVisualStyleBackColor = False
        ' 
        ' btnCBM
        ' 
        btnCBM.Anchor = AnchorStyles.None
        btnCBM.BackColor = Color.Yellow
        btnCBM.FlatStyle = FlatStyle.Flat
        btnCBM.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnCBM.ForeColor = Color.Black
        btnCBM.Location = New Point(-111, 234)
        btnCBM.Name = "btnCBM"
        btnCBM.Size = New Size(203, 84)
        btnCBM.TabIndex = 17
        btnCBM.Text = "College of Business and Management"
        btnCBM.UseVisualStyleBackColor = False
        ' 
        ' btnCCS
        ' 
        btnCCS.Anchor = AnchorStyles.None
        btnCCS.BackColor = Color.Violet
        btnCCS.FlatStyle = FlatStyle.Flat
        btnCCS.Font = New Font("Segoe UI Black", 10.25F, FontStyle.Bold)
        btnCCS.ForeColor = Color.Black
        btnCCS.Location = New Point(347, 425)
        btnCCS.Name = "btnCCS"
        btnCCS.Size = New Size(235, 84)
        btnCCS.TabIndex = 21
        btnCCS.Text = "College of Computing Studies, Information and Communication Technology"
        btnCCS.UseVisualStyleBackColor = False
        ' 
        ' btnSAS
        ' 
        btnSAS.Anchor = AnchorStyles.None
        btnSAS.BackColor = Color.Purple
        btnSAS.FlatStyle = FlatStyle.Flat
        btnSAS.Font = New Font("Segoe UI Black", 12.25F, FontStyle.Bold)
        btnSAS.ForeColor = Color.Black
        btnSAS.Location = New Point(838, 234)
        btnSAS.Name = "btnSAS"
        btnSAS.Size = New Size(179, 84)
        btnSAS.TabIndex = 23
        btnSAS.Text = "School of Arts and Sciences"
        btnSAS.UseVisualStyleBackColor = False
        ' 
        ' StudentDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(904, 604)
        Controls.Add(btnSAS)
        Controls.Add(btnIAT)
        Controls.Add(btnPS)
        Controls.Add(btnCOE)
        Controls.Add(btnCCJE)
        Controls.Add(btnCBM)
        Controls.Add(btnCCS)
        Controls.Add(panelHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "StudentDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentDashboard"
        WindowState = FormWindowState.Maximized
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnPS As Button
    Friend WithEvents panelInstructors As Panel
    Friend WithEvents lblDepartmentTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvInstructors As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCOE As Button
    Friend WithEvents btnCBM As Button
    Friend WithEvents btnIAT As Button
    Friend WithEvents btnCCS As Button
    Friend WithEvents btnSAS As Button
    Friend WithEvents btnCCJE As Button
End Class
