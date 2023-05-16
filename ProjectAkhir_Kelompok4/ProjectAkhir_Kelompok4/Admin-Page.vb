Public Class formAdmin

    'lblUsn buat nampilin usn akun

    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
    End Sub

    Private Sub btnManageStaff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnManageBarang_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLihatPesanan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub
End Class