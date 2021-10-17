Imports System.Drawing

Public Class Options
    Dim param As Parametres

    Private Sub Options_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        param.Partie_ModifierMinutes(TextBoxMinutes.Text)
        param.Partie_ModifierSecondes(TextBoxSecondes.Text)
        param.Sauver()
        MenuMemory.Show()
    End Sub

    Private Sub AppliquerTheme()
        Dim theme As Integer = Me.ComboBoxTheme.SelectedIndex + 1
        param.Graph_ModifierTheme(theme)
        Me.CarteVerso.Image = Image.FromFile(".//Images//Theme" & theme & "//CarteVerso.png")
        Me.CarteRecto.Image = Image.FromFile(".//Images//Theme" & theme & "//Carte1.png")
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        param = New Parametres()
        Me.ComboBoxTheme.SelectedIndex = param.Graph_Theme() - 1
        Me.TextBoxMinutes.Text = param.Partie_Minutes()
        Me.TextBoxSecondes.Text = param.Partie_Secondes()
        Me.CheckBoxPause.Checked = param.Partie_Pause()
        AppliquerTheme()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
    End Sub

    Private Sub ComboBoxTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTheme.SelectedIndexChanged
        AppliquerTheme()
    End Sub

    Private Sub CheckBoxPause_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPause.CheckedChanged
        param.Partie_ModifierPause(CheckBoxPause.Checked)
    End Sub

    Private Sub VerifierEntreeTemps(ByVal c)
        If Char.IsNumber(c.keychar) Or Asc(c.keychar) = 8 Then
            c.handled = False
        Else
            c.handled = True
        End If
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles TextBoxMinutes.KeyPress, TextBoxSecondes.KeyPress
        VerifierEntreeTemps(e)
    End Sub
End Class