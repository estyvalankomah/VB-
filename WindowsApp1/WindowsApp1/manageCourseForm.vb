Public Class manageCourseForm

    Dim course As New Course()
    Dim pos As Integer
    Private Sub manageCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reloadListBoxData()

    End Sub

    Sub reloadListBoxData()

        coursesListBox.DataSource = course.getCourses()
        coursesListBox.ValueMember = "code"
        coursesListBox.DisplayMember = "title"

        coursesListBox.SelectedItem = Nothing

    End Sub

    Private Sub coursesListBox_Click(sender As Object, e As EventArgs) Handles coursesListBox.Click

        Dim drv As DataRowView = coursesListBox.SelectedItem
        pos = coursesListBox.SelectedIndex
        showData(pos)

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        Dim code As String = idTextBox.Text
        Dim label As String = titleTextBox.Text
        Dim credit As Integer = creditNumericUpDown.Value
        Dim desc As String = descriptionTextBox.Text


        Try

            If code.Trim() = "" Or label.Trim() = "" Then

                MsgBox("Empty fields", MsgBoxStyle.Critical, "Add Course")

            Else
                If course.checkCourse(label) Then

                    If course.insertCourse(code, label, credit, desc) Then

                        MsgBox("New Course Inserted", MsgBoxStyle.Information, " Add Course")
                        reloadListBoxData()
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

        pos = 0

    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click

        Dim code As String = idTextBox.Text
        Dim label As String = titleTextBox.Text
        Dim credit As Integer = creditNumericUpDown.Value
        Dim desc As String = descriptionTextBox.Text

        If course.checkCourse(label, code) Then

            If course.editCourse(code, label, credit, desc) Then

                MsgBox("Course Edited", MsgBoxStyle.Information, "Edit Course")
                reloadListBoxData()
            Else
                MsgBox("Course Not Edited", MsgBoxStyle.Information, "Edit Course")

            End If

        Else
            MsgBox("Course already exists", MsgBoxStyle.Exclamation, "Edit Course")

        End If

        pos = 0

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Try

            Dim courseCode As String = idTextBox.Text

            If MsgBox("Are you sure you want to delete this course?", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If course.deleteCourse(courseCode) Then
                    MsgBox("Course Deleted", MsgBoxStyle.Information, "Delete Course")

                    idTextBox.Text = ""
                    titleTextBox.Text = ""
                    creditNumericUpDown.Value = 1
                    descriptionTextBox.Text = ""

                    reloadListBoxData()

                Else
                    MsgBox("Course does not exist", MsgBoxStyle.Information, "Delete Course")

                End If

            End If


        Catch ex As Exception

            MsgBox("Please enter a valid course code", MsgBoxStyle.Information, "Delete Course")

        End Try

        pos = 0

    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click

        If pos > 0 Then

            pos = pos - 1
            showData(pos)

        End If

    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        If pos < course.getCourses().Rows().Count - 1 Then

            pos = pos + 1
            showData(pos)

        End If

    End Sub

    Sub showData(ByVal index As Integer)

        Dim dr As DataRow = course.getCourses().Rows(index)
        coursesListBox.SelectedIndex = index
        idTextBox.Text = dr.Item(0).ToString()
        titleTextBox.Text = dr.Item(1).ToString()
        creditNumericUpDown.Value = dr.Item(2)
        descriptionTextBox.Text = dr.Item(3).ToString()

    End Sub

End Class