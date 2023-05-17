Imports MySql.Data.MySqlClient

'-- INI DIBACA, KLO DAH DIKERJAIN APUS LISTNYA --

'   (yg blom)
'-------------------------------------------------
'-- clear txtbox buat ubah profil di pnlFormUbah
'-- nampilin data akun user ke masing" textbox pnlProfil
'-- tombol exit bagian hadie
'-- SISANYA BISA CEK" LAGI MASING" KLI AJA AKU ADA YG KETINGGALAN NGE-CEK 🙏

Public Class formProfil
    Private Sub formPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        pnlFormUbah.Hide()
        pnlPass.Hide()

        Me.Size = New Size(764, 450)
        pnlSpace.Location = New Point(36, 380)
        StatusStrip1.Location = New Point(0, 428)

        txtNama.Enabled = False
        txtUsn.Enabled = False
        txtPass.Enabled = False
        txtNoTelp.Enabled = False
        txtAlamat.Enabled = False
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        pnlProfil.Hide()
        btnUbah.Hide()
        pnlFormUbah.Hide()

        pnlPass.Show()
        pnlPass.Location = New Point(238, 160)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Call checkPass()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        pnlProfil.Show()
        btnUbah.Show()
        pnlPass.Hide()
        pnlFormUbah.Hide()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        formProfilTokoC.Show()
        Me.Hide()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        formKatalog.Show()
        Me.Hide()
    End Sub

    Private Sub PesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesananToolStripMenuItem.Click
        formKatalog.Show()
        Me.Hide()
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub formProfil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem)
    End Sub

    Sub checkPass()
        Dim warn As String

        If txtPass.Text = "" Then
            warn = MessageBox.Show("Mohon isi password terlebih dahulu!", "Konfirmasi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("SELECT * From tbcustomer where password='" & txtPass.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()

            If Not RD.HasRows Then
                pnlProfil.Hide()
                btnUbah.Hide()
                pnlPass.Hide()

                pnlFormUbah.Show()
                pnlFormUbah.Location = New Point(40, 98)

            Else
                warn = MessageBox.Show("Password yang anda masukkan salah!", "Konfirmasi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class