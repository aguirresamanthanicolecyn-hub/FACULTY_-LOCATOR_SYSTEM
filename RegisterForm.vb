Imports MySql.Data.MySqlClient
Imports System.Linq
Imports System.Text.RegularExpressions
Imports BCrypt.Net

Public Class RegisterForm

    ' ===============================
    ' FORM SHOWN
    ' ===============================
    Private Sub RegisterForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim role As String = If(Me.Tag IsNot Nothing, Me.Tag.ToString(), "")

        Dim displayLinkRole As String = role
        If role = "Admin" Then
            displayLinkRole = "Administrator"
        End If

        lblRole.Text = "REGISTER AS " & role.ToUpper()
        linkLogin.Text = "Already have an account? Sign in as " & displayLinkRole

    End Sub


    ' ===============================
    ' FORM LOAD
    ' ===============================
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True
        CenterPanel()

        Dim role As String = If(Me.Tag IsNot Nothing, Me.Tag.ToString(), "")

        If role = "Admin" Then
            cmbDepartment.Enabled = False
            cmbDepartment.SelectedIndex = -1
        Else
            cmbDepartment.Enabled = True
        End If

        ' PASSWORD BULLET
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True

    End Sub


    ' ===============================
    ' USER ID - NUMBERS ONLY
    ' ===============================
    Private Sub txtUserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' AUTO DASH 00-00000
    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

        Dim cursorPosition As Integer = txtUserID.SelectionStart
        Dim numbersOnly As String = txtUserID.Text.Replace("-", "")

        ' limit to 7 digits total
        If numbersOnly.Length > 7 Then
            numbersOnly = numbersOnly.Substring(0, 7)
        End If

        ' rebuild with dash properly
        If numbersOnly.Length >= 3 Then
            txtUserID.Text = numbersOnly.Substring(0, 2) & "-" & numbersOnly.Substring(2)
        Else
            txtUserID.Text = numbersOnly
        End If

        ' ibalik cursor sa tamang pwesto
        txtUserID.SelectionStart = txtUserID.Text.Length

    End Sub


    ' ===============================
    ' NAME - LETTERS ONLY
    ' ===============================
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtFirstName.KeyPress, txtLastName.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsLetter(e.KeyChar) AndAlso
           e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    ' AUTO CAPITALIZE
    Private Sub txtName_Leave(sender As Object, e As EventArgs) _
        Handles txtFirstName.Leave, txtLastName.Leave

        Dim txt As TextBox = CType(sender, TextBox)

        If txt.Text <> "" Then
            txt.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt.Text.ToLower())
        End If

    End Sub


    ' ===============================
    ' PASSWORD NUMBERS ONLY
    ' ===============================
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtPassword.KeyPress, txtConfirmPassword.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    ' ===============================
    ' REGISTER BUTTON
    ' ===============================
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim role As String = If(Me.Tag IsNot Nothing, Me.Tag.ToString(), "").Trim()

        ' ===============================
        ' REQUIRED FIELDS CHECK
        ' ===============================
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse
       String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
       String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
       String.IsNullOrWhiteSpace(txtConfirmPassword.Text) OrElse
       (role <> "Admin" AndAlso cmbDepartment.SelectedIndex = -1) Then

            MessageBox.Show("Please fill up all required fields.",
                        "Incomplete Form",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ===============================
        ' USER ID FORMAT
        ' ===============================
        If Not Regex.IsMatch(txtUserID.Text.Trim(), "^\d{2}-\d{5}$") Then
            MessageBox.Show("Invalid User ID format. Example: 23-10380")
            Exit Sub
        End If

        ' ===============================
        ' EMAIL FORMAT
        ' ===============================
        If Not Regex.IsMatch(txtEmail.Text.Trim(),
        "^[a-zA-Z0-9._%+-]+@gmail\.com$") Then
            MessageBox.Show("Please enter a valid Gmail address.")
            Exit Sub
        End If

        ' ===============================
        ' PASSWORD VALIDATION
        ' ===============================
        If Not Regex.IsMatch(txtPassword.Text, "^\d{5}$") Then
            MessageBox.Show("Password must be exactly 5 numbers.")
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If

        Dim pass As String = txtPassword.Text

        If pass.Distinct().Count() = 1 Then
            MessageBox.Show("Password cannot contain repeating numbers.")
            Exit Sub
        End If

        If {"12345", "23456", "34567", "45678", "56789",
        "54321", "65432", "76543", "87654", "98765"}.Contains(pass) Then

            MessageBox.Show("Password cannot be sequential numbers.")
            Exit Sub
        End If

        ' ===============================
        ' 🔐 HASH PASSWORD
        ' ===============================
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(pass)

        Try
            DBConnection.OpenConnection()

            ' CHECK DUPLICATE USER
            Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE user_id = @uid"
            Using checkCmd As New MySqlCommand(checkQuery, DBConnection.conn)
                checkCmd.Parameters.AddWithValue("@uid", txtUserID.Text.Trim())

                Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If userExists > 0 Then
                    MessageBox.Show("User ID already exists.",
                                "Duplicate User",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' DEPARTMENT VALUE
            Dim departmentValue As Object = DBNull.Value
            If role <> "Admin" Then
                departmentValue = cmbDepartment.SelectedItem.ToString()
            End If

            ' INSERT USER
            Dim query As String =
            "INSERT INTO users (user_id, first_name, last_name, email, password, department, role, is_approved) " &
            "VALUES (@id, @fname, @lname, @email, @pass, @dept, @role, 0)"

            Using cmd As New MySqlCommand(query, DBConnection.conn)

                cmd.Parameters.AddWithValue("@id", txtUserID.Text.Trim())
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@pass", hashedPassword) ' 🔐 HASHED NA
                cmd.Parameters.AddWithValue("@dept", departmentValue)
                cmd.Parameters.AddWithValue("@role", role)

                cmd.ExecuteNonQuery()

            End Using

            MessageBox.Show("Registration submitted successfully. Please wait for admin approval.",
                        "Pending Approval",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            Dim roleForm As New RoleSelectionForm()
            roleForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            DBConnection.CloseConnection()
        End Try

    End Sub

    ' ===============================
    ' LOGIN LINK
    ' ===============================
    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked

        Dim login As New LoginForm()
        login.Tag = Me.Tag
        login.Show()
        Me.Hide()

    End Sub


    ' ===============================
    ' CENTER PANEL
    ' ===============================
    Private Sub CenterPanel()

        panelMain.Left = (Me.ClientSize.Width - panelMain.Width) \ 2
        panelMain.Top = (Me.ClientSize.Height - panelMain.Height) \ 2

        panelShadow.Left = panelMain.Left + 10
        panelShadow.Top = panelMain.Top + 10

    End Sub

End Class