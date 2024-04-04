<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        ButtonSides = New Button()
        ButtonBev = New Button()
        ButtonPizza = New Button()
        Panel1 = New Panel()
        ListBoxItem = New ListBox()
        ListBoxQty = New ListBox()
        ListBoxPrice = New ListBox()
        LabelItem = New Label()
        LabelQty = New Label()
        LabelPrice = New Label()
        LabelTotal = New Label()
        LabelTot = New Label()
        ButtonOrder = New Button()
        SuspendLayout()
        ' 
        ' ButtonSides
        ' 
        ButtonSides.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonSides.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSides.Location = New Point(891, 0)
        ButtonSides.Name = "ButtonSides"
        ButtonSides.Size = New Size(94, 43)
        ButtonSides.TabIndex = 2
        ButtonSides.Text = "Sides"
        ButtonSides.UseVisualStyleBackColor = True
        ' 
        ' ButtonBev
        ' 
        ButtonBev.Anchor = AnchorStyles.Top
        ButtonBev.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonBev.Location = New Point(519, 0)
        ButtonBev.Name = "ButtonBev"
        ButtonBev.Size = New Size(112, 43)
        ButtonBev.TabIndex = 1
        ButtonBev.Text = "Beverages"
        ButtonBev.UseVisualStyleBackColor = True
        ' 
        ' ButtonPizza
        ' 
        ButtonPizza.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonPizza.Location = New Point(180, 0)
        ButtonPizza.Name = "ButtonPizza"
        ButtonPizza.Size = New Size(94, 43)
        ButtonPizza.TabIndex = 0
        ButtonPizza.Text = "Pizzas"
        ButtonPizza.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Location = New Point(1, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1171, 419)
        Panel1.TabIndex = 3
        ' 
        ' ListBoxItem
        ' 
        ListBoxItem.BackColor = Color.White
        ListBoxItem.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxItem.FormattingEnabled = True
        ListBoxItem.HorizontalScrollbar = True
        ListBoxItem.ItemHeight = 25
        ListBoxItem.Location = New Point(21, 507)
        ListBoxItem.Name = "ListBoxItem"
        ListBoxItem.Size = New Size(788, 204)
        ListBoxItem.TabIndex = 5
        ' 
        ' ListBoxQty
        ' 
        ListBoxQty.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxQty.FormattingEnabled = True
        ListBoxQty.HorizontalScrollbar = True
        ListBoxQty.ItemHeight = 25
        ListBoxQty.Location = New Point(863, 507)
        ListBoxQty.Name = "ListBoxQty"
        ListBoxQty.Size = New Size(81, 204)
        ListBoxQty.TabIndex = 6
        ' 
        ' ListBoxPrice
        ' 
        ListBoxPrice.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxPrice.FormattingEnabled = True
        ListBoxPrice.HorizontalScrollbar = True
        ListBoxPrice.ItemHeight = 25
        ListBoxPrice.Location = New Point(987, 507)
        ListBoxPrice.Name = "ListBoxPrice"
        ListBoxPrice.Size = New Size(158, 204)
        ListBoxPrice.TabIndex = 7
        ' 
        ' LabelItem
        ' 
        LabelItem.AutoSize = True
        LabelItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelItem.Location = New Point(21, 465)
        LabelItem.Name = "LabelItem"
        LabelItem.Size = New Size(64, 28)
        LabelItem.TabIndex = 0
        LabelItem.Text = "Items"
        ' 
        ' LabelQty
        ' 
        LabelQty.AutoSize = True
        LabelQty.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelQty.Location = New Point(863, 465)
        LabelQty.Name = "LabelQty"
        LabelQty.Size = New Size(46, 28)
        LabelQty.TabIndex = 1
        LabelQty.Text = "Qty"
        ' 
        ' LabelPrice
        ' 
        LabelPrice.AutoSize = True
        LabelPrice.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPrice.Location = New Point(987, 465)
        LabelPrice.Name = "LabelPrice"
        LabelPrice.Size = New Size(59, 28)
        LabelPrice.TabIndex = 2
        LabelPrice.Text = "Price"
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotal.Location = New Point(874, 736)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(70, 28)
        LabelTotal.TabIndex = 0
        LabelTotal.Text = "Total :"
        ' 
        ' LabelTot
        ' 
        LabelTot.AutoSize = True
        LabelTot.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTot.Location = New Point(1046, 739)
        LabelTot.Name = "LabelTot"
        LabelTot.Size = New Size(0, 25)
        LabelTot.TabIndex = 8
        ' 
        ' ButtonOrder
        ' 
        ButtonOrder.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonOrder.Location = New Point(21, 728)
        ButtonOrder.Name = "ButtonOrder"
        ButtonOrder.Size = New Size(94, 45)
        ButtonOrder.TabIndex = 0
        ButtonOrder.Text = "Order"
        ButtonOrder.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1174, 785)
        Controls.Add(ButtonOrder)
        Controls.Add(LabelTot)
        Controls.Add(LabelTotal)
        Controls.Add(LabelItem)
        Controls.Add(LabelQty)
        Controls.Add(LabelPrice)
        Controls.Add(ListBoxPrice)
        Controls.Add(ListBoxQty)
        Controls.Add(ListBoxItem)
        Controls.Add(Panel1)
        Controls.Add(ButtonSides)
        Controls.Add(ButtonBev)
        Controls.Add(ButtonPizza)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonSides As Button
    Friend WithEvents ButtonBev As Button
    Friend WithEvents ButtonPizza As Button
    Friend WithEvents Panel1 As Panel
    Public WithEvents TextBox1 As TextBox
    Friend WithEvents ListBoxItem As ListBox
    Friend WithEvents ListBoxQty As ListBox
    Friend WithEvents ListBoxPrice As ListBox
    Friend WithEvents LabelItem As Label
    Friend WithEvents LabelQty As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelTot As Label
    Friend WithEvents ButtonOrder As Button
End Class
