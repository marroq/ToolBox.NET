Public Class frmPageSetupDialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PageSetupDialog1.PageSettings = New System.Drawing.Printing.PageSettings
        PageSetupDialog1.PrinterSettings = New System.Drawing.Printing.PrinterSettings
        PageSetupDialog1.ShowNetwork = False

        Dim result As DialogResult = PageSetupDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            Dim results() As Object = New Object() _
                {
                    PageSetupDialog1.PageSettings.Margins, _
                    PageSetupDialog1.PageSettings.PaperSize, _
                    PageSetupDialog1.PageSettings.Landscape, _
                    PageSetupDialog1.PrinterSettings.PrinterName, _
                    PageSetupDialog1.PrinterSettings.PrintRange
                }
            ListBox1.Items.AddRange(results)
        End If
    End Sub
End Class
