Public Class Form3

    ' CHANGE COLOR OF BOUTTONS ON SWITCHING
    Private selectedButton As Button = Nothing

    Private Sub ChangeButtonColor(ByVal button As Button)
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = SystemColors.Control
        End If
        button.BackColor = Color.LightBlue
        selectedButton = button
    End Sub

    ' SWITCHING PAGES ON DASHBOARD      
    Private Sub DisplayForm(form As Form)
        ' Clear existing controls from Panel2
        Panel2.Controls.Clear()

        ' Set form properties
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        ' Add form to Panel2
        Panel2.Controls.Add(form)
        form.Show()
    End Sub


    Private Sub ButtonProfile_Click(sender As Object, e As EventArgs) Handles ButtonProfile.Click
        ChangeButtonColor(ButtonProfile)
        DisplayForm(New Form4())
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        ChangeButtonColor(ButtonOrder)
        DisplayForm(New Form5())
    End Sub

    Private Sub ButtonSales_Click(sender As Object, e As EventArgs) Handles ButtonSales.Click
        ChangeButtonColor(ButtonSales)
        DisplayForm(New Form6())
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        ChangeButtonColor(ButtonMenu)
        DisplayForm(New Form10())
    End Sub

End Class