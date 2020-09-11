Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        ' Get Sender
        Dim srcButton As Button
        srcButton = CType(e.Source, Button)

        ' Find SoundName
        Dim SoundName As String
        SoundName = srcButton.Tag

        ' Convert Name to Object
        Dim SoundObj = My.Resources.ResourceManager.GetObject(SoundName)
        My.Computer.Audio.Play(SoundObj, AudioPlayMode.Background)

    End Sub
    Private Sub ResetDesign(sender As Object, e As MouseButtonEventArgs)
        Me.Width = 480
        Me.Height = 950
    End Sub

End Class

