Imports System.Timers

Public Class frmProgressBar
    Const count As Integer = 10

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Timer1.Interval = 500
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try    
    End Sub

    Private Sub frmProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 200
        ProgressBar2.Maximum = 200
        ProgressBar3.Maximum = 200
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim internCount As Integer
        If (ProgressBar1.Maximum <> ProgressBar1.Value) Then
            ProgressBar1.Value += count
        End If
        If (ProgressBar1.Maximum = ProgressBar1.Value) Then
            ProgressBar2.Visible = True
            Button2.Visible = True
            internCount = 1
        End If
        If (ProgressBar2.Maximum <> ProgressBar2.Value And internCount = 1) Then
            ProgressBar2.Value += count
        End If
        If (ProgressBar2.Maximum = ProgressBar2.Value) Then
            ProgressBar3.Visible = True
            Button3.Visible = True
            internCount = 2
        End If
        If (ProgressBar3.Maximum <> ProgressBar3.Value And internCount = 2) Then
            ProgressBar3.Value += count
        End If
        If (ProgressBar3.Maximum = ProgressBar3.Value) Then
            Button4.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
