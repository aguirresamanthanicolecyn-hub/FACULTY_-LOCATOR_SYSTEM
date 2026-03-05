

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoleSelectionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoleSelectionForm))
        panelMain = New Panel()
        btnStudent = New Button()
        btnInstructor = New Button()
        btnAdmin = New Button()
        Label2 = New Label()
        Label1 = New Label()
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
        panelMain.Controls.Add(btnStudent)
        panelMain.Controls.Add(btnInstructor)
        panelMain.Controls.Add(btnAdmin)
        panelMain.Controls.Add(Label2)
        panelMain.Controls.Add(Label1)
        panelMain.Controls.Add(PictureBox1)
        panelMain.Location = New Point(250, 110)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(420, 450)
        panelMain.TabIndex = 1
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.ForestGreen
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudent.ForeColor = Color.White
        btnStudent.Location = New Point(91, 374)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(250, 45)
        btnStudent.TabIndex = 6
        btnStudent.Text = "Student"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' btnInstructor
        ' 
        btnInstructor.BackColor = Color.ForestGreen
        btnInstructor.FlatStyle = FlatStyle.Flat
        btnInstructor.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInstructor.ForeColor = Color.White
        btnInstructor.Location = New Point(91, 314)
        btnInstructor.Name = "btnInstructor"
        btnInstructor.Size = New Size(250, 45)
        btnInstructor.TabIndex = 5
        btnInstructor.Text = "Instructor"
        btnInstructor.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.ForestGreen
        btnAdmin.FlatStyle = FlatStyle.Flat
        btnAdmin.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdmin.ForeColor = Color.White
        btnAdmin.Location = New Point(91, 254)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(250, 45)
        btnAdmin.TabIndex = 2
        btnAdmin.Text = "Administrator"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(111, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 30)
        Label2.TabIndex = 4
        Label2.Text = "Cauayan City, Isabela"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(9, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 40)
        Label1.TabIndex = 3
        Label1.Text = "FACULTY STATUS LOCATOR"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(158, 24)
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
        panelShadow.Location = New Point(275, 130)
        panelShadow.Name = "panelShadow"
        panelShadow.Size = New Size(420, 450)
        panelShadow.TabIndex = 2
        ' 
        ' RoleSelectionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(884, 561)
        Controls.Add(panelMain)
        Controls.Add(panelShadow)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "RoleSelectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Faculty Status Locator"
        WindowState = FormWindowState.Maximized
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents panelMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnInstructor As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents panelShadow As Panel

End Class
