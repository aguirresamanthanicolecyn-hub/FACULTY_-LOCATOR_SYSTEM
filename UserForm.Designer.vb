<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        panelBorder = New Panel()
        Panel1 = New Panel()
        panelHistory = New Panel()
        btnCloseHistory = New Button()
        dgvHistory = New DataGridView()
        Panel2 = New Panel()
        lblTitle = New Label()
        btnBack = New Button()
        btnStudent = New Button()
        btnInstructor = New Button()
        btnReject = New Button()
        DataGridView1 = New DataGridView()
        panelBorder.SuspendLayout()
        Panel1.SuspendLayout()
        panelHistory.SuspendLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelBorder
        ' 
        panelBorder.Anchor = AnchorStyles.None
        panelBorder.BackColor = Color.ForestGreen
        panelBorder.Controls.Add(Panel1)
        panelBorder.Location = New Point(12, 12)
        panelBorder.Name = "panelBorder"
        panelBorder.Padding = New Padding(15, 0, 0, 0)
        panelBorder.Size = New Size(880, 405)
        panelBorder.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(panelHistory)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(9, 9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(863, 381)
        Panel1.TabIndex = 9
        ' 
        ' panelHistory
        ' 
        panelHistory.BackColor = SystemColors.Control
        panelHistory.BorderStyle = BorderStyle.FixedSingle
        panelHistory.Controls.Add(btnCloseHistory)
        panelHistory.Controls.Add(dgvHistory)
        panelHistory.Dock = DockStyle.Fill
        panelHistory.Location = New Point(0, 63)
        panelHistory.Name = "panelHistory"
        panelHistory.Size = New Size(863, 318)
        panelHistory.TabIndex = 2
        panelHistory.Visible = False
        ' 
        ' btnCloseHistory
        ' 
        btnCloseHistory.BackColor = Color.Red
        btnCloseHistory.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseHistory.Location = New Point(818, 5)
        btnCloseHistory.Name = "btnCloseHistory"
        btnCloseHistory.Size = New Size(27, 23)
        btnCloseHistory.TabIndex = 0
        btnCloseHistory.Text = "X"
        btnCloseHistory.UseVisualStyleBackColor = False
        ' 
        ' dgvHistory
        ' 
        dgvHistory.BackgroundColor = SystemColors.Control
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Dock = DockStyle.Fill
        dgvHistory.Location = New Point(0, 0)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.Size = New Size(861, 316)
        dgvHistory.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(lblTitle)
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnStudent)
        Panel2.Controls.Add(btnInstructor)
        Panel2.Controls.Add(btnReject)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(863, 63)
        Panel2.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold)
        lblTitle.ForeColor = Color.ForestGreen
        lblTitle.Location = New Point(86, 2)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(558, 62)
        lblTitle.TabIndex = 6
        lblTitle.Text = "Department"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.BackgroundImageLayout = ImageLayout.Zoom
        btnBack.Font = New Font("Segoe UI", 9F)
        btnBack.Location = New Point(19, 14)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(65, 38)
        btnBack.TabIndex = 2
        btnBack.TextImageRelation = TextImageRelation.ImageAboveText
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnStudent.BackColor = Color.ForestGreen
        btnStudent.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudent.ForeColor = Color.White
        btnStudent.Location = New Point(763, 16)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(83, 30)
        btnStudent.TabIndex = 11
        btnStudent.Text = "Student"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' btnInstructor
        ' 
        btnInstructor.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnInstructor.BackColor = Color.ForestGreen
        btnInstructor.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInstructor.ForeColor = Color.White
        btnInstructor.Location = New Point(654, 16)
        btnInstructor.Name = "btnInstructor"
        btnInstructor.Size = New Size(91, 32)
        btnInstructor.TabIndex = 10
        btnInstructor.Text = "Instructor"
        btnInstructor.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnReject.BackColor = Color.ForestGreen
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold)
        btnReject.ForeColor = Color.White
        btnReject.Location = New Point(1171, 6)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(76, 33)
        btnReject.TabIndex = 8
        btnReject.Text = "REJECT"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 63)
        DataGridView1.Margin = New Padding(20, 20, 20, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.Size = New Size(863, 318)
        DataGridView1.TabIndex = 0
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(904, 494)
        Controls.Add(panelBorder)
        FormBorderStyle = FormBorderStyle.None
        Name = "UserForm"
        StartPosition = FormStartPosition.Manual
        Text = " "
        panelBorder.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        panelHistory.ResumeLayout(False)
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelBorder As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReject As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCloseHistory As Button
    Friend WithEvents btnInstructor As Button
    Friend WithEvents panelHistory As Panel
    Friend WithEvents dgvHistory As DataGridView
End Class
