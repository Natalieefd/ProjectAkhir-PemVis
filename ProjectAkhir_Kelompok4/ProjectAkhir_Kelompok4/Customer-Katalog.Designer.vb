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
        Me.btnMaximize = New System.Windows.Forms.Button()
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 953)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(747, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(61, 17)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SlabelJam.Size = New System.Drawing.Size(40, 17)
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
        Me.dgvKatalog.Location = New System.Drawing.Point(33, 136)
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
        Me.dgvKatalog.Size = New System.Drawing.Size(686, 230)
        Me.dgvKatalog.TabIndex = 2
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(247, 89)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(271, 25)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "KATALOG KPOP STORE"
        '
        'lblPS
        '
        Me.lblPS.AutoSize = True
        Me.lblPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPS.Location = New System.Drawing.Point(49, 390)
        Me.lblPS.Name = "lblPS"
        Me.lblPS.Size = New System.Drawing.Size(413, 16)
        Me.lblPS.TabIndex = 1
        Me.lblPS.Text = "* Silahkan klik daftar katalog untuk melakukan pemesanan "
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(747, 36)
        Me.pnlTop.TabIndex = 59
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnMaximize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(666, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(81, 36)
        Me.pnlControl.TabIndex = 48
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.minimize15px
        Me.btnMinimize.Location = New System.Drawing.Point(9, 11)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(14, 15)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.maximize15px
        Me.btnMaximize.Location = New System.Drawing.Point(34, 11)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(14, 15)
        Me.btnMaximize.TabIndex = 18
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(58, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 15)
        Me.btnClose.TabIndex = 17
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfilTokoToolStripMenuItem, Me.KatalogToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ProfilToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 36)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        '
        'KatalogToolStripMenuItem
        '
        Me.KatalogToolStripMenuItem.Name = "KatalogToolStripMenuItem"
        Me.KatalogToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.KatalogToolStripMenuItem.Text = "Katalog"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatPesananToolStripMenuItem, Me.BuatPesananToolStripMenuItem, Me.UbahPesananToolStripMenuItem, Me.HapusPesananToolStripMenuItem})
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'LihatPesananToolStripMenuItem
        '
        Me.LihatPesananToolStripMenuItem.Name = "LihatPesananToolStripMenuItem"
        Me.LihatPesananToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LihatPesananToolStripMenuItem.Text = "Lihat Pesanan"
        '
        'BuatPesananToolStripMenuItem
        '
        Me.BuatPesananToolStripMenuItem.Name = "BuatPesananToolStripMenuItem"
        Me.BuatPesananToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.BuatPesananToolStripMenuItem.Text = "Buat Pesanan"
        '
        'UbahPesananToolStripMenuItem
        '
        Me.UbahPesananToolStripMenuItem.Name = "UbahPesananToolStripMenuItem"
        Me.UbahPesananToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.UbahPesananToolStripMenuItem.Text = "Ubah Pesanan"
        '
        'HapusPesananToolStripMenuItem
        '
        Me.HapusPesananToolStripMenuItem.Name = "HapusPesananToolStripMenuItem"
        Me.HapusPesananToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.HapusPesananToolStripMenuItem.Text = "Batalkan Pesanan"
        '
        'ProfilToolStripMenuItem
        '
        Me.ProfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatProfilToolStripMenuItem, Me.UbahProfilToolStripMenuItem})
        Me.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        Me.ProfilToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ProfilToolStripMenuItem.Text = "Profil"
        '
        'LihatProfilToolStripMenuItem
        '
        Me.LihatProfilToolStripMenuItem.Name = "LihatProfilToolStripMenuItem"
        Me.LihatProfilToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LihatProfilToolStripMenuItem.Text = "Lihat Profil"
        '
        'UbahProfilToolStripMenuItem
        '
        Me.UbahProfilToolStripMenuItem.Name = "UbahProfilToolStripMenuItem"
        Me.UbahProfilToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UbahProfilToolStripMenuItem.Text = "Ubah Profil"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
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
        Me.pnlFormPesanan.Location = New System.Drawing.Point(33, 456)
        Me.pnlFormPesanan.Name = "pnlFormPesanan"
        Me.pnlFormPesanan.Size = New System.Drawing.Size(686, 453)
        Me.pnlFormPesanan.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_trash_50
        Me.btnClear.Location = New System.Drawing.Point(306, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 76)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(289, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 25)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "PESANAN"
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_cancel_50
        Me.btnBatal.Location = New System.Drawing.Point(443, 338)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 76)
        Me.btnBatal.TabIndex = 15
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnPesan
        '
        Me.btnPesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesan.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_send_50
        Me.btnPesan.Location = New System.Drawing.Point(161, 338)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(75, 76)
        Me.btnPesan.TabIndex = 13
        Me.btnPesan.Text = "Pesan"
        Me.btnPesan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPesan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(379, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Harga Total"
        '
        'txtHargaTotal
        '
        Me.txtHargaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaTotal.Location = New System.Drawing.Point(485, 278)
        Me.txtHargaTotal.Name = "txtHargaTotal"
        Me.txtHargaTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtHargaTotal.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(379, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(485, 173)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(152, 78)
        Me.txtAlamat.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(379, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Deskripsi Produk"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(485, 70)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(152, 77)
        Me.txtDesc.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Harga Satuan"
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaSatuan.Location = New System.Drawing.Point(139, 278)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.Size = New System.Drawing.Size(152, 20)
        Me.txtHargaSatuan.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(139, 228)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(152, 20)
        Me.txtJumlah.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 8
        '
        'txtKategori
        '
        Me.txtKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKategori.Location = New System.Drawing.Point(139, 177)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(152, 20)
        Me.txtKategori.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Produk"
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaProduk.Location = New System.Drawing.Point(139, 124)
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(152, 20)
        Me.txtNamaProduk.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(139, 73)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(152, 20)
        Me.txtNama.TabIndex = 5
        '
        'pnlSpace
        '
        Me.pnlSpace.Location = New System.Drawing.Point(33, 929)
        Me.pnlSpace.Name = "pnlSpace"
        Me.pnlSpace.Size = New System.Drawing.Size(686, 24)
        Me.pnlSpace.TabIndex = 16
        '
        'formKatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(764, 450)
        Me.Controls.Add(Me.pnlFormPesanan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lblPS)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.dgvKatalog)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlSpace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents btnMaximize As Button
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
