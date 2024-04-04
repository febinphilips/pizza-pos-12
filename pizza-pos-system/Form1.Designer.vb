<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelLogIn = New Label()
        LabelUser = New Label()
        LabelPassword = New Label()
        TextBoxUser = New TextBox()
        TextBoxPass = New TextBox()
        ButtonLogIn = New Button()
        LabelDirect = New Label()
        LinkLabelDirect = New LinkLabel()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelLogIn
        ' 
        LabelLogIn.AutoSize = True
        LabelLogIn.BackColor = Color.Transparent
        LabelLogIn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLogIn.ForeColor = SystemColors.ButtonHighlight
        LabelLogIn.Location = New Point(33, 23)
        LabelLogIn.Name = "LabelLogIn"
        LabelLogIn.Size = New Size(110, 38)
        LabelLogIn.TabIndex = 0
        LabelLogIn.Text = "LOG IN"
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUser.ForeColor = SystemColors.ButtonHighlight
        LabelUser.Location = New Point(33, 114)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(77, 28)
        LabelUser.TabIndex = 1
        LabelUser.Text = "User Id"
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.BackColor = Color.Transparent
        LabelPassword.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPassword.ForeColor = SystemColors.ButtonHighlight
        LabelPassword.Location = New Point(33, 219)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(112, 31)
        LabelPassword.TabIndex = 2
        LabelPassword.Text = "Password"
        ' 
        ' TextBoxUser
        ' 
        TextBoxUser.Location = New Point(170, 118)
        TextBoxUser.Name = "TextBoxUser"
        TextBoxUser.Size = New Size(215, 27)
        TextBoxUser.TabIndex = 3
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.Location = New Point(170, 219)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.Size = New Size(215, 27)
        TextBoxPass.TabIndex = 4
        TextBoxPass.UseSystemPasswordChar = True
        ' 
        ' ButtonLogIn
        ' 
        ButtonLogIn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonLogIn.Location = New Point(170, 309)
        ButtonLogIn.Name = "ButtonLogIn"
        ButtonLogIn.Size = New Size(105, 46)
        ButtonLogIn.TabIndex = 5
        ButtonLogIn.Text = "Log In"
        ButtonLogIn.UseVisualStyleBackColor = True
        ' 
        ' LabelDirect
        ' 
        LabelDirect.AutoSize = True
        LabelDirect.BackColor = Color.Transparent
        LabelDirect.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelDirect.ForeColor = Color.White
        LabelDirect.Location = New Point(18, 400)
        LabelDirect.Name = "LabelDirect"
        LabelDirect.Size = New Size(264, 31)
        LabelDirect.TabIndex = 6
        LabelDirect.Text = "Don't have an Account ?"
        ' 
        ' LinkLabelDirect
        ' 
        LinkLabelDirect.AutoSize = True
        LinkLabelDirect.BackColor = Color.Transparent
        LinkLabelDirect.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabelDirect.LinkColor = Color.Gainsboro
        LinkLabelDirect.Location = New Point(288, 402)
        LinkLabelDirect.Name = "LinkLabelDirect"
        LinkLabelDirect.Size = New Size(114, 28)
        LinkLabelDirect.TabIndex = 7
        LinkLabelDirect.TabStop = True
        LinkLabelDirect.Text = "Create One"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Right
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(LabelLogIn)
        GroupBox1.Controls.Add(LinkLabelDirect)
        GroupBox1.Controls.Add(LabelUser)
        GroupBox1.Controls.Add(LabelDirect)
        GroupBox1.Controls.Add(TextBoxUser)
        GroupBox1.Controls.Add(ButtonLogIn)
        GroupBox1.Controls.Add(LabelPassword)
        GroupBox1.Controls.Add(TextBoxPass)
        GroupBox1.Location = New Point(537, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(415, 514)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1018, 624)
        Controls.Add(GroupBox1)
        Cursor = Cursors.Hand
        ForeColor = Color.Black
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LabelLogIn As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents ButtonLogIn As Button
    Friend WithEvents LabelDirect As Label
    Friend WithEvents LinkLabelDirect As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox

End Class
