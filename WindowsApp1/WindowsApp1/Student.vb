Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Student

    Dim db As New Database()

    Public Function insertStudent(ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal contact As String, ByVal address As String, ByVal image As MemoryStream) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `student`(`firstName`, `lastName`, `dateOfBirth`, `gender`, `contact`, `address`, `picture`) VALUES (@fn, @ln, @bdt, @gnd, @cnt, @adrs, @pic)", db.getConnection)

        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gnd", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = contact
        command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = image.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()

    End Function

    Function getStudents(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        table.Columns(1).ColumnName = "Firstname"
        table.Columns(2).ColumnName = "Lastname"

        Return table

    End Function

    Public Function deleteStudent(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `student` WHERE `ID` = @studentID", db.getConnection)

        command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()

    End Function

    Public Function updateStudent(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal contact As String, ByVal address As String, ByVal image As MemoryStream) As Boolean

        Dim command As New MySqlCommand("UPDATE `student` SET `firstName`= @fn,`lastName`= @ln,`dateOfBirth`= @bdt,`gender`= @gnd,`contact`= @cnt,`address`= @adrs,`picture`= @pic WHERE ID = @id", db.getConnection)

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gnd", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = contact
        command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = image.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()

    End Function

    Function execCount(ByVal query As String) As String

        Dim command As New MySqlCommand(query, db.getConnection)

        db.openConnection()
        Return command.ExecuteScalar().ToString()
        db.closeConnection()

    End Function

    Function totalStudents() As String

        Return execCount("SELECT COUNT(*) FROM `student`")

    End Function

    Function totalMaleStudents() As String

        Return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Male'")

    End Function

    Function totalFemaleStudents() As String

        Return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Female'")

    End Function

End Class
