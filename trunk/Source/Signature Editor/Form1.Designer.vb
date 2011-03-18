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
        Me.b_GenerateAR = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.b_Copy1 = New System.Windows.Forms.Button
        Me.b_OpenImage = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.lbl_Sensib = New System.Windows.Forms.Label
        Me.cb_SplitCode = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.b_Copy2 = New System.Windows.Forms.Button
        Me.lbl_1stPart = New System.Windows.Forms.Label
        Me.lbl_2ndPart = New System.Windows.Forms.Label
        Me.b_Activ = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.b_About = New System.Windows.Forms.Button
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_Version = New System.Windows.Forms.ComboBox
        Me.b_Preview = New System.Windows.Forms.Button
        Me.b_ImportImage = New System.Windows.Forms.Button
        Me.b_SaveAs = New System.Windows.Forms.Button
        Me.b_OpenSave = New System.Windows.Forms.Button
        Me.b_ReloadSave = New System.Windows.Forms.Button
        Me.cmb_Language = New System.Windows.Forms.ComboBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_SaveImageAs = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmi_LoadImageAbove = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lbl_FilePath = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Size = New System.Windows.Forms.Label
        Me.lbl_CurrentBlock = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_BW_sav = New System.Windows.Forms.RadioButton
        Me.rb_HGSS_sav = New System.Windows.Forms.RadioButton
        Me.rb_DP_sav = New System.Windows.Forms.RadioButton
        Me.rb_Plat_sav = New System.Windows.Forms.RadioButton
        Me.cb_NoGBA = New System.Windows.Forms.CheckBox
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_GenerateAR
        '
        Me.b_GenerateAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_GenerateAR.Location = New System.Drawing.Point(6, 6)
        Me.b_GenerateAR.Name = "b_GenerateAR"
        Me.b_GenerateAR.Size = New System.Drawing.Size(114, 23)
        Me.b_GenerateAR.TabIndex = 70
        Me.b_GenerateAR.Text = "Générer le code !"
        Me.ToolTip2.SetToolTip(Me.b_GenerateAR, "Générer le code Action Replay à partir de l'image monochrome choisie.")
        Me.b_GenerateAR.UseVisualStyleBackColor = True
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
        Me.TextBox1.TabIndex = 75
        '
        'b_Copy1
        '
        Me.b_Copy1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.b_Copy1.Location = New System.Drawing.Point(6, 306)
        Me.b_Copy1.Name = "b_Copy1"
        Me.b_Copy1.Size = New System.Drawing.Size(149, 23)
        Me.b_Copy1.TabIndex = 80
        Me.b_Copy1.Text = "Copier la première partie"
        Me.ToolTip2.SetToolTip(Me.b_Copy1, "Copier la première partie du code dans le presse-papiers.")
        Me.b_Copy1.UseVisualStyleBackColor = True
        '
        'b_OpenImage
        '
        Me.b_OpenImage.Location = New System.Drawing.Point(12, 12)
        Me.b_OpenImage.Name = "b_OpenImage"
        Me.b_OpenImage.Size = New System.Drawing.Size(99, 23)
        Me.b_OpenImage.TabIndex = 0
        Me.b_OpenImage.Text = "Ouvrir une image"
        Me.ToolTip2.SetToolTip(Me.b_OpenImage, "Choisir une image à convertir en signature." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L'image doit mesurer exactement 192x" & _
                "64 pixels." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elle sera automatiquement convertie en monochrome.")
        Me.b_OpenImage.UseVisualStyleBackColor = True
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
        Me.TrackBar1.Size = New System.Drawing.Size(194, 45)
        Me.TrackBar1.TabIndex = 10
        Me.TrackBar1.TickFrequency = 10
        Me.ToolTip2.SetToolTip(Me.TrackBar1, "Ajuster la sensibilité pour la conversion en noir et blanc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plus la sensibilité " & _
                "est élevée, plus l'image sera sombre.")
        Me.TrackBar1.Value = 50
        '
        'lbl_Sensib
        '
        Me.lbl_Sensib.AutoSize = True
        Me.lbl_Sensib.Location = New System.Drawing.Point(433, 44)
        Me.lbl_Sensib.Name = "lbl_Sensib"
        Me.lbl_Sensib.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Sensib.TabIndex = 11
        Me.lbl_Sensib.Text = "Sensibilité : 0,5"
        '
        'cb_SplitCode
        '
        Me.cb_SplitCode.AutoSize = True
        Me.cb_SplitCode.Location = New System.Drawing.Point(348, 229)
        Me.cb_SplitCode.Name = "cb_SplitCode"
        Me.cb_SplitCode.Size = New System.Drawing.Size(139, 30)
        Me.cb_SplitCode.TabIndex = 50
        Me.cb_SplitCode.Text = "Couper le code en deux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(No$GBA)"
        Me.ToolTip2.SetToolTip(Me.cb_SplitCode, "Diviser le code en deux parties plus courtes afin de pouvoir le mettre sur un ému" & _
                "lateur comme No$GBA." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Entrez chaque partie comme un code distinct.")
        Me.cb_SplitCode.UseVisualStyleBackColor = True
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
        Me.TextBox2.TabIndex = 85
        '
        'b_Copy2
        '
        Me.b_Copy2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.b_Copy2.Enabled = False
        Me.b_Copy2.Location = New System.Drawing.Point(177, 306)
        Me.b_Copy2.Name = "b_Copy2"
        Me.b_Copy2.Size = New System.Drawing.Size(149, 23)
        Me.b_Copy2.TabIndex = 90
        Me.b_Copy2.Text = "Copier la deuxième partie"
        Me.ToolTip2.SetToolTip(Me.b_Copy2, "Copier la seconde partie du code dans le presse-papiers.")
        Me.b_Copy2.UseVisualStyleBackColor = True
        '
        'lbl_1stPart
        '
        Me.lbl_1stPart.AutoSize = True
        Me.lbl_1stPart.Location = New System.Drawing.Point(6, 32)
        Me.lbl_1stPart.Name = "lbl_1stPart"
        Me.lbl_1stPart.Size = New System.Drawing.Size(125, 13)
        Me.lbl_1stPart.TabIndex = 1001
        Me.lbl_1stPart.Text = "Première partie du code :"
        '
        'lbl_2ndPart
        '
        Me.lbl_2ndPart.AutoSize = True
        Me.lbl_2ndPart.Enabled = False
        Me.lbl_2ndPart.Location = New System.Drawing.Point(174, 32)
        Me.lbl_2ndPart.Name = "lbl_2ndPart"
        Me.lbl_2ndPart.Size = New System.Drawing.Size(89, 13)
        Me.lbl_2ndPart.TabIndex = 1002
        Me.lbl_2ndPart.Text = "Deuxième partie :"
        '
        'b_Activ
        '
        Me.b_Activ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Activ.Location = New System.Drawing.Point(370, 6)
        Me.b_Activ.Name = "b_Activ"
        Me.b_Activ.Size = New System.Drawing.Size(98, 23)
        Me.b_Activ.TabIndex = 60
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
        Me.b_About.Location = New System.Drawing.Point(436, 459)
        Me.b_About.Name = "b_About"
        Me.b_About.Size = New System.Drawing.Size(75, 23)
        Me.b_About.TabIndex = 10000
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
        Me.GroupBox1.Controls.Add(Me.cmb_Version)
        Me.GroupBox1.Location = New System.Drawing.Point(348, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 46)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Version"
        Me.ToolTip2.SetToolTip(Me.GroupBox1, "Choisissez votre version de Pokémon...")
        '
        'cmb_Version
        '
        Me.cmb_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Version.FormattingEnabled = True
        Me.cmb_Version.Items.AddRange(New Object() {"Diamant/Perle", "Platine", "HeartGold/SoulSilver", "Noire/Blanche"})
        Me.cmb_Version.Location = New System.Drawing.Point(6, 19)
        Me.cmb_Version.Name = "cmb_Version"
        Me.cmb_Version.Size = New System.Drawing.Size(125, 21)
        Me.cmb_Version.TabIndex = 30
        Me.ToolTip2.SetToolTip(Me.cmb_Version, "La version du jeu pour laquelle le code AR sera généré.")
        '
        'b_Preview
        '
        Me.b_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Preview.Location = New System.Drawing.Point(368, 63)
        Me.b_Preview.Name = "b_Preview"
        Me.b_Preview.Size = New System.Drawing.Size(116, 23)
        Me.b_Preview.TabIndex = 15
        Me.b_Preview.Text = "Prévisualisation..."
        Me.ToolTip2.SetToolTip(Me.b_Preview, "Prévisualiser le résultat avec les contours d'une vraie carte de dresseur")
        Me.b_Preview.UseVisualStyleBackColor = True
        '
        'b_ImportImage
        '
        Me.b_ImportImage.Location = New System.Drawing.Point(125, 14)
        Me.b_ImportImage.Name = "b_ImportImage"
        Me.b_ImportImage.Size = New System.Drawing.Size(148, 23)
        Me.b_ImportImage.TabIndex = 40
        Me.b_ImportImage.Text = "v  Importer l'image  v"
        Me.ToolTip2.SetToolTip(Me.b_ImportImage, "Recopier l'image ouverte au-dessus dans la boîte ci-dessous." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La sauvegarde ne se" & _
                "ra pas modifiée tant que vous n'aurez pas utilisé le bouton ""Enregistrer"".")
        Me.b_ImportImage.UseVisualStyleBackColor = True
        '
        'b_SaveAs
        '
        Me.b_SaveAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_SaveAs.Location = New System.Drawing.Point(101, 129)
        Me.b_SaveAs.Name = "b_SaveAs"
        Me.b_SaveAs.Size = New System.Drawing.Size(194, 23)
        Me.b_SaveAs.TabIndex = 50
        Me.b_SaveAs.Text = "Enregistrer sous..."
        Me.ToolTip2.SetToolTip(Me.b_SaveAs, "Enregistrer la sauvegarde avec la nouvelle signature")
        Me.b_SaveAs.UseVisualStyleBackColor = True
        '
        'b_OpenSave
        '
        Me.b_OpenSave.Location = New System.Drawing.Point(6, 6)
        Me.b_OpenSave.Name = "b_OpenSave"
        Me.b_OpenSave.Size = New System.Drawing.Size(89, 38)
        Me.b_OpenSave.TabIndex = 30
        Me.b_OpenSave.Text = "Ouvrir une sauvegarde..."
        Me.ToolTip2.SetToolTip(Me.b_OpenSave, "Sélectionner la sauvegarde à modifier.")
        Me.b_OpenSave.UseVisualStyleBackColor = True
        '
        'b_ReloadSave
        '
        Me.b_ReloadSave.Location = New System.Drawing.Point(374, 6)
        Me.b_ReloadSave.Name = "b_ReloadSave"
        Me.b_ReloadSave.Size = New System.Drawing.Size(89, 38)
        Me.b_ReloadSave.TabIndex = 60
        Me.b_ReloadSave.Text = "Recharger la sauvegarde"
        Me.ToolTip2.SetToolTip(Me.b_ReloadSave, "Recharger la signature de la sauvegarde pour annuler les modifications.")
        Me.b_ReloadSave.UseVisualStyleBackColor = True
        '
        'cmb_Language
        '
        Me.cmb_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Language.FormattingEnabled = True
        Me.cmb_Language.Items.AddRange(New Object() {"Français", "English/USA/AUS", "日本語 (Japanese)", "Español", "Italiano", "Deutch", "한국인 (Korean)"})
        Me.cmb_Language.Location = New System.Drawing.Point(6, 19)
        Me.cmb_Language.Name = "cmb_Language"
        Me.cmb_Language.Size = New System.Drawing.Size(125, 21)
        Me.cmb_Language.TabIndex = 40
        Me.ToolTip2.SetToolTip(Me.cmb_Language, "La langue du jeu pour laquelle le code AR sera généré.")
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_SaveImageAs, Me.tsmi_LoadImageAbove})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(385, 48)
        '
        'tsmi_SaveImageAs
        '
        Me.tsmi_SaveImageAs.Name = "tsmi_SaveImageAs"
        Me.tsmi_SaveImageAs.Size = New System.Drawing.Size(384, 22)
        Me.tsmi_SaveImageAs.Text = "Enregistrer l'image sous..."
        '
        'tsmi_LoadImageAbove
        '
        Me.tsmi_LoadImageAbove.Name = "tsmi_LoadImageAbove"
        Me.tsmi_LoadImageAbove.Size = New System.Drawing.Size(384, 22)
        Me.tsmi_LoadImageAbove.Text = "Charger l'image dans la partie du haut pour en faire un code AR"
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(12, 92)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(499, 361)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.b_Copy1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.cb_SplitCode)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.b_Activ)
        Me.TabPage1.Controls.Add(Me.b_Copy2)
        Me.TabPage1.Controls.Add(Me.b_GenerateAR)
        Me.TabPage1.Controls.Add(Me.lbl_2ndPart)
        Me.TabPage1.Controls.Add(Me.lbl_1stPart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(491, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Générateur de code AR"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmb_Language)
        Me.GroupBox4.Location = New System.Drawing.Point(348, 154)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(137, 46)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Langue"
        '
        'TabPage2
        '
        Me.TabPage2.AllowDrop = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.lbl_FilePath)
        Me.TabPage2.Controls.Add(Me.b_ImportImage)
        Me.TabPage2.Controls.Add(Me.b_SaveAs)
        Me.TabPage2.Controls.Add(Me.b_OpenSave)
        Me.TabPage2.Controls.Add(Me.b_ReloadSave)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(491, 335)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modificateur de sauvegarde"
        '
        'lbl_FilePath
        '
        Me.lbl_FilePath.AutoSize = True
        Me.lbl_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FilePath.Location = New System.Drawing.Point(6, 166)
        Me.lbl_FilePath.Name = "lbl_FilePath"
        Me.lbl_FilePath.Size = New System.Drawing.Size(110, 13)
        Me.lbl_FilePath.TabIndex = 2001
        Me.lbl_FilePath.Text = "(aucun fichier chargé)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_Size)
        Me.GroupBox2.Controls.Add(Me.lbl_CurrentBlock)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cb_NoGBA)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 136)
        Me.GroupBox2.TabIndex = 2000
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Infos sur la sauvegarde"
        '
        'lbl_Size
        '
        Me.lbl_Size.AutoSize = True
        Me.lbl_Size.Location = New System.Drawing.Point(121, 38)
        Me.lbl_Size.Name = "lbl_Size"
        Me.lbl_Size.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Size.TabIndex = 2010
        Me.lbl_Size.Text = "Taille :"
        '
        'lbl_CurrentBlock
        '
        Me.lbl_CurrentBlock.AutoSize = True
        Me.lbl_CurrentBlock.Location = New System.Drawing.Point(121, 61)
        Me.lbl_CurrentBlock.Name = "lbl_CurrentBlock"
        Me.lbl_CurrentBlock.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CurrentBlock.TabIndex = 2020
        Me.lbl_CurrentBlock.Text = "Bloc courant :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_BW_sav)
        Me.GroupBox3.Controls.Add(Me.rb_HGSS_sav)
        Me.GroupBox3.Controls.Add(Me.rb_DP_sav)
        Me.GroupBox3.Controls.Add(Me.rb_Plat_sav)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 111)
        Me.GroupBox3.TabIndex = 3000
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Version"
        '
        'rb_BW_sav
        '
        Me.rb_BW_sav.AutoSize = True
        Me.rb_BW_sav.Enabled = False
        Me.rb_BW_sav.Location = New System.Drawing.Point(6, 88)
        Me.rb_BW_sav.Name = "rb_BW_sav"
        Me.rb_BW_sav.Size = New System.Drawing.Size(94, 17)
        Me.rb_BW_sav.TabIndex = 2301
        Me.rb_BW_sav.TabStop = True
        Me.rb_BW_sav.Text = "Noire/Blanche"
        Me.rb_BW_sav.UseVisualStyleBackColor = True
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
        Me.cb_NoGBA.TabIndex = 2400
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
        Me.OpenFileDialog2.Filter = "Sauvegardes NDS|*.sav; *.dsv|Tous les fichiers|*.*"
        Me.OpenFileDialog2.SupportMultiDottedExtensions = True
        Me.OpenFileDialog2.Title = "Ouvrir une sauvegarde..."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Signature_Editor.My.Resources.Resources.Zuruggu_Anim
        Me.PictureBox3.Location = New System.Drawing.Point(412, 164)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 42)
        Me.PictureBox3.TabIndex = 1003
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.b_OpenImage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 496)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.b_OpenImage)
        Me.Controls.Add(Me.b_About)
        Me.Controls.Add(Me.b_Preview)
        Me.Controls.Add(Me.lbl_Sensib)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(539, 532)
        Me.Name = "Form1"
        Me.Text = "Pokémon Signature Editor - by M@T"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_GenerateAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents b_Copy1 As System.Windows.Forms.Button
    Friend WithEvents b_OpenImage As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents lbl_Sensib As System.Windows.Forms.Label
    Friend WithEvents cb_SplitCode As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents b_Copy2 As System.Windows.Forms.Button
    Friend WithEvents lbl_1stPart As System.Windows.Forms.Label
    Friend WithEvents lbl_2ndPart As System.Windows.Forms.Label
    Friend WithEvents b_Activ As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents b_About As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents b_Preview As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents b_ImportImage As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents b_SaveAs As System.Windows.Forms.Button
    Friend WithEvents b_OpenSave As System.Windows.Forms.Button
    Friend WithEvents b_ReloadSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Size As System.Windows.Forms.Label
    Friend WithEvents lbl_CurrentBlock As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_HGSS_sav As System.Windows.Forms.RadioButton
    Friend WithEvents rb_DP_sav As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Plat_sav As System.Windows.Forms.RadioButton
    Friend WithEvents cb_NoGBA As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmi_SaveImageAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tsmi_LoadImageAbove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_Version As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Language As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_BW_sav As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_FilePath As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
