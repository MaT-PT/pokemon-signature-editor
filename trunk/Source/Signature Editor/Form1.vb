Imports System.IO, System.Drawing.Imaging, System.Runtime.InteropServices

Public Class Form1

    'Form1.vb
    'Fenêtre principale

    'Par M@T, pour PokémonTrash

#Region "Déclarations"
    'Déclaration des variables :

    'Images pour les aperçus
    Dim bmp0 As Bitmap

    'Chaîne intermédiaire pour le parcours des pixels de l'image
    Dim codeTemp As String

    'Variables pour le code final
    Dim code, code2 As String

    'Indique si il faut générer automatiquement le code ou non
    Dim gen As Boolean = False

    'Indique si une image a été chargée
    Public imgChargee As Boolean = False

    'Définit les parties constantes du code
    Public activateur As String = "94000130 FCFF0000" & vbCrLf
    Dim dbt As String = "B2101F20 00000000" & vbCrLf
    Dim adr As String = "E0005BBC"
    Dim adr2 As String = "E0005EBC"


    Public Version_sav As Version = Version.PLATINE

    Dim pos As OffsetsSign = OffsetsSign.PLATINE

    Dim offsetBloc As OffsetsBloc = OffsetsBloc.BLOC_1

    Dim offset As Byte = 0

    Dim offsetSavCnt As OffsetsSavCnt = OffsetsSavCnt.PLATINE

    Dim tailleBloc As TaillesBloc = TaillesBloc.PLATINE

    Dim offsetChkSumFooter As OffsetsChkSumFooter = OffsetsChkSumFooter.DP_PT

    Dim path As String = ""

    Dim sav256ko As Boolean = False

    Public savChargee As Boolean = False

    Dim comp() As Byte = {&HFE, &HCA, &HEF, &HBE}

    Dim SeedTable() As UShort = {&H0, &H1021, &H2042, &H3063, &H4084, &H50A5, &H60C6, &H70E7, _
                                 &H8108, &H9129, &HA14A, &HB16B, &HC18C, &HD1AD, &HE1CE, &HF1EF, _
                                 &H1231, &H210, &H3273, &H2252, &H52B5, &H4294, &H72F7, &H62D6, _
                                 &H9339, &H8318, &HB37B, &HA35A, &HD3BD, &HC39C, &HF3FF, &HE3DE, _
                                 &H2462, &H3443, &H420, &H1401, &H64E6, &H74C7, &H44A4, &H5485, _
                                 &HA56A, &HB54B, &H8528, &H9509, &HE5EE, &HF5CF, &HC5AC, &HD58D, _
                                 &H3653, &H2672, &H1611, &H630, &H76D7, &H66F6, &H5695, &H46B4, _
                                 &HB75B, &HA77A, &H9719, &H8738, &HF7DF, &HE7FE, &HD79D, &HC7BC, _
                                 &H48C4, &H58E5, &H6886, &H78A7, &H840, &H1861, &H2802, &H3823, _
                                 &HC9CC, &HD9ED, &HE98E, &HF9AF, &H8948, &H9969, &HA90A, &HB92B, _
                                 &H5AF5, &H4AD4, &H7AB7, &H6A96, &H1A71, &HA50, &H3A33, &H2A12, _
                                 &HDBFD, &HCBDC, &HFBBF, &HEB9E, &H9B79, &H8B58, &HBB3B, &HAB1A, _
                                 &H6CA6, &H7C87, &H4CE4, &H5CC5, &H2C22, &H3C03, &HC60, &H1C41, _
                                 &HEDAE, &HFD8F, &HCDEC, &HDDCD, &HAD2A, &HBD0B, &H8D68, &H9D49, _
                                 &H7E97, &H6EB6, &H5ED5, &H4EF4, &H3E13, &H2E32, &H1E51, &HE70, _
                                 &HFF9F, &HEFBE, &HDFDD, &HCFFC, &HBF1B, &HAF3A, &H9F59, &H8F78, _
                                 &H9188, &H81A9, &HB1CA, &HA1EB, &HD10C, &HC12D, &HF14E, &HE16F, _
                                 &H1080, &HA1, &H30C2, &H20E3, &H5004, &H4025, &H7046, &H6067, _
                                 &H83B9, &H9398, &HA3FB, &HB3DA, &HC33D, &HD31C, &HE37F, &HF35E, _
                                 &H2B1, &H1290, &H22F3, &H32D2, &H4235, &H5214, &H6277, &H7256, _
                                 &HB5EA, &HA5CB, &H95A8, &H8589, &HF56E, &HE54F, &HD52C, &HC50D, _
                                 &H34E2, &H24C3, &H14A0, &H481, &H7466, &H6447, &H5424, &H4405, _
                                 &HA7DB, &HB7FA, &H8799, &H97B8, &HE75F, &HF77E, &HC71D, &HD73C, _
                                 &H26D3, &H36F2, &H691, &H16B0, &H6657, &H7676, &H4615, &H5634, _
                                 &HD94C, &HC96D, &HF90E, &HE92F, &H99C8, &H89E9, &HB98A, &HA9AB, _
                                 &H5844, &H4865, &H7806, &H6827, &H18C0, &H8E1, &H3882, &H28A3, _
                                 &HCB7D, &HDB5C, &HEB3F, &HFB1E, &H8BF9, &H9BD8, &HABBB, &HBB9A, _
                                 &H4A75, &H5A54, &H6A37, &H7A16, &HAF1, &H1AD0, &H2AB3, &H3A92, _
                                 &HFD2E, &HED0F, &HDD6C, &HCD4D, &HBDAA, &HAD8B, &H9DE8, &H8DC9, _
                                 &H7C26, &H6C07, &H5C64, &H4C45, &H3CA2, &H2C83, &H1CE0, &HCC1, _
                                 &HEF1F, &HFF3E, &HCF5D, &HDF7C, &HAF9B, &HBFBA, &H8FD9, &H9FF8, _
                                 &H6E17, &H7E36, &H4E55, &H5E74, &H2E93, &H3EB2, &HED1, &H1EF0}

    Enum Version As Byte
        INCONNU = 0
        DP = 1
        PLATINE = 2
        HGSS = 3
    End Enum

    Enum OffsetsSign As UShort
        DP = &H5904
        PLATINE = &H5BA8
        HGSS = &H4538
    End Enum

    Enum OffsetsBloc As Integer
        BLOC_1 = 0
        BLOC_2 = &H40000
    End Enum

    Enum OffsetsSavCnt As UShort
        DP = &HC0F0
        PLATINE = &HCF1C
        HGSS = &HF618
    End Enum

    Enum TaillesBloc As UShort
        DP = &HC0EC
        PLATINE = &HCF18
        HGSS = &HF618
    End Enum

    Enum OffsetsChkSumFooter As Byte
        DP_PT = &H12
        HGSS = &HE
    End Enum
