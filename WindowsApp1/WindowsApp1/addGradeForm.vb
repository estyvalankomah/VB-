Imports MySql.Data.MySqlClient
Public Class addGradeForm
    Dim grade As New Grade()
    Dim course As New Course()
    Dim student As New Student()
    Private Sub addGradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        courseCodeComboBox.DataSource = course.getCourses()
        courseCodeComboBox.DisplayMember = "code"

        Dim command As New MySqlCommand("SELECT `ID`, `firstName`, `lastName` FROM `student`")
        studentsDataGridView.DataSource = student.getStudents(command)

    End Sub

    Private Sub addGradeButton_Click(sender As Object, e As EventArgs) Handles addGradeButton.Click

        Try

            Dim studID As Integer = Convert.ToInt32(studentIDTextBox.Text)
            Dim code As String = courseCodeComboBox.Text
            Dim score As Double = Convert.ToDouble(scoreTextBox.Text)
            Dim studGrade As String = gradeTextBox.Text

            If Not grade.studentGradeExists(studID, code) Then

                If grade.insertGrade(studID, code, score, studGrade) Then

                    MsgBox("Grade Inserted", MsgBoxStyle.Information, "Add Grade")

                Else
                    MsgBox("Grade Not Inserted", MsgBoxStyle.Exclamation, "Add Grade")

                End If

            Else

                MsgBox("This student's grade for this course already exists", MsgBoxStyle.Exclamation, "Add Grade")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Add Grade")

        End Try

    End Sub

    Private Sub studentsDataGridView_Click(sender As Object, e As EventArgs) Handles studentsDataGridView.Click

        studentIDTextBox.Text = studentsDataGridView.CurrentRow.Cells(0).Value.ToString()


    End Sub

    Private Sub scoreTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles scoreTextBox.KeyUp

        Try

            Dim score As Double = Convert.ToDouble(scoreTextBox.Text)
            Dim grade As String = ""

            If score > 79 And score < 101 Then

                grade = "A"

            ElseIf score > 74 And score < 80 Then

                grade = "B+"

            ElseIf score > 69 And score < 75 Then

                grade = "B"

            ElseIf score > 64 And score < 70 Then

                grade = "C+"

            ElseIf score > 59 And score < 65 Then

                grade = "C"

            ElseIf score > 54 And score < 60 Then

                grade = "D+"

            ElseIf score > 49 And score < 55 Then

                grade = "D"

            ElseIf score > 44 And score < 50 Then

                grade = "E"

            ElseIf score > 0 And score < 45 Then
                grade = "F"

            ElseIf score = 0 Then
                grade = "F"

            End If

            gradeTextBox.Text = grade

        Catch ex As Exception

        End Try

    End Sub
End Class