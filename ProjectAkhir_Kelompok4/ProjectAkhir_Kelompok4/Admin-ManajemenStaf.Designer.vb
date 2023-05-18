<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManajemenStaf
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pmlSpace = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlFormAkun = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsn = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.dgvAkunStaf = New System.Windows.Forms.DataGridView()
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
        Me.StatusStrip1.SuspendLayout()
        Me.pnlFormAkun.SuspendLayout()
        CType(Me.dgvAkunStaf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Vela Sans GX", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 766)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(817, 22)
        Me.StatusStrip1.TabIndex = 16
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
        'pmlSpace
        '
        Me.pmlSpace.Location = New System.Drawing.Point(53, 742)
        Me.pmlSpace.Name = "pmlSpace"
        Me.pmlSpace.Size = New System.Drawing.Size(686, 24)
        Me.pmlSpace.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(293, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DAFTAR AKUN STAF"
        '
        'pnlFormAkun
        '
        Me.pnlFormAkun.Controls.Add(Me.Label12)
        Me.pnlFormAkun.Controls.Add(Me.btnClear)
        Me.pnlFormAkun.Controls.Add(Me.btnHapus)
        Me.pnlFormAkun.Controls.Add(Me.btnUbah)
        Me.pnlFormAkun.Controls.Add(Me.Label6)
        Me.pnlFormAkun.Controls.Add(Me.txtPass)
        Me.pnlFormAkun.Controls.Add(Me.Label3)
        Me.pnlFormAkun.Controls.Add(Me.txtUsn)
        Me.pnlFormAkun.Controls.Add(Me.btnTambah)
        Me.pnlFormAkun.Controls.Add(Me.Label2)
        Me.pnlFormAkun.Controls.Add(Me.txtNama)
        Me.pnlFormAkun.Location = New System.Drawing.Point(102, 418)
        Me.pnlFormAkun.Name = "pnlFormAkun"
        Me.pnlFormAkun.Size = New System.Drawing.Size(580, 318)
        Me.pnlFormAkun.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(159, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(257, 28)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "MANAJEMEN AKUN STAF"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(463, 266)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 27)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(324, 266)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 27)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(185, 266)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 27)
        Me.btnUbah.TabIndex = 12
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(211, 195)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(184, 23)
        Me.txtPass.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Username"
        '
        'txtUsn
        '
        Me.txtUsn.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsn.Location = New System.Drawing.Point(211, 142)
        Me.txtUsn.Name = "txtUsn"
        Me.txtUsn.Size = New System.Drawing.Size(184, 23)
        Me.txtUsn.TabIndex = 9
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(43, 266)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 27)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(211, 91)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(184, 23)
        Me.txtNama.TabIndex = 8
        '
        'dgvAkunStaf
        '
        Me.dgvAkunStaf.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAkunStaf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAkunStaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAkunStaf.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAkunStaf.Location = New System.Drawing.Point(55, 147)
        Me.dgvAkunStaf.Name = "dgvAkunStaf"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAkunStaf.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvAkunStaf.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAkunStaf.Size = New System.Drawing.Size(686, 241)
        Me.dgvAkunStaf.TabIndex = 5
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(817, 36)
        Me.pnlTop.TabIndex = 59
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(763, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(2)
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
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
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
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 15)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfilTokoToolStripMenuItem, Me.ManajemenStaffToolStripMenuItem, Me.ManajemenBarangToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 36)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(817, 24)
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
        'ManajemenStaf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(834, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pmlSpace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlFormAkun)
        Me.Controls.Add(Me.dgvAkunStaf)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManajemenStaf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlFormAkun.ResumeLayout(False)
        Me.pnlFormAkun.PerformLayout()
        CType(Me.dgvAkunStaf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents pmlSpace As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlFormAkun As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsn As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents dgvAkunStaf As DataGridView
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
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
End Class
