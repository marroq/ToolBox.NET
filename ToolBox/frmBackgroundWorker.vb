Imports System.ComponentModel

Public Class FrmBackgroundWorker
    Public Sub New()
        InitializeComponent()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub

    Private Sub startAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startAsyncButton.Click
        If BackgroundWorker1.IsBusy <> True Then
            ' Start the asynchronous operation.
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub cancelAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelAsyncButton.Click
        If BackgroundWorker1.WorkerSupportsCancellation = True Then
            ' Cancel the asynchronous operation.
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    ' This event handler is where the time-consuming work is done. 
    Private Sub backgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        Dim i As Integer

        For i = 1 To 10
            If (worker.CancellationPending = True) Then
                e.Cancel = True
                Exit For
            Else
                ' Perform a time consuming operation and report progress.
                System.Threading.Thread.Sleep(500)
                worker.ReportProgress(i * 10)
            End If
        Next
    End Sub

    ' This event handler updates the progress. 
    Private Sub backgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        resultLabel.Text = (e.ProgressPercentage.ToString() + "%")
    End Sub

    ' This event handler deals with the results of the background operation. 
    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            resultLabel.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            resultLabel.Text = "Error: " & e.Error.Message
        Else
            resultLabel.Text = "Done!"
        End If
    End Sub
End Class
