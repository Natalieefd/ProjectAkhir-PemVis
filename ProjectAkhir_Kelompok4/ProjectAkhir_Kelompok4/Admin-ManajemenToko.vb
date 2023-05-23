Public Class ManajemenTokoAdmin

    Private Sub ManajemenTokoAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        Tripart("Profil")

        dbq("Select nama_toko, no_telp, email, alamat from tbAdmin") 'query cari data admin

        txtNama.Text = RD(0)
        txtNoTelp.Text = RD(1)
        txtEmail.Text = RD(2)
        txtAlamat.Text = RD(3)
        RD.Close()

    End Sub

    Private Sub Tripart(Part As String)
        Select Case Part
            Case "Profil"
                Size = New Point(Size.Width, 460)
                pnlProfil.Show()
                pnlPass.Hide()
                pnlFormUbah.Hide()
            Case "Pass"

                Size = New Point(Size.Width, 350)
                pnlPass.Location = New Point(pnlPass.Location.X, 10)
                txtKonfirmPass.Clear()
                pnlProfil.Hide()
                pnlPass.Show()
                pnlFormUbah.Hide()

            Case "Ubah"
                Size = New Point(Size.Width, 500)
                pnlFormUbah.Location = New Point(pnlFormUbah.Location.X, 80)

                pnlProfil.Hide()
                pnlPass.Hide()
                pnlFormUbah.Show()
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ManajemenTokoAdmin_Load(sender, Nothing)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Con = EmptyTB(pnlPass)

        If Con IsNot Nothing Then
            Con.Focus()
            Exit Sub
        End If

        dbq("SELECT * From tbadmin where password='" & txtKonfirmPass.Text & "'")
        'query tbAdmin where pass = textBlabla

        If RD.HasRows Then
            txtUbahUsn.Text = RD(0)
            txtUbahPass.Text = "(Password Lama)"
            txtUbahNama.Text = RD(2)
            txtUbahNoTelp.Text = RD(3)
            txtUbahEmail.Text = RD(4)
            txtUbahAlamat.Text = RD(5)

            RD.Close()
            Tripart("Ubah")
            Exit Sub
        End If

        RD.Close()
        MessageBox.Show("Password yang Anda masukkan salah!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Tripart("Pass")
    End Sub

    Private Sub btnUbahForm_Click(sender As Object, e As EventArgs) Handles btnUbahForm.Click
        Dim Con = EmptyTB(pnlFormUbah)

        If Con IsNot Nothing Then
            Con.Focus()
            Exit Sub
        End If

        If Not CheckNum(txtUbahNoTelp) Then
            txtUbahNoTelp.Focus()
            Exit Sub
        End If

        Dim Password = txtUbahPass.Text
        Password = If(Password = "(Password Lama)", txtKonfirmPass.Text, Password)

        dbq("Update tbAdmin set username = '" & txtUbahUsn.Text & "', 
            password = '" & Password & "', nama_toko = '" & txtUbahNama.Text & "',
            no_telp = '" & txtUbahNoTelp.Text & "', alamat = '" & txtUbahAlamat.Text & "'
            Where password = '" & Password & "'")
        'query ubah data admin, password gunakan variable password
        RD.Close()

        MessageBox.Show("Berhasil ubah password!", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formAdmin.Show()
        Me.Close()

    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        ManajemenTokoAdmin_Load(sender, Nothing)
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

    Private Sub LihatDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = ""
        Me.ActiveControl = MenuStrip1
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub TambahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Tambah"
        Me.ActiveControl = MenuStrip1
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub UbahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahDataProdukToolStripMenuItem.Click
        ManajemenProdukAdmin.Mode = "Ubah"
        Me.ActiveControl = MenuStrip1
        ManajemenProdukAdmin.Show()
        Me.Close()
    End Sub

    Private Sub HapusDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataProdukToolStripMenuItem.Click
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

    Private Sub formAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub

    '-------------------------------------------------------------------------------------------------------'
    '--------------------------------------- ToolStripMenuItem ---------------------------------------------'
    '-------------------------------------------------------------------------------------------------------'

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Apakah Anda yakin ingin keluar dari program?", vbQuestion + vbYesNo, "Konfirmasi Keluar") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUbahNama.Clear()
        txtUbahNoTelp.Clear()
        txtUbahEmail.Clear()
        txtUbahAlamat.Clear()
        txtUbahUsn.Clear()
        txtUbahPass.Text = "(Password Lama)"
    End Sub
End Class