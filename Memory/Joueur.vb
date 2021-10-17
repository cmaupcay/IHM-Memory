Module ModuleJoueur
    Public Class Joueur
        Public Property Nom As String
        Public Property CarreTrouves As Integer
        Public Property TempsMinimum As Integer
        Public Property Parties As Integer
        Public Property TempsCumule As Integer
    End Class

    Public Sub EnregistrerNouveauScore(nom As String, setTermines As Integer, tempsPourTrouver As Integer)
        Dim n As Integer = FreeFile()
        Dim ligne As String
        Dim contenu As String = ""
        Dim nouveau As Boolean = True
        Dim score As Double = setTermines / tempsPourTrouver

        FileOpen(n, ".//Sauvegarde//Score.txt", OpenMode.Input)
        Do Until EOF(n)
            ligne = LineInput(n).Trim(Chr(34))
            Dim joueur As String() = Split(ligne, " ")
            If joueur(0) = nom Then
                nouveau = False
                Dim ancienScore As Double = joueur(1) / joueur(2)
                Dim parties As Integer = joueur(3) + 1
                Dim tempsCumule As Integer = joueur(4) + tempsPourTrouver
                If score > ancienScore Then
                    contenu = contenu & nom & " " & setTermines.ToString & " " & tempsPourTrouver.ToString & " " & parties.ToString & " " & tempsCumule.ToString & vbCr
                Else
                    contenu = contenu & nom & " " & joueur(1) & " " & joueur(2) & " " & parties.ToString & " " & tempsCumule.ToString & vbCr
                End If
            Else
                contenu = contenu & ligne & vbCr
            End If
        Loop
        If nouveau Then
            contenu = contenu & nom & " " & setTermines.ToString & " " & tempsPourTrouver.ToString & " 1 " & tempsPourTrouver.ToString & vbCr
        End If
        FileClose(n)

        FileOpen(n, ".//Sauvegarde//Score.txt", OpenMode.Output)
        WriteLine(n, contenu)
        FileClose(n)
    End Sub

    Public Function ChargerJoueurs() As List(Of Joueur)
        Dim joueurs As New List(Of Joueur)
        Dim n As Integer = FreeFile()
        FileOpen(n, ".//Sauvegarde//Score.txt", OpenMode.Input)
        Dim ligne As String
        Do Until EOF(n)
            ligne = LineInput(n).Trim(Chr(34))
            If ligne.Count > 0 Then
                Dim sauvegarde As String() = Split(ligne, " ")
                Dim joueur As New Joueur
                joueur.Nom = sauvegarde(0)
                joueur.CarreTrouves = sauvegarde(1)
                joueur.TempsMinimum = sauvegarde(2)
                joueur.Parties = sauvegarde(3)
                joueur.TempsCumule = sauvegarde(4)
                joueurs.Add(joueur)
            End If
        Loop
        FileClose(n)
        ChargerJoueurs = joueurs
    End Function

End Module
