Public Class frmToolTip

    Private Sub frmToolTip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        ToolTip1.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.
        ToolTip1.SetToolTip(Button1, "My button1")
        ToolTip1.SetToolTip(CheckBox1, "My checkBox1")
    End Sub
End Class
