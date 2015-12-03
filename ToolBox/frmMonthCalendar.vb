Public Class frmMonthCalendar

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox1.Text = String.Format("Date Changed: Start = {0} : End = {1}", e.Start.ToShortDateString(), e.End.ToShortDateString())
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        TextBox1.Text = String.Format("Date Selected: Start = {0} : End = {1}", e.Start.ToShortDateString(), e.End.ToShortDateString())
    End Sub
End Class