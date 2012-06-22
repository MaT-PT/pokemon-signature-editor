<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.lbl_StarNumber = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Animate = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gb_BWPreviewVersion = New System.Windows.Forms.GroupBox
        Me.rb_PreviewWhite = New System.Windows.Forms.RadioButton
        Me.rb_PreviewBlack = New System.Windows.Forms.RadioButton
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_BWPreviewVersion.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(235, 102)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(33, 20)
        Me.NumericUpDown1.TabIndex = 1
        '
        'lbl_StarNumber
        '
        Me.lbl_StarNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_StarNumber.AutoSize = True
        Me.lbl_StarNumber.Location = New System.Drawing.Point(142, 104)
        Me.lbl_StarNumber.Name = "lbl_StarNumber"
        Me.lbl_StarNumber.Size = New System.Drawing.Size(91, 13)
        Me.lbl_StarNumber.TabIndex = 2
        Me.lbl_StarNumber.Text = "Nombre d'étoiles :"
        Me.lbl_StarNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 345
        '
        'lbl_Animate
        '
        Me.lbl_Animate.AutoSize = True
        Me.lbl_Animate.Location = New System.Drawing.Point(38, 104)
        Me.lbl_Animate.Name = "lbl_Animate"
        Me.lbl_Animate.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Animate.TabIndex = 4
        Me.lbl_Animate.Text = "Animer !"
        Me.lbl_Animate.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Signature_Editor.My.Resources.Resources.Play
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(12, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 84)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gb_BWPreviewVersion
        '
        Me.gb_BWPreviewVersion.Controls.Add(Me.rb_PreviewBlack)
        Me.gb_BWPreviewVersion.Controls.Add(Me.rb_PreviewWhite)
        Me.gb_BWPreviewVersion.Location = New System.Drawing.Point(74, 120)
        Me.gb_BWPreviewVersion.Name = "gb_BWPreviewVersion"
        Me.gb_BWPreviewVersion.Size = New System.Drawing.Size(132, 42)
        Me.gb_BWPreviewVersion.TabIndex = 5
        Me.gb_BWPreviewVersion.TabStop = False
        Me.gb_BWPreviewVersion.Text = "Version"
        '
        'rb_PreviewWhite
        '
        Me.rb_PreviewWhite.AutoSize = True
        Me.rb_PreviewWhite.Location = New System.Drawing.Point(62, 19)
        Me.rb_PreviewWhite.Name = "rb_PreviewWhite"
        Me.rb_PreviewWhite.Size = New System.Drawing.Size(64, 17)
        Me.rb_PreviewWhite.TabIndex = 1
        Me.rb_PreviewWhite.TabStop = True
        Me.rb_PreviewWhite.Text = "Blanche"
        Me.rb_PreviewWhite.UseVisualStyleBackColor = True
        '
        'rb_PreviewBlack
        '
        Me.rb_PreviewBlack.AutoSize = True
        Me.rb_PreviewBlack.Checked = True
        Me.rb_PreviewBlack.Location = New System.Drawing.Point(6, 19)
        Me.rb_PreviewBlack.Name = "rb_PreviewBlack"
        Me.rb_PreviewBlack.Size = New System.Drawing.Size(50, 17)
        Me.rb_PreviewBlack.TabIndex = 0
        Me.rb_PreviewBlack.TabStop = True
        Me.rb_PreviewBlack.Text = "Noire"
        Me.rb_PreviewBlack.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 166)
        Me.Controls.Add(Me.lbl_Animate)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.gb_BWPreviewVersion)
        Me.Controls.Add(Me.lbl_StarNumber)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aperçu de la signature"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_BWPreviewVersion.ResumeLayout(False)
        Me.gb_BWPreviewVersion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_StarNumber As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Animate As System.Windows.Forms.Label
    Friend WithEvents gb_BWPreviewVersion As System.Windows.Forms.GroupBox
    Friend WithEvents rb_PreviewWhite As System.Windows.Forms.RadioButton
    Friend WithEvents rb_PreviewBlack As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
