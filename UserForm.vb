Imports MySql.Data.MySqlClient

Public Class UserForm

    Public selectedDepartment As String
    Public parentDashboard As AdminDashboard
    Private selectedRole As String = ""

    ' ==============================
    ' FORM LOAD
    ' ==============================
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterHistoryPanel()
        panelHistory.Visible = False
    End Sub

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)
        Me.ActiveControl = Nothing
    End Sub

    Private Sub CenterHistoryPanel()
        panelHistory.Left = (Me.ClientSize.Width - panelHistory.Width) \ 2
        panelHistory.Top = (Me.ClientSize.Height - panelHistory.Height) \ 2
    End Sub

    ' ==============================
    ' UPDATE TITLE
    ' ==============================
    Public Sub UpdateTitle()
        lblTitle.Text = selectedDepartment.ToUpper()
        selectedRole = ""
        DataGridView1.DataSource = Nothing
        DataGridView1.ClearSelection()
    End Sub

    ' ==============================
    ' BUTTONS
    ' ==============================
    Private Sub btnInstructor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        selectedRole = "Instructor"
        LoadUsers()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        selectedRole = "Student"
        LoadUsers()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        selectedRole = ""
        DataGridView1.DataSource = Nothing
        parentDashboard.ShowDepartments()
        Me.Hide()
    End Sub

    ' ==============================
    ' LOAD USERS GRID
    ' ==============================
    Private Sub LoadUsers()

        If selectedRole = "" Then Exit Sub

        Try
            DBConnection.OpenConnection()

            Dim query As String = "SELECT user_id, first_name, last_name, email, password 
                       FROM users 
                       WHERE department = @dept 
                       AND role = @role
                       AND is_approved = 1"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@dept", selectedDepartment)
            cmd.Parameters.AddWithValue("@role", selectedRole)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
            StyleGrid(DataGridView1)
            DataGridView1.ClearSelection()
            DataGridView1.Columns("user_id").HeaderText = "USER ID"
            DataGridView1.Columns("first_name").HeaderText = "FIRST NAME"
            DataGridView1.Columns("last_name").HeaderText = "LAST NAME"
            DataGridView1.Columns("email").HeaderText = "EMAIL"
            DataGridView1.Columns("password").HeaderText = "PASSWORD"

            DBConnection.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
            DBConnection.CloseConnection()
        End Try

    End Sub

    ' ==============================
    ' DOUBLE CLICK INSTRUCTOR
    ' ==============================
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        If selectedRole <> "Instructor" Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        Dim selectedID As String = DataGridView1.Rows(e.RowIndex).Cells("user_id").Value.ToString()

        LoadInstructorHistory(selectedID)

        panelHistory.Visible = True
        panelHistory.BringToFront()

    End Sub

    ' ==============================
    ' LOAD HISTORY GRID
    ' ==============================
    Private Sub LoadInstructorHistory(userID As String)

        Try
            DBConnection.OpenConnection()

            Dim query As String = "SELECT status, date_from, date_to, date_created 
                                   FROM instructor_status
                                   WHERE user_id = @uid
                                   ORDER BY date_created DESC"

            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@uid", userID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvHistory.DataSource = table
            StyleGrid(dgvHistory)
            dgvHistory.ClearSelection()

            ' Custom headers
            dgvHistory.Columns("status").HeaderText = "STATUS"
            dgvHistory.Columns("date_from").HeaderText = "FROM"
            dgvHistory.Columns("date_to").HeaderText = "TO"
            dgvHistory.Columns("date_created").HeaderText = "DATE SUBMITTED"

            DBConnection.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message)
            DBConnection.CloseConnection()
        End Try

    End Sub

    ' ==============================
    ' SHARED GRID STYLE METHOD
    ' ==============================
    Private Sub StyleGrid(grid As DataGridView)

        With grid
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AllowUserToOrderColumns = False

            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False

            .RowTemplate.Height = 35
            .RowTemplate.Resizable = DataGridViewTriState.False

            ' Remove blue highlight completely
            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.ForestGreen
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White

            ' Header style
            .ColumnHeadersDefaultCellStyle.BackColor = Color.ForestGreen
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            .DefaultCellStyle.Font = New Font("Segoe UI", 10)

            ' Disable sorting
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With

    End Sub

    ' ==============================
    ' CLOSE HISTORY PANEL
    ' ==============================
    Private Sub btnCloseHistory_Click(sender As Object, e As EventArgs) Handles btnCloseHistory.Click
        panelHistory.Visible = False
    End Sub

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick

    End Sub
End Class