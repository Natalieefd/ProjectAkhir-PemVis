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

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        formProfilTokoC.Show()
        Me.Hide()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click
        formPesananCust.Show()
        Me.Hide()
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.Click
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub formKatalog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem)
    End Sub
End Class