<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManajemenProdukAdmin
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlFormProduk = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvProduk = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFormProduk.SuspendLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MANAJEMEN PRODUK"
        '
        'pnlFormProduk
        '
        Me.pnlFormProduk.BackColor = System.Drawing.Color.CadetBlue
        Me.pnlFormProduk.Controls.Add(Me.btnCancel)
        Me.pnlFormProduk.Controls.Add(Me.cmbKategori)
        Me.pnlFormProduk.Controls.Add(Me.Label12)
        Me.pnlFormProduk.Controls.Add(Me.btnClear)
        Me.pnlFormProduk.Controls.Add(Me.btnHapus)
        Me.pnlFormProduk.Controls.Add(Me.btnUbah)
        Me.pnlFormProduk.Controls.Add(Me.Label9)
        Me.pnlFormProduk.Controls.Add(Me.txtDesc)
        Me.pnlFormProduk.Controls.Add(Me.Label8)
        Me.pnlFormProduk.Controls.Add(Me.txtHarga)
        Me.pnlFormProduk.Controls.Add(Me.Label7)
        Me.pnlFormProduk.Controls.Add(Me.txtStok)
        Me.pnlFormProduk.Controls.Add(Me.Label6)
        Me.pnlFormProduk.Controls.Add(Me.Label5)
        Me.pnlFormProduk.Controls.Add(Me.Label3)
        Me.pnlFormProduk.Controls.Add(Me.txtNama)
        Me.pnlFormProduk.Controls.Add(Me.btnTambah)
        Me.pnlFormProduk.Location = New System.Drawing.Point(46, 368)
        Me.pnlFormProduk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlFormProduk.Name = "pnlFormProduk"
        Me.pnlFormProduk.Size = New System.Drawing.Size(689, 330)
        Me.pnlFormProduk.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_close_window_50
        Me.btnCancel.Location = New System.Drawing.Point(645, 17)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(26, 28)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbKategori
        '
        Me.cmbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Items.AddRange(New Object() {"Album", "Lightstick"})
        Me.cmbKategori.Location = New System.Drawing.Point(157, 136)
        Me.cmbKategori.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(152, 21)
        Me.cmbKategori.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(294, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 25)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "PRODUK"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_broom_50
        Me.btnClear.Location = New System.Drawing.Point(454, 249)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 64)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_trash_50
        Me.btnHapus.Location = New System.Drawing.Point(362, 249)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 64)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_sync_50
        Me.btnUbah.Location = New System.Drawing.Point(268, 249)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 64)
        Me.btnUbah.TabIndex = 14
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(359, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Deskripsi Produk"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(497, 136)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDesc.MaxLength = 50
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(152, 77)
        Me.txtDesc.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(359, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(497, 82)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHarga.MaxLength = 10
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(152, 20)
        Me.txtHarga.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(157, 187)
        Me.txtStok.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStok.MaxLength = 4
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(152, 20)
        Me.txtStok.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 7
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Produk"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(157, 84)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNama.MaxLength = 50
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(152, 20)
        Me.txtNama.TabIndex = 8
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_add_new_50
        Me.btnTambah.Location = New System.Drawing.Point(174, 249)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 64)
        Me.btnTambah.TabIndex = 13
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvProduk
        '
        Me.dgvProduk.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.dgvProduk.Location = New System.Drawing.Point(52, 135)
        Me.dgvProduk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvProduk.Name = "dgvProduk"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduk.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProduk.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProduk.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProduk.Size = New System.Drawing.Size(689, 199)
        Me.dgvProduk.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SandyBrown
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 698)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(741, 22)
        Me.StatusStrip1.TabIndex = 18
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
        Me.SlabelJam.Size = New System.Drawing.Size(40, 17)
        Me.SlabelJam.Text = "Jam : "
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(741, 36)
        Me.pnlTop.TabIndex = 57
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(687, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(54, 36)
        Me.pnlControl.TabIndex = 49
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.maximize15px
        Me.btnMinimize.Location = New System.Drawing.Point(2, 10)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(14, 15)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(32, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 15)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SandyBrown
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfilTokoToolStripMenuItem, Me.ManajemenStaffToolStripMenuItem, Me.ManajemenBarangToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 36)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(741, 24)
        Me.MenuStrip1.TabIndex = 3
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
        'ManajemenStaffToolStripMenuItem
        '
        Me.ManajemenStaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatAkunStaffToolStripMenuItem, Me.TambahAkunStaffToolStripMenuItem, Me.UbahAkunStaffToolStripMenuItem, Me.DeleteAkunStaffToolStripMenuItem})
        Me.ManajemenStaffToolStripMenuItem.Name = "ManajemenStaffToolStripMenuItem"
        Me.ManajemenStaffToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ManajemenStaffToolStripMenuItem.Text = "Manajemen Staff"
        '
        'LihatAkunStaffToolStripMenuItem
        '
        Me.LihatAkunStaffToolStripMenuItem.Name = "LihatAkunStaffToolStripMenuItem"
        Me.LihatAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LihatAkunStaffToolStripMenuItem.Text = "Lihat Akun Staff"
        '
        'TambahAkunStaffToolStripMenuItem
        '
        Me.TambahAkunStaffToolStripMenuItem.Name = "TambahAkunStaffToolStripMenuItem"
        Me.TambahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.TambahAkunStaffToolStripMenuItem.Text = "Tambah Akun Staff"
        '
        'UbahAkunStaffToolStripMenuItem
        '
        Me.UbahAkunStaffToolStripMenuItem.Name = "UbahAkunStaffToolStripMenuItem"
        Me.UbahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UbahAkunStaffToolStripMenuItem.Text = "Ubah Akun Staff"
        '
        'DeleteAkunStaffToolStripMenuItem
        '
        Me.DeleteAkunStaffToolStripMenuItem.Name = "DeleteAkunStaffToolStripMenuItem"
        Me.DeleteAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeleteAkunStaffToolStripMenuItem.Text = "Hapus Akun Staff"
        '
        'ManajemenBarangToolStripMenuItem
        '
        Me.ManajemenBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataProdukToolStripMenuItem, Me.TambahDataProdukToolStripMenuItem, Me.UbahDataProdukToolStripMenuItem, Me.HapusDataProdukToolStripMenuItem})
        Me.ManajemenBarangToolStripMenuItem.Name = "ManajemenBarangToolStripMenuItem"
        Me.ManajemenBarangToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.ManajemenBarangToolStripMenuItem.Text = "Manajemen Produk"
        '
        'LihatDataProdukToolStripMenuItem
        '
        Me.LihatDataProdukToolStripMenuItem.Name = "LihatDataProdukToolStripMenuItem"
        Me.LihatDataProdukToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LihatDataProdukToolStripMenuItem.Text = "Lihat Data Produk"
        '
        'TambahDataProdukToolStripMenuItem
        '
        Me.TambahDataProdukToolStripMenuItem.Name = "TambahDataProdukToolStripMenuItem"
        Me.TambahDataProdukToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.TambahDataProdukToolStripMenuItem.Text = "Tambah Data Produk"
        '
        'UbahDataProdukToolStripMenuItem
        '
        Me.UbahDataProdukToolStripMenuItem.Name = "UbahDataProdukToolStripMenuItem"
        Me.UbahDataProdukToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UbahDataProdukToolStripMenuItem.Text = "Ubah Data Produk"
        '
        'HapusDataProdukToolStripMenuItem
        '
        Me.HapusDataProdukToolStripMenuItem.Name = "HapusDataProdukToolStripMenuItem"
        Me.HapusDataProdukToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.HapusDataProdukToolStripMenuItem.Text = "Hapus Data Produk"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManajemenProdukAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(693, 410)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlFormProduk)
        Me.Controls.Add(Me.dgvProduk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManajemenProdukAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.pnlFormProduk.ResumeLayout(False)
        Me.pnlFormProduk.PerformLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents pnlFormProduk As Panel
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCancel As Button
End Class
