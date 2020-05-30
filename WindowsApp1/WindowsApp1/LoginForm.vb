Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loginPictureBox.ImageLocation = "../../Images/student.jpg"

    End Sub

    Private Sub passwordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles passwordCheckBox.CheckedChanged

        If passwordText.UseSystemPasswordChar Then
            passwordText.UseSystemPasswordChar = False

        Else
            passwordText.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim db As New Database()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `admin` WHERE `username` = @usn AND `password` = @pass", db.getConnection)

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usernameText.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordText.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            Dim fmain As New MainForm()
            fmain.Show()
            Me.Close()

        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Critical, "Login failed")

        End If

    End Sub
End Class