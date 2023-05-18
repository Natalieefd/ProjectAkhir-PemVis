﻿'-- INI DIBACA, KLO DAH DIKERJAIN APUS LISTNYA --

'   (yg blom)
'-------------------------------------------------
'-- clear txtbox buat ubah profil di pnlFormUbah
'-- nampilin data akun user ke masing" textbox pnlProfil
'-- tombol exit bagian hadie
'-- SISANYA BISA CEK" LAGI MASING" KLI AJA AKU ADA YG KETINGGALAN NGE-CEK 🙏

Public Class formProfil

    Public Shared Mode As String = ""

    Private Sub formProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

        ActiveID = 1

        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        pnlProfil.Show()
        pnlFormUbah.Hide()
        pnlPass.Hide()

        'dbq("") 'query untuk ambil data customer satu ini'

        'txtNama.Text = RD(1)
        'txtUsn.Text = RD(2)
        'txtPass.Text = RD(3)
        'txtNoTelp.Text = RD(4)
        'txtAlamat.Text = RD(5)


        StatusStrip1.Location = New Point(0, 428)
        Me.Size = New Point(Me.Size.Width, 410)

        If Mode = "Ubah" Then
            ModeUbah()
        End If
    End Sub

    Private Sub ModeUbah()
        pnlProfil.Hide()
        pnlFormUbah.Hide()
        Me.Size = New Point(Me.Size.Width, 341)

        txtKonfirmPass.Clear()
        pnlPass.Show()
        pnlPass.Location = New Point(239, 80)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Call checkPass()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs)
        pnlProfil.Show()
        pnlPass.Hide()
        pnlFormUbah.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        formCustomer.Show()
        Me.Close()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        formProfilTokoC.Show()
        Me.Close()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        formKatalog.Show()
        Me.Close()
    End Sub

    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem.Click
        formPesananCust.Show()
        Me.Close()
    End Sub

    Private Sub BuatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatPesananToolStripMenuItem.Click
        formKatalog.Show()
        Me.Close()
    End Sub

    Private Sub UbahPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPesananToolStripMenuItem.Click
        formPesananCust.Show()
        Me.Close()
    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatalkanPesananToolStripMenuItem.Click
        formPesananCust.Show()
        Me.Close()
    End Sub

    Private Sub LihatProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LihatProfilToolStripMenuItem1.Click
        Mode = ""
        Me.formProfil_Load(sender, e)
    End Sub

    Private Sub UbahProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UbahProfilToolStripMenuItem1.Click
        Mode = "Ubah"
        Me.formProfil_Load(sender, e)
    End Sub

    Sub checkPass()
        Dim warn As String

        EmptyTB(pnlPass)

        dbq("SELECT * From tbcustomer where id_cust='" & ActiveID & "' AND password='" & txtKonfirmPass.Text & "'")

        If RD.HasRows Then
            pnlProfil.Hide()
            pnlPass.Hide()

            pnlFormUbah.Show()
            pnlFormUbah.Location = New Point(40, 98)
            Me.Size = New Point(Me.Size.Width, 490)

            txtUbahNama.Text = RD(1)
            txtUbahUsn.Text = RD(2)
            txtUbahPass.Text = "(Password Lama)"
            txtUbahNoTelp.Text = RD(4)
            txtUbahAlamat.Text = RD(5)
        Else
            warn = MessageBox.Show("Password yang anda masukkan salah!", "Konfirmasi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        RD.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub formProfil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUbahNama.Clear()
        txtUbahUsn.Clear()
        txtUbahPass.Text = "(Password Lama)"
        txtUbahNoTelp.Clear()
        txtUbahAlamat.Clear()
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

        If txtUsn.Text <> txtUbahUsn.Text Then
            Dim stats() As String = {"admin", "staff", "customer"}
            Dim dup = False

            For Each Mode In stats
                If dup Then
                    Exit For
                End If

                dbq("Select * from tb" & Mode & " where username='" & txtUbahUsn.Text & "'")

                If RD.HasRows Then
                    dup = True
                End If

                RD.Close()
            Next

            If dup Then
                MsgBox("Username sudah dipakai", MsgBoxStyle.Information, "Perhatian")
                txtUbahUsn.Focus()
                Exit Sub
            End If
        End If

        If txtUbahPass.Text <> "(Password Lama)" Then
            txtKonfirmPass.Text = txtUbahPass.Text
        End If

        dbq("") 'query ubah data customer satu ini  *nb: untuk Pass gunakan txtKonfirmPass
        RD.Close()
        MsgBox("Berhasil Diubah!", MsgBoxStyle.Information, "Perhatian")
    End Sub

    Private Sub txtUbahNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUbahNoTelp.KeyPress
        e.Handled = Numbering(e)
    End Sub
End Class