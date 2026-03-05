Imports MySql.Data.MySqlClient

Public Class DepartmentInstructorsForm

    Private selectedDepartment As String

    Public Sub New(departmentName As String)
        InitializeComponent()
        selectedDepartment = departmentName
    End Sub

    Private Sub DepartmentInstructorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen

        lblDepartmentTitle.Text = selectedDepartment.ToUpper()

        LoadInstructors()

    End Sub

    Private Sub LoadInstructors()

        Try
            DBConnection.OpenConnection()

            Dim query As String = "
SELECT 
    CONCAT(u.last_name, ', ', u.first_name) AS Instructor,
    COALESCE(
        (
            SELECT 
                CASE 
                    WHEN s.status IN ('ON LEAVE','TRAVEL')
                        THEN CONCAT(s.status, ' (',
                                    DATE_FORMAT(s.date_from, '%b %d'),
                                    ' - ',
                                    DATE_FORMAT(s.date_to, '%b %d'), ')')
                    ELSE s.status
                END
            FROM instructor_status s
            WHERE s.user_id = u.user_id
            AND (
                (s.status IN ('IN','OUT') AND DATE(s.date_created) = CURDATE())
                OR
                (s.status IN ('ON LEAVE','TRAVEL') 
                 AND CURDATE() BETWEEN s.date_from AND s.date_to)
            )
            ORDER BY s.date_created DESC
            LIMIT 1
        ),
        'NO STATUS'
    ) AS Status
FROM users u
WHERE u.department = @dept
AND u.role = 'instructor'
ORDER BY u.last_name ASC
"

            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@dept", selectedDepartment)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvInstructors.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error loading instructors: " & ex.Message)
        Finally
            DBConnection.CloseConnection()
        End Try


        With dgvInstructors

            ' ===== BASIC =====
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .MultiSelect = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ScrollBars = ScrollBars.Vertical

            ' ===== PERFECT ROW SIZE =====
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .RowTemplate.Height = 55

            ' ===== CLEAN CELL STYLE =====
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.Font = New Font("Segoe UI", 11)
            .DefaultCellStyle.Padding = New Padding(8, 4, 8, 4)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ' ===== ALTERNATING ROWS =====
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

            ' ===== HEADER STYLE =====
            .ColumnHeadersDefaultCellStyle.BackColor = Color.ForestGreen
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.ForestGreen
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 55
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

            ' ===== GRID STYLE =====
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.Gainsboro

            ' ===== PERFECT 50 / 50 SPLIT =====
            If .Columns.Contains("Instructor") Then
                .Columns("Instructor").FillWeight = 50
                .Columns("Instructor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If

            If .Columns.Contains("Status") Then
                .Columns("Status").FillWeight = 50
                .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            ' ===== REMOVE SORTING =====
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            .ClearSelection()

        End With
        ' ===== STATUS COLOR LOGIC =====
        For Each row As DataGridViewRow In dgvInstructors.Rows
            If Not row.IsNewRow Then

                Dim statusValue As String = row.Cells("Status").Value.ToString().ToUpper()

                If statusValue.Contains("NO STATUS") Then
                    row.Cells("Status").Style.ForeColor = Color.Gray

                ElseIf statusValue.Contains("OUT") Then
                    row.Cells("Status").Style.ForeColor = Color.Firebrick
                    row.Cells("Status").Style.Font = New Font("Segoe UI", 11, FontStyle.Bold)

                ElseIf statusValue.Contains("IN") Then
                    row.Cells("Status").Style.ForeColor = Color.ForestGreen
                    row.Cells("Status").Style.Font = New Font("Segoe UI", 11, FontStyle.Bold)

                ElseIf statusValue.Contains("LEAVE") Or statusValue.Contains("TRAVEL") Then
                    row.Cells("Status").Style.ForeColor = Color.DarkOrange
                    row.Cells("Status").Style.Font = New Font("Segoe UI", 11, FontStyle.Bold)

                End If

            End If
        Next

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If Me.Owner IsNot Nothing Then
            Me.Owner.Show()
        End If

        Me.Close()

    End Sub

End Class