#End Region


#Region "Méthodes"
    'Génère le code AR à partir de l'image passée en paramètre
    '(on peut aussi indiquer si on veut séparer le code en deux)
    Private Sub Generer(ByVal bmp As Bitmap, Optional ByVal separer As Boolean = False)
        codeTemp = ""
        code = ""
        code2 = ""

        'Boucle qui parcourt les pixels de l'image par groupes de 8
        'et qui construit les valeurs hexadécimales permettant de modifier les adresses mémoire de la signature dans le jeu
        'C'est la partie la plus importante dans la création du code.
        For cY = 0 To 56 Step 8
            For cX = 0 To 184 Step 8
                For pY = 3 + cY To cY Step -1
                    For pX = 7 + cX To cX Step -1
                        'Si le pixel est blanc, on ajoute "0" au code temporaire,
                        'sinon (le pixel est donc noir puisqu'on est en monochrome) on ajoute "1"
                        codeTemp &= If(bmp.GetPixel(pX, pY).ToArgb = -1, 0, 1)
                    Next pX

                    'Convertit le code temporaire du binaire vers le décimal puis en hexadécimal
                    code &= Convert.ToInt32(codeTemp, 2).ToString("X2")

                    codeTemp = ""
                Next pY

                'On est au milieu de la ligne, donc on ajoute un espace
                code &= " "

                For pY = 7 + cY To 4 + cY Step -1
                    For pX = 7 + cX To cX Step -1
                        codeTemp &= If(bmp.GetPixel(pX, pY).ToArgb = -1, 0, 1)
                    Next pX

                    code &= Convert.ToInt32(codeTemp, 2).ToString("X2")

                    codeTemp = ""
                Next pY

                'C'est la fin de la ligne, donc on ajoute un retour chariot
                code &= vbCrLf
        Next cX, cY

        If separer Then
            'Si il faut séparer le code, on récupère la seconde moitié,
            'à laquelle on ajoute les formalités afin de faire un code fonctionnel
            code2 = code.Substring(1824)
            code2 = activateur & dbt & adr2 & " 00000300" & vbCrLf & code2 & "D2000000 00000000"

            'Puis on fait de même avec la première moitié
            code = code.Substring(0, 1824)
            code = activateur & dbt & adr & " 00000300" & vbCrLf & code & "D2000000 00000000"
        Else
            'Sinon, on met en forme la totalité du code
            code = activateur & dbt & adr & " 00000600" & vbCrLf & code & "D2000000 00000000"
        End If

        'Enfin, on affiche le tout dans les TextBox prévues à cet effet
        TextBox1.Text = code
        TextBox2.Text = code2
    End Sub


    'Fonction qui convertit une image Bitmap couleur en Bitmap monochrome, avec la sensibilité au noir spécifiée
    '(plus la sensibilité est élevée, plus l'image sera sombre)
    Private Function BMP2Mono(ByVal img As Bitmap, Optional ByVal sens As Double = 0.5) As Bitmap
        Using bm = New Bitmap(img.Width, img.Height)

            For y = 0 To img.Height - 1
                For x = 0 To img.Width - 1
                    If img.GetPixel(x, y).GetBrightness >= sens Then
                        'Si la luminosité est supérieure à la sensibilité, on remplace par du blanc
                        bm.SetPixel(x, y, Color.White)
                    Else
                        'Sinon, par du noir
                        bm.SetPixel(x, y, Color.Black)
                    End If
            Next x, y

            'On libère les ressources utilisées par l'image
            img.Dispose()

            BMP2Mono = New Bitmap(bm)
            bm.Dispose()
        End Using
    End Function

    'Vérifie qu'une image est bien chargée et qu'il faut générer le code, et dans ce cas appelle la fonction Generer()
    Public Sub genVerif()
        If imgChargee AndAlso gen Then Generer(PictureBox1.Image, CheckBox1.Checked)
    End Sub

    'Récupère le n° de version et le retourne formaté comme ceci :
    '1.0 si c'est une version majeure
    '1.2 si c'est une mise à jour mineure
    '1.2.3 si c'est une build intermédiaire
    '1.2.3.4 si c'est une version "privée"
    Private Function VersionProg() As String
        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)

            If .FileBuildPart = 0 Then

                If .FilePrivatePart = 0 Then
                    VersionProg = .FileMajorPart & "." & .FileMinorPart
                Else
                    VersionProg = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart & "." & .FilePrivatePart
                End If

            Else

                If .FilePrivatePart = 0 Then
                    VersionProg = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart
                Else
                    VersionProg = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart & "." & .FilePrivatePart
                End If

            End If
        End With
    End Function

    Private Function n2x(ByVal n As Integer) As Integer
        Return ((7 - n Mod 8) + 8 * (n \ 64)) Mod 192
    End Function

    Private Function n2y(ByVal n As Integer) As Integer
        Return ((n Mod 64) \ 8) + 8 * (n \ 1536)
    End Function

    Function Dec2Bin(ByVal n As Byte) As String
        Dec2Bin = ""

        For i = 1 To 8
            If (n Mod 2) Then Dec2Bin = "1" & Dec2Bin Else Dec2Bin = "0" & Dec2Bin
            n = n \ CByte(2)
        Next i
    End Function

    Private Function ByteArrayEqual(ByVal a As Byte(), ByVal b As Byte()) As Boolean
        If Not a.Length = b.Length Then
            Return False
        End If

        For i = 0 To a.Length - 1
            If Not a(i) = b(i) Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Function GetVersion(ByVal path As String, ByVal offset As Byte) As Version
        Using sav As New BinaryReader(New FileStream(path, FileMode.Open))
            sav.BaseStream.Seek(&H12DC + offset, SeekOrigin.Begin)

            If ByteArrayEqual(sav.ReadBytes(4), comp) Then
                GetVersion = Version.DP
            Else
                sav.BaseStream.Seek(&H1328 + offset, SeekOrigin.Begin)

                If ByteArrayEqual(sav.ReadBytes(4), comp) Then
                    GetVersion = Version.PLATINE
                Else
                    sav.BaseStream.Seek(&H12B8 + offset, SeekOrigin.Begin)

                    If ByteArrayEqual(sav.ReadBytes(4), comp) Then
                        GetVersion = Version.HGSS
                    Else
                        GetVersion = Version.INCONNU
                    End If
                End If
            End If

            sav.Close()
        End Using
    End Function

    Private Function GetOffset(ByVal path As String) As Byte
        Using sav As New BinaryReader(New FileStream(path, FileMode.Open))

            If New String(sav.ReadChars(&H1F)) = "NocashGbaBackupMediaSavDataFile" Then
                cb_NoGBA.Checked = True
                GetOffset = &H4C
            Else
                cb_NoGBA.Checked = False
                GetOffset = 0
            End If

            sav.Close()
        End Using
    End Function

    Private Function GetOffset(ByVal sav As BinaryReader) As Byte

        If New String(sav.ReadChars(&H1F)) = "NocashGbaBackupMediaSavDataFile" Then
            cb_NoGBA.Checked = True
            GetOffset = &H4C
        Else
            cb_NoGBA.Checked = False
            GetOffset = 0
        End If
    End Function


    Private Sub reload(ByVal path As String)
        offset = GetOffset(path)

        Dim savInfo As New FileInfo(path)

        sav256ko = savInfo.Length = &H40000

        'sav As New BinaryReader(New FileStream(path, FileMode.Open)), _
        Using sav As New BinaryReader(savInfo.OpenRead), _
              bmp As New System.Drawing.Bitmap(192, 64), _
              gr As Graphics = Graphics.FromImage(bmp)

            gr.Clear(Color.White)
            gr.Save()

            If sav256ko Then
                offsetBloc = OffsetsBloc.BLOC_1
                lbl_Bloc_Courant.Text = ""
                lbl_Taille.Text = "Taille : 256 ko"
            Else
                sav.BaseStream.Seek(offset + offsetSavCnt, SeekOrigin.Begin)
                Dim compteurSauv1 = sav.ReadInt32()

                sav.BaseStream.Seek(offset + offsetSavCnt + &H40000, SeekOrigin.Begin)
                Dim compteurSauv2 = sav.ReadInt32()

                If compteurSauv1 >= compteurSauv2 Then
                    offsetBloc = OffsetsBloc.BLOC_1
                    lbl_Bloc_Courant.Text = "Bloc courant : 1"
                Else
                    offsetBloc = OffsetsBloc.BLOC_2
                    lbl_Bloc_Courant.Text = "Bloc courant : 2"
                End If

                lbl_Taille.Text = "Taille : 512 ko"
            End If

            sav.BaseStream.Seek(offset + offsetBloc, SeekOrigin.Begin)
            Dim chkSum As UShort = GetCheckSum(sav.ReadBytes(tailleBloc))

            sav.BaseStream.Seek(offsetChkSumFooter, SeekOrigin.Current)
            If Not chkSum = sav.ReadUInt16() Then
                If MsgBox("La sauvegarde est corrompue !" & vbCrLf & "Voulez-vous la charger quand même ?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Sauvegarde corrompue") = MsgBoxResult.No Then
                    RAZ()

                    Exit Sub
                End If
            End If

            sav.BaseStream.Seek(offset + offsetBloc + pos, SeekOrigin.Begin)

            Dim sign() As Byte = sav.ReadBytes(&H600)
            Dim tempBin As String = ""
            Dim n As Integer = 0

            For Each b As Byte In sign
                tempBin = Dec2Bin(b)

                For Each p As Char In tempBin
                    If p = "1" Then
                        bmp.SetPixel(n2x(n), n2y(n), Color.Black)
                    End If

                    n += 1
            Next p, b

            PictureBox2.Image = bmp.Clone()

            sav.Close()
            bmp.Dispose()
        End Using
    End Sub

    Private Function Image2Sign(ByVal bmp As Bitmap) As Byte()
        Dim binTemp As String = ""
        Dim lst As New List(Of Byte)

        For cY = 0 To 56 Step 8
            For cX = 0 To 184 Step 8
                For pY = cY To 7 + cY
                    For pX = 7 + cX To cX Step -1
                        binTemp &= If(bmp.GetPixel(pX, pY).ToArgb = -1, 0, 1)
                    Next pX

                    lst.Add(Convert.ToByte(binTemp, 2))
                    binTemp = ""
                Next pY
        Next cX, cY

        Return lst.ToArray
    End Function

    Public Function GetCheckSum(ByVal data As Byte()) As UShort
        Dim sum As UShort = &HFFFF

        For i As Integer = 0 To data.Length - 1
            sum = (sum << 8) Xor SeedTable(CByte(data(i) Xor CByte(sum >> 8)))
        Next i

        Return CShort(sum)
    End Function

    Private Sub enregistrer()
        If Not savChargee Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        If Not SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim format As ImageFormat

        Dim filename = SaveFileDialog1.FileName

        Dim parts = filename.ToLower.Split(".")

        Select Case parts(parts.Length - 1)
            Case "png"
                format = ImageFormat.Png
            Case "bmp"
                format = ImageFormat.Bmp
            Case "gif"
                format = ImageFormat.Gif
            Case "emf"
                format = ImageFormat.Emf
            Case "jpg", "jpeg"
                format = ImageFormat.Jpeg
            Case "tif", "tiff"
                format = ImageFormat.Tiff
            Case "wmf"
                format = ImageFormat.Wmf

            Case Else
                format = ImageFormat.Bmp
        End Select

        PictureBox2.Image.Save(filename, format)
    End Sub

    Private Sub RAZ()
        rb_DP_sav.Checked = False
        rb_Plat_sav.Checked = False
        rb_HGSS_sav.Checked = False
        cb_NoGBA.Checked = False
        lbl_Bloc_Courant.Text = "Bloc courant :"
        lbl_Taille.Text = "Taille :"

        savChargee = False
        path = ""

        PictureBox2.Image = Nothing
    End Sub
