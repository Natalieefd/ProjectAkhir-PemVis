Public Class DaftarPesananStaf
    Private Sub DaftarPesananStaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        ShowForm(False)

        koneksi()

        dbdsq("Select e.id_pesanan AS 'ID PESANAN', e.nama AS 'NAMA',
               e.alamat AS 'ALAMAT', r.nama_produk AS 'NAMA PRODUK',
               r.kategori AS 'KATEGORI', e.tanggal_pesanan AS 'TANGGAL DIPESAN',
               e.id_produk AS 'ID PRODUK', e.stok AS 'JUMLAH', 
               e.harga_total AS 'HARGA TOTAL', e.status AS 'STATUS', c.username
               FROM tbproduk r
               INNER JOIN tbpesanan e ON e.id_produk = r.id_produk
               INNER JOIN tbcustomer c on e.id_customer = c.id_cust")

        dgvDaftarPesanan.DataSource = DS.Tables("tb")
        dgvDaftarPesanan.Refresh()
        AturGrid(dgvDaftarPesanan, {0, 0, 0, 340, 150,
                              180, 0, 100, 120,
                              150, 0}, False)

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
        LaporanPesananStaf.Show()
    End Sub

    Private Sub ShowForm(Optional State = True)
        If State Then
            Size = New Point(Size.Width, 600)
            Label4.Hide()
            dgvDaftarPesanan.Hide()
            btnLaporan.Hide()
            pnlUbahStatus.Show()
            pnlUbahStatus.Location = New Point(40, 85)
            pnlSpace.Show()
            pnlSpace.Location = New Point(40, 530)
        Else
            Size = New Point(Size.Width, 442)
            Label4.Show()
            dgvDaftarPesanan.Show()
            btnLaporan.Show()
            pnlUbahStatus.Hide()
            pnlUbahStatus.Location = New Point(40, 85)
            pnlSpace.Hide()
        End If

    End Sub

    Private Sub dgvDaftarPesanan_DoubleClick(sender As Object, e As EventArgs) Handles dgvDaftarPesanan.DoubleClick
        ShowForm()
        dbq("Select * from tbproduk where id_produk like '%" & DGVValue(dgvDaftarPesanan, 6) & "%'")

        If DGVValue(dgvDaftarPesanan, 9) <> "Belum Dibayar" Then
            txtNama.Text = DGVValue(dgvDaftarPesanan, 1)
            txtAlamat.Text = DGVValue(dgvDaftarPesanan, 2)
            txtNamaProduk.Text = DGVValue(dgvDaftarPesanan, 3)
            txtKategori.Text = DGVValue(dgvDaftarPesanan, 4)
            txtDesc.Text = If(RD.HasRows, RD(3), "Deskripsi Produk Hilang")
            txtJumlah.Text = DGVValue(dgvDaftarPesanan, 7)
            txtHargaTotal.Text = DGVValue(dgvDaftarPesanan, 8)
            txtUsername.Text = DGVValue(dgvDaftarPesanan, 10)
            txtTanggalPesan.Text = DGVValue(dgvDaftarPesanan, 5)
            Select Case DGVValue(dgvDaftarPesanan, 9)
                Case "Belum Dibayar"
                    cmbStatus.SelectedIndex = 0
                Case "Belum Dikirim"
                    cmbStatus.SelectedIndex = 1
                Case "Sudah Dikirim"
                    cmbStatus.SelectedIndex = 2
            End Select
            RD.Close()
            ShowForm()

        ElseIf RD.HasRows Then
            txtNama.Text = DGVValue(dgvDaftarPesanan, 1)
            txtAlamat.Text = DGVValue(dgvDaftarPesanan, 2)
            txtNamaProduk.Text = RD(1)
            txtKategori.Text = RD(2)
            txtDesc.Text = RD(3)
            txtJumlah.Text = DGVValue(dgvDaftarPesanan, 7)
            txtHargaTotal.Text = Val(txtJumlah.Text) * Val(RD(5))
            txtTanggalPesan.Text = DGVValue(dgvDaftarPesanan, 5)
            Select Case DGVValue(dgvDaftarPesanan, 9)
                Case "Belum Dibayar"
                    cmbStatus.SelectedIndex = 0
                Case "Belum Dikirim"
                    cmbStatus.SelectedIndex = 1
                Case "Sudah Dikirim"
                    cmbStatus.SelectedIndex = 2
            End Select
            txtUsername.Text = DGVValue(dgvDaftarPesanan, 10)
            RD.Close()

            dbq("Update tbpesanan set nama = '" & txtNama.Text & "', alamat = '" & txtAlamat.Text & "', 
                stok = '" & txtJumlah.Text & "', harga_total = '" & txtHargaTotal.Text & "' 
                Where id_pesanan = '" & DGVValue(dgvDaftarPesanan, 1) & "'")
            RD.Close()
            ShowForm()

        Else
            MsgBox("Produk Dari Pesanan Ini Tidak Ditemukan", MsgBoxStyle.Information, "Perhatian")
            RD.Close()
            dbq("Delete From tbpesanan Where id_pesanan = '" & DGVValue(dgvDaftarPesanan, 0) & "' ") 'Query hapus pesanan ini dari daftar pesanan'
            RD.Close()
            ShowForm(False)
            Exit Sub
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ShowForm(False)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Status
        Select Case cmbStatus.SelectedIndex
            Case 0
                Status = "Belum Dibayar"
            Case 1
                Status = "Belum Dikirim"
            Case 2
                Status = "Sudah Dikirim"
        End Select

        dbq("") 'query ubah STATUS pesanan dengan id DGVValue(dgvDaftarPesanan, 0)
        RD.Close()

        MsgBox("Status Pesanan Berhasil Diubah!", MsgBoxStyle.Information, "Perhatian")
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
        CloseForm(sender, MenuStrip1)
    End Sub

    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'
End Class