Public Class Musica
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        PRINCIPAL.Show()
        Close()

    End Sub

    Private Sub btnMusica_Click(sender As Object, e As EventArgs) Handles btnMusica.Click
        ProgressBar1.Maximum = 100000
        For i = 0 To 100000
            ProgressBar1.Value = i
        Next
        My.Computer.Audio.Play(My.Resources.bailando_solo, AudioPlayMode.Background)
        lblMensaje.Show()
        lblMusica.Text = "Los Bunkers - Bailando solo"




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
        ProgressBar1.Value = 0
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        lblMensaje.Hide()
        lblMusica.Hide()
    End Sub

    Private Sub Musica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMensaje.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("PACHECO VARGAS ANTHONY ROBERTO", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class