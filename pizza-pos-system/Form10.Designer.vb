<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Gainsboro
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(500, 4, 500, 4)
        Label1.Size = New Size(1152, 45)
        Label1.TabIndex = 8
        Label1.Text = "Menu Items"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.WhiteSmoke
        FlowLayoutPanel1.Location = New Point(12, 73)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(80, 0, 80, 0)
        FlowLayoutPanel1.Size = New Size(1152, 700)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(1174, 785)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form10"
        Text = "Form10"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
