Module ModuleParametres

    Class Parametres
        Private TempsPartie_Minutes As Integer
        Private TempsPartie_Secondes As Integer
        Private AutoriserPause As Boolean
        Private ThemeActuel As Integer

        Public Sub New()
            Dim n As Integer = FreeFile()
            FileOpen(n, ".//Sauvegarde//Parametres.txt", OpenMode.Input)
            Dim param As String() = Split(LineInput(n).Trim(Chr(34)), " ")
            TempsPartie_Minutes = param(0)
            TempsPartie_Secondes = param(1)
            AutoriserPause = param(2)
            ThemeActuel = param(3)
            FileClose(n)
        End Sub

        Public Sub Sauver()
            Dim n As Integer = FreeFile()
            FileOpen(n, ".//Sauvegarde//Parametres.txt", OpenMode.Output)
            WriteLine(n, TempsPartie_Minutes.ToString & " " & TempsPartie_Secondes.ToString & " " & CInt(AutoriserPause).ToString & " " & ThemeActuel.ToString + vbCr)
            FileClose(n)
        End Sub

        Public Function Partie_Minutes() As Integer
            Return TempsPartie_Minutes
        End Function

        Public Function Partie_Secondes() As Integer
            Return TempsPartie_Secondes
        End Function

        Public Function Partie_Pause() As Boolean
            Return AutoriserPause
        End Function

        Public Function Graph_Theme() As Integer
            Return ThemeActuel
        End Function

        Public Sub Partie_ModifierMinutes(Minutes As Integer)
            If Minutes < 0 Then
                Me.TempsPartie_Minutes = 0
            ElseIf Minutes >= 60 Then
                Me.TempsPartie_Minutes = 59
            Else
                Me.TempsPartie_Minutes = Minutes
            End If
        End Sub

        Public Sub Partie_ModifierSecondes(Secondes As Integer)
            If Secondes < 0 Then
                Me.TempsPartie_Secondes = 0
            ElseIf Secondes >= 60 Then
                Me.TempsPartie_Secondes = 59
            Else
                Me.TempsPartie_Secondes = Secondes
            End If
        End Sub

        Public Sub Partie_ModifierPause(Pause As Boolean)
            Me.AutoriserPause = Pause
        End Sub

        Public Sub Graph_ModifierTheme(Theme As Integer)
            Me.ThemeActuel = Theme
        End Sub
    End Class

End Module
