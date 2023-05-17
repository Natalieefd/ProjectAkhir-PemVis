Public Class formProfilTokoS

    '-- INI DIBACA, KLO DAH DIKERJAIN APUS LISTNYA --

    '   (yg blom)
    '-------------------------------------------------
    '-- nampili data toko ke txtbox di pnlProfil
    '-- tombol exit bagian hadie
    '-- menuStrip crud produk
    '-- SISANYA BISA CEK" LAGI MASING" KLI AJA AKU ADA YG KETINGGALAN NGE-CEK 🙏

    Private Sub formProfilTokoS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub formProfilTokoS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem)
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ManajemenBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenBarangToolStripMenuItem.Click
        ManajemenProdukStaf.Show()
        Me.Hide()
    End Sub

    Private Sub ManajemenPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenPesananToolStripMenuItem.Click
        DaftarPesananStaf.Show()
        Me.Hide()
    End Sub
End Class