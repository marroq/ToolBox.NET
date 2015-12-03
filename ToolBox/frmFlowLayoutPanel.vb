Public Class frmFlowLayoutPanel

    Private Sub frmFlowLayoutPanel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Text = "Arriba - Abajo"
        RadioButton2.Text = "Abajo - Arriba"
        RadioButton3.Text = "Izquierda - Derecha"
        RadioButton4.Text = "Derecha - Izquierda"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles wrapContentsCheckBox.CheckedChanged
        FlowLayoutPanel1.WrapContents = Me.wrapContentsCheckBox.Checked
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        FlowLayoutPanel1.FlowDirection = FlowDirection.BottomUp
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft
    End Sub
End Class
