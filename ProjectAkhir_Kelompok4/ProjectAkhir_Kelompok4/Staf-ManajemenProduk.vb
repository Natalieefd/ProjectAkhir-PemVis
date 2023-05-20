Public Class ManajemenProdukStaf

    Public Shared Mode = ""
    Public idp As Integer

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

    Private Sub dgvDaftarProduk_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDaftarProduk.CellContentDoubleClick
        idp = DGVValue(dgvDaftarProduk, 0)
        txtNama.Text = DGVValue(dgvDaftarProduk, 1)
        cmbKategori.Text = DGVValue(dgvDaftarProduk, 2)
        txtDecs.Text = DGVValue(dgvDaftarProduk, 3)
        txtStok.Text = DGVValue(dgvDaftarProduk, 4)
        txtHarga.Text = DGVValue(dgvDaftarProduk, 5)

        ShowForm(True)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ShowForm(Optional State = True)
        If State Then
            dgvDaftarProduk.Hide()
            pnlFormProduk.Location = New Point(52, 152)
            pnlFormProduk.Show()
            Me.Size = New Point(Me.Size.Width, 530)

            Exit Sub

        End If

        Me.Size = New Point(Me.Size.Width, 470)
        dgvDaftarProduk.Show()
        pnlFormProduk.Hide()

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

    '>-- Profil Toko

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfilTokoS.Show()
        Me.Close()
    End Sub

    '>-- Pesanan

    Private Sub ManajemenPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        DaftarPesananStaf.Show()
        Me.Close()
    End Sub

    '>-- Exit

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub


    ' >-- Manajemen Produk

    Private Sub LihatBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatProdukToolStripMenuItem.Click
        Mode = ""
        ManajemenProdukStaf_Load(sender, Nothing)
    End Sub

    Private Sub TambahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahProdukToolStripMenuItem.Click
        Mode = "Tambah"
        ManajemenProdukStaf_Load(sender, Nothing)
    End Sub

    Private Sub UbahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahProdukToolStripMenuItem.Click
        Mode = "Ubah"
        ManajemenProdukStaf_Load(sender, Nothing)
    End Sub

    Private Sub HapusBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusProdukToolStripMenuItem.Click
        Mode = "Hapus"
        ManajemenProdukStaf_Load(sender, Nothing)
    End Sub

    Private Sub formStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub


    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'
End Class