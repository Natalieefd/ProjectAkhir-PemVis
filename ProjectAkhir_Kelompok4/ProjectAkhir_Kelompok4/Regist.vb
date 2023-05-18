Public Class formRegist
    Private Sub Regist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay
        koneksi()
        Me.ActiveControl = txtNama
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SlabelJam.Text = TimeOfDay
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Con = EmptyTB()

        If Con IsNot Nothing Then
            Me.ActiveControl = Con
            Exit Sub
        End If

        If Not CheckNum(txtNoTelp) Then
            Me.ActiveControl = txtNoTelp
            Warn.Visible = True
            Exit Sub
        End If

        Dim stats() As String = {"admin", "staff", "customer"}
        Dim dup = False

        For Each mode In stats
            If dup Then
                Exit For
            End If

            dbq("Select * from tb" & mode & " where username='" & txtUsername.Text & "'")

            If RD.HasRows Then
                dup = True
            End If

            RD.Close()
        Next

        If dup Then
            MsgBox("Username sudah dipakai", MsgBoxStyle.Information, "Perhatian")
            txtUsername.Focus()
            Exit Sub
        End If

        dbq("INSERT INTO tbcustomer(nama, username, password, no_telp, alamat)values
           ('" & txtNama.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "',
           '" & txtNoTelp.Text & "','" & txtAlamat.Text & "')")
        RD.Close()
        MsgBox("Registrasi Berhasil!", MsgBoxStyle.Information, "Perhatian")

        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub formRegist_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, {btnBack, btnSubmit})
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtUsername.Focus()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNoTelp.Focus()
        End If
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtAlamat.Focus()
        End If

        e.Handled = Numbering(e)
        Warn.Visible = False
    End Sub

    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSubmit.Focus()
            btnSubmit_Click(sender, Nothing)
        End If
    End Sub
End Class