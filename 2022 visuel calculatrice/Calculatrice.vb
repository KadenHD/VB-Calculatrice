Imports System.Drawing.Text

Public Class Form_Calculatrice
    ' CE annule toute frappe
    ' C annule dernière frappe
    ' remove dernier charactère

    ' Dim result = new DataTable().Compute(equation, Nothing)

    Private Sub Form_Calculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attribution de la police à tout le Form '
        Dim pf = New PrivateFontCollection()
        pf.AddFontFile(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\Calculator.ttf"))
        Font = New Font(pf.Families(0), 24, FontStyle.Bold)
    End Sub

End Class
