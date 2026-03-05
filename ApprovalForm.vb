Imports MySql.Data.MySqlClient

Public Class ApprovalForm

    Private adminDash As AdminDashboard

    Public Sub New(dashboard As AdminDashboard)
        InitializeComponent()
        adminDash = dashboard
    End Sub

    Private Sub ApprovalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPending()
    End Sub


    Private Sub LoadPending()

        Try
            DBConnection.OpenConnection()

            Dim query As String = "
                SELECT 
                    user_id AS 'User ID',
                    CONCAT(first_name, ' ', last_name) AS 'Full Name',
                    email AS 'Email',
                    department AS 'Department',
                    role AS 'Role'
                FROM users 
                WHERE is_approved = 0"

            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvApproval.DataSource = table
            dgvApproval.Columns("Department").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvApproval.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells



            For Each col As DataGridViewColumn In dgvApproval.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next

            dgvApproval.AutoResizeColumns()

            Dim totalWidth As Integer = 0
            For Each col As DataGridViewColumn In dgvApproval.Columns
                totalWidth += col.Width
            Next

            For Each col As DataGridViewColumn In dgvApproval.Columns
                col.FillWeight = (col.Width / totalWidth) * 100
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            dgvApproval.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvApproval.ScrollBars = ScrollBars.Vertical
            dgvApproval.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvApproval.MultiSelect = True
            dgvApproval.ReadOnly = True
            dgvApproval.AllowUserToAddRows = False
            dgvApproval.AllowUserToResizeRows = False
            dgvApproval.AllowUserToResizeColumns = False
            dgvApproval.RowHeadersVisible = False
            dgvApproval.EnableHeadersVisualStyles = False

            For Each col As DataGridViewColumn In dgvApproval.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            dgvApproval.ColumnHeadersHeight = 48
            dgvApproval.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            dgvApproval.ColumnHeadersDefaultCellStyle.BackColor = Color.ForestGreen
            dgvApproval.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvApproval.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvApproval.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None

            dgvApproval.BackgroundColor = Color.White
            dgvApproval.GridColor = Color.LightGray
            dgvApproval.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            dgvApproval.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            dgvApproval.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 200)
            dgvApproval.DefaultCellStyle.SelectionForeColor = Color.Black

            DBConnection.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try

    End Sub


    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        If dgvApproval.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one user.")
            Exit Sub
        End If

        Try
            DBConnection.OpenConnection()

            For Each row As DataGridViewRow In dgvApproval.SelectedRows

                Dim userID As String = row.Cells("User ID").Value.ToString()
                Dim fullName As String = row.Cells("Full Name").Value.ToString()
                Dim dept As String = row.Cells("Department").Value.ToString()

                ' ===== APPROVE USER =====
                Dim query As String = "UPDATE users SET is_approved = 1 WHERE user_id = @uid"
                Dim cmd As New MySqlCommand(query, DBConnection.conn)
                cmd.Parameters.AddWithValue("@uid", userID)
                cmd.ExecuteNonQuery()

                ' ===== INSERT AUDIT LOG =====
                Dim logQuery As String = "INSERT INTO audit_log 
                (admin_fullname, affected_user_id, affected_user_fullname, department, action, action_date)
                VALUES (@adminFull, @uid, @userFull, @dept, @action, NOW())"

                Dim logCmd As New MySqlCommand(logQuery, DBConnection.conn)

                logCmd.Parameters.AddWithValue("@adminFull", adminDash.loggedInAdminFullName)
                logCmd.Parameters.AddWithValue("@uid", userID)
                logCmd.Parameters.AddWithValue("@userFull", fullName)
                logCmd.Parameters.AddWithValue("@dept", dept)
                logCmd.Parameters.AddWithValue("@action", "APPROVED")

                logCmd.ExecuteNonQuery()

            Next

            DBConnection.CloseConnection()

            MessageBox.Show("Selected user(s) approved!")
            chkSelectAll.Checked = False
            LoadPending()
            adminDash.LoadNotificationCount()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            DBConnection.CloseConnection()
        End Try

    End Sub
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        If dgvApproval.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one user.")
            Exit Sub
        End If

        Try
            DBConnection.OpenConnection()

            For Each row As DataGridViewRow In dgvApproval.SelectedRows

                Dim userID As String = row.Cells("User ID").Value.ToString()
                Dim fullName As String = row.Cells("Full Name").Value.ToString()
                Dim dept As String = row.Cells("Department").Value.ToString()

                ' ===== DELETE USER =====
                Dim query As String = "DELETE FROM users WHERE user_id = @uid"
                Dim cmd As New MySqlCommand(query, DBConnection.conn)
                cmd.Parameters.AddWithValue("@uid", userID)
                cmd.ExecuteNonQuery()

                ' ===== INSERT AUDIT LOG =====
                Dim logQuery As String = "INSERT INTO audit_log 
                (admin_fullname, affected_user_id, affected_user_fullname, department, action, action_date)
                VALUES (@adminFull, @uid, @userFull, @dept, @action, NOW())"

                Dim logCmd As New MySqlCommand(logQuery, DBConnection.conn)

                logCmd.Parameters.AddWithValue("@adminFull", adminDash.loggedInAdminFullName)
                logCmd.Parameters.AddWithValue("@uid", userID)
                logCmd.Parameters.AddWithValue("@userFull", fullName)
                logCmd.Parameters.AddWithValue("@dept", dept)
                logCmd.Parameters.AddWithValue("@action", "REJECTED")

                logCmd.ExecuteNonQuery()

            Next

            DBConnection.CloseConnection()

            MessageBox.Show("Selected user(s) rejected!")
            chkSelectAll.Checked = False
            LoadPending()
            adminDash.LoadNotificationCount()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            DBConnection.CloseConnection()
        End Try

    End Sub


    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged

        dgvApproval.Focus()

        If chkSelectAll.Checked Then
            dgvApproval.SelectAll()
        Else
            dgvApproval.ClearSelection()
        End If

    End Sub

End Class