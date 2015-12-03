Public Class frmFolderBrowserDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()

        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        TextBox2.Text = FolderBrowserDialog1.RootFolder
        TextBox3.Text = FolderBrowserDialog1.Description
    End Sub
End Class