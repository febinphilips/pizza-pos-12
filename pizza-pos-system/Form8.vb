Imports System.Data.SqlClient

Public Class Form8
    Private _form5Instance As Form5

    Public Sub SetForm5Instance(ByVal form5Instance As Form5)
        _form5Instance = form5Instance
    End Sub

    Public Sub CheckInstance(ByVal text As String, ByVal price As Decimal)
        If _form5Instance IsNot Nothing Then
            _form5Instance.AddTextToListBox(text, price)
        End If
    End Sub

    Private Sub DisplayBeverageOptions()
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT Items, Price FROM Beverages"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    Do While reader.Read()
                        Dim name As String = reader("Items").ToString()
                        Dim price As Decimal = Convert.ToDecimal(reader("Price"))

                        Dim index As Integer = name.IndexOf("(")
                        Dim firstWord As String = name.Substring(0, index)
                        Dim restOfText As String = name.Substring(index)

                        Dim buttonSide As New Button()
                        buttonSide.Text = firstWord & Environment.NewLine & restOfText
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

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBeverageOptions()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
