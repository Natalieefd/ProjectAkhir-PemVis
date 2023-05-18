Public Class formKatalog

    Private Sub formKatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        pnlFormPesanan.Hide()
        pnlSpace.Location = New Point(56, 398)

    End Sub

    Private Sub dgvKatalog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKatalog.CellContentClick
        lblHeader.Hide()
        dgvKatalog.Hide()
        lblPS.Hide()

        pnlFormPesanan.Show()
        pnlFormPesanan.Location = New Point(57, 33)

        'enabled semua txtbox kecuali txtJumlah
        'harga total otomatis kehitung klo jumlahnya berubah

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        lblHeader.Show()
        dgvKatalog.Show()
        lblPS.Show()

        pnlFormPesanan.Hide()
        pnlSpace.Location = New Point(56, 398)
    End Sub

    Private Sub HomeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        formCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        formProfilTokoC.Show()
        Me.Hide()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem.Click
        formPesananCust.Show()
        Me.Hide()
    End Sub

    Private Sub BuatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatPesananToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub UbahPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPesananToolStripMenuItem.Click
        formPesananCust.Show()
        Me.Hide()
    End Sub

    Private Sub HapusPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusPesananToolStripMenuItem.Click
        formPesananCust.Show()
        Me.Hide()
    End Sub

    Private Sub LihatProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatProfilToolStripMenuItem.Click
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub UbahProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahProfilToolStripMenuItem.Click
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub formKatalog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub
End Class