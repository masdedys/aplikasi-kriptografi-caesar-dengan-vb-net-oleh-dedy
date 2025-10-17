Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String = ""
        Dim xkalimat As String = ""
        For i = 1 To Len(TextBox3.Text)
            x = Mid(TextBox3.Text, i, 1)
            x = Chr(Asc(x) + 3)
            xkalimat = xkalimat + x
        Next
        TextBox1.Text = xkalimat
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As String = ""
        Dim xkalimat As String = ""
        For i = 1 To Len(TextBox3.Text)
            x = Mid(TextBox3.Text, i, 1)
            x = Chr(Asc(x) - 3)
            xkalimat = xkalimat + x
        Next
        TextBox2.Text = xkalimat
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tanya As String
        tanya = MsgBox("Anda Yakin Ingin Keluar ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If tanya = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub
End Class
