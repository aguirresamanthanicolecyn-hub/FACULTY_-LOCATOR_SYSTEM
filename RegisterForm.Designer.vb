<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        panelMain = New Panel()
        cmbDepartment = New ComboBox()
        Label6 = New Label()
        txtConfirmPassword = New TextBox()
        Label5 = New Label()
        txtPassword = New TextBox()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtLastName = New TextBox()
        linkLogin = New LinkLabel()
        btnRegister = New Button()
        txtFirstName = New TextBox()
        Label1 = New Label()
        txtUserID = New TextBox()
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
        panelMain.Controls.Add(cmbDepartment)
        panelMain.Controls.Add(Label6)
        panelMain.Controls.Add(txtConfirmPassword)
        panelMain.Controls.Add(Label5)
        panelMain.Controls.Add(txtPassword)
        panelMain.Controls.Add(Label4)
        panelMain.Controls.Add(txtEmail)
        panelMain.Controls.Add(Label3)
        panelMain.Controls.Add(Label2)
        panelMain.Controls.Add(txtLastName)
        panelMain.Controls.Add(linkLogin)
        panelMain.Controls.Add(btnRegister)
        panelMain.Controls.Add(txtFirstName)
        panelMain.Controls.Add(Label1)
        panelMain.Controls.Add(txtUserID)
        panelMain.Controls.Add(jj)
        panelMain.Controls.Add(lblRole)
        panelMain.Controls.Add(PictureBox1)
        panelMain.Location = New Point(249, 63)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(375, 662)
        panelMain.TabIndex = 5
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDepartment.Font = New Font("Segoe UI", 14F)
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Items.AddRange(New Object() {"College of Business and Management", "College of Education", "College of Computing Studies, Information and Communication Technology", "College of Criminal Justice Education", "School of Arts and Sciences", "Polytechnic School", "Institute of Agricultural Technology"})
        cmbDepartment.Location = New Point(42, 358)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(296, 33)
        cmbDepartment.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.25F)
        Label6.Location = New Point(40, 332)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 23)
        Label6.TabIndex = 19
        Label6.Text = "Department:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 14F)
        txtConfirmPassword.Location = New Point(40, 550)
        txtConfirmPassword.MaxLength = 5
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(296, 32)
        txtConfirmPassword.TabIndex = 18
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.25F)
        Label5.Location = New Point(38, 524)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 23)
        Label5.TabIndex = 17
        Label5.Text = "Confirm Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 14F)
        txtPassword.Location = New Point(40, 482)
        txtPassword.MaxLength = 5
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(296, 32)
        txtPassword.TabIndex = 16
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.25F)
        Label4.Location = New Point(40, 456)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 23)
        Label4.TabIndex = 15
        Label4.Text = "Password:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 14F)
        txtEmail.Location = New Point(39, 417)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(296, 30)
        txtEmail.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.25F)
        Label3.Location = New Point(40, 391)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 23)
        Label3.TabIndex = 13
        Label3.Text = "Email Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.25F)
        Label2.Location = New Point(195, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 23)
        Label2.TabIndex = 12
        Label2.Text = "Last Name:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 14F)
        txtLastName.Location = New Point(195, 287)
        txtLastName.Multiline = True
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(143, 30)
        txtLastName.TabIndex = 11
        txtLastName.UseSystemPasswordChar = True
        ' 
        ' linkLogin
        ' 
        linkLogin.LinkBehavior = LinkBehavior.HoverUnderline
        linkLogin.Location = New Point(0, 638)
        linkLogin.Name = "linkLogin"
        linkLogin.Size = New Size(375, 15)
        linkLogin.TabIndex = 10
        linkLogin.TabStop = True
        linkLogin.Text = "Already have an account? Sign in" & vbCrLf
        linkLogin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.ForestGreen
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(94, 591)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(180, 40)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 14F)
        txtFirstName.Location = New Point(42, 287)
        txtFirstName.Multiline = True
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(145, 30)
        txtFirstName.TabIndex = 8
        txtFirstName.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.25F)
        Label1.Location = New Point(42, 261)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 23)
        Label1.TabIndex = 7
        Label1.Text = "First Name:"
        ' 
        ' txtUserID
        ' 
        txtUserID.Font = New Font("Segoe UI", 14F)
        txtUserID.Location = New Point(42, 223)
        txtUserID.Multiline = True
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(296, 30)
        txtUserID.TabIndex = 6
        ' 
        ' jj
        ' 
        jj.AutoSize = True
        jj.Font = New Font("Segoe UI", 12.25F)
        jj.Location = New Point(40, 197)
        jj.Name = "jj"
        jj.Size = New Size(70, 23)
        jj.TabIndex = 5
        jj.Text = "User ID:"
        ' 
        ' lblRole
        ' 
        lblRole.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(0, 157)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(375, 40)
        lblRole.TabIndex = 3
        lblRole.Text = "REGISTRATION"
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
        panelShadow.Location = New Point(275, 114)
        panelShadow.Name = "panelShadow"
        panelShadow.Size = New Size(375, 662)
        panelShadow.TabIndex = 4
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(900, 749)
        Controls.Add(panelMain)
        Controls.Add(panelShadow)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterForm"
        WindowState = FormWindowState.Maximized
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents linkLogin As LinkLabel
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents jj As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelShadow As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents Label6 As Label
End Class
