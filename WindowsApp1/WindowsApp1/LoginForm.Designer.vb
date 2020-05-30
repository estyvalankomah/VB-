<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameText = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.passwordCheckBox = New System.Windows.Forms.CheckBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.loginPictureBox = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.loginPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(68, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'usernameText
        '
        Me.usernameText.Location = New System.Drawing.Point(73, 119)
        Me.usernameText.Name = "usernameText"
        Me.usernameText.Size = New System.Drawing.Size(385, 26)
        Me.usernameText.TabIndex = 3
        Me.usernameText.Text = "Abena Mmra"
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(73, 241)
        Me.passwordText.Multiline = True
        Me.passwordText.Name = "passwordText"
        Me.passwordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordText.Size = New System.Drawing.Size(385, 26)
        Me.passwordText.TabIndex = 4
        Me.passwordText.Text = "29677777"
        '
        'passwordCheckBox
        '
        Me.passwordCheckBox.AutoSize = True
        Me.passwordCheckBox.Location = New System.Drawing.Point(73, 274)
        Me.passwordCheckBox.Name = "passwordCheckBox"
        Me.passwordCheckBox.Size = New System.Drawing.Size(148, 24)
        Me.passwordCheckBox.TabIndex = 5
        Me.passwordCheckBox.Text = "Show Password"
        Me.passwordCheckBox.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.GhostWhite
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Location = New System.Drawing.Point(243, 356)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(104, 37)
        Me.loginButton.TabIndex = 6
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'loginPictureBox
        '
        Me.loginPictureBox.Location = New System.Drawing.Point(567, 0)
        Me.loginPictureBox.Name = "loginPictureBox"
        Me.loginPictureBox.Size = New System.Drawing.Size(360, 585)
        Me.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loginPictureBox.TabIndex = 7
        Me.loginPictureBox.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(927, 583)
        Me.Controls.Add(Me.loginPictureBox)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordCheckBox)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.usernameText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.loginPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameText As TextBox
    Friend WithEvents passwordText As TextBox
    Friend WithEvents passwordCheckBox As CheckBox
    Friend WithEvents loginButton As Button
    Friend WithEvents loginPictureBox As PictureBox
    Friend WithEvents BindingSource1 As BindingSource
End Class
