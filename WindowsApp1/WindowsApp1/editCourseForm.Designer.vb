<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editCourseForm
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
        Me.creditNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.editCourseButton = New System.Windows.Forms.Button()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.courseCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        CType(Me.creditNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'creditNumericUpDown
        '
        Me.creditNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditNumericUpDown.Location = New System.Drawing.Point(78, 294)
        Me.creditNumericUpDown.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.creditNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.creditNumericUpDown.Name = "creditNumericUpDown"
        Me.creditNumericUpDown.Size = New System.Drawing.Size(386, 30)
        Me.creditNumericUpDown.TabIndex = 20
        Me.creditNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(371, 527)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'editCourseButton
        '
        Me.editCourseButton.Location = New System.Drawing.Point(170, 527)
        Me.editCourseButton.Name = "editCourseButton"
        Me.editCourseButton.Size = New System.Drawing.Size(75, 39)
        Me.editCourseButton.TabIndex = 18
        Me.editCourseButton.Text = "Edit"
        Me.editCourseButton.UseVisualStyleBackColor = True
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTextBox.Location = New System.Drawing.Point(76, 392)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(295, 101)
        Me.descriptionTextBox.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(72, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(73, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Credits"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(72, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Course Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select course code"
        '
        'courseCodeComboBox
        '
        Me.courseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.courseCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.courseCodeComboBox.FormattingEnabled = True
        Me.courseCodeComboBox.Location = New System.Drawing.Point(76, 53)
        Me.courseCodeComboBox.Name = "courseCodeComboBox"
        Me.courseCodeComboBox.Size = New System.Drawing.Size(385, 33)
        Me.courseCodeComboBox.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(73, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Course Code"
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.idTextBox.Location = New System.Drawing.Point(78, 134)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(386, 30)
        Me.idTextBox.TabIndex = 24
        '
        'titleTextBox
        '
        Me.titleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.titleTextBox.Location = New System.Drawing.Point(78, 215)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(386, 30)
        Me.titleTextBox.TabIndex = 25
        '
        'editCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(581, 599)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.courseCodeComboBox)
        Me.Controls.Add(Me.creditNumericUpDown)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.editCourseButton)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "editCourseForm"
        Me.Text = "editCourseForm"
        CType(Me.creditNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents creditNumericUpDown As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents editCourseButton As Button
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents courseCodeComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents titleTextBox As TextBox
End Class
