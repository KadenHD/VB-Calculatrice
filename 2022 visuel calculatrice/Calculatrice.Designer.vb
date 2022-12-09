<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Calculatrice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Calculatrice))
        Me.TB_Affichage = New System.Windows.Forms.TextBox()
        Me.BT_0 = New System.Windows.Forms.Button()
        Me.BT_Virgule = New System.Windows.Forms.Button()
        Me.BT_Egal = New System.Windows.Forms.Button()
        Me.BT_1 = New System.Windows.Forms.Button()
        Me.BT_2 = New System.Windows.Forms.Button()
        Me.BT_3 = New System.Windows.Forms.Button()
        Me.BT_Soustraire = New System.Windows.Forms.Button()
        Me.BT_4 = New System.Windows.Forms.Button()
        Me.BT_5 = New System.Windows.Forms.Button()
        Me.BT_6 = New System.Windows.Forms.Button()
        Me.BT_Multiplier = New System.Windows.Forms.Button()
        Me.BT_7 = New System.Windows.Forms.Button()
        Me.BT_8 = New System.Windows.Forms.Button()
        Me.BT_9 = New System.Windows.Forms.Button()
        Me.BT_Diviser = New System.Windows.Forms.Button()
        Me.BT_Supprimer = New System.Windows.Forms.Button()
        Me.BT_C = New System.Windows.Forms.Button()
        Me.BT_CE = New System.Windows.Forms.Button()
        Me.BT_Quitter = New System.Windows.Forms.Button()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.BT_Changer_Signe = New System.Windows.Forms.Button()
        Me.TB_Log = New System.Windows.Forms.TextBox()
        Me.L_Casio = New System.Windows.Forms.Label()
        Me.PB_Bordure_Affichage = New System.Windows.Forms.PictureBox()
        CType(Me.PB_Bordure_Affichage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_Affichage
        '
        Me.TB_Affichage.BackColor = System.Drawing.Color.Silver
        Me.TB_Affichage.Location = New System.Drawing.Point(13, 28)
        Me.TB_Affichage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_Affichage.Name = "TB_Affichage"
        Me.TB_Affichage.ReadOnly = True
        Me.TB_Affichage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Affichage.Size = New System.Drawing.Size(156, 23)
        Me.TB_Affichage.TabIndex = 9999
        Me.TB_Affichage.Text = "0"
        Me.TB_Affichage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BT_0
        '
        Me.BT_0.BackColor = System.Drawing.Color.Silver
        Me.BT_0.Location = New System.Drawing.Point(53, 192)
        Me.BT_0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_0.Name = "BT_0"
        Me.BT_0.Size = New System.Drawing.Size(35, 30)
        Me.BT_0.TabIndex = 0
        Me.BT_0.Text = "0"
        Me.BT_0.UseVisualStyleBackColor = False
        '
        'BT_Virgule
        '
        Me.BT_Virgule.BackColor = System.Drawing.Color.Silver
        Me.BT_Virgule.Location = New System.Drawing.Point(93, 192)
        Me.BT_Virgule.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Virgule.Name = "BT_Virgule"
        Me.BT_Virgule.Size = New System.Drawing.Size(35, 30)
        Me.BT_Virgule.TabIndex = 10
        Me.BT_Virgule.Text = ","
        Me.BT_Virgule.UseVisualStyleBackColor = False
        '
        'BT_Egal
        '
        Me.BT_Egal.BackColor = System.Drawing.Color.Silver
        Me.BT_Egal.Location = New System.Drawing.Point(133, 192)
        Me.BT_Egal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Egal.Name = "BT_Egal"
        Me.BT_Egal.Size = New System.Drawing.Size(35, 30)
        Me.BT_Egal.TabIndex = 19
        Me.BT_Egal.Text = "="
        Me.BT_Egal.UseVisualStyleBackColor = False
        '
        'BT_1
        '
        Me.BT_1.BackColor = System.Drawing.Color.Silver
        Me.BT_1.Location = New System.Drawing.Point(12, 157)
        Me.BT_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_1.Name = "BT_1"
        Me.BT_1.Size = New System.Drawing.Size(35, 30)
        Me.BT_1.TabIndex = 1
        Me.BT_1.Text = "1"
        Me.BT_1.UseVisualStyleBackColor = False
        '
        'BT_2
        '
        Me.BT_2.BackColor = System.Drawing.Color.Silver
        Me.BT_2.Location = New System.Drawing.Point(53, 157)
        Me.BT_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_2.Name = "BT_2"
        Me.BT_2.Size = New System.Drawing.Size(35, 30)
        Me.BT_2.TabIndex = 2
        Me.BT_2.Text = "2"
        Me.BT_2.UseVisualStyleBackColor = False
        '
        'BT_3
        '
        Me.BT_3.BackColor = System.Drawing.Color.Silver
        Me.BT_3.Location = New System.Drawing.Point(93, 157)
        Me.BT_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_3.Name = "BT_3"
        Me.BT_3.Size = New System.Drawing.Size(35, 30)
        Me.BT_3.TabIndex = 3
        Me.BT_3.Text = "3"
        Me.BT_3.UseVisualStyleBackColor = False
        '
        'BT_Soustraire
        '
        Me.BT_Soustraire.BackColor = System.Drawing.Color.Silver
        Me.BT_Soustraire.Location = New System.Drawing.Point(134, 123)
        Me.BT_Soustraire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Soustraire.Name = "BT_Soustraire"
        Me.BT_Soustraire.Size = New System.Drawing.Size(35, 30)
        Me.BT_Soustraire.TabIndex = 17
        Me.BT_Soustraire.Text = "-"
        Me.BT_Soustraire.UseVisualStyleBackColor = False
        '
        'BT_4
        '
        Me.BT_4.BackColor = System.Drawing.Color.Silver
        Me.BT_4.Location = New System.Drawing.Point(12, 123)
        Me.BT_4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_4.Name = "BT_4"
        Me.BT_4.Size = New System.Drawing.Size(35, 30)
        Me.BT_4.TabIndex = 4
        Me.BT_4.Text = "4"
        Me.BT_4.UseVisualStyleBackColor = False
        '
        'BT_5
        '
        Me.BT_5.BackColor = System.Drawing.Color.Silver
        Me.BT_5.Location = New System.Drawing.Point(53, 123)
        Me.BT_5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_5.Name = "BT_5"
        Me.BT_5.Size = New System.Drawing.Size(35, 30)
        Me.BT_5.TabIndex = 5
        Me.BT_5.Text = "5"
        Me.BT_5.UseVisualStyleBackColor = False
        '
        'BT_6
        '
        Me.BT_6.BackColor = System.Drawing.Color.Silver
        Me.BT_6.Location = New System.Drawing.Point(93, 123)
        Me.BT_6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_6.Name = "BT_6"
        Me.BT_6.Size = New System.Drawing.Size(35, 30)
        Me.BT_6.TabIndex = 6
        Me.BT_6.Text = "6"
        Me.BT_6.UseVisualStyleBackColor = False
        '
        'BT_Multiplier
        '
        Me.BT_Multiplier.BackColor = System.Drawing.Color.Silver
        Me.BT_Multiplier.Location = New System.Drawing.Point(134, 88)
        Me.BT_Multiplier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Multiplier.Name = "BT_Multiplier"
        Me.BT_Multiplier.Size = New System.Drawing.Size(35, 30)
        Me.BT_Multiplier.TabIndex = 16
        Me.BT_Multiplier.Text = "X"
        Me.BT_Multiplier.UseVisualStyleBackColor = False
        '
        'BT_7
        '
        Me.BT_7.BackColor = System.Drawing.Color.Silver
        Me.BT_7.Location = New System.Drawing.Point(12, 88)
        Me.BT_7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_7.Name = "BT_7"
        Me.BT_7.Size = New System.Drawing.Size(35, 30)
        Me.BT_7.TabIndex = 7
        Me.BT_7.Text = "7"
        Me.BT_7.UseVisualStyleBackColor = False
        '
        'BT_8
        '
        Me.BT_8.BackColor = System.Drawing.Color.Silver
        Me.BT_8.Location = New System.Drawing.Point(53, 88)
        Me.BT_8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_8.Name = "BT_8"
        Me.BT_8.Size = New System.Drawing.Size(35, 30)
        Me.BT_8.TabIndex = 8
        Me.BT_8.Text = "8"
        Me.BT_8.UseVisualStyleBackColor = False
        '
        'BT_9
        '
        Me.BT_9.BackColor = System.Drawing.Color.Silver
        Me.BT_9.Location = New System.Drawing.Point(94, 88)
        Me.BT_9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_9.Name = "BT_9"
        Me.BT_9.Size = New System.Drawing.Size(35, 30)
        Me.BT_9.TabIndex = 9
        Me.BT_9.Text = "9"
        Me.BT_9.UseVisualStyleBackColor = False
        '
        'BT_Diviser
        '
        Me.BT_Diviser.BackColor = System.Drawing.Color.Silver
        Me.BT_Diviser.Location = New System.Drawing.Point(135, 54)
        Me.BT_Diviser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Diviser.Name = "BT_Diviser"
        Me.BT_Diviser.Size = New System.Drawing.Size(35, 30)
        Me.BT_Diviser.TabIndex = 15
        Me.BT_Diviser.Text = "/"
        Me.BT_Diviser.UseVisualStyleBackColor = False
        '
        'BT_Supprimer
        '
        Me.BT_Supprimer.BackColor = System.Drawing.Color.Silver
        Me.BT_Supprimer.Location = New System.Drawing.Point(12, 192)
        Me.BT_Supprimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Supprimer.Name = "BT_Supprimer"
        Me.BT_Supprimer.Size = New System.Drawing.Size(35, 30)
        Me.BT_Supprimer.TabIndex = 11
        Me.BT_Supprimer.Text = "DEL"
        Me.BT_Supprimer.UseVisualStyleBackColor = False
        '
        'BT_C
        '
        Me.BT_C.BackColor = System.Drawing.Color.Silver
        Me.BT_C.Location = New System.Drawing.Point(12, 54)
        Me.BT_C.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_C.Name = "BT_C"
        Me.BT_C.Size = New System.Drawing.Size(35, 30)
        Me.BT_C.TabIndex = 12
        Me.BT_C.Text = "C"
        Me.BT_C.UseVisualStyleBackColor = False
        '
        'BT_CE
        '
        Me.BT_CE.BackColor = System.Drawing.Color.Silver
        Me.BT_CE.Location = New System.Drawing.Point(53, 54)
        Me.BT_CE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_CE.Name = "BT_CE"
        Me.BT_CE.Size = New System.Drawing.Size(35, 30)
        Me.BT_CE.TabIndex = 13
        Me.BT_CE.Text = "CE"
        Me.BT_CE.UseVisualStyleBackColor = False
        '
        'BT_Quitter
        '
        Me.BT_Quitter.BackColor = System.Drawing.Color.Silver
        Me.BT_Quitter.Location = New System.Drawing.Point(94, 54)
        Me.BT_Quitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Quitter.Name = "BT_Quitter"
        Me.BT_Quitter.Size = New System.Drawing.Size(35, 15)
        Me.BT_Quitter.TabIndex = 20
        Me.BT_Quitter.Text = "OFF"
        Me.BT_Quitter.UseVisualStyleBackColor = False
        '
        'BT_Ajouter
        '
        Me.BT_Ajouter.BackColor = System.Drawing.Color.Silver
        Me.BT_Ajouter.Location = New System.Drawing.Point(134, 157)
        Me.BT_Ajouter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Ajouter.Name = "BT_Ajouter"
        Me.BT_Ajouter.Size = New System.Drawing.Size(35, 30)
        Me.BT_Ajouter.TabIndex = 18
        Me.BT_Ajouter.Text = "+"
        Me.BT_Ajouter.UseVisualStyleBackColor = False
        '
        'BT_Changer_Signe
        '
        Me.BT_Changer_Signe.BackColor = System.Drawing.Color.Silver
        Me.BT_Changer_Signe.Location = New System.Drawing.Point(94, 69)
        Me.BT_Changer_Signe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Changer_Signe.Name = "BT_Changer_Signe"
        Me.BT_Changer_Signe.Size = New System.Drawing.Size(35, 15)
        Me.BT_Changer_Signe.TabIndex = 14
        Me.BT_Changer_Signe.Text = "+/-"
        Me.BT_Changer_Signe.UseVisualStyleBackColor = False
        '
        'TB_Log
        '
        Me.TB_Log.BackColor = System.Drawing.Color.Silver
        Me.TB_Log.Location = New System.Drawing.Point(13, 13)
        Me.TB_Log.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_Log.Name = "TB_Log"
        Me.TB_Log.ReadOnly = True
        Me.TB_Log.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Log.Size = New System.Drawing.Size(156, 23)
        Me.TB_Log.TabIndex = 9999
        Me.TB_Log.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'L_Casio
        '
        Me.L_Casio.AutoSize = True
        Me.L_Casio.BackColor = System.Drawing.Color.Transparent
        Me.L_Casio.Location = New System.Drawing.Point(53, 0)
        Me.L_Casio.Name = "L_Casio"
        Me.L_Casio.Size = New System.Drawing.Size(111, 15)
        Me.L_Casio.TabIndex = 10000
        Me.L_Casio.Text = "Casio Premium 87+"
        '
        'PB_Bordure_Affichage
        '
        Me.PB_Bordure_Affichage.BackColor = System.Drawing.Color.Black
        Me.PB_Bordure_Affichage.Location = New System.Drawing.Point(11, 11)
        Me.PB_Bordure_Affichage.Name = "PB_Bordure_Affichage"
        Me.PB_Bordure_Affichage.Size = New System.Drawing.Size(157, 34)
        Me.PB_Bordure_Affichage.TabIndex = 10001
        Me.PB_Bordure_Affichage.TabStop = False
        '
        'Form_Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(181, 234)
        Me.Controls.Add(Me.L_Casio)
        Me.Controls.Add(Me.TB_Log)
        Me.Controls.Add(Me.BT_Changer_Signe)
        Me.Controls.Add(Me.BT_Ajouter)
        Me.Controls.Add(Me.BT_CE)
        Me.Controls.Add(Me.BT_C)
        Me.Controls.Add(Me.BT_Supprimer)
        Me.Controls.Add(Me.BT_Quitter)
        Me.Controls.Add(Me.BT_Diviser)
        Me.Controls.Add(Me.BT_9)
        Me.Controls.Add(Me.BT_8)
        Me.Controls.Add(Me.BT_7)
        Me.Controls.Add(Me.BT_Multiplier)
        Me.Controls.Add(Me.BT_6)
        Me.Controls.Add(Me.BT_5)
        Me.Controls.Add(Me.BT_4)
        Me.Controls.Add(Me.BT_Soustraire)
        Me.Controls.Add(Me.BT_3)
        Me.Controls.Add(Me.BT_2)
        Me.Controls.Add(Me.BT_1)
        Me.Controls.Add(Me.BT_Egal)
        Me.Controls.Add(Me.BT_Virgule)
        Me.Controls.Add(Me.BT_0)
        Me.Controls.Add(Me.TB_Affichage)
        Me.Controls.Add(Me.PB_Bordure_Affichage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form_Calculatrice"
        Me.Text = "Calculatrice"
        CType(Me.PB_Bordure_Affichage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Affichage As TextBox
    Friend WithEvents BT_0 As Button
    Friend WithEvents BT_Virgule As Button
    Friend WithEvents BT_Egal As Button
    Friend WithEvents BT_1 As Button
    Friend WithEvents BT_2 As Button
    Friend WithEvents BT_3 As Button
    Friend WithEvents BT_Soustraire As Button
    Friend WithEvents BT_4 As Button
    Friend WithEvents BT_5 As Button
    Friend WithEvents BT_6 As Button
    Friend WithEvents BT_Multiplier As Button
    Friend WithEvents BT_7 As Button
    Friend WithEvents BT_8 As Button
    Friend WithEvents BT_9 As Button
    Friend WithEvents BT_Diviser As Button
    Friend WithEvents BT_Supprimer As Button
    Friend WithEvents BT_C As Button
    Friend WithEvents BT_CE As Button
    Friend WithEvents BT_Quitter As Button
    Friend WithEvents BT_Ajouter As Button
    Friend WithEvents BT_Changer_Signe As Button
    Friend WithEvents TB_Log As TextBox
    Friend WithEvents L_Casio As Label
    Friend WithEvents PB_Bordure_Affichage As PictureBox
End Class
