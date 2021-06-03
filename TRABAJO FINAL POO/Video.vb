Public Class Video
    Private Sub btnMusica_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ProgressBar1.Maximum = 100000
        For i = 0 To 100000
            ProgressBar1.Value = i
        Next
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        VIDEO_PRINCIPAL.Show()
        Close()
    End Sub
End Class