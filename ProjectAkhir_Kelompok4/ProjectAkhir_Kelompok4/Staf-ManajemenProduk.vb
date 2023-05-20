Public Class ManajemenProdukStaf
    Private Sub ManajemenProdukStaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
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

    Private Sub UbahProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahProdukToolStripMenuItem.Click
        Me.Show()
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