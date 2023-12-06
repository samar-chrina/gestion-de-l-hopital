Module Patient
    Public Structure patient
        Dim code As String
        Dim nom As String
        Dim prenom As String
    End Structure
    Public Patients(100)
    Public nb As Integer = 0 'compteur pour suivre le nombre des patients'
    Function ajouterpatient(p As patient) As Boolean
        If (nb < Patients.Length) Then
            Patients(nb) = p
            nb += 1
            Console.WriteLine("patient ajouté")
            Return True
        Else
            Console.WriteLine("le tableau est plein ,impossible d'ajouter")
            Return False
        End If
    End Function
    Public Sub afficherpatient(dgv As DataGridView)
        For Each p As patient In Patients
            If p.code IsNot Nothing Then
                dgv.Rows.Add(p.code, p.nom, p.prenom)
            End If
        Next
    End Sub
End Module

