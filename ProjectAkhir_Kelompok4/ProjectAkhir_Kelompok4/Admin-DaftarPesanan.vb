Public Class DaftarPesananAdmin
    Private Sub DaftarPesananAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        DaftarPesananAdmin_Load(sender, e)
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        ManajemenTokoAdmin.Show()
        Me.Close()
    End Sub

    Private Sub LihatAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatAkunStaffToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = ""
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub TambahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAkunStaffToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Tambah"
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub UbahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahAkunStaffToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Ubah"
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub DeleteAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAkunStaffToolStripMenuItem.Click
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub LihatDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = ""
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub TambahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Tambah"
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub UbahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Ubah"
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub HapusDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Hapus"
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click
        DaftarPesananAdmin_Load(sender, Nothing)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub DaftarPesananAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class