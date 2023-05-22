Public Class ManajemenStaf

    Public Shared Mode As String


    Private Sub ShowForm(Optional State = True)
        If State Then
            dgvAkunStaf.Hide()
            pnlFormAkun.Location = New Point(147, 108)
            pnlFormAkun.Show()
            Me.Size = New Point(Me.Size.Width, 530)
            Exit Sub

        End If

        Me.Size = New Point(Me.Size.Width, 430)
        dgvAkunStaf.Show()
        pnlFormAkun.Hide()

    End Sub

    Private Sub ManajemenStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        ShowForm(False)

        Select Case Mode
            Case "Tambah"
                ShowForm(True)
                Label4.Hide()
                btnTambah.Show()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Show()
                txtNama.Enabled = True
                txtUsn.Enabled = True
                txtPass.Enabled = True
                btnTambah.Location = New Point(150, 259)
                btnClear.Location = New Point(297, 259)

            Case "Ubah"
                ShowForm(True)
                Label4.Hide()
                btnTambah.Hide()
                btnUbah.Show()
                btnHapus.Hide()
                btnClear.Show()
                txtNama.Enabled = True
                txtUsn.Enabled = True
                txtPass.Enabled = True
                btnUbah.Location = New Point(150, 259)
                btnClear.Location = New Point(297, 259)

            Case "Hapus"
                ShowForm(True)
                Label4.Hide()
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Show()
                btnClear.Hide()
                txtNama.Enabled = False
                txtUsn.Enabled = False
                txtPass.Enabled = False
                btnHapus.Location = New Point(217, 259)

            Case Else
                btnTambah.Hide()
                btnUbah.Hide()
                btnHapus.Hide()
                btnClear.Hide()
                txtNama.Enabled = False
                txtUsn.Enabled = False
                txtPass.Enabled = False


        End Select

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
        Mode = ""
        ManajemenStaff_Load(sender, Nothing)
    End Sub

    Private Sub TambahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAkunStaffToolStripMenuItem.Click
        Mode = "Tambah"
        ManajemenStaff_Load(sender, Nothing)
    End Sub

    Private Sub UbahAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahAkunStaffToolStripMenuItem.Click
        Mode = "Ubah"
        ManajemenStaff_Load(sender, Nothing)
    End Sub

    Private Sub DeleteAkunStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAkunStaffToolStripMenuItem.Click
        Mode = "Hapus"
        ManajemenStaff_Load(sender, Nothing)
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
        Home.Show()
        Me.Close()
    End Sub

    Private Sub ManajemenStaf_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub

End Class