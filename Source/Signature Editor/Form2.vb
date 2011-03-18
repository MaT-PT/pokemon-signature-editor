Public Class Form2

    '''Form2.vb
    '''Boîte de dialogue pour les activateurs du code

    '''Par M@T, pour PokémonTrash


    ''Déclaration des variables :

    Dim newLine As String = Environment.NewLine()

    'Énumérateur pour les différentes valeurs des touches
    Private Enum NDSKeys
        NONE = &HFFFF
        UP = &HFFBF
        DOWN = &HFF7F
        LEFT = &HFFDF
        RIGHT = &HFFEF
        A = &HFFFE
        B = &HFFFD
        X = &HFFFE
        Y = &HFFFD
        L = &HFDFF
        R = &HFEFF
        START = &HFFF7
        SELEC = &HFFFB
    End Enum

    'Activateur par défaut
    Dim triggerCode As Integer = NDSKeys.L And NDSKeys.R

    'Liste de l'état des CheckBox
    Dim controlsState As New List(Of Boolean)

    'Renvoie la partie du code correspondant à l'activateur en fonction des touches sélectionnées
    Private Function TriggersCode() As String
        TriggersCode = ""

        If cb_A.Checked OrElse cb_B.Checked OrElse _
           cb_Haut.Checked OrElse cb_Bas.Checked OrElse _
           cb_Droite.Checked OrElse cb_Gauche.Checked OrElse _
           cb_L.Checked OrElse cb_R.Checked OrElse _
           cb_Select.Checked OrElse cb_Start.Checked Then

            'Si une touche autre que X ou Y est sélectionnée (touches GBA),
            'on calcule le code hexa correspondant à l'ensemble des touches sélectionnées grâce à l'opération binaire "And".
            triggerCode = NDSKeys.NONE
            triggerCode = triggerCode And If(cb_Haut.Checked, NDSKeys.UP, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_Bas.Checked, NDSKeys.DOWN, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_Gauche.Checked, NDSKeys.LEFT, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_Droite.Checked, NDSKeys.RIGHT, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_A.Checked, NDSKeys.A, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_B.Checked, NDSKeys.B, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_L.Checked, NDSKeys.L, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_R.Checked, NDSKeys.R, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_Start.Checked, NDSKeys.START, NDSKeys.NONE)
            triggerCode = triggerCode And If(cb_Select.Checked, NDSKeys.SELEC, NDSKeys.NONE)

            TriggersCode = "94000130 " & triggerCode.ToString("X4") & "0000" & newLine
        End If

        If cb_X.Checked OrElse cb_Y.Checked Then
            'Si la touche X ou Y est sélectionnée (touches NDS), on fait de même en modifiant l'adresse mémoire
            TriggersCode &= "94000136 " & _
                            CInt((If(cb_X.Checked, NDSKeys.X, NDSKeys.NONE) And _
                                  If(cb_Y.Checked, NDSKeys.Y, NDSKeys.NONE))).ToString("X4") & _
                            "0000" & newLine
        End If
    End Function

    'Renvoie le nom des touches sélectionnées
    Private Function ReadTriggers() As String
        ReadTriggers = ""

        For Each cb As CheckBox In GroupBox1.Controls
            If cb.Checked Then
                'Si la CheckBox est cochée, on ajoute son nom au début de la chaîne résultat
                ReadTriggers = cb.Text & "+" & ReadTriggers
            End If
        Next cb

        If ReadTriggers.Length > 0 Then
            'Si le résultat n'est pas vide, on renvoie la chaîne sans le "+" final
            ReadTriggers = ReadTriggers.Substring(0, ReadTriggers.LastIndexOf("+"))
        Else
            ReadTriggers = "aucune touche"
        End If
    End Function

    'Rétablit les CheckBox telles qu'à l'affichage du formulaire
    Private Sub resetTriggers()
        Dim n As Integer = 0

        For Each cb As CheckBox In GroupBox1.Controls
            cb.Checked = controlsState(n)
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
        controlsState.Clear()

        'Parcourt les CheckBox et ajoute leur état à la liste controlsState
        For Each cb As CheckBox In GroupBox1.Controls
            controlsState.Add(cb.Checked)
        Next

        'Met à jour la chaîne correspondant aux activateurs du code sur le formulaire principal
        Form1.codeTrigger = TriggersCode()

        Form1.genVerif()

        'Met à jour l'info-bulle indiquant les touches à presser
        Form1.ToolTip1.SetToolTip(Form1.b_Activ, ReadTriggers)

        Me.Close()
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Rétablit les contrôles comme ils sont définis :
        '  Si l'utilisateur a validé, ils ne changeront pas
        '  Si il a quitté sans valider, ils seront rétablis comme ils étaient à l'affichage du formulaire
        resetTriggers()
    End Sub

    Private Sub Form2_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Si la touche Echap est pressée, on ferme le formulaire
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sélectionne le bouton de validation
        b_Valider.Select()

        'Réinitialise la liste de l'état des CheckBox
        controlsState.Clear()

        'Parcourt les CheckBox et ajoute leur état à la liste etatControles
        For Each cb As CheckBox In GroupBox1.Controls
            controlsState.Add(cb.Checked)
        Next
    End Sub

    Private Sub b_Retablir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Retablir.Click
        'Rétablit l'état des contrôles comme ils étaient à l'affichage du formulaire
        resetTriggers()
    End Sub
End Class