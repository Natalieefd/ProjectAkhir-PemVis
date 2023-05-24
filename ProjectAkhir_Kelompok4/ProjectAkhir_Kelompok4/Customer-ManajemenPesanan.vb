Public Class formPesananCust

    Public Shared Mode As String = ""
    Public Stok As Integer

    Private Sub formPesananCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(800, 425)

        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        Me.Location = New Point(Me.Location.X, 179)

        pnlFormPesanan.Location = New Point(57, 88)

        koneksi()

        dbdsq("Select e.id_pesanan AS 'ID PESANAN', e.nama AS 'NAMA',
               e.alamat AS 'ALAMAT', r.nama_produk AS 'NAMA PRODUK',
               r.kategori AS 'KATEGORI', e.tanggal_pesanan AS 'TANGGAL DIPESAN',
               e.id_produk AS 'ID PRODUK', e.stok AS 'JUMLAH', 
               e.harga_total AS 'HARGA TOTAL', e.status AS 'STATUS'
               FROM tbpesanan e
               INNER JOIN tbproduk r ON e.id_produk = r.id_produk
               Where id_customer = '" & ActiveID & "'" +
               If(Mode = "Ubah" Or Mode = "Batal", " and status ='Belum Dibayar'", ""))


        dgvPesanan.DataSource = DS.Tables("tb")
        dgvPesanan.Refresh()
        AturGrid(dgvPesanan, {0, 0, 0, 340, 150,
                              180, 0, 100, 120,
                              150}, False)
        ToggleData()

        lblPS.Show()
        txtNama.Enabled = False
        txtJumlah.Enabled = False
        txtAlamat.Enabled = False

        Select Case Mode
            Case "Ubah"
                txtNama.Enabled = True
                txtJumlah.Enabled = True
                txtAlamat.Enabled = True
                btnUbah.Visible = True
                btnClear.Visible = True
                btnBatalkan.Visible = False
            Case "Batal"
                btnUbah.Visible = False
                btnClear.Visible = False
                btnBatalkan.Visible = True
            Case Else
                btnUbah.Visible = False
                btnClear.Visible = False
                btnBatalkan.Visible = False
                lblPS.Visible = False
        End Select

    End Sub

    Private Sub Reload(sender As Object)
        Me.Location = New Point(Me.Location.X, Me.Location.Y - 100)
        formPesananCust_Load(sender, Nothing)
    End Sub

    Private Sub HideData()
        lblHeader.Hide()
        dgvPesanan.Hide()
        lblPS.Hide()

        pnlFormPesanan.Show()
        Me.Size = New Size(820, 530)
    End Sub

    Private Sub ToggleData()
        lblHeader.Show()
        dgvPesanan.Show()
        lblPS.Show()

        pnlFormPesanan.Hide()
        Me.Size = New Size(820, 430)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formCustomer.Show()
        Me.Close()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfilTokoC.Show()
        Me.Close()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formKatalog.Show()
        Me.Close()
    End Sub

    Private Sub UbahPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Mode = "Ubah"
        Reload(sender)
    End Sub

    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Mode = "Lihat"
        Reload(sender)
    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatalkanPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Mode = "Batal"
        Reload(sender)
    End Sub

    Private Sub LihatProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem1.Click
        Me.ActiveControl = MenuStrip1
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub UbahProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UbahProfilToolStripMenuItem1.Click
        Me.ActiveControl = MenuStrip1
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        If MsgBox("Apakah Anda yakin ingin logout ?", vbQuestion + vbYesNo, "Konfirmasi Logout") = vbYes Then
            Home.Show()
            Me.Close()
        End If
    End Sub

    Private Sub formPesananCust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Apakah Anda yakin ingin keluar dari program?", vbQuestion + vbYesNo, "Konfirmasi Keluar") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Clear()
        txtJumlah.Text = "1"
        txtHargaTotal.Text = Val(txtJumlah.Text) * Val(txtHargaSatuan.Text)
        txtAlamat.Clear()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Reload(sender)
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim Con = EmptyTB(pnlFormPesanan)

        If Con IsNot Nothing Then
            Con.Focus()
            Exit Sub
        End If

        If Not CheckNum(txtJumlah) Or txtJumlah.Text = "0" Then
            txtJumlah.Focus()
            Exit Sub
        End If

        dbq("Update tbpesanan set nama = '" & txtNama.Text & "', alamat = '" & txtAlamat.Text & "', 
            stok = '" & txtJumlah.Text & "', harga_total = '" & txtHargaTotal.Text & "' 
            Where id_customer = '" & ActiveID & "'")
        RD.Close()

        MsgBox("Pesanan Berhasil Diubah!", MsgBoxStyle.Information, "Perhatian")

        Dim StokBaru = Stok - Val(txtJumlah.Text)

        dbq("Update tbproduk set stok = '" & StokBaru & "' WHERE id_produk = '" & DGVValue(dgvPesanan, 6) & "'")
        'query update stok produk menjadi stokbaru dengan idproduk = DGVValue(dgvPesanan, 6)
        RD.Close()

        Reload(sender)

    End Sub

    Private Sub btnBatalkan_Click(sender As Object, e As EventArgs) Handles btnBatalkan.Click
        dbq("DELETE FROM tbpesanan WHERE id_pesanan = '" & DGVValue(dgvPesanan, 0) & "'") 'query hapus pesanan dengan idpesanan, id-> DGVValue(dgvPesanan, 0)
        RD.Close()

        MsgBox("Berhasil Dihapus!", MsgBoxStyle.Information, "Perhatian")

        Dim StokBaru = Stok + Val(txtJumlah.Text)

        dbq("Update tbproduk set stok = '" & StokBaru & "' WHERE Id_produk = '" & DGVValue(dgvPesanan, 6) & "'")
        'query update stok produk menjadi stokbaru dengan idproduk = DGVValue(dgvPesanan, 6)
        RD.Close()

        Reload(sender)
    End Sub

    Private Sub dgvPesanan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesanan.CellContentDoubleClick
        Me.Location = New Point(Me.Location.X, 110)

        dbq("Select * from tbproduk where id_produk like '%" & DGVValue(dgvPesanan, 6) & "%'") 'query cari data produk dengan idproduk, id-> DGVValue(dgvPesanan, 6)

        If DGVValue(dgvPesanan, 9) <> "Belum Dibayar" Then
            txtNama.Text = DGVValue(dgvPesanan, 1)
            txtAlamat.Text = DGVValue(dgvPesanan, 2)
            txtNamaProduk.Text = DGVValue(dgvPesanan, 3)
            txtKategori.Text = DGVValue(dgvPesanan, 4)
            txtDesc.Text = If(RD.HasRows, RD(3), "Deskripsi Produk Hilang")
            txtJumlah.Text = DGVValue(dgvPesanan, 7)
            Stok = If(RD.HasRows, RD(4) + Val(txtJumlah.Text), 0)
            txtHargaTotal.Text = DGVValue(dgvPesanan, 8)
            txtHargaSatuan.Text = Int(Val(txtJumlah.Text) / Val(txtHargaSatuan.Text))
            RD.Close()
            HideData()

        ElseIf RD.HasRows Then
            txtNama.Text = DGVValue(dgvPesanan, 1)
            txtAlamat.Text = DGVValue(dgvPesanan, 2)
            txtNamaProduk.Text = RD(1)
            txtKategori.Text = RD(2)
            txtDesc.Text = RD(3)
            txtJumlah.Text = DGVValue(dgvPesanan, 7)
            Stok = RD(4) + Val(txtJumlah.Text)
            txtHargaSatuan.Text = RD(5)
            txtHargaTotal.Text = Val(txtJumlah.Text) * Val(txtHargaSatuan.Text)
            RD.Close()

            dbq("Update tbpesanan set nama = '" & txtNama.Text & "', alamat = '" & txtAlamat.Text & "', 
                stok = '" & txtJumlah.Text & "', harga_total = '" & txtHargaTotal.Text & "' 
                Where id_customer = '" & DGVValue(dgvPesanan, 0) & "'")
            RD.Close()
            HideData()

        Else
            MsgBox("Produk Dari Pesanan Ini Tidak Ditemukan", MsgBoxStyle.Information, "Perhatian")
            RD.Close()
            dbq("Delete From tbpesanan Where id_pesanan = '" & DGVValue(dgvPesanan, 0) & "' ") 'Query hapus pesanan ini dari daftar pesanan'
            RD.Close()
            Reload(sender)
            Exit Sub
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        e.Handled = Numbering(e)

        If txtJumlah.Text = "0" Then
            txtJumlah.Clear()
        End If

        If txtJumlah.Text <> Nothing Then
            txtJumlah.Text = Val(txtJumlah.Text)
        End If
    End Sub

    Private Sub txtJumlah_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJumlah.KeyUp
        If Val(txtJumlah.Text) > Stok Then
            txtJumlah.Text = Stok
        End If

        txtHargaTotal.Text = Val(txtJumlah.Text) * Val(txtHargaSatuan.Text)
    End Sub
End Class