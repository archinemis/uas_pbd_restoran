Imports System.Data.SqlClient
Public Class daftar_menu

    Dim cmd As SqlCommand
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Sub getData()
        Dim koneksi As String = ("server=DESKTOP-VV1HV3E; database=UTS_PBD; Integrated Security = True;")
        conn = New SqlConnection(koneksi)
        conn.Open()
    End Sub

    Sub kondisiawal()
        getData()

        'panggil tb_menu
        da = New SqlDataAdapter("select id_menu 'ID_MENU', nama_menu 'NAMA', harga 'HARGA', ID_JENIS from tb_menu", conn)
        dt = New DataTable("Menu")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        dgv_menu.DataSource = dt

        tb_kd.Text = ""
        tb_nm.Text = ""
        tb_hrg.Text = ""

        btn_hps.Enabled = False
        btn_ubah.Enabled = False
        btn_tambah.Enabled = True

    End Sub

    Private Sub Awal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_kd.MaxLength = 6
        getData()
        kondisiawal()
        Timer1.Start()

        Try
            'cb jenis menu
            Dim dajm As New SqlDataAdapter("select ID_JENIS, jenis_menu from tb_jenis", conn)
            Dim dtjm As New DataTable("JENIS_MENU")
            dajm.Fill(dtjm)

            cb_jm.DataSource = dtjm
            cb_jm.DisplayMember = "JENIS_MENU"
            cb_jm.ValueMember = "ID_JENIS"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        User.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
        Pembelian.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles p_update.Paint

    End Sub

    Private Sub cb_jm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_jm.SelectedIndexChanged

    End Sub

    Private Sub cb_daftar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_daftar.SelectedIndexChanged
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        If cb_daftar.SelectedItem = "Makanan" Then
            Dim da_mk As New SqlDataAdapter("select id_menu, nama_menu, harga from tb_menu where id_jenis = 'jm_01'", conn)
            Dim dt_mk As New DataTable("MENU")

            da_mk.Fill(dt_mk)
            dgv_menu.DataSource = dt_mk
        ElseIf cb_daftar.SelectedItem = "Minuman" Then
            Dim da_mk As New SqlDataAdapter("select id_menu, nama_menu, harga from tb_menu where id_jenis = 'jm_02'", conn)
            Dim dt_mk As New DataTable("MENU")

            da_mk.Fill(dt_mk)
            dgv_menu.DataSource = dt_mk
        ElseIf cb_daftar.SelectedItem = "Camilan" Then
            Dim da_mk As New SqlDataAdapter("select id_menu, nama_menu, harga from tb_menu where id_jenis = 'jm_03'", conn)
            Dim dt_mk As New DataTable("MENU")

            da_mk.Fill(dt_mk)
            dgv_menu.DataSource = dt_mk
        End If

    End Sub

    Private Sub btn_carimn_Click(sender As Object, e As EventArgs) Handles btn_carimn.Click
        Dim rowcari As DataRow = dt.Rows.Find(tb_kd.Text)

        If rowcari Is Nothing Then
            MsgBox("Kode Menu Tidak Ada/Salah")
        Else
            tb_nm.Text = rowcari("NAMA")
            tb_hrg.Text = rowcari("HARGA")
            cb_jm.SelectedValue = rowcari("ID_JENIS")

            btn_hps.Enabled = True
            btn_ubah.Enabled = True
            btn_tambah.Enabled = False
        End If

        Dim da_mn As New SqlDataAdapter("select id_menu, nama_menu, harga from tb_menu where id_menu ='" & tb_kd.Text & "'", conn)
        Dim dt_mn As New DataTable("MENU2")
        da_mn.Fill(dt_mn)
        dgv_menu.DataSource = dt_mn
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Try
            If tb_nm.Text = "" Or tb_kd.Text = "" Or tb_hrg.Text = "" Then
                MsgBox("SILAHKAN ISI FORM DENGAN LENGKAP", MsgBoxStyle.Information, "Informasi")
            Else
                Call getData()
                Dim simpan As New SqlCommand("Insert Into tb_menu (id_menu, nama_menu, harga, id_jenis) values
                    ('" & tb_kd.Text & "',
                    '" & tb_nm.Text & "',
                    '" & tb_hrg.Text & "',
                    '" & cb_jm.SelectedValue & "')", conn)
                Dim x = simpan.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Sukses")
                    kondisiawal()
                Else
                    MsgBox("Data Gagal Disimpan", MsgBoxStyle.Critical, "Gagal")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_hps_Click(sender As Object, e As EventArgs) Handles btn_hps.Click
        Call getData()
        Dim hapus As New SqlCommand("DELETE tb_menu where id_menu = '" & tb_kd.Text & "'", conn)

        Dim x = hapus.ExecuteNonQuery()
        If x = 1 Then
            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
            kondisiawal()
        Else
            MsgBox("Data Gagal Dihapus", MsgBoxStyle.Critical, "Gagal")
        End If

    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Try
            Call getData()
            Dim ubah As New SqlCommand("UPDATE tb_menu (id_menu, nama_menu, harga, id_jenis) set 
                                nama_menu = '" & tb_nm.Text & "', 
                                harga = '" & tb_hrg.Text & "',
                                id_jenis = '" & cb_jm.SelectedValue & "'
                                where id_menu = '" & tb_kd.Text & "'", conn)
            Dim x = ubah.ExecuteNonQuery()
            If x = 1 Then
                MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Sukses")
                kondisiawal()
            Else
                MsgBox("Data Gagal Diubah", MsgBoxStyle.Critical, "Gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Call kondisiawal()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgv_menu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_menu.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class