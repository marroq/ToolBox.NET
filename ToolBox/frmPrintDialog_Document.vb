Public Class frmPrintDialog_Document
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = PrintDocument1

        Dim result As DialogResult = PrintDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Const phrase As String = "In document_PrintPage method."
        Dim printFont As New System.Drawing.Font("Arial", 35, System.Drawing.FontStyle.Regular)

        e.Graphics.DrawString(phrase, printFont, System.Drawing.Brushes.Black, 10, 10)
    End Sub
End Class
