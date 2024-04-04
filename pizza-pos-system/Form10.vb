Imports System.Data.SqlClient

Public Class Form10
    Private connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create and add the sets of DataGridView controls
        AddDataGridViewSet("VegPizzas", 372, 198)
        AddDataGridViewSet("NonVegPizzas", 372, 198)
        AddDataGridViewSet("Beverages", 372, 198)
        AddDataGridViewSet("Sides", 372, 198)
        AddDataGridViewSet("Toppings", 372, 198)
    End Sub

    Private Sub AddDataGridViewSet(tableName As String, dgvWidth As Integer, dgvHeight As Integer)
        ' Create a panel to contain the set
        Dim panel As New Panel()
        panel.Width = dgvWidth + 80 ' Add extra space for better appearance
        panel.Height = dgvHeight + 240 ' Adjust height for buttons

        Dim label As New Label()
        label.Text = tableName
        label.Size = New Size(267, 32) ' Set the size of the label
        label.BackColor = Color.Gainsboro ' Set the backcolor
        label.Font = New Font(label.Font.FontFamily, 13, FontStyle.Bold) ' Set the font size to 13 and make it bold
        label.BorderStyle = BorderStyle.FixedSingle ' Set the border style to FixedSingle
        label.TextAlign = ContentAlignment.MiddleCenter
        label.ForeColor = Color.Black ' Set the text color to black for better visibility
        panel.Controls.Add(label)
        ' Center the label horizontally within the panel
        label.Location = New Point((panel.Width - label.Width) \ 2, 10)

        Dim dgv As New DataGridView()
        dgv.Name = "DataGridView" & tableName
        dgv.Width = dgvWidth
        dgv.Height = dgvHeight
        dgv.BorderStyle = BorderStyle.None
        dgv.BackgroundColor = Color.White
        dgv.ColumnHeadersVisible = True
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.AllowUserToOrderColumns = False
        dgv.AllowUserToResizeColumns = False
        dgv.AllowUserToResizeRows = False
        dgv.Location = New Point(10, 30 + label.Height + 4)  ' Adjust location as needed
        dgv.Font = New Font(dgv.Font.FontFamily, 12, FontStyle.Bold) ' Set the font of the DataGridView to size 12 and semi-bold
        LoadItems(dgv, tableName) ' Load items into the DataGridView
        panel.Controls.Add(dgv)
        ' Center the dgv horizontally within the panel
        dgv.Location = New Point((panel.Width - dgv.Width) \ 2, dgv.Location.Y)

        ' Create buttons for add, remove, and update
        Dim btnAdd As New Button()
        btnAdd.Text = "Add"
        btnAdd.BackColor = Color.WhiteSmoke
        btnAdd.Size = New Size(94, 34) ' Set the size of the button
        btnAdd.Font = New Font(btnAdd.Font.FontFamily, 10, FontStyle.Bold)
        btnAdd.Location = New Point(55, dgv.Location.Y + dgv.Height + 35) ' Adjust location as needed
        AddHandler btnAdd.Click, Sub(sender As Object, e As EventArgs)
                                     AddItem(dgv, tableName)
                                 End Sub
        panel.Controls.Add(btnAdd)

        Dim btnRemove As New Button()
        btnRemove.Text = "Remove"
        btnRemove.BackColor = Color.WhiteSmoke
        btnRemove.Size = New Size(94, 34) ' Set the size of the button
        btnRemove.Font = New Font(btnAdd.Font.FontFamily, 10, FontStyle.Bold)
        btnRemove.Location = New Point(btnAdd.Right + 20, dgv.Location.Y + dgv.Height + 35) ' Adjust location as needed
        AddHandler btnRemove.Click, Sub(sender As Object, e As EventArgs)
                                        RemoveItem(dgv, tableName)
                                    End Sub
        panel.Controls.Add(btnRemove)

        Dim btnUpdate As New Button()
        btnUpdate.Text = "Update"
        btnUpdate.BackColor = Color.WhiteSmoke
        btnUpdate.Size = New Size(94, 34) ' Set the size of the button
        btnUpdate.Font = New Font(btnAdd.Font.FontFamily, 10, FontStyle.Bold)
        btnUpdate.Location = New Point(btnRemove.Right + 20, dgv.Location.Y + dgv.Height + 35) ' Adjust location as needed
        AddHandler btnUpdate.Click, Sub(sender As Object, e As EventArgs)
                                        UpdateItem(dgv, tableName)
                                    End Sub
        panel.Controls.Add(btnUpdate)

        ' Add the panel to the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(panel)
    End Sub

    Private Sub LoadItems(dataGridView As DataGridView, tableName As String)
        Dim query As String = $"SELECT * FROM {tableName}"

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dataGridView.DataSource = dt
                End Using
            End Using
        End Using

        AddHandler dataGridView.DataBindingComplete, Sub(sender As Object, e As DataGridViewBindingCompleteEventArgs)
                                                         ' Set the column widths after the data binding is complete
                                                         If dataGridView.Columns.Count >= 2 Then
                                                             dataGridView.Columns("Items").Width = 240
                                                             dataGridView.Columns("Price").Width = 80
                                                         End If
                                                     End Sub
    End Sub

    Private Sub AddItem(dataGridView As DataGridView, tableName As String)
        Dim itemName As String = InputBox("Enter the item name:", "Add Item")
        If String.IsNullOrWhiteSpace(itemName) Then
            MessageBox.Show("Item name cannot be empty.")
            Return
        End If

        Dim itemPriceText As String = InputBox("Enter the item price:", "Add Item")
        Dim itemPrice As Decimal
        If Not Decimal.TryParse(itemPriceText, itemPrice) Then
            MessageBox.Show("Invalid price. Please enter a valid number.")
            Return
        End If

        Dim query As String = $"INSERT INTO {tableName} (Items, Price) VALUES (@Items, @Price)"

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Items", itemName)
                cmd.Parameters.AddWithValue("@Price", itemPrice)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadItems(dataGridView, tableName)
    End Sub

    Private Sub RemoveItem(dataGridView As DataGridView, tableName As String)
        If dataGridView.SelectedRows.Count > 0 Then
            Dim itemName As String = dataGridView.SelectedRows(0).Cells("Items").Value.ToString()

            Dim query As String = $"DELETE FROM {tableName} WHERE Items = @Items"

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Items", itemName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadItems(dataGridView, tableName)
        Else
            MessageBox.Show("Please select an item to remove.")
        End If
    End Sub

    Private Sub UpdateItem(dataGridView As DataGridView, tableName As String)
        If dataGridView.SelectedRows.Count > 0 Then
            Dim currentItemName As String = dataGridView.SelectedRows(0).Cells("Items").Value.ToString()
            Dim currentItemPrice As Decimal = Convert.ToDecimal(dataGridView.SelectedRows(0).Cells("Price").Value)

            Dim newItemName As String = InputBox("Enter the updated item name:", "Update Item", currentItemName)
            If String.IsNullOrWhiteSpace(newItemName) Then
                MessageBox.Show("Item name cannot be empty.")
                Return
            End If

            Dim newItemPriceText As String = InputBox("Enter the updated item price:", "Update Item", currentItemPrice.ToString())
            Dim newItemPrice As Decimal
            If Not Decimal.TryParse(newItemPriceText, newItemPrice) Then
                MessageBox.Show("Invalid price. Please enter a valid number.")
                Return
            End If

            Dim query As String = $"UPDATE {tableName} SET Items = @NewItems, Price = @NewPrice WHERE Items = @CurrentItems AND Price = @CurrentPrice"

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NewItems", newItemName)
                    cmd.Parameters.AddWithValue("@NewPrice", newItemPrice)
                    cmd.Parameters.AddWithValue("@CurrentItems", currentItemName)
                    cmd.Parameters.AddWithValue("@CurrentPrice", currentItemPrice)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadItems(dataGridView, tableName)
        Else
            MessageBox.Show("Please select an item to update.")
        End If
    End Sub

End Class
