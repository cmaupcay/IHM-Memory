<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelNomJoueur = New System.Windows.Forms.Label()
        Me.Horloge = New System.Windows.Forms.Label()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.GroupBoxCartes = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Carte15 = New System.Windows.Forms.Label()
        Me.Carte10 = New System.Windows.Forms.Label()
        Me.Carte9 = New System.Windows.Forms.Label()
        Me.Carte14 = New System.Windows.Forms.Label()
        Me.Carte8 = New System.Windows.Forms.Label()
        Me.Carte7 = New System.Windows.Forms.Label()
        Me.Carte13 = New System.Windows.Forms.Label()
        Me.Carte6 = New System.Windows.Forms.Label()
        Me.Carte5 = New System.Windows.Forms.Label()
        Me.Carte12 = New System.Windows.Forms.Label()
        Me.Carte4 = New System.Windows.Forms.Label()
        Me.Carte3 = New System.Windows.Forms.Label()
        Me.Carte11 = New System.Windows.Forms.Label()
        Me.Carte2 = New System.Windows.Forms.Label()
        Me.Carte1 = New System.Windows.Forms.Label()
        Me.TimerHorloge = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxCartes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.Location = New System.Drawing.Point(12, 13)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(61, 13)
        Me.LabelNomJoueur.TabIndex = 0
        Me.LabelNomJoueur.Text = "NomJoueur"
        Me.LabelNomJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Horloge
        '
        Me.Horloge.AutoSize = True
        Me.Horloge.Location = New System.Drawing.Point(543, 13)
        Me.Horloge.Name = "Horloge"
        Me.Horloge.Size = New System.Drawing.Size(28, 13)
        Me.Horloge.TabIndex = 1
        Me.Horloge.Text = "1:00"
        Me.Horloge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonPause
        '
        Me.ButtonPause.Location = New System.Drawing.Point(15, 31)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(296, 23)
        Me.ButtonPause.TabIndex = 2
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.Location = New System.Drawing.Point(317, 31)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(254, 23)
        Me.ButtonAbandonner.TabIndex = 3
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = True
        '
        'GroupBoxCartes
        '
        Me.GroupBoxCartes.Controls.Add(Me.Label1)
        Me.GroupBoxCartes.Controls.Add(Me.Label2)
        Me.GroupBoxCartes.Controls.Add(Me.Label3)
        Me.GroupBoxCartes.Controls.Add(Me.Label4)
        Me.GroupBoxCartes.Controls.Add(Me.Label5)
        Me.GroupBoxCartes.Controls.Add(Me.Carte15)
        Me.GroupBoxCartes.Controls.Add(Me.Carte10)
        Me.GroupBoxCartes.Controls.Add(Me.Carte9)
        Me.GroupBoxCartes.Controls.Add(Me.Carte14)
        Me.GroupBoxCartes.Controls.Add(Me.Carte8)
        Me.GroupBoxCartes.Controls.Add(Me.Carte7)
        Me.GroupBoxCartes.Controls.Add(Me.Carte13)
        Me.GroupBoxCartes.Controls.Add(Me.Carte6)
        Me.GroupBoxCartes.Controls.Add(Me.Carte5)
        Me.GroupBoxCartes.Controls.Add(Me.Carte12)
        Me.GroupBoxCartes.Controls.Add(Me.Carte4)
        Me.GroupBoxCartes.Controls.Add(Me.Carte3)
        Me.GroupBoxCartes.Controls.Add(Me.Carte11)
        Me.GroupBoxCartes.Controls.Add(Me.Carte2)
        Me.GroupBoxCartes.Controls.Add(Me.Carte1)
        Me.GroupBoxCartes.Location = New System.Drawing.Point(15, 58)
        Me.GroupBoxCartes.Name = "GroupBoxCartes"
        Me.GroupBoxCartes.Size = New System.Drawing.Size(555, 703)
        Me.GroupBoxCartes.TabIndex = 4
        Me.GroupBoxCartes.TabStop = False
        Me.GroupBoxCartes.Text = "Plateau"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(443, 525)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 160)
        Me.Label1.TabIndex = 20
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(336, 525)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 160)
        Me.Label2.TabIndex = 19
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(229, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 160)
        Me.Label3.TabIndex = 18
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(122, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 160)
        Me.Label4.TabIndex = 17
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(15, 525)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 160)
        Me.Label5.TabIndex = 16
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte15
        '
        Me.Carte15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte15.Location = New System.Drawing.Point(443, 356)
        Me.Carte15.Name = "Carte15"
        Me.Carte15.Size = New System.Drawing.Size(101, 160)
        Me.Carte15.TabIndex = 15
        Me.Carte15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte10
        '
        Me.Carte10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte10.Location = New System.Drawing.Point(443, 186)
        Me.Carte10.Name = "Carte10"
        Me.Carte10.Size = New System.Drawing.Size(101, 160)
        Me.Carte10.TabIndex = 10
        Me.Carte10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte9
        '
        Me.Carte9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte9.Location = New System.Drawing.Point(336, 186)
        Me.Carte9.Name = "Carte9"
        Me.Carte9.Size = New System.Drawing.Size(101, 160)
        Me.Carte9.TabIndex = 9
        Me.Carte9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte14
        '
        Me.Carte14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte14.Location = New System.Drawing.Point(336, 356)
        Me.Carte14.Name = "Carte14"
        Me.Carte14.Size = New System.Drawing.Size(101, 160)
        Me.Carte14.TabIndex = 14
        Me.Carte14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte8
        '
        Me.Carte8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte8.Location = New System.Drawing.Point(229, 186)
        Me.Carte8.Name = "Carte8"
        Me.Carte8.Size = New System.Drawing.Size(101, 160)
        Me.Carte8.TabIndex = 8
        Me.Carte8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte7
        '
        Me.Carte7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte7.Location = New System.Drawing.Point(122, 186)
        Me.Carte7.Name = "Carte7"
        Me.Carte7.Size = New System.Drawing.Size(101, 160)
        Me.Carte7.TabIndex = 7
        Me.Carte7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte13
        '
        Me.Carte13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte13.Location = New System.Drawing.Point(229, 356)
        Me.Carte13.Name = "Carte13"
        Me.Carte13.Size = New System.Drawing.Size(101, 160)
        Me.Carte13.TabIndex = 13
        Me.Carte13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte6
        '
        Me.Carte6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte6.Location = New System.Drawing.Point(15, 186)
        Me.Carte6.Name = "Carte6"
        Me.Carte6.Size = New System.Drawing.Size(101, 160)
        Me.Carte6.TabIndex = 6
        Me.Carte6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte5
        '
        Me.Carte5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte5.Location = New System.Drawing.Point(443, 16)
        Me.Carte5.Name = "Carte5"
        Me.Carte5.Size = New System.Drawing.Size(101, 160)
        Me.Carte5.TabIndex = 5
        Me.Carte5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte12
        '
        Me.Carte12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte12.Location = New System.Drawing.Point(122, 356)
        Me.Carte12.Name = "Carte12"
        Me.Carte12.Size = New System.Drawing.Size(101, 160)
        Me.Carte12.TabIndex = 12
        Me.Carte12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte4
        '
        Me.Carte4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte4.Location = New System.Drawing.Point(336, 16)
        Me.Carte4.Name = "Carte4"
        Me.Carte4.Size = New System.Drawing.Size(101, 160)
        Me.Carte4.TabIndex = 4
        Me.Carte4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte3
        '
        Me.Carte3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte3.Location = New System.Drawing.Point(229, 16)
        Me.Carte3.Name = "Carte3"
        Me.Carte3.Size = New System.Drawing.Size(101, 160)
        Me.Carte3.TabIndex = 3
        Me.Carte3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte11
        '
        Me.Carte11.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte11.Location = New System.Drawing.Point(15, 356)
        Me.Carte11.Name = "Carte11"
        Me.Carte11.Size = New System.Drawing.Size(101, 160)
        Me.Carte11.TabIndex = 11
        Me.Carte11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte2
        '
        Me.Carte2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte2.Location = New System.Drawing.Point(122, 16)
        Me.Carte2.Name = "Carte2"
        Me.Carte2.Size = New System.Drawing.Size(101, 160)
        Me.Carte2.TabIndex = 2
        Me.Carte2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte1
        '
        Me.Carte1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Carte1.Location = New System.Drawing.Point(15, 16)
        Me.Carte1.Name = "Carte1"
        Me.Carte1.Size = New System.Drawing.Size(101, 160)
        Me.Carte1.TabIndex = 1
        Me.Carte1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerHorloge
        '
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 749)
        Me.Controls.Add(Me.GroupBoxCartes)
        Me.Controls.Add(Me.ButtonAbandonner)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.Horloge)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Jeu"
        Me.Text = "Memories"
        Me.GroupBoxCartes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNomJoueur As Windows.Forms.Label
    Friend WithEvents Horloge As Windows.Forms.Label
    Friend WithEvents ButtonPause As Windows.Forms.Button
    Friend WithEvents ButtonAbandonner As Windows.Forms.Button
    Friend WithEvents GroupBoxCartes As Windows.Forms.GroupBox
    Friend WithEvents Carte15 As Windows.Forms.Label
    Friend WithEvents Carte10 As Windows.Forms.Label
    Friend WithEvents Carte9 As Windows.Forms.Label
    Friend WithEvents Carte14 As Windows.Forms.Label
    Friend WithEvents Carte8 As Windows.Forms.Label
    Friend WithEvents Carte7 As Windows.Forms.Label
    Friend WithEvents Carte13 As Windows.Forms.Label
    Friend WithEvents Carte6 As Windows.Forms.Label
    Friend WithEvents Carte5 As Windows.Forms.Label
    Friend WithEvents Carte12 As Windows.Forms.Label
    Friend WithEvents Carte4 As Windows.Forms.Label
    Friend WithEvents Carte3 As Windows.Forms.Label
    Friend WithEvents Carte11 As Windows.Forms.Label
    Friend WithEvents Carte2 As Windows.Forms.Label
    Friend WithEvents Carte1 As Windows.Forms.Label
    Friend WithEvents TimerHorloge As Windows.Forms.Timer
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
End Class
