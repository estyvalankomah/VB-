Imports MySql.Data.MySqlClient
Public Class Course

    Dim db As New Database()
    Public Function insertCourse(ByVal courseCode As String, ByVal courseName As String, ByVal credit As Integer, ByVal description As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `course`(`code`, `title`, `credit`, `description`) VALUES (@code,@title,@credit,@desc)", db.getConnection)
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseCode
        command.Parameters.Add("@title", MySqlDbType.VarChar).Value = courseName
        command.Parameters.Add("@credit", MySqlDbType.Int32).Value = credit
        command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

    End Function


    Public Function editCourse(ByVal courseCode As String, ByVal courseName As String, ByVal credit As Integer, ByVal description As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `course` SET `title`= @title,`credit`= @credit,`description`= @desc WHERE `code`= @code", db.getConnection)
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseCode
        command.Parameters.Add("@title", MySqlDbType.VarChar).Value = courseName
        command.Parameters.Add("@credit", MySqlDbType.Int32).Value = credit
        command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

    End Function


    Public Function deleteCourse(ByVal courseCode As String) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `course` WHERE `code` = @code", db.getConnection)
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseCode

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function checkCourse(ByVal courseTitle As String, ByVal Optional courseCode As String = "") As Boolean

        Dim command As New MySqlCommand("SELECT * FROM `course` WHERE `title` = @title AND `code` <> @code", db.getConnection())
        command.Parameters.Add("@title", MySqlDbType.VarChar).Value = courseTitle
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseCode
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            Return False

        Else
            Return True

        End If

    End Function


    Public Function getCourses() As DataTable

        Dim command As New MySqlCommand("SELECT * FROM `course`", db.getConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table

    End Function

    Public Function getCourseByID(ByVal courseID As String) As DataTable

        Dim command As New MySqlCommand("SELECT * FROM `course` WHERE `code` = @code", db.getConnection)
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseID
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table

    End Function

End Class
