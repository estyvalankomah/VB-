<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDeleteStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTToolStripMenuItem, Me.CUToolStripMenuItem, Me.GRADESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1001, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.ViewStudentsListToolStripMenuItem, Me.EditDeleteStudentToolStripMenuItem})
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(113, 29)
        Me.STUDENTToolStripMenuItem.Text = "STUDENTS"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'ViewStudentsListToolStripMenuItem
        '
        Me.ViewStudentsListToolStripMenuItem.Name = "ViewStudentsListToolStripMenuItem"
        Me.ViewStudentsListToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.ViewStudentsListToolStripMenuItem.Text = "View Students List"
        '
        'EditDeleteStudentToolStripMenuItem
        '
        Me.EditDeleteStudentToolStripMenuItem.Name = "EditDeleteStudentToolStripMenuItem"
        Me.EditDeleteStudentToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.EditDeleteStudentToolStripMenuItem.Text = "Edit / Delete Student"
        '
        'CUToolStripMenuItem
        '
        Me.CUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCourseToolStripMenuItem, Me.DeleteCourseToolStripMenuItem, Me.EditCourseToolStripMenuItem, Me.ManageCoursesToolStripMenuItem})
        Me.CUToolStripMenuItem.Name = "CUToolStripMenuItem"
        Me.CUToolStripMenuItem.Size = New System.Drawing.Size(105, 29)
        Me.CUToolStripMenuItem.Text = "COURSES"
        '
        'AddNewCourseToolStripMenuItem
        '
        Me.AddNewCourseToolStripMenuItem.Name = "AddNewCourseToolStripMenuItem"
        Me.AddNewCourseToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.AddNewCourseToolStripMenuItem.Text = "Add New Course"
        '
        'DeleteCourseToolStripMenuItem
        '
        Me.DeleteCourseToolStripMenuItem.Name = "DeleteCourseToolStripMenuItem"
        Me.DeleteCourseToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.DeleteCourseToolStripMenuItem.Text = "Delete Course"
        '
        'EditCourseToolStripMenuItem
        '
        Me.EditCourseToolStripMenuItem.Name = "EditCourseToolStripMenuItem"
        Me.EditCourseToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.EditCourseToolStripMenuItem.Text = "Edit Course"
        '
        'ManageCoursesToolStripMenuItem
        '
        Me.ManageCoursesToolStripMenuItem.Name = "ManageCoursesToolStripMenuItem"
        Me.ManageCoursesToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.ManageCoursesToolStripMenuItem.Text = "Manage Courses"
        '
        'GRADESToolStripMenuItem
        '
        Me.GRADESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddGradesToolStripMenuItem, Me.DeleteGradeToolStripMenuItem, Me.ManageGradeToolStripMenuItem})
        Me.GRADESToolStripMenuItem.Name = "GRADESToolStripMenuItem"
        Me.GRADESToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.GRADESToolStripMenuItem.Text = "GRADES"
        '
        'AddGradesToolStripMenuItem
        '
        Me.AddGradesToolStripMenuItem.Name = "AddGradesToolStripMenuItem"
        Me.AddGradesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AddGradesToolStripMenuItem.Text = "Add Grade"
        '
        'DeleteGradeToolStripMenuItem
        '
        Me.DeleteGradeToolStripMenuItem.Name = "DeleteGradeToolStripMenuItem"
        Me.DeleteGradeToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DeleteGradeToolStripMenuItem.Text = "Delete Grade"
        '
        'ManageGradeToolStripMenuItem
        '
        Me.ManageGradeToolStripMenuItem.Name = "ManageGradeToolStripMenuItem"
        Me.ManageGradeToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ManageGradeToolStripMenuItem.Text = "Manage Grade"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 773)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STUDENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GRADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStudentsListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDeleteStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddGradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteGradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageGradeToolStripMenuItem As ToolStripMenuItem
End Class
