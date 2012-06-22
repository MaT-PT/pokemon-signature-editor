Public Class Form3

    '''Form3.vb
    '''Boîte de dialogue pour la prévisualisation de la signature

    '''Par M@T, pour PokémonTrash.com


    ''Déclaration des variables

    'Image de l'aperçu de la carte de dresseur
    Private bmpTCPreview As Bitmap

    Private imageToUse As New Bitmap(192, 64)

    'Point d'origine de la signature sur l'image de la TCard
    Private orig As Point

    Private animateBW As Boolean = False
    Private secondFrame As Boolean = False

    Friend animateStartText = "Animer !"
    Friend animateStopText = "Arrêter"

    'Couleur de la signature
    Private textColor As System.Drawing.Color ' = Color.FromArgb(TextColors.DPPt)

    Enum TextColors As Integer
        DPPt = -9408400
        HGSS = -12033896
        BW = -13619152
    End Enum


    'Retourne une image Bitmap qui est un aperçu de la signature
    'en fonction de l'image monochrome et du nombre d'étoiles voulu sur la carte de dresseur
    Private Function Preview(ByVal img As Bitmap, ByVal nbStars As Integer) As Bitmap
        If (Form1.tc_Main.SelectedTab.Equals(Form1.tp_CodeGenerator) AndAlso Form1.cmb_Version.SelectedIndex = Form1.Versions.HGSS) OrElse _
           (Form1.tc_Main.SelectedTab.Equals(Form1.tp_SaveEditor) AndAlso Form1.saveVersion = Form1.Versions.HGSS) Then
            'Si la version sélectionnée est HG/SS
            Select Case nbStars
                Case 0
                    bmpTCPreview = My.Resources.TC_HGSS_0s

                Case 1
                    bmpTCPreview = My.Resources.TC_HGSS_1s

                Case 2
                    bmpTCPreview = My.Resources.TC_HGSS_2s

                Case 3
                    bmpTCPreview = My.Resources.TC_HGSS_3s

                Case 4
                    bmpTCPreview = My.Resources.TC_HGSS_4s

                Case 5
                    bmpTCPreview = My.Resources.TC_HGSS_5s

                Case Else 'Si il y a un problème avec la valeur, on choisit 5 étoiles par défaut (ne devrait pas arriver)
                    bmpTCPreview = My.Resources.TC_HGSS_5s
            End Select

            orig = New Point(30, 1)
            'textColor = Color.FromArgb(&H48, &H60, &H98)
            textColor = Color.FromArgb(TextColors.HGSS)
            Me.Size = New Size(282, 147)
            PictureBox1.Size = New Size(252, 71)
            lbl_StarNumber.Location = New Point(229 - lbl_StarNumber.Width, 91)
            NumericUpDown1.Location = New Point(231, 89)

            resetAnimateButton()
        ElseIf (Form1.tc_Main.SelectedTab.Equals(Form1.tp_CodeGenerator) AndAlso (Form1.cmb_Version.SelectedIndex = Form1.Versions.BW OrElse Form1.cmb_Version.SelectedIndex = Form1.Versions.B2W2)) OrElse _
               (Form1.tc_Main.SelectedTab.Equals(Form1.tp_SaveEditor) AndAlso (Form1.saveVersion = Form1.Versions.BW OrElse Form1.saveVersion = Form1.Versions.B2W2)) Then
            'Sinon, si la version sélectionnée est B/W

            If animateBW Then
                If rb_PreviewBlack.Checked Then
                    Select Case nbStars
                        Case 0
                            bmpTCPreview = My.Resources.TC_Black_0s_half

                        Case 1
                            bmpTCPreview = My.Resources.TC_Black_1s_half

                        Case 2
                            bmpTCPreview = My.Resources.TC_Black_2s_half

                        Case 3
                            bmpTCPreview = My.Resources.TC_Black_3s_half

                        Case 4
                            bmpTCPreview = My.Resources.TC_Black_4s_half

                        Case 5
                            bmpTCPreview = My.Resources.TC_Black_5s_half

                        Case Else
                            bmpTCPreview = My.Resources.TC_Black_5s_half
                    End Select
                Else
                    Select Case nbStars
                        Case 0
                            bmpTCPreview = My.Resources.TC_White_0s_half

                        Case 1
                            bmpTCPreview = My.Resources.TC_White_1s_half

                        Case 2
                            bmpTCPreview = My.Resources.TC_White_2s_half

                        Case 3
                            bmpTCPreview = My.Resources.TC_White_3s_half

                        Case 4
                            bmpTCPreview = My.Resources.TC_White_4s_half

                        Case 5
                            bmpTCPreview = My.Resources.TC_White_5s_half

                        Case Else
                            bmpTCPreview = My.Resources.TC_White_5s_half
                    End Select
                End If

                orig = New Point(80, 4)
            Else
                If rb_PreviewBlack.Checked Then
                    Select Case nbStars
                        Case 0
                            bmpTCPreview = My.Resources.TC_Black_0s

                        Case 1
                            bmpTCPreview = My.Resources.TC_Black_1s

                        Case 2
                            bmpTCPreview = My.Resources.TC_Black_2s

                        Case 3
                            bmpTCPreview = My.Resources.TC_Black_3s

                        Case 4
                            bmpTCPreview = My.Resources.TC_Black_4s

                        Case 5
                            bmpTCPreview = My.Resources.TC_Black_5s

                        Case Else
                            bmpTCPreview = My.Resources.TC_Black_5s
                    End Select
                Else
                    Select Case nbStars
                        Case 0
                            bmpTCPreview = My.Resources.TC_White_0s

                        Case 1
                            bmpTCPreview = My.Resources.TC_White_1s

                        Case 2
                            bmpTCPreview = My.Resources.TC_White_2s

                        Case 3
                            bmpTCPreview = My.Resources.TC_White_3s

                        Case 4
                            bmpTCPreview = My.Resources.TC_White_4s

                        Case 5
                            bmpTCPreview = My.Resources.TC_White_5s

                        Case Else
                            bmpTCPreview = My.Resources.TC_White_5s
                    End Select
                End If

                orig = New Point(32, 4)
            End If

            'textColor = Color.FromArgb(&H30, &H30, &H30)
            textColor = Color.FromArgb(TextColors.BW)
            Me.Size = New Size(286, 192)
            PictureBox1.Size = New Size(256, 84)
            lbl_StarNumber.Location = New Point(233 - lbl_StarNumber.Width, 104)
            NumericUpDown1.Location = New Point(235, 102)

            PictureBox2.Visible = True
            lbl_Animate.Visible = True
            gb_BWPreviewVersion.Visible = True
        Else
            'Sinon, c'est pour D/P/Pt
            Select Case nbStars
                Case 0
                    bmpTCPreview = My.Resources.TC_DPPt_0s

                Case 1
                    bmpTCPreview = My.Resources.TC_DPPt_1s

                Case 2
                    bmpTCPreview = My.Resources.TC_DPPt_2s

                Case 3
                    bmpTCPreview = My.Resources.TC_DPPt_3s

                Case 4
                    bmpTCPreview = My.Resources.TC_DPPt_4s

                Case 5
                    bmpTCPreview = My.Resources.TC_DPPt_5s

                Case Else 'Si il y a un problème avec la valeur, on choisit 5 étoiles par défaut (ne devrait pas arriver)
                    bmpTCPreview = My.Resources.TC_DPPt_5s
            End Select

            orig = New Point(25, 6)
            'textColor = Color.FromArgb(&H70, &H70, &H70)
            textColor = Color.FromArgb(TextColors.DPPt)
            Me.Size = New Size(272, 157)
            PictureBox1.Size = New Size(242, 79)
            lbl_StarNumber.Location = New Point(219 - lbl_StarNumber.Width, 99)
            NumericUpDown1.Location = New Point(221, 97)

            resetAnimateButton()
        End If

        If animateBW Then
            If secondFrame Then
                For y As Integer = 0 To img.Height - 1
                    For x As Integer = 0 To img.Width / 2 - 1
                        If img.GetPixel(x + img.Width / 2, y).ToArgb = -16777216 Then
                            'Si le pixel est noir, on le remplace par un pixel de la couleur choisie
                            bmpTCPreview.SetPixel(x + orig.X, y + orig.Y, textColor)
                        End If
                Next x, y
            Else
                For y As Integer = 0 To img.Height - 1
                    For x As Integer = 0 To img.Width / 2 - 1
                        If img.GetPixel(x, y).ToArgb = -16777216 Then
                            'Si le pixel est noir, on le remplace par un pixel de la couleur choisie
                            bmpTCPreview.SetPixel(x + orig.X, y + orig.Y, textColor)
                        End If
                Next x, y
            End If
        Else
            For y As Integer = 0 To img.Height - 1
                For x As Integer = 0 To img.Width - 1
                    If img.GetPixel(x, y).ToArgb = -16777216 Then
                        'Si le pixel est noir, on le remplace par un pixel de la couleur choisie
                        bmpTCPreview.SetPixel(x + orig.X, y + orig.Y, textColor)
                    End If
            Next x, y
        End If

        img.Dispose()

        Preview = DirectCast(bmpTCPreview.Clone, Bitmap)

        bmpTCPreview.Dispose()
    End Function

    Private Sub refreshPreview()
        PictureBox1.Image = Preview(imageToUse.Clone(), NumericUpDown1.Value)
    End Sub

    Private Sub resetAnimateButton()
        PictureBox2.Visible = False
        lbl_Animate.Visible = False
        gb_BWPreviewVersion.Visible = False
        PictureBox2.Image = My.Resources.Play
        lbl_Animate.Text = animateStartText
        animateBW = False
        Timer1.Enabled = False
    End Sub

    Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Timer1.Enabled = False
        imageToUse.Dispose()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.tc_Main.SelectedTab.Equals(Form1.tp_CodeGenerator) Then
            If Form1.imgLoaded Then
                imageToUse = DirectCast(Form1.pb_CodeSignatureImage.Image.Clone(), Bitmap)
            Else
                imageToUse = New Bitmap(192, 64)
            End If
        ElseIf Form1.tc_Main.SelectedTab.Equals(Form1.tp_SaveEditor) Then
            If Form1.saveLoaded Then
                imageToUse = DirectCast(Form1.pb_SavefileSignatureImage.Image.Clone(), Bitmap)
            Else
                imageToUse = New Bitmap(192, 64)
            End If
        Else
            'MsgBox("Fallback")
            If Form1.imgLoaded Then
                imageToUse = DirectCast(Form1.pb_CodeSignatureImage.Image.Clone(), Bitmap)
            Else
                imageToUse = New Bitmap(192, 64)
            End If
        End If


        secondFrame = False

        refreshPreview()

        If animateBW Then
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        refreshPreview()
    End Sub

    Private Sub Form3_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Si la touche Echap est pressée, on ferme le formulaire
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox2.MouseDown
        If Not e.Button = Windows.Forms.MouseButtons.Left Then Exit Sub

        If animateBW Then
            PictureBox2.Image = My.Resources.Pause_Pressed
        Else
            PictureBox2.Image = My.Resources.Play_Pressed
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox2.MouseUp
        If Not e.Button = Windows.Forms.MouseButtons.Left Then Exit Sub

        If animateBW Then
            PictureBox2.Image = My.Resources.Play
            lbl_Animate.Text = animateStartText
            Timer1.Enabled = False
            animateBW = False
            secondFrame = False
        Else
            PictureBox2.Image = My.Resources.Pause
            lbl_Animate.Text = animateStopText
            Timer1.Enabled = True
            animateBW = True
        End If

        refreshPreview()
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        If animateBW Then
            PictureBox2.Image = My.Resources.Pause
        Else
            PictureBox2.Image = My.Resources.Play
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not animateBW Then
            Timer1.Enabled = False
            Exit Sub
        End If

        If secondFrame Then
            secondFrame = False
        Else
            secondFrame = True
        End If

        refreshPreview()
    End Sub

    Private Sub rb_PreviewBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_PreviewBlack.CheckedChanged
        refreshPreview()
    End Sub
End Class

