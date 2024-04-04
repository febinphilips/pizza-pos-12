<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        PictureBox1 = New PictureBox()
        LabelUserId = New Label()
        LabelHello = New Label()
        LabelUserName = New Label()
        Panel1 = New Panel()
        LabelAtr = New Label()
        Panel2 = New Panel()
        ButtonEditProfile = New Button()
        ButtonChangePassword = New Button()
        ButtonLogOut = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.profile2
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(444, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(270, 233)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LabelUserId
        ' 
        LabelUserId.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelUserId.AutoSize = True
        LabelUserId.BackColor = Color.Transparent
        LabelUserId.FlatStyle = FlatStyle.Flat
        LabelUserId.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUserId.ForeColor = SystemColors.ActiveCaptionText
        LabelUserId.Location = New Point(514, 272)
        LabelUserId.Name = "LabelUserId"
        LabelUserId.Size = New Size(0, 32)
        LabelUserId.TabIndex = 1
        ' 
        ' LabelHello
        ' 
        LabelHello.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelHello.AutoSize = True
        LabelHello.Font = New Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHello.ForeColor = SystemColors.ButtonHighlight
        LabelHello.Location = New Point(455, 332)
        LabelHello.Name = "LabelHello"
        LabelHello.Size = New Size(93, 40)
        LabelHello.TabIndex = 2
        LabelHello.Text = "Hello,"
        ' 
        ' LabelUserName
        ' 
        LabelUserName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelUserName.AutoSize = True
        LabelUserName.BackColor = Color.Transparent
        LabelUserName.FlatStyle = FlatStyle.Flat
        LabelUserName.Font = New Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUserName.ForeColor = Color.White
        LabelUserName.Location = New Point(543, 332)
        LabelUserName.Name = "LabelUserName"
        LabelUserName.Size = New Size(0, 40)
        LabelUserName.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(LabelAtr)
        Panel1.Controls.Add(LabelUserName)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(LabelHello)
        Panel1.Controls.Add(LabelUserId)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1150, 420)
        Panel1.TabIndex = 4
        ' 
        ' LabelAtr
        ' 
        LabelAtr.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelAtr.AutoSize = True
        LabelAtr.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelAtr.Location = New Point(478, 272)
        LabelAtr.Name = "LabelAtr"
        LabelAtr.Size = New Size(36, 31)
        LabelAtr.TabIndex = 4
        LabelAtr.Text = "@"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGray
        Panel2.Controls.Add(ButtonEditProfile)
        Panel2.Controls.Add(ButtonChangePassword)
        Panel2.Controls.Add(ButtonLogOut)
        Panel2.Cursor = Cursors.IBeam
        Panel2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(12, 438)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1150, 335)
        Panel2.TabIndex = 0
        ' 
        ' ButtonEditProfile
        ' 
        ButtonEditProfile.Cursor = Cursors.Hand
        ButtonEditProfile.FlatStyle = FlatStyle.Popup
        ButtonEditProfile.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonEditProfile.Location = New Point(35, 59)
        ButtonEditProfile.Name = "ButtonEditProfile"
        ButtonEditProfile.Size = New Size(1062, 41)
        ButtonEditProfile.TabIndex = 7
        ButtonEditProfile.Text = "Edit Profile                                                                                                                                                      >"
        ButtonEditProfile.TextAlign = ContentAlignment.MiddleLeft
        ButtonEditProfile.UseVisualStyleBackColor = True
        ' 
        ' ButtonChangePassword
        ' 
        ButtonChangePassword.BackColor = Color.Transparent
        ButtonChangePassword.Cursor = Cursors.Hand
        ButtonChangePassword.FlatAppearance.BorderSize = 0
        ButtonChangePassword.FlatStyle = FlatStyle.Popup
        ButtonChangePassword.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonChangePassword.ForeColor = SystemColors.ControlText
        ButtonChangePassword.Location = New Point(35, 128)
        ButtonChangePassword.Name = "ButtonChangePassword"
        ButtonChangePassword.Size = New Size(1062, 41)
        ButtonChangePassword.TabIndex = 6
        ButtonChangePassword.Text = "Change Password                                                                                                                                           >"
        ButtonChangePassword.TextAlign = ContentAlignment.MiddleLeft
        ButtonChangePassword.UseVisualStyleBackColor = False
        ' 
        ' ButtonLogOut
        ' 
        ButtonLogOut.BackColor = Color.Transparent
        ButtonLogOut.Cursor = Cursors.Hand
        ButtonLogOut.FlatStyle = FlatStyle.Popup
        ButtonLogOut.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonLogOut.ForeColor = Color.Red
        ButtonLogOut.Location = New Point(35, 250)
        ButtonLogOut.Name = "ButtonLogOut"
        ButtonLogOut.Size = New Size(141, 60)
        ButtonLogOut.TabIndex = 4
        ButtonLogOut.Text = "Log Out"
        ButtonLogOut.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1174, 785)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelUserId As Label
    Friend WithEvents LabelHello As Label
    Friend WithEvents LabelUserName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonLogOut As Button
    Friend WithEvents ButtonChangePassword As Button
    Friend WithEvents ButtonEditProfile As Button
    Friend WithEvents LabelAtr As Label
End Class
