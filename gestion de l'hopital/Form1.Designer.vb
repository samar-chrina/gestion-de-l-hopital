<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_authentification
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pw = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codesecurite = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(156, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "authentification"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(3, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom d'utilisateur :"
        '
        'txt_login
        '
        Me.txt_login.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(196, 128)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(203, 31)
        Me.txt_login.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(9, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mot de passe :"
        '
        'txt_pw
        '
        Me.txt_pw.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pw.Location = New System.Drawing.Point(191, 198)
        Me.txt_pw.Name = "txt_pw"
        Me.txt_pw.Size = New System.Drawing.Size(208, 31)
        Me.txt_pw.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(12, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NB : le mot de passe doit contenir 4 caractéres !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_annuler.Location = New System.Drawing.Point(445, 386)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(149, 40)
        Me.btn_annuler.TabIndex = 7
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_valider
        '
        Me.btn_valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(639, 386)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(149, 40)
        Me.btn_valider.TabIndex = 8
        Me.btn_valider.Text = "valider"
        Me.btn_valider.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(9, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Code de sécurité:"
        '
        'txt_codesecurite
        '
        Me.txt_codesecurite.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_codesecurite.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codesecurite.Location = New System.Drawing.Point(191, 276)
        Me.txt_codesecurite.Name = "txt_codesecurite"
        Me.txt_codesecurite.Size = New System.Drawing.Size(208, 31)
        Me.txt_codesecurite.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(12, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "NB : le code doit contenir 5 caractéres !"
        '
        'frm_authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_codesecurite)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_pw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_authentification"
        Me.Text = "frm_authentification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_pw As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_valider As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codesecurite As TextBox
    Friend WithEvents Label6 As Label
End Class
