<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addGradeForm
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
        Me.scoreTextBox = New System.Windows.Forms.TextBox()
        Me.studentIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.courseCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.addGradeButton = New System.Windows.Forms.Button()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.studentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scoreTextBox
        '
        Me.scoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.scoreTextBox.Location = New System.Drawing.Point(62, 235)
        Me.scoreTextBox.Name = "scoreTextBox"
        Me.scoreTextBox.Size = New System.Drawing.Size(386, 30)
        Me.scoreTextBox.TabIndex = 37
        '
        'studentIDTextBox
        '
        Me.studentIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.studentIDTextBox.Location = New System.Drawing.Point(61, 69)
        Me.studentIDTextBox.Name = "studentIDTextBox"
        Me.studentIDTextBox.Size = New System.Drawing.Size(386, 30)
        Me.studentIDTextBox.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Enter Student ID"
        '
        'courseCodeComboBox
        '
        Me.courseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.courseCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.courseCodeComboBox.FormattingEnabled = True
        Me.courseCodeComboBox.Location = New System.Drawing.Point(62, 159)
        Me.courseCodeComboBox.Name = "courseCodeComboBox"
        Me.courseCodeComboBox.Size = New System.Drawing.Size(385, 33)
        Me.courseCodeComboBox.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(306, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'addGradeButton
        '
        Me.addGradeButton.Location = New System.Drawing.Point(119, 417)
        Me.addGradeButton.Name = "addGradeButton"
        Me.addGradeButton.Size = New System.Drawing.Size(97, 39)
        Me.addGradeButton.TabIndex = 31
        Me.addGradeButton.Text = "Add Grade"
        Me.addGradeButton.UseVisualStyleBackColor = True
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeTextBox.Location = New System.Drawing.Point(62, 323)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Size = New System.Drawing.Size(389, 30)
        Me.gradeTextBox.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(58, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Score"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Select course code"
        '
        'studentsDataGridView
        '
        Me.studentsDataGridView.AllowUserToAddRows = False
        Me.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentsDataGridView.Location = New System.Drawing.Point(501, 47)
        Me.studentsDataGridView.Name = "studentsDataGridView"
        Me.studentsDataGridView.ReadOnly = True
        Me.studentsDataGridView.RowHeadersWidth = 62
        Me.studentsDataGridView.RowTemplate.Height = 28
        Me.studentsDataGridView.Size = New System.Drawing.Size(566, 414)
        Me.studentsDataGridView.TabIndex = 38
        '
        'addGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1096, 527)
        Me.Controls.Add(Me.studentsDataGridView)
        Me.Controls.Add(Me.scoreTextBox)
        Me.Controls.Add(Me.studentIDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.courseCodeComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.addGradeButton)
        Me.Controls.Add(Me.gradeTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addGradeForm"
        Me.Text = "addGradeForm"
        CType(Me.studentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoreTextBox As TextBox
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents courseCodeComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents addGradeButton As Button
    Friend WithEvents gradeTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studentsDataGridView As DataGridView
End Class
