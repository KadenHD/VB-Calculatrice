Imports System.Drawing.Text

Public Class Form_Calculatrice
    Private Sub Form_Calculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attribution du style à tout le Form '
        Dim pf = New PrivateFontCollection()
        pf.AddFontFile(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\Calculator.ttf"))
        Me.Font = New Font(pf.Families(0), 24, FontStyle.Bold)
        Me.ForeColor = Color.Blue
        TB_Affichage.ForeColor = Color.Blue
        ' 

    End Sub

    Private Sub BT_Chiffres_Click(sender As Object, e As EventArgs) Handles BT_Virgule.Click, BT_0.Click, BT_1.Click, BT_2.Click, BT_3.Click, BT_4.Click, BT_5.Click, BT_6.Click, BT_7.Click, BT_8.Click, BT_9.Click

    End Sub

    Private Sub BT_Operateurs_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click, BT_Soustraire.Click, BT_Multiplier.Click, BT_Diviser.Click

    End Sub

    Private Sub BT_CE_Click(sender As Object, e As EventArgs) Handles BT_CE.Click
        ' Annule toute frappe '
    End Sub

    Private Sub BT_C_Click(sender As Object, e As EventArgs) Handles BT_C.Click
        ' Annule dernière frappe '
    End Sub

    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        ' Supprime le dernier caractère '
    End Sub

    Private Sub BT_Quitter_Click(sender As Object, e As EventArgs) Handles BT_Quitter.Click

    End Sub

    Private Sub BT_Egal_Click(sender As Object, e As EventArgs) Handles BT_Egal.Click

    End Sub

    Private Function Calculer_String(equation As String)
        ' str.replace("," , ".")
        ' Dim result = new DataTable().Compute(equation, Nothing) '
        Return ""
    End Function

    Private Sub TB_Affichage_TextChanged(sender As Object, e As EventArgs) Handles TB_Affichage.TextChanged
        ' Virgule handler between operators
    End Sub
End Class
