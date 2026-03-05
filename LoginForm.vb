Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim role As String = Me.Tag.ToString()
        Dim displayRole As String = role

        If role = "Admin" Then
            displayRole = "Administrator"
        End If

        lblRole.Text = displayRole.ToUpper() & " LOGIN"
        linkRegister.Text = "Don't have an account yet? Register as " & displayRole
    End Sub

    Private Sub linkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister.LinkClicked

        Dim reg As New RegisterForm()
        reg.Tag = Me.Tag
        reg.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        RoleSelectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Please enter User ID and Password.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter User ID.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Please enter Password.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            DBConnection.OpenConnection()

            ' Step 1: Check if account exists
            Dim checkQuery As String = "SELECT first_name, last_name, is_approved 
                                     FROM users 
                                     WHERE user_id=@id 
                                     AND password=@pass 
                                     AND role=@role"

            Dim cmd As New MySqlCommand(checkQuery, DBConnection.conn)

            cmd.Parameters.AddWithValue("@id", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            cmd.Parameters.AddWithValue("@role", Me.Tag.ToString())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then

                reader.Read()

                Dim approved As Integer = Convert.ToInt32(reader("is_approved"))

                If approved = 0 Then
                    MessageBox.Show("Your account is pending admin approval.")
                    reader.Close()
                    DBConnection.CloseConnection()
                    Exit Sub
                End If

                Dim firstName As String = reader("first_name").ToString()
                Dim lastName As String = reader("last_name").ToString()
                Dim role As String = Me.Tag.ToString()

                reader.Close()
                DBConnection.CloseConnection()

                If role = "Admin" Then
                    Dim dash As New AdminDashboard()
                    dash.SetUserName(firstName, lastName)
                    dash.Show()

                ElseIf role = "Instructor" Then
                    Dim dash As New InstructorDashboard()
                    dash.SetUserName(firstName, lastName, txtUsername.Text)
                    dash.Show()

                ElseIf role = "Student" Then
                    Dim dash As New StudentDashboard()
                    dash.SetUserName(firstName, lastName)
                    dash.Show()
                End If

                Me.Hide()

            Else
                MessageBox.Show("Invalid credentials")
                reader.Close()
                DBConnection.CloseConnection()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            DBConnection.CloseConnection()
        End Try

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "●"c
        txtPassword.MaxLength = 5

        Me.DoubleBuffered = True
        Me.DoubleBuffered = True

        CenterPanel()
    End Sub

    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterPanel()
    End Sub

    Private Sub CenterPanel()

        panelMain.Left = (Me.ClientSize.Width - panelMain.Width) \ 2
        panelMain.Top = (Me.ClientSize.Height - panelMain.Height) \ 2

        panelShadow.Left = panelMain.Left + 10
        panelShadow.Top = panelMain.Top + 10

    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress


        If e.KeyChar = ChrW(Keys.Back) Then
            Exit Sub
        End If

        If txtUsername.Text.Length = 2 AndAlso e.KeyChar <> "-"c Then
            txtUsername.Text &= "-"
            txtUsername.SelectionStart = txtUsername.Text.Length
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If txtUsername.Text.Length >= 8 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress

        If Char.IsControl(e.KeyChar) Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

End Class