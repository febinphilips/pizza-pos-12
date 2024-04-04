<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        ButtonNonVeg = New Button()
        ButtonVeg = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(ButtonNonVeg)
        Panel1.Controls.Add(ButtonVeg)
        Panel1.Location = New Point(-2, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1171, 419)
        Panel1.TabIndex = 8
        ' 
        ' ButtonNonVeg
        ' 
        ButtonNonVeg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonNonVeg.Location = New Point(660, 90)
        ButtonNonVeg.Name = "ButtonNonVeg"
        ButtonNonVeg.Size = New Size(179, 163)
        ButtonNonVeg.TabIndex = 4
        ButtonNonVeg.Text = "Non - Veg"
        ButtonNonVeg.UseVisualStyleBackColor = True
        ' 
        ' ButtonVeg
        ' 
        ButtonVeg.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ButtonVeg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonVeg.Location = New Point(347, 90)
        ButtonVeg.Name = "ButtonVeg"
        ButtonVeg.Size = New Size(179, 163)
        ButtonVeg.TabIndex = 3
        ButtonVeg.Text = "Veg"
        ButtonVeg.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1171, 419)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form7"
        Text = "Form7"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonNonVeg As Button
    Friend WithEvents ButtonVeg As Button
End Class
