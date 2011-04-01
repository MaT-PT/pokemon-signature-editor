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
        Me.gb_ActivatorList = New System.Windows.Forms.GroupBox
        Me.cb_Select = New System.Windows.Forms.CheckBox
        Me.cb_Start = New System.Windows.Forms.CheckBox
        Me.cb_R = New System.Windows.Forms.CheckBox
        Me.cb_L = New System.Windows.Forms.CheckBox
        Me.cb_B = New System.Windows.Forms.CheckBox
        Me.cb_Down = New System.Windows.Forms.CheckBox
        Me.cb_Right = New System.Windows.Forms.CheckBox
        Me.cb_A = New System.Windows.Forms.CheckBox
        Me.cb_Left = New System.Windows.Forms.CheckBox
        Me.cb_Up = New System.Windows.Forms.CheckBox
        Me.cb_Y = New System.Windows.Forms.CheckBox
        Me.cb_X = New System.Windows.Forms.CheckBox
        Me.b_UncheckAll = New System.Windows.Forms.Button
        Me.b_Validate = New System.Windows.Forms.Button
        Me.b_Reset = New System.Windows.Forms.Button
        Me.gb_ActivatorList.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_ActivatorList
        '
        Me.gb_ActivatorList.Controls.Add(Me.cb_Select)
        Me.gb_ActivatorList.Controls.Add(Me.cb_Start)
        Me.gb_ActivatorList.Controls.Add(Me.cb_R)
        Me.gb_ActivatorList.Controls.Add(Me.cb_L)
        Me.gb_ActivatorList.Controls.Add(Me.cb_B)
        Me.gb_ActivatorList.Controls.Add(Me.cb_Down)
        Me.gb_ActivatorList.Controls.Add(Me.cb_Right)
        Me.gb_ActivatorList.Controls.Add(Me.cb_A)
        Me.gb_ActivatorList.Controls.Add(Me.cb_Left)
        Me.gb_ActivatorList.Controls.Add(Me.cb_Up)
        Me.gb_ActivatorList.Controls.Add(Me.cb_Y)
        Me.gb_ActivatorList.Controls.Add(Me.cb_X)
        resources.ApplyResources(Me.gb_ActivatorList, "gb_ActivatorList")
        Me.gb_ActivatorList.Name = "gb_ActivatorList"
        Me.gb_ActivatorList.TabStop = False
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
        'cb_Down
        '
        resources.ApplyResources(Me.cb_Down, "cb_Down")
        Me.cb_Down.Name = "cb_Down"
        Me.cb_Down.UseVisualStyleBackColor = True
        '
        'cb_Right
        '
        resources.ApplyResources(Me.cb_Right, "cb_Right")
        Me.cb_Right.Name = "cb_Right"
        Me.cb_Right.UseVisualStyleBackColor = True
        '
        'cb_A
        '
        resources.ApplyResources(Me.cb_A, "cb_A")
        Me.cb_A.Name = "cb_A"
        Me.cb_A.UseVisualStyleBackColor = True
        '
        'cb_Left
        '
        resources.ApplyResources(Me.cb_Left, "cb_Left")
        Me.cb_Left.Name = "cb_Left"
        Me.cb_Left.UseVisualStyleBackColor = True
        '
        'cb_Up
        '
        resources.ApplyResources(Me.cb_Up, "cb_Up")
        Me.cb_Up.Name = "cb_Up"
        Me.cb_Up.UseVisualStyleBackColor = True
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
        'b_UncheckAll
        '
        resources.ApplyResources(Me.b_UncheckAll, "b_UncheckAll")
        Me.b_UncheckAll.Name = "b_UncheckAll"
        Me.b_UncheckAll.UseVisualStyleBackColor = True
        '
        'b_Validate
        '
        resources.ApplyResources(Me.b_Validate, "b_Validate")
        Me.b_Validate.Name = "b_Validate"
        Me.b_Validate.UseVisualStyleBackColor = True
        '
        'b_Reset
        '
        resources.ApplyResources(Me.b_Reset, "b_Reset")
        Me.b_Reset.Name = "b_Reset"
        Me.b_Reset.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AcceptButton = Me.b_Validate
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.b_Reset)
        Me.Controls.Add(Me.b_Validate)
        Me.Controls.Add(Me.b_UncheckAll)
        Me.Controls.Add(Me.gb_ActivatorList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.gb_ActivatorList.ResumeLayout(False)
        Me.gb_ActivatorList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_ActivatorList As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Select As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Start As System.Windows.Forms.CheckBox
    Friend WithEvents cb_R As System.Windows.Forms.CheckBox
    Friend WithEvents cb_L As System.Windows.Forms.CheckBox
    Friend WithEvents cb_B As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Down As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Right As System.Windows.Forms.CheckBox
    Friend WithEvents cb_A As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Left As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Up As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Y As System.Windows.Forms.CheckBox
    Friend WithEvents cb_X As System.Windows.Forms.CheckBox
    Friend WithEvents b_UncheckAll As System.Windows.Forms.Button
    Friend WithEvents b_Validate As System.Windows.Forms.Button
    Friend WithEvents b_Reset As System.Windows.Forms.Button
End Class
