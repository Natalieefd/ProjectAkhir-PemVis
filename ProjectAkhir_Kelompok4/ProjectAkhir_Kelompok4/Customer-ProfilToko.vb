Public Class formProfilTokoC

    '-- INI DIBACA, KLO DAH DIKERJAIN APUS LISTNYA --

    '   (yg blom)
    '-------------------------------------------------
    '-- nampili data toko ke txtbox di pnlProfil
    '-- tombol exit bagian hadie
    '-- menuStrip crud pesanan
    '-- SISANYA BISA CEK" LAGI MASING" KLI AJA AKU ADA YG KETINGGALAN NGE-CEK 🙏

    Private Sub formProfilTokoC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub formProfilTokoC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem)
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        formKatalog.Show()
        Me.Hide()
    End Sub

    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click
        formKatalog.Show()
        Me.Hide()
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.Click
        formProfil.Show()
        Me.Hide()
    End Sub
End Class