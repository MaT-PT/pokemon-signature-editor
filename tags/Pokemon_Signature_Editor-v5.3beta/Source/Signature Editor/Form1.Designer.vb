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
        Me.ofd_OpenImage = New System.Windows.Forms.OpenFileDialog
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.lbl_Sensitivity = New System.Windows.Forms.Label
        Me.cb_SplitCode = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.b_Copy2 = New System.Windows.Forms.Button
        Me.lbl_1stPart = New System.Windows.Forms.Label
        Me.lbl_2ndPart = New System.Windows.Forms.Label
        Me.b_Activators = New System.Windows.Forms.Button
        Me.tt_Activators = New System.Windows.Forms.ToolTip(Me.components)
        Me.b_About = New System.Windows.Forms.Button
        Me.tt_Common = New System.Windows.Forms.ToolTip(Me.components)
        Me.gb_CodeVersion = New System.Windows.Forms.GroupBox
        Me.cmb_Version = New System.Windows.Forms.ComboBox
        Me.b_Preview = New System.Windows.Forms.Button
        Me.b_ImportImage = New System.Windows.Forms.Button
        Me.b_SaveAs = New System.Windows.Forms.Button
        Me.b_OpenSave = New System.Windows.Forms.Button
        Me.b_ReloadSave = New System.Windows.Forms.Button
        Me.cmb_Language = New System.Windows.Forms.ComboBox
        Me.pb_SavefileSignatureImage = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_SaveImageAs = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmi_LoadImageAbove = New System.Windows.Forms.ToolStripMenuItem
        Me.pb_CodeSignatureImage = New System.Windows.Forms.PictureBox
        Me.tc_Main = New System.Windows.Forms.TabControl
        Me.tp_CodeGenerator = New System.Windows.Forms.TabPage
        Me.gb_CodeLanguage = New System.Windows.Forms.GroupBox
        Me.tp_SaveEditor = New System.Windows.Forms.TabPage
        Me.lbl_FilePath = New System.Windows.Forms.Label
        Me.gb_SaveInfos = New System.Windows.Forms.GroupBox
        Me.lbl_Size = New System.Windows.Forms.Label
        Me.lbl_CurrentBlock = New System.Windows.Forms.Label
        Me.gb_SaveVersions = New System.Windows.Forms.GroupBox
        Me.rb_BW_sav = New System.Windows.Forms.RadioButton
        Me.rb_HGSS_sav = New System.Windows.Forms.RadioButton
        Me.rb_DP_sav = New System.Windows.Forms.RadioButton
        Me.rb_Plat_sav = New System.Windows.Forms.RadioButton
        Me.cb_NoGBA = New System.Windows.Forms.CheckBox
        Me.sfd_SaveSavefileAs = New System.Windows.Forms.SaveFileDialog
        Me.sfd_SaveImageAs = New System.Windows.Forms.SaveFileDialog
        Me.ofd_OpenSavefile = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.gb_ProgramLanguage = New System.Windows.Forms.GroupBox
        Me.cmb_ProgramLanguage = New System.Windows.Forms.ComboBox
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_CodeVersion.SuspendLayout()
        CType(Me.pb_SavefileSignatureImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pb_CodeSignatureImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Main.SuspendLayout()
        Me.tp_CodeGenerator.SuspendLayout()
        Me.gb_CodeLanguage.SuspendLayout()
        Me.tp_SaveEditor.SuspendLayout()
        Me.gb_SaveInfos.SuspendLayout()
        Me.gb_SaveVersions.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_ProgramLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_GenerateAR
        '
        Me.b_GenerateAR.AutoSize = True
        Me.b_GenerateAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_GenerateAR.Location = New System.Drawing.Point(6, 6)
        Me.b_GenerateAR.Name = "b_GenerateAR"
        Me.b_GenerateAR.Size = New System.Drawing.Size(116, 23)
        Me.b_GenerateAR.TabIndex = 70
        Me.b_GenerateAR.Text = "Générer le code !"
        Me.tt_Common.SetToolTip(Me.b_GenerateAR, "Générer le code Action Replay à partir de l'image monochrome choisie.")
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
        Me.tt_Common.SetToolTip(Me.b_Copy1, "Copier la première partie du code dans le presse-papiers.")
        Me.b_Copy1.UseVisualStyleBackColor = True
        '
        'b_OpenImage
        '
        Me.b_OpenImage.Location = New System.Drawing.Point(12, 12)
        Me.b_OpenImage.Name = "b_OpenImage"
        Me.b_OpenImage.Size = New System.Drawing.Size(99, 23)
        Me.b_OpenImage.TabIndex = 0
        Me.b_OpenImage.Text = "Ouvrir une image"
        Me.tt_Common.SetToolTip(Me.b_OpenImage, "Choisir une image à convertir en signature." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L'image doit mesurer exactement 192x" & _
                "64 pixels." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elle sera automatiquement convertie en monochrome.")
        Me.b_OpenImage.UseVisualStyleBackColor = True
        '
        'ofd_OpenImage
        '
        Me.ofd_OpenImage.DefaultExt = "bmp"
        Me.ofd_OpenImage.Filter = "Fichiers images|*.bmp; *.png; *.gif; *.jpg; *.jpeg; *.wmf|Tous les fichiers|*.*"
        Me.ofd_OpenImage.SupportMultiDottedExtensions = True
        Me.ofd_OpenImage.Title = "Sélectionnez une image..."
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
        Me.tt_Common.SetToolTip(Me.TrackBar1, "Ajuster la sensibilité pour la conversion en noir et blanc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plus la sensibilité " & _
                "est élevée, plus l'image sera sombre.")
        Me.TrackBar1.Value = 50
        '
        'lbl_Sensitivity
        '
        Me.lbl_Sensitivity.AutoSize = True
        Me.lbl_Sensitivity.Location = New System.Drawing.Point(427, 44)
        Me.lbl_Sensitivity.Name = "lbl_Sensitivity"
        Me.lbl_Sensitivity.Size = New System.Drawing.Size(60, 13)
        Me.lbl_Sensitivity.TabIndex = 11
        Me.lbl_Sensitivity.Text = "Sensibilité :"
        '
        'cb_SplitCode
        '
        Me.cb_SplitCode.AutoSize = True
        Me.cb_SplitCode.Location = New System.Drawing.Point(348, 229)
        Me.cb_SplitCode.Name = "cb_SplitCode"
        Me.cb_SplitCode.Size = New System.Drawing.Size(139, 30)
        Me.cb_SplitCode.TabIndex = 50
        Me.cb_SplitCode.Text = "Couper le code en deux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(No$GBA)"
        Me.tt_Common.SetToolTip(Me.cb_SplitCode, "Diviser le code en deux parties plus courtes afin de pouvoir le mettre sur un ému" & _
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
        Me.tt_Common.SetToolTip(Me.b_Copy2, "Copier la seconde partie du code dans le presse-papiers.")
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
        'b_Activators
        '
        Me.b_Activators.AutoSize = True
        Me.b_Activators.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Activators.Location = New System.Drawing.Point(368, 6)
        Me.b_Activators.Name = "b_Activators"
        Me.b_Activators.Size = New System.Drawing.Size(98, 23)
        Me.b_Activators.TabIndex = 60
        Me.b_Activators.Text = "Activateurs..."
        Me.tt_Activators.SetToolTip(Me.b_Activators, "L+R")
        Me.b_Activators.UseVisualStyleBackColor = True
        '
        'tt_Activators
        '
        Me.tt_Activators.ToolTipTitle = "Touches à presser :"
        '
        'b_About
        '
        Me.b_About.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_About.Location = New System.Drawing.Point(436, 469)
        Me.b_About.Name = "b_About"
        Me.b_About.Size = New System.Drawing.Size(75, 23)
        Me.b_About.TabIndex = 10000
        Me.b_About.Text = "À propos..."
        Me.tt_Common.SetToolTip(Me.b_About, "À propos du générateur de signature...")
        Me.b_About.UseVisualStyleBackColor = True
        '
        'tt_Common
        '
        Me.tt_Common.AutoPopDelay = 10000
        Me.tt_Common.InitialDelay = 500
        Me.tt_Common.ReshowDelay = 100
        '
        'gb_CodeVersion
        '
        Me.gb_CodeVersion.Controls.Add(Me.cmb_Version)
        Me.gb_CodeVersion.Location = New System.Drawing.Point(348, 102)
        Me.gb_CodeVersion.Name = "gb_CodeVersion"
        Me.gb_CodeVersion.Size = New System.Drawing.Size(137, 46)
        Me.gb_CodeVersion.TabIndex = 30
        Me.gb_CodeVersion.TabStop = False
        Me.gb_CodeVersion.Text = "Version"
        Me.tt_Common.SetToolTip(Me.gb_CodeVersion, "Choisissez votre version de Pokémon...")
        '
        'cmb_Version
        '
        Me.cmb_Version.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Version.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Version.FormattingEnabled = True
        Me.cmb_Version.Items.AddRange(New Object() {"Diamant/Perle", "Platine", "HeartGold/SoulSilver", "Noire/Blanche"})
        Me.cmb_Version.Location = New System.Drawing.Point(6, 19)
        Me.cmb_Version.Name = "cmb_Version"
        Me.cmb_Version.Size = New System.Drawing.Size(125, 21)
        Me.cmb_Version.TabIndex = 30
        Me.tt_Common.SetToolTip(Me.cmb_Version, "La version du jeu pour laquelle le code AR sera généré.")
        '
        'b_Preview
        '
        Me.b_Preview.AutoSize = True
        Me.b_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Preview.Location = New System.Drawing.Point(355, 63)
        Me.b_Preview.Name = "b_Preview"
        Me.b_Preview.Size = New System.Drawing.Size(118, 23)
        Me.b_Preview.TabIndex = 15
        Me.b_Preview.Text = "Prévisualisation..."
        Me.tt_Common.SetToolTip(Me.b_Preview, "Prévisualiser le résultat avec les contours d'une vraie carte de dresseur")
        Me.b_Preview.UseVisualStyleBackColor = True
        '
        'b_ImportImage
        '
        Me.b_ImportImage.AutoSize = True
        Me.b_ImportImage.Location = New System.Drawing.Point(125, 14)
        Me.b_ImportImage.Name = "b_ImportImage"
        Me.b_ImportImage.Size = New System.Drawing.Size(148, 23)
        Me.b_ImportImage.TabIndex = 40
        Me.b_ImportImage.Text = "v  Importer l'image  v"
        Me.tt_Common.SetToolTip(Me.b_ImportImage, "Recopier l'image ouverte au-dessus dans la boîte ci-dessous." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La sauvegarde ne se" & _
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
        Me.tt_Common.SetToolTip(Me.b_SaveAs, "Enregistrer la sauvegarde avec la nouvelle signature")
        Me.b_SaveAs.UseVisualStyleBackColor = True
        '
        'b_OpenSave
        '
        Me.b_OpenSave.AutoSize = True
        Me.b_OpenSave.Location = New System.Drawing.Point(6, 6)
        Me.b_OpenSave.Name = "b_OpenSave"
        Me.b_OpenSave.Size = New System.Drawing.Size(89, 38)
        Me.b_OpenSave.TabIndex = 30
        Me.b_OpenSave.Text = "Ouvrir une" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sauvegarde..."
        Me.tt_Common.SetToolTip(Me.b_OpenSave, "Sélectionner la sauvegarde à modifier.")
        Me.b_OpenSave.UseVisualStyleBackColor = True
        '
        'b_ReloadSave
        '
        Me.b_ReloadSave.AutoSize = True
        Me.b_ReloadSave.Location = New System.Drawing.Point(376, 6)
        Me.b_ReloadSave.Name = "b_ReloadSave"
        Me.b_ReloadSave.Size = New System.Drawing.Size(82, 38)
        Me.b_ReloadSave.TabIndex = 60
        Me.b_ReloadSave.Text = "Recharger la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sauvegarde"
        Me.tt_Common.SetToolTip(Me.b_ReloadSave, "Recharger la signature de la sauvegarde pour annuler les modifications.")
        Me.b_ReloadSave.UseVisualStyleBackColor = True
        '
        'cmb_Language
        '
        Me.cmb_Language.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Language.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Language.FormattingEnabled = True
        Me.cmb_Language.Items.AddRange(New Object() {"Français", "English/USA/AUS", "日本語 (Japanese)", "Español", "Italiano", "Deutch", "한국인 (Korean)"})
        Me.cmb_Language.Location = New System.Drawing.Point(6, 19)
        Me.cmb_Language.Name = "cmb_Language"
        Me.cmb_Language.Size = New System.Drawing.Size(125, 21)
        Me.cmb_Language.TabIndex = 40
        Me.tt_Common.SetToolTip(Me.cmb_Language, "La langue du jeu pour laquelle le code AR sera généré.")
        '
        'pb_SavefileSignatureImage
        '
        Me.pb_SavefileSignatureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_SavefileSignatureImage.ContextMenuStrip = Me.ContextMenuStrip1
        Me.pb_SavefileSignatureImage.Location = New System.Drawing.Point(101, 50)
        Me.pb_SavefileSignatureImage.Name = "pb_SavefileSignatureImage"
        Me.pb_SavefileSignatureImage.Size = New System.Drawing.Size(194, 66)
        Me.pb_SavefileSignatureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_SavefileSignatureImage.TabIndex = 1013
        Me.pb_SavefileSignatureImage.TabStop = False
        Me.tt_Common.SetToolTip(Me.pb_SavefileSignatureImage, resources.GetString("pb_SavefileSignatureImage.ToolTip"))
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
        'pb_CodeSignatureImage
        '
        Me.pb_CodeSignatureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_CodeSignatureImage.Location = New System.Drawing.Point(117, 12)
        Me.pb_CodeSignatureImage.Name = "pb_CodeSignatureImage"
        Me.pb_CodeSignatureImage.Size = New System.Drawing.Size(194, 66)
        Me.pb_CodeSignatureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_CodeSignatureImage.TabIndex = 1
        Me.pb_CodeSignatureImage.TabStop = False
        Me.tt_Common.SetToolTip(Me.pb_CodeSignatureImage, "L'image qui servira de nouvelle signature.")
        '
        'tc_Main
        '
        Me.tc_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Main.Controls.Add(Me.tp_CodeGenerator)
        Me.tc_Main.Controls.Add(Me.tp_SaveEditor)
        Me.tc_Main.HotTrack = True
        Me.tc_Main.Location = New System.Drawing.Point(12, 92)
        Me.tc_Main.Multiline = True
        Me.tc_Main.Name = "tc_Main"
        Me.tc_Main.SelectedIndex = 0
        Me.tc_Main.Size = New System.Drawing.Size(499, 361)
        Me.tc_Main.TabIndex = 20
        '
        'tp_CodeGenerator
        '
        Me.tp_CodeGenerator.Controls.Add(Me.gb_CodeLanguage)
        Me.tp_CodeGenerator.Controls.Add(Me.TextBox1)
        Me.tp_CodeGenerator.Controls.Add(Me.b_Copy1)
        Me.tp_CodeGenerator.Controls.Add(Me.gb_CodeVersion)
        Me.tp_CodeGenerator.Controls.Add(Me.cb_SplitCode)
        Me.tp_CodeGenerator.Controls.Add(Me.TextBox2)
        Me.tp_CodeGenerator.Controls.Add(Me.b_Activators)
        Me.tp_CodeGenerator.Controls.Add(Me.b_Copy2)
        Me.tp_CodeGenerator.Controls.Add(Me.b_GenerateAR)
        Me.tp_CodeGenerator.Controls.Add(Me.lbl_2ndPart)
        Me.tp_CodeGenerator.Controls.Add(Me.lbl_1stPart)
        Me.tp_CodeGenerator.Location = New System.Drawing.Point(4, 22)
        Me.tp_CodeGenerator.Name = "tp_CodeGenerator"
        Me.tp_CodeGenerator.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_CodeGenerator.Size = New System.Drawing.Size(491, 335)
        Me.tp_CodeGenerator.TabIndex = 0
        Me.tp_CodeGenerator.Text = "Générateur de code AR"
        '
        'gb_CodeLanguage
        '
        Me.gb_CodeLanguage.Controls.Add(Me.cmb_Language)
        Me.gb_CodeLanguage.Location = New System.Drawing.Point(348, 154)
        Me.gb_CodeLanguage.Name = "gb_CodeLanguage"
        Me.gb_CodeLanguage.Size = New System.Drawing.Size(137, 46)
        Me.gb_CodeLanguage.TabIndex = 40
        Me.gb_CodeLanguage.TabStop = False
        Me.gb_CodeLanguage.Text = "Langue"
        '
        'tp_SaveEditor
        '
        Me.tp_SaveEditor.AllowDrop = True
        Me.tp_SaveEditor.BackColor = System.Drawing.SystemColors.Control
        Me.tp_SaveEditor.Controls.Add(Me.lbl_FilePath)
        Me.tp_SaveEditor.Controls.Add(Me.b_ImportImage)
        Me.tp_SaveEditor.Controls.Add(Me.b_SaveAs)
        Me.tp_SaveEditor.Controls.Add(Me.b_OpenSave)
        Me.tp_SaveEditor.Controls.Add(Me.b_ReloadSave)
        Me.tp_SaveEditor.Controls.Add(Me.gb_SaveInfos)
        Me.tp_SaveEditor.Controls.Add(Me.pb_SavefileSignatureImage)
        Me.tp_SaveEditor.Location = New System.Drawing.Point(4, 22)
        Me.tp_SaveEditor.Name = "tp_SaveEditor"
        Me.tp_SaveEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_SaveEditor.Size = New System.Drawing.Size(491, 335)
        Me.tp_SaveEditor.TabIndex = 1
        Me.tp_SaveEditor.Text = "Modificateur de sauvegarde"
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
        'gb_SaveInfos
        '
        Me.gb_SaveInfos.Controls.Add(Me.lbl_Size)
        Me.gb_SaveInfos.Controls.Add(Me.lbl_CurrentBlock)
        Me.gb_SaveInfos.Controls.Add(Me.gb_SaveVersions)
        Me.gb_SaveInfos.Controls.Add(Me.cb_NoGBA)
        Me.gb_SaveInfos.Location = New System.Drawing.Point(6, 193)
        Me.gb_SaveInfos.Name = "gb_SaveInfos"
        Me.gb_SaveInfos.Size = New System.Drawing.Size(207, 136)
        Me.gb_SaveInfos.TabIndex = 2000
        Me.gb_SaveInfos.TabStop = False
        Me.gb_SaveInfos.Text = "Infos sur la sauvegarde"
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
        'gb_SaveVersions
        '
        Me.gb_SaveVersions.Controls.Add(Me.rb_BW_sav)
        Me.gb_SaveVersions.Controls.Add(Me.rb_HGSS_sav)
        Me.gb_SaveVersions.Controls.Add(Me.rb_DP_sav)
        Me.gb_SaveVersions.Controls.Add(Me.rb_Plat_sav)
        Me.gb_SaveVersions.Location = New System.Drawing.Point(6, 19)
        Me.gb_SaveVersions.Name = "gb_SaveVersions"
        Me.gb_SaveVersions.Size = New System.Drawing.Size(109, 111)
        Me.gb_SaveVersions.TabIndex = 3000
        Me.gb_SaveVersions.TabStop = False
        Me.gb_SaveVersions.Text = "Version"
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
        'sfd_SaveSavefileAs
        '
        Me.sfd_SaveSavefileAs.DefaultExt = "sav"
        Me.sfd_SaveSavefileAs.Filter = "Sauvegardes NDS|*.sav|Tous les fichiers|*.*"
        Me.sfd_SaveSavefileAs.Title = "Enregistrer la sauvegarde sous..."
        '
        'sfd_SaveImageAs
        '
        Me.sfd_SaveImageAs.DefaultExt = "png"
        Me.sfd_SaveImageAs.FileName = "signature.png"
        Me.sfd_SaveImageAs.Filter = "Images PNG|*.png|Images GIF|*.gif|Images BMP|*.bmp|Tous les fichiers|*.*"
        Me.sfd_SaveImageAs.InitialDirectory = "."
        Me.sfd_SaveImageAs.Title = "Sauver l'image sous..."
        '
        'ofd_OpenSavefile
        '
        Me.ofd_OpenSavefile.DefaultExt = "sav"
        Me.ofd_OpenSavefile.Filter = "Sauvegardes NDS|*.sav; *.dsv|Tous les fichiers|*.*"
        Me.ofd_OpenSavefile.SupportMultiDottedExtensions = True
        Me.ofd_OpenSavefile.Title = "Ouvrir une sauvegarde..."
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
        'gb_ProgramLanguage
        '
        Me.gb_ProgramLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_ProgramLanguage.Controls.Add(Me.cmb_ProgramLanguage)
        Me.gb_ProgramLanguage.Location = New System.Drawing.Point(12, 455)
        Me.gb_ProgramLanguage.Name = "gb_ProgramLanguage"
        Me.gb_ProgramLanguage.Size = New System.Drawing.Size(142, 46)
        Me.gb_ProgramLanguage.TabIndex = 10001
        Me.gb_ProgramLanguage.TabStop = False
        Me.gb_ProgramLanguage.Text = "Langue du programme"
        '
        'cmb_ProgramLanguage
        '
        Me.cmb_ProgramLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_ProgramLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_ProgramLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ProgramLanguage.FormattingEnabled = True
        Me.cmb_ProgramLanguage.Location = New System.Drawing.Point(6, 19)
        Me.cmb_ProgramLanguage.Name = "cmb_ProgramLanguage"
        Me.cmb_ProgramLanguage.Size = New System.Drawing.Size(130, 21)
        Me.cmb_ProgramLanguage.TabIndex = 0
        '
        'Form1
        '
        Me.AcceptButton = Me.b_OpenImage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 506)
        Me.Controls.Add(Me.gb_ProgramLanguage)
        Me.Controls.Add(Me.pb_CodeSignatureImage)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbl_Sensitivity)
        Me.Controls.Add(Me.tc_Main)
        Me.Controls.Add(Me.b_OpenImage)
        Me.Controls.Add(Me.b_About)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.b_Preview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(539, 542)
        Me.Name = "Form1"
        Me.Text = "Pokémon Signature Editor v{version} - par M@T"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_CodeVersion.ResumeLayout(False)
        CType(Me.pb_SavefileSignatureImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pb_CodeSignatureImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Main.ResumeLayout(False)
        Me.tp_CodeGenerator.ResumeLayout(False)
        Me.tp_CodeGenerator.PerformLayout()
        Me.gb_CodeLanguage.ResumeLayout(False)
        Me.tp_SaveEditor.ResumeLayout(False)
        Me.tp_SaveEditor.PerformLayout()
        Me.gb_SaveInfos.ResumeLayout(False)
        Me.gb_SaveInfos.PerformLayout()
        Me.gb_SaveVersions.ResumeLayout(False)
        Me.gb_SaveVersions.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_ProgramLanguage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_GenerateAR As System.Windows.Forms.Button
    Friend WithEvents pb_CodeSignatureImage As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents b_Copy1 As System.Windows.Forms.Button
    Friend WithEvents b_OpenImage As System.Windows.Forms.Button
    Friend WithEvents ofd_OpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents lbl_Sensitivity As System.Windows.Forms.Label
    Friend WithEvents cb_SplitCode As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents b_Copy2 As System.Windows.Forms.Button
    Friend WithEvents lbl_1stPart As System.Windows.Forms.Label
    Friend WithEvents lbl_2ndPart As System.Windows.Forms.Label
    Friend WithEvents b_Activators As System.Windows.Forms.Button
    Friend WithEvents tt_Activators As System.Windows.Forms.ToolTip
    Friend WithEvents b_About As System.Windows.Forms.Button
    Friend WithEvents tt_Common As System.Windows.Forms.ToolTip
    Friend WithEvents gb_CodeVersion As System.Windows.Forms.GroupBox
    Friend WithEvents b_Preview As System.Windows.Forms.Button
    Friend WithEvents tc_Main As System.Windows.Forms.TabControl
    Friend WithEvents tp_CodeGenerator As System.Windows.Forms.TabPage
    Friend WithEvents tp_SaveEditor As System.Windows.Forms.TabPage
    Friend WithEvents b_ImportImage As System.Windows.Forms.Button
    Friend WithEvents pb_SavefileSignatureImage As System.Windows.Forms.PictureBox
    Friend WithEvents b_SaveAs As System.Windows.Forms.Button
    Friend WithEvents b_OpenSave As System.Windows.Forms.Button
    Friend WithEvents b_ReloadSave As System.Windows.Forms.Button
    Friend WithEvents gb_SaveInfos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Size As System.Windows.Forms.Label
    Friend WithEvents lbl_CurrentBlock As System.Windows.Forms.Label
    Friend WithEvents gb_SaveVersions As System.Windows.Forms.GroupBox
    Friend WithEvents rb_HGSS_sav As System.Windows.Forms.RadioButton
    Friend WithEvents rb_DP_sav As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Plat_sav As System.Windows.Forms.RadioButton
    Friend WithEvents cb_NoGBA As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmi_SaveImageAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd_SaveSavefileAs As System.Windows.Forms.SaveFileDialog
    Friend WithEvents sfd_SaveImageAs As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofd_OpenSavefile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tsmi_LoadImageAbove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_Version As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Language As System.Windows.Forms.ComboBox
    Friend WithEvents gb_CodeLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents rb_BW_sav As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_FilePath As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gb_ProgramLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_ProgramLanguage As System.Windows.Forms.ComboBox

End Class
