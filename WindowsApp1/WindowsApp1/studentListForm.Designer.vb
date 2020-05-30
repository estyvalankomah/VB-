<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentListForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.totalPanel = New System.Windows.Forms.Panel()
        Me.malePanel = New System.Windows.Forms.Panel()
        Me.femalePanel = New System.Windows.Forms.Panel()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.maleLabel = New System.Windows.Forms.Label()
        Me.femaleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.totalPanel.SuspendLayout()
        Me.malePanel.SuspendLayout()
        Me.femalePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Location = New System.Drawing.Point(99, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(747, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'refreshButton
        '
        Me.refreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.refreshButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.refreshButton.ForeColor = System.Drawing.Color.White
        Me.refreshButton.Location = New System.Drawing.Point(403, 622)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(177, 40)
        Me.refreshButton.TabIndex = 31
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = False
        '
        'totalPanel
        '
        Me.totalPanel.BackColor = System.Drawing.Color.Red
        Me.totalPanel.Controls.Add(Me.totalLabel)
        Me.totalPanel.Location = New System.Drawing.Point(512, 92)
        Me.totalPanel.Name = "totalPanel"
        Me.totalPanel.Size = New System.Drawing.Size(334, 30)
        Me.totalPanel.TabIndex = 32
        '
        'malePanel
        '
        Me.malePanel.BackColor = System.Drawing.Color.DarkTurquoise
        Me.malePanel.Controls.Add(Me.maleLabel)
        Me.malePanel.Location = New System.Drawing.Point(512, 122)
        Me.malePanel.Name = "malePanel"
        Me.malePanel.Size = New System.Drawing.Size(167, 30)
        Me.malePanel.TabIndex = 33
        '
        'femalePanel
        '
        Me.femalePanel.BackColor = System.Drawing.Color.PaleVioletRed
        Me.femalePanel.Controls.Add(Me.femaleLabel)
        Me.femalePanel.Location = New System.Drawing.Point(679, 122)
        Me.femalePanel.Name = "femalePanel"
        Me.femalePanel.Size = New System.Drawing.Size(167, 30)
        Me.femalePanel.TabIndex = 34
        '
        'totalLabel
        '
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.ForeColor = System.Drawing.Color.White
        Me.totalLabel.Location = New System.Drawing.Point(0, 0)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(331, 27)
        Me.totalLabel.TabIndex = 0
        Me.totalLabel.Text = "Total Students : 1000"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maleLabel
        '
        Me.maleLabel.AutoSize = True
        Me.maleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleLabel.ForeColor = System.Drawing.Color.White
        Me.maleLabel.Location = New System.Drawing.Point(21, 7)
        Me.maleLabel.Name = "maleLabel"
        Me.maleLabel.Size = New System.Drawing.Size(111, 20)
        Me.maleLabel.TabIndex = 0
        Me.maleLabel.Text = "Males : 1000"
        Me.maleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'femaleLabel
        '
        Me.femaleLabel.AutoSize = True
        Me.femaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleLabel.ForeColor = System.Drawing.Color.White
        Me.femaleLabel.Location = New System.Drawing.Point(17, 7)
        Me.femaleLabel.Name = "femaleLabel"
        Me.femaleLabel.Size = New System.Drawing.Size(127, 20)
        Me.femaleLabel.TabIndex = 1
        Me.femaleLabel.Text = "Females :1000"
        Me.femaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Enter search term"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(246, 36)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(264, 26)
        Me.searchTextBox.TabIndex = 36
        '
        'searchButton
        '
        Me.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.searchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.searchButton.ForeColor = System.Drawing.Color.White
        Me.searchButton.Location = New System.Drawing.Point(512, 34)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(90, 25)
        Me.searchButton.TabIndex = 37
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'studentListForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(935, 671)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.malePanel)
        Me.Controls.Add(Me.femalePanel)
        Me.Controls.Add(Me.totalPanel)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "studentListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "studentListForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.totalPanel.ResumeLayout(False)
        Me.malePanel.ResumeLayout(False)
        Me.malePanel.PerformLayout()
        Me.femalePanel.ResumeLayout(False)
        Me.femalePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents refreshButton As Button
    Friend WithEvents totalPanel As Panel
    Friend WithEvents malePanel As Panel
    Friend WithEvents femalePanel As Panel
    Friend WithEvents totalLabel As Label
    Friend WithEvents maleLabel As Label
    Friend WithEvents femaleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
End Class
