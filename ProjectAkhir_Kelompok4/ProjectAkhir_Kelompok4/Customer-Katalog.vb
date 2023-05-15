Public Class formKatalog

    'pas klik menuStrip pesanan(lihat, tamabah, ubah, hapus) menuju ke form Customer-Katalog

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub
End Class