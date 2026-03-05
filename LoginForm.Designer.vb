<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        panelMain = New Panel()
        linkRegister = New LinkLabel()
        btnBack = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        txtUsername = New TextBox()
        jj = New Label()
        lblRole = New Label()
        PictureBox1 = New PictureBox()
        panelShadow = New Panel()
        panelMain.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.Anchor = AnchorStyles.None
        panelMain.BackColor = Color.WhiteSmoke
        panelMain.Controls.Add(linkRegister)
        panelMain.Controls.Add(btnBack)
        panelMain.Controls.Add(btnLogin)
        panelMain.Controls.Add(txtPassword)
        panelMain.Controls.Add(Label1)
        panelMain.Controls.Add(txtUsername)
        panelMain.Controls.Add(jj)
        panelMain.Controls.Add(lblRole)
        panelMain.Controls.Add(PictureBox1)
        panelMain.Location = New Point(250, 110)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(375, 500)
        panelMain.TabIndex = 3
        ' 
        ' linkRegister
        ' 
        linkRegister.LinkBehavior = LinkBehavior.HoverUnderline
        linkRegister.Location = New Point(0, 475)
        linkRegister.Name = "linkRegister"
        linkRegister.Size = New Size(375, 15)
        linkRegister.TabIndex = 10
        linkRegister.TabStop = True
        linkRegister.Text = "Don't have an account yet? Click here"
        linkRegister.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.ForestGreen
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(98, 422)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(180, 40)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.ForestGreen
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(98, 369)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(180, 40)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 14F)
        txtPassword.Location = New Point(62, 317)
        txtPassword.MaxLength = 5
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(250, 32)
        txtPassword.TabIndex = 8
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.25F)
        Label1.Location = New Point(59, 284)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 23)
        Label1.TabIndex = 7
        Label1.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 14F)
        txtUsername.Location = New Point(65, 242)
        txtUsername.MaxLength = 454
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(250, 30)
        txtUsername.TabIndex = 6
        ' 
        ' jj
        ' 
        jj.AutoSize = True
        jj.Font = New Font("Segoe UI", 12.25F)
        jj.Location = New Point(62, 209)
        jj.Name = "jj"
        jj.Size = New Size(70, 23)
        jj.TabIndex = 5
        jj.Text = "User ID:"
        ' 
        ' lblRole
        ' 
        lblRole.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(-1, 157)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(375, 40)
        lblRole.TabIndex = 3
        lblRole.Text = "LOG IN"
        lblRole.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(125, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' panelShadow
        ' 
        panelShadow.Anchor = AnchorStyles.None
        panelShadow.BackColor = Color.DimGray
        panelShadow.Location = New Point(276, 136)
        panelShadow.Name = "panelShadow"
        panelShadow.Size = New Size(375, 500)
        panelShadow.TabIndex = 2
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(900, 600)
        Controls.Add(panelMain)
        Controls.Add(panelShadow)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        WindowState = FormWindowState.Maximized
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents lblRole As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelShadow As Panel
    Friend WithEvents jj As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents linkRegister As LinkLabel
End Class
