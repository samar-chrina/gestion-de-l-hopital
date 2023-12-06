<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AjoutPatient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nom du patient :"
        '
        'txt_nom
        '
        Me.txt_nom.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom.Location = New System.Drawing.Point(184, 84)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(176, 26)
        Me.txt_nom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(3, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "prénom du patient :"
        '
        'txt_prenom
        '
        Me.txt_prenom.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prenom.Location = New System.Drawing.Point(184, 175)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(176, 26)
        Me.txt_prenom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(3, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "code du patient :"
        '
        'txt_code
        '
        Me.txt_code.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(184, 271)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(176, 26)
        Me.txt_code.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(12, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Obligatoire*"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_ajouter.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(609, 351)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(164, 34)
        Me.btn_ajouter.TabIndex = 7
        Me.btn_ajouter.Text = "ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_annuler.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(609, 404)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(164, 34)
        Me.btn_annuler.TabIndex = 8
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'frm_AjoutPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_AjoutPatient"
        Me.Text = "frm_AjoutPatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_annuler As Button
End Class
