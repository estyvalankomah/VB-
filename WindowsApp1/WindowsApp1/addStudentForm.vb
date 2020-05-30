Imports System.IO

Public Class addStudentForm
    Private Sub addStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub contactTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactTextBox.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub uploadButton_Click(sender As Object, e As EventArgs) Handles uploadButton.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            studentPictureBox.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub cancelStudentButton_Click(sender As Object, e As EventArgs) Handles cancelStudentButton.Click

        Close()

    End Sub

    Private Sub saveStudentButton_Click(sender As Object, e As EventArgs) Handles saveStudentButton.Click

        Dim student As New Student()
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

                studentPictureBox.Image.Save(image, studentPictureBox.Image.RawFormat)

                If student.insertStudent(fname, lname, bdate, gender, contact, address, image) Then

                    MsgBox("New student added", MsgBoxStyle.Information, "Add student")

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Add student")

                End If

            Else

                MsgBox("Empty fields", MsgBoxStyle.Critical, "Add student")

            End If

        End If

    End Sub

    Function verify() As Boolean

        If fnameTextBox.Text.Trim() = "" Or lnameTextBox.Text.Trim() = "" Or
           addressTextBox.Text.Trim() = "" Or contactTextBox.Text.Trim() = "" Or
           studentPictureBox.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

End Class