Public Class frmErrorProvider

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Invalid username.")
        Else
            ErrorProvider1.SetError(TextBox1, String.Empty)
        End If
    End Sub
End Class
