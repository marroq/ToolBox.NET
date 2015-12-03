Public Class frmEventLog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EventLog1.WriteEntry("Test EventLog from ToolBox application")
    End Sub
End Class