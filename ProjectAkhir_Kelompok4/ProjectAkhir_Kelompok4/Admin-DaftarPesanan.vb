﻿Public Class DaftarPesananAdmin
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub
End Class