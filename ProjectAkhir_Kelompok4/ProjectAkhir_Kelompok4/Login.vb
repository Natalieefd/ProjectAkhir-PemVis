Public Class formLogin
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Con = EmptyTB()

        If Con IsNot Nothing Then
            Me.ActiveControl = Con
            Exit Sub
        End If

        Dim stats() As String = {"admin", "staff", "customer"}
        Dim loginMode = ""

        For Each mode In stats
            If loginMode <> "" Then
                Exit For
            End If

            dbq("Select * from tb" & mode & " where username='" & txtUsername.Text & "'")

            If RD.HasRows Then
                If txtPassword.Text = If(mode = "admin", RD(1), RD(3)) Then
                    ActiveID = If(mode = "admin", 0, RD(0))
                    ActiveUsername = If(mode = "admin", RD(0), RD(2))
                    loginMode = mode
                End If
            End If

            RD.Close()
        Next

        If loginMode = "" Then
            MsgBox("Username atau Password Salah", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        End If

        Select Case loginMode
            Case "admin"
                formAdmin.Show()
            Case "staff"
                formStaff.Show()
            Case "customer"
                formCustomer.Show()
        End Select

        Me.Close()
    End Sub

    Private Sub formLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, {btnBack, btnSubmit})
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class