Public Class frm_authentification
    Private Sub init()
        txt_login.Clear()
        txt_pw.Clear()
        txt_codesecurite.Clear()
    End Sub
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        Dim code As String
        login = txt_login.Text
        pw = txt_pw.Text
        code = txt_codesecurite.Text
        If (login = "admin") And (pw = "1234") And (code = "aaaaa") Then
            Me.Hide()
            frm_main.Show()
        ElseIf (login = "personnel") And (pw = "0000") And (code = "bbbbb") Then
            Me.Hide()
            frm_main.Show()
        Else
            init()
        End If
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        frm_merci.Show()
    End Sub
End Class
