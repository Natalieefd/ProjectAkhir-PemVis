<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManajemenProdulAdmin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlFomProduk = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvProduk = New System.Windows.Forms.DataGridView()
        Me.pnlSpace = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFomProduk.SuspendLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(265, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 28)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "MANAJEMEN PRODUK"
        '
        'pnlFomProduk
        '
        Me.pnlFomProduk.Controls.Add(Me.Label12)
        Me.pnlFomProduk.Controls.Add(Me.btnClear)
        Me.pnlFomProduk.Controls.Add(Me.btnHapus)
        Me.pnlFomProduk.Controls.Add(Me.btnUbah)
        Me.pnlFomProduk.Controls.Add(Me.Label9)
        Me.pnlFomProduk.Controls.Add(Me.txtDesc)
        Me.pnlFomProduk.Controls.Add(Me.Label8)
        Me.pnlFomProduk.Controls.Add(Me.txtHarga)
        Me.pnlFomProduk.Controls.Add(Me.Label7)
        Me.pnlFomProduk.Controls.Add(Me.txtStok)
        Me.pnlFomProduk.Controls.Add(Me.Label6)
        Me.pnlFomProduk.Controls.Add(Me.Label5)
        Me.pnlFomProduk.Controls.Add(Me.txtKategori)
        Me.pnlFomProduk.Controls.Add(Me.Label3)
        Me.pnlFomProduk.Controls.Add(Me.txtNama)
        Me.pnlFomProduk.Controls.Add(Me.btnTambah)
        Me.pnlFomProduk.Location = New System.Drawing.Point(41, 425)
        Me.pnlFomProduk.Name = "pnlFomProduk"
        Me.pnlFomProduk.Size = New System.Drawing.Size(686, 300)
        Me.pnlFomProduk.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(294, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 28)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "PRODUK"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(519, 251)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 27)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(380, 251)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 27)
        Me.btnHapus.TabIndex = 21
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(241, 251)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 27)
        Me.btnUbah.TabIndex = 20
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(376, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Deskripsi Produk"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(482, 131)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(152, 77)
        Me.txtDesc.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(377, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(482, 81)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(152, 23)
        Me.txtHarga.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(139, 185)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(152, 23)
        Me.txtStok.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 8
        '
        'txtKategori
        '
        Me.txtKategori.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKategori.Location = New System.Drawing.Point(139, 134)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(152, 23)
        Me.txtKategori.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nama Produk"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(139, 81)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(152, 23)
        Me.txtNama.TabIndex = 5
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(99, 251)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 27)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvProduk
        '
        Me.dgvProduk.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduk.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProduk.Location = New System.Drawing.Point(41, 117)
        Me.dgvProduk.Name = "dgvProduk"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduk.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProduk.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProduk.Size = New System.Drawing.Size(686, 271)
        Me.dgvProduk.TabIndex = 52
        '
        'pnlSpace
        '
        Me.pnlSpace.Location = New System.Drawing.Point(41, 731)
        Me.pnlSpace.Name = "pnlSpace"
        Me.pnlSpace.Size = New System.Drawing.Size(686, 24)
        Me.pnlSpace.TabIndex = 51
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Vela Sans GX", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 755)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 56
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
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Vela Sans GX", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilTokoToolStripMenuItem, Me.ManajemenStaffToolStripMenuItem, Me.ManajemenBarangToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 55
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        '
        'ManajemenStaffToolStripMenuItem
        '
        Me.ManajemenStaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatAkunStaffToolStripMenuItem, Me.TambahAkunStaffToolStripMenuItem, Me.UbahAkunStaffToolStripMenuItem, Me.DeleteAkunStaffToolStripMenuItem})
        Me.ManajemenStaffToolStripMenuItem.Name = "ManajemenStaffToolStripMenuItem"
        Me.ManajemenStaffToolStripMenuItem.Size = New System.Drawing.Size(114, 21)
        Me.ManajemenStaffToolStripMenuItem.Text = "Manajemen Staff"
        '
        'LihatAkunStaffToolStripMenuItem
        '
        Me.LihatAkunStaffToolStripMenuItem.Name = "LihatAkunStaffToolStripMenuItem"
        Me.LihatAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LihatAkunStaffToolStripMenuItem.Text = "Lihat Akun Staff"
        '
        'TambahAkunStaffToolStripMenuItem
        '
        Me.TambahAkunStaffToolStripMenuItem.Name = "TambahAkunStaffToolStripMenuItem"
        Me.TambahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.TambahAkunStaffToolStripMenuItem.Text = "Tambah Akun Staff"
        '
        'UbahAkunStaffToolStripMenuItem
        '
        Me.UbahAkunStaffToolStripMenuItem.Name = "UbahAkunStaffToolStripMenuItem"
        Me.UbahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.UbahAkunStaffToolStripMenuItem.Text = "Ubah Akun Staff"
        '
        'DeleteAkunStaffToolStripMenuItem
        '
        Me.DeleteAkunStaffToolStripMenuItem.Name = "DeleteAkunStaffToolStripMenuItem"
        Me.DeleteAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DeleteAkunStaffToolStripMenuItem.Text = "Hapus Akun Staff"
        '
        'ManajemenBarangToolStripMenuItem
        '
        Me.ManajemenBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataBarangToolStripMenuItem, Me.TambahDataBarangToolStripMenuItem, Me.UbahDataBarangToolStripMenuItem, Me.HapusDataBarangToolStripMenuItem})
        Me.ManajemenBarangToolStripMenuItem.Name = "ManajemenBarangToolStripMenuItem"
        Me.ManajemenBarangToolStripMenuItem.Size = New System.Drawing.Size(125, 21)
        Me.ManajemenBarangToolStripMenuItem.Text = "Manajemen Produk"
        '
        'LihatDataBarangToolStripMenuItem
        '
        Me.LihatDataBarangToolStripMenuItem.Name = "LihatDataBarangToolStripMenuItem"
        Me.LihatDataBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LihatDataBarangToolStripMenuItem.Text = "Lihat Data Produk"
        '
        'TambahDataBarangToolStripMenuItem
        '
        Me.TambahDataBarangToolStripMenuItem.Name = "TambahDataBarangToolStripMenuItem"
        Me.TambahDataBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TambahDataBarangToolStripMenuItem.Text = "Tambah Data Produk"
        '
        'UbahDataBarangToolStripMenuItem
        '
        Me.UbahDataBarangToolStripMenuItem.Name = "UbahDataBarangToolStripMenuItem"
        Me.UbahDataBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UbahDataBarangToolStripMenuItem.Text = "Ubah Data Produk"
        '
        'HapusDataBarangToolStripMenuItem
        '
        Me.HapusDataBarangToolStripMenuItem.Name = "HapusDataBarangToolStripMenuItem"
        Me.HapusDataBarangToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HapusDataBarangToolStripMenuItem.Text = "Hapus Data Produk"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(41, 21)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManajemenProdulAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(817, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlFomProduk)
        Me.Controls.Add(Me.dgvProduk)
        Me.Controls.Add(Me.pnlSpace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManajemenProdulAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.pnlFomProduk.ResumeLayout(False)
        Me.pnlFomProduk.PerformLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents pnlFomProduk As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents pnlSpace As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
