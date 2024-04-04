Imports System.Data.SqlClient

Public Class Form9
    Private _form5Instance As Form5

    Public Sub SetForm5Instance(ByVal form5Instance As Form5)
        _form5Instance = form5Instance
    End Sub

    Public Sub CheckInstance(ByVal text As String, ByVal price As Decimal)
        If _form5Instance IsNot Nothing Then
            _form5Instance.AddTextToListBox(text, price)
        End If
    End Sub

    Private Sub DisplaySideOptionsFromDatabase()
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT Items, Price FROM Sides"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    Do While reader.Read()
                        Dim name As String = reader("Items").ToString()
                        Dim price As Decimal = Convert.ToDecimal(reader("Price"))

                        Dim buttonSide As New Button()
                        buttonSide.Text = name
                        buttonSide.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
                        buttonSide.BackColor = Color.White
                        buttonSide.Size = New Size(186, 156)
                        buttonSide.Location = New Point(60 + (Panel1.Controls.Count * 210), 106) ' Increase the Y position for each button
                        Panel1.Controls.Add(buttonSide)

                        AddHandler buttonSide.Click, Sub(sender, e)
                                                         CheckInstance(name, price)
                                                     End Sub
                    Loop
                End Using
            End Using
        End Using
    End Sub


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySideOptionsFromDatabase()
    End Sub
End Class
