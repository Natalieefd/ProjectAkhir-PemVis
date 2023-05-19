Public Class formKatalog

    Public Stok As Integer
    Public idp As Integer

    Private Sub formKatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        koneksi()

        dbdsq("")
        'query tampil semua katalog yang stoknya lebih dari 0,
        'tampilkan sebagai:
        ' nama_produk -> NAMA PRODUK
        ' kategori -> KATEGORI
        ' stok -> STOK
        ' harga -> HARGA


        dgvKatalog.DataSource = DS.Tables("tb")
        dgvKatalog.Refresh()
        dgvKatalog.Columns(0).Visible = False
        dgvKatalog.Columns(3).Visible = False

        AturGrid(dgvKatalog, {0, 340, 150, 0, 80, 120})

        HideForm()
    End Sub

    Private Sub dgvKatalog_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKatalog.CellDoubleClick
        Dim RowSelect As Integer = dgvKatalog.CurrentCell.RowIndex
        lblPS.Text = dgvKatalog.Rows(RowSelect).Cells(1).Value.ToString

        idp = dgvKatalog.Rows(RowSelect).Cells(0).Value
        txtNamaProduk.Text = dgvKatalog.Rows(RowSelect).Cells(1).Value.ToString
        txtKategori.Text = dgvKatalog.Rows(RowSelect).Cells(2).Value.ToString
        txtDesc.Text = dgvKatalog.Rows(RowSelect).Cells(3).Value.ToString
        Stok = dgvKatalog.Rows(RowSelect).Cells(4).Value
        txtHargaSatuan.Text = dgvKatalog.Rows(RowSelect).Cells(5).Value.ToString
        txtHargaTotal.Text = Val(txtHargaSatuan.Text) * Val(txtJumlah.Text)
        ShowForm()

        'harga total otomatis kehitung klo jumlahnya berubah

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formCustomer.Show()
        Me.Close()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfilTokoC.Show()
        Me.Close()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        formKatalog_Load(sender, Nothing)
    End Sub

    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formPesananCust.Mode = "Lihat"
        formPesananCust.Show()
        Me.Close()
    End Sub

    Private Sub UbahPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formPesananCust.Mode = "Ubah"
        formPesananCust.Show()
        Me.Close()
    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatalkanPesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formPesananCust.Mode = "Hapus"
        formPesananCust.Show()
        Me.Close()
    End Sub

    Private Sub LihatProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LihatProfilToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfil.Mode = ""
        formProfil.Show()
        Me.Close()
    End Sub

    Private Sub UbahProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UbahProfilToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfil.Mode = "Ubah"
        formProfil.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub formKatalog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblPS_Click(sender As Object, e As EventArgs) Handles lblPS.Click
        'hapus nanti
        ShowForm()
    End Sub

    Sub ShowForm()
        lblHeader.Hide()
        dgvKatalog.Hide()
        lblPS.Hide()

        Me.Size = New Point(Me.Size.Width, 573)
        pnlFormPesanan.Show()
        pnlFormPesanan.Location = New Point(pnlFormPesanan.Location.X, 80)
    End Sub

    Sub HideForm()
        lblHeader.Show()
        dgvKatalog.Show()
        lblPS.Show()

        Me.Size = New Point(Me.Size.Width, 477)

        pnlFormPesanan.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Clear()
        txtJumlah.Text = "1"
        txtHargaTotal.Text = Val(txtJumlah.Text) * Val(txtHargaSatuan.Text)
        txtAlamat.Clear()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        HideForm()
    End Sub
End Class