Public Class juego_vaso
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim randomValue As Integer
        Dim upperbound As Integer
        Dim lowerbound As Integer
        upperbound = 0
        lowerbound = 4
        randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Label1.Text = randomValue
        PictureBox1.Image = My.Resources.VASO_CERRADO
        PictureBox2.Image = My.Resources.VASO_CERRADO
        PictureBox3.Image = My.Resources.VASO_CERRADO
        Label2.Text = "SELECCIONA UN VASO"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim select1 As Integer
        select1 = 1
        If Label1.Text = select1 Then
            PictureBox1.Image = My.Resources.VASO_Y_BOLA
            Label2.Text = "GANASTE!! TIENES BUENA SUERTE"
        ElseIf Label1.Text = 2 Or Label1.Text = 3 Then
            PictureBox1.Image = My.Resources.VASO_ABIERTO
            Label2.Text = "ERROR MALA SUERTE"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim select1 As Integer
        select1 = 2
        If Label1.Text = select1 Then
            PictureBox2.Image = My.Resources.VASO_Y_BOLA
            Label2.Text = "GANASTE!! TIENES BUENA SUERTE"
        ElseIf Label1.Text = 1 Or Label1.Text = 3 Then
            PictureBox2.Image = My.Resources.VASO_ABIERTO
            Label2.Text = "ERROR MALA SUERTE"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim select1 As Integer
        select1 = 3
        If Label1.Text = select1 Then
            PictureBox3.Image = My.Resources.VASO_Y_BOLA
            Label2.Text = "GANASTE!! TIENES BUENA SUERTE"
        ElseIf Label1.Text = 2 Or Label1.Text = 1 Then
            PictureBox3.Image = My.Resources.VASO_ABIERTO
            Label2.Text = "ERROR MALA SUERTE"
        End If
    End Sub

    Private Sub juego_vaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("RAMOS CORDOVA , JOEL ISAAC", "DESARROLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PRINCIPAL.Show()
        Close()
    End Sub
End Class