Public Class formStaff
    Private Sub formStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub

    'Menu Strip Manajemen Toko
    Private Sub LihatTokoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UbahTokoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    'Menu Strip Manajemen Barang
    Private Sub LihatBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatBarangToolStripMenuItem.Click

    End Sub

    Private Sub TambahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahBarangToolStripMenuItem.Click

    End Sub

    Private Sub UbahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahBarangToolStripMenuItem.Click

    End Sub

    Private Sub HapusBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusBarangToolStripMenuItem.Click

    End Sub

    'Menu Strip Manajemen Pesanan
    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UbahPesananToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class