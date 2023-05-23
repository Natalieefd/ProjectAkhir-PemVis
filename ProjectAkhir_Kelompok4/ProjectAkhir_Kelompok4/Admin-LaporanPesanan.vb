Public Class laporanPesananAdmin
    Private Sub laporanPesananAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
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
        ManajemenProdukAdmin.Mode = ""
        Me.ActiveControl = MenuStrip1
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub TambahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Tambah"
        Me.ActiveControl = MenuStrip1
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub UbahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Ubah"
        Me.ActiveControl = MenuStrip1
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub HapusDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Hapus"
        Me.ActiveControl = MenuStrip1
        ManajemenProdukAdmin.Show()
        Me.Close()
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

    Private Sub DaftarPesananAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
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