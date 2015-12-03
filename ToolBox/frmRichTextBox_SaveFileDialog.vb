Imports System.IO

Public Class frmRichTextBox_SaveFileDialog

    Private Sub frmRichTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Dock = DockStyle.Top
        RichTextBox1.LoadFile("D:\readme.rtf")
        RichTextBox1.Find("DVD", RichTextBoxFinds.MatchCase)

        RichTextBox1.SelectionFont = New Font("Verdana", 12, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.Red

        RichTextBox1.SaveFile("D:\readme.rtf", RichTextBoxStreamType.RichText)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim myStream As Stream

        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
            'End If
        End If
    End Sub
End Class
