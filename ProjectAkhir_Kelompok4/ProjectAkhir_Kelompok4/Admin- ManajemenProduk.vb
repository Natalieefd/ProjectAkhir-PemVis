Public Class ManajemenProdukAdmin

    Public Shared Mode As String


    Private Sub ShowForm(Optional State = True)
        If State Then
            dgvProduk.Hide()
            pnlFormProduk.Location = New Point(52, 152)
            pnlFormProduk.Show()
            Me.Size = New Point(Me.Size.Width, 530)
            Exit Sub

        End If

        Me.Size = New Point(Me.Size.Width, 430)
        dgvProduk.Show()
        Label4.Location = New Point(278, 100)
        dgvProduk.Location = New Point(52, 165)
        pnlFormProduk.Hide()

    End Sub

    Private Sub ManajemenProdukAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        ShowForm(False)

        Select Case Mode
            Case "Tambah"
                ShowForm(True)
                btnTambah.Show()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Show()
                txtNama.Enabled = True
                cmbKategori.Enabled = True
                txtStok.Enabled = True
                txtHarga.Enabled = True
                txtDesc.Enabled = True
                btnTambah.Location = New Point(220, 248)
                btnClear.Location = New Point(350, 248)

            Case "Ubah"
                ShowForm(True)
                btnTambah.Hide()
                btnUbah.Show()
                btnHapus.Hide()
                btnClear.Show()
                txtNama.Enabled = True
                cmbKategori.Enabled = True
                txtStok.Enabled = True
                txtHarga.Enabled = True
                txtDesc.Enabled = True
                btnUbah.Location = New Point(220, 248)
                btnClear.Location = New Point(350, 248)

            Case "Hapus"
                ShowForm(True)
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Show()
                btnClear.Hide()
                txtNama.Enabled = False
                cmbKategori.Enabled = False
                txtStok.Enabled = False
                txtHarga.Enabled = False
                txtDesc.Enabled = False
                btnHapus.Location = New Point(220, 248)

            Case Else
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Hide()
                txtNama.Enabled = False
                cmbKategori.Enabled = False
                txtStok.Enabled = False
                txtHarga.Enabled = False
                txtDesc.Enabled = False

        End Select
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ManajemenProdukAdmin_Load(sender, e)
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        ManajemenTokoAdmin.Show()
        Me.Close()
    End Sub

    Private Sub LihatAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatAkunStaffToolStripMenuItem.Click
        Mode = ""
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub TambahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAkunStaffToolStripMenuItem.Click
        Mode = "Tambah"
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub UbahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahAkunStaffToolStripMenuItem.Click
        Mode = "Ubah"
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub DeleteAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAkunStaffToolStripMenuItem.Click
        Mode = "Hapus"
        Me.ActiveControl = MenuStrip1
        ManajemenStaf.Show()
        Me.Close()
    End Sub

    Private Sub LihatDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataProdukToolStripMenuItem.Click
        Mode = ""
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub TambahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataProdukToolStripMenuItem.Click
        Mode = "Tambah"
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub UbahDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahDataProdukToolStripMenuItem.Click
        Mode = "Ubah"
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub HapusDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataProdukToolStripMenuItem.Click
        Mode = "Hapus"
        ManajemenProdukAdmin_Load(sender, Nothing)
    End Sub

    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        DaftarPesananAdmin.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub ManajemenProdukAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class