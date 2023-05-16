<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStaff
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManajemenBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Vela Sans GX", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilTokoToolStripMenuItem, Me.ManajemenBarangToolStripMenuItem, Me.ManajemenPesananToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManajemenBarangToolStripMenuItem
        '
        Me.ManajemenBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatBarangToolStripMenuItem, Me.TambahBarangToolStripMenuItem, Me.UbahBarangToolStripMenuItem, Me.HapusBarangToolStripMenuItem})
        Me.ManajemenBarangToolStripMenuItem.Name = "ManajemenBarangToolStripMenuItem"
        Me.ManajemenBarangToolStripMenuItem.Size = New System.Drawing.Size(125, 21)
        Me.ManajemenBarangToolStripMenuItem.Text = "Manajemen Produk"
        '
        'LihatBarangToolStripMenuItem
        '
        Me.LihatBarangToolStripMenuItem.Name = "LihatBarangToolStripMenuItem"
        Me.LihatBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LihatBarangToolStripMenuItem.Text = "Lihat Data Produk"
        '
        'TambahBarangToolStripMenuItem
        '
        Me.TambahBarangToolStripMenuItem.Name = "TambahBarangToolStripMenuItem"
        Me.TambahBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TambahBarangToolStripMenuItem.Text = "Tambah Data Produk"
        '
        'UbahBarangToolStripMenuItem
        '
        Me.UbahBarangToolStripMenuItem.Name = "UbahBarangToolStripMenuItem"
        Me.UbahBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UbahBarangToolStripMenuItem.Text = "Ubah Data Produk"
        '
        'HapusBarangToolStripMenuItem
        '
        Me.HapusBarangToolStripMenuItem.Name = "HapusBarangToolStripMenuItem"
        Me.HapusBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HapusBarangToolStripMenuItem.Text = "Hapus Data Produk"
        '
        'ManajemenPesananToolStripMenuItem
        '
        Me.ManajemenPesananToolStripMenuItem.Name = "ManajemenPesananToolStripMenuItem"
        Me.ManajemenPesananToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.ManajemenPesananToolStripMenuItem.Text = "Pesanan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(41, 21)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Vela Sans GX", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(59, 17)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.Size = New System.Drawing.Size(39, 17)
        Me.SlabelJam.Text = "Jam : "
        '
        'Timer1
        '
        '
        'lblUsn
        '
        Me.lblUsn.AutoSize = True
        Me.lblUsn.Font = New System.Drawing.Font("Vela Sans GX SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsn.Location = New System.Drawing.Point(329, 259)
        Me.lblUsn.Name = "lblUsn"
        Me.lblUsn.Size = New System.Drawing.Size(130, 33)
        Me.lblUsn.TabIndex = 11
        Me.lblUsn.Text = "username"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vela Sans GX", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 88)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Selamat Datang di" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Halaman Staff"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        '
        'formStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblUsn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "K-Pop Store"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManajemenBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblUsn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
End Class
