Public Class frmHelpProvider

    Private Sub frmHelpProvider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelpProvider1.SetHelpString(Button1, "Action Button")
        HelpProvider1.SetHelpString(TextBox1, "Action TextBox")
    End Sub
End Class
