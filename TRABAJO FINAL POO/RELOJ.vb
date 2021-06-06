Public Class RELOJ
    Private Sub HorayFecha_Tick(sender As Object, e As EventArgs) Handles HorayFecha.Tick
        lblHora.Text = Format(DateAndTime.TimeOfDay, "hh") & ":"
        lblmin.Text = Format(DateAndTime.TimeOfDay, "mm")
        lblseg.Text = Format(DateAndTime.TimeOfDay, "ss")
        lblFecha.Text = Format(DateTime.Now.ToLongDateString)

    End Sub

    Private Sub AmyPm_Tick(sender As Object, e As EventArgs) Handles AmyPm.Tick

    End Sub

    Private Sub lblmin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("FERNANDEZ MEREZ ALBERTO JESUS", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PRINCIPAL.Show()
        Close()
    End Sub
End Class