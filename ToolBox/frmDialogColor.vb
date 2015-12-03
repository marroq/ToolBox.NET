Public Class frmDialogColor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Keeps the user from selecting a custom color.
        ColorDialog1.AllowFullOpen = False
        ' Allows the user to get help. (The default is false.)
        ColorDialog1.ShowHelp = True
        ' Sets the initial color select to the current text color,
        ColorDialog1.Color = TextBox1.ForeColor

        ' Update the text box color if the user clicks OK 
        If (ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class