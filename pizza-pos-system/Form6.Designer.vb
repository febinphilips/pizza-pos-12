<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Chart1 = New DataVisualization.Charting.Chart()
        LabelSales = New Label()
        LabelToday = New Label()
        LabelMonthly = New Label()
        LabelTodayAmt = New Label()
        LabelMonthlyAmt = New Label()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(47, 228)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(1075, 524)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"
        ' 
        ' LabelSales
        ' 
        LabelSales.AutoSize = True
        LabelSales.BackColor = Color.Gainsboro
        LabelSales.BorderStyle = BorderStyle.FixedSingle
        LabelSales.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSales.Location = New Point(47, 9)
        LabelSales.Name = "LabelSales"
        LabelSales.Padding = New Padding(500, 4, 500, 4)
        LabelSales.Size = New Size(1075, 45)
        LabelSales.TabIndex = 1
        LabelSales.Text = "Sales"
        ' 
        ' LabelToday
        ' 
        LabelToday.AutoSize = True
        LabelToday.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelToday.Location = New Point(139, 75)
        LabelToday.Name = "LabelToday"
        LabelToday.Size = New Size(182, 38)
        LabelToday.TabIndex = 2
        LabelToday.Text = "Today's Sales"
        ' 
        ' LabelMonthly
        ' 
        LabelMonthly.AutoSize = True
        LabelMonthly.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelMonthly.Location = New Point(835, 75)
        LabelMonthly.Name = "LabelMonthly"
        LabelMonthly.Size = New Size(195, 38)
        LabelMonthly.TabIndex = 3
        LabelMonthly.Text = "Monthly Sales"
        ' 
        ' LabelTodayAmt
        ' 
        LabelTodayAmt.AutoSize = True
        LabelTodayAmt.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTodayAmt.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LabelTodayAmt.Location = New Point(157, 125)
        LabelTodayAmt.Name = "LabelTodayAmt"
        LabelTodayAmt.Size = New Size(0, 37)
        LabelTodayAmt.TabIndex = 4
        ' 
        ' LabelMonthlyAmt
        ' 
        LabelMonthlyAmt.AutoSize = True
        LabelMonthlyAmt.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelMonthlyAmt.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LabelMonthlyAmt.Location = New Point(850, 124)
        LabelMonthlyAmt.Name = "LabelMonthlyAmt"
        LabelMonthlyAmt.Size = New Size(0, 38)
        LabelMonthlyAmt.TabIndex = 5
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1174, 785)
        Controls.Add(LabelMonthlyAmt)
        Controls.Add(LabelTodayAmt)
        Controls.Add(LabelMonthly)
        Controls.Add(LabelToday)
        Controls.Add(LabelSales)
        Controls.Add(Chart1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form6"
        Text = "Form6"
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LabelSales As Label
    Friend WithEvents LabelToday As Label
    Friend WithEvents LabelMonthly As Label
    Friend WithEvents LabelTodayAmt As Label
    Friend WithEvents LabelMonthlyAmt As Label
End Class
