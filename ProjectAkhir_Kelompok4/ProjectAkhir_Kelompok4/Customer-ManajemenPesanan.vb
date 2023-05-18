Public Class formPesananCust
    Private Sub formPesananCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        pnlSpace.Hide()
        pnlFormPesanan.Hide()

    End Sub

    Private Sub dgvPesanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesanan.CellContentClick
        lblHeader.Hide()
        dgvPesanan.Hide()
        lblPS.Hide()

        pnlFormPesanan.Show()
        pnlFormPesanan.Location = New Point(31, 88)
        pnlSpace.Location = New Point(31, 473)

        'enabled semua txtbox kecuali txtJumlah
        'harga total otomatis kehitung klo jumlahnya berubah
        'btnClear buat clear txtJumlah ama txtHargaTotal

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call batal()

        lblHeader.Hide()
        dgvPesanan.Hide()
        lblPS.Hide()

        pnlFormPesanan.Show()
        pnlFormPesanan.Location = New Point(57, 33)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        formCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        formProfilTokoC.Show()
        Me.Hide()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        formKatalog.Show()
        Me.Hide()
    End Sub

    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub BuatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatPesananToolStripMenuItem.Click
        formKatalog.Show()
        Me.Hide()
    End Sub

    Private Sub UbahPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPesananToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatalkanPesananToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub LihatProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem1.Click
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub UbahProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UbahProfilToolStripMenuItem1.Click
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub formPesananCust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem)
    End Sub

    Sub batal()
        txtNama.Clear()
        txtNamaProduk.Clear()
        txtKategori.Clear()
        txtJumlah.Clear()
        txtHargaSatuan.Clear()
        txtDesc.Clear()
        txtAlamat.Clear()
        txtHargaTotal.Clear()
    End Sub
End Class