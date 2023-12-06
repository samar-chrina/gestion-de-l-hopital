Public Class frm_main
    Private Sub PatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientsToolStripMenuItem.Click
        frm_AjoutPatient.Show()
    End Sub

    Private Sub PriseDeRdvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriseDeRdvToolStripMenuItem.Click
        frm_PriseRDV.Show()
    End Sub
End Class