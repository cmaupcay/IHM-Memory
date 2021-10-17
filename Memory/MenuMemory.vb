Public Class MenuMemory
    Private Sub ButtonJouer_Click(sender As Object, e As EventArgs) Handles ButtonJouer.Click
        Me.Hide()
        Me.ComboBoxNom.Text = Me.ComboBoxNom.Text.Replace(" ", "_")
        Jeu.Show()
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub Menu_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim reponse As Integer = MsgBox("Voulez vous quitter le jeu ?", vbQuestion + vbYesNo + vbDefaultButton2, "Quitter le jeu")
        If reponse = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ComboBoxNom_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxNom.TextUpdate
        Me.ButtonJouer.Enabled = Me.ComboBoxNom.Text.Length >= 3
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ButtonJouer.Enabled = False
        Dim joueurs = ChargerJoueurs()
        For Each joueur In joueurs
            ComboBoxNom.Items.Add(joueur.Nom)
        Next
    End Sub

    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        Score.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonOptions_Click(sender As Object, e As EventArgs) Handles ButtonOptions.Click
        Options.Show()
        Me.Hide()
    End Sub
End Class