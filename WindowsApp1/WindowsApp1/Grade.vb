Imports MySql.Data.MySqlClient

Public Class Grade

    Dim db As New Database()
    Public Function insertGrade(ByVal studentID As Integer, ByVal courseID As String, ByVal score As Double, ByVal grade As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `grade`(`studentID`, `courseCode`, `score`, `grade`) VALUES (@ID,@code,@score,@grade)", db.getConnection)
        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = studentID
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseID
        command.Parameters.Add("@score", MySqlDbType.Double).Value = score
        command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = grade

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

    End Function

    Function studentGradeExists(ByVal studentID As Integer, ByVal courseID As String) As Boolean

        Dim command As New MySqlCommand("SELECT * FROM `grade` WHERE `studentID` = @ID AND `courseCode` = @code", db.getConnection)
        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = studentID
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseID

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            Return False

        Else

            Return True

        End If

    End Function

    Function getStudentGrade() As DataTable

        Dim command As New MySqlCommand()
        command.Connection = db.getConnection
        command.CommandText = "SELECT grade.studentID, student.firstName, student.lastName, grade.courseCode, course.title, grade.score, grade.grade FROM student INNER JOIN grade on student.ID = grade.studentID INNER JOIN course on grade.courseCode = course.code"

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        Return table

    End Function

    Public Function deleteGrade(ByVal studentID As Integer, ByVal courseID As String) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `grade` WHERE `studentID` = @ID AND `courseCode` = @code", db.getConnection)
        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = studentID
        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseID

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

    End Function

End Class
