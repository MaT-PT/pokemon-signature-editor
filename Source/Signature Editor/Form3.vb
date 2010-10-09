Public Class Form3

    'Form3.vb
    'Boîte de dialogue pour la prévisualisation de la signature

    'Par M@T, pour PokémonTrash.com


    'Déclaration des variables

    'Image de l'aperçu
    Dim bmp_preview As Bitmap

    'Point origine de la signature sur l'image de la TCard
    Dim orig As Point

    'Couleur de la signature
    Private textColor As System.Drawing.Color = Color.FromArgb(TextColors.DPPt)

    Enum TextColors As Integer
        DPPt = -9408400
        HGSS = -12033896
        BW = -13619152
    End Enum


    'Retourne image Bitmap qui est un aperçu de la signature
    'en fonction de l'image monochrome et du nombre d'étoiles voulu sur la carte de dresseur
    Private Function Preview(ByVal img As Bitmap, ByVal nbStars As Integer) As Bitmap
        If (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage1) AndAlso Form1.ComboBox1.SelectedIndex = Form1.VersionsAR.HGSS) OrElse _
           (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage2) AndAlso Form1.saveVersion = Form1.SaveVersions.HGSS) Then
            'Si la version sélectionnée est HG/SS
            Select Case nbStars
                Case 0
                    bmp_preview = My.Resources.Signature_0e_HGSS

                Case 1
                    bmp_preview = My.Resources.Signature_1e_HGSS

                Case 2
                    bmp_preview = My.Resources.Signature_2e_HGSS

                Case 3
                    bmp_preview = My.Resources.Signature_3e_HGSS

                Case 4
                    bmp_preview = My.Resources.Signature_4e_HGSS

                Case 5
                    bmp_preview = My.Resources.Signature_5e_HGSS

                Case Else 'Si il y a un problème avec la valeur, on choisit 5 étoiles par défaut (ne devrait pas arriver)
                    bmp_preview = My.Resources.Signature_5e_HGSS
            End Select

            orig = New Point(30, 1)
            'textColor = Color.FromArgb(&H48, &H60, &H98)
            textColor = Color.FromArgb(TextColors.HGSS)
            Me.Size = New Size(282, 147)
            PictureBox1.Size = New Size(252, 71)
            Label1.Location = New Point(134, 91)
            NumericUpDown1.Location = New Point(231, 89)

        ElseIf (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage1) AndAlso (Form1.ComboBox1.SelectedIndex = Form1.VersionsAR.BLACK OrElse Form1.ComboBox1.SelectedIndex = Form1.VersionsAR.WHITE)) OrElse _
               (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage2) AndAlso Form1.saveVersion = Form1.SaveVersions.BW) Then
            'Sinon, si la version sélectionnée est B/W
            Select Case nbStars
                Case 0
                    bmp_preview = My.Resources.Signature_0e_BW

                Case 1
                    bmp_preview = My.Resources.Signature_0e_BW

                Case 2
                    bmp_preview = My.Resources.Signature_0e_BW

                Case 3
                    bmp_preview = My.Resources.Signature_0e_BW

                Case 4
                    bmp_preview = My.Resources.Signature_0e_BW

                Case 5
                    bmp_preview = My.Resources.Signature_0e_BW

                Case Else 'Si il y a un problème avec la valeur, on choisit 5 étoiles par défaut (ne devrait pas arriver)
                    bmp_preview = My.Resources.Signature_0e_BW
            End Select

            orig = New Point(25, 4)
            'textColor = Color.FromArgb(&H30, &H30, &H30)
            textColor = Color.FromArgb(TextColors.BW)
            Me.Size = New Size(272, 155)
            PictureBox1.Size = New Size(242, 77)
            Label1.Location = New Point(124, 97)
            NumericUpDown1.Location = New Point(221, 95)
        Else
            'Sinon, c'est pour D/P/Pt
            Select Case nbStars
                Case 0
                    bmp_preview = My.Resources.Signature_0e

                Case 1
                    bmp_preview = My.Resources.Signature_1e

                Case 2
                    bmp_preview = My.Resources.Signature_2e

                Case 3
                    bmp_preview = My.Resources.Signature_3e

                Case 4
                    bmp_preview = My.Resources.Signature_4e

                Case 5
                    bmp_preview = My.Resources.Signature_5e

                Case Else 'Si il y a un problème avec la valeur, on choisit 5 étoiles par défaut (ne devrait pas arriver)
                    bmp_preview = My.Resources.Signature_5e
            End Select

            orig = New Point(25, 6)
            'textColor = Color.FromArgb(&H70, &H70, &H70)
            textColor = Color.FromArgb(TextColors.DPPt)
            Me.Size = New Size(272, 157)
            PictureBox1.Size = New Size(242, 79)
            Label1.Location = New Point(124, 99)
            NumericUpDown1.Location = New Point(221, 97)
        End If

        'Parcourt les pixels de l'image
        For y = 0 To img.Height - 1
            For x = 0 To img.Width - 1
                If img.GetPixel(x, y).ToArgb = -16777216 Then
                    'Si le pixel est noir, on le remplace par un pixel de la couleur choisie
                    bmp_preview.SetPixel(x + orig.X, y + orig.Y, textColor)
                End If
        Next x, y

        'Libération des ressources
        img.Dispose()

        'On définit la valeur de cette fonction comme une copie de l'image d'aperçu
        Preview = DirectCast(bmp_preview.Clone, Bitmap)

        'Libération des ressources
        bmp_preview.Dispose()
    End Function

    'Rafraîchit l'aperçu si une image a été chargée dans la fenêtre principale, sinon utilise une image vide
    Private Sub rafraichir()
        If Form1.imgLoaded Then
            PictureBox1.Image = Preview(DirectCast(Form1.PictureBox1.Image.Clone, Bitmap), NumericUpDown1.Value)
        Else
            PictureBox1.Image = Preview(New Bitmap(192, 64), NumericUpDown1.Value)
        End If
    End Sub

    'À l'affichage de ce formulaire
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'B/W only in beta state :
        If (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage1) AndAlso (Form1.ComboBox1.SelectedIndex = Form1.VersionsAR.BLACK OrElse Form1.ComboBox1.SelectedIndex = Form1.VersionsAR.WHITE)) OrElse _
               (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage2) AndAlso Form1.saveVersion = Form1.SaveVersions.BW) Then
            NumericUpDown1.Value = 0
            NumericUpDown1.Enabled = False
        Else
            NumericUpDown1.Enabled = True
        End If

        'On rafraîchit l'aperçu
        rafraichir()
    End Sub

    'Lorsque le nombre d'étoiles est modifié
    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        'On rafraîchit l'aperçu
        rafraichir()
    End Sub

    'Quand une touche du clavier est pressée
    Private Sub Form3_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Si la touche Echap est pressée, on ferme le formulaire
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
End Class