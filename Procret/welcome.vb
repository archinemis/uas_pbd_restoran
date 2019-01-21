Public Class welcome
    Private Sub lb_pembelian_Click(sender As Object, e As EventArgs) Handles lb_pembelian.Click
        Me.Close()
        Pembelian.Show()
    End Sub

    Private Sub lb_trx_Click(sender As Object, e As EventArgs) Handles lb_trx.Click
        Me.Close()
        daftar_menu.Show()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class