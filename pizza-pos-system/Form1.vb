Imports System.Data.SqlClient
Public Class Form1
    ' Your connection string to the SQL Server
    Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

    Private Sub LinkLabelDirect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDirect.LinkClicked
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonLogIn_Click(sender As Object, e As EventArgs) Handles ButtonLogIn.Click
        ' Check if user ID and password are provided
        If TextBoxUser.Text.Trim() = "" OrElse TextBoxPass.Text.Trim() = "" Then
            MessageBox.Show("Please enter User ID and Password.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the user ID exists and the password is correct
        If ValidateUser(TextBoxUser.Text, TextBoxPass.Text) Then
            UserId = TextBoxUser.Text
            UserName = GetUserName(UserId)

            'MessageBox.Show($"User ID: {UserId}, User Name: {UserName}", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form3 As New Form3()
            form3.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid User ID or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function GetUserName(userId As String) As String
        Dim userName As String = ""
        Dim query As String = "SELECT UserName FROM Users WHERE UserId = @userid"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userid", userId)
                connection.Open()
                userName = Convert.ToString(command.ExecuteScalar())
            End Using
        End Using
        Return userName
    End Function

    ' Function to validate user ID and password
    Private Function ValidateUser(userId As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserId = @userid AND UserPassword = @password"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userid", userId)
                command.Parameters.AddWithValue("@password", password)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

End Class
