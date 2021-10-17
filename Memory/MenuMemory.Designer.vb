<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMemory
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
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.LabelNomJoueur = New System.Windows.Forms.Label()
        Me.ButtonJouer = New System.Windows.Forms.Button()
        Me.ButtonScore = New System.Windows.Forms.Button()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Lucida Sans Unicode", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(78, 26)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(314, 78)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "MEMORY"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(91, 178)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(279, 21)
        Me.ComboBoxNom.TabIndex = 1
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.Location = New System.Drawing.Point(177, 162)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(93, 13)
        Me.LabelNomJoueur.TabIndex = 2
        Me.LabelNomJoueur.Text = "Entrez votre nom :"
        '
        'ButtonJouer
        '
        Me.ButtonJouer.Location = New System.Drawing.Point(91, 205)
        Me.ButtonJouer.Name = "ButtonJouer"
        Me.ButtonJouer.Size = New System.Drawing.Size(279, 23)
        Me.ButtonJouer.TabIndex = 3
        Me.ButtonJouer.Text = "Jouer"
        Me.ButtonJouer.UseVisualStyleBackColor = True
        '
        'ButtonScore
        '
        Me.ButtonScore.Location = New System.Drawing.Point(91, 261)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(279, 23)
        Me.ButtonScore.TabIndex = 4
        Me.ButtonScore.Text = "Score"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Location = New System.Drawing.Point(91, 290)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(279, 23)
        Me.ButtonOptions.TabIndex = 5
        Me.ButtonOptions.Text = "Options"
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(91, 334)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(279, 23)
        Me.ButtonQuitter.TabIndex = 6
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'MenuMemory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 369)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonOptions)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ButtonJouer)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.LabelTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MenuMemory"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Windows.Forms.Label
    Friend WithEvents ComboBoxNom As Windows.Forms.ComboBox
    Friend WithEvents LabelNomJoueur As Windows.Forms.Label
    Friend WithEvents ButtonJouer As Windows.Forms.Button
    Friend WithEvents ButtonScore As Windows.Forms.Button
    Friend WithEvents ButtonOptions As Windows.Forms.Button
    Friend WithEvents ButtonQuitter As Windows.Forms.Button
End Class
