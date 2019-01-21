Imports System.Data.SqlClient

Public Class Pembelian

    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        getData()
        awal()
        dt_a.Focus()
    End Sub
    Sub getData()
        Dim koneksi As String = ("server=DESKTOP-VV1HV3E; database=UTS_PBD; Integrated Security = True;")
        conn = New SqlConnection(koneksi)
        conn.Open()
    End Sub
    Sub awal()
        dt_a.Text = ""
        dt_b.Text = ""
        tb_dtl.Text = ""
        tb_kdpel.Text = ""
        tb_namapel.Text = ""
        tb_tlp.Text = ""
    End Sub

    Sub autonumber_book()
        getData()
        Dim a As String
        Dim b As String

        cmd = New SqlCommand("select * from booking order by id_booking desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.Read Then
            a = Mid(dr.Item("ID_BOOKING"), 2, 2)
            b = Val(b) + 1
            tb_kdb.Text = "B" + Mid("000", 1, 2 - b.Length) & b
        Else
            tb_kdb.Text = "B0001"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        daftar_menu.Show()
    End Sub
    Private Sub btn_rst_Click(sender As Object, e As EventArgs) Handles btn_rst.Click
        Call awal()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub gb_book_Enter(sender As Object, e As EventArgs) Handles gb_book.Enter

    End Sub

    Private Sub tb_kdb_TextChanged(sender As Object, e As EventArgs) Handles tb_kdb.TextChanged

    End Sub

    Private Sub btn_pesan_Click(sender As Object, e As EventArgs) Handles btn_pesan.Click
        Try
            'Call autonumber_book()
            If tb_kdb.Text = "" Or dt_a.Text = "" Or dt_b.Text = "" Or tb_kdpel.Text = "" Then
                MsgBox("SILAHKAN ISI FORM BOOKING DENGAN LENGKAP", MsgBoxStyle.Information, "Informasi")
            Else
                Call getData()
                Dim simpan_bk As New SqlCommand("Insert Into booking (id_booking, tanggal_booking, tanggal_acara) values
                    ('" & tb_kdb.Text & "',
                    '" & dt_a.Value.ToString("yyyy-MM-dd") & "',
                    '" & dt_b.Value.ToString("yyyy-MM-dd") & "')", conn)
                Dim xx = simpan_bk.ExecuteNonQuery()
                If xx = 1 Then
                    MsgBox("Data Booking Berhasil Disimpan", MsgBoxStyle.Information, "Sukses")
                    gb_book.Enabled = True
                Else
                    MsgBox("Data Booking Gagal Disimpan", MsgBoxStyle.Critical, "Gagal")
                End If
            End If

            Me.Close()
            pesan_menu.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb_note.Text = ""
        dt_note.Text = ""
        dt_nt.Text = ""
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
        daftar_menu.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        User.Show()
    End Sub
End Class