Public Class frmDomainUpDown

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        DomainUpDown1.Items.Add("Guatemala")
        DomainUpDown1.Items.Add("Francia")
        DomainUpDown1.Items.Add("Alemania")
    End Sub
End Class