<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAdmin
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsn = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SandyBrown
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 401)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(805, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(72, 17)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.Size = New System.Drawing.Size(46, 17)
        Me.SlabelJam.Text = "Jam : "
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(805, 36)
        Me.pnlTop.TabIndex = 50
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(751, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(54, 36)
        Me.pnlControl.TabIndex = 49
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
        Me.MenuStrip1.Size = New System.Drawing.Size(805, 28)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        '
        'ManajemenStaffToolStripMenuItem
        '
        Me.ManajemenStaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatAkunStaffToolStripMenuItem, Me.TambahAkunStaffToolStripMenuItem, Me.UbahAkunStaffToolStripMenuItem, Me.DeleteAkunStaffToolStripMenuItem})
        Me.ManajemenStaffToolStripMenuItem.Name = "ManajemenStaffToolStripMenuItem"
        Me.ManajemenStaffToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.ManajemenStaffToolStripMenuItem.Text = "Manajemen Staff"
        '
        'LihatAkunStaffToolStripMenuItem
        '
        Me.LihatAkunStaffToolStripMenuItem.Name = "LihatAkunStaffToolStripMenuItem"
        Me.LihatAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.LihatAkunStaffToolStripMenuItem.Text = "Lihat Akun Staff"
        '
        'TambahAkunStaffToolStripMenuItem
        '
        Me.TambahAkunStaffToolStripMenuItem.Name = "TambahAkunStaffToolStripMenuItem"
        Me.TambahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.TambahAkunStaffToolStripMenuItem.Text = "Tambah Akun Staff"
        '
        'UbahAkunStaffToolStripMenuItem
        '
        Me.UbahAkunStaffToolStripMenuItem.Name = "UbahAkunStaffToolStripMenuItem"
        Me.UbahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.UbahAkunStaffToolStripMenuItem.Text = "Ubah Akun Staff"
        '
        'DeleteAkunStaffToolStripMenuItem
        '
        Me.DeleteAkunStaffToolStripMenuItem.Name = "DeleteAkunStaffToolStripMenuItem"
        Me.DeleteAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.DeleteAkunStaffToolStripMenuItem.Text = "Hapus Akun Staff"
        '
        'ManajemenBarangToolStripMenuItem
        '
        Me.ManajemenBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataProdukToolStripMenuItem, Me.TambahDataProdukToolStripMenuItem, Me.UbahDataProdukToolStripMenuItem, Me.HapusDataProdukToolStripMenuItem})
        Me.ManajemenBarangToolStripMenuItem.Name = "ManajemenBarangToolStripMenuItem"
        Me.ManajemenBarangToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.ManajemenBarangToolStripMenuItem.Text = "Manajemen Produk"
        '
        'LihatDataProdukToolStripMenuItem
        '
        Me.LihatDataProdukToolStripMenuItem.Name = "LihatDataProdukToolStripMenuItem"
        Me.LihatDataProdukToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.LihatDataProdukToolStripMenuItem.Text = "Lihat Data Produk"
        '
        'TambahDataProdukToolStripMenuItem
        '
        Me.TambahDataProdukToolStripMenuItem.Name = "TambahDataProdukToolStripMenuItem"
        Me.TambahDataProdukToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.TambahDataProdukToolStripMenuItem.Text = "Tambah Data Produk"
        '
        'UbahDataProdukToolStripMenuItem
        '
        Me.UbahDataProdukToolStripMenuItem.Name = "UbahDataProdukToolStripMenuItem"
        Me.UbahDataProdukToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.UbahDataProdukToolStripMenuItem.Text = "Ubah Data Produk"
        '
        'HapusDataProdukToolStripMenuItem
        '
        Me.HapusDataProdukToolStripMenuItem.Name = "HapusDataProdukToolStripMenuItem"
        Me.HapusDataProdukToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.HapusDataProdukToolStripMenuItem.Text = "Hapus Data Produk"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.bgPageAdmin
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblUsn)
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 342)
        Me.Panel1.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 24.21818!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(0, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(802, 115)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selamat Datang"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsn
        '
        Me.lblUsn.BackColor = System.Drawing.Color.Transparent
        Me.lblUsn.Font = New System.Drawing.Font("Palatino Linotype", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsn.ForeColor = System.Drawing.Color.DimGray
        Me.lblUsn.Location = New System.Drawing.Point(-1, 241)
        Me.lblUsn.Name = "lblUsn"
        Me.lblUsn.Size = New System.Drawing.Size(809, 44)
        Me.lblUsn.TabIndex = 50
        Me.lblUsn.Text = "username"
        Me.lblUsn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'formAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(805, 423)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "K-Pop Store"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsn As Label
End Class
