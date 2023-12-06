Public Class frm_AjoutPatient
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Hide()
        frm_main.Show()
    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim p As Patient.patient
        With p
            .code = txt_code.Text
            .nom = txt_nom.Text
            .prenom = txt_prenom.Text
        End With
        ajouterpatient(p)


    End Sub
End Class