Public Class ManajemenProdukAdmin

    Public Shared Mode As String
    Public idp As Integer

    Private Sub ManajemenProdukAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        koneksi()

        dbdsq("Select id_produk, nama_produk AS 'NAMA PRODUK', 
               kategori AS 'KATEGORI', deskripsi_produk, stok AS 'STOK',
               harga AS 'HARGA' From tbproduk")

        dgvProduk.DataSource = DS.Tables("tb")
        dgvProduk.Refresh()
        AturGrid(dgvProduk, {0, 340, 150, 0, 80, 120})

        ShowForm(False)

        Select Case Mode
            Case "Tambah"
                btnTambah.Show()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Show()
                btnClear_Click(sender, Nothing)
                txtNama.Enabled = True
                cmbKategori.Enabled = True
                txtStok.Enabled = True
                txtHarga.Enabled = True
                txtDesc.Enabled = True
                btnTambah.Location = New Point(250, 248)
                btnClear.Location = New Point(380, 248)
                ShowForm()

            Case "Ubah"
                btnTambah.Hide()
                btnUbah.Show()
                btnHapus.Hide()
                btnClear.Show()
                txtNama.Enabled = True
                cmbKategori.Enabled = True
                txtStok.Enabled = True
                txtHarga.Enabled = True
                txtDesc.Enabled = True
                btnUbah.Location = New Point(250, 248)
                btnClear.Location = New Point(380, 248)

            Case "Hapus"
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Show()
                btnClear.Hide()
                txtNama.Enabled = False
                cmbKategori.Enabled = False
                txtStok.Enabled = False
                txtHarga.Enabled = False
                txtDesc.Enabled = False
                btnHapus.Location = New Point(320, 248)

            Case Else
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Hide()
                txtNama.Enabled = False
                cmbKategori.Enabled = False
                txtStok.Enabled = False
                txtHarga.Enabled = False
                txtDesc.Enabled = False
        End Select
    End Sub

    Private Sub ShowForm(Optional State = True)
        If State Then
            dgvProduk.Hide()
            pnlFormProduk.Location = New Point(52, 152)
            pnlFormProduk.Show()
            Me.Size = New Point(Me.Size.Width, 530)
            Exit Sub

        End If

        Me.Size = New Point(Me.Size.Width, 430)
        dgvProduk.Show()
        dgvProduk.Location = New Point(52, 165)
        pnlFormProduk.Hide()

    End Sub

    Private Sub dgvProduk_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellDoubleClick
        idp = DGVValue(dgvProduk, 0)
        txtNama.Text = DGVValue(dgvProduk, 1)
        cmbKategori.Text = DGVValue(dgvProduk, 2)
        txtDesc.Text = DGVValue(dgvProduk, 3)
        txtStok.Text = DGVValue(dgvProduk, 4)
        txtHarga.Text = DGVValue(dgvProduk, 5)
        ShowForm(True)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvProduk.Refresh()
        ShowForm(False)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not Condition() Then
            Exit Sub
        End If

        dbq("SELECT * FROM tbproduk WHERE nama_produk = '" & txtNama.Text & "'")
        'query cek produk dengan nama itu udh ada atau ngga

        If RD.HasRows Then
            If MsgBox("Produk Tersebut sudah ada, ubah stok saja?",
                      MsgBoxStyle.YesNo, "Produk Duplikat") = MsgBoxResult.Yes Then
                Dim DupeID = RD(0)
                RD.Close()

                dbq("Update tbproduk set stok = '" & txtStok.Text & "' WHERE Id_produk = '" & DupeID & "'")
                'query ubah stok Barang dengan ID DupeID
                RD.Close()
                MsgBox("Stok Berhasil Diubah!", MsgBoxStyle.Information, "Perhatian")
            Else
                RD.Close()
                txtNama.Focus()
                Exit Sub
            End If
        Else
            RD.Close()
            dbq("Insert Into tbproduk (nama_produk, kategori, deskripsi_produk, stok, harga)
                values('" & txtNama.Text & "','" & cmbKategori.Text & "','" & txtDesc.Text & "',
                '" & txtStok.Text & "','" & txtHarga.Text & "')")
            RD.Close()
            MsgBox("Produk Berhasil Ditambahkan!", MsgBoxStyle.Information, "Perhatian")
        End If

        LihatDataProdukToolStripMenuItem_Click(sender, Nothing)
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        dbq("Update tbproduk set nama_produk = '" & txtNama.Text & "', 
            kategori =  '" & cmbKategori.Text & "', deskripsi_produk =  '" & txtDesc.Text & "',
            stok =  '" & txtStok.Text & "',  harga =  '" & txtHarga.Text & "'
            Where id_produk =  '" & idp & "'") 'query edit produk dengan id idp
        RD.Close()

        MsgBox("Data Produk Berhasil Diubah!", MsgBoxStyle.Information, "Perhatian")
        UbahDataProdukToolStripMenuItem_Click(sender, Nothing)
    End Sub


    Private Function Condition() As Boolean
        Dim Con = EmptyTB()

        If Con IsNot Nothing Then
            Con.Focus()
            Return False
        End If

        If Not CheckNum(txtHarga) Then
            txtHarga.Focus()
            Return False
        End If

        If Not CheckNum(txtStok) Then
            txtStok.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        dbq("Select * from tbpesanan where id_produk = '" & idp & "' AND status = 'Belum Dikirim'")
        'query cari idproduk ini di tbpesanan dengan status 'Belum Dikirim'

        If RD.HasRows Then
            MsgBox("Terdapat pesanan belum dikirim dengan produk ini!
                    Gagal menghapus data produk.", MsgBoxStyle.Exclamation, "Perhatian")
            RD.Close()
            HapusDataProdukToolStripMenuItem_Click(sender, Nothing)
            Exit Sub
        End If
        RD.Close()

        dbq("Delete From tbproduk Where id_produk = '" & idp & "'") 'Hapus Produk ini
        RD.Close()
        dbq("") 'Delete semua data di tbpesanan yang idproduk = idp, dan statusnya belum dibayar
        RD.Close()
        MsgBox("Data Produk Berhasil Dihapus!", MsgBoxStyle.Information, "Perhatian")
        HapusDataProdukToolStripMenuItem_Click(sender, Nothing)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Text = ""
        cmbKategori.Text = ""
        txtStok.Text = ""
        txtHarga.Text = ""
        txtDesc.Text = ""
    End Sub


    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formAdmin.Show()
        Me.Close()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenTokoAdmin.Show()
        Me.Close()
    End Sub

    Private Sub LihatAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatAkunStaffToolStripMenuItem.Click
        ManajemenStaf.Mode = ""
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub TambahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAkunStaffToolStripMenuItem.Click
        ManajemenStaf.Mode = "Tambah"
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub UbahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahAkunStaffToolStripMenuItem.Click
        ManajemenStaf.Mode = "Ubah"
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub DeleteAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAkunStaffToolStripMenuItem.Click
        ManajemenStaf.Mode = "Hapus"
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub LihatDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Mode = ""
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub TambahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Mode = "Tambah"
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub UbahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahDataProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Mode = "Ubah"
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub HapusDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Mode = "Hapus"
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        DaftarPesananAdmin.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        If MsgBox("Apakah Anda yakin ingin logout ?", vbQuestion + vbYesNo, "Konfirmasi Logout") = vbYes Then
            Home.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ManajemenProdukAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
End Class