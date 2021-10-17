Public Class Document
    Private titre As String

    Public Sub New(ByVal varTitre As String)
        titre = varTitre
    End Sub

    Public Overridable Sub Affiche()
        Console.WriteLine("le titre provient de la calsse document et est : " & titre)
    End Sub

    Friend ReadOnly Property VarGetTitre As String
        Get
            Return titre
        End Get
    End Property


    Public Function donneTitreDocument() As String
        Return titre
    End Function

End Class
