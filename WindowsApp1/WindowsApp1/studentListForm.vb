Imports System.IO
Imports MySql.Data.MySqlClient

Public Class studentListForm

    Dim student As New Student()
    Dim command As New MySqlCommand("SELECT * FROM `student`")
    Private Sub studentListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim total As Integer = Convert.ToInt32(student.totalStudents())
        Dim totalMales As Integer = Convert.ToInt32(student.totalMaleStudents())
        Dim totalFemales As Integer = Convert.ToInt32(student.totalFemaleStudents())

        totalLabel.Text = " Total Students : " & total.ToString()
        maleLabel.Text = " Males : " & totalMales.ToString()
        femaleLabel.Text = " Females : " & totalFemales.ToString()

        fillGrid(command)

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Dim updateDelStudForm As New updateDeleteStudentForm()

        updateDelStudForm.IDTextBox.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        updateDelStudForm.fnameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        updateDelStudForm.lnameTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        updateDelStudForm.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value

        If DataGridView1.CurrentRow.Cells(4).Value.ToString() = "Female" Then
            updateDelStudForm.femaleRadioButton.Checked = True
        End If

        updateDelStudForm.contactTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        updateDelStudForm.addressTextBox.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()

        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        updateDelStudForm.studentPictureBox.Image = Image.FromStream(picture)

        updateDelStudForm.Show()

    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click

        DataGridView1.DataSource = student.getStudents(command)

        Dim total As Integer = Convert.ToInt32(student.totalStudents())
        Dim totalMales As Integer = Convert.ToInt32(student.totalMaleStudents())
        Dim totalFemales As Integer = Convert.ToInt32(student.totalFemaleStudents())

        totalLabel.Text = " Total Students : " & total.ToString()
        maleLabel.Text = " Males : " & totalMales.ToString()
        femaleLabel.Text = " Females : " & totalFemales.ToString()

    End Sub

    Sub fillGrid(ByVal comm As MySqlCommand)

        DataGridView1.DataSource = student.getStudents(comm)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True

        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False

    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim comm As New MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`firstName`,`lastName`)LIKE'%" & searchTextBox.Text & "%'")
        fillGrid(comm)

    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

        Dim comm As New MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`firstName`,`lastName`)LIKE'%" & searchTextBox.Text & "%'")
        fillGrid(comm)

    End Sub
End Class