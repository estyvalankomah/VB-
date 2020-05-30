Imports System.IO
Public Class updateDeleteStudentForm

    Dim student As New Student()
    Private Sub deleteStudentButton_Click(sender As Object, e As EventArgs) Handles deleteStudentButton.Click

        Try

            Dim studentID As Integer = Convert.ToInt32(IDTextBox.Text)

            If MsgBox("Are you sure you want to delete this student?", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If student.deleteStudent(studentID) Then

                    MsgBox("Student Deleted", MsgBoxStyle.Information, "Delete Student")
                    IDTextBox.Text = " "
                    fnameTextBox.Text = " "
                    lnameTextBox.Text = " "
                    addressTextBox.Text = " "
                    contactTextBox.Text = " "
                    DateTimePicker1.Value = Date.Now
                    studentPictureBox.Image = Nothing

                Else

                    MsgBox("Student not deleted", MsgBoxStyle.Information, "Delete Student")

                End If

            End If

        Catch ex As Exception

            MsgBox("Please enter a valid ID", MsgBoxStyle.Information, "Delete student")

        End Try

    End Sub

    Private Sub updateStudentButton_Click(sender As Object, e As EventArgs) Handles updateStudentButton.Click

        Dim student As New Student()
        Dim id As Integer
        Dim fname As String = fnameTextBox.Text
        Dim lname As String = lnameTextBox.Text
        Dim bdate As Date = DateTimePicker1.Value
        Dim contact As String = contactTextBox.Text
        Dim address As String = addressTextBox.Text

        Dim gender As String = "Male"

        If femaleRadioButton.Checked Then

            gender = "Female"

        End If

        Dim image As New MemoryStream

        Dim born_year As Integer = DateTimePicker1.Value.Year
        Dim this_year As Integer = Date.Now.Year

        If this_year - born_year < 15 Or this_year - born_year > 25 Then

            MsgBox("Student age must be between 15 and 25 years", MsgBoxStyle.Information, "Birth date error")

        Else

            If verify() Then

                Try

                    id = Convert.ToInt32(IDTextBox.Text)

                Catch ex As Exception

                    MsgBox(" Please Enter a valid numeric ID", MsgBoxStyle.Exclamation, "Edit Student")

                End Try



                studentPictureBox.Image.Save(image, studentPictureBox.Image.RawFormat)

                If student.updateStudent(id, fname, lname, bdate, gender, contact, address, image) Then

                    MsgBox("Student information updated", MsgBoxStyle.Information, "Edit student")

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Edit student")

                End If

            Else

                MsgBox("Empty fields", MsgBoxStyle.Critical, "Edit student")

            End If

        End If

    End Sub

    Function verify() As Boolean

        If IDTextBox.Text.Trim() = "" Or fnameTextBox.Text.Trim() = "" Or lnameTextBox.Text.Trim() = "" Or
           addressTextBox.Text.Trim() = "" Or contactTextBox.Text.Trim() = "" Or
           studentPictureBox.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

    Private Sub uploadButton_Click(sender As Object, e As EventArgs) Handles uploadButton.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            studentPictureBox.Image = Image.FromFile(opf.FileName)

        End If

    End Sub
End Class