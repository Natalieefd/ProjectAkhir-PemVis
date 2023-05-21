Imports System.Globalization
Imports System.Xml.Schema

Public Class formKatalog

    Public Stok As Integer
    Public idp As Integer

    Private Sub formKatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        koneksi()


        dbdsq("Select id_produk, nama_produk AS 'NAMA PRODUK', 
               kategori AS 'KATEGORI', deskripsi_produk, stok AS 'STOK',
               harga AS 'HARGA' From tbproduk where stok > 0")

        dgvKatalog.DataSource = DS.Tables("tb")
        dgvKatalog.Refresh()
        AturGrid(dgvKatalog, {0, 340, 150, 0, 80, 120})
        HideForm()
    End Sub

    Private Sub dgvKatalog_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKatalog.CellDoubleClick
        idp = DGVValue(dgvKatalog, 0)
        txtNamaProduk.Text = DGVValue(dgvKatalog, 1).ToString
        txtKategori.Text = DGVValue(dgvKatalog, 2).ToString
        txtDesc.Text = DGVValue(dgvKatalog, 3).ToString
        Stok = DGVValue(dgvKatalog, 4)
        txtHargaSatuan.Text = DGVValue(dgvKatalog, 5).ToString
        txtHargaTotal.Text = Val(txtHargaSatuan.Text) * Val(txtJumlah.Text)
        ShowForm()

        'harga total otomatis kehitung klo jumlahnya berubah

    End Sub

    Private Sub btnAutofill_Click(sender As Object, e As EventArgs) Handles btnAutofill.Click
        AkunSeqID(ActiveID)

        txtNama.Text = RD(1)
        txtAlamat.Text = RD(5)

        RD.Close()
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

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Dim Con = EmptyTB()

        If Con IsNot Nothing Then
            Con.Focus()
            Exit Sub
        End If

        If CheckNum(txtJumlah) = False Or txtJumlah.Text = "0" Then
            txtJumlah.Focus()
            Exit Sub
        End If

        Dim TimeNow As DateTime = DateTime.Now
        Dim TimeFormatSQL As String = TimeNow.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)

        dbq("Insert into tbpesanan (nama, alamat, tanggal_pesanan, id_customer,
            id_produk, stok, status, harga_total) Values('" & txtNama.Text & "','" & txtAlamat.Text &
            "','" & TimeFormatSQL & "','" & ActiveID & "',
            '" & idp & "','" & txtJumlah.Text & "', 'Belum Dibayar','" & txtHargaTotal.Text & "')")

        RD.Close()
        MsgBox("Produk Berhasil Dipesan", MsgBoxStyle.Information, "Perhatian")

        Dim StokBaru = Stok - Val(txtJumlah.Text)
        dbq("Update tbproduk set stok = '" & StokBaru & "' WHERE Id_produk = '" & idp & "'")

        formKatalog_Load(sender, Nothing)
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        e.Handled = Numbering(e)

        If txtJumlah.Text = "0" Then
            txtJumlah.Clear()
        End If

        If txtJumlah.Text <> Nothing Then
            txtJumlah.Text = Val(txtJumlah.Text)
        End If
    End Sub

    Private Sub txtJumlah_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJumlah.KeyUp
        If Val(txtJumlah.Text) > Stok Then
            txtJumlah.Text = Stok
        End If

        txtHargaTotal.Text = Val(txtJumlah.Text) * Val(txtHargaSatuan.Text)
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
End Class