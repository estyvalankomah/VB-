<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCourseForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.courseCodeTextBox = New System.Windows.Forms.TextBox()
        Me.courseTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addCourseButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.creditNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.creditNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Code"
        '
        'courseCodeTextBox
        '
        Me.courseCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseCodeTextBox.Location = New System.Drawing.Point(53, 75)
        Me.courseCodeTextBox.Name = "courseCodeTextBox"
        Me.courseCodeTextBox.Size = New System.Drawing.Size(387, 30)
        Me.courseCodeTextBox.TabIndex = 1
        '
        'courseTitleTextBox
        '
        Me.courseTitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseTitleTextBox.Location = New System.Drawing.Point(52, 169)
        Me.courseTitleTextBox.Name = "courseTitleTextBox"
        Me.courseTitleTextBox.Size = New System.Drawing.Size(387, 30)
        Me.courseTitleTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Credits"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTextBox.Location = New System.Drawing.Point(52, 349)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(295, 101)
        Me.descriptionTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Description"
        '
        'addCourseButton
        '
        Me.addCourseButton.Location = New System.Drawing.Point(146, 484)
        Me.addCourseButton.Name = "addCourseButton"
        Me.addCourseButton.Size = New System.Drawing.Size(75, 39)
        Me.addCourseButton.TabIndex = 8
        Me.addCourseButton.Text = "Add"
        Me.addCourseButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'creditNumericUpDown
        '
        Me.creditNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditNumericUpDown.Location = New System.Drawing.Point(53, 251)
        Me.creditNumericUpDown.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.creditNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.creditNumericUpDown.Name = "creditNumericUpDown"
        Me.creditNumericUpDown.Size = New System.Drawing.Size(386, 30)
        Me.creditNumericUpDown.TabIndex = 10
        Me.creditNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'addCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(544, 566)
        Me.Controls.Add(Me.creditNumericUpDown)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.addCourseButton)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.courseTitleTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.courseCodeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addCourseForm"
        Me.Text = "addCourseForm"
        CType(Me.creditNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents courseCodeTextBox As TextBox
    Friend WithEvents courseTitleTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addCourseButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents creditNumericUpDown As NumericUpDown
End Class
