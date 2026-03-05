<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApprovalForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvApproval = New DataGridView()
        btnAccept = New Button()
        btnReject = New Button()
        panelBorder = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        chkSelectAll = New CheckBox()
        CType(dgvApproval, ComponentModel.ISupportInitialize).BeginInit()
        panelBorder.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvApproval
        ' 
        dgvApproval.AllowUserToAddRows = False
        dgvApproval.AllowUserToDeleteRows = False
        dgvApproval.BackgroundColor = SystemColors.Control
        dgvApproval.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvApproval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvApproval.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApproval.Dock = DockStyle.Top
        dgvApproval.EnableHeadersVisualStyles = False
        dgvApproval.Location = New Point(0, 0)
        dgvApproval.Margin = New Padding(20, 20, 20, 0)
        dgvApproval.Name = "dgvApproval"
        dgvApproval.ReadOnly = True
        dgvApproval.ScrollBars = ScrollBars.Vertical
        dgvApproval.Size = New Size(863, 343)
        dgvApproval.TabIndex = 0
        ' 
        ' btnAccept
        ' 
        btnAccept.Anchor = AnchorStyles.Bottom
        btnAccept.BackColor = Color.ForestGreen
        btnAccept.FlatStyle = FlatStyle.Flat
        btnAccept.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold)
        btnAccept.ForeColor = Color.White
        btnAccept.Location = New Point(275, 6)
        btnAccept.Name = "btnAccept"
        btnAccept.Size = New Size(76, 33)
        btnAccept.TabIndex = 7
        btnAccept.Text = "ACCEPT"
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnReject.BackColor = Color.ForestGreen
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold)
        btnReject.ForeColor = Color.White
        btnReject.Location = New Point(508, 6)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(76, 33)
        btnReject.TabIndex = 8
        btnReject.Text = "REJECT"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' panelBorder
        ' 
        panelBorder.Anchor = AnchorStyles.None
        panelBorder.BackColor = Color.ForestGreen
        panelBorder.Controls.Add(Panel1)
        panelBorder.Location = New Point(12, 42)
        panelBorder.Name = "panelBorder"
        panelBorder.Padding = New Padding(15, 0, 0, 0)
        panelBorder.Size = New Size(880, 410)
        panelBorder.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(dgvApproval)
        Panel1.Location = New Point(9, 9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(863, 393)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(chkSelectAll)
        Panel2.Controls.Add(btnAccept)
        Panel2.Controls.Add(btnReject)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 346)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(863, 47)
        Panel2.TabIndex = 1
        ' 
        ' chkSelectAll
        ' 
        chkSelectAll.AutoSize = True
        chkSelectAll.Location = New Point(16, 16)
        chkSelectAll.Name = "chkSelectAll"
        chkSelectAll.Size = New Size(74, 19)
        chkSelectAll.TabIndex = 9
        chkSelectAll.Text = "Select All"
        chkSelectAll.UseVisualStyleBackColor = True
        ' 
        ' ApprovalForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(904, 494)
        Controls.Add(panelBorder)
        FormBorderStyle = FormBorderStyle.None
        Name = "ApprovalForm"
        StartPosition = FormStartPosition.Manual
        Text = "ApprovalForm"
        CType(dgvApproval, ComponentModel.ISupportInitialize).EndInit()
        panelBorder.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvApproval As DataGridView
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents panelBorder As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkSelectAll As CheckBox
End Class
