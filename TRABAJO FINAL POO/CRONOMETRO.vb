Public Class CRONOMETRO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInicia.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblseg.Text += 1
        If lblseg.Text = "60" Then
            lblmin.Text += 1
            lblseg.Text = "00"
        End If
        If lblmin.Text = "60" Then
            lblHora.Text += 1
            lblmin.Text = "00"
        End If



    End Sub

    Private Sub btnparar_Click(sender As Object, e As EventArgs) Handles btnparar.Click
        Timer1.Stop()
    End Sub

    Private Sub btnlim_Click(sender As Object, e As EventArgs) Handles btnlim.Click
        Timer1.Stop()
        lblmin.Text = "00"
        lblHora.Text = "00"
        lblseg.Text = "00"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("FERNANDEZ MEREZ ALBERTO JESUS", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PRINCIPAL.Show()
        Close()
    End Sub
End Class
