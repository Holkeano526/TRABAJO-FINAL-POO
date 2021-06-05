Public Class CALENDARIO
    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        txtfecha.Text = calendariodate.Value
        txtinicio.Text = calendarioMonth.SelectionStart.Date
        txtfin.Text = calendarioMonth.SelectionRange.End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("ANTEZANO MEJIA, JOSE LUIS", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        PRINCIPAL.Show()
        Hide()
    End Sub

    Private Sub CALENDARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class