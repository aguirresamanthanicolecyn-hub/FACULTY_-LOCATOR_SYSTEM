Public Class RoleSelectionForm

    Private Sub RoleSelectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True

        panelMain.Left = (Me.ClientSize.Width - panelMain.Width) \ 2
        panelMain.Top = (Me.ClientSize.Height - panelMain.Height) \ 2

        panelShadow.Left = panelMain.Left + 10
        panelShadow.Top = panelMain.Top + 10

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim login As New LoginForm()
        login.Tag = "Admin"
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnInstructor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        Dim login As New LoginForm()
        login.Tag = "Instructor"
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim login As New LoginForm()
        login.Tag = "Student"
        login.Show()
        Me.Hide()
    End Sub

End Class