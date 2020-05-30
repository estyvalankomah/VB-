<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteCourseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.courseIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteCourseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'courseIDTextBox
        '
        Me.courseIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseIDTextBox.Location = New System.Drawing.Point(83, 124)
        Me.courseIDTextBox.Name = "courseIDTextBox"
        Me.courseIDTextBox.Size = New System.Drawing.Size(387, 30)
        Me.courseIDTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter the course code"
        '
        'deleteCourseButton
        '
        Me.deleteCourseButton.Location = New System.Drawing.Point(233, 212)
        Me.deleteCourseButton.Name = "deleteCourseButton"
        Me.deleteCourseButton.Size = New System.Drawing.Size(75, 39)
        Me.deleteCourseButton.TabIndex = 10
        Me.deleteCourseButton.Text = "Delete"
        Me.deleteCourseButton.UseVisualStyleBackColor = True
        '
        'deleteCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(566, 339)
        Me.Controls.Add(Me.deleteCourseButton)
        Me.Controls.Add(Me.courseIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "deleteCourseForm"
        Me.Text = "deleteCourseForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents courseIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents deleteCourseButton As Button
End Class
