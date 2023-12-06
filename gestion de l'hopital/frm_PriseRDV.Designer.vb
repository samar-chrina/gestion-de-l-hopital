<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PriseRDV
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
        Me.txt_codepatient = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_d = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_heure = New System.Windows.Forms.TextBox()
        Me.btn_confirmer = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "code du patient :"
        '
        'txt_codepatient
        '
        Me.txt_codepatient.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_codepatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codepatient.Location = New System.Drawing.Point(214, 57)
        Me.txt_codepatient.Name = "txt_codepatient"
        Me.txt_codepatient.Size = New System.Drawing.Size(153, 26)
        Me.txt_codepatient.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(3, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "date du rendez-vous:"
        '
        'txt_d
        '
        Me.txt_d.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_d.Location = New System.Drawing.Point(214, 131)
        Me.txt_d.Name = "txt_d"
        Me.txt_d.Size = New System.Drawing.Size(153, 26)
        Me.txt_d.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(3, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "heure du rendez vous :"
        '
        'txt_heure
        '
        Me.txt_heure.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_heure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heure.Location = New System.Drawing.Point(214, 203)
        Me.txt_heure.Name = "txt_heure"
        Me.txt_heure.Size = New System.Drawing.Size(153, 26)
        Me.txt_heure.TabIndex = 5
        '
        'btn_confirmer
        '
        Me.btn_confirmer.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_confirmer.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmer.Location = New System.Drawing.Point(582, 341)
        Me.btn_confirmer.Name = "btn_confirmer"
        Me.btn_confirmer.Size = New System.Drawing.Size(156, 31)
        Me.btn_confirmer.TabIndex = 6
        Me.btn_confirmer.Text = "confirmer"
        Me.btn_confirmer.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_annuler.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(582, 393)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(156, 29)
        Me.btn_annuler.TabIndex = 7
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'frm_PriseRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_confirmer)
        Me.Controls.Add(Me.txt_heure)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_d)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_codepatient)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_PriseRDV"
        Me.Text = "frm_PriseRDV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codepatient As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_d As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_heure As TextBox
    Friend WithEvents btn_confirmer As Button
    Friend WithEvents btn_annuler As Button
End Class
