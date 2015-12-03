Public Class frmPrintPreviewControl
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Const text As String = "In docToPrint_PrintPage method."
        Dim printFont As New Font("Arial", 35, System.Drawing.FontStyle.Regular)

        e.Graphics.DrawString(text, printFont, System.Drawing.Brushes.Black, 10, 10)
    End Sub

    Private Sub frmPrintPreviewControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewControl1.Document = PrintDocument1
        PrintPreviewControl1.Zoom = 0.25
        PrintPreviewControl1.Document.DocumentName = "C:\someFile.txt"
        PrintPreviewControl1.UseAntiAlias = True
    End Sub
End Class
