Imports MySql.Data.MySqlClient

Public Class DBConnection

    Public Shared conn As MySqlConnection

    Public Shared Sub OpenConnection()

        If conn Is Nothing Then
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=faculty_locator")
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub

    Public Shared Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Class