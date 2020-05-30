<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class removeGradeForm
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.deleteGradeButton = New System.Windows.Forms.Button()
        CType(Me.gradeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gradeDataGridView
        '
        Me.gradeDataGridView.AllowUserToAddRows = False
        Me.gradeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gradeDataGridView.Location = New System.Drawing.Point(29, 52)
        Me.gradeDataGridView.Name = "gradeDataGridView"
        Me.gradeDataGridView.ReadOnly = True
        Me.gradeDataGridView.RowHeadersWidth = 62
        Me.gradeDataGridView.RowTemplate.Height = 28
        Me.gradeDataGridView.Size = New System.Drawing.Size(1217, 538)
        Me.gradeDataGridView.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(682, 629)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 47)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'deleteGradeButton
        '
        Me.deleteGradeButton.Location = New System.Drawing.Point(507, 629)
        Me.deleteGradeButton.Name = "deleteGradeButton"
        Me.deleteGradeButton.Size = New System.Drawing.Size(143, 47)
        Me.deleteGradeButton.TabIndex = 43
        Me.deleteGradeButton.Text = "Delete Grade"
        Me.deleteGradeButton.UseVisualStyleBackColor = True
        '
        'removeGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 715)
        Me.Controls.Add(Me.gradeDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.deleteGradeButton)
        Me.Name = "removeGradeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "removeGradeForm"
        CType(Me.gradeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gradeDataGridView As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents deleteGradeButton As Button
End Class
