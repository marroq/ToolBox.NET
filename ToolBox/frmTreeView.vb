Public Class frmTreeView

    Private Sub frmTreeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Add("Parent")
        TreeView1.Nodes(0).Nodes.Add("Child1")
        TreeView1.Nodes(0).Nodes.Add("Child2")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("GrandChild")
        TreeView1.Nodes(0).Nodes(1).Nodes(0).Nodes.Add("Great GrandChild")
        TreeView1.EndUpdate()
    End Sub
End Class
