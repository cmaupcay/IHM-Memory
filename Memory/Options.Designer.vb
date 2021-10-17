<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxParamPartie = New System.Windows.Forms.GroupBox()
        Me.CheckBoxPause = New System.Windows.Forms.CheckBox()
        Me.LabelSecondes = New System.Windows.Forms.Label()
        Me.TextBoxSecondes = New System.Windows.Forms.TextBox()
        Me.LabelMinute = New System.Windows.Forms.Label()
        Me.TextBoxMinutes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxGraphisme = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCartes = New System.Windows.Forms.GroupBox()
        Me.CarteRecto = New System.Windows.Forms.Label()
        Me.CarteVerso = New System.Windows.Forms.Label()
        Me.ComboBoxTheme = New System.Windows.Forms.ComboBox()
        Me.LabelTheme = New System.Windows.Forms.Label()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.GroupBoxParamPartie.SuspendLayout()
        Me.GroupBoxGraphisme.SuspendLayout()
        Me.GroupBoxCartes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxParamPartie
        '
        Me.GroupBoxParamPartie.Controls.Add(Me.CheckBoxPause)
        Me.GroupBoxParamPartie.Controls.Add(Me.LabelSecondes)
        Me.GroupBoxParamPartie.Controls.Add(Me.TextBoxSecondes)
        Me.GroupBoxParamPartie.Controls.Add(Me.LabelMinute)
        Me.GroupBoxParamPartie.Controls.Add(Me.TextBoxMinutes)
        Me.GroupBoxParamPartie.Controls.Add(Me.Label1)
        Me.GroupBoxParamPartie.Location = New System.Drawing.Point(12, 24)
        Me.GroupBoxParamPartie.Name = "GroupBoxParamPartie"
        Me.GroupBoxParamPartie.Size = New System.Drawing.Size(468, 101)
        Me.GroupBoxParamPartie.TabIndex = 0
        Me.GroupBoxParamPartie.TabStop = False
        Me.GroupBoxParamPartie.Text = "Paramètres de la partie"
        '
        'CheckBoxPause
        '
        Me.CheckBoxPause.AutoSize = True
        Me.CheckBoxPause.Location = New System.Drawing.Point(25, 56)
        Me.CheckBoxPause.Name = "CheckBoxPause"
        Me.CheckBoxPause.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxPause.TabIndex = 5
        Me.CheckBoxPause.Text = "Autoriser les pauses"
        Me.CheckBoxPause.UseVisualStyleBackColor = True
        '
        'LabelSecondes
        '
        Me.LabelSecondes.AutoSize = True
        Me.LabelSecondes.Location = New System.Drawing.Point(238, 23)
        Me.LabelSecondes.Name = "LabelSecondes"
        Me.LabelSecondes.Size = New System.Drawing.Size(24, 13)
        Me.LabelSecondes.TabIndex = 4
        Me.LabelSecondes.Text = "sec"
        '
        'TextBoxSecondes
        '
        Me.TextBoxSecondes.Location = New System.Drawing.Point(166, 20)
        Me.TextBoxSecondes.Name = "TextBoxSecondes"
        Me.TextBoxSecondes.Size = New System.Drawing.Size(66, 20)
        Me.TextBoxSecondes.TabIndex = 3
        '
        'LabelMinute
        '
        Me.LabelMinute.AutoSize = True
        Me.LabelMinute.Location = New System.Drawing.Point(137, 23)
        Me.LabelMinute.Name = "LabelMinute"
        Me.LabelMinute.Size = New System.Drawing.Size(23, 13)
        Me.LabelMinute.TabIndex = 2
        Me.LabelMinute.Text = "min"
        '
        'TextBoxMinutes
        '
        Me.TextBoxMinutes.Location = New System.Drawing.Point(65, 20)
        Me.TextBoxMinutes.Name = "TextBoxMinutes"
        Me.TextBoxMinutes.Size = New System.Drawing.Size(66, 20)
        Me.TextBoxMinutes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Durée"
        '
        'GroupBoxGraphisme
        '
        Me.GroupBoxGraphisme.Controls.Add(Me.GroupBoxCartes)
        Me.GroupBoxGraphisme.Controls.Add(Me.ComboBoxTheme)
        Me.GroupBoxGraphisme.Controls.Add(Me.LabelTheme)
        Me.GroupBoxGraphisme.Location = New System.Drawing.Point(13, 145)
        Me.GroupBoxGraphisme.Name = "GroupBoxGraphisme"
        Me.GroupBoxGraphisme.Size = New System.Drawing.Size(467, 220)
        Me.GroupBoxGraphisme.TabIndex = 1
        Me.GroupBoxGraphisme.TabStop = False
        Me.GroupBoxGraphisme.Text = "Graphisme"
        '
        'GroupBoxCartes
        '
        Me.GroupBoxCartes.Controls.Add(Me.CarteRecto)
        Me.GroupBoxCartes.Controls.Add(Me.CarteVerso)
        Me.GroupBoxCartes.Location = New System.Drawing.Point(24, 71)
        Me.GroupBoxCartes.Name = "GroupBoxCartes"
        Me.GroupBoxCartes.Size = New System.Drawing.Size(221, 140)
        Me.GroupBoxCartes.TabIndex = 9
        Me.GroupBoxCartes.TabStop = False
        '
        'CarteRecto
        '
        Me.CarteRecto.BackColor = System.Drawing.SystemColors.Highlight
        Me.CarteRecto.Location = New System.Drawing.Point(6, 25)
        Me.CarteRecto.Name = "CarteRecto"
        Me.CarteRecto.Size = New System.Drawing.Size(100, 100)
        Me.CarteRecto.TabIndex = 7
        Me.CarteRecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarteVerso
        '
        Me.CarteVerso.BackColor = System.Drawing.SystemColors.Highlight
        Me.CarteVerso.Location = New System.Drawing.Point(112, 25)
        Me.CarteVerso.Name = "CarteVerso"
        Me.CarteVerso.Size = New System.Drawing.Size(100, 100)
        Me.CarteVerso.TabIndex = 6
        Me.CarteVerso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxTheme
        '
        Me.ComboBoxTheme.FormattingEnabled = True
        Me.ComboBoxTheme.Items.AddRange(New Object() {"Naruto", "One Piece"})
        Me.ComboBoxTheme.Location = New System.Drawing.Point(70, 35)
        Me.ComboBoxTheme.Name = "ComboBoxTheme"
        Me.ComboBoxTheme.Size = New System.Drawing.Size(161, 21)
        Me.ComboBoxTheme.TabIndex = 1
        '
        'LabelTheme
        '
        Me.LabelTheme.AutoSize = True
        Me.LabelTheme.Location = New System.Drawing.Point(24, 38)
        Me.LabelTheme.Name = "LabelTheme"
        Me.LabelTheme.Size = New System.Drawing.Size(40, 13)
        Me.LabelTheme.TabIndex = 0
        Me.LabelTheme.Text = "Theme"
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(13, 399)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(467, 23)
        Me.ButtonRetour.TabIndex = 2
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 450)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.GroupBoxGraphisme)
        Me.Controls.Add(Me.GroupBoxParamPartie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Options"
        Me.Text = "Options"
        Me.GroupBoxParamPartie.ResumeLayout(False)
        Me.GroupBoxParamPartie.PerformLayout()
        Me.GroupBoxGraphisme.ResumeLayout(False)
        Me.GroupBoxGraphisme.PerformLayout()
        Me.GroupBoxCartes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxParamPartie As Windows.Forms.GroupBox
    Friend WithEvents CheckBoxPause As Windows.Forms.CheckBox
    Friend WithEvents LabelSecondes As Windows.Forms.Label
    Friend WithEvents TextBoxSecondes As Windows.Forms.TextBox
    Friend WithEvents LabelMinute As Windows.Forms.Label
    Friend WithEvents TextBoxMinutes As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBoxGraphisme As Windows.Forms.GroupBox
    Friend WithEvents GroupBoxCartes As Windows.Forms.GroupBox
    Friend WithEvents CarteRecto As Windows.Forms.Label
    Friend WithEvents CarteVerso As Windows.Forms.Label
    Friend WithEvents ComboBoxTheme As Windows.Forms.ComboBox
    Friend WithEvents LabelTheme As Windows.Forms.Label
    Friend WithEvents ButtonRetour As Windows.Forms.Button
End Class
