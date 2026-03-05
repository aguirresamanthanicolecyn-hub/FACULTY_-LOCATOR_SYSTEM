Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class AdminDashboard
    Public loggedInAdminFullName As String
    Private userFormInstance As UserForm
    Private approvalForm As ApprovalForm
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
    Public Sub SetUserName(firstName As String, lastName As String)

        ' Save full name for audit log
        loggedInAdminFullName = firstName & " " & lastName

        ' Display sa welcome label
        lblWelcome.Text = "Welcome! " & lastName & ", " & firstName

    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        btnNotification.Controls.Add(lblNotifCount)
        lblNotifCount.AutoSize = True
        lblNotifCount.BringToFront()

        ' Create once
        approvalForm = New ApprovalForm(Me)
        approvalForm.TopLevel = False
        approvalForm.FormBorderStyle = FormBorderStyle.None
        approvalForm.Dock = DockStyle.Fill
        approvalForm.StartPosition = FormStartPosition.Manual

        panelAdminContainer.Controls.Add(approvalForm)
        approvalForm.Hide()

        LoadNotificationCount()
        CenterDepartments()

    End Sub
    Private Sub CenterDepartments()

        panelDepartments.Left = (panelAdminContainer.Width - panelDepartments.Width) \ 2
        panelDepartments.Top = (panelAdminContainer.Height - panelDepartments.Height) \ 2

    End Sub

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterDepartments()
    End Sub

    ' =========================================
    ' OPEN USERS FORM
    ' =========================================
    Private Sub OpenUsersForm(dept As String)

        panelDepartments.Visible = False

        ' Create once
        If userFormInstance Is Nothing Then

            userFormInstance = New UserForm
            userFormInstance.parentDashboard = Me
            userFormInstance.TopLevel = False
            userFormInstance.FormBorderStyle = FormBorderStyle.None
            userFormInstance.Dock = DockStyle.Fill

            panelAdminContainer.Controls.Add(userFormInstance)

        End If

        ' Update department properly
        userFormInstance.selectedDepartment = dept
        userFormInstance.UpdateTitle()   ' 👈 IMPORTANT

        userFormInstance.BringToFront()
        userFormInstance.Show()

    End Sub

    ' =========================================
    ' DEPARTMENT BUTTONS
    ' =========================================
    Private Sub btnCBM_Click(sender As Object, e As EventArgs) Handles btnCBM.Click
        OpenUsersForm("College of Business and Management")
    End Sub

    Private Sub btnPS_Click(sender As Object, e As EventArgs) Handles btnPS.Click
        OpenUsersForm("Polytechnic School")
    End Sub

    Private Sub btnIAT_Click(sender As Object, e As EventArgs) Handles btnIAT.Click
        OpenUsersForm("Institute of Agricultural Technology")
    End Sub

    Private Sub btnCCSICT_Click(sender As Object, e As EventArgs) Handles btnCCSICT.Click
        OpenUsersForm("College of Computing Studies, Information and Communication Technology")
    End Sub

    Private Sub btnCCJE_Click(sender As Object, e As EventArgs) Handles btnCCJE.Click
        OpenUsersForm("College of Criminal Justice Education")
    End Sub

    Private Sub btnSAS_Click(sender As Object, e As EventArgs) Handles btnSAS.Click
        OpenUsersForm("School of Arts and Sciences")
    End Sub

    Private Sub btnCED_Click(sender As Object, e As EventArgs) Handles btnCED.Click
        OpenUsersForm("College of Education")
    End Sub

    ' =========================================
    ' NOTIFICATION BUTTON (FIXED)
    ' =========================================
    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click

        If approvalForm.Visible = False Then

            panelDepartments.Visible = False
            approvalForm.Show()
            approvalForm.BringToFront()

        Else

            approvalForm.Hide()
            panelDepartments.Visible = True

        End If

    End Sub

    Public Sub ShowDepartments()

        approvalForm.Hide()
        panelDepartments.Visible = True

    End Sub

    ' =========================================
    ' LOGOUT
    ' =========================================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim roleForm As New RoleSelectionForm()
            roleForm.Show()
            Me.Close()
        End If

    End Sub

    ' =========================================
    ' LOAD NOTIFICATION COUNT
    ' =========================================
    Public Sub LoadNotificationCount()

        Try
            DBConnection.OpenConnection()

            Dim query As String = "SELECT COUNT(*) FROM users WHERE is_approved = 0"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            DBConnection.CloseConnection()

            If count > 0 Then
                lblNotifCount.Text = count.ToString()
                lblNotifCount.Visible = True
                lblNotifCount.Location = New Point(btnNotification.Width - lblNotifCount.Width, -3)
            Else
                lblNotifCount.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading notifications: " & ex.Message)
        End Try

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class