<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesan_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pesan_menu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_book = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_menu = New System.Windows.Forms.DataGridView()
        Me.p_update = New System.Windows.Forms.Panel()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_carimn = New System.Windows.Forms.Button()
        Me.cb_jm = New System.Windows.Forms.ComboBox()
        Me.tb_qty = New System.Windows.Forms.Label()
        Me.tb_hrg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_nm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_kd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p_update.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(348, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ini jam"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(198, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 49)
        Me.Panel2.TabIndex = 14
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 564)
        Me.Panel1.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(18, 239)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 1)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.dgv_menu)
        Me.Panel5.Controls.Add(Me.p_update)
        Me.Panel5.Controls.Add(Me.btn_book)
        Me.Panel5.Location = New System.Drawing.Point(210, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(801, 403)
        Me.Panel5.TabIndex = 15
        '
        'btn_book
        '
        Me.btn_book.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_book.Location = New System.Drawing.Point(547, 318)
        Me.btn_book.Name = "btn_book"
        Me.btn_book.Size = New System.Drawing.Size(204, 59)
        Me.btn_book.TabIndex = 15
        Me.btn_book.Text = "Booking"
        Me.btn_book.UseVisualStyleBackColor = True
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
        'dgv_menu
        '
        Me.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_menu.Location = New System.Drawing.Point(10, 50)
        Me.dgv_menu.Name = "dgv_menu"
        Me.dgv_menu.Size = New System.Drawing.Size(457, 327)
        Me.dgv_menu.TabIndex = 17
        '
        'p_update
        '
        Me.p_update.BackColor = System.Drawing.Color.White
        Me.p_update.Controls.Add(Me.Label6)
        Me.p_update.Controls.Add(Me.lbl)
        Me.p_update.Controls.Add(Me.btn_tambah)
        Me.p_update.Controls.Add(Me.btn_carimn)
        Me.p_update.Controls.Add(Me.cb_jm)
        Me.p_update.Controls.Add(Me.tb_qty)
        Me.p_update.Controls.Add(Me.tb_hrg)
        Me.p_update.Controls.Add(Me.Label9)
        Me.p_update.Controls.Add(Me.tb_nm)
        Me.p_update.Controls.Add(Me.Label8)
        Me.p_update.Controls.Add(Me.tb_kd)
        Me.p_update.Controls.Add(Me.Label7)
        Me.p_update.Location = New System.Drawing.Point(502, 50)
        Me.p_update.Name = "p_update"
        Me.p_update.Size = New System.Drawing.Size(285, 262)
        Me.p_update.TabIndex = 16
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(13, 225)
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
        'tb_qty
        '
        Me.tb_qty.AutoSize = True
        Me.tb_qty.Location = New System.Drawing.Point(12, 141)
        Me.tb_qty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tb_qty.Name = "tb_qty"
        Me.tb_qty.Size = New System.Drawing.Size(61, 13)
        Me.tb_qty.TabIndex = 6
        Me.tb_qty.Text = "Jenis Menu"
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
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(16, 188)
        Me.lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(111, 24)
        Me.lbl.TabIndex = 13
        Me.lbl.Text = "TOTAL Rp. "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Kode Booking"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 25)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(131, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "rp..."
        '
        'pesan_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 529)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "pesan_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pesan_menu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p_update.ResumeLayout(False)
        Me.p_update.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_book As Button
    Friend WithEvents dgv_menu As DataGridView
    Friend WithEvents p_update As Panel
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_carimn As Button
    Friend WithEvents cb_jm As ComboBox
    Friend WithEvents tb_qty As Label
    Friend WithEvents tb_hrg As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_nm As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_kd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl As Label
End Class
