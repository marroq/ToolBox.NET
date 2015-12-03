Public Class frmMaskedTextbox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MaskedTextBox2.MaskCompleted = False Then
            MsgBox("Fecha incorrecta", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub frmMaskedTextbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaskedTextBox1.BeepOnError = True
        MaskedTextBox1.Mask = "0000-0000"
        MaskedTextBox2.Mask = "00/00/0000"
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        MsgBox("Se requiere valor numérico", MsgBoxStyle.Critical, "Error")
    End Sub
End Class
