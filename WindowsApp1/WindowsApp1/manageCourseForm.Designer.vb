<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageCourseForm
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
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.creditNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.coursesListBox = New System.Windows.Forms.ListBox()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        CType(Me.creditNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleTextBox
        '
        Me.titleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.titleTextBox.Location = New System.Drawing.Point(69, 165)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(386, 30)
        Me.titleTextBox.TabIndex = 33
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.idTextBox.Location = New System.Drawing.Point(69, 84)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(386, 30)
        Me.idTextBox.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(64, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Course Code"
        '
        'creditNumericUpDown
        '
        Me.creditNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditNumericUpDown.Location = New System.Drawing.Point(69, 244)
        Me.creditNumericUpDown.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.creditNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.creditNumericUpDown.Name = "creditNumericUpDown"
        Me.creditNumericUpDown.Size = New System.Drawing.Size(386, 30)
        Me.creditNumericUpDown.TabIndex = 30
        Me.creditNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTextBox.Location = New System.Drawing.Point(67, 342)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(295, 101)
        Me.descriptionTextBox.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(63, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(64, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Credits"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Course Title"
        '
        'coursesListBox
        '
        Me.coursesListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.coursesListBox.FormattingEnabled = True
        Me.coursesListBox.ItemHeight = 29
        Me.coursesListBox.Location = New System.Drawing.Point(542, 70)
        Me.coursesListBox.Name = "coursesListBox"
        Me.coursesListBox.Size = New System.Drawing.Size(431, 468)
        Me.coursesListBox.TabIndex = 34
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(118, 460)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(75, 36)
        Me.previousButton.TabIndex = 35
        Me.previousButton.Text = "<<"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(254, 460)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 36)
        Me.nextButton.TabIndex = 36
        Me.nextButton.Text = ">>"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(323, 515)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(75, 39)
        Me.deleteButton.TabIndex = 40
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(199, 515)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 39)
        Me.editButton.TabIndex = 39
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(71, 515)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 39)
        Me.addButton.TabIndex = 38
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'manageCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1057, 658)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.coursesListBox)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.creditNumericUpDown)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "manageCourseForm"
        Me.Text = "manageCourseForm"
        CType(Me.creditNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents creditNumericUpDown As NumericUpDown
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents coursesListBox As ListBox
    Friend WithEvents previousButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents addButton As Button
End Class
