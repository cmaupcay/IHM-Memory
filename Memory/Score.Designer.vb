<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Me.ListBoxScore = New System.Windows.Forms.ListBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxScore
        '
        Me.ListBoxScore.FormattingEnabled = True
        Me.ListBoxScore.Location = New System.Drawing.Point(35, 36)
        Me.ListBoxScore.Name = "ListBoxScore"
        Me.ListBoxScore.Size = New System.Drawing.Size(461, 316)
        Me.ListBoxScore.TabIndex = 0
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(35, 383)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(461, 23)
        Me.ButtonRetour.TabIndex = 1
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 450)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ListBoxScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Score"
        Me.Text = "Score"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxScore As Windows.Forms.ListBox
    Friend WithEvents ButtonRetour As Windows.Forms.Button
End Class
