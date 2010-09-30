<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.b_Generer = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.b_Copier1 = New System.Windows.Forms.Button
        Me.b_Ouvrir = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.b_Copier2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.b_Activ = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.b_About = New System.Windows.Forms.Button
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_HGSS = New System.Windows.Forms.RadioButton
        Me.rb_DP = New System.Windows.Forms.RadioButton
        Me.rb_Plat = New System.Windows.Forms.RadioButton
        Me.b_Previs = New System.Windows.Forms.Button
        Me.b_Import = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EnregistrerLimageSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.b_Sauver = New System.Windows.Forms.Button
        Me.b_OuvrirSav = New System.Windows.Forms.Button
        Me.b_Recharger = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Taille = New System.Windows.Forms.Label
        Me.lbl_Bloc_Courant = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_HGSS_sav = New System.Windows.Forms.RadioButton
        Me.rb_DP_sav = New System.Windows.Forms.RadioButton
        Me.rb_Plat_sav = New System.Windows.Forms.RadioButton
        Me.cb_NoGBA = New System.Windows.Forms.CheckBox
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Generer
        '
        Me.b_Generer.Location = New System.Drawing.Point(6, 6)
        Me.b_Generer.Name = "b_Generer"
        Me.b_Generer.Size = New System.Drawing.Size(97, 23)
        Me.b_Generer.TabIndex = 1
        Me.b_Generer.Text = "Générer le code !"
        Me.ToolTip2.SetToolTip(Me.b_Generer, "Générer le code Action Replay à partir de l'image monochrome choisie.")
        Me.b_Generer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(117, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.ToolTip2.SetToolTip(Me.PictureBox1, "L'image qui servira de nouvelle signature.")
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 48)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(165, 252)
        Me.TextBox1.TabIndex = 3
        '
        'b_Copier1
        '
        Me.b_Copier1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.b_Copier1.Location = New System.Drawing.Point(6, 306)
        Me.b_Copier1.Name = "b_Copier1"
        Me.b_Copier1.Size = New System.Drawing.Size(149, 23)
        Me.b_Copier1.TabIndex = 7
        Me.b_Copier1.Text = "Copier la première partie"
        Me.ToolTip2.SetToolTip(Me.b_Copier1, "Copier la première partie du code dans le presse-papiers.")
        Me.b_Copier1.UseVisualStyleBackColor = True
        '
        'b_Ouvrir
        '
        Me.b_Ouvrir.Location = New System.Drawing.Point(12, 12)
        Me.b_Ouvrir.Name = "b_Ouvrir"
        Me.b_Ouvrir.Size = New System.Drawing.Size(99, 23)
        Me.b_Ouvrir.TabIndex = 0
        Me.b_Ouvrir.Text = "Ouvrir une image"
        Me.ToolTip2.SetToolTip(Me.b_Ouvrir, "Choisir une image à convertir en signature." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L'image doit mesurer exactement 192x" & _
                "64 pixels." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elle sera automatiquement convertie en monochrome.")
        Me.b_Ouvrir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "bmp"
        Me.OpenFileDialog1.Filter = "Fichiers images|*.bmp; *.png; *.gif; *.jpg; *.jpeg; *.wmf|Tous les fichiers|*.*"
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        Me.OpenFileDialog1.Title = "Sélectionnez une image..."
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(317, 12)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(137, 45)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.TickFrequency = 10
        Me.ToolTip2.SetToolTip(Me.TrackBar1, "Ajuster la sensibilité pour la conversion en noir et blanc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plus la sensibilité " & _
                "est élevée, plus l'image sera sombre.")
        Me.TrackBar1.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1000
        Me.Label1.Text = "Sensibilité : 0,5"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(348, 229)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 43)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Couper le code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en deux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(No$GBA)"
        Me.ToolTip2.SetToolTip(Me.CheckBox1, "Diviser le code en deux parties plus courtes afin de pouvoir le mettre sur un ému" & _
                "lateur comme No$GBA." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Entrez chaque partie comme un code distinct.")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(177, 48)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(165, 252)
        Me.TextBox2.TabIndex = 4
        '
        'b_Copier2
        '
        Me.b_Copier2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.b_Copier2.Enabled = False
        Me.b_Copier2.Location = New System.Drawing.Point(177, 306)
        Me.b_Copier2.Name = "b_Copier2"
        Me.b_Copier2.Size = New System.Drawing.Size(149, 23)
        Me.b_Copier2.TabIndex = 8
        Me.b_Copier2.Text = "Copier la deuxième partie"
        Me.ToolTip2.SetToolTip(Me.b_Copier2, "Copier la seconde partie du code dans le presse-papiers.")
        Me.b_Copier2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 1001
        Me.Label2.Text = "Première partie du code :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(174, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 1002
        Me.Label3.Text = "Deuxième partie :"
        '
        'b_Activ
        '
        Me.b_Activ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Activ.Location = New System.Drawing.Point(348, 48)
        Me.b_Activ.Name = "b_Activ"
        Me.b_Activ.Size = New System.Drawing.Size(98, 23)
        Me.b_Activ.TabIndex = 5
        Me.b_Activ.Text = "Activateurs..."
        Me.ToolTip1.SetToolTip(Me.b_Activ, "L+R")
        Me.b_Activ.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Touches à presser :"
        '
        'b_About
        '
        Me.b_About.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_About.Location = New System.Drawing.Point(397, 459)
        Me.b_About.Name = "b_About"
        Me.b_About.Size = New System.Drawing.Size(75, 23)
        Me.b_About.TabIndex = 1001
        Me.b_About.Text = "À propos..."
        Me.ToolTip2.SetToolTip(Me.b_About, "À propos du générateur de signature...")
        Me.b_About.UseVisualStyleBackColor = True
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 10000
        Me.ToolTip2.InitialDelay = 500
        Me.ToolTip2.ReshowDelay = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_HGSS)
        Me.GroupBox1.Controls.Add(Me.rb_DP)
        Me.GroupBox1.Controls.Add(Me.rb_Plat)
        Me.GroupBox1.Location = New System.Drawing.Point(348, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(98, 127)
        Me.GroupBox1.TabIndex = 1003
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Version"
        Me.ToolTip2.SetToolTip(Me.GroupBox1, "Choisissez votre version de Pokémon...")
        '
        'rb_HGSS
        '
        Me.rb_HGSS.AutoSize = True
        Me.rb_HGSS.Location = New System.Drawing.Point(6, 78)
        Me.rb_HGSS.Name = "rb_HGSS"
        Me.rb_HGSS.Size = New System.Drawing.Size(89, 30)
        Me.rb_HGSS.TabIndex = 2
        Me.rb_HGSS.TabStop = True
        Me.rb_HGSS.Text = "HeartGold/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SoulSilver FR"
        Me.ToolTip2.SetToolTip(Me.rb_HGSS, "Cochez si vous utilisez Pokémon version Or HeartGold ou Argent SoulSilver Françai" & _
                "se.")
        Me.rb_HGSS.UseVisualStyleBackColor = True
        '
        'rb_DP
        '
        Me.rb_DP.AutoSize = True
        Me.rb_DP.Location = New System.Drawing.Point(6, 19)
        Me.rb_DP.Name = "rb_DP"
        Me.rb_DP.Size = New System.Drawing.Size(69, 30)
        Me.rb_DP.TabIndex = 1
        Me.rb_DP.Text = "Diamant/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perle FR"
        Me.ToolTip2.SetToolTip(Me.rb_DP, "Cochez si vous utilisez Pokémon version Diamant ou Perle Française.")
        Me.rb_DP.UseVisualStyleBackColor = True
        '
        'rb_Plat
        '
        Me.rb_Plat.AutoSize = True
        Me.rb_Plat.Checked = True
        Me.rb_Plat.Location = New System.Drawing.Point(6, 55)
        Me.rb_Plat.Name = "rb_Plat"
        Me.rb_Plat.Size = New System.Drawing.Size(74, 17)
        Me.rb_Plat.TabIndex = 0
        Me.rb_Plat.TabStop = True
        Me.rb_Plat.Text = "Platine FR"
        Me.ToolTip2.SetToolTip(Me.rb_Plat, "Cochez si vous utilisez Pokémon version Platine Française.")
        Me.rb_Plat.UseVisualStyleBackColor = True
        '
        'b_Previs
        '
        Me.b_Previs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Previs.Location = New System.Drawing.Point(338, 63)
        Me.b_Previs.Name = "b_Previs"
        Me.b_Previs.Size = New System.Drawing.Size(116, 23)
        Me.b_Previs.TabIndex = 1004
        Me.b_Previs.Text = "Prévisualisation..."
        Me.ToolTip2.SetToolTip(Me.b_Previs, "Prévisualiser le résultat avec les contours d'une vraie carte de dresseur")
        Me.b_Previs.UseVisualStyleBackColor = True
        '
        'b_Import
        '
        Me.b_Import.Location = New System.Drawing.Point(125, 14)
        Me.b_Import.Name = "b_Import"
        Me.b_Import.Size = New System.Drawing.Size(148, 23)
        Me.b_Import.TabIndex = 1014
        Me.b_Import.Text = "↓  Importer l'image  ↓"
        Me.ToolTip2.SetToolTip(Me.b_Import, "Recopier l'image ouverte au-dessus dans la boîte ci-dessous." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La sauvegarde ne se" & _
                "ra pas modifiée tant que vous n'aurez pas utilisé le bouton ""Enregistrer"".")
        Me.b_Import.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox2.Location = New System.Drawing.Point(101, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1013
        Me.PictureBox2.TabStop = False
        Me.ToolTip2.SetToolTip(Me.PictureBox2, resources.GetString("PictureBox2.ToolTip"))
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrerLimageSousToolStripMenuItem, Me.ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(385, 48)
        '
        'EnregistrerLimageSousToolStripMenuItem
        '
        Me.EnregistrerLimageSousToolStripMenuItem.Name = "EnregistrerLimageSousToolStripMenuItem"
        Me.EnregistrerLimageSousToolStripMenuItem.Size = New System.Drawing.Size(384, 22)
        Me.EnregistrerLimageSousToolStripMenuItem.Text = "Enregistrer l'image sous..."
        '
        'ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem
        '
        Me.ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem.Name = "ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem"
        Me.ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem.Size = New System.Drawing.Size(384, 22)
        Me.ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem.Text = "Charger l'image dans la partie du haut pour en faire un code AR"
        '
        'b_Sauver
        '
        Me.b_Sauver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Sauver.Location = New System.Drawing.Point(101, 129)
        Me.b_Sauver.Name = "b_Sauver"
        Me.b_Sauver.Size = New System.Drawing.Size(194, 23)
        Me.b_Sauver.TabIndex = 1015
        Me.b_Sauver.Text = "Enregistrer les modifications"
        Me.ToolTip2.SetToolTip(Me.b_Sauver, "Enregistrer la sauvegarde avec la nouvelle signature")
        Me.b_Sauver.UseVisualStyleBackColor = True
        '
        'b_OuvrirSav
        '
        Me.b_OuvrirSav.Location = New System.Drawing.Point(6, 6)
        Me.b_OuvrirSav.Name = "b_OuvrirSav"
        Me.b_OuvrirSav.Size = New System.Drawing.Size(89, 38)
        Me.b_OuvrirSav.TabIndex = 1012
        Me.b_OuvrirSav.Text = "Ouvrir une sauvegarde"
        Me.ToolTip2.SetToolTip(Me.b_OuvrirSav, "Sélectionner la sauvegarde à modifier.")
        Me.b_OuvrirSav.UseVisualStyleBackColor = True
        '
        'b_Recharger
        '
        Me.b_Recharger.Location = New System.Drawing.Point(357, 6)
        Me.b_Recharger.Name = "b_Recharger"
        Me.b_Recharger.Size = New System.Drawing.Size(89, 38)
        Me.b_Recharger.TabIndex = 1016
        Me.b_Recharger.Text = "Recharger la sauvegarde"
        Me.ToolTip2.SetToolTip(Me.b_Recharger, "Recharger la signature de la sauvegarde pour annuler les modifications.")
        Me.b_Recharger.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(12, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 361)
        Me.TabControl1.TabIndex = 1005
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.b_Copier1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.b_Activ)
        Me.TabPage1.Controls.Add(Me.b_Copier2)
        Me.TabPage1.Controls.Add(Me.b_Generer)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(452, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Générateur de code AR"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.b_Import)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.b_Sauver)
        Me.TabPage2.Controls.Add(Me.b_OuvrirSav)
        Me.TabPage2.Controls.Add(Me.b_Recharger)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(452, 335)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modificateur de sauvegarde"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_Taille)
        Me.GroupBox2.Controls.Add(Me.lbl_Bloc_Courant)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cb_NoGBA)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 113)
        Me.GroupBox2.TabIndex = 1017
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Infos sur la sauvegarde"
        '
        'lbl_Taille
        '
        Me.lbl_Taille.AutoSize = True
        Me.lbl_Taille.Location = New System.Drawing.Point(121, 38)
        Me.lbl_Taille.Name = "lbl_Taille"
        Me.lbl_Taille.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Taille.TabIndex = 2003
        Me.lbl_Taille.Text = "Taille :"
        '
        'lbl_Bloc_Courant
        '
        Me.lbl_Bloc_Courant.AutoSize = True
        Me.lbl_Bloc_Courant.Location = New System.Drawing.Point(121, 61)
        Me.lbl_Bloc_Courant.Name = "lbl_Bloc_Courant"
        Me.lbl_Bloc_Courant.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Bloc_Courant.TabIndex = 2002
        Me.lbl_Bloc_Courant.Text = "Bloc courant :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_HGSS_sav)
        Me.GroupBox3.Controls.Add(Me.rb_DP_sav)
        Me.GroupBox3.Controls.Add(Me.rb_Plat_sav)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 88)
        Me.GroupBox3.TabIndex = 3000
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Version"
        '
        'rb_HGSS_sav
        '
        Me.rb_HGSS_sav.AutoSize = True
        Me.rb_HGSS_sav.Enabled = False
        Me.rb_HGSS_sav.Location = New System.Drawing.Point(6, 65)
        Me.rb_HGSS_sav.Name = "rb_HGSS_sav"
        Me.rb_HGSS_sav.Size = New System.Drawing.Size(60, 17)
        Me.rb_HGSS_sav.TabIndex = 2300
        Me.rb_HGSS_sav.TabStop = True
        Me.rb_HGSS_sav.Tag = "&H4538"
        Me.rb_HGSS_sav.Text = "HG/SS"
        Me.rb_HGSS_sav.UseVisualStyleBackColor = True
        '
        'rb_DP_sav
        '
        Me.rb_DP_sav.AutoSize = True
        Me.rb_DP_sav.Enabled = False
        Me.rb_DP_sav.Location = New System.Drawing.Point(6, 19)
        Me.rb_DP_sav.Name = "rb_DP_sav"
        Me.rb_DP_sav.Size = New System.Drawing.Size(93, 17)
        Me.rb_DP_sav.TabIndex = 2100
        Me.rb_DP_sav.Tag = "&H5904"
        Me.rb_DP_sav.Text = "Diamant/Perle"
        Me.rb_DP_sav.UseVisualStyleBackColor = True
        '
        'rb_Plat_sav
        '
        Me.rb_Plat_sav.AutoSize = True
        Me.rb_Plat_sav.Enabled = False
        Me.rb_Plat_sav.Location = New System.Drawing.Point(6, 42)
        Me.rb_Plat_sav.Name = "rb_Plat_sav"
        Me.rb_Plat_sav.Size = New System.Drawing.Size(57, 17)
        Me.rb_Plat_sav.TabIndex = 2200
        Me.rb_Plat_sav.Tag = "&H5BA8"
        Me.rb_Plat_sav.Text = "Platine"
        Me.rb_Plat_sav.UseVisualStyleBackColor = True
        '
        'cb_NoGBA
        '
        Me.cb_NoGBA.AutoSize = True
        Me.cb_NoGBA.Enabled = False
        Me.cb_NoGBA.Location = New System.Drawing.Point(121, 90)
        Me.cb_NoGBA.Name = "cb_NoGBA"
        Me.cb_NoGBA.Size = New System.Drawing.Size(68, 17)
        Me.cb_NoGBA.TabIndex = 2001
        Me.cb_NoGBA.Text = "No$GBA"
        Me.cb_NoGBA.UseVisualStyleBackColor = True
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.DefaultExt = "sav"
        Me.SaveFileDialog2.Filter = "Sauvegardes NDS|*.sav|Tous les fichiers|*.*"
        Me.SaveFileDialog2.Title = "Enregistrer la sauvegarde sous..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "png"
        Me.SaveFileDialog1.FileName = "signature.png"
        Me.SaveFileDialog1.Filter = "Images PNG|*.png|Images GIF|*.gif|Images BMP|*.bmp|Tous les fichiers|*.*"
        Me.SaveFileDialog1.InitialDirectory = "."
        Me.SaveFileDialog1.Title = "Sauver l'image sous..."
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.DefaultExt = "sav"
        Me.OpenFileDialog2.Filter = "Sauvegardes NDS|*.sav"
        Me.OpenFileDialog2.SupportMultiDottedExtensions = True
        Me.OpenFileDialog2.Title = "Ouvrir une sauvegarde..."
        '
        'Form1
        '
        Me.AcceptButton = Me.b_Ouvrir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 494)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.b_Previs)
        Me.Controls.Add(Me.b_About)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.b_Ouvrir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 530)
        Me.Name = "Form1"
        Me.Text = "Pokémon Signature Editor - par M@T"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_Generer As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents b_Copier1 As System.Windows.Forms.Button
    Friend WithEvents b_Ouvrir As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents b_Copier2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents b_Activ As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents b_About As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Plat As System.Windows.Forms.RadioButton
    Friend WithEvents rb_DP As System.Windows.Forms.RadioButton
    Friend WithEvents b_Previs As System.Windows.Forms.Button
    Friend WithEvents rb_HGSS As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents b_Import As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents b_Sauver As System.Windows.Forms.Button
    Friend WithEvents b_OuvrirSav As System.Windows.Forms.Button
    Friend WithEvents b_Recharger As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Taille As System.Windows.Forms.Label
    Friend WithEvents lbl_Bloc_Courant As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_HGSS_sav As System.Windows.Forms.RadioButton
    Friend WithEvents rb_DP_sav As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Plat_sav As System.Windows.Forms.RadioButton
    Friend WithEvents cb_NoGBA As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EnregistrerLimageSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
