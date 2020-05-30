Public Class addCourseForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addCourseButton.Click

        Dim code As String = courseCodeTextBox.Text
        Dim label As String = courseTitleTextBox.Text
        Dim credit As Integer = creditNumericUpDown.Value
        Dim desc As String = descriptionTextBox.Text


        Try

            Dim course As New Course()

            If code.Trim() = "" Or label.Trim() = "" Then

                MsgBox("Empty fields", MsgBoxStyle.Critical, "Add Course")

            Else
                If course.checkCourse(label) Then

                    If course.insertCourse(code, label, credit, desc) Then

                        MsgBox("New Course Inserted", MsgBoxStyle.Information, " Add Course")

                    Else
                        MsgBox("Course Not Inserted", MsgBoxStyle.Information, " Add Course")

                    End If

                Else

                    MsgBox("Course already exists", MsgBoxStyle.Critical, "Add Course")

                End If
            End If

        Catch ex As Exception

            MsgBox("This course code already exists", MsgBoxStyle.Critical, "Add Course")

        End Try

    End Sub
End Class