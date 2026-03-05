Imports MySql.Data.MySqlClient

Public Class InstructorDashboard

    Private currentUserID As String

    Public Sub SetUserName(firstName As String, lastName As String, userID As String)
        lblWelcome.Text = "Welcome! " & lastName & ", " & firstName
        currentUserID = userID
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result = MessageBox.Show("Are you sure you want to log out?",
                                                     "Confirm Logout",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim roleForm As New RoleSelectionForm
            roleForm.Show()
            Close()
        End If

    End Sub


    Private Sub UpdateDatePickerState()

        If rbLeave.Checked Or rbTravel.Checked Then
            dtFrom.Enabled = True
            dtTo.Enabled = True
        Else
            dtFrom.Enabled = False
            dtTo.Enabled = False
        End If

    End Sub


    Private Sub InstructorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDatePickerState()
        LoadHistory()
    End Sub


    Private Sub rbIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbIn.CheckedChanged
        UpdateDatePickerState()
    End Sub

    Private Sub rbOut_CheckedChanged(sender As Object, e As EventArgs) Handles rbOut.CheckedChanged
        UpdateDatePickerState()
    End Sub

    Private Sub rbLeave_CheckedChanged(sender As Object, e As EventArgs) Handles rbLeave.CheckedChanged
        UpdateDatePickerState()
    End Sub

    Private Sub rbTravel_CheckedChanged(sender As Object, e As EventArgs) Handles rbTravel.CheckedChanged
        UpdateDatePickerState()
    End Sub


    Private Sub btnSubmitStatus_Click(sender As Object, e As EventArgs) Handles btnSubmitStatus.Click

        If (rbLeave.Checked Or rbTravel.Checked) AndAlso dtFrom.Value.Date > dtTo.Value.Date Then
            MessageBox.Show("Invalid date range.")
            Exit Sub
        End If

        Dim selectedStatus = ""

        If rbIn.Checked Then
            selectedStatus = "IN"
        ElseIf rbOut.Checked Then
            selectedStatus = "OUT"
        ElseIf rbLeave.Checked Then
            selectedStatus = "ON LEAVE"
        ElseIf rbTravel.Checked Then
            selectedStatus = "ON TRAVEL"
        Else
            MessageBox.Show("Please select a status.")
            Exit Sub
        End If

        Try
            DBConnection.OpenConnection()

            ' 🔎 CHECK DUPLICATE FIRST
            Dim checkQuery = "SELECT COUNT(*) FROM instructor_status 
                                     WHERE user_id=@uid 
                                     AND status=@status 
                                     AND DATE(date_created)=CURDATE()"

            Dim checkCmd As New MySqlCommand(checkQuery, DBConnection.conn)
            checkCmd.Parameters.AddWithValue("@uid", currentUserID)
            checkCmd.Parameters.AddWithValue("@status", selectedStatus)

            Dim count = Convert.ToInt32(checkCmd.ExecuteScalar)

            If count > 0 Then
                MessageBox.Show("You already submitted this status today.")
                DBConnection.CloseConnection()
                Exit Sub
            End If

            ' ✅ INSERT ONLY IF NO DUPLICATE
            Dim query = "INSERT INTO instructor_status (user_id, status, date_from, date_to) 
                               VALUES (@uid, @status, @from, @to)"

            Dim cmd As New MySqlCommand(query, DBConnection.conn)

            cmd.Parameters.AddWithValue("@uid", currentUserID)
            cmd.Parameters.AddWithValue("@status", selectedStatus)

            If rbLeave.Checked Or rbTravel.Checked Then
                cmd.Parameters.AddWithValue("@from", dtFrom.Value.Date)
                cmd.Parameters.AddWithValue("@to", dtTo.Value.Date)
            Else
                cmd.Parameters.AddWithValue("@from", DBNull.Value)
                cmd.Parameters.AddWithValue("@to", DBNull.Value)
            End If

            cmd.ExecuteNonQuery()

            DBConnection.CloseConnection()

            MessageBox.Show("Status submitted successfully!")
            LoadHistory()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            DBConnection.CloseConnection()
        End Try

    End Sub

    Private Sub LoadHistory()

        Try
            DBConnection.OpenConnection()

            Dim query As String = "SELECT status, date_from, date_to, date_created 
                               FROM instructor_status 
                               WHERE user_id = @uid
                               ORDER BY date_created DESC"

            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@uid", currentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvHistory.DataSource = table

            ' ===== FINAL CLEAN DESIGN =====
            With dgvHistory

                ' Make columns fit width (no horizontal scroll)
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .ScrollBars = ScrollBars.Vertical

                ' Basic setup
                .EnableHeadersVisualStyles = False
                .RowHeadersVisible = False
                .AllowUserToResizeRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToAddRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False

                ' Header design
                .ColumnHeadersDefaultCellStyle.BackColor = Color.ForestGreen
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.ForestGreen
                .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
                .ColumnHeadersHeight = 45
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

                ' Remove blue selection
                .DefaultCellStyle.SelectionBackColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Black

                ' Grid style
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                .GridColor = Color.Gainsboro

                ' Disable sorting & resizing
                For Each col As DataGridViewColumn In .Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                    col.Resizable = DataGridViewTriState.False
                Next

                ' ===== PROFESSIONAL COLUMN TITLES =====
                If .Columns.Contains("status") Then
                    .Columns("status").HeaderText = "Status"
                End If

                If .Columns.Contains("date_from") Then
                    .Columns("date_from").HeaderText = "Effective From"
                End If

                If .Columns.Contains("date_to") Then
                    .Columns("date_to").HeaderText = "Effective To"
                End If

                If .Columns.Contains("date_created") Then
                    .Columns("date_created").HeaderText = "Date Recorded"
                    .Columns("date_created").FillWeight = 130
                End If
                ' ===== END COLUMN TITLES =====

                .ClearSelection()

            End With
            ' ===== END DESIGN =====

            DBConnection.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message)
            DBConnection.CloseConnection()
        End Try

    End Sub
    Private Sub panelHistory_Paint(sender As Object, e As PaintEventArgs) Handles panelHistory.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick

    End Sub

    Private Sub grpStatus_Enter(sender As Object, e As EventArgs) Handles grpStatus.Enter

    End Sub
End Class