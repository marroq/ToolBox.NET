Public Class frmTrackBar

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TextBox1.BorderStyle = BorderStyle.None
        Select Case TrackBar1.Value
            Case 1
                TextBox1.BackColor = Color.Red
            Case 2
                TextBox1.BackColor = Color.Yellow
            Case 3
                TextBox1.BackColor = Color.Blue
            Case 4
                TextBox1.BackColor = Color.Green
            Case 5
                TextBox1.BackColor = Color.Orange
            Case 6
                TextBox1.BackColor = Color.Violet
            Case 7
                TextBox1.BackColor = Color.YellowGreen
            Case 8
                TextBox1.BackColor = Color.White
            Case 9
                TextBox1.BackColor = Color.Silver
            Case 10
                TextBox1.BackColor = Color.Orchid
        End Select
    End Sub
End Class
