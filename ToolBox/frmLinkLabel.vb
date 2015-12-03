Public Class frmLinkLabel

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True

        ' Navigate to a URL.
        System.Diagnostics.Process.Start("http://www.microsoft.com")
    End Sub
End Class