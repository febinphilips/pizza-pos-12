Imports System.Data.SqlClient

Public Class Form2
    ' Your connection string to the SQL Server
    Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        ' Check if all textboxes have values
        If TextBoxName.Text.Trim() = "" OrElse TextBoxUserId.Text.Trim() = "" OrElse TextBoxPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter all details to create a new user.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the user already exists in the database
        If UserExists(TextBoxUserId.Text) Then
            MessageBox.Show("User with the provided User ID already exists. Please provide a different User ID.", "User Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Generate a user number
        Dim userNumber As Integer = GetUserNumber()

        ' Insert the user's information into the 'Users' table
        Dim query As String = "INSERT INTO Users (UserNo, UserName, UserId, UserPassword) VALUES (@userno, @name, @userid, @password)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userno", userNumber)
                command.Parameters.AddWithValue("@name", TextBoxName.Text)
                command.Parameters.AddWithValue("@userid", TextBoxUserId.Text)
                command.Parameters.AddWithValue("@password", TextBoxPassword.Text)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        ' Display a message box
        Dim result As DialogResult = MessageBox.Show("User created successfully with User Number: " & userNumber & ". Click OK to return to login page.", "User Created", MessageBoxButtons.OK)

        ' Check if the OK button was clicked
        If result = DialogResult.OK Then
            ' Show Form1 (Login Page) and hide Form2 (Create User Page)
            Dim form1 As New Form1()
            form1.Show()
            Me.Hide()
        End If
    End Sub

    ' Function to check if a user with the given User ID already exists
    Private Function UserExists(userId As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserId = @userid"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userid", userId)
                connection.Open()
                command.CommandTimeout = 30 ' Set command timeout to 30 seconds
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Function GetUserNumber() As Integer
        Dim lastUserNumber As Integer = 0
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT MAX(CAST(UserNo AS INT)) FROM Users"
            Using command As New SqlCommand(query, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    lastUserNumber = Convert.ToInt32(result)
                End If
            End Using
        End Using

        ' Increment the last user number by 1 to get the next user number
        Return lastUserNumber + 1
    End Function

End Class
