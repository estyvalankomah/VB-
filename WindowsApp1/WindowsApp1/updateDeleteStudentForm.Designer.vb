<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateDeleteStudentForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.deleteStudentButton = New System.Windows.Forms.Button()
        Me.updateStudentButton = New System.Windows.Forms.Button()
        Me.uploadButton = New System.Windows.Forms.Button()
        Me.studentPictureBox = New System.Windows.Forms.PictureBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contactTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.femaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.maleRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 365)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 55)
        Me.GroupBox1.TabIndex = 33
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(58, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 29)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Gender"
        '
        'deleteStudentButton
        '
        Me.deleteStudentButton.BackColor = System.Drawing.Color.Red
        Me.deleteStudentButton.ForeColor = System.Drawing.Color.White
        Me.deleteStudentButton.Location = New System.Drawing.Point(600, 635)
        Me.deleteStudentButton.Name = "deleteStudentButton"
        Me.deleteStudentButton.Size = New System.Drawing.Size(112, 40)
        Me.deleteStudentButton.TabIndex = 31
        Me.deleteStudentButton.Text = "Delete"
        Me.deleteStudentButton.UseVisualStyleBackColor = False
        '
        'updateStudentButton
        '
        Me.updateStudentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.updateStudentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.updateStudentButton.ForeColor = System.Drawing.Color.White
        Me.updateStudentButton.Location = New System.Drawing.Point(427, 635)
        Me.updateStudentButton.Name = "updateStudentButton"
        Me.updateStudentButton.Size = New System.Drawing.Size(112, 40)
        Me.updateStudentButton.TabIndex = 30
        Me.updateStudentButton.Text = "Save"
        Me.updateStudentButton.UseVisualStyleBackColor = False
        '
        'uploadButton
        '
        Me.uploadButton.Location = New System.Drawing.Point(742, 296)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(187, 39)
        Me.uploadButton.TabIndex = 29
        Me.uploadButton.Text = "Upload Image"
        Me.uploadButton.UseVisualStyleBackColor = True
        '
        'studentPictureBox
        '
        Me.studentPictureBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.studentPictureBox.Location = New System.Drawing.Point(742, 80)
        Me.studentPictureBox.Name = "studentPictureBox"
        Me.studentPictureBox.Size = New System.Drawing.Size(187, 200)
        Me.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentPictureBox.TabIndex = 28
        Me.studentPictureBox.TabStop = False
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.Location = New System.Drawing.Point(62, 526)
        Me.addressTextBox.Multiline = True
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(467, 98)
        Me.addressTextBox.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(57, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Address"
        '
        'contactTextBox
        '
        Me.contactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTextBox.Location = New System.Drawing.Point(62, 456)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.Size = New System.Drawing.Size(466, 35)
        Me.contactTextBox.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(57, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 29)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Contact"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(63, 327)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(462, 26)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 29)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date of Birth"
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnameTextBox.Location = New System.Drawing.Point(59, 242)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(466, 35)
        Me.lnameTextBox.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(58, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Last Name"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnameTextBox.Location = New System.Drawing.Point(63, 166)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(466, 35)
        Me.fnameTextBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "First Name"
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(63, 80)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(466, 35)
        Me.IDTextBox.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(58, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 29)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "ID"
        '
        'updateDeleteStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1035, 696)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.deleteStudentButton)
        Me.Controls.Add(Me.updateStudentButton)
        Me.Controls.Add(Me.uploadButton)
        Me.Controls.Add(Me.studentPictureBox)
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
        Me.Name = "updateDeleteStudentForm"
        Me.Text = "updateDeleteStudentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents deleteStudentButton As Button
    Friend WithEvents updateStudentButton As Button
    Friend WithEvents uploadButton As Button
    Friend WithEvents studentPictureBox As PictureBox
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents contactTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fnameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label6 As Label
End Class
