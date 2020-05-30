Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundImage = Image.FromFile("../../Images/student.jpg")

    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click

        Dim newStudForm As New addStudentForm()
        newStudForm.Show(Me)

    End Sub

    Private Sub ViewStudentsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentsListToolStripMenuItem.Click

        Dim studListForm As New studentListForm()
        studListForm.Show(Me)

    End Sub

    Private Sub EditDeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDeleteStudentToolStripMenuItem.Click

        Dim updateDelStud As New updateDeleteStudentForm()
        updateDelStud.Show(Me)

    End Sub

    Private Sub AddNewCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCourseToolStripMenuItem.Click

        Dim addCourse As New addCourseForm()
        addCourse.Show(Me)
    End Sub

    Private Sub DeleteCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCourseToolStripMenuItem.Click

        Dim delCourse As New deleteCourseForm()
        delCourse.Show(Me)

    End Sub

    Private Sub EditCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCourseToolStripMenuItem.Click

        Dim editCourse As New editCourseForm()
        editCourse.Show(Me)

    End Sub

    Private Sub ManageCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCoursesToolStripMenuItem.Click

        Dim manageCourses As New manageCourseForm()
        manageCourses.Show(Me)

    End Sub

    Private Sub AddGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGradesToolStripMenuItem.Click

        Dim addGrade As New addGradeForm()
        addGrade.Show(Me)

    End Sub

    Private Sub DeleteGradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteGradeToolStripMenuItem.Click

        Dim delGrade As New removeGradeForm()
        delGrade.Show(Me)

    End Sub

    Private Sub ManageGradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGradeToolStripMenuItem.Click

        Dim manageGrade As New manageGradeForm()
        manageGrade.Show(Me)

    End Sub
End Class