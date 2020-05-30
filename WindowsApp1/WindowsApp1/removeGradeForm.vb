Public Class removeGradeForm

    Dim grade As New Grade()
    Private Sub removeGradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gradeDataGridView.DataSource = grade.getStudentGrade()

    End Sub

    Private Sub deleteGradeButton_Click(sender As Object, e As EventArgs) Handles deleteGradeButton.Click

        Dim studID As Integer = gradeDataGridView.CurrentRow.Cells(0).Value
        Dim courseID As String = gradeDataGridView.CurrentRow.Cells(3).Value

        If MsgBox("Are you sure you want to delete this grade?", MsgBoxStyle.YesNo, "Delete Grade") = MsgBoxResult.Yes Then

            If grade.deleteGrade(studID, courseID) Then

                MsgBox("Grade Deleted", MsgBoxStyle.Information, "Delete Grade")
                gradeDataGridView.DataSource = grade.getStudentGrade()

            Else

                MsgBox("Grade not deleted", MsgBoxStyle.Information, "Delete Grade")

            End If

        End If

    End Sub
End Class