Public Class DaftarPesananStaf

    Private Sub ShowForm(Optional State = True)
        Label4.Hide()
        dgvDaftarPesanan.Hide()
        btnLaporan.Hide()
        pnlUbahStatus.Show()
        pnlUbahStatus.Location = New Point(40, 85)
        pnlSpace.Show()
        pnlSpace.Location = New Point(40, 530)
    End Sub

    Private Sub DaftarPesananStaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        pnlUbahStatus.Hide()
        pnlSpace.Hide()

        koneksi()

        dbdsq("Select e.id_pesanan AS 'ID PESANAN', e.nama AS 'NAMA',
               e.alamat AS 'ALAMAT', r.nama_produk AS 'NAMA PRODUK',
               r.kategori AS 'KATEGORI', e.tanggal_pesanan AS 'TANGGAL DIPESAN',
               e.id_produk AS 'ID PRODUK', e.stok AS 'JUMLAH', 
               e.harga_total AS 'HARGA TOTAL', e.status AS 'STATUS'
               FROM tbpesanan e
               INNER JOIN tbproduk r ON e.id_produk = r.id_produk")

        dgvDaftarPesanan.DataSource = DS.Tables("tb")
        dgvDaftarPesanan.Refresh()
        AturGrid(dgvDaftarPesanan, {0, 0, 0, 340, 150,
                              180, 0, 100, 120,
                              150}, False)

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Apakah Anda yakin ingin keluar dari program?", vbQuestion + vbYesNo, "Konfirmasi Keluar") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        laporanPesananStaf.Show()
    End Sub

    Private Sub dgvDaftarPesanan_DoubleClick(sender As Object, e As EventArgs) Handles dgvDaftarPesanan.DoubleClick
        ShowForm(True)

        'query update status only
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ShowForm(False)
    End Sub


    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'

    '>-- Home

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formStaff.Show()
        Me.Close()
    End Sub

    '>-- Profil Toko

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfilTokoS.Show()
        Me.Close()
    End Sub

    '>-- Pesanan

    Private Sub ManajemenPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenPesananToolStripMenuItem.Click
        DaftarPesananStaf_Load(sender, Nothing)
    End Sub

    '>-- Exit

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        If MsgBox("Apakah Anda yakin ingin logout ?", vbQuestion + vbYesNo, "Konfirmasi Logout") = vbYes Then
            Home.Show()
            Me.Close()
        End If
    End Sub


    ' >-- Manajemen Produk

    Private Sub LihatBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = ""
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub TambahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = "Tambah"
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub UbahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = "Ubah"
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub HapusBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = "Hapus"
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub formStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub

    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'
End Class