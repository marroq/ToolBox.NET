Public Class frmNumericUpDown
    Dim count As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NumericUpDown1.DecimalPlaces = 2
        If (count = 0) Then
            MsgBox(NumericUpDown1.Value, MsgBoxStyle.Information, "")
        End If

        If (count > 0) Then
            NumericUpDown1.Increment = 0.25D
        End If
        count += 1
    End Sub

    Private Sub frmNumericUpDown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'NumericUpDown1.Value = 5
        NumericUpDown1.Maximum = 2500
        NumericUpDown1.Minimum = -100
    End Sub
End Class
