Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the chart with data
        Dim connectionString As String = "Data Source=LENOVO31\SQLEXPRESS;Initial Catalog=pizza_pos;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT TOP 7 Date, Day, TotalSales FROM (SELECT Date, Day, TotalSales, ROW_NUMBER() OVER (ORDER BY Date DESC) AS rn FROM Sales) AS Temp WHERE rn <= 7 ORDER BY Date ASC"
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Bind the data to the chart
        Chart1.DataSource = dataTable
        Chart1.Series.Clear()
        Chart1.Series.Add("TotalSales")
        Chart1.Series("TotalSales").XValueMember = "Date"
        Chart1.Series("TotalSales").YValueMembers = "TotalSales"
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -35
        Chart1.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        ' Set the font for axis labels
        Chart1.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 12, FontStyle.Bold)
        Chart1.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Arial", 12, FontStyle.Bold)

        ' Add data labels on top of each bar
        Chart1.Series("TotalSales").IsValueShownAsLabel = True
        Chart1.Series("TotalSales").LabelForeColor = Color.Black ' Set label color
        Chart1.Series("TotalSales").Font = New Font("Arial", 12, FontStyle.Bold) ' Set label font style to bold and size 12

        ' Get total sales for today
        Dim today As Date = Date.Today
        Dim todayDateString As String = today.ToString("yyyy-MM-dd")
        query = "SELECT TotalSales FROM Sales WHERE Date = @Today"
        Dim totalSalesToday As Decimal = 0
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Today", todayDateString)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    totalSalesToday = Convert.ToDecimal(result)
                End If
            End Using
        End Using

        Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("en-IN")
        Dim symbol As String = culture.NumberFormat.CurrencySymbol
        ' Display total sales for today with rupee symbol
        LabelTodayAmt.Text = $"{symbol} {totalSalesToday.ToString("0.00")}"


        ' Get the first day of the current month
        Dim firstDayOfMonth As Date = New Date(today.Year, today.Month, 1)

        ' Get the last day of the current month
        Dim lastDayOfMonth As Date = firstDayOfMonth.AddMonths(1).AddDays(-1)

        ' Format the first and last day of the month as strings in 'yyyy-MM-dd' format
        Dim firstDayOfMonthString As String = firstDayOfMonth.ToString("yyyy-MM-dd")
        Dim lastDayOfMonthString As String = lastDayOfMonth.ToString("yyyy-MM-dd")

        ' Query to retrieve the total sales for the current month
        query = "SELECT SUM(TotalSales) FROM Sales WHERE Date BETWEEN @FirstDayOfMonth AND @LastDayOfMonth"
        Dim totalSalesMonth As Decimal = 0
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@FirstDayOfMonth", firstDayOfMonthString)
                command.Parameters.AddWithValue("@LastDayOfMonth", lastDayOfMonthString)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    totalSalesMonth = Convert.ToDecimal(result)
                End If
            End Using
        End Using

        ' Display total sales for the current month
        LabelMonthlyAmt.Text = $"{symbol} {totalSalesMonth.ToString("0.00")}"

        Chart1.DataBind()
    End Sub
End Class
