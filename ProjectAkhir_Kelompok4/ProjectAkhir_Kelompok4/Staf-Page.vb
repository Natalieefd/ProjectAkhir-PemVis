﻿Public Class formStaff
    Private Sub formStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        lblUsn.Text = ActiveUsername
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        formProfilTokoS.Show()
        Me.Hide()
    End Sub

    Private Sub ManajemenBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenBarangToolStripMenuItem.Click
        ManajemenProdukStaf.Show()
        Me.Hide()
    End Sub

    Private Sub ManajemenPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenPesananToolStripMenuItem.Click
        DaftarPesananStaf.Show()
        Me.Hide()
    End Sub

    Private Sub formStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, ExitToolStripMenuItem.Owner)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = sender.Owner
        Home.Show()
        Me.Close()
    End Sub
End Class