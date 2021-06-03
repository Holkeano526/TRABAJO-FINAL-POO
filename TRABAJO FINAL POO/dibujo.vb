Public Class dibujo
    Dim down = False
    Dim down2 = False
    Dim color = Brushes.Black


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick


    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

    End Sub

    Private Sub btnexaminar_Click(sender As Object, e As EventArgs) Handles btnexaminar.Click
        Dim abrir_archivo As New OpenFileDialog()
        abrir_archivo.Filter = "cursor file |* PNG"
        If abrir_archivo.ShowDialog() = DialogResult.OK Then
            pbx.Load(abrir_archivo.FileName)
        End If
        pbx.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click

    End Sub

    Private Sub pbx_MouseDown(sender As Object, e As MouseEventArgs) Handles pbx.MouseDown
        down2 = False
        down = True

    End Sub

    Private Sub pbx_MouseMove(sender As Object, e As MouseEventArgs) Handles pbx.MouseMove
        If down = True Then
            pbx.CreateGraphics.FillEllipse(color, e.X, e.Y, 40, 20)
        End If
    End Sub

    Private Sub pbx_MouseUp(sender As Object, e As MouseEventArgs) Handles pbx.MouseUp
        down2 = True
        down = False
    End Sub

    Private Sub pbx_MouseWheel(sender As Object, e As MouseEventArgs) Handles pbx.MouseWheel
        If down2 = True Then
            pbx.CreateGraphics.FillEllipse(color, e.X, e.Y, 80, 80)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        color = Brushes.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        color = Brushes.Orange
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        color = Brushes.Cyan
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        color = Brushes.Yellow
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        color = Brushes.Lime
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        color = Brushes.Red
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        color = Brushes.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        color = Brushes.BlueViolet
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        color = Brushes.Blue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        color = Brushes.Fuchsia
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MessageBox.Show("ALANYA ASPUR, MARCO ANTONIO", "DESARROLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PRINCIPAL.Show()
        Close()
    End Sub
End Class

