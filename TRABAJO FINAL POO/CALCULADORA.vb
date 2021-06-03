Public Class CALCULADORA
    Dim val1 As Double
    Dim val2 As Double
    Dim operacion As Double
    Dim resultado As Double
    Dim cadena As Double
    Private Sub btnuno_Click(sender As Object, e As EventArgs) Handles btnuno.Click
        txtpantalla.Text = txtpantalla.Text & "1"
    End Sub

    Private Sub btndos_Click(sender As Object, e As EventArgs) Handles btndos.Click
        txtpantalla.Text = txtpantalla.Text & "2"
    End Sub

    Private Sub btntres_Click(sender As Object, e As EventArgs) Handles btntres.Click
        txtpantalla.Text = txtpantalla.Text & "3"
    End Sub

    Private Sub btncuatro_Click(sender As Object, e As EventArgs) Handles btncuatro.Click
        txtpantalla.Text = txtpantalla.Text & "4"
    End Sub

    Private Sub btncinco_Click(sender As Object, e As EventArgs) Handles btncinco.Click
        txtpantalla.Text = txtpantalla.Text & "5"
    End Sub

    Private Sub btnseis_Click(sender As Object, e As EventArgs) Handles btnseis.Click
        txtpantalla.Text = txtpantalla.Text & "6"
    End Sub

    Private Sub btnsiete_Click(sender As Object, e As EventArgs) Handles btnsiete.Click
        txtpantalla.Text = txtpantalla.Text & "7"
    End Sub

    Private Sub btnocho_Click(sender As Object, e As EventArgs) Handles btnocho.Click
        txtpantalla.Text = txtpantalla.Text & "8"
    End Sub

    Private Sub btnnueve_Click(sender As Object, e As EventArgs) Handles btnnueve.Click
        txtpantalla.Text = txtpantalla.Text & "9"
    End Sub

    Private Sub btncero_Click(sender As Object, e As EventArgs) Handles btncero.Click
        txtpantalla.Text = txtpantalla.Text & "0"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        Try
            If txtpantalla.Text.IndexOf(".") > 0 Then
                Beep()
            ElseIf txtpantalla.Text <> "." Then
                txtpantalla.Text = txtpantalla.Text & "."
            Else
                txtpantalla.Text = "0"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        operacion = 1
        val1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtresultado.Text = val1 & "+"
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        operacion = 2
        val1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtresultado.Text = val1 & "-"
    End Sub

    Private Sub btnmultiplicacion_Click(sender As Object, e As EventArgs) Handles btnmultiplicacion.Click
        operacion = 3
        val1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtresultado.Text = val1 & "×"
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        operacion = 4
        val1 = Val(txtpantalla.Text)
        txtpantalla.Clear()

        txtresultado.Text = val1 & "÷"
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        val2 = Val(txtpantalla.Text)

        If operacion = 1 Then
            resultado = val1 + val2
            txtpantalla.Text = resultado
            txtresultado.Text = txtresultado.Text & val2

        Else
            If operacion = 2 Then
                resultado = val1 - val2
                txtpantalla.Text = resultado
                txtresultado.Text = txtresultado.Text & val2

            Else
                If operacion = 3 Then
                    resultado = val1 * val2
                    txtpantalla.Text = resultado
                    txtresultado.Text = txtresultado.Text & val2

                Else
                    If operacion = 4 Then
                        resultado = val1 / val2
                        txtpantalla.Text = resultado
                        txtresultado.Text = txtresultado.Text & val2

                    Else
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub btnbackspace_Click(sender As Object, e As EventArgs) Handles btnbackspace.Click
        If txtpantalla.Text <> "" Then
            cadena = txtpantalla.Text.Length
            txtpantalla.Text = Mid(txtpantalla.Text, 1, cadena - 1)
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtpantalla.Text = ""
        txtresultado.Text = ""
    End Sub

    Private Sub btnmasmenos_Click(sender As Object, e As EventArgs) Handles btnmasmenos.Click
        If txtpantalla.Text <> "" Then
            txtpantalla.Text = txtpantalla.Text * (-1)
        End If
    End Sub

    Private Sub btnexponente_Click(sender As Object, e As EventArgs) Handles btnexponente.Click
        txtresultado.Text = "(" & txtpantalla.Text & ")" & "²"
        txtpantalla.Text = Val((txtpantalla.Text) ^ (2))
    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        txtresultado.Text = "√" & "" & txtpantalla.Text & " "
        txtpantalla.Text = (Val(txtpantalla.Text)) ^ (1 / 2)
    End Sub

    Private Sub btnporcentaje_Click(sender As Object, e As EventArgs) Handles btnporcentaje.Click
        val2 = txtpantalla.Text
        txtresultado.Text = "% = (" & val1 & "×"
        resultado = (val1 * val2) / 100
        txtpantalla.Text = resultado
        txtresultado.Text = txtresultado.Text & val2 & ") + 100"
    End Sub

    Private Sub btnpi_Click(sender As Object, e As EventArgs) Handles btnpi.Click
        txtpantalla.Text = Math.PI
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("ANTEZANO MEJIA, JOSE LUIS", "DESARROLLADO POR: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.steam, AudioPlayMode.Background)
        PRINCIPAL.Show()
        Hide()
    End Sub

    Private Sub CALCULADORA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class