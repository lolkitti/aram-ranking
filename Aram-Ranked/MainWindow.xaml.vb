Imports RiotWrapper.Summoner_V3

Class MainWindow
    Dim summonername As String
    Dim level As Integer

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim API As New Summoner
        API.SummonerLevel
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
