<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class daftar_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daftar_menu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.p_update = New System.Windows.Forms.Panel()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_carimn = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_hps = New System.Windows.Forms.Button()
        Me.cb_jm = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_hrg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_nm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_kd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_menu = New System.Windows.Forms.DataGridView()
        Me.cb_daftar = New System.Windows.Forms.ComboBox()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p_update.SuspendLayout()
        CType(Me.dgv_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 564)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(18, 189)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(160, 1)
        Me.Panel6.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pemesanan"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(18, 295)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 1)
        Me.Panel3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Daftar User"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(18, 239)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 1)
        Me.Panel4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Menu"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(198, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 49)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(780, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(359, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ini jam"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(990, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 34)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'p_update
        '
        Me.p_update.BackColor = System.Drawing.Color.White
        Me.p_update.Controls.Add(Me.btn_tambah)
        Me.p_update.Controls.Add(Me.btn_carimn)
        Me.p_update.Controls.Add(Me.btn_ubah)
        Me.p_update.Controls.Add(Me.btn_hps)
        Me.p_update.Controls.Add(Me.cb_jm)
        Me.p_update.Controls.Add(Me.Label10)
        Me.p_update.Controls.Add(Me.tb_hrg)
        Me.p_update.Controls.Add(Me.Label9)
        Me.p_update.Controls.Add(Me.tb_nm)
        Me.p_update.Controls.Add(Me.Label8)
        Me.p_update.Controls.Add(Me.tb_kd)
        Me.p_update.Controls.Add(Me.Label7)
        Me.p_update.Location = New System.Drawing.Point(726, 115)
        Me.p_update.Name = "p_update"
        Me.p_update.Size = New System.Drawing.Size(285, 254)
        Me.p_update.TabIndex = 2
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(13, 190)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(260, 25)
        Me.btn_tambah.TabIndex = 12
        Me.btn_tambah.Text = "TAMBAH"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_carimn
        '
        Me.btn_carimn.Location = New System.Drawing.Point(189, 23)
        Me.btn_carimn.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_carimn.Name = "btn_carimn"
        Me.btn_carimn.Size = New System.Drawing.Size(84, 25)
        Me.btn_carimn.TabIndex = 11
        Me.btn_carimn.Text = "Cari"
        Me.btn_carimn.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Enabled = False
        Me.btn_ubah.Location = New System.Drawing.Point(13, 219)
        Me.btn_ubah.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(126, 25)
        Me.btn_ubah.TabIndex = 10
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_hps
        '
        Me.btn_hps.Enabled = False
        Me.btn_hps.Location = New System.Drawing.Point(148, 219)
        Me.btn_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hps.Name = "btn_hps"
        Me.btn_hps.Size = New System.Drawing.Size(125, 25)
        Me.btn_hps.TabIndex = 9
        Me.btn_hps.Text = "Hapus"
        Me.btn_hps.UseVisualStyleBackColor = True
        '
        'cb_jm
        '
        Me.cb_jm.FormattingEnabled = True
        Me.cb_jm.Items.AddRange(New Object() {"Makanan", "Minuman", "Camilan"})
        Me.cb_jm.Location = New System.Drawing.Point(13, 156)
        Me.cb_jm.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_jm.Name = "cb_jm"
        Me.cb_jm.Size = New System.Drawing.Size(172, 21)
        Me.cb_jm.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 141)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Jenis Menu"
        '
        'tb_hrg
        '
        Me.tb_hrg.Location = New System.Drawing.Point(14, 112)
        Me.tb_hrg.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_hrg.Name = "tb_hrg"
        Me.tb_hrg.Size = New System.Drawing.Size(171, 20)
        Me.tb_hrg.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Harga Menu"
        '
        'tb_nm
        '
        Me.tb_nm.Location = New System.Drawing.Point(14, 70)
        Me.tb_nm.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nm.Name = "tb_nm"
        Me.tb_nm.Size = New System.Drawing.Size(171, 20)
        Me.tb_nm.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nama Menu"
        '
        'tb_kd
        '
        Me.tb_kd.Location = New System.Drawing.Point(14, 26)
        Me.tb_kd.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_kd.Name = "tb_kd"
        Me.tb_kd.Size = New System.Drawing.Size(171, 20)
        Me.tb_kd.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Kode Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Daftar Menu"
        '
        'dgv_menu
        '
        Me.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_menu.Location = New System.Drawing.Point(234, 115)
        Me.dgv_menu.Name = "dgv_menu"
        Me.dgv_menu.Size = New System.Drawing.Size(457, 327)
        Me.dgv_menu.TabIndex = 7
        '
        'cb_daftar
        '
        Me.cb_daftar.FormattingEnabled = True
        Me.cb_daftar.Items.AddRange(New Object() {"Makanan", "Minuman", "Camilan"})
        Me.cb_daftar.Location = New System.Drawing.Point(307, 88)
        Me.cb_daftar.Name = "cb_daftar"
        Me.cb_daftar.Size = New System.Drawing.Size(94, 21)
        Me.cb_daftar.TabIndex = 8
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(406, 85)
        Me.btn_cari.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(70, 25)
        Me.btn_cari.TabIndex = 11
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(231, 90)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Jenis Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(722, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Update Menu"
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(949, 72)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(53, 38)
        Me.btn_reset.TabIndex = 13
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'daftar_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1023, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.cb_daftar)
        Me.Controls.Add(Me.dgv_menu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.p_update)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "daftar_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "c"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p_update.ResumeLayout(False)
        Me.p_update.PerformLayout()
        CType(Me.dgv_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents p_update As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cb_jm As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_hrg As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_nm As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_kd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_hps As Button
    Friend WithEvents dgv_menu As DataGridView
    Friend WithEvents cb_daftar As ComboBox
    Friend WithEvents btn_cari As Button
    Friend WithEvents btn_carimn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_reset As Button
End Class
