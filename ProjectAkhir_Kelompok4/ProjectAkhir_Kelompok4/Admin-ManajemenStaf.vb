Public Class ManajemenStaf
    Private Sub ManajemenStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        formAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        ManajemenTokoAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub LihatAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatAkunStaffToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub TambahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAkunStaffToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub UbahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahAkunStaffToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub DeleteAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAkunStaffToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub LihatDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub TambahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub UbahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub HapusDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click
        DaftarPesananAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub ManajemenStaf_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub
End Class