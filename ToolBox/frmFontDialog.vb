Public Class frmFontDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FontDialog1.ShowDialog()
        FontDialog1.ShowColor = True

        Label1.ForeColor = FontDialog1.Color
        Label1.Font = FontDialog1.Font
    End Sub
End Class