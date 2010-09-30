Public Class Form3

    'Form3.vb
    'Boîte de dialogue pour la prévisualisation de la signature

    'Par M@T, pour PokémonTrash


    'Déclaration des variables

    'Image de l'aperçu
    Dim bmp_apercu As Bitmap

    'Point origine de la signature sur l'image de la TCard
    Dim orig As Point

    'Couleur de la signature
    Private COULEUR_SIGNATURE As System.Drawing.Color = Color.FromArgb(112, 112, 112)


    'Retourne image Bitmap qui est un aperçu de la signature
    'en fonction de l'image monochrome et du nombre d'étoiles voulu sur la carte de dresseur
    Private Function Apercu(ByVal img As Bitmap, ByVal nb_etoiles As Integer) As Bitmap
        If (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage1) AndAlso Form1.rb_HGSS.Checked) OrElse _
           (Form1.TabControl1.SelectedTab.Equals(Form1.TabPage2) AndAlso Form1.Version_sav = Form1.Version.HGSS) Then
            'Si la version sélectionnée est HG/SS
            Select Case nb_etoiles
                Case 0
                    bmp_apercu = My.Resources.Signature_0e_HGSS

                Case 1
                    bmp_apercu = My.Resources.Signature_1e_HGSS

                Case 2
                    bmp_apercu = My.Resources.Signature_2e_HGSS

                Case 3
                    bmp_apercu = My.Resources.Signature_3e_HGSS

                Case 4
                    bmp_apercu = My.Resources.Signature_4e_HGSS

                Case 5
                    bmp_apercu = My.Resources.Signature_5e_HGSS

                Case Else 'Si il y a un problème avec la valeur, on choisit 5 étoiles par défaut (ne devrait pas arriver)
                    bmp_apercu = My.Resources.Signature_5e_HGSS
            End Select

            orig = New Point(30, 1)
            COULEUR_SIGNATURE = Color.FromArgb(72, 96, 152)
            Size = New Size(282, 147)
            PictureBox1.Size = New Size(252, 71)
            Label1.Location = New Point(134, 91)
            NumericUpDown1.Location = New Point(231, 89)
        Else
            'Sinon, on choisit un cadre en fonction du nombre d'étoiles
            Select Case nb_etoiles
                Case 0
                    bmp_apercu = My.Resources.Signature_0e

                Case 1
                    bmp_apercu = My.Resources.Signature_1e

                Case 2
                    bmp_apercu = My.Resources.Signature_2e

                Case 3
                    bmp_apercu = My.Resources.Signature_3e

                Case 4
                    bmp_apercu = My.Resources.Signature_4e

                Case 5
                    bmp_apercu = My.Resources.Signature_5e

                Case Else 'Si il y a un problème avec la valeur, on choisit 5 étoiles par défaut (ne devrait pas arriver)
                    bmp_apercu = My.Resources.Signature_5e
            End Select

            orig = New Point(25, 6)
            COULEUR_SIGNATURE = Color.FromArgb(112, 112, 112)
            Size = New Size(272, 155)
            PictureBox1.Size = New Size(242, 79)
            Label1.Location = New Point(124, 99)
            NumericUpDown1.Location = New Point(221, 97)
        End If

        'Parcourt les pixels de l'image
        For y = 0 To img.Height - 1
            For x = 0 To img.Width - 1
                If img.GetPixel(x, y).ToArgb = -16777216 Then
                    'Si le pixel est noir, on le remplace par un pixel de la couleur choisie
                    bmp_apercu.SetPixel(x + orig.X, y + orig.Y, COULEUR_SIGNATURE)
                End If
        Next x, y

        'Libération des ressources
        img.Dispose()

        'On définit la valeur de cette fonction comme une copie de l'image d'aperçu
        Apercu = DirectCast(bmp_apercu.Clone, Bitmap)

        'Libération des ressources
        bmp_apercu.Dispose()
    End Function

    'Rafraîchit l'aperçu si une image a été chargée dans la fenêtre principale, utilise une image vide
    Private Sub rafraichir()
        If Form1.imgChargee Then
            PictureBox1.Image = Apercu(DirectCast(Form1.PictureBox1.Image.Clone, Bitmap), NumericUpDown1.Value)
        Else
            PictureBox1.Image = Apercu(New Bitmap(192, 64), NumericUpDown1.Value)
        End If
    End Sub

    'À l'affichage de ce formulaire
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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