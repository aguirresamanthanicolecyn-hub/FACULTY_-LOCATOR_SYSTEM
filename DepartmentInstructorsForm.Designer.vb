<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentInstructorsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartmentInstructorsForm))
        panelHeader = New Panel()
        btnBack = New Button()
        btnLogout = New Button()
        lblDepartmentTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        panelBody = New Panel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        dgvInstructors = New DataGridView()
        panelHeader.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelBody.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvInstructors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackgroundImage = CType(resources.GetObject("panelHeader.BackgroundImage"), Image)
        panelHeader.BackgroundImageLayout = ImageLayout.Stretch
        panelHeader.Controls.Add(btnBack)
        panelHeader.Controls.Add(btnLogout)
        panelHeader.Controls.Add(lblDepartmentTitle)
        panelHeader.Controls.Add(PictureBox1)
        panelHeader.Controls.Add(Panel2)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(904, 110)
        panelHeader.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBack.BackColor = Color.ForestGreen
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(758, 52)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(76, 33)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.ForestGreen
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(1511, 50)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(76, 33)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' lblDepartmentTitle
        ' 
        lblDepartmentTitle.AutoSize = True
        lblDepartmentTitle.BackColor = Color.Transparent
        lblDepartmentTitle.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartmentTitle.ForeColor = Color.White
        lblDepartmentTitle.Location = New Point(129, 53)
        lblDepartmentTitle.Name = "lblDepartmentTitle"
        lblDepartmentTitle.Size = New Size(154, 32)
        lblDepartmentTitle.TabIndex = 5
        lblDepartmentTitle.Text = "Department"
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
        ' panelBody
        ' 
        panelBody.Controls.Add(Panel1)
        panelBody.Dock = DockStyle.Fill
        panelBody.Location = New Point(0, 110)
        panelBody.Name = "panelBody"
        panelBody.Size = New Size(904, 494)
        panelBody.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 494)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BackColor = Color.ForestGreen
        Panel3.Controls.Add(dgvInstructors)
        Panel3.Location = New Point(70, 54)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(765, 386)
        Panel3.TabIndex = 1
        ' 
        ' dgvInstructors
        ' 
        dgvInstructors.AllowUserToAddRows = False
        dgvInstructors.AllowUserToDeleteRows = False
        dgvInstructors.AllowUserToResizeColumns = False
        dgvInstructors.AllowUserToResizeRows = False
        dgvInstructors.Anchor = AnchorStyles.None
        dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInstructors.BackgroundColor = Color.WhiteSmoke
        dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInstructors.Location = New Point(8, 8)
        dgvInstructors.MultiSelect = False
        dgvInstructors.Name = "dgvInstructors"
        dgvInstructors.ReadOnly = True
        dgvInstructors.RowHeadersVisible = False
        dgvInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInstructors.Size = New Size(748, 371)
        dgvInstructors.TabIndex = 0
        ' 
        ' DepartmentInstructorsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(904, 604)
        Controls.Add(panelBody)
        Controls.Add(panelHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "DepartmentInstructorsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DepartmentInstructorsForm"
        WindowState = FormWindowState.Maximized
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelBody.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(dgvInstructors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblDepartmentTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents panelBody As Panel
    Friend WithEvents dgvInstructors As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
