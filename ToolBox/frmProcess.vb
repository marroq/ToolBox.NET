Public Class frmProcess

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFavoritesPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Favorites)

        OpenApplication("www.google.com")
        OpenWithArguments()
        OpenWithStartInfo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim StartInfo As New ProcessStartInfo("Photoshop.exe") With {.WindowStyle = ProcessWindowStyle.Minimized}

        Process1.Start(StartInfo)
    End Sub

    Public Sub OpenApplication(myFavoritesPath As String)
        ' Start Internet Explorer. Defaults to the home page.
        Process.Start("IExplore.exe")

        ' Display the contents of the favorites folder in the browser.
        Process.Start(myFavoritesPath)
    End Sub 'OpenApplication

    Sub OpenWithArguments()
        ' url's are not considered documents. They can only be opened 
        ' by passing them as arguments.
        Process.Start("IExplore.exe", "www.northwindtraders.com")

        ' Start a Web page using a browser associated with .html and .asp files.
        Process.Start("IExplore.exe", "D:\Escritorio\AngularJS\2 Bootstrap\index.html")
        Process.Start("IExplore.exe", "D:\Escritorio\AngularJS\2 Bootstrap\index2.html")
    End Sub 'OpenWithArguments

    Sub OpenWithStartInfo()
        Dim startInfo As New ProcessStartInfo("IExplore.exe") With {.WindowStyle = ProcessWindowStyle.Minimized}

        Process.Start(startInfo)

        startInfo.Arguments = "www.northwindtraders.com"

        Process.Start(startInfo)
    End Sub 'OpenWithStartInfo

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process1.Close()
    End Sub
End Class
