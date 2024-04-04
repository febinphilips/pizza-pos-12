Imports System.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show($"User ID: {UserId}, User Name: {UserName}", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LabelUserId.Text = UserId
        LabelUserName.Text = $"{UserName}!"
    End Sub

    Private Sub ButtonEditProfile_Click(sender As Object, e As EventArgs) Handles ButtonEditProfile.Click
        Dim newName As String = InputBox("Enter your new name:", "Edit Profile", UserName)
        If newName <> "" Then
            ' Update the user's name in the database
            UpdateUserName(UserId, newName)

            ' Update the global UserName variable and LabelUserName
            UserName = newName
            LabelUserName.Text = $"{UserName}!"
        End If
    End Sub

    Private Sub ButtonChangePassword_Click(sender As Object, e As EventArgs) Handles ButtonChangePassword.Click
        ' Ask the user for the existing password
        Dim existingPassword As String = InputBox("Enter your existing password:", "Change Password")
        If existingPassword = "" Then
            Exit Sub
        End If

        ' Check if the existing password is correct
        If ValidatePassword(UserId, existingPassword) Then
            ' Ask the user for the new password
            Dim newPassword As String = InputBox("Enter your new password:", "Change Password")
            If newPassword <> "" Then
                ' Update the user's password in the database
                UpdateUserPassword(UserId, newPassword)

                ' Inform the user that the password has been changed
                MessageBox.Show("Password changed successfully. You will now be logged out.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Logout the user
                ButtonLogOut.PerformClick()
            End If
        Else
            MessageBox.Show("Invalid existing password. Please try again.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub UpdateUserName(userId As String, newName As String)
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

        ' Update the UserName in the database
        Dim query As String = "UPDATE Users SET UserName = @newName WHERE UserId = @userId"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)
                command.Parameters.AddWithValue("@newName", newName)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdateUserPassword(userId As String, newPassword As String)
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

        ' Update the UserPassword in the database
        Dim query As String = "UPDATE Users SET UserPassword = @newPassword WHERE UserId = @userId"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)
                command.Parameters.AddWithValue("@newPassword", newPassword)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Function ValidatePassword(userId As String, password As String) As Boolean
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

        ' Validate the password against the one stored in the database
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserId = @userId AND UserPassword = @password"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)
                command.Parameters.AddWithValue("@password", password)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogOut.Click
        ' Empty the global UserName and UserId strings
        UserName = ""
        UserId = ""

        ' Close Form3 (Dashboard)
        Dim parentForm As Form = Me.ParentForm
        If parentForm IsNot Nothing Then
            parentForm.Close()
        End If

        ' Show Form1 (Login Page)
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub

End Class
