<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKatalog
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgvKatalog = New System.Windows.Forms.DataGridView()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblPS = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KatalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFormPesanan = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHargaTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.pnlSpace = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvKatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlFormPesanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1173)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1007, 24)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(72, 18)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SlabelJam.Size = New System.Drawing.Size(49, 18)
        Me.SlabelJam.Text = "Jam : "
        '
        'dgvKatalog
        '
        Me.dgvKatalog.BackgroundColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKatalog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKatalog.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKatalog.Location = New System.Drawing.Point(44, 167)
        Me.dgvKatalog.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvKatalog.Name = "dgvKatalog"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKatalog.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvKatalog.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvKatalog.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvKatalog.Size = New System.Drawing.Size(915, 283)
        Me.dgvKatalog.TabIndex = 9
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(329, 110)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(343, 31)
        Me.lblHeader.TabIndex = 11
        Me.lblHeader.Text = "KATALOG KPOP STORE"
        '
        'lblPS
        '
        Me.lblPS.AutoSize = True
        Me.lblPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPS.Location = New System.Drawing.Point(65, 480)
        Me.lblPS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPS.Name = "lblPS"
        Me.lblPS.Size = New System.Drawing.Size(500, 20)
        Me.lblPS.TabIndex = 13
        Me.lblPS.Text = "* Silahkan klik daftar katalog untuk melakukan pemesanan "
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1007, 44)
        Me.pnlTop.TabIndex = 59
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(935, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(72, 44)
        Me.pnlControl.TabIndex = 48
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.maximize15px
        Me.btnMinimize.Location = New System.Drawing.Point(3, 12)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(19, 18)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(43, 12)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 18)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfilTokoToolStripMenuItem, Me.KatalogToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ProfilToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 44)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1007, 26)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(63, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        '
        'KatalogToolStripMenuItem
        '
        Me.KatalogToolStripMenuItem.Name = "KatalogToolStripMenuItem"
        Me.KatalogToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.KatalogToolStripMenuItem.Text = "Katalog"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatPesananToolStripMenuItem, Me.BuatPesananToolStripMenuItem, Me.UbahPesananToolStripMenuItem, Me.HapusPesananToolStripMenuItem})
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(80, 22)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'LihatPesananToolStripMenuItem
        '
        Me.LihatPesananToolStripMenuItem.Name = "LihatPesananToolStripMenuItem"
        Me.LihatPesananToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.LihatPesananToolStripMenuItem.Text = "Lihat Pesanan"
        '
        'BuatPesananToolStripMenuItem
        '
        Me.BuatPesananToolStripMenuItem.Name = "BuatPesananToolStripMenuItem"
        Me.BuatPesananToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.BuatPesananToolStripMenuItem.Text = "Buat Pesanan"
        '
        'UbahPesananToolStripMenuItem
        '
        Me.UbahPesananToolStripMenuItem.Name = "UbahPesananToolStripMenuItem"
        Me.UbahPesananToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.UbahPesananToolStripMenuItem.Text = "Ubah Pesanan"
        '
        'HapusPesananToolStripMenuItem
        '
        Me.HapusPesananToolStripMenuItem.Name = "HapusPesananToolStripMenuItem"
        Me.HapusPesananToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.HapusPesananToolStripMenuItem.Text = "Batalkan Pesanan"
        '
        'ProfilToolStripMenuItem
        '
        Me.ProfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatProfilToolStripMenuItem, Me.UbahProfilToolStripMenuItem})
        Me.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        Me.ProfilToolStripMenuItem.Size = New System.Drawing.Size(56, 22)
        Me.ProfilToolStripMenuItem.Text = "Profil"
        '
        'LihatProfilToolStripMenuItem
        '
        Me.LihatProfilToolStripMenuItem.Name = "LihatProfilToolStripMenuItem"
        Me.LihatProfilToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.LihatProfilToolStripMenuItem.Text = "Lihat Profil"
        '
        'UbahProfilToolStripMenuItem
        '
        Me.UbahProfilToolStripMenuItem.Name = "UbahProfilToolStripMenuItem"
        Me.UbahProfilToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.UbahProfilToolStripMenuItem.Text = "Ubah Profil"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'pnlFormPesanan
        '
        Me.pnlFormPesanan.BackColor = System.Drawing.Color.Coral
        Me.pnlFormPesanan.Controls.Add(Me.btnClear)
        Me.pnlFormPesanan.Controls.Add(Me.Label12)
        Me.pnlFormPesanan.Controls.Add(Me.btnBatal)
        Me.pnlFormPesanan.Controls.Add(Me.btnPesan)
        Me.pnlFormPesanan.Controls.Add(Me.Label11)
        Me.pnlFormPesanan.Controls.Add(Me.txtHargaTotal)
        Me.pnlFormPesanan.Controls.Add(Me.Label10)
        Me.pnlFormPesanan.Controls.Add(Me.txtAlamat)
        Me.pnlFormPesanan.Controls.Add(Me.Label9)
        Me.pnlFormPesanan.Controls.Add(Me.txtDesc)
        Me.pnlFormPesanan.Controls.Add(Me.Label8)
        Me.pnlFormPesanan.Controls.Add(Me.txtHargaSatuan)
        Me.pnlFormPesanan.Controls.Add(Me.Label7)
        Me.pnlFormPesanan.Controls.Add(Me.txtJumlah)
        Me.pnlFormPesanan.Controls.Add(Me.Label6)
        Me.pnlFormPesanan.Controls.Add(Me.Label5)
        Me.pnlFormPesanan.Controls.Add(Me.txtKategori)
        Me.pnlFormPesanan.Controls.Add(Me.Label3)
        Me.pnlFormPesanan.Controls.Add(Me.txtNamaProduk)
        Me.pnlFormPesanan.Controls.Add(Me.Label2)
        Me.pnlFormPesanan.Controls.Add(Me.txtNama)
        Me.pnlFormPesanan.Location = New System.Drawing.Point(44, 561)
        Me.pnlFormPesanan.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFormPesanan.Name = "pnlFormPesanan"
        Me.pnlFormPesanan.Size = New System.Drawing.Size(915, 558)
        Me.pnlFormPesanan.TabIndex = 61
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_trash_50
        Me.btnClear.Location = New System.Drawing.Point(408, 416)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 94)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(385, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 31)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "PESANAN"
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_cancel_50
        Me.btnBatal.Location = New System.Drawing.Point(591, 416)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 94)
        Me.btnBatal.TabIndex = 21
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnPesan
        '
        Me.btnPesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesan.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_send_50
        Me.btnPesan.Location = New System.Drawing.Point(215, 416)
        Me.btnPesan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(100, 94)
        Me.btnPesan.TabIndex = 20
        Me.btnPesan.Text = "Pesan"
        Me.btnPesan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPesan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(505, 347)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Harga Total"
        '
        'txtHargaTotal
        '
        Me.txtHargaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaTotal.Location = New System.Drawing.Point(647, 342)
        Me.txtHargaTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHargaTotal.Name = "txtHargaTotal"
        Me.txtHargaTotal.Size = New System.Drawing.Size(201, 23)
        Me.txtHargaTotal.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(505, 220)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(647, 213)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(201, 95)
        Me.txtAlamat.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(505, 94)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Deskripsi Produk"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(647, 86)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(201, 94)
        Me.txtDesc.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 346)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Harga Satuan"
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaSatuan.Location = New System.Drawing.Point(185, 342)
        Me.txtHargaSatuan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.Size = New System.Drawing.Size(201, 23)
        Me.txtHargaSatuan.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(185, 281)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(201, 23)
        Me.txtJumlah.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 8
        '
        'txtKategori
        '
        Me.txtKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKategori.Location = New System.Drawing.Point(185, 218)
        Me.txtKategori.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(201, 23)
        Me.txtKategori.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nama Produk"
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaProduk.Location = New System.Drawing.Point(185, 153)
        Me.txtNamaProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(201, 23)
        Me.txtNamaProduk.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(185, 90)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(201, 23)
        Me.txtNama.TabIndex = 0
        '
        'pnlSpace
        '
        Me.pnlSpace.Location = New System.Drawing.Point(44, 1143)
        Me.pnlSpace.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSpace.Name = "pnlSpace"
        Me.pnlSpace.Size = New System.Drawing.Size(915, 30)
        Me.pnlSpace.TabIndex = 12
        '
        'formKatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1028, 554)
        Me.Controls.Add(Me.pnlFormPesanan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lblPS)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.dgvKatalog)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlSpace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formKatalog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvKatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlFormPesanan.ResumeLayout(False)
        Me.pnlFormPesanan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgvKatalog As DataGridView
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblPS As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KatalogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlFormPesanan As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnPesan As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtHargaTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHargaSatuan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents pnlSpace As Panel
End Class
