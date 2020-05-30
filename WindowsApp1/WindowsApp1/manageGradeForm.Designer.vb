<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageGradeForm
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
        Me.gradeDataGridView = New System.Windows.Forms.DataGridView()
        Me.scoreTextBox = New System.Windows.Forms.TextBox()
        Me.studentIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.courseCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.delGradeButton = New System.Windows.Forms.Button()
        Me.addGradeButton = New System.Windows.Forms.Button()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentsButton = New System.Windows.Forms.Button()
        Me.gradeButton = New System.Windows.Forms.Button()
        CType(Me.gradeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gradeDataGridView
        '
        Me.gradeDataGridView.AllowUserToAddRows = False
        Me.gradeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gradeDataGridView.Location = New System.Drawing.Point(443, 68)
        Me.gradeDataGridView.Name = "gradeDataGridView"
        Me.gradeDataGridView.ReadOnly = True
        Me.gradeDataGridView.RowHeadersWidth = 62
        Me.gradeDataGridView.RowTemplate.Height = 28
        Me.gradeDataGridView.Size = New System.Drawing.Size(810, 490)
        Me.gradeDataGridView.TabIndex = 49
        '
        'scoreTextBox
        '
        Me.scoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.scoreTextBox.Location = New System.Drawing.Point(23, 256)
        Me.scoreTextBox.Name = "scoreTextBox"
        Me.scoreTextBox.Size = New System.Drawing.Size(386, 30)
        Me.scoreTextBox.TabIndex = 48
        '
        'studentIDTextBox
        '
        Me.studentIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.studentIDTextBox.Location = New System.Drawing.Point(22, 90)
        Me.studentIDTextBox.Name = "studentIDTextBox"
        Me.studentIDTextBox.Size = New System.Drawing.Size(155, 30)
        Me.studentIDTextBox.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Student ID"
        '
        'courseCodeComboBox
        '
        Me.courseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.courseCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.courseCodeComboBox.FormattingEnabled = True
        Me.courseCodeComboBox.Location = New System.Drawing.Point(23, 180)
        Me.courseCodeComboBox.Name = "courseCodeComboBox"
        Me.courseCodeComboBox.Size = New System.Drawing.Size(385, 33)
        Me.courseCodeComboBox.TabIndex = 45
        '
        'delGradeButton
        '
        Me.delGradeButton.Location = New System.Drawing.Point(229, 438)
        Me.delGradeButton.Name = "delGradeButton"
        Me.delGradeButton.Size = New System.Drawing.Size(92, 39)
        Me.delGradeButton.TabIndex = 44
        Me.delGradeButton.Text = "Delete"
        Me.delGradeButton.UseVisualStyleBackColor = True
        '
        'addGradeButton
        '
        Me.addGradeButton.Location = New System.Drawing.Point(80, 438)
        Me.addGradeButton.Name = "addGradeButton"
        Me.addGradeButton.Size = New System.Drawing.Size(97, 39)
        Me.addGradeButton.TabIndex = 43
        Me.addGradeButton.Text = "Add"
        Me.addGradeButton.UseVisualStyleBackColor = True
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeTextBox.Location = New System.Drawing.Point(23, 344)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Size = New System.Drawing.Size(389, 30)
        Me.gradeTextBox.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Score"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Select course code"
        '
        'studentsButton
        '
        Me.studentsButton.Location = New System.Drawing.Point(443, 23)
        Me.studentsButton.Name = "studentsButton"
        Me.studentsButton.Size = New System.Drawing.Size(144, 39)
        Me.studentsButton.TabIndex = 50
        Me.studentsButton.Text = "Show Students"
        Me.studentsButton.UseVisualStyleBackColor = True
        '
        'gradeButton
        '
        Me.gradeButton.Location = New System.Drawing.Point(634, 23)
        Me.gradeButton.Name = "gradeButton"
        Me.gradeButton.Size = New System.Drawing.Size(144, 39)
        Me.gradeButton.TabIndex = 51
        Me.gradeButton.Text = "Show Grades"
        Me.gradeButton.UseVisualStyleBackColor = True
        '
        'manageGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1292, 618)
        Me.Controls.Add(Me.gradeButton)
        Me.Controls.Add(Me.studentsButton)
        Me.Controls.Add(Me.gradeDataGridView)
        Me.Controls.Add(Me.scoreTextBox)
        Me.Controls.Add(Me.studentIDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.courseCodeComboBox)
        Me.Controls.Add(Me.delGradeButton)
        Me.Controls.Add(Me.addGradeButton)
        Me.Controls.Add(Me.gradeTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "manageGradeForm"
        Me.Text = "manageGradeForm"
        CType(Me.gradeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gradeDataGridView As DataGridView
    Friend WithEvents scoreTextBox As TextBox
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents courseCodeComboBox As ComboBox
    Friend WithEvents delGradeButton As Button
    Friend WithEvents addGradeButton As Button
    Friend WithEvents gradeTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studentsButton As Button
    Friend WithEvents gradeButton As Button
End Class
