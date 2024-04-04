Imports System.Data.SqlClient

Public Class Form7

    'Create instance of form5
    Private _form5Instance As Form5
    Public Sub SetForm5Instance(ByVal form5Instance As Form5)
        _form5Instance = form5Instance
    End Sub

    'Initialize BUttons
    Private buttonHalf As New Button()
    Private buttonFull As New Button()
    Private buttonPizzaOk As New Button()
    Private buttonPizzaCancel As New Button()
    Private LabelToppings As New Label()

    Public Sub New()
        InitializeComponent()

        ' Configure the 'half' button
        buttonHalf.Text = "Half"
        buttonHalf.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        buttonHalf.Size = New Size(ButtonVeg.Width, ButtonVeg.Height)
        buttonHalf.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Bottom
        buttonHalf.BackColor = Color.White
        buttonHalf.Visible = False
        AddHandler buttonHalf.Click, AddressOf ButtonHalf_Click

        ' Configure the 'full' button
        buttonFull.Text = "Full"
        buttonFull.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        buttonFull.Size = New Size(ButtonNonVeg.Width, ButtonNonVeg.Height)
        buttonFull.Anchor = AnchorStyles.Right Or AnchorStyles.Bottom Or AnchorStyles.Top
        buttonFull.BackColor = Color.White
        buttonFull.Visible = False
        AddHandler buttonFull.Click, AddressOf ButtonFull_Click

        ' Configure the 'ok' button
        buttonPizzaOk.Text = "OK"
        buttonPizzaOk.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        buttonPizzaOk.Size = New Size(94, 32)
        buttonPizzaOk.Location = New Point(1047, 340)
        buttonPizzaOk.Anchor = AnchorStyles.Right Or AnchorStyles.Bottom
        buttonPizzaOk.BackColor = Color.White
        buttonPizzaOk.Visible = False
        AddHandler buttonPizzaOk.Click, AddressOf ButtonPizzaOk_Click

        ' Configure the 'cancel' button
        buttonPizzaCancel.Text = "Cancel"
        buttonPizzaCancel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        buttonPizzaCancel.Size = New Size(94, 32)
        buttonPizzaCancel.Location = New Point(936, 340)
        buttonPizzaCancel.Anchor = AnchorStyles.Right Or AnchorStyles.Bottom
        buttonPizzaCancel.BackColor = Color.White
        buttonPizzaCancel.Visible = False
        AddHandler buttonPizzaCancel.Click, AddressOf ButtonPizzaCancel_Click

        LabelToppings.Text = "Toppings"
        LabelToppings.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        LabelToppings.Location = New Point(533, 34)
        ' LabelToppings.Size = New Size(159, 25)
        LabelToppings.Visible = False

        ' Add buttons to the panel
        Panel1.Controls.Add(buttonHalf)
        Panel1.Controls.Add(buttonFull)
        Panel1.Controls.Add(buttonPizzaOk)
        Panel1.Controls.Add(buttonPizzaCancel)
        Panel1.Controls.Add(LabelToppings)

    End Sub

    Private selectedPizzaType As String ' Variable to store the selected pizza type (Veg or NonVeg)
    Private Sub HidePreferenceButtons()
        ButtonVeg.Visible = False
        ButtonNonVeg.Visible = False
    End Sub
    Private Sub ButtonVeg_Click(sender As Object, e As EventArgs) Handles ButtonVeg.Click
        ' Set selected pizza type to Veg
        selectedPizzaType = "Veg"
        ' Remove existing pizza buttons
        HidePreferenceButtons()

        ' Show the 'half' and 'full' buttons
        buttonHalf.Location = New Point(ButtonVeg.Left, ButtonVeg.Top)
        buttonHalf.Visible = True

        buttonFull.Location = New Point(ButtonNonVeg.Left, ButtonNonVeg.Top)
        buttonFull.Visible = True

        ' Show the 'ok' and 'cancel' buttons
        buttonPizzaOk.Visible = True
        buttonPizzaCancel.Visible = True
    End Sub

    Private Sub ButtonNonVeg_Click(sender As Object, e As EventArgs) Handles ButtonNonVeg.Click
        ' Set selected pizza type to NonVeg
        selectedPizzaType = "NonVeg"
        ' Remove existing pizza buttons
        HidePreferenceButtons()

        ' Show the 'half' and 'full' buttons
        buttonHalf.Location = New Point(ButtonVeg.Left, ButtonVeg.Top)
        buttonHalf.Visible = True

        buttonFull.Location = New Point(ButtonNonVeg.Left, ButtonNonVeg.Top)
        buttonFull.Visible = True

        ' Show the 'ok' and 'cancel' buttons
        buttonPizzaOk.Visible = True
        buttonPizzaCancel.Visible = True
    End Sub
    Private Sub HideSizeButtons()
        buttonHalf.Visible = False
        buttonFull.Visible = False
    End Sub
    Private Sub ButtonHalf_Click(sender As Object, e As EventArgs)
        ' Remove existing pizza buttons
        HideSizeButtons()

        ' Display pizza options for Half based on the selected pizza type
        If selectedPizzaType = "Veg" Then
            DisplayVegPizzaOptions("Half")
        ElseIf selectedPizzaType = "NonVeg" Then
            DisplayNonVegPizzaOptions("Half")
        End If

    End Sub

    Private Sub ButtonFull_Click(sender As Object, e As EventArgs)
        ' Remove existing pizza buttons
        HideSizeButtons()

        ' Display pizza options for Full based on the selected pizza type
        If selectedPizzaType = "Veg" Then
            DisplayVegPizzaOptions("Full")
        ElseIf selectedPizzaType = "NonVeg" Then
            DisplayNonVegPizzaOptions("Full")
        End If

    End Sub
    Private Class Pizza
        Public Property Name As String
        Public Property Price As Decimal

        Public Sub New(ByVal name As String, ByVal price As Decimal)
            Me.Name = name
            Me.Price = price
        End Sub
    End Class

    Private item As String = ""
    Private price As Decimal = 0

    Private Sub UpdateItemAndPrice(ByVal pizzaName As String, ByVal size As String, ByVal basePrice As Decimal)
        ' Update the item string with the pizza name and size
        item += $"({size}) {pizzaName} Pizza"

        ' Update the price based on the size
        If size = "Full" Then
            price += basePrice * 2
        ElseIf size = "Half" Then
            price += basePrice
        End If

        ' Display item and price in a MessageBox for testing
        ' MessageBox.Show($"Item: {item}{Environment.NewLine}Price: {price.ToString("C")}")
    End Sub


    Private Sub DisplayVegPizzaOptions(ByVal size As String)
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT Items, Price FROM [VegPizzas]"

        Dim buttonCount As Integer = 0 ' Move the button count outside the loop

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    Do While reader.Read()
                        Dim item As String = reader("Items").ToString()
                        Dim price As Decimal

                        If Not reader.IsDBNull(reader.GetOrdinal("Price")) Then
                            price = Convert.ToDecimal(reader("Price"))
                        Else
                            ' Handle the case when Price is NULL
                            price = 0 ' Or any other default value
                        End If

                        Dim buttonPizza As New Button()
                        buttonPizza.Text = item
                        buttonPizza.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
                        buttonPizza.BackColor = Color.White
                        buttonPizza.Size = New Size(185, 156)
                        buttonPizza.Location = New Point(60 + (buttonCount * 210), 106)
                        Panel1.Controls.Add(buttonPizza)

                        AddHandler buttonPizza.Click, Sub(sender, e)
                                                          UpdateItemAndPrice(item, size, price)
                                                          DisplayToppingsForPizza(item, price)
                                                      End Sub

                        buttonCount += 1 ' Increment the button count
                    Loop
                End Using
            End Using
        End Using
    End Sub

    Private Sub DisplayNonVegPizzaOptions(ByVal size As String)
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT Items, Price FROM [NonVegPizzas]"

        Dim buttonCount As Integer = 0 ' Move the button count outside the loop

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    Do While reader.Read()
                        Dim item As String = reader("Items").ToString()
                        Dim price As Decimal

                        If Not reader.IsDBNull(reader.GetOrdinal("Price")) Then
                            price = Convert.ToDecimal(reader("Price"))
                        Else
                            ' Handle the case when Price is NULL
                            price = 0 ' Or any other default value
                        End If

                        Dim buttonPizza As New Button()
                        buttonPizza.Text = item
                        buttonPizza.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
                        buttonPizza.BackColor = Color.White
                        buttonPizza.Size = New Size(185, 156)
                        buttonPizza.Location = New Point(60 + (buttonCount * 210), 106)
                        Panel1.Controls.Add(buttonPizza)

                        AddHandler buttonPizza.Click, Sub(sender, e)
                                                          UpdateItemAndPrice(item, size, price)
                                                          DisplayToppingsForPizza(item, price)
                                                      End Sub

                        buttonCount += 1 ' Increment the button count
                    Loop
                End Using
            End Using
        End Using
    End Sub


    Private Class Topping
        Public Property Name As String
        Public Property Price As Decimal

        Public Sub New(ByVal name As String, ByVal price As Decimal)
            Me.Name = name
            Me.Price = price
        End Sub
    End Class

    Private Sub HandleToppingSelection(ByVal button As Button, ByVal topping As Topping)
        If button.BackColor = Color.LightBlue Then
            ' Topping is already selected, remove highlight and update item and price
            button.BackColor = Color.White
            item = item.Replace($" {topping.Name}", "")
            price -= topping.Price
        Else
            ' Topping is not selected, add highlight and update item and price
            button.BackColor = Color.LightBlue
            item += $" {topping.Name}"
            price += topping.Price
        End If

        ' Display the item and price in a message box for testing
        'MessageBox.Show($"Item: {item}, Price: {price}")
    End Sub
    Private Sub HidePizzaButtons()
        For Each control As Control In Panel1.Controls
            If TypeOf control Is Button AndAlso control IsNot buttonPizzaOk AndAlso control IsNot buttonPizzaCancel Then
                control.Visible = False
            End If
        Next
    End Sub
    Private Sub DisplayToppingsForPizza(ByVal pizzaName As String, ByVal pizzaPrice As Decimal)
        HidePizzaButtons()
        LabelToppings.Visible = True

        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT Items, Price FROM [Toppings]"

        Dim buttonCount As Integer = 0 ' Move the button count outside the loop

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    Do While reader.Read()
                        Dim toppingName As String = reader("Items").ToString()
                        Dim toppingPrice As Decimal

                        If Not reader.IsDBNull(reader.GetOrdinal("Price")) Then
                            toppingPrice = Convert.ToDecimal(reader("Price"))
                        Else
                            ' Handle the case when Price is NULL
                            toppingPrice = 0 ' Or any other default value
                        End If

                        Dim buttonTopping As New Button()
                        buttonTopping.Text = $"{toppingName}"
                        buttonTopping.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
                        buttonTopping.BackColor = Color.White
                        buttonTopping.Size = New Size(185, 156)
                        buttonTopping.Location = New Point(60 + (buttonCount * 210), 106) ' Adjust the location based on the button count
                        Panel1.Controls.Add(buttonTopping)

                        AddHandler buttonTopping.Click, Sub(sender, e)
                                                            Dim selectedTopping As New Topping(toppingName, toppingPrice)
                                                            HandleToppingSelection(buttonTopping, selectedTopping)
                                                        End Sub

                        ' Increment the button count
                        buttonCount += 1
                    Loop
                End Using
            End Using
        End Using
    End Sub


    Private Sub ButtonPizzaOk_Click(sender As Object, e As EventArgs)
        ' Add the selected item to the listbox in Form5
        If item <> "" Then
            If _form5Instance IsNot Nothing AndAlso Not String.IsNullOrEmpty(item) Then
                _form5Instance.AddTextToListBox(item, price)
            End If
        End If

        ' Reset the item and price variables for the next order
        item = ""
        price = 0

        ' Display a new instance of Form7 inside Panel1 of Form5
        _form5Instance.DisplayForm(New Form7())
    End Sub

    Private Sub ButtonPizzaCancel_Click(sender As Object, e As EventArgs)
        ' Reset the item and price variables
        item = ""
        price = 0

        _form5Instance.DisplayForm(New Form7())
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
