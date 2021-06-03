Public Class buscador2
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        navegador.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        navegador.GoForward()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        navegador.Refresh()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        navegador.GoHome()

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        navegador.Navigate(striptxt.Text)
    End Sub

    Private Sub navegador_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles navegador.DocumentCompleted

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        PRINCIPAL.Show()
        Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MessageBox.Show("ALANYA ASPUR, MARCO ANTONIO", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class