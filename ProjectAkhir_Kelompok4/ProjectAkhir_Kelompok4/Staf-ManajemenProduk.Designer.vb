﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManajemenProdukStaf
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlFormProduk = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDecs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvDaftarProduk = New System.Windows.Forms.DataGridView()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlFormProduk.SuspendLayout()
        CType(Me.dgvDaftarProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 935)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 24)
        Me.StatusStrip1.TabIndex = 18
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MANAJEMEN PRODUK"
        '
        'pnlFormProduk
        '
        Me.pnlFormProduk.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnlFormProduk.Controls.Add(Me.btnCancel)
        Me.pnlFormProduk.Controls.Add(Me.btnClear)
        Me.pnlFormProduk.Controls.Add(Me.btnUbah)
        Me.pnlFormProduk.Controls.Add(Me.cmbKategori)
        Me.pnlFormProduk.Controls.Add(Me.Label12)
        Me.pnlFormProduk.Controls.Add(Me.btnHapus)
        Me.pnlFormProduk.Controls.Add(Me.Label9)
        Me.pnlFormProduk.Controls.Add(Me.txtDecs)
        Me.pnlFormProduk.Controls.Add(Me.Label8)
        Me.pnlFormProduk.Controls.Add(Me.txtHarga)
        Me.pnlFormProduk.Controls.Add(Me.Label7)
        Me.pnlFormProduk.Controls.Add(Me.txtStok)
        Me.pnlFormProduk.Controls.Add(Me.Label6)
        Me.pnlFormProduk.Controls.Add(Me.Label5)
        Me.pnlFormProduk.Controls.Add(Me.Label3)
        Me.pnlFormProduk.Controls.Add(Me.txtNama)
        Me.pnlFormProduk.Controls.Add(Me.btnTambah)
        Me.pnlFormProduk.Location = New System.Drawing.Point(69, 566)
        Me.pnlFormProduk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFormProduk.Name = "pnlFormProduk"
        Me.pnlFormProduk.Size = New System.Drawing.Size(915, 369)
        Me.pnlFormProduk.TabIndex = 6
        Me.pnlFormProduk.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_close_window_50
        Me.btnCancel.Location = New System.Drawing.Point(849, 17)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(41, 39)
        Me.btnCancel.TabIndex = 53
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_broom_50
        Me.btnClear.Location = New System.Drawing.Point(503, 263)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 79)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_sync_50
        Me.btnUbah.Location = New System.Drawing.Point(353, 263)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(100, 79)
        Me.btnUbah.TabIndex = 17
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'cmbKategori
        '
        Me.cmbKategori.Enabled = False
        Me.cmbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Items.AddRange(New Object() {"Album", "Lightstick"})
        Me.cmbKategori.Location = New System.Drawing.Point(185, 166)
        Me.cmbKategori.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(201, 25)
        Me.cmbKategori.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(392, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 31)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "PRODUK"
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_remove_50
        Me.btnHapus.Location = New System.Drawing.Point(429, 263)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 79)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(460, 167)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Deskripsi Produk"
        '
        'txtDecs
        '
        Me.txtDecs.Enabled = False
        Me.txtDecs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecs.Location = New System.Drawing.Point(643, 161)
        Me.txtDecs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDecs.MaxLength = 50
        Me.txtDecs.Multiline = True
        Me.txtDecs.Name = "txtDecs"
        Me.txtDecs.Size = New System.Drawing.Size(201, 94)
        Me.txtDecs.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(460, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Enabled = False
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(643, 100)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHarga.MaxLength = 10
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(201, 23)
        Me.txtHarga.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 230)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Enabled = False
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(185, 228)
        Me.txtStok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStok.MaxLength = 50
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(201, 23)
        Me.txtStok.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 167)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 7
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Produk"
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(185, 100)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNama.MaxLength = 50
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(201, 23)
        Me.txtNama.TabIndex = 8
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_add_new_50
        Me.btnTambah.Location = New System.Drawing.Point(353, 263)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(100, 79)
        Me.btnTambah.TabIndex = 13
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvDaftarProduk
        '
        Me.dgvDaftarProduk.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDaftarProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDaftarProduk.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDaftarProduk.Location = New System.Drawing.Point(69, 187)
        Me.dgvDaftarProduk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDaftarProduk.Name = "dgvDaftarProduk"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarProduk.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDaftarProduk.RowHeadersWidth = 47
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvDaftarProduk.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDaftarProduk.Size = New System.Drawing.Size(915, 334)
        Me.dgvDaftarProduk.TabIndex = 5
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(984, 44)
        Me.pnlTop.TabIndex = 52
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(912, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(72, 44)
        Me.pnlControl.TabIndex = 50
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
        Me.MenuStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfilTokoToolStripMenuItem, Me.ManajemenBarangToolStripMenuItem, Me.ManajemenPesananToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 44)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 26)
        Me.MenuStrip1.TabIndex = 3
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
        'ManajemenBarangToolStripMenuItem
        '
        Me.ManajemenBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatProdukToolStripMenuItem, Me.TambahProdukToolStripMenuItem, Me.UbahProdukToolStripMenuItem, Me.HapusProdukToolStripMenuItem})
        Me.ManajemenBarangToolStripMenuItem.Name = "ManajemenBarangToolStripMenuItem"
        Me.ManajemenBarangToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ManajemenBarangToolStripMenuItem.Text = "Manajemen Produk"
        '
        'LihatProdukToolStripMenuItem
        '
        Me.LihatProdukToolStripMenuItem.Name = "LihatProdukToolStripMenuItem"
        Me.LihatProdukToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.LihatProdukToolStripMenuItem.Text = "Lihat Data Produk"
        '
        'TambahProdukToolStripMenuItem
        '
        Me.TambahProdukToolStripMenuItem.Name = "TambahProdukToolStripMenuItem"
        Me.TambahProdukToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.TambahProdukToolStripMenuItem.Text = "Tambah Data Produk"
        '
        'UbahProdukToolStripMenuItem
        '
        Me.UbahProdukToolStripMenuItem.Name = "UbahProdukToolStripMenuItem"
        Me.UbahProdukToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.UbahProdukToolStripMenuItem.Text = "Ubah Data Produk"
        '
        'HapusProdukToolStripMenuItem
        '
        Me.HapusProdukToolStripMenuItem.Name = "HapusProdukToolStripMenuItem"
        Me.HapusProdukToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.HapusProdukToolStripMenuItem.Text = "Hapus Data Produk"
        '
        'ManajemenPesananToolStripMenuItem
        '
        Me.ManajemenPesananToolStripMenuItem.Name = "ManajemenPesananToolStripMenuItem"
        Me.ManajemenPesananToolStripMenuItem.Size = New System.Drawing.Size(80, 22)
        Me.ManajemenPesananToolStripMenuItem.Text = "Pesanan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManajemenProdukStaf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(945, 526)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlFormProduk)
        Me.Controls.Add(Me.dgvDaftarProduk)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManajemenProdukStaf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlFormProduk.ResumeLayout(False)
        Me.pnlFormProduk.PerformLayout()
        CType(Me.dgvDaftarProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlFormProduk As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDecs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvDaftarProduk As DataGridView
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCancel As Button
End Class
