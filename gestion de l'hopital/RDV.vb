Module RDV
    Public Structure Rendezvous
        Dim codepatient As String
        Dim d As Date
        Dim heure As String
    End Structure
    Public RDVs(100)
    Dim i As Integer = 0
    Public Sub ajoutRDV(R As Rendezvous)
        If i < 100 Then
            RDVs(i) = R
            i = i + 1
        End If
    End Sub
    Public Sub afficherRDVsDuJour(dgv As DataGridView)
        For Each R As Rendezvous In RDVs
            If R.codepatient IsNot Nothing Then
                dgv.Rows.Add(R.codepatient, R.d, R.heure)
            End If
        Next
    End Sub
End Module
