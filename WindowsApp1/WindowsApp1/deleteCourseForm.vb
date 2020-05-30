Public Class deleteCourseForm
    Private Sub deleteCourseButton_Click(sender As Object, e As EventArgs) Handles deleteCourseButton.Click

        Dim course As New Course()

        Try

            Dim courseCode As String = courseIDTextBox.Text

            If MsgBox("Are you sure you want to delete this course?", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If course.deleteCourse(courseCode) Then
                    MsgBox("Course Deleted", MsgBoxStyle.Information, "Delete Course")
                    courseIDTextBox.Text = " "

                Else
                    MsgBox("Course does not exist", MsgBoxStyle.Information, "Delete Course")

                End If

            End If


        Catch ex As Exception

            MsgBox("Please enter a valid course code", MsgBoxStyle.Information, "Delete Course")

        End Try

    End Sub

End Class