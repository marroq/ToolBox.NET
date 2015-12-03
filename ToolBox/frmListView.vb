Public Class frmListView
    Dim arr As String() = New String(3) {}
    Dim itm As ListViewItem

    Dim prodName As String
    Dim price As String
    Dim quantity As String
    
    Private Sub frmListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("ProductName", 100)
        ListView1.Columns.Add("Price", 70)
        ListView1.Columns.Add("Quantity", 70)

        arr(0) = "product_1"
        arr(1) = "100"
        arr(2) = "10"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "product_2"
        arr(1) = "200"
        arr(2) = "20"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        prodName = ListView1.Items(1).SubItems(0).ToString
        price = ListView1.Items(1).SubItems(1).ToString
        quantity = ListView1.Items(1).SubItems(2).ToString

        MsgBox(String.Format("{0} , {1} , {2}", prodName, price, quantity))
    End Sub
End Class
