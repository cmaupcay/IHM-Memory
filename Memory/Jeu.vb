Imports System.Drawing
Imports System.Windows.Forms

Public Class Jeu
    Dim param As Parametres
    Dim temps As Date
    Dim tempsRestant As Date
    Dim tempsPourTrouver As Integer = 0
    Dim cartesVisibles As Integer = 0
    Dim setTermines As Integer = 0

    Dim idSet As Integer = -1
    Dim pause As Boolean = False

    Dim ignorerVerificationSortie As Boolean = False
    Private Class Carte
        Public label As Label
        Public visible As Boolean
        Public idImage As Integer
        Public image As Drawing.Image
    End Class
    Private listeCartes As New List(Of Carte)

    Private Sub InitialiserHorloge()
        temps = "#00:" & param.Partie_Minutes() & ":" & param.Partie_Secondes() & "#"
        tempsRestant = temps
        TimerHorloge.Interval = 1000
        Me.Horloge.Text = Format(tempsRestant, "mm:ss")
        TimerHorloge.Start()
    End Sub
    Private Sub InitialiserCartes()
        Dim theme As Integer = param.Graph_Theme()
        Dim id As Integer = 0
        Dim i As Integer
        For i = 0 To 19
            id = i Mod 5
            listeCartes.Add(New Carte With {
                .idImage = id,
                .image = Image.FromFile(".//Images//Theme" & theme & "//Carte" & id & ".png"),
                .visible = False
            })
        Next

        listeCartes = Melanger(listeCartes)

        i = 0
        For Each label As Label In GroupBoxCartes.Controls
            listeCartes(i).label = label
            label.Name = i
            AddHandler label.Click, AddressOf ActualiserCartes
            i += 1
        Next
    End Sub
    Private Sub AfficherCartes()
        For Each carte As Carte In listeCartes
            If carte.visible Then
                carte.label.Image = carte.image
            ElseIf carte.label.Enabled Then
                carte.label.Image = Image.FromFile(".//Images//Theme" & param.Graph_Theme() & "//CarteVerso.png")
            End If
        Next
    End Sub

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        param = New Parametres()
        LabelNomJoueur.Text = MenuMemory.ComboBoxNom.Text
        ButtonPause.Visible = param.Partie_Pause()
        InitialiserHorloge()
        InitialiserCartes()
        AfficherCartes()
    End Sub

    Function Melanger(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Dim r As Random = New Random()
        Melanger = collection.OrderBy(Function(a) r.Next()).ToList()
    End Function

    Public Sub Attendre(secondes As Single)
        Static debut As Single
        debut = Microsoft.VisualBasic.Timer()
        Do While Microsoft.VisualBasic.Timer() < debut + secondes
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Private Sub SetTermine()
        For Each carte As Carte In listeCartes
            If carte.visible Then
                carte.label.Enabled = False
            End If
        Next
        tempsPourTrouver = DateDiff(DateInterval.Second, tempsRestant, temps)
        setTermines += 1
    End Sub

    Private Sub ActualiserCartes(sender As Object, e As EventArgs)
        Dim label As Label = DirectCast(sender, Label)
        Dim carte As Carte = listeCartes(Integer.Parse(label.Name))
        If carte.visible Then
            Return
        End If

        'Première carte du set
        If idSet = -1 Then
            idSet = carte.idImage
        End If
        carte.visible = True
        AfficherCartes()

        'Cartes suivantes
        If idSet = carte.idImage Then
            cartesVisibles += 1
            ' Un set retourné
            If cartesVisibles = 4 Then
                SetTermine()
                cartesVisibles = 0
                idSet = -1
            End If
            'Toutes les cartes ont ete retournees
            If setTermines = 5 Then
                TimerHorloge.Stop()
                FinPartie(True)
            End If
        Else
            For Each c As Carte In listeCartes
                c.visible = False
            Next
            Attendre(0.5)
            idSet = -1
            cartesVisibles = 0
            AfficherCartes()
        End If
    End Sub

    Private Sub ButtonAbandonner_Click(sender As Object, e As EventArgs) Handles ButtonAbandonner.Click
        Me.Close()
    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        pause = Not pause 'Changement de l'etat
        If pause Then
            TimerHorloge.Stop()
        Else
            TimerHorloge.Start()
        End If
        GroupBoxCartes.Enabled = Not pause
    End Sub

    Private Sub Jeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ignorerVerificationSortie Then
            MenuMemory.Show()
            Return
        End If
        Dim reponse As Integer = MsgBox("Voulez-vous abandonner la partie ?", vbQuestion + vbYesNo + vbDefaultButton2, "Oui")
        If reponse = vbYes Then
            MenuMemory.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub TimerHorloge_Tick(sender As Object, e As EventArgs) Handles TimerHorloge.Tick
        If tempsRestant.Second > 0 Or tempsRestant.Minute > 0 Then
            tempsRestant = DateAdd(DateInterval.Second, -1, tempsRestant)
            Me.Horloge.Text = Format(tempsRestant, "mm:ss")
        Else
            TimerHorloge.Stop()
            FinPartie(False)
        End If
    End Sub

    Private Sub FinPartie(gagner As Boolean)
        If gagner Then
            MsgBox("Vous avez gagné !", vbCritical + vbOKOnly + vbDefaultButton1, "Super !")
        Else
            MsgBox("Temps écoulé..." & vbCrLf & setTermines.ToString & " carré(s) en " & tempsPourTrouver.ToString & " secondes", vbCritical + vbOKOnly + vbDefaultButton1, "Trop tard !")
        End If
        ignorerVerificationSortie = True
        ModuleJoueur.EnregistrerNouveauScore(MenuMemory.ComboBoxNom.Text, setTermines, tempsPourTrouver)
        Me.Close()
    End Sub
End Class