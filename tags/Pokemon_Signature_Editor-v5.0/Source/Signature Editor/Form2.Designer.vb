<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_Select = New System.Windows.Forms.CheckBox
        Me.cb_Start = New System.Windows.Forms.CheckBox
        Me.cb_R = New System.Windows.Forms.CheckBox
        Me.cb_L = New System.Windows.Forms.CheckBox
        Me.cb_B = New System.Windows.Forms.CheckBox
        Me.cb_Bas = New System.Windows.Forms.CheckBox
        Me.cb_Droite = New System.Windows.Forms.CheckBox
        Me.cb_A = New System.Windows.Forms.CheckBox
        Me.cb_Gauche = New System.Windows.Forms.CheckBox
        Me.cb_Haut = New System.Windows.Forms.CheckBox
        Me.cb_Y = New System.Windows.Forms.CheckBox
        Me.cb_X = New System.Windows.Forms.CheckBox
        Me.b_ToutDecoch = New System.Windows.Forms.Button
        Me.b_Valider = New System.Windows.Forms.Button
        Me.b_Retablir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_Select)
        Me.GroupBox1.Controls.Add(Me.cb_Start)
        Me.GroupBox1.Controls.Add(Me.cb_R)
        Me.GroupBox1.Controls.Add(Me.cb_L)
        Me.GroupBox1.Controls.Add(Me.cb_B)
        Me.GroupBox1.Controls.Add(Me.cb_Bas)
        Me.GroupBox1.Controls.Add(Me.cb_Droite)
        Me.GroupBox1.Controls.Add(Me.cb_A)
        Me.GroupBox1.Controls.Add(Me.cb_Gauche)
        Me.GroupBox1.Controls.Add(Me.cb_Haut)
        Me.GroupBox1.Controls.Add(Me.cb_Y)
        Me.GroupBox1.Controls.Add(Me.cb_X)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cb_Select
        '
        resources.ApplyResources(Me.cb_Select, "cb_Select")
        Me.cb_Select.Name = "cb_Select"
        Me.cb_Select.UseVisualStyleBackColor = True
        '
        'cb_Start
        '
        resources.ApplyResources(Me.cb_Start, "cb_Start")
        Me.cb_Start.Name = "cb_Start"
        Me.cb_Start.UseVisualStyleBackColor = True
        '
        'cb_R
        '
        resources.ApplyResources(Me.cb_R, "cb_R")
        Me.cb_R.Checked = True
        Me.cb_R.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_R.Name = "cb_R"
        Me.cb_R.UseVisualStyleBackColor = True
        '
        'cb_L
        '
        resources.ApplyResources(Me.cb_L, "cb_L")
        Me.cb_L.Checked = True
        Me.cb_L.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_L.Name = "cb_L"
        Me.cb_L.UseVisualStyleBackColor = True
        '
        'cb_B
        '
        resources.ApplyResources(Me.cb_B, "cb_B")
        Me.cb_B.Name = "cb_B"
        Me.cb_B.UseVisualStyleBackColor = True
        '
        'cb_Bas
        '
        resources.ApplyResources(Me.cb_Bas, "cb_Bas")
        Me.cb_Bas.Name = "cb_Bas"
        Me.cb_Bas.UseVisualStyleBackColor = True
        '
        'cb_Droite
        '
        resources.ApplyResources(Me.cb_Droite, "cb_Droite")
        Me.cb_Droite.Name = "cb_Droite"
        Me.cb_Droite.UseVisualStyleBackColor = True
        '
        'cb_A
        '
        resources.ApplyResources(Me.cb_A, "cb_A")
        Me.cb_A.Name = "cb_A"
        Me.cb_A.UseVisualStyleBackColor = True
        '
        'cb_Gauche
        '
        resources.ApplyResources(Me.cb_Gauche, "cb_Gauche")
        Me.cb_Gauche.Name = "cb_Gauche"
        Me.cb_Gauche.UseVisualStyleBackColor = True
        '
        'cb_Haut
        '
        resources.ApplyResources(Me.cb_Haut, "cb_Haut")
        Me.cb_Haut.Name = "cb_Haut"
        Me.cb_Haut.UseVisualStyleBackColor = True
        '
        'cb_Y
        '
        resources.ApplyResources(Me.cb_Y, "cb_Y")
        Me.cb_Y.Name = "cb_Y"
        Me.cb_Y.UseVisualStyleBackColor = True
        '
        'cb_X
        '
        resources.ApplyResources(Me.cb_X, "cb_X")
        Me.cb_X.Name = "cb_X"
        Me.cb_X.UseVisualStyleBackColor = True
        '
        'b_ToutDecoch
        '
        resources.ApplyResources(Me.b_ToutDecoch, "b_ToutDecoch")
        Me.b_ToutDecoch.Name = "b_ToutDecoch"
        Me.b_ToutDecoch.UseVisualStyleBackColor = True
        '
        'b_Valider
        '
        resources.ApplyResources(Me.b_Valider, "b_Valider")
        Me.b_Valider.Name = "b_Valider"
        Me.b_Valider.UseVisualStyleBackColor = True
        '
        'b_Retablir
        '
        resources.ApplyResources(Me.b_Retablir, "b_Retablir")
        Me.b_Retablir.Name = "b_Retablir"
        Me.b_Retablir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AcceptButton = Me.b_Valider
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.b_Retablir)
        Me.Controls.Add(Me.b_Valider)
        Me.Controls.Add(Me.b_ToutDecoch)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Select As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Start As System.Windows.Forms.CheckBox
    Friend WithEvents cb_R As System.Windows.Forms.CheckBox
    Friend WithEvents cb_L As System.Windows.Forms.CheckBox
    Friend WithEvents cb_B As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Bas As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Droite As System.Windows.Forms.CheckBox
    Friend WithEvents cb_A As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Gauche As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Haut As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Y As System.Windows.Forms.CheckBox
    Friend WithEvents cb_X As System.Windows.Forms.CheckBox
    Friend WithEvents b_ToutDecoch As System.Windows.Forms.Button
    Friend WithEvents b_Valider As System.Windows.Forms.Button
    Friend WithEvents b_Retablir As System.Windows.Forms.Button
End Class