#End Region


#Region "Événements"
    'Au lancement du programme
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Définit le répertoire initial dans la boîte de dialogue "Ouvrir" comme le dossier "Mes Images" par défaut
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
    End Sub

    'Quand le bouton "Générer" est cliqué
    Private Sub b_Generer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Generer.Click
        If Not imgChargee Then
            'Si l'image n'est pas chargée, on affiche un message d'erreur puis on quitte
            MsgBox("Veuillez sélectionner une image !", MsgBoxStyle.Critical, "Erreur : Aucune image sélectionnée !")

            Exit Sub
        End If

        'On génère le code
        Generer(PictureBox1.Image, CheckBox1.Checked)

        gen = True 'Indique que le code devra se mettre à jour automatiquement
    End Sub

    'Quand le premier bouton "Copier" est cliqué
    Private Sub b_Copier1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Copier1.Click
        If TextBox1.Text = "" Then
            'Si il n'y a pas de code généré, alors on affiche une erreur
            MsgBox("Veuillez d'abord générer un code...", MsgBoxStyle.Exclamation, "Erreur : aucun code à copier !")
        Else
            'Sinon, on copie le code dans le presse-papiers
            Clipboard.SetText(TextBox1.Text)
        End If
    End Sub

    'Quand le second bouton "Copier" est cliqué
    Private Sub b_Copier2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Copier2.Click
        If TextBox2.Text = "" Then
            'Si il n'y a pas de code généré, alors on affiche une erreur
            MsgBox("Veuillez d'abord générer un code...", MsgBoxStyle.Exclamation, "Erreur : aucun code à copier !")
        Else
            'Sinon, on copie le code dans le presse-papiers
            Clipboard.SetText(TextBox2.Text)
        End If
    End Sub

    'Quand le bouton "Ouvrir une image" est cliqué
    Private Sub b_Ouvrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Ouvrir.Click
        'Si l'utilisateur annule, on quitte
        If Not OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub

        Try
            'On essaye de créer une nouvelle image à partir du chemin spécifié
            bmp0 = New Bitmap(OpenFileDialog1.FileName)
        Catch
            'Si une exception est levée, c'est que le fichier n'est pas une image valide, donc on affiche un message d'erreur
            MsgBox("Le fichier sélectionné n'est pas une image valide.", MsgBoxStyle.Critical, "Erreur : image invalide !")
            imgChargee = False
            PictureBox1.Image = Nothing
            TextBox1.Text = ""
            TextBox2.Text = ""

            'Et on quitte la procédure
            Exit Sub
        End Try

        If Not bmp0.Size = New Size(192, 64) Then
            'Si l'image ne fait pas 192x64 pixels, on affiche une erreur
            MsgBox("L'image doit faire exactement 192x64 pixels !", MsgBoxStyle.Critical, "Erreur : dimensions incorrectes !")
            imgChargee = False
            PictureBox1.Image = Nothing
            TextBox1.Text = ""
            TextBox2.Text = ""

            Exit Sub
        End If

        'On efface les anciens codes au chargement de la nouvelle image
        TextBox1.Text = ""
        TextBox2.Text = ""

        'On indique qu'il ne faut pas générer le code automatiquement pour l'instant
        gen = False

        'On met à jour l'aperçu avec la nouvelle image
        PictureBox1.Image = New Bitmap(BMP2Mono(bmp0, TrackBar1.Value / TrackBar1.Maximum))

        'On libère les ressources utilisées par les images
        bmp0.Dispose()

        'On indique qu'une image a été chargée
        imgChargee = True

        'On sélectionne le bouton "Générer"
        b_Generer.Select()
    End Sub

    'Quand la valeur de la barre de sensibilité change
    Private Sub TrackBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        Label1.Text = "Sensibilité : " & CDbl(TrackBar1.Value / TrackBar1.Maximum).ToString

        If imgChargee Then
            'Si une image a été chargée
            bmp0 = New Bitmap(OpenFileDialog1.FileName)

            'On met à jour l'aperçu
            PictureBox1.Image = New Bitmap(BMP2Mono(bmp0, TrackBar1.Value / TrackBar1.Maximum))

            'On rafraîchit l'affichage les contrôles
            PictureBox1.Refresh()
            Label1.Refresh()

            'On libère les ressources utilisées par les images
            bmp0.Dispose()
        End If
    End Sub

    'Quand l'état de CheckBox "Couper le code en deux" change
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'On régénère le code en vérifiant si les paramètres le permettent
        genVerif()

        'On adapte la zone pour le second code en fonction de l'état de cette CheckBox
        Label3.Enabled = CheckBox1.Checked
        TextBox2.Enabled = CheckBox1.Checked
        b_Copier2.Enabled = CheckBox1.Checked
    End Sub

    'Quand le bouton "Activateurs" est cliqué
    Private Sub b_Activ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Activ.Click
        'On montre la boîte de dialogue pour définir les activateurs
        Form2.ShowDialog()
    End Sub

    'Quand le bouton "À propos" est cliqué
    Private Sub b_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_About.Click
        'On affiche les crédits
        MsgBox("Pokémon Signature Editor v" & VersionProg() & vbCrLf & _
                       "pour Pokémon version Diamant, Perle, Platine," & vbCrLf & _
                       "Or HeartGold et Argent SoulSilver" & vbCrLf & vbCrLf & _
                       "par M@T aka. lVl477l-l13Ll" & vbCrLf & vbCrLf & _
                       "Source libre, si vous la modifiez merci de laisser les crédits ! ;)" & vbCrLf & vbCrLf & _
                       "http://www.pokemontrash.com/", MsgBoxStyle.Information, "À propos...")
    End Sub

    'Quand la sélection des RadioButton change
    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Plat.CheckedChanged, rb_DP.CheckedChanged, rb_HGSS.CheckedChanged
        'En fonction de la version sélectionnée, on définit les constantes du code
        If rb_Plat.Checked Then
            dbt = "B2101F20 00000000" & vbCrLf
            adr = "E0005BBC"
            adr2 = "E0005EBC"

        ElseIf rb_DP.Checked Then
            dbt = "B21C4EA8 00000000" & vbCrLf & "B0000004 00000000" & vbCrLf
            adr = "E0005B70"
            adr2 = "E0005E70"

        ElseIf rb_HGSS.Checked Then
            dbt = "B21118A0 00000000" & vbCrLf
            adr = "E0004548"
            adr2 = "E0004848"

        Else 'Cette condition ne devrait jamais être vérifiée, mais on ne sait jamais...
            rb_Plat.Checked = True
            dbt = "B2101F20 00000000" & vbCrLf
            adr = "E0005BBC"
            adr2 = "E0005EBC"
        End If

        'On régénère le code en vérifiant si les paramètres le permettent
        genVerif()
    End Sub

    'Quand le bouton de prévisualisation est cliqué
    Private Sub b_Previs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Previs.Click
        'On affiche la boîte de dialogue de prévisualisation
        Form3.ShowDialog()
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then
            sender.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub b_OuvrirSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_OuvrirSav.Click
        If Not OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        path = OpenFileDialog2.FileName

        Version_sav = GetVersion(path, GetOffset(path))

        Select Case Version_sav
            Case Version.DP
                rb_DP_sav.Checked = True
                pos = OffsetsSign.DP
                offsetSavCnt = OffsetsSavCnt.DP
                tailleBloc = TaillesBloc.DP
                offsetChkSumFooter = OffsetsChkSumFooter.DP_PT

            Case Version.PLATINE
                rb_Plat_sav.Checked = True
                pos = OffsetsSign.PLATINE
                offsetSavCnt = OffsetsSavCnt.PLATINE
                tailleBloc = TaillesBloc.PLATINE
                offsetChkSumFooter = OffsetsChkSumFooter.DP_PT

            Case Version.HGSS
                rb_HGSS_sav.Checked = True
                pos = OffsetsSign.HGSS
                offsetSavCnt = OffsetsSavCnt.HGSS
                tailleBloc = TaillesBloc.HGSS
                offsetChkSumFooter = OffsetsChkSumFooter.HGSS

            Case Else
                MsgBox("Ce n'est pas une sauvegarde de Pokémon 4G !", MsgBoxStyle.Critical, "Erreur : format de sauvegarde invalide")
                RAZ()

                Exit Sub
        End Select

        savChargee = True

        reload(path)
    End Sub

    Private Sub b_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Import.Click
        If Not savChargee Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        If Not imgChargee Then
            MsgBox("Il faut d'abord ouvrir une image !", MsgBoxStyle.Critical, "Erreur : aucune image chargée")
            Exit Sub
        End If

        PictureBox2.Image = New Bitmap(PictureBox1.Image)
    End Sub

    Private Sub b_Sauver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Sauver.Click
        If Not savChargee Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        Dim infoFichier As New FileInfo(path)

        SaveFileDialog2.InitialDirectory = infoFichier.DirectoryName
        SaveFileDialog2.FileName = infoFichier.Name

        If Not SaveFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim dest As String = SaveFileDialog2.FileName
        Dim path_out As String = dest & ".tmp"

        Using sav_in As New BinaryReader(New FileStream(path, FileMode.Open, FileAccess.Read)), _
              sav_out As New BinaryWriter(New FileStream(path_out, FileMode.Create, FileAccess.ReadWrite)), _
              tmp_br As New BinaryReader(sav_out.BaseStream)

            offset = GetOffset(sav_in)

            sav_in.BaseStream.Seek(offset, SeekOrigin.Begin)

            Dim save As Byte() = sav_in.ReadBytes(If(sav256ko, &H40000, &H80000))

            Dim gh As GCHandle = GCHandle.Alloc(save, GCHandleType.Pinned)

            Dim sign As Byte() = Image2Sign(PictureBox2.Image)

            Marshal.Copy(sign, 0, New IntPtr(gh.AddrOfPinnedObject().ToInt32() + offsetBloc + pos), &H600)

            gh.Free()

            sav_out.Write(save)

            tmp_br.BaseStream.Seek(offsetBloc, SeekOrigin.Begin)

            Dim chkSum As UShort = GetCheckSum(tmp_br.ReadBytes(tailleBloc))
            tmp_br.BaseStream.Seek(offsetChkSumFooter, SeekOrigin.Current)
            sav_out.Write(chkSum)

            sav_in.Close()
            sav_out.Flush()
            tmp_br.Close()
            sav_out.Close()
        End Using

        If File.Exists(dest) Then
            File.Replace(path_out, dest, dest & ".BAK", True)
        Else
            File.Move(path_out, dest)
        End If

        MsgBox("La sauvegarde a bien été modifiée !", MsgBoxStyle.Information, "Enregistrement effectué")
    End Sub

    Private Sub b_Recharger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Recharger.Click
        If Not savChargee Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        reload(path)
    End Sub

    Private Sub EnregistrerLimageSousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerLimageSousToolStripMenuItem.Click
        enregistrer()
    End Sub

    Private Sub ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargerLimageDansLaPartieDuHautPourEnFaireUnCodeARToolStripMenuItem.Click
        If Not savChargee Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        PictureBox1.Image = New Bitmap(PictureBox2.Image)
        imgChargee = True
    End Sub
#End Region
End Class
