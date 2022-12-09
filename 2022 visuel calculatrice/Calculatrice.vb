' ----------------------------------------
'| Auteur : CLEMENT Pierre (INFO 25)      |
'|                                        |
'| Date : 09/12/2022                      |
'|                                        |
'| Utilite :                              |
'| Le Programme réalise des opérations    |
'| nombres négatifs, opérations multiples |
'| et priorités de signes compris.        |
' ----------------------------------------

' Libs
Imports System.Drawing.Text
Imports System.Globalization
Imports System.IO

Public Class Form_Calculatrice
    ' Le Form de la calculatrice '

    ' Vars
    Dim nouveauResultat As Boolean = False
    Dim nouveauNombre As Boolean = False

    ' Consts
    ReadOnly messageErreur As String = "ERREUR SUR OPERATION"

    Private Sub Form_Calculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Au lancement du form '

        ' Attribution du style à tout le Form '
        Visuel_Mode_Casio()
        ' Instancier les variables '
        TB_Log.ResetText()
    End Sub

    Private Sub BT_Operateurs_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click, BT_Soustraire.Click, BT_Multiplier.Click, BT_Diviser.Click
        ' Gestion de l'attribution des opérateurs '

        Supprimer_Message_Erreur()

        If nouveauResultat = True Then
            TB_Log.ResetText()
            nouveauResultat = False
        End If

        If nouveauNombre = False And nouveauResultat = False Then
            TB_Affichage.Text = Format_Affichage_Nombre(TB_Affichage.Text)
        End If

        Dim res() As Char = TB_Log.Text
        If res <> "" Then
            If nouveauNombre = True And (res(res.Length - 1) = "+" Or res(res.Length - 1) = "-" Or res(res.Length - 1) = "X" Or res(res.Length - 1) = "/") Then ' Changement d'opérateur '
                res(res.Length - 1) = sender.text
                TB_Log.Text = res
            Else ' Ajout standard '
                TB_Log.Text &= TB_Affichage.Text & sender.text
                nouveauNombre = True
            End If
        Else ' Ajout standard '
            TB_Log.Text &= TB_Affichage.Text & sender.text
            nouveauNombre = True
        End If

        TB_Affichage.Text = TB_Affichage.Text.Replace("(", "").Replace(")", "") ' Retire les parenthèses des négatifs '
    End Sub

    Private Sub BT_Chiffres_Click(sender As Object, e As EventArgs) Handles BT_0.Click, BT_1.Click, BT_2.Click, BT_3.Click, BT_4.Click, BT_5.Click, BT_6.Click, BT_7.Click, BT_8.Click, BT_9.Click
        ' Gestion de l'attribution des chiffres '

        Supprimer_Message_Erreur()

        Changement_Nombre_Ou_Resultat()

        Dim res() As Char = TB_Affichage.Text

        If res.Length = 1 Then ' Remplace 0 par le chiffre '
            If res(0) = "0" Then
                res(0) = sender.text
                TB_Affichage.Text = res
            Else
                TB_Affichage.Text &= sender.text
            End If

        ElseIf res.Length = 2 Then ' Remplace -0 par le chiffre negatif '
            If res(0) = "-" And res(1) = "0" Then
                res(1) = sender.text
                TB_Affichage.Text = res
            Else
                TB_Affichage.Text &= sender.text
            End If
        Else ' Sinon concaténation '
            TB_Affichage.Text &= sender.text
        End If
    End Sub

    Private Sub BT_Virgule_Click(sender As Object, e As EventArgs) Handles BT_Virgule.Click
        ' Gestion de l'attribution de virgule '

        Supprimer_Message_Erreur()

        Changement_Nombre_Ou_Resultat()

        ' S'il y a déjà une virgule, quitter la méthode '
        Dim res() As Char = TB_Affichage.Text
        For i = 0 To res.Length - 1
            If res(i) = "," Then
                Exit Sub
            End If
        Next

        ' S'il y a aucune virgule '
        TB_Affichage.Text &= sender.text
    End Sub

    Private Sub Changement_Nombre_Ou_Resultat()
        ' Prend en main le reset pour la méthode de click des chiffres et virgule '

        If nouveauNombre = True Or nouveauResultat = True Then
            If nouveauNombre = True Then
                nouveauNombre = False
            End If
            If nouveauResultat = True Then
                TB_Log.ResetText()
                nouveauResultat = False
            End If
            TB_Affichage.Text = "0"
        End If
    End Sub

    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        ' Supprime le dernier caractère '

        Supprimer_Message_Erreur()

        If nouveauResultat = True Or nouveauNombre = True Then ' En cas de resultat reset les logs, si nombre, rien '
            If nouveauResultat = True Then
                TB_Log.ResetText()
            End If
        ElseIf TB_Affichage.Text.Length = 1 Then ' Si de taille 1 remplace par 0 '
            TB_Affichage.Text = "0"
        ElseIf TB_Affichage.Text.Length = 2 And TB_Affichage.Text(0) = "-" Then ' Si négatif de taille 1 remplace par -0 '
            TB_Affichage.Text = "-0"
        ElseIf TB_Affichage.Text <> "0" Then ' Si différent de 0, supprime le dernier caractère '
            TB_Affichage.Text = TB_Affichage.Text.Remove(TB_Affichage.Text.Length - 1)
        Else ' Sinon remplace par 0 '
            TB_Affichage.Text = "0"
        End If
    End Sub

    Private Sub BT_Egal_Click(sender As Object, e As EventArgs) Handles BT_Egal.Click
        ' Gestion du calcul du resultat '

        Supprimer_Message_Erreur()

        TB_Affichage.Text = Format_Affichage_Nombre(TB_Affichage.Text)

        Dim equation_str As String = TB_Log.Text & TB_Affichage.Text
        equation_str = equation_str.Replace(",", ".").Replace("X", "*") ' Rend la string exploitable mathématiquement '

        ' Réalise le calcul et retourne une erreur en cas d'exception '
        If nouveauResultat = False Then
            Try
                Dim calcul = New DataTable().Compute(equation_str, Nothing)
                calcul = Math.Round(calcul, 2)
                TB_Log.Text = equation_str.Replace(".", ",").Replace("*", "X") & sender.text ' Rend la formule visuellement adaptée '
                Dim result As Double = calcul ' Si pas décimal, Throw l'erreur '
                TB_Affichage.Text = result
                nouveauResultat = True
            Catch ex As Exception
                TB_Affichage.Text = messageErreur
            End Try
        End If
    End Sub

    Private Sub Supprimer_Message_Erreur()
        ' Réinitialisation des variables en cas d'erreur sur opération '

        If TB_Affichage.Text = messageErreur Then
            TB_Log.ResetText()
            TB_Affichage.Text = "0"
            nouveauNombre = False
            nouveauResultat = False
        End If
    End Sub

    Private Sub BT_Quitter_Click(sender As Object, e As EventArgs) Handles BT_Quitter.Click
        ' Demande avant de quitter l'application '

        If MessageBox.Show("Souhaitez-vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
            End
        End If
    End Sub

    Private Sub BT_C_Click(sender As Object, e As EventArgs) Handles BT_C.Click
        ' Supprime tout le calcul '

        TB_Log.ResetText()
        TB_Affichage.Text = "0"
        nouveauNombre = False
        nouveauResultat = False
    End Sub

    Private Sub BT_CE_Click(sender As Object, e As EventArgs) Handles BT_CE.Click
        ' Supprime le dernier nombre du calcul '

        Supprimer_Message_Erreur()

        If nouveauResultat = True Then
            TB_Log.ResetText()
        End If

        TB_Affichage.Text = "0"
        nouveauNombre = False
        nouveauResultat = False
    End Sub

    Private Sub BT_Changer_Signe_Click(sender As Object, e As EventArgs) Handles BT_Changer_Signe.Click
        ' Convertir une valeur positive en négative et inversement '

        If nouveauNombre = False And nouveauResultat = False Then
            If Est_Negatif(TB_Affichage.Text) = True Then
                TB_Affichage.Text = TB_Affichage.Text.Replace("-", "")
            Else
                TB_Affichage.Text = "-" & TB_Affichage.Text
            End If
        End If
    End Sub

    Private Shared Function Est_Negatif(str() As Char)
        ' Permet de savoir si un nombre est négatif '

        If str.Length <> 0 Then
            If str(0) = "-" Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Shared Function Format_Affichage_Nombre(text() As Char)
        ' Permet un rendu visuelement parlant des opérations '

        ' Supprime les virgules inutiles '
        If text(text.Length - 1) = "," Then
            text(text.Length - 1) = ""
        End If

        ' Remplace les opérations --nb par -(nb) et +-nb par +(-nb) '
        If Est_Negatif(text) Then
            text = "(" & text & ")"
        End If

        Return text
    End Function

    Public Shared Function HexToColor(ByVal hexColor As String) As Color
        ' Prend une string de couleur hexadecimal et la retourne en obj Color '

        If hexColor.IndexOf("#"c) <> -1 Then
            hexColor = hexColor.Replace("#", "")
        End If

        Dim red As Integer = 0
        Dim green As Integer = 0
        Dim blue As Integer = 0

        If hexColor.Length = 6 Then
            red = Integer.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier)
            green = Integer.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier)
            blue = Integer.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier)
        ElseIf hexColor.Length = 3 Then
            red = Integer.Parse(hexColor(0).ToString() + hexColor(0).ToString(), NumberStyles.AllowHexSpecifier)
            green = Integer.Parse(hexColor(1).ToString() + hexColor(1).ToString(), NumberStyles.AllowHexSpecifier)
            blue = Integer.Parse(hexColor(2).ToString() + hexColor(2).ToString(), NumberStyles.AllowHexSpecifier)
        End If

        Return Color.FromArgb(red, green, blue)
    End Function

    Private Sub Visuel_Mode_Casio()
        ' Transforme visuellement en Casio '

        ' Attribution des couleurs '
        Dim couleur_blanc As Color = HexToColor("#ffffff")
        Dim couleur_noir As Color = HexToColor("#000000")
        Dim couleur_vert_fonce As Color = HexToColor("#3c5454")
        Dim couleur_vert As Color = HexToColor("#6d9d7f")
        Dim couleur_vert_clair As Color = HexToColor("#c0e9d7")

        ' Attribution des Polices '
        Dim pf = New PrivateFontCollection()
        pf.AddFontFile(Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\Calculator.ttf"))
        Me.Font = New Font(pf.Families(0), 34, FontStyle.Bold)
        BT_Changer_Signe.Font = New Font(pf.Families(0), 22, FontStyle.Bold)
        BT_Quitter.Font = New Font(pf.Families(0), 22, FontStyle.Bold)
        BT_Supprimer.Font = New Font(pf.Families(0), 26, FontStyle.Bold)
        L_Casio.Font = New Font(pf.Families(0), 24, FontStyle.Bold)

        ' Visuel Général '
        Me.BackColor = couleur_vert_clair
        TB_Affichage.ForeColor = HexToColor("#3a3a3a")
        TB_Log.ForeColor = HexToColor("#737373")
        L_Casio.ForeColor = couleur_vert_fonce
        PB_Bordure_Affichage.BackColor = couleur_vert_fonce

        Dim taille_bordure As Integer = 6

        ' Visuel de l'écran '
        Dim textbox = New List(Of TextBox) From {TB_Affichage, TB_Log}
        For i = 0 To textbox.Count - 1
            textbox(i).BackColor = HexToColor("#c0c0c0")
            textbox(i).BorderStyle = BorderStyle.None
        Next

        ' Visuel des chiffres '
        Dim button_chiffre = New List(Of Button) From {BT_0, BT_1, BT_2, BT_3, BT_4, BT_5, BT_6, BT_7, BT_8, BT_9}
        For i = 0 To button_chiffre.Count - 1
            button_chiffre(i).FlatStyle = FlatStyle.Flat
            button_chiffre(i).FlatAppearance.BorderColor = couleur_vert
            button_chiffre(i).FlatAppearance.BorderSize = taille_bordure
            button_chiffre(i).BackColor = couleur_vert_fonce
            button_chiffre(i).ForeColor = couleur_blanc
        Next

        ' Visuel des opérateurs '
        Dim button_operation = New List(Of Button) From {BT_Ajouter, BT_Soustraire, BT_Multiplier, BT_Diviser}
        For i = 0 To button_operation.Count - 1
            button_operation(i).FlatStyle = FlatStyle.Flat
            button_operation(i).FlatAppearance.BorderColor = couleur_vert_fonce
            button_operation(i).FlatAppearance.BorderSize = taille_bordure
            button_operation(i).BackColor = couleur_vert
            button_operation(i).ForeColor = couleur_blanc
        Next

        ' Visuel de CE '
        Dim button_annulation = New List(Of Button) From {BT_Changer_Signe, BT_Virgule}
        For i = 0 To button_annulation.Count - 1
            button_annulation(i).FlatStyle = FlatStyle.Flat
            button_annulation(i).FlatAppearance.BorderColor = couleur_vert_fonce
            button_annulation(i).FlatAppearance.BorderSize = taille_bordure
            button_annulation(i).BackColor = couleur_vert_clair
            button_annulation(i).ForeColor = couleur_vert_fonce
        Next

        ' Visuel de Supprimer '
        BT_Supprimer.FlatStyle = FlatStyle.Flat
        BT_Supprimer.FlatAppearance.BorderColor = HexToColor("#989231")
        BT_Supprimer.FlatAppearance.BorderSize = taille_bordure
        BT_Supprimer.BackColor = HexToColor("#d9d146")
        BT_Supprimer.ForeColor = couleur_noir

        ' Visuel de CE '
        BT_CE.FlatStyle = FlatStyle.Flat
        BT_CE.FlatAppearance.BorderColor = HexToColor("#945522")
        BT_CE.FlatAppearance.BorderSize = taille_bordure
        BT_CE.BackColor = HexToColor("#d47930")
        BT_CE.ForeColor = couleur_noir

        ' Visuel de C '
        BT_C.FlatStyle = FlatStyle.Flat
        BT_C.FlatAppearance.BorderColor = HexToColor("#82281f")
        BT_C.FlatAppearance.BorderSize = taille_bordure
        BT_C.BackColor = HexToColor("#b9392c")
        BT_C.ForeColor = couleur_noir

        ' Visuel de Quitter '
        BT_Quitter.FlatStyle = FlatStyle.Flat
        BT_Quitter.FlatAppearance.BorderColor = couleur_vert
        BT_Quitter.FlatAppearance.BorderSize = taille_bordure
        BT_Quitter.BackColor = couleur_vert_fonce
        BT_Quitter.ForeColor = couleur_vert

        ' Visuel de = '
        BT_Egal.FlatStyle = FlatStyle.Flat
        BT_Egal.FlatAppearance.BorderColor = HexToColor("#3e3980")
        BT_Egal.FlatAppearance.BorderSize = taille_bordure
        BT_Egal.BackColor = HexToColor("#5851b7")
        BT_Egal.ForeColor = couleur_blanc

    End Sub
End Class