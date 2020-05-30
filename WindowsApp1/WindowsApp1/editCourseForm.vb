Public Class editCourseForm
    Dim course As New Course()
    Private Sub editCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        courseCodeComboBox.DataSource = course.getCourses()
        courseCodeComboBox.DisplayMember = "code"
        courseCodeComboBox.SelectedItem = Nothing

    End Sub

    Sub fillCombo(ByVal index As Integer)

        courseCodeComboBox.DataSource = course.getCourses()
        courseCodeComboBox.DisplayMember = "code"
        courseCodeComboBox.SelectedIndex = index

    End Sub

    Private Sub courseCodeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles courseCodeComboBox.SelectedIndexChanged
        Try
            Dim table As New DataTable()
            Dim courseCode As String = courseCodeComboBox.Text
            table = course.getCourseByID(courseCode)
            idTextBox.Text = table.Rows(0)(0)
            titleTextBox.Text = table.Rows(0)(1)
            creditNumericUpDown.Value = table.Rows(0)(2)
            descriptionTextBox.Text = table.Rows(0)(3)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub editCourseButton_Click(sender As Object, e As EventArgs) Handles editCourseButton.Click

        Dim code As String = idTextBox.Text
        Dim label As String = titleTextBox.Text
        Dim credit As Integer = creditNumericUpDown.Value
        Dim desc As String = descriptionTextBox.Text

        If course.checkCourse(label, code) Then

            If course.editCourse(code, label, credit, desc) Then

                MsgBox("Course Edited", MsgBoxStyle.Information, "Edit Course")
                fillCombo(courseCodeComboBox.SelectedIndex)

            Else
                MsgBox("Course Not Edited", MsgBoxStyle.Information, "Edit Course")

            End If

        Else
            MsgBox("Course already exists", MsgBoxStyle.Exclamation, "Edit Course")

        End If


    End Sub
End Class