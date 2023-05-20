Public Class ManajemenProdukStaf
    Private Sub ManajemenProdukStaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        ShowForm(False)

        dbdsq("Select id_produk AS 'ID PRODUK', nama_produk AS 'NAMA PRODUK',
               kategori AS 'KATEGORI', deskripsi_produk AS 'DESKRIPSI_PRODUK',
               stok AS 'STOK', harga AS 'HARGA' from tbproduk Where id_produk > 0  ")

        dgvDaftarProduk.DataSource = DS.Tables("tb")
        dgvDaftarProduk.Refresh()
        'AturGrid(dgvDaftarProduk, {0, 340, 150, 0, 80, 120})


        Select Case Mode
            Case "Tambah"
                ShowForm(True)
                btnTambah.Show()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Show()

            Case "Ubah"
                btnTambah.Hide()
                btnUbah.Show()
                btnHapus.Hide()
                btnClear.Show()

            Case "Hapus"
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Show()
                btnClear.Hide()

            Case Else
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Hide()
                txtNama.Enabled = False
                cmbKategori.Enabled = False
                txtHarga.Enabled = False
                txtDecs.Enabled = False
                txtStok.Enabled = False
        End Select



    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        formStaff.Show()
        Me.Hide()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        formProfilTokoS.Show()
        Me.Hide()
    End Sub

    Private Sub LihatProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatProdukToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub TambahProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahProdukToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Con = EmptyTB(pnlFormProduk)

        If Con IsNot Nothing Then
            Con.Focus()
            Exit Sub
        End If

        dbq("SELECT * FROM `tbproduk` WHERE nama_produk = '" & txtNama.Text & "'")
        'query cek produk dengan nama itu udh ada atau ngga

        If RD.HasRows Then
            If MsgBox("Produk Tersebut sudah ada, ubah stok saja?",
                      MsgBoxStyle.YesNo, "Produk Duplikat") = MsgBoxResult.Yes Then
                Dim DupeID = RD(0)
                RD.Close()

                dbq("Update tbproduk set stok = '" & txtStok.Text & "' WHERE Id_produk = '" & idp & "'")
                'query ubah stok Barang dengan ID DupeID
                RD.Close()
                MsgBox("Stok Berhasil Diubah!", MsgBoxStyle.Information, "Perhatian")
            Else
                txtNama.Focus()
                Exit Sub
            End If
        Else
            dbq("Insert Into tbproduk (nama_produk, kategori, deskripsi_produk, stok, harga)
                values('" & txtNama.Text & "','" & cmbKategori.Text & "','" & txtDecs.Text & "',
                '" & txtStok.Text & "','" & txtHarga.Text & "'")
            RD.Close()
            MsgBox("Produk Berhasil Ditambahkan!", MsgBoxStyle.Information, "Perhatian")
        End If

        LihatBarangToolStripMenuItem_Click(sender, Nothing)
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

    Private Sub HapusProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusProdukToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ManajemenPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenPesananToolStripMenuItem.Click
        DaftarPesananStaf.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = sender.Owner
        Home.Show()
        Me.Close()
    End Sub

    Private Sub ManajemenProdukStaf_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub
End Class