<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        GroupBox1 = New GroupBox()
        ButtonCreate = New Button()
        TextBoxPassword = New TextBox()
        TextBoxUserId = New TextBox()
        TextBoxName = New TextBox()
        LabelPassword = New Label()
        LabelUser = New Label()
        LabelName = New Label()
        LabelCreate = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Right
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(ButtonCreate)
        GroupBox1.Controls.Add(TextBoxPassword)
        GroupBox1.Controls.Add(TextBoxUserId)
        GroupBox1.Controls.Add(TextBoxName)
        GroupBox1.Controls.Add(LabelPassword)
        GroupBox1.Controls.Add(LabelUser)
        GroupBox1.Controls.Add(LabelName)
        GroupBox1.Controls.Add(LabelCreate)
        GroupBox1.Location = New Point(535, 64)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(421, 500)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' ButtonCreate
        ' 
        ButtonCreate.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCreate.Location = New Point(156, 419)
        ButtonCreate.Name = "ButtonCreate"
        ButtonCreate.Size = New Size(112, 42)
        ButtonCreate.TabIndex = 0
        ButtonCreate.Text = "Create"
        ButtonCreate.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(180, 323)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(192, 27)
        TextBoxPassword.TabIndex = 0
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' TextBoxUserId
        ' 
        TextBoxUserId.Location = New Point(180, 247)
        TextBoxUserId.Name = "TextBoxUserId"
        TextBoxUserId.Size = New Size(192, 27)
        TextBoxUserId.TabIndex = 0
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(180, 171)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(192, 27)
        TextBoxName.TabIndex = 0
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.BackColor = Color.Transparent
        LabelPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPassword.ForeColor = SystemColors.ButtonHighlight
        LabelPassword.Location = New Point(43, 322)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(97, 28)
        LabelPassword.TabIndex = 0
        LabelPassword.Text = "Password"
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUser.ForeColor = SystemColors.ButtonHighlight
        LabelUser.Location = New Point(43, 247)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(91, 31)
        LabelUser.TabIndex = 0
        LabelUser.Text = "User ID"
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.BackColor = Color.Transparent
        LabelName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelName.ForeColor = SystemColors.ButtonHighlight
        LabelName.Location = New Point(48, 167)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(66, 28)
        LabelName.TabIndex = 1
        LabelName.Text = "Name"
        ' 
        ' LabelCreate
        ' 
        LabelCreate.AutoSize = True
        LabelCreate.BackColor = Color.Transparent
        LabelCreate.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCreate.ForeColor = SystemColors.ButtonHighlight
        LabelCreate.Location = New Point(117, 55)
        LabelCreate.Name = "LabelCreate"
        LabelCreate.Size = New Size(208, 31)
        LabelCreate.TabIndex = 0
        LabelCreate.Text = "CREATE ACCOUNT"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.OIP
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1023, 630)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelCreate As Label
End Class
