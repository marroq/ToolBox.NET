Imports System.IO

Public Class frmImageList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.ImageList = ImageList1

        If Label1.ImageIndex < ImageList1.Images.Count - 1 Then
            Label1.ImageIndex += 1
        Else
            Label1.ImageIndex = 0
        End If
    End Sub

    Private Sub frmImageList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImageList1.Images.Add(Image.FromFile("C:\Users\DESARROLLO-PS\Desktop\captura.jpg"))
        ImageList1.Images.Add(Image.FromFile("C:\Users\DESARROLLO-PS\Desktop\ther.jpg"))
    End Sub
End Class