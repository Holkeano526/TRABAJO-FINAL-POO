Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Clave As String
        Clave = txtClave.Text
        pbLogin.Maximum = 1000000
        If Clave = "123456" Then
            For i = 0 To 1000000
                pbLogin.Value = i
            Next
            PRINCIPAL.Show()
            Hide()
        Else
            MsgBox("CLAVE INCORRECTA", MsgBoxStyle.Critical, "ERROR!")
        End If
    End Sub
End Class
