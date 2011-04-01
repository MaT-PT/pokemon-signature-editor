Imports System.IO, System.Drawing.Imaging, System.Runtime.InteropServices

Public Class Form1

    '''Form1.vb
    '''Fenêtre principale

    '''Par M@T, pour PokémonTrash.com


    Const IS_BETA As Boolean = True
    Const IS_RC As Boolean = False

#Region "Declarations"

    Friend newLine As String = Environment.NewLine()

    Private SettingsFile As String = Application.StartupPath & "\settings.ini"

    ''Déclaration des variables :

    Private bmp0 As Bitmap 'Image pour les aperçus
    Private codeTemp As String 'Chaîne intermédiaire pour le parcours des pixels de l'image
    Private code, code2 As String 'Variables pour le code final
    Private mustGen As Boolean = False 'Indique s'il faut générer automatiquement le code ou non

    Friend imgLoaded As Boolean = False 'Indique si une image a été chargée
    Private imgPath As String = "" 'Chemin du fichier d'image
    Private formLoaded As Boolean = False

    Friend codeTrigger As String = "94000130 FCFF0000" & newLine
    Private pointer, addr1, addr2 As String


    Friend saveVersion As Versions = Versions.Unknown
    Private position As OffsetsSign = OffsetsSign.Platinum
    Private blockOffset As BlockOffsets = BlockOffsets.Block_1
    Private initialOffset As Byte = 0
    Private offsetSavCnt As OffsetsSavCnt = OffsetsSavCnt.Platinum
    Private blockSize As BlockSizes = BlockSizes.Platinum
    Private offsetChkSumFooter As ChkSumFooterOffsets = ChkSumFooterOffsets.DP_PT

    Private savePath As String = ""
    Private sav256ko As Boolean = False
    Friend saveLoaded As Boolean = False
    Private saveIsBW As Boolean = False


    Private lngFileLines As New List(Of String)
    Private currentLocale As String = Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName()
    Private currentLngFile As String = "default.lng"
    Private lngFiles As New List(Of LanguageFile)

    Private sensitivityText As String = "Sensibilité :"
    Private sizeText As String = "Taille :"
    Private currentBlockText As String = "Bloc courant :"
    Private byteUnitSymbol As String = "o"
    Private defaultGameLanguage As Langs = Langs.Fra
    Private aboutBoxText As String = "Pokémon Signature Editor v{version}" & newLine & _
                                     "pour Pokémon versions Diamant, Perle, Platine, HeartGold, SoulSilver, Noire & Blanche" & newLine & newLine & _
                                     "Par M@T." & newLine & newLine & _
                                     "Source libre, si vous la modifiez merci de me prévenir et de laisser les crédits ! ;)" & newLine & newLine & _
                                     "http://www.pokemontrash.com/"
    Private aboutBoxTitle As String = "À propos..."


    Const bw_footer_offset As Integer = &H23F00
    Const bw_footer_signature_chkSum_offset As Integer = &H23F42
    Const bw_footer_chkSum_offset As Integer = &H23F9A
    Const bw_signature_block_size As Integer = &H658
    Const bw_footer_size As Integer = &H8C

    Private comp() As Byte = {&HFE, &HCA, &HEF, &HBE}

    Private SeedTable() As UShort = {&H0, &H1021, &H2042, &H3063, &H4084, &H50A5, &H60C6, &H70E7, _
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

    Friend Enum Versions As Byte
        Unknown = &HFF
        DP = 0
        Platinum = 1
        HGSS = 2
        BW = 3
    End Enum

    Friend Enum Langs As Byte
        Fra = 0
        USA = 1
        Jap = 2
        Esp = 3
        Ita = 4
        Deu = 5
        Kor = 6
    End Enum

    Friend Enum OffsetsSign As UInteger
        DP = &H5904
        Platinum = &H5BA8
        HGSS = &H4538
        BW = &H1C100
    End Enum

    'http://gbatemp.net/t255124-pokemon-black-white-hacking-documentation?view=findpost&p=3144849

    Friend Enum BlockOffsets As Integer
        Block_1 = &H0
        Block_2 = &H40000
        Block_2_BW = &H24000
    End Enum

    Friend Enum OffsetsSavCnt As UInteger
        DP = &HC0F0
        Platinum = &HCF1C
        HGSS = &HF618
        BW = &H23F8C
    End Enum

    Friend Enum BlockSizes As UInteger
        DP = &HC0EC
        Platinum = &HCF18
        HGSS = &HF618
        BW = &H23F8C
    End Enum

    Friend Enum ChkSumFooterOffsets As Byte
        DP_PT = &H12
        HGSS = &HE
        BW = &HE
    End Enum

    Private Structure LanguageFile
        Private _filePath As String
        Private _fileName As String
        Private _langName As String
        Private _langID As String
        Private _isValid As Boolean

        Friend Sub New(ByVal filePath As String)
            Init(filePath)
        End Sub

        Private Function Init(ByVal filePath As String) As Boolean
            _filePath = filePath
            _fileName = Path.GetFileName(filePath)

            Dim fileLines As String() = File.ReadAllLines(filePath, System.Text.Encoding.UTF8)
            Dim flags As Byte = &H0

            For Each line As String In fileLines
                If line.TrimStart(" ", vbTab).StartsWith("#") Then
                    Dim l As String = line.TrimStart("#", " ", vbTab)

                    If l.Contains("=") Then
                        If l.StartsWith("LangName", StringComparison.OrdinalIgnoreCase) Then
                            _langName = l.Substring(l.IndexOf("=") + 1).TrimStart(" ", vbTab)
                            flags = flags Or &H1

                        ElseIf l.StartsWith("LangID", StringComparison.OrdinalIgnoreCase) Then
                            _langID = l.Substring(l.IndexOf("=") + 1).TrimStart(" ", vbTab).ToLowerInvariant
                            flags = flags Or &H2
                        End If
                    End If
                End If
            Next line

            If Not CBool(flags And CByte(&H2)) Then
                _langID = ""
            End If

            _isValid = CBool(flags And CByte(&H1))
            Return _isValid
        End Function

        Friend Function SetFilePath(ByVal filePath As String) As Boolean
            If File.Exists(filePath) Then
                Return Init(filePath)
            Else
                Return False
            End If
        End Function

        Friend ReadOnly Property FilePath() As String
            Get
                Return _filePath
            End Get
        End Property

        Friend ReadOnly Property FileName() As String
            Get
                Return _fileName
            End Get
        End Property

        Friend ReadOnly Property LangName() As String
            Get
                Return _langName
            End Get
        End Property

        Friend ReadOnly Property LangID() As String
            Get
                Return _langID
            End Get
        End Property

        Friend ReadOnly Property IsValid() As Boolean
            Get
                Return _isValid
            End Get
        End Property
    End Structure
#End Region


#Region "Methods"
    'Génère le code AR à partir de l'image passée en paramètre
    '(on peut aussi indiquer si on veut séparer le code en deux)
    Private Sub generateARCode(ByVal bmp As Bitmap, Optional ByVal mustSplitCode As Boolean = False)
        regenGameParameters()

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
                        codeTemp &= If(bmp.GetPixel(pX, pY).ToArgb = -1, "0", "1")
                    Next pX

                    'Convertit le code temporaire du binaire vers le décimal puis en hexadécimal
                    code &= Convert.ToInt32(codeTemp, 2).ToString("X2")

                    codeTemp = ""
                Next pY

                code &= " "

                For pY = 7 + cY To 4 + cY Step -1
                    For pX = 7 + cX To cX Step -1
                        codeTemp &= If(bmp.GetPixel(pX, pY).ToArgb = -1, "0", "1")
                    Next pX

                    code &= Convert.ToInt32(codeTemp, 2).ToString("X2")

                    codeTemp = ""
                Next pY

                code &= newLine
        Next cX, cY

        If mustSplitCode Then
            'Si il faut séparer le code, on récupère la seconde moitié,
            'à laquelle on ajoute les formalités afin de faire un code fonctionnel
            code2 = code.Substring(1824)
            code2 = codeTrigger & pointer & addr2 & " 00000300" & newLine & code2 & "D2000000 00000000"

            'Puis on fait de même avec la première moitié
            code = code.Substring(0, 1824)
            code = codeTrigger & pointer & addr1 & " 00000300" & newLine & code & "D2000000 00000000"
        Else
            'Sinon, on met en forme la totalité du code
            code = codeTrigger & pointer & addr1 & " 00000600" & newLine & code & "D2000000 00000000"
        End If

        TextBox1.Text = code
        TextBox2.Text = code2
    End Sub

    'Fonction qui convertit une image Bitmap couleur en Bitmap monochrome, avec la sensibilité au noir spécifiée
    '(plus la sensibilité est élevée, plus l'image sera sombre)
    Private Function BMP2Mono(ByVal img As Bitmap, Optional ByVal sens As Double = 0.5) As Bitmap
        Using bm As New Bitmap(img.Width, img.Height)

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

            img.Dispose()

            BMP2Mono = New Bitmap(bm)
            bm.Dispose()
        End Using
    End Function

    'Vérifie qu'une image est bien chargée et qu'il faut générer le code, et dans ce cas appelle la fonction Generer()
    Friend Sub genVerif()
        If imgLoaded AndAlso mustGen Then generateARCode(pb_CodeSignatureImage.Image, cb_SplitCode.Checked)
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

        If IS_RC Then
            VersionProg &= " RC"
        ElseIf IS_BETA Then
            VersionProg &= " beta"
        End If
    End Function

    Private Function n2x(ByVal n As Integer) As Integer
        Return ((7 - n Mod 8) + 8 * (n \ 64)) Mod 192
    End Function

    Private Function n2y(ByVal n As Integer) As Integer
        Return ((n Mod 64) \ 8) + 8 * (n \ 1536)
    End Function

    Friend Function Dec2Bin(ByVal n As Byte) As String
        Dec2Bin = ""

        For i = 1 To 8
            Dec2Bin = (n Mod 2) & Dec2Bin
            n = n \ CByte(2)
        Next i
    End Function

    Private Function ByteArraysEqual(ByVal a As Byte(), ByVal b As Byte()) As Boolean
        If Not a.Length = b.Length Then
            Return False
        End If

        For i = 0 To a.Length - 1
            If Not a(i) = b(i) Then
                Return False
            End If
        Next i

        Return True
    End Function

    Private Function GetVersion(ByVal path As String) As Versions
        Dim offset As Byte = GetOffset(savePath)

        Using sav As New BinaryReader(New FileStream(path, FileMode.Open))
            sav.BaseStream.Seek(&H12DC + offset, SeekOrigin.Begin)

            If ByteArraysEqual(sav.ReadBytes(4), comp) Then
                GetVersion = Versions.DP
            Else
                sav.BaseStream.Seek(&H1328 + offset, SeekOrigin.Begin)

                If ByteArraysEqual(sav.ReadBytes(4), comp) Then
                    GetVersion = Versions.Platinum
                Else
                    sav.BaseStream.Seek(&H12B8 + offset, SeekOrigin.Begin)

                    If ByteArraysEqual(sav.ReadBytes(4), comp) Then
                        GetVersion = Versions.HGSS
                    Else
                        sav.BaseStream.Seek(&H21600 + offset, SeekOrigin.Begin)

                        If ByteArraysEqual(sav.ReadBytes(4), comp) Then
                            GetVersion = Versions.BW
                        Else
                            GetVersion = Versions.Unknown
                        End If
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

    Private Sub loadSave(ByVal filePath As String)
        If Not File.Exists(filePath) Then
            MsgBox("Le fichier spécifié est introuvable.", MsgBoxStyle.Critical, "Erreur : fichier introuvable")
            reset()

            Exit Sub
        End If

        saveVersion = GetVersion(savePath)

        Select Case saveVersion
            Case Versions.DP
                rb_DP_sav.Checked() = True
                position = OffsetsSign.DP
                offsetSavCnt = OffsetsSavCnt.DP
                blockSize = BlockSizes.DP
                offsetChkSumFooter = ChkSumFooterOffsets.DP_PT
                saveIsBW = False

            Case Versions.Platinum
                rb_Plat_sav.Checked() = True
                position = OffsetsSign.Platinum
                offsetSavCnt = OffsetsSavCnt.Platinum
                blockSize = BlockSizes.Platinum
                offsetChkSumFooter = ChkSumFooterOffsets.DP_PT
                saveIsBW = False

            Case Versions.HGSS
                rb_HGSS_sav.Checked() = True
                position = OffsetsSign.HGSS
                offsetSavCnt = OffsetsSavCnt.HGSS
                blockSize = BlockSizes.HGSS
                offsetChkSumFooter = ChkSumFooterOffsets.HGSS
                saveIsBW = False

            Case Versions.BW
                rb_BW_sav.Checked() = True
                position = OffsetsSign.BW
                offsetSavCnt = OffsetsSavCnt.BW
                blockSize = BlockSizes.BW
                offsetChkSumFooter = ChkSumFooterOffsets.BW
                saveIsBW = True

            Case Else
                reset()
                MsgBox("Ce n'est pas une sauvegarde de Pokémon NDS !", MsgBoxStyle.Critical, "Erreur : format de sauvegarde invalide")

                Exit Sub
        End Select

        saveLoaded = True

        lbl_FilePath.Text = savePath
        lbl_FilePath.Font = New Font(lbl_FilePath.Font, FontStyle.Regular)

        initialOffset = GetOffset(filePath)

        Dim savInfo As New FileInfo(filePath)

        sav256ko = (savInfo.Length - initialOffset = &H40000)

        'sav As New BinaryReader(New FileStream(path, FileMode.Open)), _
        Using sav As New BinaryReader(savInfo.OpenRead), _
              bmp As New System.Drawing.Bitmap(192, 64), _
              gr As Graphics = Graphics.FromImage(bmp)

            If sav256ko Then
                blockOffset = BlockOffsets.Block_1
                lbl_CurrentBlock.Text = ""
                lbl_Size.Text = sizeText & " 256 k" & byteUnitSymbol
            Else
                Dim offsetBlock2 As UInteger

                If saveIsBW Then
                    offsetBlock2 = BlockOffsets.Block_2_BW
                Else
                    offsetBlock2 = BlockOffsets.Block_2
                End If

                sav.BaseStream.Seek(initialOffset + offsetSavCnt, SeekOrigin.Begin)
                Dim compteurSauv1 As Integer = sav.ReadInt32()

                sav.BaseStream.Seek(initialOffset + offsetSavCnt + offsetBlock2, SeekOrigin.Begin)
                Dim compteurSauv2 As Integer = sav.ReadInt32()

                If compteurSauv1 >= compteurSauv2 Then
                    blockOffset = BlockOffsets.Block_1
                    lbl_CurrentBlock.Text = currentBlockText & " 1"
                Else
                    blockOffset = offsetBlock2
                    lbl_CurrentBlock.Text = currentBlockText & " 2"
                End If

                lbl_Size.Text = sizeText & " 512 k" & byteUnitSymbol
            End If

            Dim corrupted As Boolean = False

            If saveIsBW Then
                '0x1C75A = ChkSum(0x1C100|0x658)
                '0x23F42 = ChkSum(0x1C100|0x658)
                '0x23F9A = ChkSum(0x23F00|0x8C)

                sav.BaseStream.Seek(initialOffset + OffsetsSign.BW, SeekOrigin.Begin)
                Dim bwSignBlockChkSum As UShort = GetCheckSum(sav.ReadBytes(bw_signature_block_size))
                sav.BaseStream.Seek(2, SeekOrigin.Current)
                Dim bwSignBlockActualChkSum As UShort = sav.ReadUInt16()
                sav.BaseStream.Seek(initialOffset + bw_footer_signature_chkSum_offset, SeekOrigin.Begin)
                Dim bwFooterSignActualChkSum As UShort = sav.ReadUInt16()

                sav.BaseStream.Seek(initialOffset + bw_footer_offset, SeekOrigin.Begin)
                Dim bwFooterChkSum As UShort = GetCheckSum(sav.ReadBytes(bw_footer_size))
                sav.BaseStream.Seek(initialOffset + bw_footer_chkSum_offset, SeekOrigin.Begin)
                Dim bwFooterActualChkSum As UShort = sav.ReadUInt16()

                corrupted = Not ((bwSignBlockChkSum = bwSignBlockActualChkSum) And _
                                 (bwSignBlockChkSum = bwFooterSignActualChkSum) And _
                                    (bwFooterChkSum = bwFooterActualChkSum))

            Else
                sav.BaseStream.Seek(initialOffset + blockOffset, SeekOrigin.Begin)
                Dim chkSum As UShort = GetCheckSum(sav.ReadBytes(blockSize))
                sav.BaseStream.Seek(offsetChkSumFooter, SeekOrigin.Current)

                corrupted = Not (chkSum = sav.ReadUInt16())
            End If

            If corrupted AndAlso (Not MsgBox("La sauvegarde est corrompue !" & newLine & "Voulez-vous la charger quand même ?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Attention : Sauvegarde corrompue") = MsgBoxResult.Yes) Then
                reset()
                Exit Sub
            End If

            sav.BaseStream.Seek(initialOffset + blockOffset + position, SeekOrigin.Begin)

            gr.Clear(Color.White)
            gr.Save()

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

            pb_SavefileSignatureImage.Image = bmp.Clone()

            sav.Close()
            bmp.Dispose()
        End Using
    End Sub

    Private Function Image2SignBytes(ByVal bmp As Bitmap) As Byte()
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

        Return lst.ToArray()
    End Function

    Friend Function GetCheckSum(ByVal data As Byte()) As UShort
        Dim sum As UShort = &HFFFF

        For i As Integer = 0 To data.Length - 1
            sum = (sum << 8) Xor SeedTable(CByte(data(i) Xor CByte(sum >> 8)))
        Next i

        Return sum
    End Function

    Private Sub saveImageAs()
        If Not saveLoaded Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        If Not sfd_SaveImageAs.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim format As ImageFormat

        Dim filename = sfd_SaveImageAs.FileName

        Dim parts = filename.ToLowerInvariant.Split(".")

        Select Case parts(parts.Length - 1)
            Case "png"
                format = ImageFormat.Png()
            Case "bmp"
                format = ImageFormat.Bmp()
            Case "gif"
                format = ImageFormat.Gif()
            Case "emf"
                format = ImageFormat.Emf()
            Case "jpg", "jpeg"
                format = ImageFormat.Jpeg()
            Case "tif", "tiff"
                format = ImageFormat.Tiff()
            Case "wmf"
                format = ImageFormat.Wmf()

            Case Else
                format = ImageFormat.Bmp()
        End Select

        pb_SavefileSignatureImage.Image.Save(filename, format)
    End Sub

    Private Sub reset()
        rb_DP_sav.Checked = False
        rb_Plat_sav.Checked = False
        rb_HGSS_sav.Checked = False
        rb_BW_sav.Checked = False
        cb_NoGBA.Checked = False
        lbl_CurrentBlock.Text = "Bloc courant :"
        lbl_Size.Text = "Taille :"

        saveVersion = Versions.Unknown
        saveLoaded = False
        savePath = ""
        lbl_FilePath.Text = "(aucun fichier chargé)"
        lbl_FilePath.Font = New Font(lbl_FilePath.Font, FontStyle.Italic)

        pb_SavefileSignatureImage.Image = Nothing
    End Sub

    Private Sub regenGameParameters()
        '                             Français    EN/US/Aus   Japanese    Español     Italiano    Deutch      Korean
        Dim pointers As String(,) = {{"B21C4EA8", "B21C4D28", "B21C6588", "B21C4EC8", "B21C4E08", "B21C4E68", "B21C2328"}, _
                                     {"B2101F20", "B2101D40", "B2101140", "B2101F40", "B2101EA0", "B2101EE0", "B2102C40"}, _
                                     {"B21118A0", "B2111880", "B2110DC0", "B21118C0", "B2111820", "B2111860", "B2112280"}, _
                                     {"B2000024", "B2000024", "B2000024", "B2000024", "B2000024", "B2000024", "B2000024"}}

        pointer = pointers(cmb_Version.SelectedIndex(), cmb_Language.SelectedIndex()) & " 00000000" & newLine

        Select Case cmb_Version.SelectedIndex()
            Case Versions.DP
                addr1 = "E0005B70"
                addr2 = "E0005E70"
                pointer &= "B0000004 00000000" & newLine

            Case Versions.Platinum
                addr1 = "E0005BBC"
                addr2 = "E0005EBC"

            Case Versions.HGSS
                addr1 = "E0004548"
                addr2 = "E0004848"

            Case Versions.BW
                addr1 = "E001C9BC"
                addr2 = "E001CCBC"

            Case Else
                cmb_Version.SelectedIndex = Versions.BW
                Exit Sub
        End Select
    End Sub

    Private Sub openImage()
        Try
            bmp0 = New Bitmap(imgPath) 'Essaye de créer une nouvelle image à partir du chemin spécifié
        Catch
            'Si une exception est levée, c'est que le fichier n'est pas une image valide, donc on affiche un message d'erreur
            MsgBox("Le fichier sélectionné n'est pas une image valide.", MsgBoxStyle.Critical, "Erreur : image invalide")
            imgLoaded = False
            pb_CodeSignatureImage.Image = Nothing
            TextBox1.Text = ""
            TextBox2.Text = ""

            Exit Sub
        End Try

        If Not bmp0.Size = New Size(192, 64) Then
            'Si l'image ne fait pas 192x64 pixels, on affiche une erreur
            MsgBox("L'image doit faire exactement 192x64 pixels !", MsgBoxStyle.Critical, "Erreur : dimensions incorrectes")
            imgLoaded = False
            pb_CodeSignatureImage.Image = Nothing
            TextBox1.Text = ""
            TextBox2.Text = ""

            Exit Sub
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""

        mustGen = False 'Indique qu'il ne faut pas générer le code automatiquement pour l'instant

        pb_CodeSignatureImage.Image = New Bitmap(BMP2Mono(bmp0, TrackBar1.Value / TrackBar1.Maximum))

        bmp0.Dispose()

        imgLoaded = True 'Indique qu'une image a été chargée

        b_GenerateAR.Select() 'Sélectionne le bouton "Générer"
    End Sub

    Private Sub addControlText(ByVal ctrl As Control)
        If (Not TypeOf ctrl Is NumericUpDown) _
           AndAlso ctrl.Text IsNot Nothing _
           AndAlso ctrl.Name <> "" _
           AndAlso ctrl.Text <> "" _
           Then
            addLngFileLine(ctrl.Name, ctrl.Text)
        End If

        If tt_Common.GetToolTip(ctrl) IsNot Nothing AndAlso tt_Common.GetToolTip(ctrl) <> "" AndAlso ctrl.Name <> "" Then
            addLngFileLine(ctrl.Name & ".ToolTip", tt_Common.GetToolTip(ctrl))
        End If

        For Each c As Control In ctrl.Controls
            addControlText(c)
        Next c

        'If ctrl.ContextMenuStrip() IsNot Nothing Then
        '    For Each i In ctrl.ContextMenuStrip.Items()
        '        addLngFileLine(i.Name, i.Text)
        '    Next i
        'End If
    End Sub

    Private Sub addLngFileLine(ByVal parameterName As String, ByVal value As String)
        lngFileLines.Add(parameterName & " = " & value.Replace(newLine, "|"))
    End Sub

    Private Sub addLngFileLine(ByVal parameterName As String)
        lngFileLines.Add(parameterName)
    End Sub

    Private Sub initLanguageFile(ByVal filePath As String)
        addLngFileLine("# LangName", "Français")
        addLngFileLine("# LangID", "fr")
        addLngFileLine("")

        addLngFileLine("# Form1")
        addControlText(Me)
        addLngFileLine("ContextMenu_SaveImageAs", tsmi_SaveImageAs.Text)
        addLngFileLine("ContextMenu_LoadImageToBoxAbove", tsmi_LoadImageAbove.Text)
        addLngFileLine("OpenImageDialog_Title", ofd_OpenImage.Title)
        addLngFileLine("OpenSavefileDialog_Title", ofd_OpenSavefile.Title)
        addLngFileLine("SaveImageDialog_Title", sfd_SaveImageAs.Title)
        addLngFileLine("SaveSavefileDialog_Title", sfd_SaveSavefileAs.Title)
        addLngFileLine("OpenImageDialog_Filter", ofd_OpenImage.Filter)
        addLngFileLine("OpenSavefileDialog_Filter", ofd_OpenSavefile.Filter)
        addLngFileLine("SaveImageDialog_Filter", sfd_SaveImageAs.Filter)
        addLngFileLine("SaveSavefileDialog_Filter", sfd_SaveSavefileAs.Filter)
        addLngFileLine("ActivatorsTooltip_Title", tt_Activators.ToolTipTitle)
        addLngFileLine("Version_DP", cmb_Version.Items(0))
        addLngFileLine("Version_Plat", cmb_Version.Items(1))
        addLngFileLine("Version_HGSS", cmb_Version.Items(2))
        addLngFileLine("Version_BW", cmb_Version.Items(3))

        addLngFileLine("# Form2")
        addControlText(Form2)

        addLngFileLine("# Form3")
        addControlText(Form3)
        addLngFileLine("AnimateStopText", Form3.animateStopText)

        addLngFileLine("# Misc")
        addLngFileLine("; Available languages : Fra|0, USA|1, Jap|2, Esp|3, Ita|4, Deu|5, Kor|6")
        addLngFileLine("DefaultGameLanguage", defaultGameLanguage.ToString())
        addLngFileLine("ByteUnitSymbol", byteUnitSymbol)
        addLngFileLine("AboutBoxText", aboutBoxText)
        addLngFileLine("AboutBoxTitle", aboutBoxTitle)

        File.WriteAllLines(filePath, lngFileLines.ToArray(), System.Text.Encoding.UTF8)
    End Sub

    Private Sub loadLanguageFile(ByVal filePath As String)
        If Not File.Exists(filePath) Then Exit Sub

        Dim fileLines As String() = File.ReadAllLines(filePath, System.Text.Encoding.UTF8)

        Dim controlName, text As String
        Dim currentForm As Form = Me

        For Each line As String In fileLines
            If line.TrimStart(" ", vbTab).StartsWith(";") Then Continue For

            If line.TrimStart(" ", vbTab).StartsWith("#") Then
                Dim l As String = line.TrimStart("#", " ", vbTab)

                If l.StartsWith("Form1", StringComparison.OrdinalIgnoreCase) Then
                    currentForm = Me

                ElseIf l.StartsWith("Form2", StringComparison.OrdinalIgnoreCase) Then
                    currentForm = Form2

                ElseIf l.StartsWith("Form3", StringComparison.OrdinalIgnoreCase) Then
                    currentForm = Form3
                End If

                Continue For
            End If

            If Not line.Contains("=") Then Continue For

            controlName = line.Substring(0, line.IndexOf("=")).Trim()
            text = line.Substring(line.IndexOf("=") + 1).TrimStart(" ", vbTab).Replace("\\", "<#²backslash²#>").Replace("\|", "<#²pipe²#>").Replace("|", newLine).Replace("<#²backslash²#>", "\").Replace("<#²pipe²#>", "|")

            Select Case controlName.ToLowerInvariant()
                Case "form1"
                    Me.Text = text
                    Continue For

                Case "form2"
                    Form2.Text = text
                    Continue For

                Case "form3"
                    Form3.Text = text
                    Continue For

                Case "openimagedialog_title"
                    ofd_OpenImage.Title = text
                    Continue For

                Case "opensavefiledialog_title"
                    ofd_OpenSavefile.Title = text
                    Continue For

                Case "saveimagedialog_title"
                    sfd_SaveImageAs.Title = text
                    Continue For

                Case "savesavefiledialog_title"
                    sfd_SaveSavefileAs.Title = text
                    Continue For

                Case "openimagedialog_filter"
                    Try
                        ofd_OpenImage.Filter = text
                    Catch
                    End Try
                    Continue For

                Case "opensavefiledialog_filter"
                    Try
                        ofd_OpenSavefile.Filter = text
                    Catch
                    End Try
                    Continue For

                Case "saveimagedialog_filter"
                    Try
                        sfd_SaveImageAs.Filter = text
                    Catch
                    End Try
                    Continue For

                Case "savesavefiledialog_filter"
                    Try
                        sfd_SaveSavefileAs.Filter = text
                    Catch
                    End Try
                    Continue For

                Case "activatorstooltip_title"
                    tt_Activators.ToolTipTitle = text
                    Continue For

                Case "contextmenu_saveimageas"
                    tsmi_SaveImageAs.Text = text
                    Continue For

                Case "contextmenu_loadimagetoboxabove"
                    tsmi_LoadImageAbove.Text = text
                    Continue For

                Case "lbl_sensitivity"
                    sensitivityText = text

                Case "lbl_size"
                    sizeText = text

                Case "lbl_currentblock"
                    currentBlockText = text

                Case "lbl_animate"
                    Form3.animateStartText = text

                Case "animatestoptext"
                    Form3.animateStopText = text
                    Continue For

                Case "byteunitsymbol"
                    byteUnitSymbol = text
                    Continue For

                Case "aboutboxtext"
                    aboutBoxText = text
                    Continue For

                Case "aboutboxtitle"
                    aboutBoxTitle = text
                    Continue For

                Case "version_dp"
                    cmb_Version.Items(0) = text
                    Continue For

                Case "version_plat"
                    cmb_Version.Items(1) = text
                    Continue For

                Case "version_hgss"
                    cmb_Version.Items(2) = text
                    Continue For

                Case "version_bw"
                    cmb_Version.Items(3) = text
                    Continue For

                Case "defaultgamelanguage"
                    Try
                        If IsNumeric(text) Then
                            defaultGameLanguage = CInt(text)
                        Else
                            defaultGameLanguage = CInt([Enum].Parse(GetType(Langs), text, True))
                        End If
                    Catch
                    End Try
                    Continue For

            End Select

            If controlName.EndsWith(".ToolTip", StringComparison.OrdinalIgnoreCase) Then
                For Each c As Control In currentForm.Controls.Find(controlName.Substring(0, controlName.IndexOf(".ToolTip", StringComparison.OrdinalIgnoreCase)), True)
                    tt_Common.SetToolTip(c, text)
                Next c
            Else
                For Each c As Control In currentForm.Controls.Find(controlName, True)
                    c.Text = text
                Next c
            End If
        Next line

        lbl_Sensitivity.Left = 487 - lbl_Sensitivity.Width
        b_Preview.Left = 414 - CInt(Int(b_Preview.Width / 2))
        b_Activators.Left = 417 - CInt(Int(b_Activators.Width / 2))
        b_ImportImage.Left = 199 - CInt(Int(b_ImportImage.Width / 2))
        b_ReloadSave.Left = 417 - CInt(Int(b_ReloadSave.Width / 2))

        With Form2
            .cb_Up.Left = 81 - CInt(Int(.cb_Up.Width / 2))
            .cb_Down.Left = 81 - CInt(Int(.cb_Down.Width / 2))
            .cb_X.Left = 196 - CInt(Int(.cb_X.Width / 2))
            .cb_B.Left = 196 - CInt(Int(.cb_B.Width / 2))
            .cb_Left.Left = 70 - .cb_Left.Width
            .cb_Y.Left = 185 - .cb_Y.Width
            .cb_L.Left = 124 - .cb_L.Width
            .cb_Start.Left = 124 - .cb_Start.Width
        End With

        With Form3
            .rb_PreviewWhite.Left = 12 + .rb_PreviewBlack.Width
            .gb_BWPreviewVersion.Width = 18 + .rb_PreviewBlack.Width + .rb_PreviewWhite.Width
            .gb_BWPreviewVersion.Left = 140 - CInt(Int(.gb_BWPreviewVersion.Width / 2))
        End With
    End Sub

    Private Function GetSetting(ByVal settingName As String) As String
        If Not File.Exists(SettingsFile) Then Return ""

        Dim fileLines As String() = File.ReadAllLines(SettingsFile, System.Text.Encoding.UTF8)

        For Each line As String In fileLines
            If line.TrimStart(" ", vbTab).StartsWith(";") _
               OrElse line.TrimStart(" ", vbTab).StartsWith("#") _
               OrElse Not line.Contains("=") _
            Then Continue For

            If line.Substring(0, line.IndexOf("=")).Trim().Equals(settingName, StringComparison.OrdinalIgnoreCase) Then Return line.Substring(line.IndexOf("=") + 1).Trim()
        Next line

        Return ""
    End Function

    Private Sub SetSetting(ByVal settingName As String, ByVal settingValue As String)
        If Not File.Exists(SettingsFile) Then
            File.WriteAllText(SettingsFile, settingName & " = " & settingValue, System.Text.Encoding.UTF8)
            Exit Sub
        End If

        Dim fileLines As String() = File.ReadAllLines(SettingsFile, System.Text.Encoding.UTF8)
        Dim newLines As New List(Of String)
        Dim settingUpdated As Boolean = False

        For Each line As String In fileLines
            If line.TrimStart(" ", vbTab).StartsWith(";") _
               OrElse line.TrimStart(" ", vbTab).StartsWith("#") _
               OrElse Not line.Contains("=") _
            Then
                newLines.Add(line)
                Continue For
            End If

            If line.Substring(0, line.IndexOf("=")).Trim().Equals(settingName, StringComparison.OrdinalIgnoreCase) Then
                newLines.Add(settingName & " = " & settingValue)
                settingUpdated = True
            Else
                newLines.Add(line)
            End If
        Next line

        If Not settingUpdated Then
            newLines.Add(settingName & " = " & settingValue)
        End If

        File.WriteAllLines(SettingsFile, newLines.ToArray(), System.Text.Encoding.UTF8)
    End Sub
#End Region


#Region "Events"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Environment.GetCommandLineArgs.Length > 1 AndAlso Environment.GetCommandLineArgs(1).Equals("/generatelangfile", StringComparison.OrdinalIgnoreCase) Then
            initLanguageFile(Application.StartupPath & "\default.lng")
            'Console.WriteLine("Default language file ""default.lng"" generated. Now exiting...") ' Doesn't work
            Application.Exit()
            Me.Close()
            Exit Sub
        End If

        'Définit le répertoire initial dans la boîte de dialogue "Ouvrir" comme le dossier "Mes Images" par défaut
        ofd_OpenImage.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures

        Try
            currentLngFile = GetSetting("Language File")
            If Not File.Exists(Path.Combine(Application.StartupPath, currentLngFile)) Then
                currentLngFile = ""
            End If
        Catch
            currentLngFile = ""
        End Try

        Dim currentLng As LanguageFile
        For Each f As String In Directory.GetFiles(Application.StartupPath, "*.lng", SearchOption.TopDirectoryOnly)
            currentLng = New LanguageFile(f)
            If Not currentLng.IsValid() Then Continue For

            lngFiles.Add(currentLng)
        Next f

        Dim n As Integer = 0
        For Each lng As LanguageFile In lngFiles
            cmb_ProgramLanguage.Items.Add(lng.LangName)

            If (currentLngFile = "" AndAlso lng.LangID = currentLocale) OrElse lng.FileName = currentLngFile Then
                cmb_ProgramLanguage.SelectedIndex = n
                currentLngFile = lng.FileName
            End If

            n += 1
        Next lng

        Try
            loadLanguageFile(Path.Combine(Application.StartupPath, currentLngFile))
        Catch
        End Try

        Try
            Dim gameVersion As String = GetSetting("Game Version")
            If IsNumeric(gameVersion) Then
                cmb_Version.SelectedIndex = CInt(gameVersion)
            Else
                cmb_Version.SelectedIndex = CInt([Enum].Parse(GetType(Versions), gameVersion, True))
            End If
        Catch
            cmb_Version.SelectedIndex = Versions.BW
        End Try

        Try
            cmb_Language.SelectedIndex = defaultGameLanguage
        Catch
            cmb_Language.SelectedIndex = Langs.Fra
        End Try

        Me.Text = Me.Text.Replace("{version}", VersionProg())
        aboutBoxText = aboutBoxText.Replace("{version}", VersionProg())

        lbl_Sensitivity.Text = sensitivityText & " " & CDbl(TrackBar1.Value / TrackBar1.Maximum).ToString()

        pb_CodeSignatureImage.AllowDrop = True

        formLoaded = True
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Workaround for a bug in Windows Vista where the animation stops and doesn't restart correctly  if the form loses focus
        PictureBox3.Invalidate()
    End Sub

    Private Sub b_GenerateAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_GenerateAR.Click
        If Not imgLoaded Then
            'Si l'image n'est pas chargée, on affiche un message d'erreur puis on quitte
            MsgBox("Veuillez sélectionner une image !", MsgBoxStyle.Critical, "Erreur : Aucune image sélectionnée !")

            Exit Sub
        End If

        generateARCode(pb_CodeSignatureImage.Image, cb_SplitCode.Checked()) 'Génère le code

        mustGen = True 'Indique que le code devra se mettre à jour automatiquement
    End Sub

    Private Sub b_Copy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Copy1.Click
        If TextBox1.Text = "" Then
            'Si il n'y a pas de code généré, alors on affiche une erreur
            MsgBox("Veuillez d'abord générer un code.", MsgBoxStyle.Exclamation, "Attention : aucun code à copier")
        Else
            'Sinon, on copie le code dans le presse-papiers
            Clipboard.SetText(TextBox1.Text)
        End If
    End Sub

    Private Sub b_Copy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Copy2.Click
        If TextBox2.Text = "" Then
            'Si il n'y a pas de code généré, alors on affiche une erreur
            MsgBox("Veuillez d'abord générer un code.", MsgBoxStyle.Exclamation, "Attention : aucun code à copier")
        Else
            'Sinon, on copie le code dans le presse-papiers
            Clipboard.SetText(TextBox2.Text)
        End If
    End Sub

    Private Sub b_OpenImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_OpenImage.Click
        'Si l'utilisateur annule, on quitte
        If Not ofd_OpenImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        imgPath = ofd_OpenImage.FileName()
        openImage()
    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        lbl_Sensitivity.Text = sensitivityText & " " & CDbl(TrackBar1.Value / TrackBar1.Maximum).ToString()

        If imgLoaded Then
            If imgPath = "" Then
                If pb_SavefileSignatureImage.Image Is Nothing Then Exit Sub

                bmp0 = New Bitmap(pb_SavefileSignatureImage.Image)
            Else
                bmp0 = New Bitmap(imgPath)
            End If

            pb_CodeSignatureImage.Image = New Bitmap(BMP2Mono(bmp0, TrackBar1.Value / TrackBar1.Maximum)) 'Met à jour l'aperçu

            pb_CodeSignatureImage.Refresh()
            lbl_Sensitivity.Refresh()

            bmp0.Dispose()
        End If
    End Sub

    Private Sub cb_SplitCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_SplitCode.CheckedChanged
        genVerif() 'Régénère le code en vérifiant si les paramètres le permettent

        'Adapte la zone pour le second code en fonction de l'état de cette CheckBox
        lbl_2ndPart.Enabled() = cb_SplitCode.Checked()
        TextBox2.Enabled() = cb_SplitCode.Checked()
        b_Copy2.Enabled() = cb_SplitCode.Checked()
    End Sub

    Private Sub b_Activ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Activators.Click
        Form2.ShowDialog()
    End Sub

    Private Sub b_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_About.Click
        MsgBox(aboutBoxText, MsgBoxStyle.Information, aboutBoxTitle)
    End Sub

    Private Sub b_Preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Preview.Click
        Form3.ShowDialog()
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As TextBox, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then
            sender.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub b_OpenSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_OpenSave.Click
        If Not ofd_OpenSavefile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        savePath = ofd_OpenSavefile.FileName

        loadSave(savePath)
    End Sub

    Private Sub b_ImportImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ImportImage.Click
        If Not imgLoaded Then
            MsgBox("Il faut d'abord ouvrir une image !", MsgBoxStyle.Critical, "Erreur : aucune image chargée")
            Exit Sub
        End If

        If Not saveLoaded Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        pb_SavefileSignatureImage.Image = New Bitmap(pb_CodeSignatureImage.Image)
    End Sub

    Private Sub b_SaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_SaveAs.Click
        If Not saveLoaded Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        Dim saveFileInfo As New FileInfo(savePath)

        sfd_SaveSavefileAs.InitialDirectory = saveFileInfo.DirectoryName()
        sfd_SaveSavefileAs.FileName = saveFileInfo.Name()

        If Not sfd_SaveSavefileAs.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim dest As String = sfd_SaveSavefileAs.FileName()
        Dim pathOut As String = dest & ".tmp"

        Using savIn As New BinaryReader(New FileStream(savePath, FileMode.Open, FileAccess.Read)), _
              savOut As New BinaryWriter(New FileStream(pathOut, FileMode.Create, FileAccess.ReadWrite)), _
              tmpBR As New BinaryReader(savOut.BaseStream)

            initialOffset = GetOffset(savIn)

            savIn.BaseStream.Seek(initialOffset, SeekOrigin.Begin)

            'Dim save As Byte() = savIn.ReadBytes(If(sav256ko, &H40000, &H80000))
            Dim save As Byte() = savIn.ReadBytes(saveFileInfo.Length() - initialOffset)

            Dim gh As GCHandle = GCHandle.Alloc(save, GCHandleType.Pinned)

            Dim signBytes As Byte() = Image2SignBytes(pb_SavefileSignatureImage.Image)

            Marshal.Copy(signBytes, 0, New IntPtr(gh.AddrOfPinnedObject().ToInt32() + blockOffset + position), &H600)

            gh.Free()

            savOut.Write(save)

            If saveIsBW Then
                '0x1C75A = ChkSum(0x1C100|0x658)
                '0x23F42 = ChkSum(0x1C100|0x658)
                '0x23F9A = ChkSum(0x23F00|0x8C)

                tmpBR.BaseStream.Seek(initialOffset + OffsetsSign.BW, SeekOrigin.Begin)
                Dim bwSignBlockChkSum As UShort = GetCheckSum(tmpBR.ReadBytes(bw_signature_block_size))
                tmpBR.BaseStream.Seek(2, SeekOrigin.Current)
                savOut.Write(bwSignBlockChkSum)
                tmpBR.BaseStream.Seek(initialOffset + bw_footer_signature_chkSum_offset, SeekOrigin.Begin)
                savOut.Write(bwSignBlockChkSum)

                tmpBR.BaseStream.Seek(initialOffset + bw_footer_offset, SeekOrigin.Begin)
                Dim bwFooterChkSum As UShort = GetCheckSum(tmpBR.ReadBytes(bw_footer_size))
                tmpBR.BaseStream.Seek(initialOffset + bw_footer_chkSum_offset, SeekOrigin.Begin)
                savOut.Write(bwFooterChkSum)
            Else
                tmpBR.BaseStream.Seek(initialOffset + blockOffset, SeekOrigin.Begin)

                Dim chkSum As UShort = GetCheckSum(tmpBR.ReadBytes(blockSize))
                tmpBR.BaseStream.Seek(offsetChkSumFooter, SeekOrigin.Current)
                savOut.Write(chkSum)
            End If

            savIn.Close()
            savOut.Flush()
            tmpBR.Close()
            savOut.Close()
        End Using

        If File.Exists(dest) Then
            File.Replace(pathOut, dest, dest & ".BAK", True)
        Else
            File.Move(pathOut, dest)
        End If

        MsgBox("La sauvegarde a bien été modifiée !", MsgBoxStyle.Information, "Enregistrement effectué")
    End Sub

    Private Sub b_ReloadSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ReloadSave.Click
        If Not saveLoaded Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")
            Exit Sub
        End If

        loadSave(savePath)
    End Sub

    Private Sub tsmi_SaveImageAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmi_SaveImageAs.Click
        saveImageAs()
    End Sub

    Private Sub tsmi_LoadImageAbove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmi_LoadImageAbove.Click
        If Not saveLoaded Then
            MsgBox("Il faut d'abord charger une sauvegarde !", MsgBoxStyle.Critical, "Erreur : aucune sauvegarde chargée")

            Exit Sub
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""

        mustGen = False
        pb_CodeSignatureImage.Image = New Bitmap(pb_SavefileSignatureImage.Image)
        imgLoaded = True
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(ByVal sender As ComboBox, ByVal e As System.EventArgs) Handles cmb_Version.SelectedIndexChanged, cmb_Language.SelectedIndexChanged
        If formLoaded Then
            If sender.Equals(cmb_Version) Then
                SetSetting("Game Version", [Enum].GetName(GetType(Versions), cmb_Version.SelectedIndex))
            End If

            'On régénère le code en vérifiant si les paramètres le permettent
            genVerif()
        End If
    End Sub

    Private Sub PictureBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pb_CodeSignatureImage.DragDrop
        Dim fileNames As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
        imgPath = fileNames(0)
        openImage()
    End Sub

    Private Sub PictureBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pb_CodeSignatureImage.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TabPage2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tp_SaveEditor.DragDrop
        Dim fileNames As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
        savePath = fileNames(0)
        loadSave(savePath)
    End Sub

    Private Sub TabPage2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tp_SaveEditor.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub cmb_ProgramLanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ProgramLanguage.SelectedIndexChanged
        If Not formLoaded Then Exit Sub

        SetSetting("Language File", lngFiles(cmb_ProgramLanguage.SelectedIndex).FileName())

        MessageBox.Show("Veuillez relancer le programme pour que la nouvelle langue soit appliquée." & newLine & newLine & "--------" & newLine & newLine & "Please restart the program for the language setting to take effect.", "Veuillez relancer le programme / Please restart the program", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region
End Class
