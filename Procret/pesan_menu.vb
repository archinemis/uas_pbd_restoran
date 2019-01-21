Imports System.Data.SqlClient
Public Class pesan_menu

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

        'panggil tb_book
        da = New SqlDataAdapter("select * from booking", conn)
        dt = New DataTable("Booking")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        dgv_menu.DataSource = dt

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
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub gb_pel_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub gb_book_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_carimn_Click(sender As Object, e As EventArgs) Handles btn_carimn.Click
        da = New SqlDataAdapter("select id_menu, nama_menu, harga, id_jenis from tb_menu", conn)
        dt = New DataTable("MENU")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey

        Dim rowcari As DataRow = dt.Rows.Find(tb_kd.Text)
        If rowcari Is Nothing Then
            MsgBox("Kode Menu Tidak Ada/Salah")
        Else
            tb_nm.Text = rowcari("nama_menu")
            tb_hrg.Text = rowcari("HARGA")
            cb_jm.SelectedValue = rowcari("ID_JENIS")

        End If

        Dim da_mn As New SqlDataAdapter("select id_menu, nama_menu, harga from tb_menu where id_menu ='" & tb_kd.Text & "'", conn)
        Dim dt_mn As New DataTable("MENU2")
        da_mn.Fill(dt_mn)
        dgv_menu.DataSource = dt_mn
    End Sub

    Private Sub dgv_menu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_menu.CellContentClick

    End Sub

    Private Sub pesan_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
        Pembelian.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        User.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class