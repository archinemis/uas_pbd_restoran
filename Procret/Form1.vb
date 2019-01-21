Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_TextChanged(sender As Object, e As EventArgs) Handles Button1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If uname.Text = "pbd" And pw.Text = "uas" Then
                Me.Hide()
                welcome.Show()
            Else
                MsgBox("USERNAME ATAU PASSWORD SALAH!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
End Class
