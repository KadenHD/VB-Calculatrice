' ----------------------------------------
'| Auteur : CLEMENT Pierre (INFO 25)      |
'|                                        |
'| Date : 09/12/2022                      |
'|                                        |
'| Utilite :                              |
'| Le Programme réaliser des opérations   |
'| nombres négatifs, opérations multiples |
'| et priorités de signes compris.        |
' ----------------------------------------

' Libs
Imports System.Drawing.Text
Imports System.IO

Public Class Form_Calculatrice

    ' Vars
    Dim nouveauResultat As Boolean = False
    Dim nouveauNombre As Boolean = False
    Dim equation As String = ""

    ' Consts
    ReadOnly messageErreur As String = "ERREUR SUR OPERATION"

    Private Sub Form_Calculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attribution du style à tout le Form '
        Dim pf = New PrivateFontCollection()
        pf.AddFontFile(Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\Calculator.ttf"))
        Me.Font = New Font(pf.Families(0), 34, FontStyle.Bold)
        Me.ForeColor = Color.Blue
        TB_Affichage.ForeColor = Color.Blue
        TB_Log.ForeColor = Color.DarkBlue
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
            If nouveauNombre = True And (res(res.Length - 1) = "+" Or res(res.Length - 1) = "-" Or res(res.Length - 1) = "X" Or res(res.Length - 1) = "/") Then
                res(res.Length - 1) = sender.text
                TB_Log.Text = res
            Else
                TB_Log.Text &= TB_Affichage.Text & sender.text
                nouveauNombre = True
            End If
        Else
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

        If res.Length = 1 And res(0) = "0" Then
            res(0) = sender.text
            TB_Affichage.Text = res
        Else
            TB_Affichage.Text &= sender.text
        End If
    End Sub

    Private Sub BT_Virgule_Click(sender As Object, e As EventArgs) Handles BT_Virgule.Click
        ' Gestion de l'attribution de virgule '

        Supprimer_Message_Erreur()

        Changement_Nombre_Ou_Resultat()

        ' S'il y a déjà une virgule, quitter le programme '
        Dim res() As Char = TB_Affichage.Text
        For i = 0 To res.Length - 1
            If res(i) = "," Then
                Exit Sub
            End If
        Next

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

        If nouveauResultat = True Or nouveauNombre = True Then
            If nouveauResultat = True Then
                TB_Log.ResetText()
                equation = ""
            End If
        ElseIf TB_Affichage.Text.Length = 1 Then
            TB_Affichage.Text = "0"
        ElseIf TB_Affichage.Text <> "0" Then
            TB_Affichage.Text = TB_Affichage.Text.Remove(TB_Affichage.Text.Length - 1)
        Else
            TB_Affichage.Text = "0"
        End If
    End Sub

    Private Sub BT_Egal_Click(sender As Object, e As EventArgs) Handles BT_Egal.Click
        ' Gestion du calcul du resultat '

        Supprimer_Message_Erreur()

        TB_Affichage.Text = Format_Affichage_Nombre(TB_Affichage.Text)

        Dim equation_str As String = TB_Log.Text & TB_Affichage.Text
        equation_str = equation_str.Replace(",", ".").Replace("X", "*")

        If nouveauResultat = False Then
            Try
                Dim calcul = New DataTable().Compute(equation_str, Nothing)
                calcul = Math.Round(calcul, 2)
                TB_Log.Text = equation_str.Replace(".", ",").Replace("*", "X") & sender.text
                Dim result As Decimal = calcul ' Si pas décimal, Throw l'erreur '
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
            equation = ""
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
        equation = ""
        nouveauNombre = False
        nouveauResultat = False
    End Sub

    Private Sub BT_CE_Click(sender As Object, e As EventArgs) Handles BT_CE.Click
        ' Supprime le dernier nombre du calcul '

        Supprimer_Message_Erreur()

        If nouveauResultat = True Then
            TB_Log.ResetText()
            equation = ""
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
End Class