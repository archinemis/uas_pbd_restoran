<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_pembelian = New System.Windows.Forms.Label()
        Me.lb_trx = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 42)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(324, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lb_pembelian
        '
        Me.lb_pembelian.AutoSize = True
        Me.lb_pembelian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_pembelian.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_pembelian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_pembelian.Location = New System.Drawing.Point(102, 115)
        Me.lb_pembelian.Name = "lb_pembelian"
        Me.lb_pembelian.Size = New System.Drawing.Size(155, 30)
        Me.lb_pembelian.TabIndex = 1
        Me.lb_pembelian.Text = "Pemesanan"
        '
        'lb_trx
        '
        Me.lb_trx.AutoSize = True
        Me.lb_trx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_trx.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_trx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_trx.Location = New System.Drawing.Point(102, 157)
        Me.lb_trx.Name = "lb_trx"
        Me.lb_trx.Size = New System.Drawing.Size(162, 30)
        Me.lb_trx.TabIndex = 2
        Me.lb_trx.Text = "Daftar Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(115, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Daftar User"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(104, 148)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 1)
        Me.Panel4.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(104, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 1)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(104, 232)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 1)
        Me.Panel3.TabIndex = 5
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(369, 323)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_trx)
        Me.Controls.Add(Me.lb_pembelian)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "welcome"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lb_pembelian As Label
    Friend WithEvents lb_trx As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
