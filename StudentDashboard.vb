Public Class StudentDashboard

    Public Sub SetUserName(firstName As String, lastName As String)
        lblWelcome.Text = "Welcome! " & lastName & ", " & firstName
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?",
                                                     "Confirm Logout",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim roleForm As New RoleSelectionForm()
            roleForm.Show()
            Me.Close()
        End If

    End Sub


    Private Sub OpenDepartment(deptName As String)

        Dim deptForm As New DepartmentInstructorsForm(deptName)

        deptForm.Owner = Me
        deptForm.Show()
        Me.Hide()

    End Sub


    Private Sub btnCBM_Click(sender As Object, e As EventArgs) Handles btnCBM.Click
        OpenDepartment("College of Business and Management")
    End Sub

    Private Sub btnCOE_Click(sender As Object, e As EventArgs) Handles btnCOE.Click
        OpenDepartment("College of Education")
    End Sub

    Private Sub btnCCJE_Click(sender As Object, e As EventArgs) Handles btnCCJE.Click, btnCCJE.Click
        OpenDepartment("College of Criminal Justice Education")
    End Sub

    Private Sub btnIAT_Click(sender As Object, e As EventArgs) Handles btnIAT.Click, btnIAT.Click
        OpenDepartment("Institute of Agriculture Technology")
    End Sub

    Private Sub btnSAS_Click(sender As Object, e As EventArgs) Handles btnSAS.Click
        OpenDepartment("School of Arts and Sciences")
    End Sub

    Private Sub btnCCS_Click(sender As Object, e As EventArgs) Handles btnCCS.Click, btnCCS.Click
        OpenDepartment("College of Computing Studies, Information and Communication Technology")
    End Sub

    Private Sub btnPS_Click(sender As Object, e As EventArgs) Handles btnPS.Click
        OpenDepartment("Polytechnic School")
    End Sub

End Class