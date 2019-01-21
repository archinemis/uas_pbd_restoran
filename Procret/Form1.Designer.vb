<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.pw = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label1.Location = New System.Drawing.Point(41, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign In"
        '
        'uname
        '
        Me.uname.Depth = 0
        Me.uname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname.ForeColor = System.Drawing.Color.SteelBlue
        Me.uname.Hint = "Username"
        Me.uname.Location = New System.Drawing.Point(51, 200)
        Me.uname.MouseState = MaterialSkin.MouseState.HOVER
        Me.uname.Name = "uname"
        Me.uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.uname.SelectedText = ""
        Me.uname.SelectionLength = 0
        Me.uname.SelectionStart = 0
        Me.uname.Size = New System.Drawing.Size(283, 23)
        Me.uname.TabIndex = 1
        Me.uname.UseSystemPasswordChar = False
        '
        'pw
        '
        Me.pw.Depth = 0
        Me.pw.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw.ForeColor = System.Drawing.Color.SteelBlue
        Me.pw.Hint = "Password"
        Me.pw.Location = New System.Drawing.Point(51, 257)
        Me.pw.MouseState = MaterialSkin.MouseState.HOVER
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pw.SelectedText = ""
        Me.pw.SelectionLength = 0
        Me.pw.SelectionStart = 0
        Me.pw.Size = New System.Drawing.Size(283, 23)
        Me.pw.TabIndex = 2
        Me.pw.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(51, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(345, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(41, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 58)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sign"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(390, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "a"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents uname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pw As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
