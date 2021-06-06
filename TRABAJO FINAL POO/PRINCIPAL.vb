Public Class PRINCIPAL
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub btnMusica_Click(sender As Object, e As EventArgs) Handles btnMusica.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        Musica.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        VIDEO_PRINCIPAL.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.apagado, AudioPlayMode.Background)
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("PACHECO VARGAS ANTHONY ROBERTO" + vbCrLf + "RAMOS CORDOVA JOEL ISAAC" + vbCrLf + "ANTEZANO MEJIA JOSE LUIS" + vbCrLf + "ALANYA ASPUR, MARCO ANTONIO" + vbCrLf + "FERNANDEZ MEREZ ALBERTO JESUS", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Today()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        juego_vaso.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        CALCULADORA.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        CALENDARIO.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        dibujo.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        buscador2.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        CRONOMETRO.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        ProgressBar1.Maximum = 99999
        For i = 0 To 99999
            ProgressBar1.Value = i
        Next
        RELOJ.Show()
        Hide()
        ProgressBar1.Value = 0
    End Sub
End Class