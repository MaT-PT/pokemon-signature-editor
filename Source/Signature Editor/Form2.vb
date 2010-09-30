Public Class Form2

    'Form2.vb
    'Boîte de dialogue pour les activateurs du code

    'Par M@T, pour PokémonTrash


    'Déclaration des variables :

    'Énumérateur pour les différentes valeurs des touches
    Private Enum Touches
        RIEN = &HFFFF
        HAUT = &HFFBF
        BAS = &HFF7F
        GAUCHE = &HFFDF
        DROITE = &HFFEF
        A = &HFFFE
        B = &HFFFD
        X = &HFFFE
        Y = &HFFFD
        L = &HFDFF
        R = &HFEFF
        START = &HFFF7
        SELEC = &HFFFB
    End Enum

    'Définition de la touche par défaut
    Dim codeTouche As Integer = Touches.L And Touches.R

    'Définition de la liste de l'état des CheckBox
    Dim etatControles As New List(Of Boolean)

    'Renvoie la partie du code correspondant à l'activateur en fonction des touches sélectionnées
    Private Function CodeTouches() As String
        CodeTouches = ""

        If cb_A.Checked OrElse _
           cb_B.Checked OrElse _
           cb_Bas.Checked OrElse _
           cb_Droite.Checked OrElse _
           cb_Gauche.Checked OrElse _
           cb_Haut.Checked OrElse _
           cb_L.Checked OrElse _
           cb_R.Checked OrElse _
           cb_Select.Checked OrElse _
           cb_Start.Checked Then

            'Si une touche autre que X ou Y est sélectionnée (touches GBA),
            'on calcule le code hexa correspondant à l'ensemble des touches sélectionnées
            'grâce à l'opération binaire "And"
            codeTouche = Touches.RIEN
            codeTouche = codeTouche And If(cb_Haut.Checked, Touches.HAUT, Touches.RIEN)
            codeTouche = codeTouche And If(cb_Bas.Checked, Touches.BAS, Touches.RIEN)
            codeTouche = codeTouche And If(cb_Gauche.Checked, Touches.GAUCHE, Touches.RIEN)
            codeTouche = codeTouche And If(cb_Droite.Checked, Touches.DROITE, Touches.RIEN)
            codeTouche = codeTouche And If(cb_A.Checked, Touches.A, Touches.RIEN)
            codeTouche = codeTouche And If(cb_B.Checked, Touches.B, Touches.RIEN)
            codeTouche = codeTouche And If(cb_L.Checked, Touches.L, Touches.RIEN)
            codeTouche = codeTouche And If(cb_R.Checked, Touches.R, Touches.RIEN)
            codeTouche = codeTouche And If(cb_Start.Checked, Touches.START, Touches.RIEN)
            codeTouche = codeTouche And If(cb_Select.Checked, Touches.SELEC, Touches.RIEN)
            CodeTouches = "94000130 " & Hex(codeTouche) & "0000" & vbCrLf
        End If

        If cb_X.Checked OrElse cb_Y.Checked Then
            'Si la touche X ou Y est sélectionnée (touches NDS), on fait de même en modifiant l'adresse mémoire
            CodeTouches &= "94000136 " & _
                           Hex(If(cb_X.Checked, Touches.X, Touches.RIEN) And _
                               If(cb_Y.Checked, Touches.Y, Touches.RIEN)) & _
                           "0000" & vbCrLf
        End If
    End Function

    'Renvoie le nom des touches sélectionnées
    Private Function LireTouches() As String
        LireTouches = ""

        'Parcourt les contrôles de GroupBox1
        For Each cb As CheckBox In GroupBox1.Controls
            If cb.Checked Then
                'Si la CheckBox est cochée, on ajoute son nom au début de la chaîne résultat
                LireTouches = cb.Text & "+" & LireTouches
            End If
        Next cb

        If LireTouches.Length > 0 Then
            'Si le résultat n'est pas vide, on renvoie la chaîne sans le "+" final
            LireTouches = LireTouches.Substring(0, LireTouches.LastIndexOf("+"))
        Else
            'Sinon, on renvoie "aucune touche"
            LireTouches = "aucune touche"
        End If
    End Function

    'Rétablit les CheckBox telles qu'à l'affichage du formulaire
    Private Sub retablir()
        Dim n As Integer = 0

        For Each cb As CheckBox In GroupBox1.Controls
            cb.Checked = etatControles(n)
            n += 1
        Next
    End Sub

    'Vérifie que l'on n'a pas les touches Gauche et Droite de sélectionnées en même temps
    Private Sub cb_Droite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Droite.CheckedChanged
        If cb_Gauche.Checked And cb_Droite.Checked Then cb_Gauche.Checked = False
    End Sub

    Private Sub cb_Gauche_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Gauche.CheckedChanged
        If cb_Gauche.Checked And cb_Droite.Checked Then cb_Droite.Checked = False
    End Sub

    'Vérifie que l'on n'a pas les touches Haut et Bas de sélectionnées en même temps
    Private Sub cb_Haut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Haut.CheckedChanged
        If cb_Haut.Checked And cb_Bas.Checked Then cb_Bas.Checked = False
    End Sub

    Private Sub cb_Bas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Bas.CheckedChanged
        If cb_Haut.Checked And cb_Bas.Checked Then cb_Haut.Checked = False
    End Sub

    'Décoche toutes les CheckBox
    Private Sub b_ToutDecoch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ToutDecoch.Click
        For Each cb As CheckBox In GroupBox1.Controls
            cb.Checked = False
        Next cb
    End Sub

    'Quand le bouton "Valider" est cliqué
    Private Sub b_Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Valider.Click
        'Réinitialise la liste de l'état des CheckBox
        etatControles.Clear()

        'Parcourt les CheckBox et ajoute leur état à la liste etatControles
        For Each cb As CheckBox In GroupBox1.Controls
            etatControles.Add(cb.Checked)
        Next

        'Met à jour la chaîne correspondant aux activateurs du code sur le formulaire principal
        Form1.activateur = CodeTouches()

        'Génère le code si besoin
        Form1.genVerif()

        'Met à jour l'info-bulle indiquant les touches à presser
        Form1.ToolTip1.SetToolTip(Form1.b_Activ, LireTouches)

        'Ferme le formulaire
        Me.Close()
    End Sub

    'À la fermeture du formulaire
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'On rétablit les contrôles comme ils sont définis :
        'Si l'utilisateur a validé, ils ne changeront pas
        'si il a quitté sans valider, ils seront rétablis comme ils étaient à l'affichage du formulaire
        retablir()
    End Sub

    'Quand une touche du clavier est pressée
    Private Sub Form2_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Si la touche Echap est pressée, on ferme le formulaire
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    'À l'affichage du formulaire
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sélectionne le bouton de validation
        b_Valider.Select()

        'Réinitialise la liste de l'état des CheckBox
        etatControles.Clear()

        'Parcourt les CheckBox et ajoute leur état à la liste etatControles
        For Each cb As CheckBox In GroupBox1.Controls
            etatControles.Add(cb.Checked)
        Next
    End Sub

    'Quand le bouton "Rétablir" est cliqué
    Private Sub b_Retablir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Retablir.Click
        'On rétablit l'état des contrôles comme ils étaient à l'affichage du formulaire
        retablir()
    End Sub
End Class