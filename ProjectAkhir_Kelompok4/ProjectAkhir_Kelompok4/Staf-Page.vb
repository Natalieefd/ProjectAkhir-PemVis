Public Class formStaff
    Private Sub formStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        lblUsn.Text = ActiveUsername
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'

    '>-- Home

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        formStaff_Load(sender, e)
    End Sub

    '>-- Profil Toko

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfilTokoS.Show()
        Me.Close()
    End Sub

    '>-- Pesanan

    Private Sub ManajemenPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        DaftarPesananStaf.Show()
        Me.Close()
    End Sub

    '>-- Exit

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub


    ' >-- Manajemen Produk

    Private Sub LihatBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = ""
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub TambahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = "Tambah"
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub UbahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = "Ubah"
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub HapusBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusProdukToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenProdukStaf.Mode = "Hapus"
        ManajemenProdukStaf.Show()
        Me.Close()
    End Sub

    Private Sub formStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub

    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'

End Class