<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudentForm
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
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.contactTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.studentPictureBox = New System.Windows.Forms.PictureBox()
        Me.uploadButton = New System.Windows.Forms.Button()
        Me.saveStudentButton = New System.Windows.Forms.Button()
        Me.cancelStudentButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnameTextBox.Location = New System.Drawing.Point(43, 59)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(466, 35)
        Me.fnameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnameTextBox.Location = New System.Drawing.Point(43, 148)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(466, 35)
        Me.lnameTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(47, 247)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(462, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'contactTextBox
        '
        Me.contactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTextBox.Location = New System.Drawing.Point(47, 411)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.Size = New System.Drawing.Size(466, 35)
        Me.contactTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact"
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.Location = New System.Drawing.Point(47, 496)
        Me.addressTextBox.Multiline = True
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(466, 113)
        Me.addressTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(42, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(670, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Add Image"
        '
        'studentPictureBox
        '
        Me.studentPictureBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.studentPictureBox.Location = New System.Drawing.Point(675, 86)
        Me.studentPictureBox.Name = "studentPictureBox"
        Me.studentPictureBox.Size = New System.Drawing.Size(187, 200)
        Me.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentPictureBox.TabIndex = 11
        Me.studentPictureBox.TabStop = False
        '
        'uploadButton
        '
        Me.uploadButton.Location = New System.Drawing.Point(675, 302)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(187, 39)
        Me.uploadButton.TabIndex = 12
        Me.uploadButton.Text = "Upload Image"
        Me.uploadButton.UseVisualStyleBackColor = True
        '
        'saveStudentButton
        '
        Me.saveStudentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saveStudentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.saveStudentButton.ForeColor = System.Drawing.Color.White
        Me.saveStudentButton.Location = New System.Drawing.Point(360, 641)
        Me.saveStudentButton.Name = "saveStudentButton"
        Me.saveStudentButton.Size = New System.Drawing.Size(112, 40)
        Me.saveStudentButton.TabIndex = 13
        Me.saveStudentButton.Text = "Save"
        Me.saveStudentButton.UseVisualStyleBackColor = False
        '
        'cancelStudentButton
        '
        Me.cancelStudentButton.BackColor = System.Drawing.Color.Red
        Me.cancelStudentButton.ForeColor = System.Drawing.Color.White
        Me.cancelStudentButton.Location = New System.Drawing.Point(533, 641)
        Me.cancelStudentButton.Name = "cancelStudentButton"
        Me.cancelStudentButton.Size = New System.Drawing.Size(112, 40)
        Me.cancelStudentButton.TabIndex = 14
        Me.cancelStudentButton.Text = "Cancel"
        Me.cancelStudentButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Gender"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.femaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.maleRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 55)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.femaleRadioButton.ForeColor = System.Drawing.Color.White
        Me.femaleRadioButton.Location = New System.Drawing.Point(166, 11)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(120, 33)
        Me.femaleRadioButton.TabIndex = 1
        Me.femaleRadioButton.Text = "Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Checked = True
        Me.maleRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.maleRadioButton.ForeColor = System.Drawing.Color.White
        Me.maleRadioButton.Location = New System.Drawing.Point(6, 11)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(91, 33)
        Me.maleRadioButton.TabIndex = 0
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'addStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 762)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cancelStudentButton)
        Me.Controls.Add(Me.saveStudentButton)
        Me.Controls.Add(Me.uploadButton)
        Me.Controls.Add(Me.studentPictureBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.contactTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lnameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fnameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addStudentForm"
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents fnameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents contactTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents studentPictureBox As PictureBox
    Friend WithEvents uploadButton As Button
    Friend WithEvents saveStudentButton As Button
    Friend WithEvents cancelStudentButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents maleRadioButton As RadioButton
End Class
