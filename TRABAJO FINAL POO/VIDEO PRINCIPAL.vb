Public Class VIDEO_PRINCIPAL
    Private Sub btnMusica_Click(sender As Object, e As EventArgs) Handles btnMusica.Click
        ProgressBar1.Maximum = 1000000
        For i = 0 To 1000000
            ProgressBar1.Value = i
        Next
        Video.Show()
        ProgressBar1.Value = 0
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        PRINCIPAL.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("PACHECO VARGAS ANTHONY ROBERTO", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub VIDEO_PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class