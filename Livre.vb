Friend Class Livre
    Inherits Document

    Private auteur As String


    Friend Sub New(ByVal varTitre As String, varAuteur As String)
        MyBase.New(varTitre)
        auteur = varAuteur
    End Sub

    Friend Function DonneAuteurLivre() As String
        Return auteur
    End Function

    Public Overrides Sub Affiche()
        MyBase.Affiche()
        Console.WriteLine("provient de la classe livre : auteur " & auteur)
    End Sub

End Class

