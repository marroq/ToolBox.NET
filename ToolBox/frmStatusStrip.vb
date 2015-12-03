Public Class frmStatusStrip

    Private Sub frmStatusStrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Loading..."
        While (ToolStripProgressBar1.Maximum <> ToolStripProgressBar1.Value)
            ToolStripProgressBar1.Value += 10
        End While
    End Sub
End Class
