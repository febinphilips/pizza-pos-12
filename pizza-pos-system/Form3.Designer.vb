<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel1 = New Panel()
        ButtonOrder = New Button()
        ButtonMenu = New Button()
        ButtonSales = New Button()
        ButtonProfile = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(ButtonOrder)
        Panel1.Controls.Add(ButtonMenu)
        Panel1.Controls.Add(ButtonSales)
        Panel1.Controls.Add(ButtonProfile)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(173, 785)
        Panel1.TabIndex = 0
        ' 
        ' ButtonOrder
        ' 
        ButtonOrder.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonOrder.Location = New Point(0, 122)
        ButtonOrder.Name = "ButtonOrder"
        ButtonOrder.Size = New Size(173, 77)
        ButtonOrder.TabIndex = 1
        ButtonOrder.Text = "ORDER"
        ButtonOrder.UseVisualStyleBackColor = True
        ' 
        ' ButtonMenu
        ' 
        ButtonMenu.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonMenu.Location = New Point(0, 215)
        ButtonMenu.Name = "ButtonMenu"
        ButtonMenu.Size = New Size(173, 77)
        ButtonMenu.TabIndex = 3
        ButtonMenu.Text = "MENU"
        ButtonMenu.UseVisualStyleBackColor = True
        ' 
        ' ButtonSales
        ' 
        ButtonSales.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSales.Location = New Point(0, 309)
        ButtonSales.Name = "ButtonSales"
        ButtonSales.Size = New Size(173, 77)
        ButtonSales.TabIndex = 2
        ButtonSales.Text = "SALES"
        ButtonSales.UseVisualStyleBackColor = True
        ' 
        ' ButtonProfile
        ' 
        ButtonProfile.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonProfile.Location = New Point(0, 28)
        ButtonProfile.Name = "ButtonProfile"
        ButtonProfile.Size = New Size(173, 79)
        ButtonProfile.TabIndex = 0
        ButtonProfile.Text = "PROFILE"
        ButtonProfile.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Location = New Point(173, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1174, 785)
        Panel2.TabIndex = 1
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1347, 785)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form3"
        Text = "191998"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonSales As Button
    Friend WithEvents ButtonOrder As Button
    Friend WithEvents ButtonProfile As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonMenu As Button
End Class
