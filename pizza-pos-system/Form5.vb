Imports System.Data.SqlClient
Public Class Form5

    Public Sub AddTextToListBox(ByVal text As String, ByVal price As Decimal)
        ' Check if the item already exists in the ListBoxItem
        Dim index As Integer = ListBoxItem.Items.IndexOf(text)

        If index <> -1 Then
            ' Item already exists, increment the quantity in ListBoxQty and update the total price in ListBoxPrice
            Dim qty As Integer = CInt(ListBoxQty.Items(index))
            ListBoxQty.Items(index) = qty + 1
            ListBoxPrice.Items(index) = (qty + 1) * price
            UpdateTotal()
        Else
            ' Item does not exist, add it to ListBoxItem, set quantity to 1, and add the price to ListBoxPrice
            ListBoxItem.Items.Add(text)
            ListBoxQty.Items.Add(1)
            ListBoxPrice.Items.Add(price)

            ' Add buttons for adjusting quantity
            Dim buttonIncrease As New Button()
            buttonIncrease.Text = "+"
            buttonIncrease.Tag = ListBoxQty.Items.Count - 1
            AddHandler buttonIncrease.Click, AddressOf ButtonIncreaseQty_Click

            Dim buttonDecrease As New Button()
            buttonDecrease.Text = "-"
            buttonDecrease.Tag = ListBoxQty.Items.Count - 1
            AddHandler buttonDecrease.Click, AddressOf ButtonDecreaseQty_Click

            Dim buttonWidth As Integer = 30 ' Set the desired width for the buttons

            buttonIncrease.Width = buttonWidth
            buttonDecrease.Width = buttonWidth

            ' Calculate the total price
            Dim total As Decimal = 0
            For i As Integer = 0 To ListBoxPrice.Items.Count - 1
                total += CDec(ListBoxPrice.Items(i))
            Next

            ' Update the total label
            LabelTot.Text = total.ToString("0.00")


            buttonIncrease.Location = New Point(ListBoxQty.Right + 5, ListBoxQty.Top + (ListBoxQty.Items.Count - 1) * ListBoxQty.ItemHeight)
            buttonDecrease.Location = New Point(ListBoxQty.Left - buttonDecrease.Width - 5, ListBoxQty.Top + (ListBoxQty.Items.Count - 1) * ListBoxQty.ItemHeight)

            Controls.Add(buttonIncrease)
            Controls.Add(buttonDecrease)

        End If
    End Sub

    Private Sub RemoveItem(ByVal index As Integer)
        ' Remove the item from the ListBox
        ListBoxItem.Items.RemoveAt(index)
        ListBoxQty.Items.RemoveAt(index)
        ListBoxPrice.Items.RemoveAt(index)

        ' Remove the corresponding buttons
        Dim lastButtonIndex As Integer = Controls.Count - 1
        If lastButtonIndex >= 0 Then
            Controls.RemoveAt(lastButtonIndex)
        End If
        If lastButtonIndex - 1 >= 0 Then
            Controls.RemoveAt(lastButtonIndex - 1)
        End If

        ' Update the total
        UpdateTotal()
    End Sub


    Private Sub ButtonIncreaseQty_Click(sender As Object, e As EventArgs)
        Dim index As Integer = CInt(DirectCast(sender, Button).Tag)
        Dim qty As Integer = CInt(ListBoxQty.Items(index))
        Dim price As Decimal = CDec(ListBoxPrice.Items(index)) / qty  ' Get original price per item
        ListBoxQty.Items(index) = qty + 1
        ListBoxPrice.Items(index) = (qty + 1) * price
        ' Update the total label
        UpdateTotal()
    End Sub

    Private Sub ButtonDecreaseQty_Click(sender As Object, e As EventArgs)
        Dim index As Integer = CInt(DirectCast(sender, Button).Tag)
        Dim qty As Integer = CInt(ListBoxQty.Items(index))
        If qty > 1 Then
            Dim price As Decimal = CDec(ListBoxPrice.Items(index)) / qty  ' Get original price per item
            ListBoxQty.Items(index) = qty - 1
            ListBoxPrice.Items(index) = (qty - 1) * price
            UpdateTotal()
        Else
            RemoveItem(index)
            UpdateTotal()
        End If
    End Sub


    Private Sub UpdateTotal()
        ' Calculate the total price
        Dim total As Decimal = 0
        For i As Integer = 0 To ListBoxPrice.Items.Count - 1
            total += CDec(ListBoxPrice.Items(i))
        Next

        ' Update the total label
        LabelTot.Text = total.ToString("0.00")
    End Sub

    Private selectedButton As Button = Nothing
    Private Sub ChangeButtonColor(ByVal button As Button)
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = SystemColors.Control
        End If
        button.BackColor = Color.LightBlue
        selectedButton = button
    End Sub

    Friend Sub DisplayForm(form As Form)
        ' Clear existing controls from Panel2
        Panel1.Controls.Clear()

        ' Set form properties
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        ' Add form to Panel2
        Panel1.Controls.Add(form)
        form.Show()

        If TypeOf form Is Form9 Then
            Dim form9 As Form9 = DirectCast(form, Form9)
            form9.SetForm5Instance(Me)
        ElseIf TypeOf form Is Form8 Then
            Dim form8 As Form8 = DirectCast(form, Form8)
            form8.SetForm5Instance(Me)
        ElseIf TypeOf form Is Form7 Then
            Dim form7 As Form7 = DirectCast(form, Form7)
            form7.SetForm5Instance(Me)
        End If
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        ' Check if the ListBox is empty
        If ListBoxItem.Items.Count = 0 Then
            MessageBox.Show("Please select items before placing the order.")
            Return
        End If
        ' Generate a unique bill number (you can use a more sophisticated method if needed)
        Dim billNo As Integer = GetNextBillNumber()

        ' Get the current date as a string
        Dim dateString As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' Concatenate items, quantities, and prices into strings
        Dim items As String = String.Join(", ", ListBoxItem.Items.Cast(Of String)())
        Dim quantities As String = String.Join(", ", ListBoxQty.Items.Cast(Of Integer)())
        Dim prices As String = String.Join(", ", ListBoxPrice.Items.Cast(Of Decimal)())

        ' Get the total amount from the LabelTot control
        Dim totalAmount As Decimal = CDec(LabelTot.Text)

        ' Insert the order into the database
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO Orders (BillNo, Date, Items, Quantities, Prices, TotalAmount) VALUES (@BillNo, @Date, @Items, @Quantities, @Prices, @TotalAmount)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@BillNo", billNo)
                command.Parameters.AddWithValue("@Date", dateString)
                command.Parameters.AddWithValue("@Items", items)
                command.Parameters.AddWithValue("@Quantities", quantities)
                command.Parameters.AddWithValue("@Prices", prices)
                command.Parameters.AddWithValue("@TotalAmount", totalAmount)
                command.ExecuteNonQuery()
            End Using
        End Using

        ' Insert or update the sales table
        Dim dayOfWeek As String = DateTime.Now.DayOfWeek.ToString()
        Dim totalSales As Decimal = totalAmount
        InsertOrUpdateSales(dateString, dayOfWeek, totalSales)

        ' Display the bill number and total amount
        MessageBox.Show($"Order placed successfully! Bill No: {billNo.ToString("0")}, Total Amount: {totalAmount.ToString("0.00")}")

        ' Clear the ListBoxes
        ListBoxItem.Items.Clear()
        ListBoxQty.Items.Clear()
        ListBoxPrice.Items.Clear()
        LabelTot.Text = "0.00"
    End Sub
    Private Function GetNextBillNumber() As Integer
        Dim lastBillNumber As Integer = 0
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT MAX(CAST(BillNo AS INT)) FROM Orders"
            Using command As New SqlCommand(query, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    lastBillNumber = Convert.ToInt32(result)
                End If
            End Using
        End Using

        ' Increment the last bill number by 1 to get the next bill number
        Return lastBillNumber + 1
    End Function


    Private Sub InsertOrUpdateSales(dateString As String, dayOfWeek As String, totalSales As Decimal)
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            ' Check if a row with the same date already exists in the sales table
            Dim query As String = "SELECT * FROM Sales WHERE Date = @Date"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Date", dateString)
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    ' Row already exists, update the total sales
                    reader.Close()
                    query = "UPDATE sales SET TotalSales = TotalSales + @TotalSales WHERE Date = @Date"
                    Using updateCommand As New SqlCommand(query, connection)
                        updateCommand.Parameters.AddWithValue("@TotalSales", totalSales)
                        updateCommand.Parameters.AddWithValue("@Date", dateString)
                        updateCommand.ExecuteNonQuery()
                    End Using
                Else
                    ' Row does not exist, insert a new row
                    reader.Close()
                    query = "INSERT INTO sales (Date, Day, TotalSales) VALUES (@Date, @Day, @TotalSales)"
                    Using insertCommand As New SqlCommand(query, connection)
                        insertCommand.Parameters.AddWithValue("@Date", dateString)
                        insertCommand.Parameters.AddWithValue("@Day", dayOfWeek)
                        insertCommand.Parameters.AddWithValue("@TotalSales", totalSales)
                        insertCommand.ExecuteNonQuery()
                    End Using
                End If
            End Using
        End Using
    End Sub
    Private Sub ButtonPizza_Click(sender As Object, e As EventArgs) Handles ButtonPizza.Click
        ChangeButtonColor(ButtonPizza)
        DisplayForm(New Form7())
    End Sub

    Private Sub ButtonBev_Click(sender As Object, e As EventArgs) Handles ButtonBev.Click
        ChangeButtonColor(ButtonBev)
        DisplayForm(New Form8())
    End Sub

    Private Sub ButtonSides_Click(sender As Object, e As EventArgs) Handles ButtonSides.Click
        ChangeButtonColor(ButtonSides)
        DisplayForm(New Form9())
    End Sub

End Class