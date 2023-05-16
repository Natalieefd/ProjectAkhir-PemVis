<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarPesanan
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDaftarPesanan = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvDaftarPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Vela Sans GX", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 11
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilTokoToolStripMenuItem, Me.ManajemenBarangToolStripMenuItem, Me.ManajemenPesananToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DAFTAR PESANAN"
        '
        'dgvDaftarPesanan
        '
        Me.dgvDaftarPesanan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarPesanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDaftarPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDaftarPesanan.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDaftarPesanan.Location = New System.Drawing.Point(57, 136)
        Me.dgvDaftarPesanan.Name = "dgvDaftarPesanan"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarPesanan.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvDaftarPesanan.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvDaftarPesanan.Size = New System.Drawing.Size(686, 251)
        Me.dgvDaftarPesanan.TabIndex = 12
        '
        'DaftarPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvDaftarPesanan)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DaftarPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvDaftarPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvDaftarPesanan As DataGridView
End Class
