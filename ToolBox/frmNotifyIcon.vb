Public Class frmNotifyIcon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Control mostrado en la barra de herramientas de SO
        NotifyIcon1.Text = "Notification Application"
        NotifyIcon1.Visible = True
    End Sub
End Class
