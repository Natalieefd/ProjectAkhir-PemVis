Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        formRegist.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        formLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
