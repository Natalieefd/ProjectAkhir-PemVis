Public Class formAdmin

    'lblUsn buat nampilin usn akun

    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
    End Sub

    Private Sub btnManageStaff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnManageBarang_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLihatPesanan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub

    'Menu Strip Manajemen Staff
    Private Sub LihatAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatAkunStaffToolStripMenuItem.Click

    End Sub

    Private Sub TambahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAkunStaffToolStripMenuItem.Click

    End Sub

    Private Sub UbahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahAkunStaffToolStripMenuItem.Click

    End Sub

    Private Sub DeleteAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAkunStaffToolStripMenuItem.Click

    End Sub

    'Menu Strip Manajemen Barang
    Private Sub LihatDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataBarangToolStripMenuItem.Click

    End Sub

    Private Sub TambahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataBarangToolStripMenuItem.Click

    End Sub

    Private Sub UbahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahDataBarangToolStripMenuItem.Click

    End Sub

    Private Sub HapusDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataBarangToolStripMenuItem.Click

    End Sub

    'Menu Lihat Pesanan
    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click

    End Sub
End Class