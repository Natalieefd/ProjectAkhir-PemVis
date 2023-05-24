Public Class LaporanPesananStaf

    Private Sub LaporanPesananStaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Apakah Anda ingin kembali ke menu utama ?", vbQuestion + vbYesNo, "Konfirmasi Keluar") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class