Public Class frm_PriseRDV
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Hide()
        frm_main.Show()
    End Sub
End Class