Public Class Score
    Dim joueurs As New List(Of Joueur)

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
    End Sub

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        joueurs = ChargerJoueurs()
        For Each joueur In joueurs
            ListBoxScore.Items.Add(joueur.Nom & " : " & joueur.CarreTrouves & " carrés en " & joueur.TempsMinimum & " secondes (" & joueur.Parties & " parties et " & joueur.TempsCumule & " secondes de jeu)" & vbCr)
        Next
    End Sub

    Private Sub Score_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MenuMemory.Show()
    End Sub
End Class