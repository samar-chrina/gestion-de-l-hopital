<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherPatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriseDeRdvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriseDeRDVToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVDuJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientsToolStripMenuItem, Me.PriseDeRdvToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 41)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientsToolStripMenuItem
        '
        Me.PatientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterPatientToolStripMenuItem, Me.AfficherPatientsToolStripMenuItem})
        Me.PatientsToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem"
        Me.PatientsToolStripMenuItem.Size = New System.Drawing.Size(119, 37)
        Me.PatientsToolStripMenuItem.Text = "patients"
        '
        'AjouterPatientToolStripMenuItem
        '
        Me.AjouterPatientToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjouterPatientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.AjouterPatientToolStripMenuItem.Name = "AjouterPatientToolStripMenuItem"
        Me.AjouterPatientToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AjouterPatientToolStripMenuItem.Text = "Ajouter patient"
        '
        'AfficherPatientsToolStripMenuItem
        '
        Me.AfficherPatientsToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfficherPatientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.AfficherPatientsToolStripMenuItem.Name = "AfficherPatientsToolStripMenuItem"
        Me.AfficherPatientsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AfficherPatientsToolStripMenuItem.Text = "Afficher patients"
        '
        'PriseDeRdvToolStripMenuItem
        '
        Me.PriseDeRdvToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PriseDeRDVToolStripMenuItem1, Me.RDVDuJourToolStripMenuItem})
        Me.PriseDeRdvToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriseDeRdvToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.PriseDeRdvToolStripMenuItem.Name = "PriseDeRdvToolStripMenuItem"
        Me.PriseDeRdvToolStripMenuItem.Size = New System.Drawing.Size(163, 37)
        Me.PriseDeRdvToolStripMenuItem.Text = "prise de rdv"
        '
        'PriseDeRDVToolStripMenuItem1
        '
        Me.PriseDeRDVToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriseDeRDVToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PriseDeRDVToolStripMenuItem1.Name = "PriseDeRDVToolStripMenuItem1"
        Me.PriseDeRDVToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.PriseDeRDVToolStripMenuItem1.Text = "prise de RDV "
        '
        'RDVDuJourToolStripMenuItem
        '
        Me.RDVDuJourToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDVDuJourToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RDVDuJourToolStripMenuItem.Name = "RDVDuJourToolStripMenuItem"
        Me.RDVDuJourToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RDVDuJourToolStripMenuItem.Text = "RDV du jour"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "frm_main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriseDeRdvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AjouterPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherPatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriseDeRDVToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RDVDuJourToolStripMenuItem As ToolStripMenuItem
End Class
