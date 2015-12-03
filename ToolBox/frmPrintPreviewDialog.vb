Public Class frmPrintPreviewDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TreeView1.SelectedNode IsNot Nothing) Then
            PrintDocument1.DocumentName = TreeView1.SelectedNode.Tag
        End If

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub frmPrintPreviewDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.UseAntiAlias = True
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Const text As String = "In document_PrintPage method."
        Dim printFont As New System.Drawing.Font("Arial", 35, System.Drawing.FontStyle.Regular)
        e.Graphics.DrawString(text, printFont, System.Drawing.Brushes.Black, 0, 0)
    End Sub
End Class
