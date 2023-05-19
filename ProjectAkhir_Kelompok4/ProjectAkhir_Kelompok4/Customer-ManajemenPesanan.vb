Public Class formPesananCust

    Public Shared Mode As String = ""
    Public Stok As Integer

    Private Sub formPesananCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        Me.Location = New Point(Me.Location.X, Me.Location.Y + 200)

        pnlFormPesanan.Location = New Point(57, 88)

        koneksi()

        dbdsq("Select tbpesanan.id_pesanan AS 'ID PESANAN', tbpesanan.nama AS 'NAMA',
               tbpesanan.alamat AS 'ALAMAT', tbproduk.nama_produk AS 'NAMA PRODUK',
               tbproduk.kategori AS 'KATEGORI', tbpesanan.tanggal_pesanan AS 'TANGGAL DIPESAN',
               tbpesanan.id_produk AS 'ID PRODUK', tbpesanan.stok AS 'JUMLAH', 
               tbpesanan.harga_total AS 'HARGA TOTAL', tbpesanan.status AS 'STATUS'
               FROM tbpesanan
               INNER JOIN tbproduk ON tbpesanan.id_produk = tbpesanan.id_produk
               Where id_pesanan = '" & ActiveID & "'" +
               If(Mode = "Ubah" Or Mode = "Batal", " and status ='Belum Dibayar'", ""))


        dgvPesanan.DataSource = DS.Tables("tb")
        dgvPesanan.Refresh()
        AturGrid(dgvPesanan, {0, 0, 0, 340, 150,
                              200, 0, 120, 120,
                              120})
        ToggleData()

        lblPS.Show()

        Select Case Mode
            Case "Ubah"
                btnUbah.Visible = True
                btnClear.Visible = True
                btnBatalkan.Visible = False
            Case "Batal"
                btnUbah.Visible = False
                btnClear.Visible = False
                btnBatalkan.Visible = True
            Case Else
                lblPS.Visible = False
        End Select

    End Sub

    Private Sub Reload(sender As Object)
        formPesananCust_Load(sender, Nothing)
        Me.Location = New Point(Me.Location.X, Me.Location.Y - 200)
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
        Mode = "Ubah"
        Reload(sender)
    End Sub

    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem.Click
        Mode = "Lihat"
        Reload(sender)
    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatalkanPesananToolStripMenuItem.Click
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
        Home.Show()
        Me.Close()
    End Sub

    Private Sub formPesananCust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Reload(sender)
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim Con = EmptyTB(pnlFormPesanan)

        If Con IsNot Nothing Then
            Con.Focus()
            Exit Sub
        End If

        If Not CheckNum(txtJumlah) Then
            txtJumlah.Focus()
            Exit Sub
        End If

        dbq("") 'Query ubah pesanan terkait
        RD.Close()

        MsgBox("Pesanan Berhasil Diubah!", MsgBoxStyle.Information, "Perhatian")

        Dim StokBaru = Stok - Val(txtJumlah.Text)

        dbq("")
        'query update stok produk menjadi stokbaru dengan idproduk = DGVValue(dgvPesanan, 6)
        RD.Close()

        formPesananCust_Load(sender, Nothing)

    End Sub

    Private Sub btnBatalkan_Click(sender As Object, e As EventArgs) Handles btnBatalkan.Click
        dbq("") 'query hapus pesanan dengan idpesanan, id-> DGVValue(dgvPesanan, 0)
        RD.Close()

        MsgBox("Berhasil Dihapus!", MsgBoxStyle.Information, "Perhatian")
        formPesananCust_Load(sender, Nothing)
    End Sub

    Private Sub dgvPesanan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesanan.CellContentDoubleClick
        dbq("") 'query cari data produk dengan idproduk, id-> DGVValue(dgvPesanan, 6)

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

            dbq("") 'query ubah pesanan dengan txt di atas
            RD.Close()
            HideData()

        Else
            MsgBox("Produk Dari Pesanan Ini Tidak Ditemukan", MsgBoxStyle.Information, "Perhatian")
            RD.Close()
            dbq("") 'Query hapus pesanan ini dari daftar pesanan'
            RD.Close()
            Reload(sender)
            Exit Sub
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        e.Handled = Numbering(e)

        'If Asc(e.KeyChar) = 48 Then
        'If txtJumlah.Text <> Nothing Then
        'If txtJumlah.Text.First = "0" Then
        'e.Handled = True
        'End If
        'End If
        '
        'e.Handled = True
        'End If
    End Sub

    Private Sub txtJumlah_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJumlah.KeyUp
        If Val(txtJumlah.Text) > Stok Then
            txtJumlah.Text = Stok
        End If

        txtHargaTotal.Text = Val(txtJumlah.Text) * Val(txtHargaSatuan.Text)
    End Sub
End Class